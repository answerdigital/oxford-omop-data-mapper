using System.Runtime.CompilerServices;
using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Selects the month of the year or null if the date is null.")]
internal class MonthOfYearSelector
{
    private readonly DateTime? _datetime;

    public MonthOfYearSelector(DateTime? datetime)
    {
        _datetime = datetime;
    }

    public int? MonthOfYear => _datetime?.Month;
}