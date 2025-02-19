using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;

namespace OmopTransformerTests.Transformation
{
    [TestClass]
    public class LoggerTests
    {
        private TestLogger<LoggerTests>? _logger;

        [TestInitialize]
        public void Setup()
        {
            _logger = new TestLogger<LoggerTests>();
        }

        [TestMethod]
        [DataRow(1, 2, "1 records are considered invalid. (50%) invalid.")]
        [DataRow(2, 5, "2 records are considered invalid. (40%) invalid.")]
        [DataRow(3, 3, "3 records are considered invalid. (100%) invalid.")]
        [DataRow(1, 100, "1 records are considered invalid. (1%) invalid.")]
        [DataRow(1, 200, "1 records are considered invalid. (0.5%) invalid.")]
        public void LogNonValid_WithInvalidRecords_LogsCorrectFormatString(int invalidCount, int totalCount, string expectedMessage)
        {
            // Arrange
            var records = CreateTestRecords(invalidCount, totalCount);

            // Act
            Logger.LogNonValid(_logger!, records);

            // Assert
            Assert.AreEqual(1, _logger!.LoggedMessages.Count);
            Assert.AreEqual(expectedMessage, _logger.LoggedMessages[0]);
        }

        [TestMethod]
        public void LogNonValid_NoInvalidRecords_DoesNotLog()
        {
            // Arrange
            var records = CreateTestRecords(0, 5);

            // Act
            Logger.LogNonValid(_logger!, records);

            // Assert
            Assert.AreEqual(0, _logger!.LoggedMessages.Count);
        }

        [TestMethod]
        public void LogNonValid_EmptyRecordList_DoesNotLog()
        {
            // Arrange
            var records = new List<TestOmopRecord>();

            // Act
            Logger.LogNonValid(_logger!, records);

            // Assert
            Assert.AreEqual(0, _logger!.LoggedMessages.Count);
        }

        private List<TestOmopRecord> CreateTestRecords(int invalidCount, int totalCount)
        {
            var records = new List<TestOmopRecord>();

            // Add invalid records
            for (int i = 0; i < invalidCount; i++)
            {
                records.Add(new TestOmopRecord { IsValid = false });
            }

            // Add valid records
            for (int i = 0; i < totalCount - invalidCount; i++)
            {
                records.Add(new TestOmopRecord { IsValid = true });
            }

            return records;
        }

        private class TestLogger<T> : ILogger<T>
        {
            public List<string> LoggedMessages { get; } = new List<string>();

            public IDisposable BeginScope<TState>(TState state) where TState : notnull => null!;

            public bool IsEnabled(LogLevel logLevel) => true;

            public void Log<TState>(
                LogLevel logLevel,
                EventId eventId,
                TState state,
                Exception? exception,
                Func<TState, Exception, string> formatter)
            {
                LoggedMessages.Add(formatter(state, exception!));
            }
        }

        private class TestOmopRecord : IOmopRecord<object>
        {
            public object? Source { get; set; }
            public bool IsValid { get; set; }
            public object? SourceObject => null;
            public IEnumerable<string> ValidationErrors => new List<string>();
            public string OmopTargetTypeDescription { get; } = "test";
        }
    }
}