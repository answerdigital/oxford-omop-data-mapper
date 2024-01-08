using System.Globalization;
using CsvHelper;

namespace OmopTransformer.RTDS.Parser;

internal class Rtds2AAttendancesParser(string text)
{
    private readonly string _text = text ?? throw new ArgumentNullException(nameof(text));

    public IEnumerable<Rtds2AAttendances> Parse()
    {
        using var reader = new StringReader(_text);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        csv.Read();
        csv.ReadHeader();

        while (csv.Read())
        {
            if (csv.Parser.Record!.Length != csv.HeaderRecord!.Length) // I have no idea why but one of the rows in one of the files has a missing column.
                continue;

            yield return new Rtds2AAttendances
            {
                ScheduledActivitySer = csv.GetFieldOrNullWhenEmpty("ScheduledActivitySer"),
                ScheduledStartTime = csv.GetFieldOrNullWhenEmpty("ScheduledStartTime"),
                AttributeValue = csv.GetFieldOrNullWhenEmpty("AttributeValue"),
                CourseSer = csv.GetFieldOrNullWhenEmpty("CourseSer"),
                ProcedureCode = csv.GetFieldOrNullWhenEmpty("ProcedureCode"),
                PatientSer = csv.GetFieldOrNullWhenEmpty("PatientSer"),
                ScheduledActivityCode = csv.GetFieldOrNullWhenEmpty("ScheduledActivityCode"),
                Description = csv.GetFieldOrNullWhenEmpty("Description"),
                ActualStartDateTime_s = csv.GetFieldOrNullWhenEmpty("ActualStartDateTime_s"),
                ActualEndDateTime_s = csv.GetFieldOrNullWhenEmpty("ActualEndDateTime_s"),
                Start_date = csv.GetFieldOrNullWhenEmpty("Start_date"),
                End_date = csv.GetFieldOrNullWhenEmpty("End_date")
            };
        }
    }
}