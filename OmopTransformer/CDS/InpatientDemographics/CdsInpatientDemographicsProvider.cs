using System.Data.SqlClient;
using Dapper;

namespace OmopTransformer.CDS.InpatientDemographics;

internal class CdsInpatientDemographicsProvider
{
    public IReadOnlyCollection<CdsInpatientDemographics> GetRecords()
    {
        var sqlConnection = new SqlConnection("Server=1.2.3.4;Database=ORBIT_WHVIEWS;Trusted_Connection=True;encrypt=false");

        sqlConnection.Open();

        return sqlConnection.Query<CdsInpatientDemographics>(File.ReadAllText("CDS/InpatientDemographics/v_CDS_Inpatient_Demographics.sql")).ToList();
    }
}