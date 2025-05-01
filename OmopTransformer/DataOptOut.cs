using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace OmopTransformer;

internal class DataOptOut : IDataOptOut
{
    private readonly ILogger<DataOptOut> _logger;
    private readonly StagingOptions _options;
    private readonly object _loadingLock = new ();

    private AllowedListInternal? _allowedList;

    private int _allowed;
    private int _disallowed;

    public DataOptOut(ILogger<DataOptOut> logger, StagingOptions options)
    {
        _logger = logger;
        _options = options;
    }

    private void EnsureLoaded()
    {
        if (_allowedList != null) 
            return;

        if (string.IsNullOrEmpty(_options.AllowedListNhsNumber))
        {
            _logger.LogInformation("Allowed patient list not supplied. Allowing all patients.");

            _allowedList = AllowedListInternal.CreateAllowAll();
        }
        else
        {
            var stopwatch = Stopwatch.StartNew();

            _allowedList = AllowedListInternal.LoadFromFile(_options.AllowedListNhsNumber!);

            stopwatch.Stop();

            _logger.LogInformation("Loading allowed patient list took {0} seconds. {1} entries loaded.", stopwatch.Elapsed.TotalSeconds, _allowedList.Count);
        }
    }

    public bool PatientAllowed(string? nhsNumber)
    {
        if (string.IsNullOrEmpty(nhsNumber))
            return true;

        nhsNumber = nhsNumber.Trim();

        lock (_loadingLock)
        {
            EnsureLoaded();
        }

        bool isAllowed = _allowedList!.PatientAllowed(nhsNumber);

        if (isAllowed)
        {
            _allowed++;
        }
        else
        {
            _disallowed++;
        }

        return isAllowed;
    }

    public void PrintStats()
    {
        _logger.LogInformation("National Data Opt Out");
        _logger.LogInformation("Allowed count: {0}", _allowed);
        _logger.LogInformation("Opt out count: {0}", _disallowed);
    }

    private class AllowedListInternal
    {
        private readonly Dictionary<string, object>? _allowedNhsNumbers;
        private readonly bool _allowAll;

        private AllowedListInternal(bool allowAll, Dictionary<string, object>? allowedNhsNumbers)
        {
            if (allowAll == false && allowedNhsNumbers == null)
                throw new ArgumentNullException(nameof(allowAll));

            _allowAll = allowAll;
            _allowedNhsNumbers = allowedNhsNumbers;
        }

        public static AllowedListInternal CreateAllowAll() => new(allowAll: true, null);

        public static AllowedListInternal LoadFromFile(string path)
        {
            var allowedPatientNhsNumbers =
                File.ReadAllLines(path)
                    .Distinct()
                    .ToDictionary(
                        keySelector: nhsNumber => nhsNumber,
                        elementSelector: _ => new object());

            return
                new AllowedListInternal(
                    allowAll: false,
                    allowedNhsNumbers: allowedPatientNhsNumbers);
        }

        public int? Count => _allowedNhsNumbers?.Count;

        public bool PatientAllowed(string nhsNumber) => _allowAll || _allowedNhsNumbers!.ContainsKey(nhsNumber);
    }
}

