using System.Globalization;
using CsvHelper;

namespace OmopTransformer.OxfordPrescribing.Staging;

internal class OxfordPrescribingRecordParser : IOxfordPrescribingRecordParser
{
    public IEnumerable<OxfordPrescribingRecord> ReadFile(string path, CancellationToken cancellationToken)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Read();
        csv.ReadHeader();

        while (csv.Read())
        {
            cancellationToken.ThrowIfCancellationRequested();

            yield return new OxfordPrescribingRecord
            {
                patient_identifier_value = csv.GetField<string>("patient_identifier_value").GetTrimmedValueOrNull(),
                EVENT_ID = csv.GetField<string>("EVENT_ID").GetTrimmedValueOrNull(),
                WAREHOUSE_IDENTIFIER = csv.GetField<string>("WAREHOUSE_IDENTIFIER").GetTrimmedValueOrNull(),
                ORDER_ID = csv.GetField<string>("ORDER_ID").GetTrimmedValueOrNull(),
                BEG_DT_TM = csv.GetField<string>("BEG_DT_TM").GetTrimmedValueOrNull(),
                END_DT_TM = csv.GetField<string>("END_DT_TM").GetTrimmedValueOrNull(),
                SCHEDULED_DT_TM = csv.GetField<string>("SCHEDULED_DT_TM").GetTrimmedValueOrNull(),
                VERIFICATION_DT_TM = csv.GetField<string>("VERIFICATION_DT_TM").GetTrimmedValueOrNull(),
                UPDT_DT_TM = csv.GetField<string>("UPDT_DT_TM").GetTrimmedValueOrNull(),
                CURRENT_START_DT_TM = csv.GetField<string>("CURRENT_START_DT_TM").GetTrimmedValueOrNull(),
                PROJECTED_STOP_DT_TM = csv.GetField<string>("PROJECTED_STOP_DT_TM").GetTrimmedValueOrNull(),
                MED_ADMIN_EVENT_ID = csv.GetField<string>("MED_ADMIN_EVENT_ID").GetTrimmedValueOrNull(),
                EVENT_TYPE_DISPLAY = csv.GetField<string>("EVENT_TYPE_DISPLAY").GetTrimmedValueOrNull(),
                REFERENCESTARTDTTM = csv.GetField<string>("REFERENCESTARTDTTM").GetTrimmedValueOrNull(),
                STRENGTHDOSE = csv.GetField<string>("STRENGTHDOSE").GetTrimmedValueOrNull(),
                DIFFINMIN = csv.GetField<string>("DIFFINMIN").GetTrimmedValueOrNull(),
                CONSTANTIND = csv.GetField<string>("CONSTANTIND").GetTrimmedValueOrNull(),
                RXPRIORITY = csv.GetField<string>("RXPRIORITY").GetTrimmedValueOrNull(),
                PHARMORDERTYPE = csv.GetField<string>("PHARMORDERTYPE").GetTrimmedValueOrNull(),
                ADHOCFREQINSTANCE = csv.GetField<string>("ADHOCFREQINSTANCE").GetTrimmedValueOrNull(),
                FREQSCHEDID = csv.GetField<string>("FREQSCHEDID").GetTrimmedValueOrNull(),
                WEIGHT = csv.GetField<string>("WEIGHT").GetTrimmedValueOrNull(),
                DRUGFORM = csv.GetField<string>("DRUGFORM").GetTrimmedValueOrNull(),
                REQSTARTDTTM = csv.GetField<string>("REQSTARTDTTM").GetTrimmedValueOrNull(),
                STRENGTHDOSEUNIT = csv.GetField<string>("STRENGTHDOSEUNIT").GetTrimmedValueOrNull(),
                RXROUTE = csv.GetField<string>("RXROUTE").GetTrimmedValueOrNull(),
                CATALOG_CD = csv.GetField<string>("CATALOG_CD").GetTrimmedValueOrNull(),
                CATALOG = csv.GetField<string>("CATALOG").GetTrimmedValueOrNull(),
                ORDER_MNEMONIC = csv.GetField<string>("ORDER_MNEMONIC").GetTrimmedValueOrNull(),
                ORDER_DETAIL_DISPLAY_LINE = csv.GetField<string>("ORDER_DETAIL_DISPLAY_LINE").GetTrimmedValueOrNull(),
                DEPT_MISC_LINE = csv.GetField<string>("DEPT_MISC_LINE").GetTrimmedValueOrNull(),
                concept_identifier = csv.GetField<string>("concept_identifier").GetTrimmedValueOrNull(),
                concept_name = csv.GetField<string>("concept_name").GetTrimmedValueOrNull(),
                CONCEPT_CKI = csv.GetField<string>("CONCEPT_CKI").GetTrimmedValueOrNull(),
                cki = csv.GetField<string>("cki").GetTrimmedValueOrNull()
            };
        }
    }
}