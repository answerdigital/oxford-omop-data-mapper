using Microsoft.Extensions.Logging;
using OmopTransformer.CDS.ConditionOccurrence;
using OmopTransformer.CDS.Death;
using OmopTransformer.CDS.DrugExposure;
using OmopTransformer.CDS.Person;
using OmopTransformer.CDS.ProcedureOccurrence;
using OmopTransformer.CDS.StructuredAddress;
using OmopTransformer.CDS.UnstructuredAddress;
using OmopTransformer.CDS.VisitDetails;
using OmopTransformer.CDS.VisitOccurrenceWithoutSpell;
using OmopTransformer.CDS.VisitOccurrenceWithSpell;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IVisitOccurrenceRecorder _visitOccurrenceRecorder;
    private readonly IVisitDetailRecorder _visitDetailRecorder;
    private readonly IDeathRecorder _deathRecorder;
    private readonly IProcedureOccurrenceRecorder _procedureOccurrenceRecorder;
    private readonly IDrugExposureRecorder _drugExposureRecorder;
    private readonly ConceptSnomedResolver _conceptSnomedResolver;

    public CdsTransformer(IRecordTransformer recordTransformer,
        ILogger<IRecordTransformer> logger,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IConditionOccurrenceRecorder conditionOccurrenceRecorder,
        IVisitOccurrenceRecorder visitOccurrenceRecorder,
        IVisitDetailRecorder visitDetailRecorder,
        IDeathRecorder deathRecorder,
        IProcedureOccurrenceRecorder procedureOccurrenceRecorder, 
        ConceptSnomedResolver conceptSnomedResolver, 
        IDrugExposureRecorder drugExposureRecorder) : base(recordTransformer,
        logger,
        transformOptions,
        recordProvider,
        "CDS")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _visitOccurrenceRecorder = visitOccurrenceRecorder;
        _visitDetailRecorder = visitDetailRecorder;
        _deathRecorder = deathRecorder;
        _procedureOccurrenceRecorder = procedureOccurrenceRecorder;
        _conceptSnomedResolver = conceptSnomedResolver;
        _drugExposureRecorder = drugExposureRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CdsPersonRecord, CdsPerson>(
            _personRecorder.InsertUpdatePersons,
            "CDS Person",
            cancellationToken);

        await Transform<CdsStructuredAddress, CdsStructuredLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Structured Address",
            cancellationToken);

        await Transform<CdsUnstructuredAddress, CdsUnstructuredLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Unstructured Address",
            cancellationToken);

        await Transform<CdsConditionOccurrenceRecord, CdsConditionOccurrence>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "CDS Condition Occurrences",
            cancellationToken);

        await Transform<CdsVisitOccurrenceWithSpellRecord, CdsVisitOccurrenceWithSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "CDS VisitOccurrenceWithSpell",
            cancellationToken);

        await Transform<CdsVisitOccurrenceWithoutSpellRecord, CdsVisitOccurrenceWithoutSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "CDS VisitOccurrenceWithoutSpell",
            cancellationToken);

        await Transform<CdsVisitDetailsRecord, CdsVisitDetail>(
            _visitDetailRecorder.InsertUpdateVisitDetail,
            "CDS VisitDetail",
            cancellationToken);

        await Transform<CdsDeathRecord, CdsDeath>(
            _deathRecorder.InsertUpdateDeaths,
            "CDS Death",
            cancellationToken);

        await Transform<CdsProcedureOccurrenceRecord, CdsProcedureOccurrence>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "CDS Procedure Occurrence",
            cancellationToken);

        await Transform<CdsDrugExposureRecord, CdsDrugExposure>(
            _drugExposureRecorder.InsertUpdateDrugExposure,
            "CDS Drug Exposure",
            cancellationToken);

        _conceptSnomedResolver.PrintErrors();
    }
}