using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Oxford Prescribing data to RxNorm Concept ID Mapping")]
internal class RxNormLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "ajmaline", new ValueWithNote("19105879", "ajmaline") },
//             { "ajmaline", new ValueWithNote("19105879", "ajmaline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "albumin human", new ValueWithNote("1344143", "albumin human, USP") },
//             { "albumin human", new ValueWithNote("1344143", "albumin human, USP") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ALFentanil", new ValueWithNote("19059528", "alfentanil") },
//             { "ALFentanil", new ValueWithNote("19059528", "alfentanil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acamprosate", new ValueWithNote("19043959", "acamprosate") },
//             { "acamprosate", new ValueWithNote("19043959", "acamprosate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acarbose", new ValueWithNote("1529331", "acarbose") },
//             { "acarbose", new ValueWithNote("1529331", "acarbose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amitriptyline", new ValueWithNote("710062", "amitriptyline") },
//             { "amitriptyline", new ValueWithNote("710062", "amitriptyline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amphotericin B liposomal", new ValueWithNote("19056402", "amphotericin B liposomal") },
//             { "amphotericin B liposomal", new ValueWithNote("19056402", "amphotericin B liposomal") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acetarsol", new ValueWithNote("44012478", "Acetarsol") },
//             { "acetarsol", new ValueWithNote("44012478", "Acetarsol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acetaZOLamide", new ValueWithNote("929435", "acetazolamide") },
//             { "acetaZOLamide", new ValueWithNote("929435", "acetazolamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "antithymocyte immunoglobulin (rabbit)", new ValueWithNote("19003472", "rabbit anti-human T-lymphocyte globulin") },
//             { "antithymocyte immunoglobulin (rabbit)", new ValueWithNote("19003472", "rabbit anti-human T-lymphocyte globulin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aceclofenac", new ValueWithNote("19029393", "aceclofenac") },
//             { "aceclofenac", new ValueWithNote("19029393", "aceclofenac") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "abatacept", new ValueWithNote("1186087", "abatacept") },
//             { "abatacept", new ValueWithNote("1186087", "abatacept") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acebutolol", new ValueWithNote("1319998", "acebutolol") },
//             { "acebutolol", new ValueWithNote("1319998", "acebutolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "adenosine", new ValueWithNote("1309204", "adenosine") },
//             { "adenosine", new ValueWithNote("1309204", "adenosine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "abacavir", new ValueWithNote("1736971", "abacavir") },
//             { "abacavir", new ValueWithNote("1736971", "abacavir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "abacavir/dolutegravir/lamiVUDine", new ValueWithNote("36029673", "abacavir / dolutegravir / lamivudine") },
//             { "abacavir/dolutegravir/lamiVUDine", new ValueWithNote("36029673", "abacavir / dolutegravir / lamivudine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "apomorphine", new ValueWithNote("837027", "apomorphine") },
//             { "apomorphine", new ValueWithNote("837027", "apomorphine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aprepitant", new ValueWithNote("936748", "aprepitant") },
//             { "aprepitant", new ValueWithNote("936748", "aprepitant") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "adapalene", new ValueWithNote("981774", "adapalene") },
//             { "adapalene", new ValueWithNote("981774", "adapalene") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aliskiren", new ValueWithNote("1317967", "aliskiren") },
//             { "aliskiren", new ValueWithNote("1317967", "aliskiren") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "AMIODarone", new ValueWithNote("1309944", "amiodarone") },
//             { "AMIODarone", new ValueWithNote("1309944", "amiodarone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amikacin", new ValueWithNote("1790868", "amikacin") },
//             { "amikacin", new ValueWithNote("1790868", "amikacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aminophylline", new ValueWithNote("1105775", "aminophylline") },
//             { "aminophylline", new ValueWithNote("1105775", "aminophylline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atomoxetine", new ValueWithNote("742185", "atomoxetine") },
//             { "atomoxetine", new ValueWithNote("742185", "atomoxetine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acitretin", new ValueWithNote("929638", "acitretin") },
//             { "acitretin", new ValueWithNote("929638", "acitretin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acrivastine", new ValueWithNote("1140123", "acrivastine") },
//             { "acrivastine", new ValueWithNote("1140123", "acrivastine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Albutrepenonacog alfa", new ValueWithNote("35606573", "albutrepenonacog alfa") },
//             { "Albutrepenonacog alfa", new ValueWithNote("35606573", "albutrepenonacog alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alginate", new ValueWithNote("43013872", "alginate") },
//             { "alginate", new ValueWithNote("43013872", "alginate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alimemazine", new ValueWithNote("19005570", "trimeprazine") },
//             { "alimemazine", new ValueWithNote("19005570", "trimeprazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alverine", new ValueWithNote("19030751", "alverine") },
//             { "alverine", new ValueWithNote("19030751", "alverine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "albendazole", new ValueWithNote("1753745", "albendazole") },
//             { "albendazole", new ValueWithNote("1753745", "albendazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alfuzosin", new ValueWithNote("930021", "alfuzosin") },
//             { "alfuzosin", new ValueWithNote("930021", "alfuzosin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amisulpride", new ValueWithNote("19057607", "amisulpride") },
//             { "amisulpride", new ValueWithNote("19057607", "amisulpride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "apalutamide", new ValueWithNote("963987", "apalutamide") },
//             { "apalutamide", new ValueWithNote("963987", "apalutamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Almitrine", new ValueWithNote("19113052", "almitrine") },
//             { "Almitrine", new ValueWithNote("19113052", "almitrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alogliptin", new ValueWithNote("43013884", "alogliptin") },
//             { "alogliptin", new ValueWithNote("43013884", "alogliptin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atazanavir", new ValueWithNote("1727223", "atazanavir") },
//             { "atazanavir", new ValueWithNote("1727223", "atazanavir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "anastrozole", new ValueWithNote("1348265", "anastrozole") },
//             { "anastrozole", new ValueWithNote("1348265", "anastrozole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "artesunate", new ValueWithNote("19018511", "artesunate") },
//             { "artesunate", new ValueWithNote("19018511", "artesunate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aminolevulinic acid", new ValueWithNote("904351", "aminolevulinic acid") },
//             { "aminolevulinic acid", new ValueWithNote("904351", "aminolevulinic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "AXitinib", new ValueWithNote("42709322", "axitinib") },
//             { "AXitinib", new ValueWithNote("42709322", "axitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alitretinoin", new ValueWithNote("941052", "alitretinoin") },
//             { "alitretinoin", new ValueWithNote("941052", "alitretinoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ALLOPurinol", new ValueWithNote("1167322", "allopurinol") },
//             { "ALLOPurinol", new ValueWithNote("1167322", "allopurinol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amorolfine", new ValueWithNote("19032619", "amorolfine") },
//             { "amorolfine", new ValueWithNote("19032619", "amorolfine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amoxicillin", new ValueWithNote("1713332", "amoxicillin") },
//             { "amoxicillin", new ValueWithNote("1713332", "amoxicillin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aztreonam", new ValueWithNote("1715117", "aztreonam") },
//             { "aztreonam", new ValueWithNote("1715117", "aztreonam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alendronic acid", new ValueWithNote("19055729", "alendronic acid") },
//             { "alendronic acid", new ValueWithNote("19055729", "alendronic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alirocumab", new ValueWithNote("46275447", "alirocumab") },
//             { "alirocumab", new ValueWithNote("46275447", "alirocumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atenolol", new ValueWithNote("1314002", "atenolol") },
//             { "atenolol", new ValueWithNote("1314002", "atenolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aluminium hydroxide", new ValueWithNote("985247", "aluminum hydroxide") },
//             { "aluminium hydroxide", new ValueWithNote("985247", "aluminum hydroxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amlitelimab", new ValueWithNote("1254461", "Amlitelimab") },
//             { "amlitelimab", new ValueWithNote("1254461", "Amlitelimab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Arachis oil", new ValueWithNote("19033278", "peanut oil") },
//             { "Arachis oil", new ValueWithNote("19033278", "peanut oil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "almotriptan", new ValueWithNote("1103552", "almotriptan") },
//             { "almotriptan", new ValueWithNote("1103552", "almotriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aluminium chloride", new ValueWithNote("957393", "aluminum chloride") },
//             { "aluminium chloride", new ValueWithNote("957393", "aluminum chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "anagrelide", new ValueWithNote("1381253", "anagrelide") },
//             { "anagrelide", new ValueWithNote("1381253", "anagrelide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "apixaban", new ValueWithNote("43013024", "apixaban") },
//             { "apixaban", new ValueWithNote("43013024", "apixaban") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atovaquone", new ValueWithNote("1781733", "atovaquone") },
//             { "atovaquone", new ValueWithNote("1781733", "atovaquone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "avacopan", new ValueWithNote("702027", "avacopan") },
//             { "avacopan", new ValueWithNote("702027", "avacopan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atorvastatin", new ValueWithNote("1545958", "atorvastatin") },
//             { "atorvastatin", new ValueWithNote("1545958", "atorvastatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atropine", new ValueWithNote("914335", "atropine") },
//             { "atropine", new ValueWithNote("914335", "atropine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "BARICitinib", new ValueWithNote("1510627", "baricitinib") },
//             { "BARICitinib", new ValueWithNote("1510627", "baricitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "azaTHIOprine", new ValueWithNote("19014878", "azathioprine") },
//             { "azaTHIOprine", new ValueWithNote("19014878", "azathioprine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "baclofen", new ValueWithNote("715233", "baclofen") },
//             { "baclofen", new ValueWithNote("715233", "baclofen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcitonin", new ValueWithNote("42900359", "calcitonin") },
//             { "calcitonin", new ValueWithNote("42900359", "calcitonin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcium gluconate", new ValueWithNote("19037038", "calcium gluconate") },
//             { "calcium gluconate", new ValueWithNote("19037038", "calcium gluconate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "barium", new ValueWithNote("42898624", "barium") },
//             { "barium", new ValueWithNote("42898624", "barium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bedaquiline", new ValueWithNote("43012518", "bedaquiline") },
//             { "bedaquiline", new ValueWithNote("43012518", "bedaquiline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefaLEXin", new ValueWithNote("1786621", "cephalexin") },
//             { "cefaLEXin", new ValueWithNote("1786621", "cephalexin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefepime", new ValueWithNote("1748975", "cefepime") },
//             { "cefepime", new ValueWithNote("1748975", "cefepime") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "belumosudil", new ValueWithNote("701423", "belumosudil") },
//             { "belumosudil", new ValueWithNote("701423", "belumosudil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benzoyl peroxide", new ValueWithNote("918172", "benzoyl peroxide") },
//             { "benzoyl peroxide", new ValueWithNote("918172", "benzoyl peroxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "betahistine", new ValueWithNote("19020124", "betahistine") },
//             { "betahistine", new ValueWithNote("19020124", "betahistine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefOTAXime", new ValueWithNote("1774470", "cefotaxime") },
//             { "cefOTAXime", new ValueWithNote("1774470", "cefotaxime") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefUROXime", new ValueWithNote("1778162", "cefuroxime") },
//             { "cefUROXime", new ValueWithNote("1778162", "cefuroxime") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bicalutamide", new ValueWithNote("1344381", "bicalutamide") },
//             { "bicalutamide", new ValueWithNote("1344381", "bicalutamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amantadine", new ValueWithNote("19087090", "amantadine") },
//             { "amantadine", new ValueWithNote("19087090", "amantadine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amidotrizoate", new ValueWithNote("19022596", "diatrizoate") },
//             { "amidotrizoate", new ValueWithNote("19022596", "diatrizoate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chlorothiazide", new ValueWithNote("992590", "chlorothiazide") },
//             { "chlorothiazide", new ValueWithNote("992590", "chlorothiazide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bezafibrate", new ValueWithNote("19022956", "bezafibrate") },
//             { "bezafibrate", new ValueWithNote("19022956", "bezafibrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bisoPROLOL", new ValueWithNote("1338005", "bisoprolol") },
//             { "bisoPROLOL", new ValueWithNote("1338005", "bisoprolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "abiraterone", new ValueWithNote("40239056", "abiraterone") },
//             { "abiraterone", new ValueWithNote("40239056", "abiraterone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acenocoumarol", new ValueWithNote("19024063", "acenocoumarol") },
//             { "acenocoumarol", new ValueWithNote("19024063", "acenocoumarol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Bleomycin", new ValueWithNote("1329241", "bleomycin") },
//             { "Bleomycin", new ValueWithNote("1329241", "bleomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "botulinum toxin type A", new ValueWithNote("729855", "botulinum toxin type A") },
//             { "botulinum toxin type A", new ValueWithNote("729855", "botulinum toxin type A") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aMILoride", new ValueWithNote("991382", "amiloride") },
//             { "aMILoride", new ValueWithNote("991382", "amiloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amobarbital", new ValueWithNote("712757", "amobarbital") },
//             { "amobarbital", new ValueWithNote("712757", "amobarbital") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bromocriptine", new ValueWithNote("730548", "bromocriptine") },
//             { "bromocriptine", new ValueWithNote("730548", "bromocriptine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bambuterol", new ValueWithNote("19034275", "bambuterol") },
//             { "bambuterol", new ValueWithNote("19034275", "bambuterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ascorbic acid", new ValueWithNote("19011773", "ascorbic acid") },
//             { "ascorbic acid", new ValueWithNote("19011773", "ascorbic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aspirin", new ValueWithNote("1112807", "aspirin") },
//             { "aspirin", new ValueWithNote("1112807", "aspirin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "anakinra", new ValueWithNote("1114375", "anakinra") },
//             { "anakinra", new ValueWithNote("1114375", "anakinra") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "arginine", new ValueWithNote("19006410", "arginine") },
//             { "arginine", new ValueWithNote("19006410", "arginine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "avatrombopag", new ValueWithNote("1510483", "avatrombopag") },
//             { "avatrombopag", new ValueWithNote("1510483", "avatrombopag") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ARIPiprazole", new ValueWithNote("757688", "aripiprazole") },
//             { "ARIPiprazole", new ValueWithNote("757688", "aripiprazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "belimumab", new ValueWithNote("40236987", "belimumab") },
//             { "belimumab", new ValueWithNote("40236987", "belimumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benzalkonium chloride", new ValueWithNote("19011436", "benzalkonium chloride") },
//             { "benzalkonium chloride", new ValueWithNote("19011436", "benzalkonium chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "azithromycin", new ValueWithNote("1734104", "azithromycin") },
//             { "azithromycin", new ValueWithNote("1734104", "azithromycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cimetidine", new ValueWithNote("997276", "cimetidine") },
//             { "cimetidine", new ValueWithNote("997276", "cimetidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ciprofibrate", new ValueWithNote("19050375", "ciprofibrate") },
//             { "ciprofibrate", new ValueWithNote("19050375", "ciprofibrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cabotegravir", new ValueWithNote("739588", "cabotegravir") },
//             { "cabotegravir", new ValueWithNote("739588", "cabotegravir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcium carbonate", new ValueWithNote("19035704", "calcium carbonate") },
//             { "calcium carbonate", new ValueWithNote("19035704", "calcium carbonate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "balsalazide", new ValueWithNote("934262", "balsalazide") },
//             { "balsalazide", new ValueWithNote("934262", "balsalazide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "captopril", new ValueWithNote("1340128", "captopril") },
//             { "captopril", new ValueWithNote("1340128", "captopril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Casirivimab", new ValueWithNote("37003288", "casirivimab") },
//             { "Casirivimab", new ValueWithNote("37003288", "casirivimab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cisatracurium", new ValueWithNote("19015726", "cisatracurium") },
//             { "cisatracurium", new ValueWithNote("19015726", "cisatracurium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ceFIXime", new ValueWithNote("1796435", "cefixime") },
//             { "ceFIXime", new ValueWithNote("1796435", "cefixime") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefTAZIDime", new ValueWithNote("1776684", "ceftazidime") },
//             { "cefTAZIDime", new ValueWithNote("1776684", "ceftazidime") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benzbromarone", new ValueWithNote("19016754", "benzbromarone") },
//             { "benzbromarone", new ValueWithNote("19016754", "benzbromarone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "axatilimab", new ValueWithNote("1735157", "axatilimab") },
//             { "axatilimab", new ValueWithNote("1735157", "axatilimab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "azilsartan", new ValueWithNote("40235485", "azilsartan") },
//             { "azilsartan", new ValueWithNote("40235485", "azilsartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clobazam", new ValueWithNote("19050832", "clobazam") },
//             { "clobazam", new ValueWithNote("19050832", "clobazam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clodronic acid", new ValueWithNote("19024249", "clodronic acid") },
//             { "clodronic acid", new ValueWithNote("19024249", "clodronic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bendroflumethiazide", new ValueWithNote("1316354", "bendroflumethiazide") },
//             { "bendroflumethiazide", new ValueWithNote("1316354", "bendroflumethiazide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bevacizumab", new ValueWithNote("1397141", "bevacizumab") },
//             { "bevacizumab", new ValueWithNote("1397141", "bevacizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "biotin", new ValueWithNote("19024770", "biotin") },
//             { "biotin", new ValueWithNote("19024770", "biotin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cloNIDine", new ValueWithNote("1398937", "clonidine") },
//             { "cloNIDine", new ValueWithNote("1398937", "clonidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "brivaracetam", new ValueWithNote("35604901", "brivaracetam") },
//             { "brivaracetam", new ValueWithNote("35604901", "brivaracetam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benzydamine", new ValueWithNote("19019620", "benzydamine") },
//             { "benzydamine", new ValueWithNote("19019620", "benzydamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chorionic gonadotrophin", new ValueWithNote("1563600", "chorionic gonadotropin") },
//             { "chorionic gonadotrophin", new ValueWithNote("1563600", "chorionic gonadotropin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bromazepam", new ValueWithNote("19030353", "bromazepam") },
//             { "bromazepam", new ValueWithNote("19030353", "bromazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "budesonide", new ValueWithNote("939259", "budesonide") },
//             { "budesonide", new ValueWithNote("939259", "budesonide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "citric acid", new ValueWithNote("950435", "citric acid") },
//             { "citric acid", new ValueWithNote("950435", "citric acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcitriol", new ValueWithNote("19035631", "calcitriol") },
//             { "calcitriol", new ValueWithNote("19035631", "calcitriol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "caffeine", new ValueWithNote("1134439", "caffeine") },
//             { "caffeine", new ValueWithNote("1134439", "caffeine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "basiliximab", new ValueWithNote("19038440", "basiliximab") },
//             { "basiliximab", new ValueWithNote("19038440", "basiliximab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bisaCODYL", new ValueWithNote("924939", "bisacodyl") },
//             { "bisaCODYL", new ValueWithNote("924939", "bisacodyl") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benralizumab", new ValueWithNote("792993", "benralizumab") },
//             { "benralizumab", new ValueWithNote("792993", "benralizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcium lactate", new ValueWithNote("19058896", "calcium lactate") },
//             { "calcium lactate", new ValueWithNote("19058896", "calcium lactate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "caNAKinumab", new ValueWithNote("40161669", "canakinumab") },
//             { "caNAKinumab", new ValueWithNote("40161669", "canakinumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benzathine benzylpenicillin", new ValueWithNote("19130393", "penicillin G benzathine") },
//             { "benzathine benzylpenicillin", new ValueWithNote("19130393", "penicillin G benzathine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "betamethasone", new ValueWithNote("920458", "betamethasone") },
//             { "betamethasone", new ValueWithNote("920458", "betamethasone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "BUPivacaine", new ValueWithNote("732893", "bupivacaine") },
//             { "BUPivacaine", new ValueWithNote("732893", "bupivacaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cabergoline", new ValueWithNote("1558471", "cabergoline") },
//             { "cabergoline", new ValueWithNote("1558471", "cabergoline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cannabidiol", new ValueWithNote("1510417", "cannabidiol") },
//             { "cannabidiol", new ValueWithNote("1510417", "cannabidiol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "capecitabine", new ValueWithNote("1337620", "capecitabine") },
//             { "capecitabine", new ValueWithNote("1337620", "capecitabine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carbidopa/entacapone/levodopa", new ValueWithNote("36030184", "carbidopa / entacapone / levodopa") },
//             { "carbidopa/entacapone/levodopa", new ValueWithNote("36030184", "carbidopa / entacapone / levodopa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carbocisteine", new ValueWithNote("19041843", "carbocysteine") },
//             { "carbocisteine", new ValueWithNote("19041843", "carbocysteine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carglumic acid", new ValueWithNote("19102150", "carglumic acid") },
//             { "carglumic acid", new ValueWithNote("19102150", "carglumic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefTRIAXONE", new ValueWithNote("1777806", "ceftriaxone") },
//             { "cefTRIAXONE", new ValueWithNote("1777806", "ceftriaxone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bumetanide", new ValueWithNote("932745", "bumetanide") },
//             { "bumetanide", new ValueWithNote("932745", "bumetanide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "buPROPion", new ValueWithNote("750982", "bupropion") },
//             { "buPROPion", new ValueWithNote("750982", "bupropion") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clindamycin", new ValueWithNote("997881", "clindamycin") },
//             { "clindamycin", new ValueWithNote("997881", "clindamycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clobetasol", new ValueWithNote("998415", "clobetasol") },
//             { "clobetasol", new ValueWithNote("998415", "clobetasol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "busPIRone", new ValueWithNote("733301", "buspirone") },
//             { "busPIRone", new ValueWithNote("733301", "buspirone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calamine", new ValueWithNote("902616", "calamine") },
//             { "calamine", new ValueWithNote("902616", "calamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "caPLAcizumab", new ValueWithNote("1366428", "caplacizumab") },
//             { "caPLAcizumab", new ValueWithNote("1366428", "caplacizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carBIMazole", new ValueWithNote("19040606", "carbimazole") },
//             { "carBIMazole", new ValueWithNote("19040606", "carbimazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "buprenorphine", new ValueWithNote("1133201", "buprenorphine") },
//             { "buprenorphine", new ValueWithNote("1133201", "buprenorphine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "C1 esterase inhibitor", new ValueWithNote("45892906", "C1 esterase inhibitor") },
//             { "C1 esterase inhibitor", new ValueWithNote("45892906", "C1 esterase inhibitor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcipotriol", new ValueWithNote("908921", "calcipotriene") },
//             { "calcipotriol", new ValueWithNote("908921", "calcipotriene") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "coal tar", new ValueWithNote("1000995", "coal tar") },
//             { "coal tar", new ValueWithNote("1000995", "coal tar") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefazolin", new ValueWithNote("1771162", "cefazolin") },
//             { "cefazolin", new ValueWithNote("1771162", "cefazolin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chlortalidone", new ValueWithNote("1395058", "chlorthalidone") },
//             { "chlortalidone", new ValueWithNote("1395058", "chlorthalidone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cinnarizine", new ValueWithNote("19097481", "cinnarizine") },
//             { "cinnarizine", new ValueWithNote("19097481", "cinnarizine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "citalopram", new ValueWithNote("797617", "citalopram") },
//             { "citalopram", new ValueWithNote("797617", "citalopram") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "celecoxib", new ValueWithNote("1118084", "celecoxib") },
//             { "celecoxib", new ValueWithNote("1118084", "celecoxib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carvedilol", new ValueWithNote("1346823", "carvedilol") },
//             { "carvedilol", new ValueWithNote("1346823", "carvedilol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "caspofungin", new ValueWithNote("1718054", "caspofungin") },
//             { "caspofungin", new ValueWithNote("1718054", "caspofungin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcium acetate", new ValueWithNote("951469", "calcium acetate") },
//             { "calcium acetate", new ValueWithNote("951469", "calcium acetate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "calcium chloride", new ValueWithNote("19036781", "calcium chloride") },
//             { "calcium chloride", new ValueWithNote("19036781", "calcium chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "CANagliflozin", new ValueWithNote("43526465", "canagliflozin") },
//             { "CANagliflozin", new ValueWithNote("43526465", "canagliflozin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefiderocol", new ValueWithNote("37498010", "cefiderocol") },
//             { "cefiderocol", new ValueWithNote("37498010", "cefiderocol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cenobamate", new ValueWithNote("37497998", "cenobamate") },
//             { "cenobamate", new ValueWithNote("37497998", "cenobamate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clomiFENE", new ValueWithNote("1598819", "clomiphene") },
//             { "clomiFENE", new ValueWithNote("1598819", "clomiphene") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clomiPRAMINE", new ValueWithNote("798834", "clomipramine") },
//             { "clomiPRAMINE", new ValueWithNote("798834", "clomipramine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cangrelor", new ValueWithNote("46275677", "cangrelor") },
//             { "cangrelor", new ValueWithNote("46275677", "cangrelor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "capsaicin", new ValueWithNote("939881", "capsaicin") },
//             { "capsaicin", new ValueWithNote("939881", "capsaicin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "certolizumab pegol", new ValueWithNote("912263", "certolizumab pegol") },
//             { "certolizumab pegol", new ValueWithNote("912263", "certolizumab pegol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chloral hydrate", new ValueWithNote("19054996", "chloral hydrate") },
//             { "chloral hydrate", new ValueWithNote("19054996", "chloral hydrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carBAMazepine", new ValueWithNote("740275", "carbamazepine") },
//             { "carBAMazepine", new ValueWithNote("740275", "carbamazepine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefoxitin", new ValueWithNote("1775741", "cefoxitin") },
//             { "cefoxitin", new ValueWithNote("1775741", "cefoxitin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clonazePAM", new ValueWithNote("798874", "clonazepam") },
//             { "clonazePAM", new ValueWithNote("798874", "clonazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clopidogrel", new ValueWithNote("1322184", "clopidogrel") },
//             { "clopidogrel", new ValueWithNote("1322184", "clopidogrel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Cilazapril", new ValueWithNote("19050216", "cilazapril") },
//             { "Cilazapril", new ValueWithNote("19050216", "cilazapril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cycloSERINE", new ValueWithNote("1710446", "cycloserine") },
//             { "cycloSERINE", new ValueWithNote("1710446", "cycloserine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "colchicine", new ValueWithNote("1101554", "colchicine") },
//             { "colchicine", new ValueWithNote("1101554", "colchicine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "colestyramine", new ValueWithNote("19095309", "cholestyramine resin") },
//             { "colestyramine", new ValueWithNote("19095309", "cholestyramine resin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "celiprolol", new ValueWithNote("19049145", "celiprolol") },
//             { "celiprolol", new ValueWithNote("19049145", "celiprolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chloroquine", new ValueWithNote("1792515", "chloroquine") },
//             { "chloroquine", new ValueWithNote("1792515", "chloroquine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cyproterone", new ValueWithNote("19010792", "cyproterone") },
//             { "cyproterone", new ValueWithNote("19010792", "cyproterone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dabrafenib", new ValueWithNote("43532299", "dabrafenib") },
//             { "dabrafenib", new ValueWithNote("43532299", "dabrafenib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chlorambucil", new ValueWithNote("1390051", "chlorambucil") },
//             { "chlorambucil", new ValueWithNote("1390051", "chlorambucil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cloZAPine", new ValueWithNote("800878", "clozapine") },
//             { "cloZAPine", new ValueWithNote("800878", "clozapine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "CRIZotinib", new ValueWithNote("40242675", "crizotinib") },
//             { "CRIZotinib", new ValueWithNote("40242675", "crizotinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "claRITHromycin", new ValueWithNote("1750500", "clarithromycin") },
//             { "claRITHromycin", new ValueWithNote("1750500", "clarithromycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "CLINDAmycin", new ValueWithNote("997881", "clindamycin") },
//             { "CLINDAmycin", new ValueWithNote("997881", "clindamycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chlordiazePOXIDE", new ValueWithNote("990678", "chlordiazepoxide") },
//             { "chlordiazePOXIDE", new ValueWithNote("990678", "chlordiazepoxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "colistimethate sodium", new ValueWithNote("19112658", "colistimethate sodium") },
//             { "colistimethate sodium", new ValueWithNote("19112658", "colistimethate sodium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chlorproMAZINE", new ValueWithNote("794852", "chlorpromazine") },
//             { "chlorproMAZINE", new ValueWithNote("794852", "chlorpromazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "DApagliflozin", new ValueWithNote("44785829", "dapagliflozin") },
//             { "DApagliflozin", new ValueWithNote("44785829", "dapagliflozin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dapsone", new ValueWithNote("1711759", "dapsone") },
//             { "dapsone", new ValueWithNote("1711759", "dapsone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clotrimazole", new ValueWithNote("1000632", "clotrimazole") },
//             { "clotrimazole", new ValueWithNote("1000632", "clotrimazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dabigatran", new ValueWithNote("45775372", "dabigatran") },
//             { "dabigatran", new ValueWithNote("45775372", "dabigatran") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "demeclocycline", new ValueWithNote("1714527", "demeclocycline") },
//             { "demeclocycline", new ValueWithNote("1714527", "demeclocycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cilostazol", new ValueWithNote("1350310", "cilostazol") },
//             { "cilostazol", new ValueWithNote("1350310", "cilostazol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "crotamiton", new ValueWithNote("969276", "crotamiton") },
//             { "crotamiton", new ValueWithNote("969276", "crotamiton") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ciprofloxacin", new ValueWithNote("1797513", "ciprofloxacin") },
//             { "ciprofloxacin", new ValueWithNote("1797513", "ciprofloxacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cyclizine", new ValueWithNote("909358", "cyclizine") },
//             { "cyclizine", new ValueWithNote("909358", "cyclizine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "crizanlizumab", new ValueWithNote("37497670", "crizanlizumab") },
//             { "crizanlizumab", new ValueWithNote("37497670", "crizanlizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "colesevelam", new ValueWithNote("1518148", "colesevelam") },
//             { "colesevelam", new ValueWithNote("1518148", "colesevelam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "DAPTOmycin", new ValueWithNote("1786617", "daptomycin") },
//             { "DAPTOmycin", new ValueWithNote("1786617", "daptomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "darifenacin", new ValueWithNote("916230", "darifenacin") },
//             { "darifenacin", new ValueWithNote("916230", "darifenacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "choline salicylate", new ValueWithNote("19042282", "choline salicylate") },
//             { "choline salicylate", new ValueWithNote("19042282", "choline salicylate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ciclesonide", new ValueWithNote("902938", "ciclesonide") },
//             { "ciclesonide", new ValueWithNote("902938", "ciclesonide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "CM-101", new ValueWithNote("1254269", "CM-101") },
//             { "CM-101", new ValueWithNote("1254269", "CM-101") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "darbepoetin alfa", new ValueWithNote("1304643", "darbepoetin alfa") },
//             { "darbepoetin alfa", new ValueWithNote("1304643", "darbepoetin alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "darunavir", new ValueWithNote("1756831", "darunavir") },
//             { "darunavir", new ValueWithNote("1756831", "darunavir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cyproheptadine", new ValueWithNote("1110727", "cyproheptadine") },
//             { "cyproheptadine", new ValueWithNote("1110727", "cyproheptadine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dequalinium", new ValueWithNote("19016063", "dequalinium") },
//             { "dequalinium", new ValueWithNote("19016063", "dequalinium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dalteparin", new ValueWithNote("1301065", "dalteparin") },
//             { "dalteparin", new ValueWithNote("1301065", "dalteparin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dexamfetamine", new ValueWithNote("719311", "dextroamphetamine") },
//             { "dexamfetamine", new ValueWithNote("719311", "dextroamphetamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cicloSPORIN", new ValueWithNote("19010482", "cyclosporine") },
//             { "cicloSPORIN", new ValueWithNote("19010482", "cyclosporine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "deferiprone", new ValueWithNote("19011091", "deferiprone") },
//             { "deferiprone", new ValueWithNote("19011091", "deferiprone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "desloratadine", new ValueWithNote("1103006", "desloratadine") },
//             { "desloratadine", new ValueWithNote("1103006", "desloratadine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "desogestrel", new ValueWithNote("1588000", "desogestrel") },
//             { "desogestrel", new ValueWithNote("1588000", "desogestrel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dexmedetomidine", new ValueWithNote("19061088", "dexmedetomidine") },
//             { "dexmedetomidine", new ValueWithNote("19061088", "dexmedetomidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "degarelix", new ValueWithNote("19058410", "degarelix") },
//             { "degarelix", new ValueWithNote("19058410", "degarelix") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "desmopressin", new ValueWithNote("1517070", "desmopressin") },
//             { "desmopressin", new ValueWithNote("1517070", "desmopressin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dinoprostone", new ValueWithNote("1329415", "dinoprostone") },
//             { "dinoprostone", new ValueWithNote("1329415", "dinoprostone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cidofovir", new ValueWithNote("1745072", "cidofovir") },
//             { "cidofovir", new ValueWithNote("1745072", "cidofovir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dexamethasone", new ValueWithNote("1518254", "dexamethasone") },
//             { "dexamethasone", new ValueWithNote("1518254", "dexamethasone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "DIAmorphine", new ValueWithNote("19022417", "heroin") },
//             { "DIAmorphine", new ValueWithNote("19022417", "heroin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Clemastine", new ValueWithNote("1197677", "clemastine") },
//             { "Clemastine", new ValueWithNote("1197677", "clemastine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clobetasone", new ValueWithNote("19005129", "clobetasone") },
//             { "clobetasone", new ValueWithNote("19005129", "clobetasone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diazepam", new ValueWithNote("723013", "diazepam") },
//             { "diazepam", new ValueWithNote("723013", "diazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diazoxide", new ValueWithNote("1523280", "diazoxide") },
//             { "diazoxide", new ValueWithNote("1523280", "diazoxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "clofazimine", new ValueWithNote("1798476", "clofazimine") },
//             { "clofazimine", new ValueWithNote("1798476", "clofazimine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dutasteride", new ValueWithNote("989482", "dutasteride") },
//             { "dutasteride", new ValueWithNote("989482", "dutasteride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dolutegravir", new ValueWithNote("43560385", "dolutegravir") },
//             { "dolutegravir", new ValueWithNote("43560385", "dolutegravir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "doxapram", new ValueWithNote("738152", "doxapram") },
//             { "doxapram", new ValueWithNote("738152", "doxapram") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "doxepin", new ValueWithNote("738156", "doxepin") },
//             { "doxepin", new ValueWithNote("738156", "doxepin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Eftrenonacog alfa", new ValueWithNote("44818493", "coagulation factor IX recombinant immunoglobulin G1 fusion protein") },
//             { "Eftrenonacog alfa", new ValueWithNote("44818493", "coagulation factor IX recombinant immunoglobulin G1 fusion protein") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "elexacaftor/ivacaftor/tezacaftor", new ValueWithNote("779006", "elexacaftor / ivacaftor / tezacaftor") },
//             { "elexacaftor/ivacaftor/tezacaftor", new ValueWithNote("779006", "elexacaftor / ivacaftor / tezacaftor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diethylamine salicylate", new ValueWithNote("19029278", "diethylamine salicylate") },
//             { "diethylamine salicylate", new ValueWithNote("19029278", "diethylamine salicylate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "colestipol", new ValueWithNote("1501617", "colestipol") },
//             { "colestipol", new ValueWithNote("1501617", "colestipol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "EMpagliflozin", new ValueWithNote("45774751", "empagliflozin") },
//             { "EMpagliflozin", new ValueWithNote("45774751", "empagliflozin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dulaglutide", new ValueWithNote("45774435", "dulaglutide") },
//             { "dulaglutide", new ValueWithNote("45774435", "dulaglutide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Efgartigimod alfa", new ValueWithNote("702468", "efgartigimod alfa") },
//             { "Efgartigimod alfa", new ValueWithNote("702468", "efgartigimod alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cyanocobalamin", new ValueWithNote("1308738", "vitamin B12") },
//             { "cyanocobalamin", new ValueWithNote("1308738", "vitamin B12") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "danaparoid", new ValueWithNote("19026343", "danaparoid") },
//             { "danaparoid", new ValueWithNote("19026343", "danaparoid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eltrombopag", new ValueWithNote("19012346", "eltrombopag") },
//             { "eltrombopag", new ValueWithNote("19012346", "eltrombopag") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dantrolene", new ValueWithNote("711714", "dantrolene") },
//             { "dantrolene", new ValueWithNote("711714", "dantrolene") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "deflazacort", new ValueWithNote("19086888", "deflazacort") },
//             { "deflazacort", new ValueWithNote("19086888", "deflazacort") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dalbavancin", new ValueWithNote("45774861", "dalbavancin") },
//             { "dalbavancin", new ValueWithNote("45774861", "dalbavancin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eplerenone", new ValueWithNote("1309799", "eplerenone") },
//             { "eplerenone", new ValueWithNote("1309799", "eplerenone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diflucortolone", new ValueWithNote("19026096", "diflucortolone") },
//             { "diflucortolone", new ValueWithNote("19026096", "diflucortolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "esmolol", new ValueWithNote("19063575", "esmolol") },
//             { "esmolol", new ValueWithNote("19063575", "esmolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etelcalcetide", new ValueWithNote("1593331", "etelcalcetide") },
//             { "etelcalcetide", new ValueWithNote("1593331", "etelcalcetide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "entecavir", new ValueWithNote("1711246", "entecavir") },
//             { "entecavir", new ValueWithNote("1711246", "entecavir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "epirubicin", new ValueWithNote("1344354", "epirubicin") },
//             { "epirubicin", new ValueWithNote("1344354", "epirubicin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diltiazem", new ValueWithNote("1328165", "diltiazem") },
//             { "diltiazem", new ValueWithNote("1328165", "diltiazem") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "deferasirox", new ValueWithNote("40127988", "deferasirox") },
//             { "deferasirox", new ValueWithNote("40127988", "deferasirox") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "defibrotide", new ValueWithNote("42898933", "defibrotide") },
//             { "defibrotide", new ValueWithNote("42898933", "defibrotide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eprosartan", new ValueWithNote("1346686", "eprosartan") },
//             { "eprosartan", new ValueWithNote("1346686", "eprosartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eptacog alfa", new ValueWithNote("19065771", "eptacog alfa activated") },
//             { "eptacog alfa", new ValueWithNote("19065771", "eptacog alfa activated") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "DISOPyramide", new ValueWithNote("1335606", "disopyramide") },
//             { "DISOPyramide", new ValueWithNote("1335606", "disopyramide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etomidate", new ValueWithNote("19050488", "etomidate") },
//             { "etomidate", new ValueWithNote("19050488", "etomidate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ferrous fumarate", new ValueWithNote("1595799", "ferrous fumarate") },
//             { "ferrous fumarate", new ValueWithNote("1595799", "ferrous fumarate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "delafloxacin", new ValueWithNote("1592954", "delafloxacin") },
//             { "delafloxacin", new ValueWithNote("1592954", "delafloxacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "delandistrogene moxeparvovec", new ValueWithNote("746024", "delandistrogene moxeparvovec") },
//             { "delandistrogene moxeparvovec", new ValueWithNote("746024", "delandistrogene moxeparvovec") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "difelikefalin", new ValueWithNote("701764", "difelikefalin") },
//             { "difelikefalin", new ValueWithNote("701764", "difelikefalin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "denosumab", new ValueWithNote("40222444", "denosumab") },
//             { "denosumab", new ValueWithNote("40222444", "denosumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diPYRIDamole", new ValueWithNote("1331270", "dipyridamole") },
//             { "diPYRIDamole", new ValueWithNote("1331270", "dipyridamole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "docusate", new ValueWithNote("941258", "docusate") },
//             { "docusate", new ValueWithNote("941258", "docusate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etonogestrel", new ValueWithNote("1519936", "etonogestrel") },
//             { "etonogestrel", new ValueWithNote("1519936", "etonogestrel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etoposide", new ValueWithNote("1350504", "etoposide") },
//             { "etoposide", new ValueWithNote("1350504", "etoposide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fludarabine", new ValueWithNote("1395557", "fludarabine") },
//             { "fludarabine", new ValueWithNote("1395557", "fludarabine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "doxazosin", new ValueWithNote("1363053", "doxazosin") },
//             { "doxazosin", new ValueWithNote("1363053", "doxazosin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fosfomycin", new ValueWithNote("956653", "fosfomycin") },
//             { "fosfomycin", new ValueWithNote("956653", "fosfomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fulvestrant", new ValueWithNote("1304044", "fulvestrant") },
//             { "fulvestrant", new ValueWithNote("1304044", "fulvestrant") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fampridine", new ValueWithNote("40170680", "dalfampridine") },
//             { "fampridine", new ValueWithNote("40170680", "dalfampridine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "doxycycline", new ValueWithNote("1738521", "doxycycline") },
//             { "doxycycline", new ValueWithNote("1738521", "doxycycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dronedarone", new ValueWithNote("40163615", "dronedarone") },
//             { "dronedarone", new ValueWithNote("40163615", "dronedarone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "gentamicin", new ValueWithNote("45892419", "gentamicin") },
//             { "gentamicin", new ValueWithNote("45892419", "gentamicin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "doravirine", new ValueWithNote("35200446", "doravirine") },
//             { "doravirine", new ValueWithNote("35200446", "doravirine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dosulepin", new ValueWithNote("19037989", "dothiepin") },
//             { "dosulepin", new ValueWithNote("19037989", "dothiepin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "emicizumab", new ValueWithNote("793042", "emicizumab") },
//             { "emicizumab", new ValueWithNote("793042", "emicizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "epoetin alfa", new ValueWithNote("1301125", "epoetin alfa") },
//             { "epoetin alfa", new ValueWithNote("1301125", "epoetin alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ferrous gluconate", new ValueWithNote("1396012", "ferrous gluconate") },
//             { "ferrous gluconate", new ValueWithNote("1396012", "ferrous gluconate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etoricoxib", new ValueWithNote("19011355", "etoricoxib") },
//             { "etoricoxib", new ValueWithNote("19011355", "etoricoxib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "factor IX", new ValueWithNote("1351935", "factor IX") },
//             { "factor IX", new ValueWithNote("1351935", "factor IX") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ergocalciferol", new ValueWithNote("19045045", "ergocalciferol") },
//             { "ergocalciferol", new ValueWithNote("19045045", "ergocalciferol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fidaxomicin", new ValueWithNote("40239985", "fidaxomicin") },
//             { "fidaxomicin", new ValueWithNote("40239985", "fidaxomicin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "filgotinib", new ValueWithNote("35891916", "Filgotinib") },
//             { "filgotinib", new ValueWithNote("35891916", "Filgotinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "edoxaban", new ValueWithNote("45892847", "edoxaban") },
//             { "edoxaban", new ValueWithNote("45892847", "edoxaban") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "esomeprazole", new ValueWithNote("904453", "esomeprazole") },
//             { "esomeprazole", new ValueWithNote("904453", "esomeprazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fingolimod", new ValueWithNote("40226579", "fingolimod") },
//             { "fingolimod", new ValueWithNote("40226579", "fingolimod") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flumazenil", new ValueWithNote("19055153", "flumazenil") },
//             { "flumazenil", new ValueWithNote("19055153", "flumazenil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "efavirenz", new ValueWithNote("1738135", "efavirenz") },
//             { "efavirenz", new ValueWithNote("1738135", "efavirenz") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eflornithine", new ValueWithNote("978236", "eflornithine") },
//             { "eflornithine", new ValueWithNote("978236", "eflornithine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flurbiprofen", new ValueWithNote("1156378", "flurbiprofen") },
//             { "flurbiprofen", new ValueWithNote("1156378", "flurbiprofen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flutamide", new ValueWithNote("1356461", "flutamide") },
//             { "flutamide", new ValueWithNote("1356461", "flutamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Efmoroctocog alfa", new ValueWithNote("45776421", "efmoroctocog alfa") },
//             { "Efmoroctocog alfa", new ValueWithNote("45776421", "efmoroctocog alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eletriptan", new ValueWithNote("1189697", "eletriptan") },
//             { "eletriptan", new ValueWithNote("1189697", "eletriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diethylstilbestrol", new ValueWithNote("1525866", "diethylstilbestrol") },
//             { "diethylstilbestrol", new ValueWithNote("1525866", "diethylstilbestrol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glimepiride", new ValueWithNote("1597756", "glimepiride") },
//             { "glimepiride", new ValueWithNote("1597756", "glimepiride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "desferrioxamine", new ValueWithNote("1711947", "deferoxamine") },
//             { "desferrioxamine", new ValueWithNote("1711947", "deferoxamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dimethyl fumarate", new ValueWithNote("43526424", "dimethyl fumarate") },
//             { "dimethyl fumarate", new ValueWithNote("43526424", "dimethyl fumarate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "disulfiram", new ValueWithNote("735850", "disulfiram") },
//             { "disulfiram", new ValueWithNote("735850", "disulfiram") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluvastatin", new ValueWithNote("1549686", "fluvastatin") },
//             { "fluvastatin", new ValueWithNote("1549686", "fluvastatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluvoxaMINE", new ValueWithNote("751412", "fluvoxamine") },
//             { "fluvoxaMINE", new ValueWithNote("751412", "fluvoxamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "droperidol", new ValueWithNote("739323", "droperidol") },
//             { "droperidol", new ValueWithNote("739323", "droperidol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eculizumab", new ValueWithNote("19080458", "eculizumab") },
//             { "eculizumab", new ValueWithNote("19080458", "eculizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "formoterol", new ValueWithNote("1196677", "formoterol") },
//             { "formoterol", new ValueWithNote("1196677", "formoterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "enoxaparin", new ValueWithNote("1301025", "enoxaparin") },
//             { "enoxaparin", new ValueWithNote("1301025", "enoxaparin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "gonadorelin", new ValueWithNote("19089810", "gonadorelin") },
//             { "gonadorelin", new ValueWithNote("19089810", "gonadorelin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glycopyrronium", new ValueWithNote("45775571", "glycopyrronium") },
//             { "glycopyrronium", new ValueWithNote("45775571", "glycopyrronium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "entacapone", new ValueWithNote("782211", "entacapone") },
//             { "entacapone", new ValueWithNote("782211", "entacapone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "donepezil", new ValueWithNote("715997", "donepezil") },
//             { "donepezil", new ValueWithNote("715997", "donepezil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dornase alfa", new ValueWithNote("1125443", "dornase alfa") },
//             { "dornase alfa", new ValueWithNote("1125443", "dornase alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "epoetin beta", new ValueWithNote("19001311", "epoetin beta") },
//             { "epoetin beta", new ValueWithNote("19001311", "epoetin beta") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "epoetin zeta", new ValueWithNote("21014076", "Epoetin zeta") },
//             { "epoetin zeta", new ValueWithNote("21014076", "Epoetin zeta") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fentaNYL", new ValueWithNote("1154029", "fentanyl") },
//             { "fentaNYL", new ValueWithNote("1154029", "fentanyl") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "finasteride", new ValueWithNote("996416", "finasteride") },
//             { "finasteride", new ValueWithNote("996416", "finasteride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etodolac", new ValueWithNote("1195492", "etodolac") },
//             { "etodolac", new ValueWithNote("1195492", "etodolac") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ezetimibe", new ValueWithNote("1526475", "ezetimibe") },
//             { "ezetimibe", new ValueWithNote("1526475", "ezetimibe") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ertapenem", new ValueWithNote("1717963", "ertapenem") },
//             { "ertapenem", new ValueWithNote("1717963", "ertapenem") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "eslicarbazepine", new ValueWithNote("44507780", "eslicarbazepine") },
//             { "eslicarbazepine", new ValueWithNote("44507780", "eslicarbazepine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flavoxATE", new ValueWithNote("954853", "flavoxate") },
//             { "flavoxATE", new ValueWithNote("954853", "flavoxate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flecainide", new ValueWithNote("1354860", "flecainide") },
//             { "flecainide", new ValueWithNote("1354860", "flecainide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "factor XIII", new ValueWithNote("19106100", "factor XIII") },
//             { "factor XIII", new ValueWithNote("19106100", "factor XIII") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ferric derisomaltose", new ValueWithNote("37498615", "ferric derisomaltose") },
//             { "ferric derisomaltose", new ValueWithNote("37498615", "ferric derisomaltose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ethanol", new ValueWithNote("955372", "ethanol") },
//             { "ethanol", new ValueWithNote("955372", "ethanol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ethinylestradiol", new ValueWithNote("1549786", "ethinyl estradiol") },
//             { "ethinylestradiol", new ValueWithNote("1549786", "ethinyl estradiol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin isophane", new ValueWithNote("46221581", "insulin isophane") },
//             { "insulin isophane", new ValueWithNote("46221581", "insulin isophane") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "enalapril", new ValueWithNote("1341927", "enalapril") },
//             { "enalapril", new ValueWithNote("1341927", "enalapril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ephedrine", new ValueWithNote("1143374", "ephedrine") },
//             { "ephedrine", new ValueWithNote("1143374", "ephedrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ferrous sulfate", new ValueWithNote("1396131", "ferrous sulfate") },
//             { "ferrous sulfate", new ValueWithNote("1396131", "ferrous sulfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "isavuconazole", new ValueWithNote("35606695", "isavuconazole") },
//             { "isavuconazole", new ValueWithNote("35606695", "isavuconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "isocarboxazid", new ValueWithNote("781705", "isocarboxazid") },
//             { "isocarboxazid", new ValueWithNote("781705", "isocarboxazid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "epoprostenol", new ValueWithNote("1354118", "epoprostenol") },
//             { "epoprostenol", new ValueWithNote("1354118", "epoprostenol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "finerenone", new ValueWithNote("1537451", "finerenone") },
//             { "finerenone", new ValueWithNote("1537451", "finerenone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flucytosine", new ValueWithNote("1755112", "flucytosine") },
//             { "flucytosine", new ValueWithNote("1755112", "flucytosine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "isoniazid", new ValueWithNote("1782521", "isoniazid") },
//             { "isoniazid", new ValueWithNote("1782521", "isoniazid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "FELOdipine", new ValueWithNote("1353776", "felodipine") },
//             { "FELOdipine", new ValueWithNote("1353776", "felodipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydrocortisone", new ValueWithNote("975125", "hydrocortisone") },
//             { "hydrocortisone", new ValueWithNote("975125", "hydrocortisone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydrOXYzine", new ValueWithNote("777221", "hydroxyzine") },
//             { "hydrOXYzine", new ValueWithNote("777221", "hydroxyzine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluorescein", new ValueWithNote("996625", "fluorescein") },
//             { "fluorescein", new ValueWithNote("996625", "fluorescein") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etanercept", new ValueWithNote("1151789", "etanercept") },
//             { "etanercept", new ValueWithNote("1151789", "etanercept") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "evolocumab", new ValueWithNote("46287466", "evolocumab") },
//             { "evolocumab", new ValueWithNote("46287466", "evolocumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flupentixol", new ValueWithNote("19055982", "flupenthixol") },
//             { "flupentixol", new ValueWithNote("19055982", "flupenthixol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hyoscine", new ValueWithNote("965748", "scopolamine") },
//             { "hyoscine", new ValueWithNote("965748", "scopolamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ibuprofen", new ValueWithNote("1177480", "ibuprofen") },
//             { "ibuprofen", new ValueWithNote("1177480", "ibuprofen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fludroxycortide", new ValueWithNote("956266", "flurandrenolide") },
//             { "fludroxycortide", new ValueWithNote("956266", "flurandrenolide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "flurazepam", new ValueWithNote("756349", "flurazepam") },
//             { "flurazepam", new ValueWithNote("756349", "flurazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "isosorbide MONOnitrate", new ValueWithNote("19069136", "isosorbide mononitrate") },
//             { "isosorbide MONOnitrate", new ValueWithNote("19069136", "isosorbide mononitrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ivabradine", new ValueWithNote("46234437", "ivabradine") },
//             { "ivabradine", new ValueWithNote("46234437", "ivabradine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "inclisiran", new ValueWithNote("1758562", "inclisiran") },
//             { "inclisiran", new ValueWithNote("1758562", "inclisiran") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fosaprepitant", new ValueWithNote("35605594", "fosaprepitant") },
//             { "fosaprepitant", new ValueWithNote("35605594", "fosaprepitant") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ergometrine", new ValueWithNote("1345205", "ergonovine") },
//             { "ergometrine", new ValueWithNote("1345205", "ergonovine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "erythromycin", new ValueWithNote("1746940", "erythromycin") },
//             { "erythromycin", new ValueWithNote("1746940", "erythromycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "indocyanine green", new ValueWithNote("19078612", "indocyanine green") },
//             { "indocyanine green", new ValueWithNote("19078612", "indocyanine green") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "indometacin", new ValueWithNote("1178663", "indomethacin") },
//             { "indometacin", new ValueWithNote("1178663", "indomethacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluticasone", new ValueWithNote("1149380", "fluticasone") },
//             { "fluticasone", new ValueWithNote("1149380", "fluticasone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fomepizole", new ValueWithNote("19022479", "fomepizole") },
//             { "fomepizole", new ValueWithNote("19022479", "fomepizole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "factor VIII", new ValueWithNote("1352213", "factor VIII") },
//             { "factor VIII", new ValueWithNote("1352213", "factor VIII") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "factor VIII inhibitor bypassing fraction", new ValueWithNote("19080406", "anti-inhibitor coagulant complex") },
//             { "factor VIII inhibitor bypassing fraction", new ValueWithNote("19080406", "anti-inhibitor coagulant complex") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fludrocortisone", new ValueWithNote("1555120", "fludrocortisone") },
//             { "fludrocortisone", new ValueWithNote("1555120", "fludrocortisone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluorouracil", new ValueWithNote("955632", "fluorouracil") },
//             { "fluorouracil", new ValueWithNote("955632", "fluorouracil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "foscarnet", new ValueWithNote("1724700", "foscarnet") },
//             { "foscarnet", new ValueWithNote("1724700", "foscarnet") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "folic acid", new ValueWithNote("19111620", "folic acid") },
//             { "folic acid", new ValueWithNote("19111620", "folic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "frovatriptan", new ValueWithNote("1189458", "frovatriptan") },
//             { "frovatriptan", new ValueWithNote("1189458", "frovatriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glatiramer", new ValueWithNote("751889", "glatiramer") },
//             { "glatiramer", new ValueWithNote("751889", "glatiramer") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glipiZIDE", new ValueWithNote("1560171", "glipizide") },
//             { "glipiZIDE", new ValueWithNote("1560171", "glipizide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "famciclovir", new ValueWithNote("1703603", "famciclovir") },
//             { "famciclovir", new ValueWithNote("1703603", "famciclovir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "famotidine", new ValueWithNote("953076", "famotidine") },
//             { "famotidine", new ValueWithNote("953076", "famotidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ketamine", new ValueWithNote("785649", "ketamine") },
//             { "ketamine", new ValueWithNote("785649", "ketamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ketotifen", new ValueWithNote("986117", "ketotifen") },
//             { "ketotifen", new ValueWithNote("986117", "ketotifen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "GEFitinib", new ValueWithNote("1319193", "gefitinib") },
//             { "GEFitinib", new ValueWithNote("1319193", "gefitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Inebilizumab", new ValueWithNote("1146077", "inebilizumab") },
//             { "Inebilizumab", new ValueWithNote("1146077", "inebilizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "escitalopram", new ValueWithNote("715939", "escitalopram") },
//             { "escitalopram", new ValueWithNote("715939", "escitalopram") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "estradiol", new ValueWithNote("1548195", "estradiol") },
//             { "estradiol", new ValueWithNote("1548195", "estradiol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fexofenadine", new ValueWithNote("1153428", "fexofenadine") },
//             { "fexofenadine", new ValueWithNote("1153428", "fexofenadine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hemin", new ValueWithNote("19067303", "hemin") },
//             { "hemin", new ValueWithNote("19067303", "hemin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "heparin", new ValueWithNote("1367571", "heparin") },
//             { "heparin", new ValueWithNote("1367571", "heparin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "gliCLAzide", new ValueWithNote("19059796", "gliclazide") },
//             { "gliCLAzide", new ValueWithNote("19059796", "gliclazide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fibrinogen", new ValueWithNote("19054702", "fibrinogen") },
//             { "fibrinogen", new ValueWithNote("19054702", "fibrinogen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "interferon beta-1a", new ValueWithNote("722424", "interferon beta-1a") },
//             { "interferon beta-1a", new ValueWithNote("722424", "interferon beta-1a") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "estriol", new ValueWithNote("19049038", "estriol") },
//             { "estriol", new ValueWithNote("19049038", "estriol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "iohexol", new ValueWithNote("19080985", "iohexol") },
//             { "iohexol", new ValueWithNote("19080985", "iohexol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluocinolone", new ValueWithNote("996541", "fluocinolone") },
//             { "fluocinolone", new ValueWithNote("996541", "fluocinolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "leuprorelin", new ValueWithNote("1351541", "leuprolide") },
//             { "leuprorelin", new ValueWithNote("1351541", "leuprolide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ethosuximide", new ValueWithNote("750119", "ethosuximide") },
//             { "ethosuximide", new ValueWithNote("750119", "ethosuximide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "exenatide", new ValueWithNote("1583722", "exenatide") },
//             { "exenatide", new ValueWithNote("1583722", "exenatide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fenofibrate", new ValueWithNote("1551803", "fenofibrate") },
//             { "fenofibrate", new ValueWithNote("1551803", "fenofibrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "FLUoxetine", new ValueWithNote("755695", "fluoxetine") },
//             { "FLUoxetine", new ValueWithNote("755695", "fluoxetine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fondaparinux", new ValueWithNote("1315865", "fondaparinux") },
//             { "fondaparinux", new ValueWithNote("1315865", "fondaparinux") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "iron dextran", new ValueWithNote("1381661", "iron-dextran complex") },
//             { "iron dextran", new ValueWithNote("1381661", "iron-dextran complex") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ISOtretinoin", new ValueWithNote("984232", "isotretinoin") },
//             { "ISOtretinoin", new ValueWithNote("984232", "isotretinoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "letermovir", new ValueWithNote("792929", "letermovir") },
//             { "letermovir", new ValueWithNote("792929", "letermovir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "furosemide", new ValueWithNote("956874", "furosemide") },
//             { "furosemide", new ValueWithNote("956874", "furosemide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "linaclotide", new ValueWithNote("42900505", "linaclotide") },
//             { "linaclotide", new ValueWithNote("42900505", "linaclotide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "levofloxacin", new ValueWithNote("1742253", "levofloxacin") },
//             { "levofloxacin", new ValueWithNote("1742253", "levofloxacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "linagliptin", new ValueWithNote("40239216", "linagliptin") },
//             { "linagliptin", new ValueWithNote("40239216", "linagliptin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fusidic acid", new ValueWithNote("19112521", "fusidic acid") },
//             { "fusidic acid", new ValueWithNote("19112521", "fusidic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "gabapentin", new ValueWithNote("797399", "gabapentin") },
//             { "gabapentin", new ValueWithNote("797399", "gabapentin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "golimumab", new ValueWithNote("19041065", "golimumab") },
//             { "golimumab", new ValueWithNote("19041065", "golimumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydroxychloroquine", new ValueWithNote("1777087", "hydroxychloroquine") },
//             { "hydroxychloroquine", new ValueWithNote("1777087", "hydroxychloroquine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "idarucizumab", new ValueWithNote("35602981", "idarucizumab") },
//             { "idarucizumab", new ValueWithNote("35602981", "idarucizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "imlifidase", new ValueWithNote("35894914", "Imlifidase") },
//             { "imlifidase", new ValueWithNote("35894914", "Imlifidase") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lomustine", new ValueWithNote("1391846", "lomustine") },
//             { "lomustine", new ValueWithNote("1391846", "lomustine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "gelatin", new ValueWithNote("19058092", "gelatin") },
//             { "gelatin", new ValueWithNote("19058092", "gelatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "granisetron", new ValueWithNote("1000772", "granisetron") },
//             { "granisetron", new ValueWithNote("1000772", "granisetron") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "interferon gamma-1b", new ValueWithNote("1380191", "interferon gamma-1b") },
//             { "interferon gamma-1b", new ValueWithNote("1380191", "interferon gamma-1b") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "menadiol", new ValueWithNote("19009057", "menadiol") },
//             { "menadiol", new ValueWithNote("19009057", "menadiol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lofepramine", new ValueWithNote("19091830", "lofepramine") },
//             { "lofepramine", new ValueWithNote("19091830", "lofepramine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ferric carboxymaltose", new ValueWithNote("43560392", "ferric carboxymaltose") },
//             { "ferric carboxymaltose", new ValueWithNote("43560392", "ferric carboxymaltose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glycine irrigation", new ValueWithNote("40046876", "glycine Irrigation Solution") },
//             { "glycine irrigation", new ValueWithNote("40046876", "glycine Irrigation Solution") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "goserelin", new ValueWithNote("1366310", "goserelin") },
//             { "goserelin", new ValueWithNote("1366310", "goserelin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "melphalan", new ValueWithNote("1301267", "melphalan") },
//             { "melphalan", new ValueWithNote("1301267", "melphalan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluCONAZole", new ValueWithNote("1754994", "fluconazole") },
//             { "fluCONAZole", new ValueWithNote("1754994", "fluconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metroNIDAZOLE", new ValueWithNote("1707164", "metronidazole") },
//             { "metroNIDAZOLE", new ValueWithNote("1707164", "metronidazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "minocycline", new ValueWithNote("1708880", "minocycline") },
//             { "minocycline", new ValueWithNote("1708880", "minocycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluticasone/umeclidinium/vilanterol", new ValueWithNote("778971", "fluticasone / umeclidinium / vilanterol") },
//             { "fluticasone/umeclidinium/vilanterol", new ValueWithNote("778971", "fluticasone / umeclidinium / vilanterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hexaminolevulinate", new ValueWithNote("43532423", "hexyl 5-aminolevulinate") },
//             { "hexaminolevulinate", new ValueWithNote("43532423", "hexyl 5-aminolevulinate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lacosamide", new ValueWithNote("19087394", "lacosamide") },
//             { "lacosamide", new ValueWithNote("19087394", "lacosamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "galantamine", new ValueWithNote("757627", "galantamine") },
//             { "galantamine", new ValueWithNote("757627", "galantamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nabilone", new ValueWithNote("913440", "nabilone") },
//             { "nabilone", new ValueWithNote("913440", "nabilone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nicotinamide", new ValueWithNote("19018419", "niacinamide") },
//             { "nicotinamide", new ValueWithNote("19018419", "niacinamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Human cytomegalovirus immunoglobulin", new ValueWithNote("963762", "cytomegalovirus immune globulin, human") },
//             { "Human cytomegalovirus immunoglobulin", new ValueWithNote("963762", "cytomegalovirus immune globulin, human") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Mepacrine", new ValueWithNote("19060400", "quinacrine") },
//             { "Mepacrine", new ValueWithNote("19060400", "quinacrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nilotinib", new ValueWithNote("1394023", "nilotinib") },
//             { "nilotinib", new ValueWithNote("1394023", "nilotinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nintedanib", new ValueWithNote("45775396", "nintedanib") },
//             { "nintedanib", new ValueWithNote("45775396", "nintedanib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydrochlorothiazide", new ValueWithNote("974166", "hydrochlorothiazide") },
//             { "hydrochlorothiazide", new ValueWithNote("974166", "hydrochlorothiazide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ganciclovir", new ValueWithNote("1757803", "ganciclovir") },
//             { "ganciclovir", new ValueWithNote("1757803", "ganciclovir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ginkgo", new ValueWithNote("1391889", "Ginkgo biloba extract") },
//             { "ginkgo", new ValueWithNote("1391889", "Ginkgo biloba extract") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "haloperidol", new ValueWithNote("766529", "haloperidol") },
//             { "haloperidol", new ValueWithNote("766529", "haloperidol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Honey", new ValueWithNote("19071840", "honey preparation") },
//             { "Honey", new ValueWithNote("19071840", "honey preparation") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lenograstim", new ValueWithNote("19009705", "lenograstim") },
//             { "lenograstim", new ValueWithNote("19009705", "lenograstim") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "LERCANidipine", new ValueWithNote("19015802", "lercanidipine") },
//             { "LERCANidipine", new ValueWithNote("19015802", "lercanidipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methenamine", new ValueWithNote("904356", "methenamine") },
//             { "methenamine", new ValueWithNote("904356", "methenamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "letrozole", new ValueWithNote("1315946", "letrozole") },
//             { "letrozole", new ValueWithNote("1315946", "letrozole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methylphenidate", new ValueWithNote("705944", "methylphenidate") },
//             { "methylphenidate", new ValueWithNote("705944", "methylphenidate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mifepristone", new ValueWithNote("1508439", "mifepristone") },
//             { "mifepristone", new ValueWithNote("1508439", "mifepristone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glycerol", new ValueWithNote("961145", "glycerin") },
//             { "glycerol", new ValueWithNote("961145", "glycerin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glyceryl trinitrate", new ValueWithNote("1361711", "nitroglycerin") },
//             { "glyceryl trinitrate", new ValueWithNote("1361711", "nitroglycerin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mitomycin", new ValueWithNote("1389036", "mitomycin") },
//             { "mitomycin", new ValueWithNote("1389036", "mitomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mometasone", new ValueWithNote("905233", "mometasone") },
//             { "mometasone", new ValueWithNote("905233", "mometasone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glucose", new ValueWithNote("1560524", "glucose") },
//             { "glucose", new ValueWithNote("1560524", "glucose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "levothyroxine", new ValueWithNote("1501700", "levothyroxine") },
//             { "levothyroxine", new ValueWithNote("1501700", "levothyroxine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydroxocobalamin", new ValueWithNote("1377023", "hydroxocobalamin") },
//             { "hydroxocobalamin", new ValueWithNote("1377023", "hydroxocobalamin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydrogen peroxide", new ValueWithNote("1776430", "hydrogen peroxide") },
//             { "hydrogen peroxide", new ValueWithNote("1776430", "hydrogen peroxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "olodaterol", new ValueWithNote("45775116", "olodaterol") },
//             { "olodaterol", new ValueWithNote("45775116", "olodaterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "olsalazine", new ValueWithNote("916282", "olsalazine") },
//             { "olsalazine", new ValueWithNote("916282", "olsalazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "griseofulvin", new ValueWithNote("1763779", "griseofulvin") },
//             { "griseofulvin", new ValueWithNote("1763779", "griseofulvin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "liothyronine", new ValueWithNote("1505346", "liothyronine") },
//             { "liothyronine", new ValueWithNote("1505346", "liothyronine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mupirocin", new ValueWithNote("951511", "mupirocin") },
//             { "mupirocin", new ValueWithNote("951511", "mupirocin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nafarelin", new ValueWithNote("1507558", "nafarelin") },
//             { "nafarelin", new ValueWithNote("1507558", "nafarelin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "omalizumab", new ValueWithNote("1110942", "omalizumab") },
//             { "omalizumab", new ValueWithNote("1110942", "omalizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oxytocin", new ValueWithNote("1326115", "oxytocin") },
//             { "oxytocin", new ValueWithNote("1326115", "oxytocin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "icatibant", new ValueWithNote("40242044", "icatibant") },
//             { "icatibant", new ValueWithNote("40242044", "icatibant") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "imipramine", new ValueWithNote("778268", "imipramine") },
//             { "imipramine", new ValueWithNote("778268", "imipramine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hepatitis B immunoglobulin", new ValueWithNote("501343", "hepatitis B immune globulin") },
//             { "hepatitis B immunoglobulin", new ValueWithNote("501343", "hepatitis B immune globulin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naftidrofuryl", new ValueWithNote("19014035", "nafronyl") },
//             { "naftidrofuryl", new ValueWithNote("19014035", "nafronyl") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "indoramin", new ValueWithNote("19078808", "indoramin") },
//             { "indoramin", new ValueWithNote("19078808", "indoramin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin degludec", new ValueWithNote("35602717", "insulin degludec") },
//             { "insulin degludec", new ValueWithNote("35602717", "insulin degludec") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hexetidine", new ValueWithNote("19068839", "hexetidine") },
//             { "hexetidine", new ValueWithNote("19068839", "hexetidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "HYDROmorphone", new ValueWithNote("1126658", "hydromorphone") },
//             { "HYDROmorphone", new ValueWithNote("1126658", "hydromorphone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "loratadine", new ValueWithNote("1107830", "loratadine") },
//             { "loratadine", new ValueWithNote("1107830", "loratadine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "losartan", new ValueWithNote("1367500", "losartan") },
//             { "losartan", new ValueWithNote("1367500", "losartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "isoprenaline", new ValueWithNote("1183554", "isoproterenol") },
//             { "isoprenaline", new ValueWithNote("1183554", "isoproterenol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "magnesium aspartate", new ValueWithNote("19019131", "magnesium aspartate") },
//             { "magnesium aspartate", new ValueWithNote("19019131", "magnesium aspartate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydrALAZINE", new ValueWithNote("1373928", "hydralazine") },
//             { "hydrALAZINE", new ValueWithNote("1373928", "hydralazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lactulose", new ValueWithNote("987245", "lactulose") },
//             { "lactulose", new ValueWithNote("987245", "lactulose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Imdevimab", new ValueWithNote("37003293", "imdevimab") },
//             { "Imdevimab", new ValueWithNote("37003293", "imdevimab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "medium chain triglycerides", new ValueWithNote("42899398", "medium chain triglycerides") },
//             { "medium chain triglycerides", new ValueWithNote("42899398", "medium chain triglycerides") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin aspart", new ValueWithNote("1567198", "insulin aspart, human") },
//             { "insulin aspart", new ValueWithNote("1567198", "insulin aspart, human") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin glargine", new ValueWithNote("1502905", "insulin glargine") },
//             { "insulin glargine", new ValueWithNote("1502905", "insulin glargine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pegvisomant", new ValueWithNote("1503432", "pegvisomant") },
//             { "pegvisomant", new ValueWithNote("1503432", "pegvisomant") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pentamidine", new ValueWithNote("1730370", "pentamidine") },
//             { "pentamidine", new ValueWithNote("1730370", "pentamidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ibandronic acid", new ValueWithNote("19011068", "ibandronic acid") },
//             { "ibandronic acid", new ValueWithNote("19011068", "ibandronic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nicotine", new ValueWithNote("718583", "nicotine") },
//             { "nicotine", new ValueWithNote("718583", "nicotine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "permethrin", new ValueWithNote("922868", "permethrin") },
//             { "permethrin", new ValueWithNote("922868", "permethrin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pimecrolimus", new ValueWithNote("915935", "pimecrolimus") },
//             { "pimecrolimus", new ValueWithNote("915935", "pimecrolimus") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "indapamide", new ValueWithNote("978555", "indapamide") },
//             { "indapamide", new ValueWithNote("978555", "indapamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin detemir", new ValueWithNote("1516976", "insulin detemir") },
//             { "insulin detemir", new ValueWithNote("1516976", "insulin detemir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nitric oxide", new ValueWithNote("19020068", "nitric oxide") },
//             { "nitric oxide", new ValueWithNote("19020068", "nitric oxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "octreotide", new ValueWithNote("1522957", "octreotide") },
//             { "octreotide", new ValueWithNote("1522957", "octreotide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "plerixafor", new ValueWithNote("19017581", "plerixafor") },
//             { "plerixafor", new ValueWithNote("19017581", "plerixafor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin lispro", new ValueWithNote("1550023", "insulin lispro") },
//             { "insulin lispro", new ValueWithNote("1550023", "insulin lispro") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "LEFlunomide", new ValueWithNote("1101898", "leflunomide") },
//             { "LEFlunomide", new ValueWithNote("1101898", "leflunomide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "levonorgestrel", new ValueWithNote("1589505", "levonorgestrel") },
//             { "levonorgestrel", new ValueWithNote("1589505", "levonorgestrel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "OLANZapine", new ValueWithNote("785788", "olanzapine") },
//             { "OLANZapine", new ValueWithNote("785788", "olanzapine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "posaconazole", new ValueWithNote("1704139", "posaconazole") },
//             { "posaconazole", new ValueWithNote("1704139", "posaconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "linezolid", new ValueWithNote("1736887", "linezolid") },
//             { "linezolid", new ValueWithNote("1736887", "linezolid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "olmesartan", new ValueWithNote("40226742", "olmesartan") },
//             { "olmesartan", new ValueWithNote("40226742", "olmesartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "orlistat", new ValueWithNote("741530", "orlistat") },
//             { "orlistat", new ValueWithNote("741530", "orlistat") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ixekizumab", new ValueWithNote("35603563", "ixekizumab") },
//             { "ixekizumab", new ValueWithNote("35603563", "ixekizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ketoconazole", new ValueWithNote("985708", "ketoconazole") },
//             { "ketoconazole", new ValueWithNote("985708", "ketoconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ivermectin", new ValueWithNote("1784444", "ivermectin") },
//             { "ivermectin", new ValueWithNote("1784444", "ivermectin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "labetalol", new ValueWithNote("1386957", "labetalol") },
//             { "labetalol", new ValueWithNote("1386957", "labetalol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ketoprofen", new ValueWithNote("1185922", "ketoprofen") },
//             { "ketoprofen", new ValueWithNote("1185922", "ketoprofen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "LACIdipine", new ValueWithNote("19004539", "lacidipine") },
//             { "LACIdipine", new ValueWithNote("19004539", "lacidipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lanolin", new ValueWithNote("19087317", "lanolin") },
//             { "lanolin", new ValueWithNote("19087317", "lanolin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pravastatin", new ValueWithNote("1551860", "pravastatin") },
//             { "pravastatin", new ValueWithNote("1551860", "pravastatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "prazosin", new ValueWithNote("1350489", "prazosin") },
//             { "prazosin", new ValueWithNote("1350489", "prazosin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "IMatinib", new ValueWithNote("1304107", "imatinib") },
//             { "IMatinib", new ValueWithNote("1304107", "imatinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "imiquimod", new ValueWithNote("981691", "imiquimod") },
//             { "imiquimod", new ValueWithNote("981691", "imiquimod") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lanreotide", new ValueWithNote("1503501", "lanreotide") },
//             { "lanreotide", new ValueWithNote("1503501", "lanreotide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lenalidomide", new ValueWithNote("19026972", "lenalidomide") },
//             { "lenalidomide", new ValueWithNote("19026972", "lenalidomide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "primaquine", new ValueWithNote("1751310", "primaquine") },
//             { "primaquine", new ValueWithNote("1751310", "primaquine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lithium", new ValueWithNote("19124477", "lithium") },
//             { "lithium", new ValueWithNote("19124477", "lithium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "LEVObupivacaine", new ValueWithNote("19098741", "levobupivacaine") },
//             { "LEVObupivacaine", new ValueWithNote("19098741", "levobupivacaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "propylthiouracil", new ValueWithNote("1554072", "propylthiouracil") },
//             { "propylthiouracil", new ValueWithNote("1554072", "propylthiouracil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pyrazinamide", new ValueWithNote("1759455", "pyrazinamide") },
//             { "pyrazinamide", new ValueWithNote("1759455", "pyrazinamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "magnesium oxide", new ValueWithNote("993631", "magnesium oxide") },
//             { "magnesium oxide", new ValueWithNote("993631", "magnesium oxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "magnesium sulfate", new ValueWithNote("19093848", "magnesium sulfate") },
//             { "magnesium sulfate", new ValueWithNote("19093848", "magnesium sulfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "loprazolam", new ValueWithNote("19042550", "triazulenone") },
//             { "loprazolam", new ValueWithNote("19042550", "triazulenone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lymecycline", new ValueWithNote("19092353", "lymecycline") },
//             { "lymecycline", new ValueWithNote("19092353", "lymecycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pyridostigmine", new ValueWithNote("759740", "pyridostigmine") },
//             { "pyridostigmine", new ValueWithNote("759740", "pyridostigmine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "RABEprazole", new ValueWithNote("911735", "rabeprazole") },
//             { "RABEprazole", new ValueWithNote("911735", "rabeprazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "melatonin", new ValueWithNote("1301152", "melatonin") },
//             { "melatonin", new ValueWithNote("1301152", "melatonin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mesna", new ValueWithNote("1354698", "mesna") },
//             { "mesna", new ValueWithNote("1354698", "mesna") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lamoTRIgine", new ValueWithNote("705103", "lamotrigine") },
//             { "lamoTRIgine", new ValueWithNote("705103", "lamotrigine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "paracetamol", new ValueWithNote("1125315", "acetaminophen") },
//             { "paracetamol", new ValueWithNote("1125315", "acetaminophen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "insulin glulisine", new ValueWithNote("1544838", "insulin glulisine, human") },
//             { "insulin glulisine", new ValueWithNote("1544838", "insulin glulisine, human") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "irbesartan", new ValueWithNote("1347384", "irbesartan") },
//             { "irbesartan", new ValueWithNote("1347384", "irbesartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mebeverine", new ValueWithNote("19008994", "mebeverine") },
//             { "mebeverine", new ValueWithNote("19008994", "mebeverine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "magnesium citrate", new ValueWithNote("967861", "magnesium citrate") },
//             { "magnesium citrate", new ValueWithNote("967861", "magnesium citrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ramipril", new ValueWithNote("1334456", "ramipril") },
//             { "ramipril", new ValueWithNote("1334456", "ramipril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "remdesivir", new ValueWithNote("37499271", "remdesivir") },
//             { "remdesivir", new ValueWithNote("37499271", "remdesivir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methyl salicylate", new ValueWithNote("909440", "methyl salicylate") },
//             { "methyl salicylate", new ValueWithNote("909440", "methyl salicylate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "miconazole", new ValueWithNote("907879", "miconazole") },
//             { "miconazole", new ValueWithNote("907879", "miconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "levoMEPromazine", new ValueWithNote("19005147", "methotrimeprazine") },
//             { "levoMEPromazine", new ValueWithNote("19005147", "methotrimeprazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lidocaine", new ValueWithNote("989878", "lidocaine") },
//             { "lidocaine", new ValueWithNote("989878", "lidocaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ribavirin", new ValueWithNote("1762711", "ribavirin") },
//             { "ribavirin", new ValueWithNote("1762711", "ribavirin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rifaMPICIN", new ValueWithNote("1763204", "rifampin") },
//             { "rifaMPICIN", new ValueWithNote("1763204", "rifampin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methocarbamol", new ValueWithNote("704943", "methocarbamol") },
//             { "methocarbamol", new ValueWithNote("704943", "methocarbamol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methylnaltrexone", new ValueWithNote("909841", "methylnaltrexone") },
//             { "methylnaltrexone", new ValueWithNote("909841", "methylnaltrexone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "paricalcitol", new ValueWithNote("1517740", "paricalcitol") },
//             { "paricalcitol", new ValueWithNote("1517740", "paricalcitol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "perindopril", new ValueWithNote("1373225", "perindopril") },
//             { "perindopril", new ValueWithNote("1373225", "perindopril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "isosorbide Dinitrate", new ValueWithNote("1383925", "isosorbide dinitrate") },
//             { "isosorbide Dinitrate", new ValueWithNote("1383925", "isosorbide dinitrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ispaghula", new ValueWithNote("19132967", "ispaghula extract") },
//             { "ispaghula", new ValueWithNote("19132967", "ispaghula extract") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mirtazapine", new ValueWithNote("725131", "mirtazapine") },
//             { "mirtazapine", new ValueWithNote("725131", "mirtazapine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "misoprostol", new ValueWithNote("1150871", "misoprostol") },
//             { "misoprostol", new ValueWithNote("1150871", "misoprostol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "liraglutide", new ValueWithNote("40170911", "liraglutide") },
//             { "liraglutide", new ValueWithNote("40170911", "liraglutide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lisinopril", new ValueWithNote("1308216", "lisinopril") },
//             { "lisinopril", new ValueWithNote("1308216", "lisinopril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rilpivirine", new ValueWithNote("40238930", "rilpivirine") },
//             { "rilpivirine", new ValueWithNote("40238930", "rilpivirine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "micafungin", new ValueWithNote("19018013", "micafungin") },
//             { "micafungin", new ValueWithNote("19018013", "micafungin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lixisenatide", new ValueWithNote("44506754", "lixisenatide") },
//             { "lixisenatide", new ValueWithNote("44506754", "lixisenatide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "loperamide", new ValueWithNote("991876", "loperamide") },
//             { "loperamide", new ValueWithNote("991876", "loperamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "LORazepam", new ValueWithNote("791967", "lorazepam") },
//             { "LORazepam", new ValueWithNote("791967", "lorazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lormetazepam", new ValueWithNote("19007977", "lormetazepam") },
//             { "lormetazepam", new ValueWithNote("19007977", "lormetazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rocuronium", new ValueWithNote("19003953", "rocuronium") },
//             { "rocuronium", new ValueWithNote("19003953", "rocuronium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ivacaftor", new ValueWithNote("42709323", "ivacaftor") },
//             { "ivacaftor", new ValueWithNote("42709323", "ivacaftor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naldemedine", new ValueWithNote("1593619", "naldemedine") },
//             { "naldemedine", new ValueWithNote("1593619", "naldemedine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mannitol", new ValueWithNote("994058", "mannitol") },
//             { "mannitol", new ValueWithNote("994058", "mannitol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ketorolac", new ValueWithNote("1136980", "ketorolac") },
//             { "ketorolac", new ValueWithNote("1136980", "ketorolac") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "morphine", new ValueWithNote("1110410", "morphine") },
//             { "morphine", new ValueWithNote("1110410", "morphine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naloxegol", new ValueWithNote("45774613", "naloxegol") },
//             { "naloxegol", new ValueWithNote("45774613", "naloxegol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "romosozumab", new ValueWithNote("1511251", "romosozumab") },
//             { "romosozumab", new ValueWithNote("1511251", "romosozumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rufinamide", new ValueWithNote("19006586", "rufinamide") },
//             { "rufinamide", new ValueWithNote("19006586", "rufinamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lansoprazole", new ValueWithNote("929887", "lansoprazole") },
//             { "lansoprazole", new ValueWithNote("929887", "lansoprazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lanthanum carbonate", new ValueWithNote("990028", "lanthanum carbonate") },
//             { "lanthanum carbonate", new ValueWithNote("990028", "lanthanum carbonate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "malathion", new ValueWithNote("993979", "malathion") },
//             { "malathion", new ValueWithNote("993979", "malathion") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "medroxyPROGESTERone", new ValueWithNote("1500211", "medroxyprogesterone") },
//             { "medroxyPROGESTERone", new ValueWithNote("1500211", "medroxyprogesterone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "megestrol", new ValueWithNote("1300978", "megestrol") },
//             { "megestrol", new ValueWithNote("1300978", "megestrol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "menthol", new ValueWithNote("901656", "menthol") },
//             { "menthol", new ValueWithNote("901656", "menthol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mepolizumab", new ValueWithNote("35606631", "mepolizumab") },
//             { "mepolizumab", new ValueWithNote("35606631", "mepolizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metaraminol", new ValueWithNote("19003303", "metaraminol") },
//             { "metaraminol", new ValueWithNote("19003303", "metaraminol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "salMETerol", new ValueWithNote("1137529", "salmeterol") },
//             { "salMETerol", new ValueWithNote("1137529", "salmeterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "neomycin", new ValueWithNote("915981", "neomycin") },
//             { "neomycin", new ValueWithNote("915981", "neomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Nirsevimab", new ValueWithNote("746155", "nirsevimab") },
//             { "Nirsevimab", new ValueWithNote("746155", "nirsevimab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nusinersen", new ValueWithNote("1593031", "nusinersen") },
//             { "nusinersen", new ValueWithNote("1593031", "nusinersen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methadone", new ValueWithNote("1103640", "methadone") },
//             { "methadone", new ValueWithNote("1103640", "methadone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "plasma protein fraction", new ValueWithNote("19025693", "plasma protein fraction") },
//             { "plasma protein fraction", new ValueWithNote("19025693", "plasma protein fraction") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "OXcarbazepine", new ValueWithNote("718122", "oxcarbazepine") },
//             { "OXcarbazepine", new ValueWithNote("718122", "oxcarbazepine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methotrexate", new ValueWithNote("1305058", "methotrexate") },
//             { "methotrexate", new ValueWithNote("1305058", "methotrexate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "omeprazole", new ValueWithNote("923645", "omeprazole") },
//             { "omeprazole", new ValueWithNote("923645", "omeprazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methoxyflurane", new ValueWithNote("19005257", "methoxyflurane") },
//             { "methoxyflurane", new ValueWithNote("19005257", "methoxyflurane") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metolazone", new ValueWithNote("907013", "metolazone") },
//             { "metolazone", new ValueWithNote("907013", "metolazone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oxycodone", new ValueWithNote("1124957", "oxycodone") },
//             { "oxycodone", new ValueWithNote("1124957", "oxycodone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "paliperidone", new ValueWithNote("40137339", "paliperidone") },
//             { "paliperidone", new ValueWithNote("40137339", "paliperidone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metyrapone", new ValueWithNote("19007490", "metyrapone") },
//             { "metyrapone", new ValueWithNote("19007490", "metyrapone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "midodrine", new ValueWithNote("1308368", "midodrine") },
//             { "midodrine", new ValueWithNote("1308368", "midodrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mebendazole", new ValueWithNote("1794280", "mebendazole") },
//             { "mebendazole", new ValueWithNote("1794280", "mebendazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "palivizumab", new ValueWithNote("537647", "palivizumab") },
//             { "palivizumab", new ValueWithNote("537647", "palivizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "papaverine", new ValueWithNote("1326901", "papaverine") },
//             { "papaverine", new ValueWithNote("1326901", "papaverine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "midazolam", new ValueWithNote("708298", "midazolam") },
//             { "midazolam", new ValueWithNote("708298", "midazolam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mizolastine", new ValueWithNote("19086100", "mizolastine") },
//             { "mizolastine", new ValueWithNote("19086100", "mizolastine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "parecoxib", new ValueWithNote("19003570", "parecoxib") },
//             { "parecoxib", new ValueWithNote("19003570", "parecoxib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "meloxicam", new ValueWithNote("1150345", "meloxicam") },
//             { "meloxicam", new ValueWithNote("1150345", "meloxicam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "moclobemide", new ValueWithNote("19010652", "moclobemide") },
//             { "moclobemide", new ValueWithNote("19010652", "moclobemide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naproxen", new ValueWithNote("1115008", "naproxen") },
//             { "naproxen", new ValueWithNote("1115008", "naproxen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ondansetron", new ValueWithNote("1000560", "ondansetron") },
//             { "ondansetron", new ValueWithNote("1000560", "ondansetron") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naratriptan", new ValueWithNote("1118117", "naratriptan") },
//             { "naratriptan", new ValueWithNote("1118117", "naratriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium dihydrogen phosphate", new ValueWithNote("990499", "sodium phosphate, monobasic") },
//             { "sodium dihydrogen phosphate", new ValueWithNote("990499", "sodium phosphate, monobasic") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium feredetate", new ValueWithNote("19001131", "sodium ironedetate") },
//             { "sodium feredetate", new ValueWithNote("19001131", "sodium ironedetate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "meningococcal group B vaccine", new ValueWithNote("45775636", "meningococcal group B vaccine") },
//             { "meningococcal group B vaccine", new ValueWithNote("45775636", "meningococcal group B vaccine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mitotane", new ValueWithNote("1309161", "mitotane") },
//             { "mitotane", new ValueWithNote("1309161", "mitotane") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "moxonidine", new ValueWithNote("19011021", "moxonidine") },
//             { "moxonidine", new ValueWithNote("19011021", "moxonidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pancreatin", new ValueWithNote("926487", "pancreatin") },
//             { "pancreatin", new ValueWithNote("926487", "pancreatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "PARoxetine", new ValueWithNote("722031", "paroxetine") },
//             { "PARoxetine", new ValueWithNote("722031", "paroxetine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "potassium citrate", new ValueWithNote("976545", "potassium citrate") },
//             { "potassium citrate", new ValueWithNote("976545", "potassium citrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pristinamycin", new ValueWithNote("19125201", "pristinamycin") },
//             { "pristinamycin", new ValueWithNote("19125201", "pristinamycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mercaptOPURine", new ValueWithNote("1436650", "mercaptopurine") },
//             { "mercaptOPURine", new ValueWithNote("1436650", "mercaptopurine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metFORMIN", new ValueWithNote("1503297", "metformin") },
//             { "metFORMIN", new ValueWithNote("1503297", "metformin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nadolol", new ValueWithNote("1313200", "nadolol") },
//             { "nadolol", new ValueWithNote("1313200", "nadolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nitrofurantoin", new ValueWithNote("920293", "nitrofurantoin") },
//             { "nitrofurantoin", new ValueWithNote("920293", "nitrofurantoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "neostigmine", new ValueWithNote("717136", "neostigmine") },
//             { "neostigmine", new ValueWithNote("717136", "neostigmine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sugammadex", new ValueWithNote("35604506", "sugammadex") },
//             { "sugammadex", new ValueWithNote("35604506", "sugammadex") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "SUMAtriptan", new ValueWithNote("1140643", "sumatriptan") },
//             { "SUMAtriptan", new ValueWithNote("1140643", "sumatriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pegfilgrastim", new ValueWithNote("1325608", "pegfilgrastim") },
//             { "pegfilgrastim", new ValueWithNote("1325608", "pegfilgrastim") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "perampanel", new ValueWithNote("42904177", "perampanel") },
//             { "perampanel", new ValueWithNote("42904177", "perampanel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nizatidine", new ValueWithNote("950696", "nizatidine") },
//             { "nizatidine", new ValueWithNote("950696", "nizatidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "norTRIPtyline", new ValueWithNote("721724", "nortriptyline") },
//             { "norTRIPtyline", new ValueWithNote("721724", "nortriptyline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pasireotide", new ValueWithNote("43012417", "pasireotide") },
//             { "pasireotide", new ValueWithNote("43012417", "pasireotide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pentosan polysulfate sodium", new ValueWithNote("19011333", "pentosan polysulphate sodium") },
//             { "pentosan polysulfate sodium", new ValueWithNote("19011333", "pentosan polysulphate sodium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "promazine", new ValueWithNote("19052903", "promazine") },
//             { "promazine", new ValueWithNote("19052903", "promazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "propiverine", new ValueWithNote("19077093", "propiverine") },
//             { "propiverine", new ValueWithNote("19077093", "propiverine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methyldopa", new ValueWithNote("1305447", "methyldopa") },
//             { "methyldopa", new ValueWithNote("1305447", "methyldopa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methylPREDNISolone", new ValueWithNote("1506270", "methylprednisolone") },
//             { "methylPREDNISolone", new ValueWithNote("1506270", "methylprednisolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "niCARdipine", new ValueWithNote("1318137", "nicardipine") },
//             { "niCARdipine", new ValueWithNote("1318137", "nicardipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "niMOdipine", new ValueWithNote("1319133", "nimodipine") },
//             { "niMOdipine", new ValueWithNote("1319133", "nimodipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "phenobarbital", new ValueWithNote("734275", "phenobarbital") },
//             { "phenobarbital", new ValueWithNote("734275", "phenobarbital") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pioglitazone", new ValueWithNote("1525215", "pioglitazone") },
//             { "pioglitazone", new ValueWithNote("1525215", "pioglitazone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Olive oil", new ValueWithNote("42900448", "olive oil") },
//             { "Olive oil", new ValueWithNote("42900448", "olive oil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "orphenadrine", new ValueWithNote("724394", "orphenadrine") },
//             { "orphenadrine", new ValueWithNote("724394", "orphenadrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pyrimethamine", new ValueWithNote("1760039", "pyrimethamine") },
//             { "pyrimethamine", new ValueWithNote("1760039", "pyrimethamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "quinapril", new ValueWithNote("1331235", "quinapril") },
//             { "quinapril", new ValueWithNote("1331235", "quinapril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methylthioninium chloride", new ValueWithNote("905518", "methylene blue") },
//             { "methylthioninium chloride", new ValueWithNote("905518", "methylene blue") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metoclopramide", new ValueWithNote("906780", "metoclopramide") },
//             { "metoclopramide", new ValueWithNote("906780", "metoclopramide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "metoprolol", new ValueWithNote("1307046", "metoprolol") },
//             { "metoprolol", new ValueWithNote("1307046", "metoprolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mexiletine", new ValueWithNote("1307542", "mexiletine") },
//             { "mexiletine", new ValueWithNote("1307542", "mexiletine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nitrazepam", new ValueWithNote("19020021", "nitrazepam") },
//             { "nitrazepam", new ValueWithNote("19020021", "nitrazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pentoxifylline", new ValueWithNote("1331247", "pentoxifylline") },
//             { "pentoxifylline", new ValueWithNote("1331247", "pentoxifylline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "perhexiline", new ValueWithNote("19032359", "perhexiline") },
//             { "perhexiline", new ValueWithNote("19032359", "perhexiline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tamoxifen", new ValueWithNote("1436678", "tamoxifen") },
//             { "tamoxifen", new ValueWithNote("1436678", "tamoxifen") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "teicoplanin", new ValueWithNote("19078399", "teicoplanin") },
//             { "teicoplanin", new ValueWithNote("19078399", "teicoplanin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nystatin", new ValueWithNote("922570", "nystatin") },
//             { "nystatin", new ValueWithNote("922570", "nystatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oxybutynin", new ValueWithNote("918906", "oxybutynin") },
//             { "oxybutynin", new ValueWithNote("918906", "oxybutynin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pantoprazole", new ValueWithNote("948078", "pantoprazole") },
//             { "pantoprazole", new ValueWithNote("948078", "pantoprazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "paraldehyde", new ValueWithNote("19027181", "paraldehyde") },
//             { "paraldehyde", new ValueWithNote("19027181", "paraldehyde") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "piroxicam", new ValueWithNote("1146810", "piroxicam") },
//             { "piroxicam", new ValueWithNote("1146810", "piroxicam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "phenoxybenzamine", new ValueWithNote("1335301", "phenoxybenzamine") },
//             { "phenoxybenzamine", new ValueWithNote("1335301", "phenoxybenzamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "phenylephrine", new ValueWithNote("1135766", "phenylephrine") },
//             { "phenylephrine", new ValueWithNote("1135766", "phenylephrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "poractant alfa", new ValueWithNote("19091377", "poractant alfa") },
//             { "poractant alfa", new ValueWithNote("19091377", "poractant alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mirabegron", new ValueWithNote("42873636", "mirabegron") },
//             { "mirabegron", new ValueWithNote("42873636", "mirabegron") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "paromomycin", new ValueWithNote("1727443", "paromomycin") },
//             { "paromomycin", new ValueWithNote("1727443", "paromomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pazopanib", new ValueWithNote("40167554", "pazopanib") },
//             { "pazopanib", new ValueWithNote("40167554", "pazopanib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "petrolatum", new ValueWithNote("19033354", "petrolatum") },
//             { "petrolatum", new ValueWithNote("19033354", "petrolatum") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "piracetam", new ValueWithNote("19046654", "piracetam") },
//             { "piracetam", new ValueWithNote("19046654", "piracetam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ranitidine", new ValueWithNote("961047", "ranitidine") },
//             { "ranitidine", new ValueWithNote("961047", "ranitidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rasagiline", new ValueWithNote("715710", "rasagiline") },
//             { "rasagiline", new ValueWithNote("715710", "rasagiline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "telmisartan", new ValueWithNote("1317640", "telmisartan") },
//             { "telmisartan", new ValueWithNote("1317640", "telmisartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "temocillin", new ValueWithNote("19100438", "temocillin") },
//             { "temocillin", new ValueWithNote("19100438", "temocillin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Mirikizumab", new ValueWithNote("746977", "mirikizumab") },
//             { "Mirikizumab", new ValueWithNote("746977", "mirikizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "potassium canrenoate", new ValueWithNote("19019629", "canrenoate potassium") },
//             { "potassium canrenoate", new ValueWithNote("19019629", "canrenoate potassium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "moxifloxacin", new ValueWithNote("1716903", "moxifloxacin") },
//             { "moxifloxacin", new ValueWithNote("1716903", "moxifloxacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rivaroxaban", new ValueWithNote("40241331", "rivaroxaban") },
//             { "rivaroxaban", new ValueWithNote("40241331", "rivaroxaban") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "phenytoin", new ValueWithNote("740910", "phenytoin") },
//             { "phenytoin", new ValueWithNote("740910", "phenytoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pholcodine", new ValueWithNote("19024213", "pholcodine") },
//             { "pholcodine", new ValueWithNote("19024213", "pholcodine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rosuvastatin", new ValueWithNote("1510813", "rosuvastatin") },
//             { "rosuvastatin", new ValueWithNote("1510813", "rosuvastatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ruxolitinib", new ValueWithNote("40244464", "ruxolitinib") },
//             { "ruxolitinib", new ValueWithNote("40244464", "ruxolitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "potassium iodate", new ValueWithNote("19095275", "potassium iodate") },
//             { "potassium iodate", new ValueWithNote("19095275", "potassium iodate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pramipexole", new ValueWithNote("720810", "pramipexole") },
//             { "pramipexole", new ValueWithNote("720810", "pramipexole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pivmecillinam", new ValueWithNote("19088223", "amdinocillin pivoxil") },
//             { "pivmecillinam", new ValueWithNote("19088223", "amdinocillin pivoxil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pizotifen", new ValueWithNote("19047076", "pizotyline") },
//             { "pizotifen", new ValueWithNote("19047076", "pizotyline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mycophenolate mofetil", new ValueWithNote("19003999", "mycophenolate mofetil") },
//             { "mycophenolate mofetil", new ValueWithNote("19003999", "mycophenolate mofetil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "TERIFlunomide", new ValueWithNote("42900584", "teriflunomide") },
//             { "TERIFlunomide", new ValueWithNote("42900584", "teriflunomide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "terlipressin", new ValueWithNote("19119253", "terlipressin") },
//             { "terlipressin", new ValueWithNote("19119253", "terlipressin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "potassium iodide", new ValueWithNote("19049909", "potassium iodide") },
//             { "potassium iodide", new ValueWithNote("19049909", "potassium iodide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "propafenone", new ValueWithNote("1353256", "propafenone") },
//             { "propafenone", new ValueWithNote("1353256", "propafenone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "palonosetron", new ValueWithNote("911354", "palonosetron") },
//             { "palonosetron", new ValueWithNote("911354", "palonosetron") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pseudoephedrine", new ValueWithNote("1154332", "pseudoephedrine") },
//             { "pseudoephedrine", new ValueWithNote("1154332", "pseudoephedrine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "raltegravir", new ValueWithNote("1712889", "raltegravir") },
//             { "raltegravir", new ValueWithNote("1712889", "raltegravir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "peniciLLAMINE", new ValueWithNote("19028050", "penicillamine") },
//             { "peniciLLAMINE", new ValueWithNote("19028050", "penicillamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pentazocine", new ValueWithNote("1130585", "pentazocine") },
//             { "pentazocine", new ValueWithNote("1130585", "pentazocine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "selegiline", new ValueWithNote("766209", "selegiline") },
//             { "selegiline", new ValueWithNote("766209", "selegiline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "semaglutide", new ValueWithNote("793143", "semaglutide") },
//             { "semaglutide", new ValueWithNote("793143", "semaglutide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naloxone", new ValueWithNote("1114220", "naloxone") },
//             { "naloxone", new ValueWithNote("1114220", "naloxone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "naltrexone", new ValueWithNote("1714319", "naltrexone") },
//             { "naltrexone", new ValueWithNote("1714319", "naltrexone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sevelamer", new ValueWithNote("952004", "sevelamer") },
//             { "sevelamer", new ValueWithNote("952004", "sevelamer") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sildenafil", new ValueWithNote("1316262", "sildenafil") },
//             { "sildenafil", new ValueWithNote("1316262", "sildenafil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "procaine benzylpenicillin", new ValueWithNote("19130403", "penicillin G procaine") },
//             { "procaine benzylpenicillin", new ValueWithNote("19130403", "penicillin G procaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "protamine", new ValueWithNote("19054245", "protamines") },
//             { "protamine", new ValueWithNote("19054245", "protamines") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "phenindione", new ValueWithNote("19033934", "phenindione") },
//             { "phenindione", new ValueWithNote("19033934", "phenindione") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "silver sulfADIAZINE", new ValueWithNote("966956", "silver sulfadiazine") },
//             { "silver sulfADIAZINE", new ValueWithNote("966956", "silver sulfadiazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium benzoate", new ValueWithNote("19116573", "sodium benzoate") },
//             { "sodium benzoate", new ValueWithNote("19116573", "sodium benzoate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "prucalopride", new ValueWithNote("1356018", "prucalopride") },
//             { "prucalopride", new ValueWithNote("1356018", "prucalopride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "quiNINE", new ValueWithNote("1760616", "quinine") },
//             { "quiNINE", new ValueWithNote("1760616", "quinine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "secukinumab", new ValueWithNote("45892883", "secukinumab") },
//             { "secukinumab", new ValueWithNote("45892883", "secukinumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tetanus immunoglobulin", new ValueWithNote("35604680", "tetanus immune globulin") },
//             { "tetanus immunoglobulin", new ValueWithNote("35604680", "tetanus immune globulin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tigecycline", new ValueWithNote("1742432", "tigecycline") },
//             { "tigecycline", new ValueWithNote("1742432", "tigecycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "prilocaine", new ValueWithNote("951279", "prilocaine") },
//             { "prilocaine", new ValueWithNote("951279", "prilocaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "probenecid", new ValueWithNote("1151422", "probenecid") },
//             { "probenecid", new ValueWithNote("1151422", "probenecid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "phytomenadione", new ValueWithNote("19044727", "vitamin K1") },
//             { "phytomenadione", new ValueWithNote("19044727", "vitamin K1") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pilocarpine", new ValueWithNote("945286", "pilocarpine") },
//             { "pilocarpine", new ValueWithNote("945286", "pilocarpine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tiotropium", new ValueWithNote("1106776", "tiotropium") },
//             { "tiotropium", new ValueWithNote("1106776", "tiotropium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "simvastatin", new ValueWithNote("1539403", "simvastatin") },
//             { "simvastatin", new ValueWithNote("1539403", "simvastatin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium chloride", new ValueWithNote("967823", "sodium chloride") },
//             { "sodium chloride", new ValueWithNote("967823", "sodium chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "potassium chloride", new ValueWithNote("19049105", "potassium chloride") },
//             { "potassium chloride", new ValueWithNote("19049105", "potassium chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "TOLBUTamide", new ValueWithNote("1502855", "tolbutamide") },
//             { "TOLBUTamide", new ValueWithNote("1502855", "tolbutamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tranylcypromine", new ValueWithNote("703470", "tranylcypromine") },
//             { "tranylcypromine", new ValueWithNote("703470", "tranylcypromine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "promethazine", new ValueWithNote("1153013", "promethazine") },
//             { "promethazine", new ValueWithNote("1153013", "promethazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "propranolol", new ValueWithNote("1353766", "propranolol") },
//             { "propranolol", new ValueWithNote("1353766", "propranolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nicorandil", new ValueWithNote("19014977", "nicorandil") },
//             { "nicorandil", new ValueWithNote("19014977", "nicorandil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ofloxacin", new ValueWithNote("923081", "ofloxacin") },
//             { "ofloxacin", new ValueWithNote("923081", "ofloxacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "raloxifene", new ValueWithNote("1513103", "raloxifene") },
//             { "raloxifene", new ValueWithNote("1513103", "raloxifene") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "quiNIDine", new ValueWithNote("1360421", "quinidine") },
//             { "quiNIDine", new ValueWithNote("1360421", "quinidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium bicarbonate", new ValueWithNote("939506", "sodium bicarbonate") },
//             { "sodium bicarbonate", new ValueWithNote("939506", "sodium bicarbonate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ritonavir", new ValueWithNote("1748921", "ritonavir") },
//             { "ritonavir", new ValueWithNote("1748921", "ritonavir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rizatriptan", new ValueWithNote("1154077", "rizatriptan") },
//             { "rizatriptan", new ValueWithNote("1154077", "rizatriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "trifluoperazine", new ValueWithNote("704984", "trifluoperazine") },
//             { "trifluoperazine", new ValueWithNote("704984", "trifluoperazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "reboxetine", new ValueWithNote("19084693", "reboxetine") },
//             { "reboxetine", new ValueWithNote("19084693", "reboxetine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "reslizumab", new ValueWithNote("35603983", "reslizumab") },
//             { "reslizumab", new ValueWithNote("35603983", "reslizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "upadacitinib", new ValueWithNote("1361580", "upadacitinib") },
//             { "upadacitinib", new ValueWithNote("1361580", "upadacitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "urea", new ValueWithNote("906914", "urea") },
//             { "urea", new ValueWithNote("906914", "urea") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rOPINIRole", new ValueWithNote("713823", "ropinirole") },
//             { "rOPINIRole", new ValueWithNote("713823", "ropinirole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ropivacaine", new ValueWithNote("1136487", "ropivacaine") },
//             { "ropivacaine", new ValueWithNote("1136487", "ropivacaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "prochlorperazine", new ValueWithNote("752061", "prochlorperazine") },
//             { "prochlorperazine", new ValueWithNote("752061", "prochlorperazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "procyclidine", new ValueWithNote("752276", "procyclidine") },
//             { "procyclidine", new ValueWithNote("752276", "procyclidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rifaBUTIN", new ValueWithNote("1777417", "rifabutin") },
//             { "rifaBUTIN", new ValueWithNote("1777417", "rifabutin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rifaXIMIN", new ValueWithNote("1735947", "rifaximin") },
//             { "rifaXIMIN", new ValueWithNote("1735947", "rifaximin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium picosulfate", new ValueWithNote("19025115", "picosulfate sodium") },
//             { "sodium picosulfate", new ValueWithNote("19025115", "picosulfate sodium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "omega-3 fatty acids", new ValueWithNote("19106973", "omega-3 fatty acids") },
//             { "omega-3 fatty acids", new ValueWithNote("19106973", "omega-3 fatty acids") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Rozanolixizumab", new ValueWithNote("746106", "rozanolixizumab") },
//             { "Rozanolixizumab", new ValueWithNote("746106", "rozanolixizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "propofol", new ValueWithNote("753626", "propofol") },
//             { "propofol", new ValueWithNote("753626", "propofol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pyridoxine", new ValueWithNote("19005046", "pyridoxine") },
//             { "pyridoxine", new ValueWithNote("19005046", "pyridoxine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "riluzole", new ValueWithNote("735951", "riluzole") },
//             { "riluzole", new ValueWithNote("735951", "riluzole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "riTUXimab", new ValueWithNote("1314273", "rituximab") },
//             { "riTUXimab", new ValueWithNote("1314273", "rituximab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oxandrolone", new ValueWithNote("1524769", "oxandrolone") },
//             { "oxandrolone", new ValueWithNote("1524769", "oxandrolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oxazepam", new ValueWithNote("724816", "oxazepam") },
//             { "oxazepam", new ValueWithNote("724816", "oxazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "urokinase", new ValueWithNote("1307515", "urokinase") },
//             { "urokinase", new ValueWithNote("1307515", "urokinase") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "valsartan", new ValueWithNote("1308842", "valsartan") },
//             { "valsartan", new ValueWithNote("1308842", "valsartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vardenafil", new ValueWithNote("1311276", "vardenafil") },
//             { "vardenafil", new ValueWithNote("1311276", "vardenafil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium citrate", new ValueWithNote("977968", "sodium citrate") },
//             { "sodium citrate", new ValueWithNote("977968", "sodium citrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium hyaluronate", new ValueWithNote("19106560", "sodium hyaluronate") },
//             { "sodium hyaluronate", new ValueWithNote("19106560", "sodium hyaluronate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rasburicase", new ValueWithNote("1304565", "rasburicase") },
//             { "rasburicase", new ValueWithNote("1304565", "rasburicase") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "peginterferon alfa-2a", new ValueWithNote("1714165", "peginterferon alfa-2a") },
//             { "peginterferon alfa-2a", new ValueWithNote("1714165", "peginterferon alfa-2a") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vecuronium", new ValueWithNote("19012598", "vecuronium") },
//             { "vecuronium", new ValueWithNote("19012598", "vecuronium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vildagliptin", new ValueWithNote("19122137", "vildagliptin") },
//             { "vildagliptin", new ValueWithNote("19122137", "vildagliptin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rivastigmine", new ValueWithNote("733523", "rivastigmine") },
//             { "rivastigmine", new ValueWithNote("733523", "rivastigmine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "romiplostim", new ValueWithNote("19032407", "romiplostim") },
//             { "romiplostim", new ValueWithNote("19032407", "romiplostim") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium tetradecyl sulfate", new ValueWithNote("19070012", "sodium tetradecyl sulfate") },
//             { "sodium tetradecyl sulfate", new ValueWithNote("19070012", "sodium tetradecyl sulfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "somatropin", new ValueWithNote("1584910", "somatropin") },
//             { "somatropin", new ValueWithNote("1584910", "somatropin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "peppermint oil", new ValueWithNote("19086712", "peppermint oil") },
//             { "peppermint oil", new ValueWithNote("19086712", "peppermint oil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vitamin E", new ValueWithNote("19009540", "vitamin E") },
//             { "vitamin E", new ValueWithNote("19009540", "vitamin E") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "risedronate sodium", new ValueWithNote("19122562", "risedronate sodium") },
//             { "risedronate sodium", new ValueWithNote("19122562", "risedronate sodium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "roflumilast", new ValueWithNote("40236897", "roflumilast") },
//             { "roflumilast", new ValueWithNote("40236897", "roflumilast") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sarilumab", new ValueWithNote("1594587", "sarilumab") },
//             { "sarilumab", new ValueWithNote("1594587", "sarilumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sulindac", new ValueWithNote("1236607", "sulindac") },
//             { "sulindac", new ValueWithNote("1236607", "sulindac") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zinc sulfate", new ValueWithNote("19044522", "zinc sulfate") },
//             { "zinc sulfate", new ValueWithNote("19044522", "zinc sulfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zolpidem", new ValueWithNote("744740", "zolpidem") },
//             { "zolpidem", new ValueWithNote("744740", "zolpidem") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "stiripentol", new ValueWithNote("35200286", "stiripentol") },
//             { "stiripentol", new ValueWithNote("35200286", "stiripentol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sulfaSALAzine", new ValueWithNote("964339", "sulfasalazine") },
//             { "sulfaSALAzine", new ValueWithNote("964339", "sulfasalazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "temozolomide", new ValueWithNote("1341149", "temozolomide") },
//             { "temozolomide", new ValueWithNote("1341149", "temozolomide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "terbinafine", new ValueWithNote("1741309", "terbinafine") },
//             { "terbinafine", new ValueWithNote("1741309", "terbinafine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sofosbuvir/velpatasvir/voxilaprevir", new ValueWithNote("778968", "sofosbuvir / velpatasvir / voxilaprevir") },
//             { "sofosbuvir/velpatasvir/voxilaprevir", new ValueWithNote("778968", "sofosbuvir / velpatasvir / voxilaprevir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Erythromycin injection", new ValueWithNote("35603399", "erythromycin Injection") },
//             { "Erythromycin injection", new ValueWithNote("35603399", "erythromycin Injection") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ROtigoTine", new ValueWithNote("786426", "rotigotine") },
//             { "ROtigoTine", new ValueWithNote("786426", "rotigotine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "povidone iodine", new ValueWithNote("1750087", "povidone-iodine") },
//             { "povidone iodine", new ValueWithNote("1750087", "povidone-iodine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "praziquantel", new ValueWithNote("1750461", "praziquantel") },
//             { "praziquantel", new ValueWithNote("1750461", "praziquantel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "solifenacin", new ValueWithNote("916005", "solifenacin") },
//             { "solifenacin", new ValueWithNote("916005", "solifenacin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sterile water", new ValueWithNote("19009608", "sterile water") },
//             { "sterile water", new ValueWithNote("19009608", "sterile water") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sulfADIAZINE", new ValueWithNote("1836391", "sulfadiazine") },
//             { "sulfADIAZINE", new ValueWithNote("1836391", "sulfadiazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "thalidomide", new ValueWithNote("19137042", "thalidomide") },
//             { "thalidomide", new ValueWithNote("19137042", "thalidomide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "theophylline", new ValueWithNote("1237049", "theophylline") },
//             { "theophylline", new ValueWithNote("1237049", "theophylline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "siponimod", new ValueWithNote("1510913", "siponimod") },
//             { "siponimod", new ValueWithNote("1510913", "siponimod") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "suxamethonium", new ValueWithNote("836208", "succinylcholine") },
//             { "suxamethonium", new ValueWithNote("836208", "succinylcholine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tadalafil", new ValueWithNote("1336926", "tadalafil") },
//             { "tadalafil", new ValueWithNote("1336926", "tadalafil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "thiopental", new ValueWithNote("700253", "thiopental") },
//             { "thiopental", new ValueWithNote("700253", "thiopental") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tinzaparin", new ValueWithNote("1308473", "tinzaparin") },
//             { "tinzaparin", new ValueWithNote("1308473", "tinzaparin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Follitropin alfa", new ValueWithNote("1542948", "follitropin alfa") },
//             { "Follitropin alfa", new ValueWithNote("1542948", "follitropin alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Haloperidol decanoate", new ValueWithNote("19068898", "haloperidol decanoate") },
//             { "Haloperidol decanoate", new ValueWithNote("19068898", "haloperidol decanoate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "terazosin", new ValueWithNote("1341238", "terazosin") },
//             { "terazosin", new ValueWithNote("1341238", "terazosin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "teriparatide", new ValueWithNote("1521987", "teriparatide") },
//             { "teriparatide", new ValueWithNote("1521987", "teriparatide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sertraline", new ValueWithNote("739138", "sertraline") },
//             { "sertraline", new ValueWithNote("739138", "sertraline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Simoctocog alfa", new ValueWithNote("35604968", "simoctocog alfa") },
//             { "Simoctocog alfa", new ValueWithNote("35604968", "simoctocog alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tetracycline", new ValueWithNote("1836948", "tetracycline") },
//             { "tetracycline", new ValueWithNote("1836948", "tetracycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "thyrotropin alpha", new ValueWithNote("19063297", "thyrotropin alfa") },
//             { "thyrotropin alpha", new ValueWithNote("19063297", "thyrotropin alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sirolimus", new ValueWithNote("19034726", "sirolimus") },
//             { "sirolimus", new ValueWithNote("19034726", "sirolimus") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tezepelumab", new ValueWithNote("702498", "tezepelumab") },
//             { "tezepelumab", new ValueWithNote("702498", "tezepelumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tiopronin", new ValueWithNote("903031", "tiopronin") },
//             { "tiopronin", new ValueWithNote("903031", "tiopronin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium polystyrene sulfonate", new ValueWithNote("19078126", "sodium polystyrene sulfonate") },
//             { "sodium polystyrene sulfonate", new ValueWithNote("19078126", "sodium polystyrene sulfonate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "SORAfenib", new ValueWithNote("1363387", "sorafenib") },
//             { "SORAfenib", new ValueWithNote("1363387", "sorafenib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Lanolin", new ValueWithNote("19087317", "lanolin") },
//             { "Lanolin", new ValueWithNote("19087317", "lanolin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pregABALIN", new ValueWithNote("734354", "pregabalin") },
//             { "pregABALIN", new ValueWithNote("734354", "pregabalin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "procarbazine", new ValueWithNote("1351779", "procarbazine") },
//             { "procarbazine", new ValueWithNote("1351779", "procarbazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sotalol", new ValueWithNote("1370109", "sotalol") },
//             { "sotalol", new ValueWithNote("1370109", "sotalol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sulpiride", new ValueWithNote("19136626", "sulpiride") },
//             { "sulpiride", new ValueWithNote("19136626", "sulpiride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tirofiban", new ValueWithNote("19017067", "tirofiban") },
//             { "tirofiban", new ValueWithNote("19017067", "tirofiban") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "topotecan", new ValueWithNote("1378509", "topotecan") },
//             { "topotecan", new ValueWithNote("1378509", "topotecan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tacrolimus", new ValueWithNote("950637", "tacrolimus") },
//             { "tacrolimus", new ValueWithNote("950637", "tacrolimus") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tolvaptan", new ValueWithNote("19036797", "tolvaptan") },
//             { "tolvaptan", new ValueWithNote("19036797", "tolvaptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "trandolapril", new ValueWithNote("1342439", "trandolapril") },
//             { "trandolapril", new ValueWithNote("1342439", "trandolapril") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Promethazine hydrochloride", new ValueWithNote("19012193", "promethazine hydrochloride") },
//             { "Promethazine hydrochloride", new ValueWithNote("19012193", "promethazine hydrochloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "propantheline", new ValueWithNote("953391", "propantheline") },
//             { "propantheline", new ValueWithNote("953391", "propantheline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium glycerophosphate", new ValueWithNote("45892326", "sodium glycerophosphate") },
//             { "sodium glycerophosphate", new ValueWithNote("45892326", "sodium glycerophosphate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium phenylbutyrate", new ValueWithNote("19048721", "sodium phenylbutyrate") },
//             { "sodium phenylbutyrate", new ValueWithNote("19048721", "sodium phenylbutyrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Potassium phosphate", new ValueWithNote("19027362", "potassium phosphate") },
//             { "Potassium phosphate", new ValueWithNote("19027362", "potassium phosphate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ravulizumab", new ValueWithNote("1356009", "ravulizumab") },
//             { "ravulizumab", new ValueWithNote("1356009", "ravulizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "torasemide", new ValueWithNote("942350", "torsemide") },
//             { "torasemide", new ValueWithNote("942350", "torsemide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Turoctocog alfa", new ValueWithNote("35604313", "turoctocog alfa") },
//             { "Turoctocog alfa", new ValueWithNote("35604313", "turoctocog alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tretinoin", new ValueWithNote("903643", "tretinoin") },
//             { "tretinoin", new ValueWithNote("903643", "tretinoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "trimipramine", new ValueWithNote("705755", "trimipramine") },
//             { "trimipramine", new ValueWithNote("705755", "trimipramine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tryptophan", new ValueWithNote("19006186", "tryptophan") },
//             { "tryptophan", new ValueWithNote("19006186", "tryptophan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "riboflavin", new ValueWithNote("19062817", "riboflavin") },
//             { "riboflavin", new ValueWithNote("19062817", "riboflavin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "risankizumab", new ValueWithNote("1511348", "risankizumab") },
//             { "risankizumab", new ValueWithNote("1511348", "risankizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Trisodium citrate", new ValueWithNote("19065826", "trisodium citrate") },
//             { "Trisodium citrate", new ValueWithNote("19065826", "trisodium citrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tapentadol", new ValueWithNote("19026459", "tapentadol") },
//             { "tapentadol", new ValueWithNote("19026459", "tapentadol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "varicella vaccine", new ValueWithNote("42800027", "varicella-zoster virus vaccine live (Oka-Merck) strain") },
//             { "varicella vaccine", new ValueWithNote("42800027", "varicella-zoster virus vaccine live (Oka-Merck) strain") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "salBUTamol", new ValueWithNote("1154343", "albuterol") },
//             { "salBUTamol", new ValueWithNote("1154343", "albuterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "terbutaline", new ValueWithNote("1236744", "terbutaline") },
//             { "terbutaline", new ValueWithNote("1236744", "terbutaline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zanamivir", new ValueWithNote("1708748", "zanamivir") },
//             { "zanamivir", new ValueWithNote("1708748", "zanamivir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zoledronic acid", new ValueWithNote("1524674", "zoledronic acid") },
//             { "zoledronic acid", new ValueWithNote("1524674", "zoledronic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "saxagliptin", new ValueWithNote("40166035", "saxagliptin") },
//             { "saxagliptin", new ValueWithNote("40166035", "saxagliptin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium zirconium cyclosilicate", new ValueWithNote("1510687", "sodium zirconium cyclosilicate") },
//             { "sodium zirconium cyclosilicate", new ValueWithNote("1510687", "sodium zirconium cyclosilicate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "spironolactone", new ValueWithNote("970250", "spironolactone") },
//             { "spironolactone", new ValueWithNote("970250", "spironolactone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ursodeoxycholic acid", new ValueWithNote("19010877", "ursodiol") },
//             { "ursodeoxycholic acid", new ValueWithNote("19010877", "ursodiol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tetracosactide", new ValueWithNote("19008009", "cosyntropin") },
//             { "tetracosactide", new ValueWithNote("19008009", "cosyntropin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tobramycin", new ValueWithNote("902722", "tobramycin") },
//             { "tobramycin", new ValueWithNote("902722", "tobramycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vitamin A", new ValueWithNote("19008339", "vitamin A") },
//             { "vitamin A", new ValueWithNote("19008339", "vitamin A") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vortioxetine", new ValueWithNote("44507700", "vortioxetine") },
//             { "vortioxetine", new ValueWithNote("44507700", "vortioxetine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Voxelotor", new ValueWithNote("37497986", "voxelotor") },
//             { "Voxelotor", new ValueWithNote("37497986", "voxelotor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "valproate", new ValueWithNote("745466", "valproate") },
//             { "valproate", new ValueWithNote("745466", "valproate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Vonicog alfa", new ValueWithNote("1718111", "vonicog alfa") },
//             { "Vonicog alfa", new ValueWithNote("1718111", "vonicog alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Fusidic acid", new ValueWithNote("19112521", "fusidic acid") },
//             { "Fusidic acid", new ValueWithNote("19112521", "fusidic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sodium thiosulfate", new ValueWithNote("940004", "sodium thiosulfate") },
//             { "sodium thiosulfate", new ValueWithNote("940004", "sodium thiosulfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sotrovimab", new ValueWithNote("1536976", "sotrovimab") },
//             { "sotrovimab", new ValueWithNote("1536976", "sotrovimab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zopiclone", new ValueWithNote("19044883", "zopiclone") },
//             { "zopiclone", new ValueWithNote("19044883", "zopiclone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tacalcitol", new ValueWithNote("19008361", "tacalcitol") },
//             { "tacalcitol", new ValueWithNote("19008361", "tacalcitol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tamsulosin", new ValueWithNote("924566", "tamsulosin") },
//             { "tamsulosin", new ValueWithNote("924566", "tamsulosin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tocilizumab", new ValueWithNote("40171288", "tocilizumab") },
//             { "tocilizumab", new ValueWithNote("40171288", "tocilizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "TOFACitinib", new ValueWithNote("42904205", "tofacitinib") },
//             { "TOFACitinib", new ValueWithNote("42904205", "tofacitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "temazepam", new ValueWithNote("836715", "temazepam") },
//             { "temazepam", new ValueWithNote("836715", "temazepam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tenecteplase", new ValueWithNote("19098548", "tenecteplase") },
//             { "tenecteplase", new ValueWithNote("19098548", "tenecteplase") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "traMADol", new ValueWithNote("1103314", "tramadol") },
//             { "traMADol", new ValueWithNote("1103314", "tramadol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "traZODone", new ValueWithNote("703547", "trazodone") },
//             { "traZODone", new ValueWithNote("703547", "trazodone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sucralfate", new ValueWithNote("1036228", "sucralfate") },
//             { "sucralfate", new ValueWithNote("1036228", "sucralfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sucroferric oxyhydroxide", new ValueWithNote("44785066", "sucroferric oxyhydroxide") },
//             { "sucroferric oxyhydroxide", new ValueWithNote("44785066", "sucroferric oxyhydroxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tetracaine", new ValueWithNote("1036884", "tetracaine") },
//             { "tetracaine", new ValueWithNote("1036884", "tetracaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "thiamine", new ValueWithNote("19137312", "thiamine") },
//             { "thiamine", new ValueWithNote("19137312", "thiamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "trihexyphenidyl", new ValueWithNote("705178", "trihexyphenidyl") },
//             { "trihexyphenidyl", new ValueWithNote("705178", "trihexyphenidyl") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tuberculin purified protein derivative", new ValueWithNote("19058274", "purified protein derivative of tuberculin") },
//             { "tuberculin purified protein derivative", new ValueWithNote("19058274", "purified protein derivative of tuberculin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Sucrose", new ValueWithNote("19136247", "sucrose") },
//             { "Sucrose", new ValueWithNote("19136247", "sucrose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "SUNitinib", new ValueWithNote("1336539", "sunitinib") },
//             { "SUNitinib", new ValueWithNote("1336539", "sunitinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tiaGABine", new ValueWithNote("715458", "tiagabine") },
//             { "tiaGABine", new ValueWithNote("715458", "tiagabine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tiaprofenic acid", new ValueWithNote("19100755", "tiaprofenic acid") },
//             { "tiaprofenic acid", new ValueWithNote("19100755", "tiaprofenic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Pirfenidone", new ValueWithNote("45775206", "pirfenidone") },
//             { "Pirfenidone", new ValueWithNote("45775206", "pirfenidone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ticagrelor", new ValueWithNote("40241186", "ticagrelor") },
//             { "ticagrelor", new ValueWithNote("40241186", "ticagrelor") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zinc oxide", new ValueWithNote("911064", "zinc oxide") },
//             { "zinc oxide", new ValueWithNote("911064", "zinc oxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ustekinumab", new ValueWithNote("40161532", "ustekinumab") },
//             { "ustekinumab", new ValueWithNote("40161532", "ustekinumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "verapamil", new ValueWithNote("1307863", "verapamil") },
//             { "verapamil", new ValueWithNote("1307863", "verapamil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sulfADIAZINE silver", new ValueWithNote("966956", "silver sulfadiazine") },
//             { "sulfADIAZINE silver", new ValueWithNote("966956", "silver sulfadiazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Triamcinolone hexacetonide", new ValueWithNote("19101172", "triamcinolone hexacetonide") },
//             { "Triamcinolone hexacetonide", new ValueWithNote("19101172", "triamcinolone hexacetonide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Tinidazole", new ValueWithNote("1702559", "tinidazole") },
//             { "Tinidazole", new ValueWithNote("1702559", "tinidazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tiZANidine", new ValueWithNote("778474", "tizanidine") },
//             { "tiZANidine", new ValueWithNote("778474", "tizanidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Calcium gluconate", new ValueWithNote("19037038", "calcium gluconate") },
//             { "Calcium gluconate", new ValueWithNote("19037038", "calcium gluconate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tolcapone", new ValueWithNote("715727", "tolcapone") },
//             { "tolcapone", new ValueWithNote("715727", "tolcapone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "triptorelin", new ValueWithNote("1343039", "triptorelin") },
//             { "triptorelin", new ValueWithNote("1343039", "triptorelin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Valproic acid", new ValueWithNote("19010963", "valproic acid") },
//             { "Valproic acid", new ValueWithNote("19010963", "valproic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "trospium", new ValueWithNote("991825", "trospium") },
//             { "trospium", new ValueWithNote("991825", "trospium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "valproic acid", new ValueWithNote("19010963", "valproic acid") },
//             { "valproic acid", new ValueWithNote("19010963", "valproic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tranexamic acid", new ValueWithNote("1303425", "tranexamic acid") },
//             { "tranexamic acid", new ValueWithNote("1303425", "tranexamic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "triamcinolone", new ValueWithNote("903963", "triamcinolone") },
//             { "triamcinolone", new ValueWithNote("903963", "triamcinolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vedolizumab", new ValueWithNote("45774639", "vedolizumab") },
//             { "vedolizumab", new ValueWithNote("45774639", "vedolizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vigabatrin", new ValueWithNote("19020002", "vigabatrin") },
//             { "vigabatrin", new ValueWithNote("19020002", "vigabatrin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Clotrimazole", new ValueWithNote("1000632", "clotrimazole") },
//             { "Clotrimazole", new ValueWithNote("1000632", "clotrimazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Erythromycin", new ValueWithNote("1746940", "erythromycin") },
//             { "Erythromycin", new ValueWithNote("1746940", "erythromycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Allantoin", new ValueWithNote("966376", "allantoin") },
//             { "Allantoin", new ValueWithNote("966376", "allantoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Interferon alfa-2a", new ValueWithNote("1379969", "interferon alfa-2a") },
//             { "Interferon alfa-2a", new ValueWithNote("1379969", "interferon alfa-2a") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Liquid paraffin", new ValueWithNote("908523", "mineral oil") },
//             { "Liquid paraffin", new ValueWithNote("908523", "mineral oil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Cetylpyridinium", new ValueWithNote("989301", "cetylpyridinium") },
//             { "Cetylpyridinium", new ValueWithNote("989301", "cetylpyridinium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ulipristal", new ValueWithNote("40225722", "ulipristal") },
//             { "ulipristal", new ValueWithNote("40225722", "ulipristal") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "umeclidinium", new ValueWithNote("44785907", "umeclidinium") },
//             { "umeclidinium", new ValueWithNote("44785907", "umeclidinium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Varenicline", new ValueWithNote("780442", "varenicline") },
//             { "Varenicline", new ValueWithNote("780442", "varenicline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "warfarin", new ValueWithNote("1310149", "warfarin") },
//             { "warfarin", new ValueWithNote("1310149", "warfarin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Lithium citrate", new ValueWithNote("767410", "lithium citrate") },
//             { "Lithium citrate", new ValueWithNote("767410", "lithium citrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zinc acetate", new ValueWithNote("979096", "zinc acetate") },
//             { "zinc acetate", new ValueWithNote("979096", "zinc acetate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "methylPREDNISolone sodium succinate", new ValueWithNote("19026798", "methylprednisolone sodium succinate") },
//             { "methylPREDNISolone sodium succinate", new ValueWithNote("19026798", "methylprednisolone sodium succinate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Carbomer 980", new ValueWithNote("42898572", "carbomer homopolymer type c") },
//             { "Carbomer 980", new ValueWithNote("42898572", "carbomer homopolymer type c") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Glucosamine", new ValueWithNote("1360332", "glucosamine") },
//             { "Glucosamine", new ValueWithNote("1360332", "glucosamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Nonacog alfa", new ValueWithNote("46274289", "nonacog alfa") },
//             { "Nonacog alfa", new ValueWithNote("46274289", "nonacog alfa") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Polyvinyl alcohol", new ValueWithNote("948856", "polyvinyl alcohol") },
//             { "Polyvinyl alcohol", new ValueWithNote("948856", "polyvinyl alcohol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Urea", new ValueWithNote("906914", "urea") },
//             { "Urea", new ValueWithNote("906914", "urea") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Sirolimus", new ValueWithNote("19034726", "sirolimus") },
//             { "Sirolimus", new ValueWithNote("19034726", "sirolimus") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "OLANZapine embonate", new ValueWithNote("46274261", "olanzapine pamoate") },
//             { "OLANZapine embonate", new ValueWithNote("46274261", "olanzapine pamoate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "acetylcysteine", new ValueWithNote("1139042", "acetylcysteine") },
//             { "acetylcysteine", new ValueWithNote("1139042", "acetylcysteine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "aclidinium", new ValueWithNote("42873639", "aclidinium") },
//             { "aclidinium", new ValueWithNote("42873639", "aclidinium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "adalimumab", new ValueWithNote("1119119", "adalimumab") },
//             { "adalimumab", new ValueWithNote("1119119", "adalimumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Hydrocortisone butyrate", new ValueWithNote("19002396", "hydrocortisone butyrate") },
//             { "Hydrocortisone butyrate", new ValueWithNote("19002396", "hydrocortisone butyrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Testosterone propionate", new ValueWithNote("19002851", "testosterone propionate") },
//             { "Testosterone propionate", new ValueWithNote("19002851", "testosterone propionate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alemtuzumab", new ValueWithNote("1312706", "alemtuzumab") },
//             { "alemtuzumab", new ValueWithNote("1312706", "alemtuzumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alfacalcidol", new ValueWithNote("19014202", "alfacalcidol") },
//             { "alfacalcidol", new ValueWithNote("19014202", "alfacalcidol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alteplase", new ValueWithNote("1347450", "alteplase") },
//             { "alteplase", new ValueWithNote("1347450", "alteplase") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "alum", new ValueWithNote("19115033", "aluminum potassium sulfate") },
//             { "alum", new ValueWithNote("19115033", "aluminum potassium sulfate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ambrisentan", new ValueWithNote("1337068", "ambrisentan") },
//             { "ambrisentan", new ValueWithNote("1337068", "ambrisentan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "amLODIPine", new ValueWithNote("1332418", "amlodipine") },
//             { "amLODIPine", new ValueWithNote("1332418", "amlodipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "atracurium", new ValueWithNote("19014341", "atracurium") },
//             { "atracurium", new ValueWithNote("19014341", "atracurium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Phenytoin", new ValueWithNote("740910", "phenytoin") },
//             { "Phenytoin", new ValueWithNote("740910", "phenytoin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "azelaic acid", new ValueWithNote("19018514", "azelaic acid") },
//             { "azelaic acid", new ValueWithNote("19018514", "azelaic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "belatacept", new ValueWithNote("40239665", "belatacept") },
//             { "belatacept", new ValueWithNote("40239665", "belatacept") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "benzocaine", new ValueWithNote("917006", "benzocaine") },
//             { "benzocaine", new ValueWithNote("917006", "benzocaine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bexarotene", new ValueWithNote("1389888", "bexarotene") },
//             { "bexarotene", new ValueWithNote("1389888", "bexarotene") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bivalirudin", new ValueWithNote("19084670", "bivalirudin") },
//             { "bivalirudin", new ValueWithNote("19084670", "bivalirudin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "bosentan", new ValueWithNote("1321636", "bosentan") },
//             { "bosentan", new ValueWithNote("1321636", "bosentan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Botulinum B toxin", new ValueWithNote("729959", "botulinum toxin type B") },
//             { "Botulinum B toxin", new ValueWithNote("729959", "botulinum toxin type B") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "candesartan", new ValueWithNote("1351557", "candesartan") },
//             { "candesartan", new ValueWithNote("1351557", "candesartan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "carboprost", new ValueWithNote("19049150", "carboprost") },
//             { "carboprost", new ValueWithNote("19049150", "carboprost") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefRADINE", new ValueWithNote("1786842", "cephradine") },
//             { "cefRADINE", new ValueWithNote("1786842", "cephradine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cefTAROLine fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") },
//             { "cefTAROLine fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cetirizine", new ValueWithNote("1149196", "cetirizine") },
//             { "cetirizine", new ValueWithNote("1149196", "cetirizine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chloramPHENICOL", new ValueWithNote("990069", "chloramphenicol") },
//             { "chloramPHENICOL", new ValueWithNote("990069", "chloramphenicol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "chlorhexidine", new ValueWithNote("1790812", "chlorhexidine") },
//             { "chlorhexidine", new ValueWithNote("1790812", "chlorhexidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cinacalcet", new ValueWithNote("1548111", "cinacalcet") },
//             { "cinacalcet", new ValueWithNote("1548111", "cinacalcet") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "codeine", new ValueWithNote("1201620", "codeine") },
//             { "codeine", new ValueWithNote("1201620", "codeine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "cyclophosphamide", new ValueWithNote("1310317", "cyclophosphamide") },
//             { "cyclophosphamide", new ValueWithNote("1310317", "cyclophosphamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "danazol", new ValueWithNote("1511449", "danazol") },
//             { "danazol", new ValueWithNote("1511449", "danazol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "DASatinib", new ValueWithNote("1358436", "dasatinib") },
//             { "DASatinib", new ValueWithNote("1358436", "dasatinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dexpanthenol", new ValueWithNote("988294", "dexpanthenol") },
//             { "dexpanthenol", new ValueWithNote("988294", "dexpanthenol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "diclofenac", new ValueWithNote("1124300", "diclofenac") },
//             { "diclofenac", new ValueWithNote("1124300", "diclofenac") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "digoxin", new ValueWithNote("1326303", "digoxin") },
//             { "digoxin", new ValueWithNote("1326303", "digoxin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dihydrocodeine", new ValueWithNote("1189596", "dihydrocodeine") },
//             { "dihydrocodeine", new ValueWithNote("1189596", "dihydrocodeine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "domperidone", new ValueWithNote("19037833", "domperidone") },
//             { "domperidone", new ValueWithNote("19037833", "domperidone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "DULoxetine", new ValueWithNote("715259", "duloxetine") },
//             { "DULoxetine", new ValueWithNote("715259", "duloxetine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "dupilumab", new ValueWithNote("1593467", "dupilumab") },
//             { "dupilumab", new ValueWithNote("1593467", "dupilumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "emtricitabine", new ValueWithNote("1703069", "emtricitabine") },
//             { "emtricitabine", new ValueWithNote("1703069", "emtricitabine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "enzalutamide", new ValueWithNote("42900250", "enzalutamide") },
//             { "enzalutamide", new ValueWithNote("42900250", "enzalutamide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ERLotinib", new ValueWithNote("1325363", "erlotinib") },
//             { "ERLotinib", new ValueWithNote("1325363", "erlotinib") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ethambutol", new ValueWithNote("1749301", "ethambutol") },
//             { "ethambutol", new ValueWithNote("1749301", "ethambutol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ethyl chloride", new ValueWithNote("950316", "ethyl chloride") },
//             { "ethyl chloride", new ValueWithNote("950316", "ethyl chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "etravirine", new ValueWithNote("1758536", "etravirine") },
//             { "etravirine", new ValueWithNote("1758536", "etravirine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "everolimus", new ValueWithNote("19011440", "everolimus") },
//             { "everolimus", new ValueWithNote("19011440", "everolimus") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "exemestane", new ValueWithNote("1398399", "exemestane") },
//             { "exemestane", new ValueWithNote("1398399", "exemestane") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "febuxostat", new ValueWithNote("19017742", "febuxostat") },
//             { "febuxostat", new ValueWithNote("19017742", "febuxostat") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fesoterodine", new ValueWithNote("19027958", "fesoterodine") },
//             { "fesoterodine", new ValueWithNote("19027958", "fesoterodine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "filgrastim", new ValueWithNote("1304850", "filgrastim") },
//             { "filgrastim", new ValueWithNote("1304850", "filgrastim") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "fluPHENAZine", new ValueWithNote("756018", "fluphenazine") },
//             { "fluPHENAZine", new ValueWithNote("756018", "fluphenazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glucagon", new ValueWithNote("1560278", "glucagon") },
//             { "glucagon", new ValueWithNote("1560278", "glucagon") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "glucosamine", new ValueWithNote("1360332", "glucosamine") },
//             { "glucosamine", new ValueWithNote("1360332", "glucosamine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hyaluronidase", new ValueWithNote("19073699", "hyaluronidase") },
//             { "hyaluronidase", new ValueWithNote("19073699", "hyaluronidase") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "hydroxycarbamide", new ValueWithNote("1377141", "hydroxyurea") },
//             { "hydroxycarbamide", new ValueWithNote("1377141", "hydroxyurea") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "indacaterol", new ValueWithNote("40240664", "indacaterol") },
//             { "indacaterol", new ValueWithNote("40240664", "indacaterol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "inFLIXimab", new ValueWithNote("937368", "infliximab") },
//             { "inFLIXimab", new ValueWithNote("937368", "infliximab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ipratropium", new ValueWithNote("1112921", "ipratropium") },
//             { "ipratropium", new ValueWithNote("1112921", "ipratropium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "iron sucrose", new ValueWithNote("1395773", "iron sucrose") },
//             { "iron sucrose", new ValueWithNote("1395773", "iron sucrose") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "itraconazole", new ValueWithNote("1703653", "itraconazole") },
//             { "itraconazole", new ValueWithNote("1703653", "itraconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "lamiVUDine", new ValueWithNote("1704183", "lamivudine") },
//             { "lamiVUDine", new ValueWithNote("1704183", "lamivudine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "levETIRAcetam", new ValueWithNote("711584", "levetiracetam") },
//             { "levETIRAcetam", new ValueWithNote("711584", "levetiracetam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "levocetirizine", new ValueWithNote("1136422", "levocetirizine") },
//             { "levocetirizine", new ValueWithNote("1136422", "levocetirizine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "magnesium chloride", new ValueWithNote("19092849", "magnesium chloride") },
//             { "magnesium chloride", new ValueWithNote("19092849", "magnesium chloride") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "magnesium hydroxide", new ValueWithNote("992956", "magnesium hydroxide") },
//             { "magnesium hydroxide", new ValueWithNote("992956", "magnesium hydroxide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "memantine", new ValueWithNote("701322", "memantine") },
//             { "memantine", new ValueWithNote("701322", "memantine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "meptazinol", new ValueWithNote("19003010", "meptazinol") },
//             { "meptazinol", new ValueWithNote("19003010", "meptazinol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "meropenem", new ValueWithNote("1709170", "meropenem") },
//             { "meropenem", new ValueWithNote("1709170", "meropenem") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "minoxidil", new ValueWithNote("1309068", "minoxidil") },
//             { "minoxidil", new ValueWithNote("1309068", "minoxidil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "modafinil", new ValueWithNote("710650", "modafinil") },
//             { "modafinil", new ValueWithNote("710650", "modafinil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "montelukast", new ValueWithNote("1154161", "montelukast") },
//             { "montelukast", new ValueWithNote("1154161", "montelukast") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "mycophenolic acid", new ValueWithNote("19012565", "mycophenolic acid") },
//             { "mycophenolic acid", new ValueWithNote("19012565", "mycophenolic acid") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nabumetone", new ValueWithNote("1113648", "nabumetone") },
//             { "nabumetone", new ValueWithNote("1113648", "nabumetone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "natalizumab", new ValueWithNote("735843", "natalizumab") },
//             { "natalizumab", new ValueWithNote("735843", "natalizumab") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nebivolol", new ValueWithNote("1314577", "nebivolol") },
//             { "nebivolol", new ValueWithNote("1314577", "nebivolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nefopam", new ValueWithNote("19015602", "nefopam") },
//             { "nefopam", new ValueWithNote("19015602", "nefopam") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nevirapine", new ValueWithNote("1769389", "nevirapine") },
//             { "nevirapine", new ValueWithNote("1769389", "nevirapine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "niFEDipine", new ValueWithNote("1318853", "nifedipine") },
//             { "niFEDipine", new ValueWithNote("1318853", "nifedipine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "nitazoxanide", new ValueWithNote("1715315", "nitazoxanide") },
//             { "nitazoxanide", new ValueWithNote("1715315", "nitazoxanide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "octenidine", new ValueWithNote("1366603", "octenidine") },
//             { "octenidine", new ValueWithNote("1366603", "octenidine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oseltamivir", new ValueWithNote("1799139", "oseltamivir") },
//             { "oseltamivir", new ValueWithNote("1799139", "oseltamivir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "oxytetracycline", new ValueWithNote("925952", "oxytetracycline") },
//             { "oxytetracycline", new ValueWithNote("925952", "oxytetracycline") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "pamidronate disodium", new ValueWithNote("19007069", "pamidronate disodium") },
//             { "pamidronate disodium", new ValueWithNote("19007069", "pamidronate disodium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "potassium permanganate", new ValueWithNote("19135788", "potassium permanganate") },
//             { "potassium permanganate", new ValueWithNote("19135788", "potassium permanganate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "prasugrel", new ValueWithNote("40163718", "prasugrel") },
//             { "prasugrel", new ValueWithNote("40163718", "prasugrel") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "prednisoLONE", new ValueWithNote("1550557", "prednisolone") },
//             { "prednisoLONE", new ValueWithNote("1550557", "prednisolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "primidone", new ValueWithNote("751347", "primidone") },
//             { "primidone", new ValueWithNote("751347", "primidone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "progesterone", new ValueWithNote("1552310", "progesterone") },
//             { "progesterone", new ValueWithNote("1552310", "progesterone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "QUEtiapine", new ValueWithNote("766814", "quetiapine") },
//             { "QUEtiapine", new ValueWithNote("766814", "quetiapine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ranolazine", new ValueWithNote("1337107", "ranolazine") },
//             { "ranolazine", new ValueWithNote("1337107", "ranolazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "repaglinide", new ValueWithNote("1516766", "repaglinide") },
//             { "repaglinide", new ValueWithNote("1516766", "repaglinide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rFVIIa", new ValueWithNote("19065771", "eptacog alfa activated") },
//             { "rFVIIa", new ValueWithNote("19065771", "eptacog alfa activated") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "rimegepant", new ValueWithNote("37498993", "rimegepant") },
//             { "rimegepant", new ValueWithNote("37498993", "rimegepant") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "risperiDONE", new ValueWithNote("735979", "risperidone") },
//             { "risperiDONE", new ValueWithNote("735979", "risperidone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "roxadustat", new ValueWithNote("35834902", "roxadustat") },
//             { "roxadustat", new ValueWithNote("35834902", "roxadustat") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "selenium", new ValueWithNote("966282", "selenium") },
//             { "selenium", new ValueWithNote("966282", "selenium") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "senna", new ValueWithNote("938268", "sennosides, USP") },
//             { "senna", new ValueWithNote("938268", "sennosides, USP") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "silver nitrate", new ValueWithNote("966913", "silver nitrate") },
//             { "silver nitrate", new ValueWithNote("966913", "silver nitrate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sitaGLIPtin", new ValueWithNote("1580747", "sitagliptin") },
//             { "sitaGLIPtin", new ValueWithNote("1580747", "sitagliptin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "sultiame", new ValueWithNote("19000921", "sulthiame") },
//             { "sultiame", new ValueWithNote("19000921", "sulthiame") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Talc", new ValueWithNote("1036667", "talc") },
//             { "Talc", new ValueWithNote("1036667", "talc") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tenofovir", new ValueWithNote("19011093", "tenofovir") },
//             { "tenofovir", new ValueWithNote("19011093", "tenofovir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "testosterone", new ValueWithNote("1636780", "testosterone") },
//             { "testosterone", new ValueWithNote("1636780", "testosterone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tetrabenazine", new ValueWithNote("836877", "tetrabenazine") },
//             { "tetrabenazine", new ValueWithNote("836877", "tetrabenazine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tibolone", new ValueWithNote("19041933", "tibolone") },
//             { "tibolone", new ValueWithNote("19041933", "tibolone") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "timolol", new ValueWithNote("902427", "timolol") },
//             { "timolol", new ValueWithNote("902427", "timolol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tirzepatide", new ValueWithNote("779705", "tirzepatide") },
//             { "tirzepatide", new ValueWithNote("779705", "tirzepatide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tolterodine", new ValueWithNote("913782", "tolterodine") },
//             { "tolterodine", new ValueWithNote("913782", "tolterodine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "topiramate", new ValueWithNote("742267", "topiramate") },
//             { "topiramate", new ValueWithNote("742267", "topiramate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "tozorakimab", new ValueWithNote("36860143", "TOZORAKIMAB") },
//             { "tozorakimab", new ValueWithNote("36860143", "TOZORAKIMAB") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "trimethoprim", new ValueWithNote("1705674", "trimethoprim") },
//             { "trimethoprim", new ValueWithNote("1705674", "trimethoprim") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "valGANciclovir", new ValueWithNote("1703063", "valganciclovir") },
//             { "valGANciclovir", new ValueWithNote("1703063", "valganciclovir") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "vancomycin", new ValueWithNote("1707687", "vancomycin") },
//             { "vancomycin", new ValueWithNote("1707687", "vancomycin") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "venlafaxine", new ValueWithNote("743670", "venlafaxine") },
//             { "venlafaxine", new ValueWithNote("743670", "venlafaxine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "voriconazole", new ValueWithNote("1714277", "voriconazole") },
//             { "voriconazole", new ValueWithNote("1714277", "voriconazole") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zidovudine", new ValueWithNote("1710612", "zidovudine") },
//             { "zidovudine", new ValueWithNote("1710612", "zidovudine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "ZOLMitriptan", new ValueWithNote("1116031", "zolmitriptan") },
//             { "ZOLMitriptan", new ValueWithNote("1116031", "zolmitriptan") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "zuclopenthixol", new ValueWithNote("19010886", "zuclopenthixol") },
//             { "zuclopenthixol", new ValueWithNote("19010886", "zuclopenthixol") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Coal tar", new ValueWithNote("1000995", "coal tar") },
//             { "Coal tar", new ValueWithNote("1000995", "coal tar") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Cod liver oil", new ValueWithNote("19101604", "cod liver oil") },
//             { "Cod liver oil", new ValueWithNote("19101604", "cod liver oil") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Moroctocog alfa", new ValueWithNote("46274287", "antihemophilic factor, human recombinant residues 743-1636 deleted") },
//             { "Moroctocog alfa", new ValueWithNote("46274287", "antihemophilic factor, human recombinant residues 743-1636 deleted") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Nateglinide", new ValueWithNote("1502826", "nateglinide") },
//             { "Nateglinide", new ValueWithNote("1502826", "nateglinide") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Phenelzine", new ValueWithNote("733896", "phenelzine") },
//             { "Phenelzine", new ValueWithNote("733896", "phenelzine") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "Testosterone undecanoate", new ValueWithNote("19100455", "testosterone undecanoate") },
//             { "Testosterone undecanoate", new ValueWithNote("19100455", "testosterone undecanoate") }, // Confidence: 100.0%, OMOP Match: 100.0%
            { "anti-D (RHO) immunoglobulin", new ValueWithNote("535714", "Rho(D) immune globulin") },
//             { "anti-D (RHO) immunoglobulin", new ValueWithNote("535714", "Rho(D) immune globulin") }, // Confidence: 98.1%, OMOP Match: 100.0%
            { "conjugated oestrogens", new ValueWithNote("1549080", "estrogens, conjugated (USP)") },
//             { "conjugated oestrogens", new ValueWithNote("1549080", "estrogens, conjugated (USP)") }, // Confidence: 97.6%, OMOP Match: 100.0%
            { "White soft paraffin", new ValueWithNote("19033354", "petrolatum") },
//             { "White soft paraffin", new ValueWithNote("19033354", "petrolatum") }, // Confidence: 97.4%, OMOP Match: 100.0%
            { "charcoal, activated", new ValueWithNote("1701928", "activated charcoal") },
//             { "charcoal, activated", new ValueWithNote("1701928", "activated charcoal") }, // Confidence: 97.3%, OMOP Match: 100.0%
            { "Tenofovir alafenamide + Emtricitabine", new ValueWithNote("778947", "emtricitabine / tenofovir alafenamide") },
//             { "Tenofovir alafenamide + Emtricitabine", new ValueWithNote("778947", "emtricitabine / tenofovir alafenamide") }, // Confidence: 97.3%, OMOP Match: 100.0%
            { "sodium biphosphate-sodium phosphate", new ValueWithNote("36028653", "sodium phosphate / sodium phosphate, monobasic") },
//             { "sodium biphosphate-sodium phosphate", new ValueWithNote("36028653", "sodium phosphate / sodium phosphate, monobasic") }, // Confidence: 97.1%, OMOP Match: 100.0%
            { "Factor VIII + von Willebrand factor", new ValueWithNote("36030083", "factor VIII / von Willebrand factor") },
//             { "Factor VIII + von Willebrand factor", new ValueWithNote("36030083", "factor VIII / von Willebrand factor") }, // Confidence: 97.1%, OMOP Match: 100.0%
            { "Calcium carbonate + Ergocalciferol", new ValueWithNote("36028357", "calcium carbonate / ergocalciferol") },
//             { "Calcium carbonate + Ergocalciferol", new ValueWithNote("36028357", "calcium carbonate / ergocalciferol") }, // Confidence: 97.1%, OMOP Match: 100.0%
            { "isoniazid/pyrazinamide/rifaMPICIN", new ValueWithNote("36030016", "isoniazid / pyrazinamide / rifampin") },
//             { "isoniazid/pyrazinamide/rifaMPICIN", new ValueWithNote("36030016", "isoniazid / pyrazinamide / rifampin") }, // Confidence: 96.9%, OMOP Match: 100.0%
            { "hydrochlorothiazide-telmisartan", new ValueWithNote("36030113", "hydrochlorothiazide / telmisartan") },
//             { "hydrochlorothiazide-telmisartan", new ValueWithNote("36030113", "hydrochlorothiazide / telmisartan") }, // Confidence: 96.8%, OMOP Match: 100.0%
            { "hydrochlorothiazide-olmesartan", new ValueWithNote("36030964", "hydrochlorothiazide / olmesartan") },
//             { "hydrochlorothiazide-olmesartan", new ValueWithNote("36030964", "hydrochlorothiazide / olmesartan") }, // Confidence: 96.7%, OMOP Match: 100.0%
            { "hydrochlorothiazide-lisinopril", new ValueWithNote("36030000", "hydrochlorothiazide / lisinopril") },
//             { "hydrochlorothiazide-lisinopril", new ValueWithNote("36030000", "hydrochlorothiazide / lisinopril") }, // Confidence: 96.7%, OMOP Match: 100.0%
            { "hydrochlorothiazide-irbesartan", new ValueWithNote("36029999", "hydrochlorothiazide / irbesartan") },
//             { "hydrochlorothiazide-irbesartan", new ValueWithNote("36029999", "hydrochlorothiazide / irbesartan") }, // Confidence: 96.7%, OMOP Match: 100.0%
            { "hydrocortisone-oxytetracycline", new ValueWithNote("36029281", "hydrocortisone / oxytetracycline") },
//             { "hydrocortisone-oxytetracycline", new ValueWithNote("36029281", "hydrocortisone / oxytetracycline") }, // Confidence: 96.7%, OMOP Match: 100.0%
            { "ascorbic acid-ferrous sulfate", new ValueWithNote("36029893", "ascorbic acid / ferrous sulfate") },
//             { "ascorbic acid-ferrous sulfate", new ValueWithNote("36029893", "ascorbic acid / ferrous sulfate") }, // Confidence: 96.6%, OMOP Match: 100.0%
            { "citric acid-potassium citrate", new ValueWithNote("36029947", "citric acid / potassium citrate") },
//             { "citric acid-potassium citrate", new ValueWithNote("36029947", "citric acid / potassium citrate") }, // Confidence: 96.6%, OMOP Match: 100.0%
            { "colecalciferol", new ValueWithNote("19095164", "cholecalciferol") },
//             { "colecalciferol", new ValueWithNote("19095164", "cholecalciferol") }, // Confidence: 96.6%, OMOP Match: 100.0%
            { "hydrochlorothiazide-quinapril", new ValueWithNote("36030100", "hydrochlorothiazide / quinapril") },
//             { "hydrochlorothiazide-quinapril", new ValueWithNote("36030100", "hydrochlorothiazide / quinapril") }, // Confidence: 96.6%, OMOP Match: 100.0%
            { "hydrochlorothiazide-valsartan", new ValueWithNote("36030008", "hydrochlorothiazide / valsartan") },
//             { "hydrochlorothiazide-valsartan", new ValueWithNote("36030008", "hydrochlorothiazide / valsartan") }, // Confidence: 96.6%, OMOP Match: 100.0%
            { "Chlorhexidine + Chlorobutanol", new ValueWithNote("36030287", "chlorhexidine / chlorobutanol") },
//             { "Chlorhexidine + Chlorobutanol", new ValueWithNote("36030287", "chlorhexidine / chlorobutanol") }, // Confidence: 96.6%, OMOP Match: 100.0%
            { "benzoyl peroxide-clindamycin", new ValueWithNote("36030343", "benzoyl peroxide / clindamycin") },
//             { "benzoyl peroxide-clindamycin", new ValueWithNote("36030343", "benzoyl peroxide / clindamycin") }, // Confidence: 96.4%, OMOP Match: 100.0%
            { "hydrochlorothiazide-losartan", new ValueWithNote("36030001", "hydrochlorothiazide / losartan") },
//             { "hydrochlorothiazide-losartan", new ValueWithNote("36030001", "hydrochlorothiazide / losartan") }, // Confidence: 96.4%, OMOP Match: 100.0%
            { "aMILoride + Cyclopenthiazide", new ValueWithNote("36030291", "amiloride / cyclopenthiazide") },
//             { "aMILoride + Cyclopenthiazide", new ValueWithNote("36030291", "amiloride / cyclopenthiazide") }, // Confidence: 96.4%, OMOP Match: 100.0%
            { "beclometasone", new ValueWithNote("1115572", "beclomethasone") },
//             { "beclometasone", new ValueWithNote("1115572", "beclomethasone") }, // Confidence: 96.3%, OMOP Match: 100.0%
            { "ferrous fumarate-folic acid", new ValueWithNote("36028638", "ferrous fumarate / folic acid") },
//             { "ferrous fumarate-folic acid", new ValueWithNote("36028638", "ferrous fumarate / folic acid") }, // Confidence: 96.3%, OMOP Match: 100.0%
            { "immunoglobulin intravenous", new ValueWithNote("551749", "immunoglobulins, intravenous") },
//             { "immunoglobulin intravenous", new ValueWithNote("551749", "immunoglobulins, intravenous") }, // Confidence: 96.3%, OMOP Match: 100.0%
            { ".TERIFlunomide", new ValueWithNote("42900584", "teriflunomide") },
//             { ".TERIFlunomide", new ValueWithNote("42900584", "teriflunomide") }, // Confidence: 96.3%, OMOP Match: 100.0%
            { "Chlorhexidine + Tetracaine", new ValueWithNote("36030325", "chlorhexidine / tetracaine") },
//             { "Chlorhexidine + Tetracaine", new ValueWithNote("36030325", "chlorhexidine / tetracaine") }, // Confidence: 96.2%, OMOP Match: 100.0%
            { "betamethasone-clotrimazole", new ValueWithNote("36029270", "betamethasone / clotrimazole") },
//             { "betamethasone-clotrimazole", new ValueWithNote("36029270", "betamethasone / clotrimazole") }, // Confidence: 96.2%, OMOP Match: 100.0%
            { "ferrous sulfate-folic acid", new ValueWithNote("36028169", "ferrous sulfate / folic acid") },
//             { "ferrous sulfate-folic acid", new ValueWithNote("36028169", "ferrous sulfate / folic acid") }, // Confidence: 96.2%, OMOP Match: 100.0%
            { "adapalene-benzoyl peroxide", new ValueWithNote("36031106", "adapalene / benzoyl peroxide") },
//             { "adapalene-benzoyl peroxide", new ValueWithNote("36031106", "adapalene / benzoyl peroxide") }, // Confidence: 96.2%, OMOP Match: 100.0%
            { "Iodine + Potassium iodide", new ValueWithNote("36030121", "iodine / potassium iodide") },
//             { "Iodine + Potassium iodide", new ValueWithNote("36030121", "iodine / potassium iodide") }, // Confidence: 96.0%, OMOP Match: 100.0%
            { "Hypromellose + Dextran 70", new ValueWithNote("36030364", "dextran 70 / hypromellose") },
//             { "Hypromellose + Dextran 70", new ValueWithNote("36030364", "dextran 70 / hypromellose") }, // Confidence: 96.0%, OMOP Match: 100.0%
            { "dolutegravir-rilpivirine", new ValueWithNote("36029814", "dolutegravir / rilpivirine") },
//             { "dolutegravir-rilpivirine", new ValueWithNote("36029814", "dolutegravir / rilpivirine") }, // Confidence: 95.8%, OMOP Match: 100.0%
            { "estradiol-levonorgestrel", new ValueWithNote("36030367", "estradiol / levonorgestrel") },
//             { "estradiol-levonorgestrel", new ValueWithNote("36030367", "estradiol / levonorgestrel") }, // Confidence: 95.8%, OMOP Match: 100.0%
            { "hydrocortisone-lidocaine", new ValueWithNote("36029276", "hydrocortisone / lidocaine") },
//             { "hydrocortisone-lidocaine", new ValueWithNote("36029276", "hydrocortisone / lidocaine") }, // Confidence: 95.8%, OMOP Match: 100.0%
            { "glecaprevir-pibrentasvir", new ValueWithNote("778969", "glecaprevir / pibrentasvir") },
//             { "glecaprevir-pibrentasvir", new ValueWithNote("778969", "glecaprevir / pibrentasvir") }, // Confidence: 95.8%, OMOP Match: 100.0%
            { "Benzocaine + Tyrothricin", new ValueWithNote("36030792", "benzocaine / tyrothricin") },
//             { "Benzocaine + Tyrothricin", new ValueWithNote("36030792", "benzocaine / tyrothricin") }, // Confidence: 95.8%, OMOP Match: 100.0%
            { "artemether-lumefantrine", new ValueWithNote("778783", "artemether / lumefantrine") },
//             { "artemether-lumefantrine", new ValueWithNote("778783", "artemether / lumefantrine") }, // Confidence: 95.7%, OMOP Match: 100.0%
            { "coal tar-salicylic acid", new ValueWithNote("36030531", "coal tar / salicylic acid") },
//             { "coal tar-salicylic acid", new ValueWithNote("36030531", "coal tar / salicylic acid") }, // Confidence: 95.7%, OMOP Match: 100.0%
            { "dolutegravir-lamiVUDine", new ValueWithNote("36029861", "dolutegravir / lamivudine") },
//             { "dolutegravir-lamiVUDine", new ValueWithNote("36029861", "dolutegravir / lamivudine") }, // Confidence: 95.7%, OMOP Match: 100.0%
            { "umeclidinium-vilanterol", new ValueWithNote("778926", "umeclidinium / vilanterol") },
//             { "umeclidinium-vilanterol", new ValueWithNote("778926", "umeclidinium / vilanterol") }, // Confidence: 95.7%, OMOP Match: 100.0%
            { "Calcium phosphate + Colecalciferol", new ValueWithNote("36030284", "calcium phosphate / cholecalciferol") },
//             { "Calcium phosphate + Colecalciferol", new ValueWithNote("36030284", "calcium phosphate / cholecalciferol") }, // Confidence: 95.7%, OMOP Match: 100.0%
            { "Coal tar-salicylic acid", new ValueWithNote("36030531", "coal tar / salicylic acid") },
//             { "Coal tar-salicylic acid", new ValueWithNote("36030531", "coal tar / salicylic acid") }, // Confidence: 95.7%, OMOP Match: 100.0%
            { "buprenorphine-naloxone", new ValueWithNote("36030126", "buprenorphine / naloxone") },
//             { "buprenorphine-naloxone", new ValueWithNote("36030126", "buprenorphine / naloxone") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "ceftolozane-tazobactam", new ValueWithNote("778933", "ceftolozane / tazobactam") },
//             { "ceftolozane-tazobactam", new ValueWithNote("778933", "ceftolozane / tazobactam") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "diclofenac-misoprostol", new ValueWithNote("36029967", "diclofenac / misoprostol") },
//             { "diclofenac-misoprostol", new ValueWithNote("36029967", "diclofenac / misoprostol") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "fluticasone-saLMETerol", new ValueWithNote("778784", "fluticasone / salmeterol") },
//             { "fluticasone-saLMETerol", new ValueWithNote("778784", "fluticasone / salmeterol") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "dutasteride-tamsulosin", new ValueWithNote("36027018", "dutasteride / tamsulosin") },
//             { "dutasteride-tamsulosin", new ValueWithNote("36027018", "dutasteride / tamsulosin") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "metFORMIN-pioglitazone", new ValueWithNote("36030280", "metformin / pioglitazone") },
//             { "metFORMIN-pioglitazone", new ValueWithNote("36030280", "metformin / pioglitazone") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "sofosbuvir-velpatasvir", new ValueWithNote("778954", "sofosbuvir / velpatasvir") },
//             { "sofosbuvir-velpatasvir", new ValueWithNote("778954", "sofosbuvir / velpatasvir") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "fluticasone-vilanterol", new ValueWithNote("778919", "fluticasone / vilanterol") },
//             { "fluticasone-vilanterol", new ValueWithNote("778919", "fluticasone / vilanterol") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "tipiracil-trifluridine", new ValueWithNote("36029751", "tipiracil / trifluridine") },
//             { "tipiracil-trifluridine", new ValueWithNote("36029751", "tipiracil / trifluridine") }, // Confidence: 95.5%, OMOP Match: 100.0%
            { "aclidinium-formoterol", new ValueWithNote("779005", "aclidinium / formoterol") },
//             { "aclidinium-formoterol", new ValueWithNote("779005", "aclidinium / formoterol") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "avibactam-cefTAZIDime", new ValueWithNote("36029713", "avibactam / ceftazidime") },
//             { "avibactam-cefTAZIDime", new ValueWithNote("36029713", "avibactam / ceftazidime") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "amLODIPine-olmesartan", new ValueWithNote("36029071", "amlodipine / olmesartan") },
//             { "amLODIPine-olmesartan", new ValueWithNote("36029071", "amlodipine / olmesartan") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "budesonide-formoterol", new ValueWithNote("36030143", "budesonide / formoterol") },
//             { "budesonide-formoterol", new ValueWithNote("36030143", "budesonide / formoterol") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "dimeticone", new ValueWithNote("916662", "dimethicone") },
//             { "dimeticone", new ValueWithNote("916662", "dimethicone") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "esomeprazole-naproxen", new ValueWithNote("36031122", "esomeprazole / naproxen") },
//             { "esomeprazole-naproxen", new ValueWithNote("36031122", "esomeprazole / naproxen") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "ezetimibe-simvastatin", new ValueWithNote("36030246", "ezetimibe / simvastatin") },
//             { "ezetimibe-simvastatin", new ValueWithNote("36030246", "ezetimibe / simvastatin") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "meropenem-vaborbactam", new ValueWithNote("36029808", "meropenem / vaborbactam") },
//             { "meropenem-vaborbactam", new ValueWithNote("36029808", "meropenem / vaborbactam") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "heparinoid", new ValueWithNote("19113045", "heparinoids") },
//             { "heparinoid", new ValueWithNote("19113045", "heparinoids") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "lamiVUDine-zidovudine", new ValueWithNote("36030019", "lamivudine / zidovudine") },
//             { "lamiVUDine-zidovudine", new ValueWithNote("36030019", "lamivudine / zidovudine") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "simeticone", new ValueWithNote("966991", "simethicone") },
//             { "simeticone", new ValueWithNote("966991", "simethicone") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "metFORMIN-sitaGLIPtin", new ValueWithNote("36030770", "metformin / sitagliptin") },
//             { "metFORMIN-sitaGLIPtin", new ValueWithNote("36030770", "metformin / sitagliptin") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "olodaterol-tiotropium", new ValueWithNote("778944", "olodaterol / tiotropium") },
//             { "olodaterol-tiotropium", new ValueWithNote("778944", "olodaterol / tiotropium") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "ledipasvir-sofosbuvir", new ValueWithNote("778931", "ledipasvir / sofosbuvir") },
//             { "ledipasvir-sofosbuvir", new ValueWithNote("778931", "ledipasvir / sofosbuvir") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { ".apreMILast", new ValueWithNote("44816294", "apremilast") },
//             { ".apreMILast", new ValueWithNote("44816294", "apremilast") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "Wasp venom", new ValueWithNote("19011001", "wasp venoms") },
//             { "Wasp venom", new ValueWithNote("19011001", "wasp venoms") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "Urea + Lauromacrogols", new ValueWithNote("36030315", "lauromacrogols / urea") },
//             { "Urea + Lauromacrogols", new ValueWithNote("36030315", "lauromacrogols / urea") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "Atenolol + niFEDipine", new ValueWithNote("36030155", "atenolol / nifedipine") },
//             { "Atenolol + niFEDipine", new ValueWithNote("36030155", "atenolol / nifedipine") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "Caffeine + Ergotamine", new ValueWithNote("36029919", "caffeine / ergotamine") },
//             { "Caffeine + Ergotamine", new ValueWithNote("36029919", "caffeine / ergotamine") }, // Confidence: 95.2%, OMOP Match: 100.0%
            { "atovaquone-proguanil", new ValueWithNote("36030109", "atovaquone / proguanil") },
//             { "atovaquone-proguanil", new ValueWithNote("36030109", "atovaquone / proguanil") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "ivacaftor-lumacaftor", new ValueWithNote("778938", "ivacaftor / lumacaftor") },
//             { "ivacaftor-lumacaftor", new ValueWithNote("778938", "ivacaftor / lumacaftor") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "ivacaftor-tezacaftor", new ValueWithNote("778976", "ivacaftor / tezacaftor") },
//             { "ivacaftor-tezacaftor", new ValueWithNote("778976", "ivacaftor / tezacaftor") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "sacubitril-valsartan", new ValueWithNote("778939", "sacubitril / valsartan") },
//             { "sacubitril-valsartan", new ValueWithNote("778939", "sacubitril / valsartan") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "amLODIPine-valsartan", new ValueWithNote("36030761", "amlodipine / valsartan") },
//             { "amLODIPine-valsartan", new ValueWithNote("36030761", "amlodipine / valsartan") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "cobicistat-darunavir", new ValueWithNote("778934", "cobicistat / darunavir") },
//             { "cobicistat-darunavir", new ValueWithNote("778934", "cobicistat / darunavir") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "lidocaine-prilocaine", new ValueWithNote("36029745", "lidocaine / prilocaine") },
//             { "lidocaine-prilocaine", new ValueWithNote("36029745", "lidocaine / prilocaine") }, // Confidence: 95.0%, OMOP Match: 100.0%
            { "abacavir-lamiVUDine", new ValueWithNote("36030299", "abacavir / lamivudine") },
//             { "abacavir-lamiVUDine", new ValueWithNote("36030299", "abacavir / lamivudine") }, // Confidence: 94.7%, OMOP Match: 100.0%
            { "adrenaline", new ValueWithNote("44814295", "Adrenalin") },
//             { "adrenaline", new ValueWithNote("44814295", "Adrenalin") }, // Confidence: 94.7%, OMOP Match: 100.0%
            { "fibrinogen-thrombin", new ValueWithNote("36030145", "fibrinogen / thrombin") },
//             { "fibrinogen-thrombin", new ValueWithNote("36030145", "fibrinogen / thrombin") }, // Confidence: 94.7%, OMOP Match: 100.0%
            { "lopinavir-ritonavir", new ValueWithNote("36030114", "lopinavir / ritonavir") },
//             { "lopinavir-ritonavir", new ValueWithNote("36030114", "lopinavir / ritonavir") }, // Confidence: 94.7%, OMOP Match: 100.0%
            { "rabies immunoglobulin, human", new ValueWithNote("19135830", "rabies immune globulin, human") },
//             { "rabies immunoglobulin, human", new ValueWithNote("19135830", "rabies immune globulin, human") }, // Confidence: 94.7%, OMOP Match: 100.0%
            { "Coal tar + Lecithin", new ValueWithNote("36030357", "coal tar / lecithin") },
//             { "Coal tar + Lecithin", new ValueWithNote("36030357", "coal tar / lecithin") }, // Confidence: 94.7%, OMOP Match: 100.0%
            { "factor VIII-von Willebrand factor", new ValueWithNote("36030083", "factor VIII / von Willebrand factor") },
//             { "factor VIII-von Willebrand factor", new ValueWithNote("36030083", "factor VIII / von Willebrand factor") }, // Confidence: 94.1%, OMOP Match: 100.0%
            { "Ethinylestradiol + norETHISTerone", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") },
//             { "Ethinylestradiol + norETHISTerone", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") }, // Confidence: 94.1%, OMOP Match: 100.0%
            { "L-acetylcarnitine", new ValueWithNote("19037596", "acetylcarnitine") },
//             { "L-acetylcarnitine", new ValueWithNote("19037596", "acetylcarnitine") }, // Confidence: 93.8%, OMOP Match: 100.0%
            { "chlorphenamine", new ValueWithNote("19049707", "chlorphenoxamine") },
//             { "chlorphenamine", new ValueWithNote("19049707", "chlorphenoxamine") }, // Confidence: 93.3%, OMOP Match: 100.0%
            { "estradiol-medroxyPROGESTERone", new ValueWithNote("36030310", "estradiol / medroxyprogesterone") },
//             { "estradiol-medroxyPROGESTERone", new ValueWithNote("36030310", "estradiol / medroxyprogesterone") }, // Confidence: 93.3%, OMOP Match: 100.0%
            { "betamethasone-salicylic acid", new ValueWithNote("36027016", "betamethasone / salicylic acid") },
//             { "betamethasone-salicylic acid", new ValueWithNote("36027016", "betamethasone / salicylic acid") }, // Confidence: 93.1%, OMOP Match: 100.0%
            { "calcium carbonate-prasterone", new ValueWithNote("36028330", "calcium carbonate / prasterone") },
//             { "calcium carbonate-prasterone", new ValueWithNote("36028330", "calcium carbonate / prasterone") }, // Confidence: 93.1%, OMOP Match: 100.0%
            { "lidocaine-methylPREDNISolone", new ValueWithNote("36029284", "lidocaine / methylprednisolone") },
//             { "lidocaine-methylPREDNISolone", new ValueWithNote("36029284", "lidocaine / methylprednisolone") }, // Confidence: 93.1%, OMOP Match: 100.0%
            { "loperamide-simeticone", new ValueWithNote("36030021", "loperamide / simethicone") },
//             { "loperamide-simeticone", new ValueWithNote("36030021", "loperamide / simethicone") }, // Confidence: 93.0%, OMOP Match: 100.0%
            { "bendroflumethiazide-timolol", new ValueWithNote("36030341", "bendroflumethiazide / timolol") },
//             { "bendroflumethiazide-timolol", new ValueWithNote("36030341", "bendroflumethiazide / timolol") }, // Confidence: 92.9%, OMOP Match: 100.0%
            { "clotrimazole-hydrocortisone", new ValueWithNote("36030105", "clotrimazole / hydrocortisone") },
//             { "clotrimazole-hydrocortisone", new ValueWithNote("36030105", "clotrimazole / hydrocortisone") }, // Confidence: 92.9%, OMOP Match: 100.0%
            { "glycopyrronium-neostigmine", new ValueWithNote("36028189", "glycopyrronium / neostigmine") },
//             { "glycopyrronium-neostigmine", new ValueWithNote("36028189", "glycopyrronium / neostigmine") }, // Confidence: 92.6%, OMOP Match: 100.0%
            { "estradiol/norETHISTerone/relugolix", new ValueWithNote("779054", "estradiol / norethindrone / relugolix") },
//             { "estradiol/norETHISTerone/relugolix", new ValueWithNote("779054", "estradiol / norethindrone / relugolix") }, // Confidence: 92.5%, OMOP Match: 100.0%
            { "crotamiton-hydrocortisone", new ValueWithNote("36029273", "crotamiton / hydrocortisone") },
//             { "crotamiton-hydrocortisone", new ValueWithNote("36029273", "crotamiton / hydrocortisone") }, // Confidence: 92.3%, OMOP Match: 100.0%
            { "erythromycin-zinc acetate", new ValueWithNote("36030166", "erythromycin / zinc acetate") },
//             { "erythromycin-zinc acetate", new ValueWithNote("36030166", "erythromycin / zinc acetate") }, // Confidence: 92.3%, OMOP Match: 100.0%
            { "formoterol-glycopyrronium", new ValueWithNote("36029773", "formoterol / glycopyrronium") },
//             { "formoterol-glycopyrronium", new ValueWithNote("36029773", "formoterol / glycopyrronium") }, // Confidence: 92.3%, OMOP Match: 100.0%
            { "hydrocortisone-miconazole", new ValueWithNote("36029277", "hydrocortisone / miconazole") },
//             { "hydrocortisone-miconazole", new ValueWithNote("36029277", "hydrocortisone / miconazole") }, // Confidence: 92.3%, OMOP Match: 100.0%
            { "hypromellose ophthalmic", new ValueWithNote("40056206", "hypromellose Ophthalmic Gel") },
//             { "hypromellose ophthalmic", new ValueWithNote("40056206", "hypromellose Ophthalmic Gel") }, // Confidence: 92.0%, OMOP Match: 100.0%
            { "betamethasone-clioquinol", new ValueWithNote("36027015", "betamethasone / clioquinol") },
//             { "betamethasone-clioquinol", new ValueWithNote("36027015", "betamethasone / clioquinol") }, // Confidence: 92.0%, OMOP Match: 100.0%
            { "dydrogesterone-estradiol", new ValueWithNote("36030766", "dydrogesterone / estradiol") },
//             { "dydrogesterone-estradiol", new ValueWithNote("36030766", "dydrogesterone / estradiol") }, // Confidence: 92.0%, OMOP Match: 100.0%
            { "cetrimide-chlorhexidine", new ValueWithNote("36029297", "cetrimide / chlorhexidine") },
//             { "cetrimide-chlorhexidine", new ValueWithNote("36029297", "cetrimide / chlorhexidine") }, // Confidence: 91.7%, OMOP Match: 100.0%
            { "chlorhexidine-lidocaine", new ValueWithNote("36029292", "chlorhexidine / lidocaine") },
//             { "chlorhexidine-lidocaine", new ValueWithNote("36029292", "chlorhexidine / lidocaine") }, // Confidence: 91.7%, OMOP Match: 100.0%
            { "ganciclovir ophthalmic", new ValueWithNote("40047166", "ganciclovir Ophthalmic Gel") },
//             { "ganciclovir ophthalmic", new ValueWithNote("40047166", "ganciclovir Ophthalmic Gel") }, // Confidence: 91.7%, OMOP Match: 100.0%
            { "Ethinylestradiol + norETHISTerone ace", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") },
//             { "Ethinylestradiol + norETHISTerone ace", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") }, // Confidence: 91.7%, OMOP Match: 100.0%
            { "ubidecarenone-vitamin E", new ValueWithNote("36029194", "ubidecarenone / vitamin E") },
//             { "ubidecarenone-vitamin E", new ValueWithNote("36029194", "ubidecarenone / vitamin E") }, // Confidence: 91.7%, OMOP Match: 100.0%
            { "valACiclovir", new ValueWithNote("1717704", "valacyclovir") },
//             { "valACiclovir", new ValueWithNote("1717704", "valacyclovir") }, // Confidence: 91.7%, OMOP Match: 100.0%
            { "quiNINE bisulphate", new ValueWithNote("19135856", "quinine bisulfate") },
//             { "quiNINE bisulphate", new ValueWithNote("19135856", "quinine bisulfate") }, // Confidence: 91.4%, OMOP Match: 100.0%
            { "chlorhexidine-neomycin", new ValueWithNote("36031065", "chlorhexidine / neomycin") },
//             { "chlorhexidine-neomycin", new ValueWithNote("36031065", "chlorhexidine / neomycin") }, // Confidence: 91.3%, OMOP Match: 100.0%
            { "indapamide-perindopril", new ValueWithNote("36030141", "indapamide / perindopril") },
//             { "indapamide-perindopril", new ValueWithNote("36030141", "indapamide / perindopril") }, // Confidence: 91.3%, OMOP Match: 100.0%
            { "sodium chloride nasal", new ValueWithNote("40080074", "sodium chloride Nasal Gel") },
//             { "sodium chloride nasal", new ValueWithNote("40080074", "sodium chloride Nasal Gel") }, // Confidence: 91.3%, OMOP Match: 100.0%
            { "ethinylestradiol-norelgestromin", new ValueWithNote("36030133", "ethinyl estradiol / norelgestromin") },
//             { "ethinylestradiol-norelgestromin", new ValueWithNote("36030133", "ethinyl estradiol / norelgestromin") }, // Confidence: 90.9%, OMOP Match: 100.0%
            { "ethinylestradiol-levonorgestrel", new ValueWithNote("36029985", "ethinyl estradiol / levonorgestrel") },
//             { "ethinylestradiol-levonorgestrel", new ValueWithNote("36029985", "ethinyl estradiol / levonorgestrel") }, // Confidence: 90.9%, OMOP Match: 100.0%
            { "Ethinylestradiol-levonorgestrel", new ValueWithNote("36029985", "ethinyl estradiol / levonorgestrel") },
//             { "Ethinylestradiol-levonorgestrel", new ValueWithNote("36029985", "ethinyl estradiol / levonorgestrel") }, // Confidence: 90.9%, OMOP Match: 100.0%
            { "heparinoid-salicylic acid", new ValueWithNote("36028188", "heparinoids / salicylic acid") },
//             { "heparinoid-salicylic acid", new ValueWithNote("36028188", "heparinoids / salicylic acid") }, // Confidence: 90.6%, OMOP Match: 100.0%
            { "aMILoride-bumetanide", new ValueWithNote("36030337", "amiloride / bumetanide") },
//             { "aMILoride-bumetanide", new ValueWithNote("36030337", "amiloride / bumetanide") }, // Confidence: 90.5%, OMOP Match: 100.0%
            { "oxymetazoline nasal", new ValueWithNote("739543", "oxymetazoline Nasal Gel") },
//             { "oxymetazoline nasal", new ValueWithNote("739543", "oxymetazoline Nasal Gel") }, // Confidence: 90.5%, OMOP Match: 100.0%
            { "ethinylestradiol-norgestimate", new ValueWithNote("36029986", "ethinyl estradiol / norgestimate") },
//             { "ethinylestradiol-norgestimate", new ValueWithNote("36029986", "ethinyl estradiol / norgestimate") }, // Confidence: 90.3%, OMOP Match: 100.0%
            { "drospirenone-ethinylestradiol", new ValueWithNote("36031101", "drospirenone / ethinyl estradiol") },
//             { "drospirenone-ethinylestradiol", new ValueWithNote("36031101", "drospirenone / ethinyl estradiol") }, // Confidence: 90.3%, OMOP Match: 100.0%
            { "mefenamic acid", new ValueWithNote("19125097", "meclofenamic acid") },
//             { "mefenamic acid", new ValueWithNote("19125097", "meclofenamic acid") }, // Confidence: 90.3%, OMOP Match: 100.0%
            { "Mucin + Xylitol", new ValueWithNote("36030769", "mucins / xylitol") },
//             { "Mucin + Xylitol", new ValueWithNote("36030769", "mucins / xylitol") }, // Confidence: 90.3%, OMOP Match: 100.0%
            { "allantoin-lidocaine", new ValueWithNote("36030317", "allantoin / lidocaine") },
//             { "allantoin-lidocaine", new ValueWithNote("36030317", "allantoin / lidocaine") }, // Confidence: 90.0%, OMOP Match: 100.0%
            { "desogestrel-ethinylestradiol", new ValueWithNote("36030123", "desogestrel / ethinyl estradiol") },
//             { "desogestrel-ethinylestradiol", new ValueWithNote("36030123", "desogestrel / ethinyl estradiol") }, // Confidence: 90.0%, OMOP Match: 100.0%
            { "FELOdipine-ramipril", new ValueWithNote("36030144", "felodipine / ramipril") },
//             { "FELOdipine-ramipril", new ValueWithNote("36030144", "felodipine / ramipril") }, // Confidence: 90.0%, OMOP Match: 100.0%
            { "mesalazine", new ValueWithNote("968426", "mesalamine") },
//             { "mesalazine", new ValueWithNote("968426", "mesalamine") }, // Confidence: 90.0%, OMOP Match: 100.0%
            { "timolol ophthalmic", new ValueWithNote("40087909", "timolol Ophthalmic Gel") },
//             { "timolol ophthalmic", new ValueWithNote("40087909", "timolol Ophthalmic Gel") }, // Confidence: 90.0%, OMOP Match: 100.0%
            { "urea hydrogen peroxide otic", new ValueWithNote("958999", "carbamide peroxide") },
//             { "urea hydrogen peroxide otic", new ValueWithNote("958999", "carbamide peroxide") }, // Confidence: 89.8%, OMOP Match: 100.0%
            { "budesonide/formoterol/glycopyrronium", new ValueWithNote("779032", "budesonide / formoterol / glycopyrronium") },
//             { "budesonide/formoterol/glycopyrronium", new ValueWithNote("779032", "budesonide / formoterol / glycopyrronium") }, // Confidence: 89.5%, OMOP Match: 100.0%
            { "naloxone-oxycodone", new ValueWithNote("36029671", "naloxone / oxycodone") },
//             { "naloxone-oxycodone", new ValueWithNote("36029671", "naloxone / oxycodone") }, // Confidence: 89.5%, OMOP Match: 100.0%
            { "cefTORALine fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") },
//             { "cefTORALine fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") }, // Confidence: 89.5%, OMOP Match: 100.0%
            { "ethinylestradiol-gestodene", new ValueWithNote("36030295", "ethinyl estradiol / gestodene") },
//             { "ethinylestradiol-gestodene", new ValueWithNote("36030295", "ethinyl estradiol / gestodene") }, // Confidence: 89.3%, OMOP Match: 100.0%
            { "aciclovir", new ValueWithNote("1703687", "acyclovir") },
//             { "aciclovir", new ValueWithNote("1703687", "acyclovir") }, // Confidence: 88.9%, OMOP Match: 100.0%
            { "immunoglobulin normal intramuscular", new ValueWithNote("505117", "intramuscular immunoglobulin") },
//             { "immunoglobulin normal intramuscular", new ValueWithNote("505117", "intramuscular immunoglobulin") }, // Confidence: 88.9%, OMOP Match: 100.0%
            { "cetrimide-dimeticone", new ValueWithNote("36027191", "cetrimide / dimethicone") },
//             { "cetrimide-dimeticone", new ValueWithNote("36027191", "cetrimide / dimethicone") }, // Confidence: 88.4%, OMOP Match: 100.0%
            { "flucloxacillin", new ValueWithNote("1800835", "cloxacillin") },
//             { "flucloxacillin", new ValueWithNote("1800835", "cloxacillin") }, // Confidence: 88.0%, OMOP Match: 100.0%
            { "foliNic acid", new ValueWithNote("19129642", "oxolinic acid") },
//             { "foliNic acid", new ValueWithNote("19129642", "oxolinic acid") }, // Confidence: 88.0%, OMOP Match: 100.0%
            { "norETHISTerone", new ValueWithNote("19050090", "ethisterone") },
//             { "norETHISTerone", new ValueWithNote("19050090", "ethisterone") }, // Confidence: 88.0%, OMOP Match: 100.0%
            { "calcium polystyrene sulfonate", new ValueWithNote("19112563", "calcium polystyrene sulfonate product") },
//             { "calcium polystyrene sulfonate", new ValueWithNote("19112563", "calcium polystyrene sulfonate product") }, // Confidence: 87.9%, OMOP Match: 100.0%
            { "Insulin isophane biphasic porcine", new ValueWithNote("19053996", "Hypurin Porcine Biphasic Isophane") },
//             { "Insulin isophane biphasic porcine", new ValueWithNote("19053996", "Hypurin Porcine Biphasic Isophane") }, // Confidence: 87.9%, OMOP Match: 100.0%
            { "methylPREDNISolone oral", new ValueWithNote("1506270", "methylprednisolone") },
//             { "methylPREDNISolone oral", new ValueWithNote("1506270", "methylprednisolone") }, // Confidence: 87.8%, OMOP Match: 100.0%
            { "varicella immunoglobulin", new ValueWithNote("543291", "varicella-zoster immune globulin") },
//             { "varicella immunoglobulin", new ValueWithNote("543291", "varicella-zoster immune globulin") }, // Confidence: 87.3%, OMOP Match: 100.0%
            { "xylometazoline nasal", new ValueWithNote("40101014", "xylometazoline Nasal Spray") },
//             { "xylometazoline nasal", new ValueWithNote("40101014", "xylometazoline Nasal Spray") }, // Confidence: 87.0%, OMOP Match: 100.0%
            { "chloramPHENICOL ophthalmic", new ValueWithNote("36216751", "chloramphenicol Ophthalmic Product") },
//             { "chloramPHENICOL ophthalmic", new ValueWithNote("36216751", "chloramphenicol Ophthalmic Product") }, // Confidence: 86.7%, OMOP Match: 100.0%
            { "fluorometholone ophthalmic", new ValueWithNote("36224796", "fluorometholone Ophthalmic Product") },
//             { "fluorometholone ophthalmic", new ValueWithNote("36224796", "fluorometholone Ophthalmic Product") }, // Confidence: 86.7%, OMOP Match: 100.0%
            { "Sodium chloride ophthalmic", new ValueWithNote("36227316", "sodium chloride Ophthalmic Product") },
//             { "Sodium chloride ophthalmic", new ValueWithNote("36227316", "sodium chloride Ophthalmic Product") }, // Confidence: 86.7%, OMOP Match: 100.0%
            { "isoniazid-rifaMPICIN", new ValueWithNote("36029269", "isoniazid / rifampin") },
//             { "isoniazid-rifaMPICIN", new ValueWithNote("36029269", "isoniazid / rifampin") }, // Confidence: 86.4%, OMOP Match: 100.0%
            { "paracetamol-traMADol", new ValueWithNote("36030125", "acetaminophen / tramadol") },
//             { "paracetamol-traMADol", new ValueWithNote("36030125", "acetaminophen / tramadol") }, // Confidence: 86.4%, OMOP Match: 100.0%
            { "triamcinolone nasal", new ValueWithNote("40085508", "triamcinolone Nasal Spray") },
//             { "triamcinolone nasal", new ValueWithNote("40085508", "triamcinolone Nasal Spray") }, // Confidence: 86.4%, OMOP Match: 100.0%
            { "sodium citrate ophthalmic", new ValueWithNote("36218153", "citrate Ophthalmic Product") },
//             { "sodium citrate ophthalmic", new ValueWithNote("36218153", "citrate Ophthalmic Product") }, // Confidence: 86.3%, OMOP Match: 100.0%
            { "acetylcysteine ophthalmic", new ValueWithNote("36216795", "acetylcysteine Ophthalmic Product") },
//             { "acetylcysteine ophthalmic", new ValueWithNote("36216795", "acetylcysteine Ophthalmic Product") }, // Confidence: 86.2%, OMOP Match: 100.0%
            { "cyclopentolate ophthalmic", new ValueWithNote("36213819", "cyclopentolate Ophthalmic Product") },
//             { "cyclopentolate ophthalmic", new ValueWithNote("36213819", "cyclopentolate Ophthalmic Product") }, // Confidence: 86.2%, OMOP Match: 100.0%
            { "sodium citrate irrigation", new ValueWithNote("36224415", "sodium citrate Irrigation Product") },
//             { "sodium citrate irrigation", new ValueWithNote("36224415", "sodium citrate Irrigation Product") }, // Confidence: 86.2%, OMOP Match: 100.0%
            { "apraclonidine ophthalmic", new ValueWithNote("36215199", "apraclonidine Ophthalmic Product") },
//             { "apraclonidine ophthalmic", new ValueWithNote("36215199", "apraclonidine Ophthalmic Product") }, // Confidence: 85.7%, OMOP Match: 100.0%
            { "betamethasone ophthalmic", new ValueWithNote("36212153", "betamethasone Ophthalmic Product") },
//             { "betamethasone ophthalmic", new ValueWithNote("36212153", "betamethasone Ophthalmic Product") }, // Confidence: 85.7%, OMOP Match: 100.0%
            { "ciprofloxacin ophthalmic", new ValueWithNote("36217289", "ciprofloxacin Ophthalmic Product") },
//             { "ciprofloxacin ophthalmic", new ValueWithNote("36217289", "ciprofloxacin Ophthalmic Product") }, // Confidence: 85.7%, OMOP Match: 100.0%
            { "dexamethasone ophthalmic", new ValueWithNote("36215259", "dexamethasone Ophthalmic Product") },
//             { "dexamethasone ophthalmic", new ValueWithNote("36215259", "dexamethasone Ophthalmic Product") }, // Confidence: 85.7%, OMOP Match: 100.0%
            { "phenylephrine ophthalmic", new ValueWithNote("36223312", "phenylephrine Ophthalmic Product") },
//             { "phenylephrine ophthalmic", new ValueWithNote("36223312", "phenylephrine Ophthalmic Product") }, // Confidence: 85.7%, OMOP Match: 100.0%
            { "brinZOLamide ophthalmic", new ValueWithNote("36219538", "brinzolamide Ophthalmic Product") },
//             { "brinZOLamide ophthalmic", new ValueWithNote("36219538", "brinzolamide Ophthalmic Product") }, // Confidence: 85.2%, OMOP Match: 100.0%
            { "levofloxacin ophthalmic", new ValueWithNote("36221026", "levofloxacin Ophthalmic Product") },
//             { "levofloxacin ophthalmic", new ValueWithNote("36221026", "levofloxacin Ophthalmic Product") }, // Confidence: 85.2%, OMOP Match: 100.0%
            { "sodium bicarbonate otic", new ValueWithNote("36227308", "sodium bicarbonate Otic Product") },
//             { "sodium bicarbonate otic", new ValueWithNote("36227308", "sodium bicarbonate Otic Product") }, // Confidence: 85.2%, OMOP Match: 100.0%
            { "moxifloxacin ophthalmic", new ValueWithNote("36213853", "moxifloxacin Ophthalmic Product") },
//             { "moxifloxacin ophthalmic", new ValueWithNote("36213853", "moxifloxacin Ophthalmic Product") }, // Confidence: 85.2%, OMOP Match: 100.0%
            { "prednisoLONE ophthalmic", new ValueWithNote("36220910", "prednisolone Ophthalmic Product") },
//             { "prednisoLONE ophthalmic", new ValueWithNote("36220910", "prednisolone Ophthalmic Product") }, // Confidence: 85.2%, OMOP Match: 100.0%
            { "briMONidine-brinZOLamide ophthalmic", new ValueWithNote(null, null) },
//             { "briMONidine-brinZOLamide ophthalmic", new ValueWithNote("36246176", "brimonidine / brinzolamide Ophthalmic Product") }, // Confidence: 85.0%, OMOP Match: 100.0%
            { "ipratropium nasal", new ValueWithNote(null, null) },
//             { "ipratropium nasal", new ValueWithNote("40049465", "ipratropium Nasal Spray") }, // Confidence: 85.0%, OMOP Match: 100.0%
            { "briMONidine ophthalmic", new ValueWithNote(null, null) },
//             { "briMONidine ophthalmic", new ValueWithNote("36219537", "brimonidine Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "biMAToprost ophthalmic", new ValueWithNote(null, null) },
//             { "biMAToprost ophthalmic", new ValueWithNote("36226260", "bimatoprost Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "DORzolamide ophthalmic", new ValueWithNote(null, null) },
//             { "DORzolamide ophthalmic", new ValueWithNote("36224178", "dorzolamide Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "latanoprost ophthalmic", new ValueWithNote(null, null) },
//             { "latanoprost ophthalmic", new ValueWithNote("36226918", "latanoprost Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "levobunolol ophthalmic", new ValueWithNote(null, null) },
//             { "levobunolol ophthalmic", new ValueWithNote("36221015", "levobunolol Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "propamidine ophthalmic", new ValueWithNote(null, null) },
//             { "propamidine ophthalmic", new ValueWithNote("36211817", "propamidine Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "olopatadine ophthalmic", new ValueWithNote(null, null) },
//             { "olopatadine ophthalmic", new ValueWithNote("36223879", "olopatadine Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "tropicamide ophthalmic", new ValueWithNote(null, null) },
//             { "tropicamide ophthalmic", new ValueWithNote("36227351", "tropicamide Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "Witch hazel ophthalmic", new ValueWithNote(null, null) },
//             { "Witch hazel ophthalmic", new ValueWithNote("36227261", "witch hazel Ophthalmic Product") }, // Confidence: 84.6%, OMOP Match: 100.0%
            { "beclometasone nasal", new ValueWithNote(null, null) },
//             { "beclometasone nasal", new ValueWithNote("40010699", "beclomethasone Nasal Spray") }, // Confidence: 84.4%, OMOP Match: 100.0%
            { "betamethasone-neomycin ophthalmic", new ValueWithNote(null, null) },
//             { "betamethasone-neomycin ophthalmic", new ValueWithNote("36212136", "betamethasone / neomycin Ophthalmic Product") }, // Confidence: 84.2%, OMOP Match: 100.0%
            { "azelastine nasal", new ValueWithNote(null, null) },
//             { "azelastine nasal", new ValueWithNote("40133581", "azelastine Nasal Spray") }, // Confidence: 84.2%, OMOP Match: 100.0%
            { "gentamicin-hydrocortisone otic", new ValueWithNote(null, null) },
//             { "gentamicin-hydrocortisone otic", new ValueWithNote("36029279", "gentamicin / hydrocortisone") }, // Confidence: 84.2%, OMOP Match: 100.0%
            { "mometasone nasal", new ValueWithNote(null, null) },
//             { "mometasone nasal", new ValueWithNote("40066277", "mometasone Nasal Spray") }, // Confidence: 84.2%, OMOP Match: 100.0%
            { "budesonide nasal", new ValueWithNote(null, null) },
//             { "budesonide nasal", new ValueWithNote("40020313", "budesonide Nasal Spray") }, // Confidence: 84.2%, OMOP Match: 100.0%
            { "azelastine-fluticasone nasal", new ValueWithNote(null, null) },
//             { "azelastine-fluticasone nasal", new ValueWithNote("778911", "azelastine / fluticasone") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "azelastine ophthalmic", new ValueWithNote(null, null) },
//             { "azelastine ophthalmic", new ValueWithNote("36225520", "azelastine Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "cefUROXime ophthalmic", new ValueWithNote(null, null) },
//             { "cefUROXime ophthalmic", new ValueWithNote("36217283", "cefuroxime Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "diclofenac ophthalmic", new ValueWithNote(null, null) },
//             { "diclofenac ophthalmic", new ValueWithNote("36217233", "diclofenac Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "epinastine ophthalmic", new ValueWithNote(null, null) },
//             { "epinastine ophthalmic", new ValueWithNote("36225777", "epinastine Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "gentamicin ophthalmic", new ValueWithNote(null, null) },
//             { "gentamicin ophthalmic", new ValueWithNote("1594375", "gentamicin Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "lodoxamide ophthalmic", new ValueWithNote(null, null) },
//             { "lodoxamide ophthalmic", new ValueWithNote("36221142", "lodoxamide Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "tetracaine ophthalmic", new ValueWithNote(null, null) },
//             { "tetracaine ophthalmic", new ValueWithNote("36221743", "tetracaine Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "traVOprost ophthalmic", new ValueWithNote(null, null) },
//             { "traVOprost ophthalmic", new ValueWithNote("36225495", "travoprost Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "taFLuprost ophthalmic", new ValueWithNote(null, null) },
//             { "taFLuprost ophthalmic", new ValueWithNote("36238005", "tafluprost Ophthalmic Product") }, // Confidence: 84.0%, OMOP Match: 100.0%
            { "bromfenac ophthalmic", new ValueWithNote(null, null) },
//             { "bromfenac ophthalmic", new ValueWithNote("36219545", "bromfenac Ophthalmic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "chloramPHENICOL otic", new ValueWithNote(null, null) },
//             { "chloramPHENICOL otic", new ValueWithNote("36216754", "chloramphenicol Otic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "dicycloverine", new ValueWithNote(null, null) },
//             { "dicycloverine", new ValueWithNote("1710446", "cycloserine") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "ephedrine nasal", new ValueWithNote(null, null) },
//             { "ephedrine nasal", new ValueWithNote("40037821", "ephedrine Nasal Spray") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "ketorolac ophthalmic", new ValueWithNote(null, null) },
//             { "ketorolac ophthalmic", new ValueWithNote("36225366", "ketorolac Ophthalmic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "nepafenac ophthalmic", new ValueWithNote(null, null) },
//             { "nepafenac ophthalmic", new ValueWithNote("36223788", "nepafenac Ophthalmic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "ofloxacin ophthalmic", new ValueWithNote(null, null) },
//             { "ofloxacin ophthalmic", new ValueWithNote("36227393", "ofloxacin Ophthalmic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "betaxolol ophthalmic", new ValueWithNote(null, null) },
//             { "betaxolol ophthalmic", new ValueWithNote("36212161", "betaxolol Ophthalmic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "ketotifen ophthalmic", new ValueWithNote(null, null) },
//             { "ketotifen ophthalmic", new ValueWithNote("36225372", "ketotifen Ophthalmic Product") }, // Confidence: 83.3%, OMOP Match: 100.0%
            { "atropine ophthalmic", new ValueWithNote(null, null) },
//             { "atropine ophthalmic", new ValueWithNote("36212940", "atropine Ophthalmic Product") }, // Confidence: 82.6%, OMOP Match: 100.0%
            { "Insulin isophane bovine", new ValueWithNote(null, null) },
//             { "Insulin isophane bovine", new ValueWithNote("46221581", "insulin isophane") }, // Confidence: 82.1%, OMOP Match: 100.0%
            { "ciprofloxacin otic", new ValueWithNote(null, null) },
//             { "ciprofloxacin otic", new ValueWithNote("36217292", "ciprofloxacin Otic Product") }, // Confidence: 81.8%, OMOP Match: 100.0%
            { "citric acid/Mg oxide/Na picosulfate", new ValueWithNote(null, null) },
//             { "citric acid/Mg oxide/Na picosulfate", new ValueWithNote("36029516", "citric acid / magnesium oxide / picosulfurate") }, // Confidence: 81.5%, OMOP Match: 100.0%
            { "lidocaine-phenylephrine nasal", new ValueWithNote(null, null) },
//             { "lidocaine-phenylephrine nasal", new ValueWithNote("36030085", "lidocaine / phenylephrine") }, // Confidence: 81.5%, OMOP Match: 100.0%
            { "Zuclopenthixol acetate injection", new ValueWithNote(null, null) },
//             { "Zuclopenthixol acetate injection", new ValueWithNote("19121994", "zuclopenthixol acetate") }, // Confidence: 81.5%, OMOP Match: 100.0%
            { "amylmetacresol-dichlorobenzyl alc top", new ValueWithNote(null, null) },
//             { "amylmetacresol-dichlorobenzyl alc top", new ValueWithNote("36028603", "amylmetacresol / dichlorobenzyl alcohol / menthol") }, // Confidence: 81.4%, OMOP Match: 100.0%
            { "timolol-traVOprost ophthalmic", new ValueWithNote(null, null) },
//             { "timolol-traVOprost ophthalmic", new ValueWithNote("40099457", "travoprost Ophthalmic Solution") }, // Confidence: 81.4%, OMOP Match: 100.0%
            { "fluticasone nasal", new ValueWithNote(null, null) },
//             { "fluticasone nasal", new ValueWithNote("36220588", "fluticasone Nasal Product") }, // Confidence: 81.0%, OMOP Match: 100.0%
            { "Convalescent Plasma", new ValueWithNote(null, null) },
//             { "Convalescent Plasma", new ValueWithNote("33000", "COVID-19 convalescent plasma") }, // Confidence: 80.9%, OMOP Match: 100.0%
            { "clioquinol-flumetasone otic", new ValueWithNote(null, null) },
//             { "clioquinol-flumetasone otic", new ValueWithNote("36030361", "clioquinol / flumethasone") }, // Confidence: 80.8%, OMOP Match: 100.0%
            { "Estradiol + norETHISTerone", new ValueWithNote(null, null) },
//             { "Estradiol + norETHISTerone", new ValueWithNote("36030820", "ethinyl estradiol / ethisterone") }, // Confidence: 80.7%, OMOP Match: 100.0%
            { "acetic acid otic", new ValueWithNote(null, null) },
//             { "acetic acid otic", new ValueWithNote("36217021", "acetic acid Otic Product") }, // Confidence: 80.0%, OMOP Match: 100.0%
            { "benzalkonium chloride-cetrimide", new ValueWithNote(null, null) },
//             { "benzalkonium chloride-cetrimide", new ValueWithNote("36030307", "benzalkonium / cetrimide") }, // Confidence: 80.0%, OMOP Match: 100.0%
            { "citric acid-magnesium carbonate", new ValueWithNote(null, null) },
//             { "citric acid-magnesium carbonate", new ValueWithNote("36030486", "citric acid / magnesium oxide / sodium carbonate") }, // Confidence: 80.0%, OMOP Match: 100.0%
            { "Digoxin specific antibody", new ValueWithNote(null, null) },
//             { "Digoxin specific antibody", new ValueWithNote("35603726", "ovine digoxin immune fab") }, // Confidence: 80.0%, OMOP Match: 100.0%
            { "Urea (13-C)", new ValueWithNote(null, null) },
//             { "Urea (13-C)", new ValueWithNote("19054337", "urea c-13") }, // Confidence: 80.0%, OMOP Match: 100.0%
            { "Potassium chloride 20mmol with Glucose 5", new ValueWithNote(null, null) },
//             { "Potassium chloride 20mmol with Glucose 5", new ValueWithNote("36030057", "glucose / potassium chloride") }, // Confidence: 79.4%, OMOP Match: 100.0%
            { "Potassium chloride 20mmol with Glucose 2", new ValueWithNote(null, null) },
//             { "Potassium chloride 20mmol with Glucose 2", new ValueWithNote("36030057", "glucose / potassium chloride") }, // Confidence: 79.4%, OMOP Match: 100.0%
            { "Potassium chloride 10mmol with Glucose 1", new ValueWithNote(null, null) },
//             { "Potassium chloride 10mmol with Glucose 1", new ValueWithNote("36030057", "glucose / potassium chloride") }, // Confidence: 79.4%, OMOP Match: 100.0%
            { "Potassium chloride 10mmol with Glucose 5", new ValueWithNote(null, null) },
//             { "Potassium chloride 10mmol with Glucose 5", new ValueWithNote("36030057", "glucose / potassium chloride") }, // Confidence: 79.4%, OMOP Match: 100.0%
            { "Potassium chloride 20mmol with Glucose 1", new ValueWithNote(null, null) },
//             { "Potassium chloride 20mmol with Glucose 1", new ValueWithNote("36030057", "glucose / potassium chloride") }, // Confidence: 79.4%, OMOP Match: 100.0%
            { "chlorhexidine-fluoride", new ValueWithNote(null, null) },
//             { "chlorhexidine-fluoride", new ValueWithNote("36027304", "chlorhexidine / sodium fluoride") }, // Confidence: 79.2%, OMOP Match: 100.0%
            { "cicloSPORIN ophthalmic", new ValueWithNote(null, null) },
//             { "cicloSPORIN ophthalmic", new ValueWithNote("36213827", "cyclosporine Ophthalmic Product") }, // Confidence: 79.2%, OMOP Match: 100.0%
            { "aciclovir ophthalmic", new ValueWithNote(null, null) },
//             { "aciclovir ophthalmic", new ValueWithNote("36217182", "acyclovir Ophthalmic Product") }, // Confidence: 79.2%, OMOP Match: 100.0%
            { "amphotericin B (Fungizone)", new ValueWithNote(null, null) },
//             { "amphotericin B (Fungizone)", new ValueWithNote("19098044", "amphotericin B 30 MG/ML [Fungizone]") }, // Confidence: 78.7%, OMOP Match: 100.0%
            { "Zuclopenthixol decanoate depot inject", new ValueWithNote(null, null) },
//             { "Zuclopenthixol decanoate depot inject", new ValueWithNote("19121997", "zuclopenthixol decanoate") }, // Confidence: 78.7%, OMOP Match: 100.0%
            { "insulin isophane biphasic", new ValueWithNote(null, null) },
//             { "insulin isophane biphasic", new ValueWithNote("46221581", "insulin isophane") }, // Confidence: 78.0%, OMOP Match: 100.0%
            { "potassium ascorbate ophthalmic", new ValueWithNote(null, null) },
//             { "potassium ascorbate ophthalmic", new ValueWithNote("36027699", "calcium ascorbate / potassium") }, // Confidence: 78.0%, OMOP Match: 100.0%
            { "fentaNYL-LEVObupivacaine", new ValueWithNote(null, null) },
//             { "fentaNYL-LEVObupivacaine", new ValueWithNote("19098741", "levobupivacaine") }, // Confidence: 76.9%, OMOP Match: 100.0%
            { "cocaine nasal", new ValueWithNote(null, null) },
//             { "cocaine nasal", new ValueWithNote("36213696", "cocaine Nasal Product") }, // Confidence: 76.5%, OMOP Match: 100.0%
            { "estradiol-norETHISTerone", new ValueWithNote(null, null) },
//             { "estradiol-norETHISTerone", new ValueWithNote("36030820", "ethinyl estradiol / ethisterone") }, // Confidence: 76.4%, OMOP Match: 100.0%
            { "immunoglobulin subcutaneous", new ValueWithNote(null, null) },
//             { "immunoglobulin subcutaneous", new ValueWithNote("551749", "immunoglobulins, intravenous") }, // Confidence: 76.4%, OMOP Match: 100.0%
            { "Liquid paraffin + Magnesium hydroxide", new ValueWithNote(null, null) },
//             { "Liquid paraffin + Magnesium hydroxide", new ValueWithNote("36215463", "magnesium hydroxide Oral Liquid Product") }, // Confidence: 76.3%, OMOP Match: 100.0%
            { "antazoline-xylometazoline ophthalmic", new ValueWithNote(null, null) },
//             { "antazoline-xylometazoline ophthalmic", new ValueWithNote("36030351", "antazoline / xylometazoline") }, // Confidence: 76.2%, OMOP Match: 100.0%
            { "argipressin (vasopressin)", new ValueWithNote(null, null) },
//             { "argipressin (vasopressin)", new ValueWithNote("19006871", "argipressin") }, // Confidence: 76.0%, OMOP Match: 100.0%
            { "betamethasone-fusidic acid", new ValueWithNote(null, null) },
//             { "betamethasone-fusidic acid", new ValueWithNote("36027464", "betamethasone / fusidate") }, // Confidence: 76.0%, OMOP Match: 100.0%
            { "Lidocaine + Adrenaline + Tetracaine", new ValueWithNote(null, null) },
//             { "Lidocaine + Adrenaline + Tetracaine", new ValueWithNote("36028515", "adrenalone / tetracaine") }, // Confidence: 75.9%, OMOP Match: 100.0%
            { "insulin aspart biphasic", new ValueWithNote(null, null) },
//             { "insulin aspart biphasic", new ValueWithNote("1567198", "insulin aspart, human") }, // Confidence: 75.7%, OMOP Match: 100.0%
            { "insulin lispro biphasic", new ValueWithNote(null, null) },
//             { "insulin lispro biphasic", new ValueWithNote("1550023", "insulin lispro") }, // Confidence: 75.7%, OMOP Match: 100.0%
            { "Bee venom", new ValueWithNote(null, null) },
//             { "Bee venom", new ValueWithNote("514834", "honey bee venom") }, // Confidence: 75.0%, OMOP Match: 100.0%
            { "ispaghula-senna", new ValueWithNote(null, null) },
//             { "ispaghula-senna", new ValueWithNote("19132967", "ispaghula extract") }, // Confidence: 75.0%, OMOP Match: 100.0%
            { "Terpin + Codeine", new ValueWithNote(null, null) },
//             { "Terpin + Codeine", new ValueWithNote("36030564", "codeine / terpin hydrate") }, // Confidence: 75.0%, OMOP Match: 100.0%
            { "Alpha tocopherol + Selenium", new ValueWithNote(null, null) },
//             { "Alpha tocopherol + Selenium", new ValueWithNote("19056802", "alpha tocopherol") }, // Confidence: 74.4%, OMOP Match: 100.0%
            { "brinZOLamide-timolol ophthalmic", new ValueWithNote(null, null) },
//             { "brinZOLamide-timolol ophthalmic", new ValueWithNote("36219538", "brinzolamide Ophthalmic Product") }, // Confidence: 74.2%, OMOP Match: 100.0%
            { "phenoxymethylpenicillin potassium", new ValueWithNote(null, null) },
//             { "phenoxymethylpenicillin potassium", new ValueWithNote("19133859", "penicillin V potassium 50 MG/ML Oral Solution") }, // Confidence: 74.2%, OMOP Match: 100.0%
            { "Glucose 4% with 0.18% Sodium Chloride in", new ValueWithNote(null, null) },
//             { "Glucose 4% with 0.18% Sodium Chloride in", new ValueWithNote("36029299", "glucose / sodium chloride") }, // Confidence: 73.8%, OMOP Match: 100.0%
            { "Glucose 5% with 0.45% Sodium Chloride in", new ValueWithNote(null, null) },
//             { "Glucose 5% with 0.45% Sodium Chloride in", new ValueWithNote("36029299", "glucose / sodium chloride") }, // Confidence: 73.8%, OMOP Match: 100.0%
            { "Glucose 5% with 0.9% Sodium Chloride int", new ValueWithNote(null, null) },
//             { "Glucose 5% with 0.9% Sodium Chloride int", new ValueWithNote("36029299", "glucose / sodium chloride") }, // Confidence: 73.8%, OMOP Match: 100.0%
            { "Glucose 10% with Sodium Chloride 0.18% i", new ValueWithNote(null, null) },
//             { "Glucose 10% with Sodium Chloride 0.18% i", new ValueWithNote("36029299", "glucose / sodium chloride") }, // Confidence: 73.8%, OMOP Match: 100.0%
            { "briMONidine-timolol ophthalmic", new ValueWithNote(null, null) },
//             { "briMONidine-timolol ophthalmic", new ValueWithNote("36030258", "brimonidine / timolol") }, // Confidence: 73.5%, OMOP Match: 100.0%
            { "DORzolamide-timolol ophthalmic", new ValueWithNote(null, null) },
//             { "DORzolamide-timolol ophthalmic", new ValueWithNote("36030344", "dorzolamide / timolol") }, // Confidence: 73.5%, OMOP Match: 100.0%
            { "biMAToprost-timolol ophthalmic", new ValueWithNote(null, null) },
//             { "biMAToprost-timolol ophthalmic", new ValueWithNote("36226260", "bimatoprost Ophthalmic Product") }, // Confidence: 73.3%, OMOP Match: 100.0%
            { "Liquid paraffin ophthalmic", new ValueWithNote(null, null) },
//             { "Liquid paraffin ophthalmic", new ValueWithNote("908523", "mineral oil") }, // Confidence: 73.2%, OMOP Match: 100.0%
            { "ichthammol-zinc oxide", new ValueWithNote(null, null) },
//             { "ichthammol-zinc oxide", new ValueWithNote("36030285", "ichthammol / zinc oxide") }, // Confidence: 72.7%, OMOP Match: 100.0%
            { "taFLuprost-timolol ophthalmic", new ValueWithNote(null, null) },
//             { "taFLuprost-timolol ophthalmic", new ValueWithNote("36238005", "tafluprost Ophthalmic Product") }, // Confidence: 72.4%, OMOP Match: 100.0%
            { "trometamol (THAM))", new ValueWithNote(null, null) },
//             { "trometamol (THAM))", new ValueWithNote("1511352", "trometamol citrate") }, // Confidence: 72.2%, OMOP Match: 100.0%
            { "dexamethasone/neomycin/polymyxin B ophth", new ValueWithNote(null, null) },
//             { "dexamethasone/neomycin/polymyxin B ophth", new ValueWithNote("36213940", "dexamethasone / neomycin / polymyxin B Ophthalmic Product") }, // Confidence: 72.2%, OMOP Match: 100.0%
            { "piperacillin-tazobactam (Tazocin equival", new ValueWithNote(null, null) },
//             { "piperacillin-tazobactam (Tazocin equival", new ValueWithNote("46275426", "piperacillin / tazobactam Injection") }, // Confidence: 72.0%, OMOP Match: 100.0%
            { "proxymetacaine ophthalmic", new ValueWithNote(null, null) },
//             { "proxymetacaine ophthalmic", new ValueWithNote("929504", "proparacaine") }, // Confidence: 71.8%, OMOP Match: 100.0%
            { "lidocaine-zinc oxide", new ValueWithNote(null, null) },
//             { "lidocaine-zinc oxide", new ValueWithNote("36030290", "lidocaine / zinc oxide") }, // Confidence: 71.4%, OMOP Match: 100.0%
            { "sodium alginate-potassium bicarbonate", new ValueWithNote(null, null) },
//             { "sodium alginate-potassium bicarbonate", new ValueWithNote("36028316", "alginic acid / sodium bicarbonate") }, // Confidence: 71.4%, OMOP Match: 100.0%
            { "acetic acid/dexamethasone/neomycin otic", new ValueWithNote(null, null) },
//             { "acetic acid/dexamethasone/neomycin otic", new ValueWithNote("36213943", "dexamethasone / neomycin Otic Product") }, // Confidence: 71.1%, OMOP Match: 100.0%
            { "Calcium citrate + Colecalciferol", new ValueWithNote(null, null) },
//             { "Calcium citrate + Colecalciferol", new ValueWithNote("36027950", "calcium citrate / cholecalciferol") }, // Confidence: 70.8%, OMOP Match: 100.0%
            { "Al hydroxide/Mg hydroxide/simeticone", new ValueWithNote(null, null) },
//             { "Al hydroxide/Mg hydroxide/simeticone", new ValueWithNote("36027592", "aluminum hydroxide / simethicone") }, // Confidence: 70.6%, OMOP Match: 100.0%
            { "latanoprost-timolol ophthalmic", new ValueWithNote(null, null) },
//             { "latanoprost-timolol ophthalmic", new ValueWithNote("36030140", "latanoprost / timolol") }, // Confidence: 70.6%, OMOP Match: 100.0%
            { "oxybuprocaine ophthalmic", new ValueWithNote(null, null) },
//             { "oxybuprocaine ophthalmic", new ValueWithNote("935529", "benoxinate") }, // Confidence: 70.3%, OMOP Match: 100.0%
            { "Soft paraffin + Wool fat", new ValueWithNote(null, null) },
//             { "Soft paraffin + Wool fat", new ValueWithNote("19033354", "petrolatum") }, // Confidence: 70.3%, OMOP Match: 100.0%
            { "Corticotrophin releasing hormone", new ValueWithNote(null, null) },
//             { "Corticotrophin releasing hormone", new ValueWithNote("19048699", "corticotropin-releasing hormone") }, // Confidence: 69.8%, OMOP Match: 100.0%
            { "Alginic acid/calcium carbonate/Na bic", new ValueWithNote(null, null) },
//             { "Alginic acid/calcium carbonate/Na bic", new ValueWithNote("36027575", "alginic acid / calcium carbonate") }, // Confidence: 69.6%, OMOP Match: 100.0%
            { "calcium acetate-magnesium carbonate", new ValueWithNote(null, null) },
//             { "calcium acetate-magnesium carbonate", new ValueWithNote("778779", "calcium acetate / magnesium carbonate") }, // Confidence: 69.4%, OMOP Match: 100.0%
            { "Aluminium acetate", new ValueWithNote(null, null) },
//             { "Aluminium acetate", new ValueWithNote("42898412", "aluminum") }, // Confidence: 69.2%, OMOP Match: 100.0%
            { "polihexanide ophthalmic", new ValueWithNote(null, null) },
//             { "polihexanide ophthalmic", new ValueWithNote("43525903", "polihexanide") }, // Confidence: 68.6%, OMOP Match: 100.0%
            { "mercaptAMine ophthalmic", new ValueWithNote(null, null) },
//             { "mercaptAMine ophthalmic", new ValueWithNote("910888", "cysteamine") }, // Confidence: 68.6%, OMOP Match: 100.0%
            { "Liquid paraffin + Isopropyl myristate", new ValueWithNote(null, null) },
//             { "Liquid paraffin + Isopropyl myristate", new ValueWithNote("19003568", "isopropyl myristate") }, // Confidence: 67.9%, OMOP Match: 100.0%
            { "Mg acetate/Mg carbonate/Mg hydroxide", new ValueWithNote(null, null) },
//             { "Mg acetate/Mg carbonate/Mg hydroxide", new ValueWithNote("43012385", "magnesium carbonate hydroxide") }, // Confidence: 67.7%, OMOP Match: 100.0%
            { "Continuous epidural infusion", new ValueWithNote(null, null) },
//             { "Continuous epidural infusion", new ValueWithNote("19100021", "Pranoxen Continus") }, // Confidence: 66.7%, OMOP Match: 100.0%
            { "dexamethasone-tobramycin ophthalmic", new ValueWithNote(null, null) },
//             { "dexamethasone-tobramycin ophthalmic", new ValueWithNote("40027456", "dexamethasone / tobramycin Ophthalmic Ointment") }, // Confidence: 66.7%, OMOP Match: 100.0%
            { "ispaghula-mebeverine", new ValueWithNote(null, null) },
//             { "ispaghula-mebeverine", new ValueWithNote("19008994", "mebeverine") }, // Confidence: 66.7%, OMOP Match: 100.0%
            { "White soft paraffin + Liquid paraffin", new ValueWithNote(null, null) },
//             { "White soft paraffin + Liquid paraffin", new ValueWithNote("19033354", "petrolatum") }, // Confidence: 66.7%, OMOP Match: 100.0%
            { "potassium acid tartrate-potassium bicarb", new ValueWithNote(null, null) },
//             { "potassium acid tartrate-potassium bicarb", new ValueWithNote("36027949", "potassium bicarbonate / potassium tartrate") }, // Confidence: 65.9%, OMOP Match: 100.0%
            { "Glucose 2.5% with 0.45% Sodium Chloride", new ValueWithNote(null, null) },
//             { "Glucose 2.5% with 0.45% Sodium Chloride", new ValueWithNote("40221365", "50 ML sodium chloride 4.5 MG/ML Injection") }, // Confidence: 65.7%, OMOP Match: 100.0%
            { "imipenem/cilastatin/relebactam", new ValueWithNote(null, null) },
//             { "imipenem/cilastatin/relebactam", new ValueWithNote("36030067", "cilastatin / imipenem / relebactam") }, // Confidence: 65.6%, OMOP Match: 100.0%
            { "haemophilus b-meningococcal conj vaccine", new ValueWithNote(null, null) },
//             { "haemophilus b-meningococcal conj vaccine", new ValueWithNote("530009", "0.5 ML Haemophilus influenzae b (Ross strain) capsular polysaccharide meningococcal protein conjugate vaccine 0.265 MG/ML Injection") }, // Confidence: 65.5%, OMOP Match: 100.0%
            { "Glucose 5% to", new ValueWithNote(null, null) },
//             { "Glucose 5% to", new ValueWithNote("19095012", "glucose 82.5 MG/ML") }, // Confidence: 64.5%, OMOP Match: 100.0%
            { "calamine-glycerol", new ValueWithNote(null, null) },
//             { "calamine-glycerol", new ValueWithNote("961145", "glycerin") }, // Confidence: 64.0%, OMOP Match: 100.0%
            { "fusidic acid ophthalmic", new ValueWithNote(null, null) },
//             { "fusidic acid ophthalmic", new ValueWithNote("36220424", "fusidate Ophthalmic Product") }, // Confidence: 64.0%, OMOP Match: 100.0%
            { "calamine-menthol", new ValueWithNote(null, null) },
//             { "calamine-menthol", new ValueWithNote("36029578", "calamine / menthol / zinc oxide") }, // Confidence: 63.8%, OMOP Match: 100.0%
            { "Continuous subcutaneous", new ValueWithNote(null, null) },
//             { "Continuous subcutaneous", new ValueWithNote("19053549", "MST Continus") }, // Confidence: 62.9%, OMOP Match: 100.0%
            { "Dronabinol + Cannabidiol", new ValueWithNote(null, null) },
//             { "Dronabinol + Cannabidiol", new ValueWithNote("1510417", "cannabidiol") }, // Confidence: 62.9%, OMOP Match: 100.0%
            { "hamamelis ophthalmic", new ValueWithNote(null, null) },
//             { "hamamelis ophthalmic", new ValueWithNote("959196", "witch hazel") }, // Confidence: 62.9%, OMOP Match: 100.0%
            { "SNG001 (Interferon -ß1a)", new ValueWithNote(null, null) },
//             { "SNG001 (Interferon -ß1a)", new ValueWithNote("40053881", "Interferons") }, // Confidence: 62.9%, OMOP Match: 100.0%
            { "adrenaline-lidocaine", new ValueWithNote(null, null) },
//             { "adrenaline-lidocaine", new ValueWithNote("44814295", "Adrenalin") }, // Confidence: 62.1%, OMOP Match: 100.0%
            { "alteplase ophthalmic", new ValueWithNote(null, null) },
//             { "alteplase ophthalmic", new ValueWithNote("1347450", "alteplase") }, // Confidence: 62.1%, OMOP Match: 100.0%
            { "fusidic acid-hydrocortisone", new ValueWithNote(null, null) },
//             { "fusidic acid-hydrocortisone", new ValueWithNote("36028432", "fusidate / hydrocortisone") }, // Confidence: 61.5%, OMOP Match: 100.0%
            { "dexamethasone/framycetin/gramicid ophth", new ValueWithNote(null, null) },
//             { "dexamethasone/framycetin/gramicid ophth", new ValueWithNote("36027970", "framycetin / gramicidin") }, // Confidence: 61.3%, OMOP Match: 100.0%
            { "Castor oil + Zinc oxide", new ValueWithNote(null, null) },
//             { "Castor oil + Zinc oxide", new ValueWithNote("950933", "castor oil") }, // Confidence: 60.6%, OMOP Match: 100.0%
            { "Meningococcal groups A + C + W135 + Y", new ValueWithNote(null, null) },
//             { "Meningococcal groups A + C + W135 + Y", new ValueWithNote("514015", "meningococcal polysaccharide vaccine group Y") }, // Confidence: 59.3%, OMOP Match: 100.0%
            { "Potassium Chloride 0.2% (27 mmol/L) in G", new ValueWithNote(null, null) },
//             { "Potassium Chloride 0.2% (27 mmol/L) in G", new ValueWithNote("19101198", "potassium 7.7 MMOL") }, // Confidence: 58.6%, OMOP Match: 100.0%
            { "Potassium Chloride 0.6% (80 mmol/L) in S", new ValueWithNote(null, null) },
//             { "Potassium Chloride 0.6% (80 mmol/L) in S", new ValueWithNote("19101211", "potassium 8.4 MMOL") }, // Confidence: 58.6%, OMOP Match: 100.0%
            { "adrenaline-BUPivacaine", new ValueWithNote(null, null) },
//             { "adrenaline-BUPivacaine", new ValueWithNote("44814295", "Adrenalin") }, // Confidence: 58.1%, OMOP Match: 100.0%
            { "frangula-sterculia", new ValueWithNote(null, null) },
//             { "frangula-sterculia", new ValueWithNote("19016537", "Frangula preparation") }, // Confidence: 57.9%, OMOP Match: 100.0%
            { "Continuous subcutaneous infusion", new ValueWithNote(null, null) },
//             { "Continuous subcutaneous infusion", new ValueWithNote("19100536", "Nitrocontin Continus") }, // Confidence: 57.7%, OMOP Match: 100.0%
            { "mercaptAMine (Cysteamine)", new ValueWithNote(null, null) },
//             { "mercaptAMine (Cysteamine)", new ValueWithNote("910888", "cysteamine") }, // Confidence: 57.1%, OMOP Match: 100.0%
            { "Potassium Chloride 0.15% (20 mmol/L) in", new ValueWithNote(null, null) },
//             { "Potassium Chloride 0.15% (20 mmol/L) in", new ValueWithNote("19101200", "potassium 10 MMOL") }, // Confidence: 57.1%, OMOP Match: 100.0%
            { "Clobetasol/oxytetracycline/nystatin topi", new ValueWithNote(null, null) },
//             { "Clobetasol/oxytetracycline/nystatin topi", new ValueWithNote("36227369", "nystatin / oxytetracycline Pill") }, // Confidence: 56.3%, OMOP Match: 100.0%
            { "BUPivacaine + cloNIDine", new ValueWithNote(null, null) },
//             { "BUPivacaine + cloNIDine", new ValueWithNote("1398937", "clonidine") }, // Confidence: 56.2%, OMOP Match: 100.0%
            { "Potassium Chloride 0.3% (40 mmol/L) in S", new ValueWithNote(null, null) },
//             { "Potassium Chloride 0.3% (40 mmol/L) in S", new ValueWithNote("19101200", "potassium 10 MMOL") }, // Confidence: 56.1%, OMOP Match: 100.0%
            { "Potassium Chloride 0.3% (40 mmol/L) in G", new ValueWithNote(null, null) },
//             { "Potassium Chloride 0.3% (40 mmol/L) in G", new ValueWithNote("19101200", "potassium 10 MMOL") }, // Confidence: 56.1%, OMOP Match: 100.0%
            { "Estriol applicator", new ValueWithNote(null, null) },
//             { "Estriol applicator", new ValueWithNote("19049038", "estriol") }, // Confidence: 56.0%, OMOP Match: 100.0%
            { "Estradiol-dydrogesterone", new ValueWithNote(null, null) },
//             { "Estradiol-dydrogesterone", new ValueWithNote("36030766", "dydrogesterone / estradiol") }, // Confidence: 56.0%, OMOP Match: 100.0%
            { "Emulsifying ointment + Phenoxyethanol", new ValueWithNote(null, null) },
//             { "Emulsifying ointment + Phenoxyethanol", new ValueWithNote("19058343", "phenoxyethanol") }, // Confidence: 54.9%, OMOP Match: 100.0%
            { "Insulin isophane porcine", new ValueWithNote(null, null) },
//             { "Insulin isophane porcine", new ValueWithNote("40052072", "insulin isophane Injectable Suspension [Hypurin Porcine Isophane]") }, // Confidence: 53.9%, OMOP Match: 100.0%
            { "Retinol + Vitamin D", new ValueWithNote(null, null) },
//             { "Retinol + Vitamin D", new ValueWithNote("19008339", "vitamin A") }, // Confidence: 53.8%, OMOP Match: 100.0%
            { "chlorhexidine-nystatin", new ValueWithNote(null, null) },
//             { "chlorhexidine-nystatin", new ValueWithNote("922570", "nystatin") }, // Confidence: 53.3%, OMOP Match: 100.0%
            { "Paed 3k 1L (aqueous)", new ValueWithNote(null, null) },
//             { "Paed 3k 1L (aqueous)", new ValueWithNote("43526318", "potassium triiodide") }, // Confidence: 52.9%, OMOP Match: 100.0%
            { "Al hydroxide/dicycloverine/MgO/simet", new ValueWithNote(null, null) },
//             { "Al hydroxide/dicycloverine/MgO/simet", new ValueWithNote("36029063", "magnesium hydroxide / simethicone") }, // Confidence: 52.2%, OMOP Match: 100.0%
            { "sodium bicarbonate-sodium biphosphate", new ValueWithNote(null, null) },
//             { "sodium bicarbonate-sodium biphosphate", new ValueWithNote("36029231", "potassium bicarbonate / sodium bicarbonate / sodium citrate") }, // Confidence: 52.1%, OMOP Match: 100.0%
            { "Neonatal Main (aqueous)", new ValueWithNote(null, null) },
//             { "Neonatal Main (aqueous)", new ValueWithNote("19053623", "Opticrom Aqueous") }, // Confidence: 51.3%, OMOP Match: 100.0%
            { "ubidecarenone (ubiquinone)", new ValueWithNote(null, null) },
//             { "ubidecarenone (ubiquinone)", new ValueWithNote("43526994", "ubiquinone Q2") }, // Confidence: 51.3%, OMOP Match: 100.0%
            { "benzalkonium/dimeticone/HC/nystatin top", new ValueWithNote(null, null) },
//             { "benzalkonium/dimeticone/HC/nystatin top", new ValueWithNote("40167927", "benzalkonium Topical Gel [Sentry HC HOTspot]") }, // Confidence: 50.6%, OMOP Match: 100.0%
            { "Neat", new ValueWithNote(null, null) },
//             { "Neat", new ValueWithNote("42904273", "neatsfoot oil") }, // Confidence: 47.1%, OMOP Match: 100.0%
            { "cetylpyridium/chlorocresol/lidocaine top", new ValueWithNote(null, null) },
//             { "cetylpyridium/chlorocresol/lidocaine top", new ValueWithNote("19037891", "chlorocresol") }, // Confidence: 46.2%, OMOP Match: 100.0%
            { "PCA", new ValueWithNote(null, null) },
//             { "PCA", new ValueWithNote("43531981", "lauryl PCA") }, // Confidence: 46.2%, OMOP Match: 100.0%
            { "imipenem-cilastatin", new ValueWithNote(null, null) },
//             { "imipenem-cilastatin", new ValueWithNote("36030067", "cilastatin / imipenem / relebactam") }, // Confidence: 44.4%, OMOP Match: 100.0%
            { "Drug chart reminder", new ValueWithNote(null, null) },
//             { "Drug chart reminder", new ValueWithNote("40175669", "Stachybotrys chartarum allergenic extract") }, // Confidence: 43.9%, OMOP Match: 100.0%
            { "guselkumab-golimumab-JNJ78934804", new ValueWithNote(null, null) },
//             { "guselkumab-golimumab-JNJ78934804", new ValueWithNote("19041065", "golimumab") }, // Confidence: 43.9%, OMOP Match: 100.0%
            { "amifampridine (3,4 DAP)", new ValueWithNote(null, null) },
//             { "amifampridine (3,4 DAP)", new ValueWithNote("1355889", "amifampridine") }, // Confidence: 40.0%, OMOP Match: 100.0%
            { "Additional chemotherapy and/or chemother", new ValueWithNote(null, null) },
//             { "Additional chemotherapy and/or chemother", new ValueWithNote("36232901", "Baza Cleanse and Protect Medicated Pad or Tape") }, // Confidence: 39.5%, OMOP Match: 100.0%
            { "BCG", new ValueWithNote(null, null) },
//             { "BCG", new ValueWithNote("36248976", "Tice BCG Topical Product") }, // Confidence: 22.2%, OMOP Match: 100.0%
            { "Taurolock", new ValueWithNote("2901073", "Taurolock") },
//             { "Taurolock", new ValueWithNote("2901073", "Taurolock") }, // Confidence: 0.0%, OMOP Match: 100.0%
            { "hepatitis A vaccine", new ValueWithNote("40047409", "Hepatitis A Vaccines") },
//             { "hepatitis A vaccine", new ValueWithNote("40047409", "Hepatitis A Vaccines") }, // Confidence: 100.0%, OMOP Match: 97.4%
            { "calcium-vitamin D", new ValueWithNote("43126501", "CALCIUM/VITAMINE D") },
//             { "calcium-vitamin D", new ValueWithNote("43126501", "CALCIUM/VITAMINE D") }, // Confidence: 94.1%, OMOP Match: 97.1%
            { "dibotermin alfa", new ValueWithNote("43126075", "Alfa dibotermin") },
//             { "dibotermin alfa", new ValueWithNote("43126075", "Alfa dibotermin") }, // Confidence: 100.0%, OMOP Match: 93.3%
            { "co-trimoxazole", new ValueWithNote("21018085", "Co-trimoxazole") },
//             { "co-trimoxazole", new ValueWithNote("21018085", "Co-trimoxazole") }, // Confidence: 0.0%, OMOP Match: 92.9%
            { "co-danthrusate", new ValueWithNote("21015003", "Co-danthrusate") },
//             { "co-danthrusate", new ValueWithNote("21015003", "Co-danthrusate") }, // Confidence: 0.0%, OMOP Match: 92.9%
            { "co-amilofruse", new ValueWithNote("21014899", "Co-amilofruse") },
//             { "co-amilofruse", new ValueWithNote("21014899", "Co-amilofruse") }, // Confidence: 0.0%, OMOP Match: 92.3%
            { "co-danthramer", new ValueWithNote("21014474", "Co-danthramer") },
//             { "co-danthramer", new ValueWithNote("21014474", "Co-danthramer") }, // Confidence: 0.0%, OMOP Match: 92.3%
            { "co-cyprindiol", new ValueWithNote("21014586", "Co-cyprindiol") },
//             { "co-cyprindiol", new ValueWithNote("21014586", "Co-cyprindiol") }, // Confidence: 0.0%, OMOP Match: 92.3%
            { "Grass pollen", new ValueWithNote("36879220", "Grass pollen") },
//             { "Grass pollen", new ValueWithNote("36879220", "Grass pollen") }, // Confidence: 100.0%, OMOP Match: 91.7%
            { "co-magaldrox", new ValueWithNote("21018430", "Co-magaldrox") },
//             { "co-magaldrox", new ValueWithNote("21018430", "Co-magaldrox") }, // Confidence: 0.0%, OMOP Match: 91.7%
            { "co-amilozide", new ValueWithNote("21018645", "Co-amilozide") },
//             { "co-amilozide", new ValueWithNote("21018645", "Co-amilozide") }, // Confidence: 0.0%, OMOP Match: 91.7%
            { "co-careldopa", new ValueWithNote("21017760", "Co-careldopa") },
//             { "co-careldopa", new ValueWithNote("21017760", "Co-careldopa") }, // Confidence: 0.0%, OMOP Match: 91.7%
            { "co-amoxiclav", new ValueWithNote("21015284", "Co-amoxiclav") },
//             { "co-amoxiclav", new ValueWithNote("21015284", "Co-amoxiclav") }, // Confidence: 0.0%, OMOP Match: 91.7%
            { "co-beneldopa", new ValueWithNote("21014753", "Co-beneldopa") },
//             { "co-beneldopa", new ValueWithNote("21014753", "Co-beneldopa") }, // Confidence: 0.0%, OMOP Match: 91.7%
            { "rotavirus vaccine", new ValueWithNote("19018193", "Rotavirus Vaccines") },
//             { "rotavirus vaccine", new ValueWithNote("19018193", "Rotavirus Vaccines") }, // Confidence: 100.0%, OMOP Match: 91.4%
            { "agomelatine", new ValueWithNote("21014017", "Agomelatine") },
//             { "agomelatine", new ValueWithNote("21014017", "Agomelatine") }, // Confidence: 100.0%, OMOP Match: 90.9%
            { "co-dydramol", new ValueWithNote("21016567", "Co-dydramol") },
//             { "co-dydramol", new ValueWithNote("21016567", "Co-dydramol") }, // Confidence: 0.0%, OMOP Match: 90.9%
            { "co-tenidone", new ValueWithNote("21015431", "Co-tenidone") },
//             { "co-tenidone", new ValueWithNote("21015431", "Co-tenidone") }, // Confidence: 0.0%, OMOP Match: 90.9%
            { "rupatadine", new ValueWithNote("21014003", "Rupatadine") },
//             { "rupatadine", new ValueWithNote("21014003", "Rupatadine") }, // Confidence: 100.0%, OMOP Match: 90.0%
            { "zonisamide", new ValueWithNote("744798", "zonisamide") },
//             { "zonisamide", new ValueWithNote("744798", "zonisamide") }, // Confidence: 100.0%, OMOP Match: 90.0%
            { "co-codamol", new ValueWithNote(null, null) },
//             { "co-codamol", new ValueWithNote("21018553", "Co-codamol") }, // Confidence: 0.0%, OMOP Match: 90.0%
            { "asundexian", new ValueWithNote(null, null) },
//             { "asundexian", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "bilastine", new ValueWithNote(null, null) },
//             { "bilastine", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "bictegravir/emtricitabine/tenofovir", new ValueWithNote(null, null) },
//             { "bictegravir/emtricitabine/tenofovir", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "ARGX-119", new ValueWithNote(null, null) },
//             { "ARGX-119", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "COVID-19 vaccine", new ValueWithNote(null, null) },
//             { "COVID-19 vaccine", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "efavirenz/emtricitabine/tenofovir", new ValueWithNote(null, null) },
//             { "efavirenz/emtricitabine/tenofovir", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "emtricitabine/rilpivirine/tenofovir", new ValueWithNote(null, null) },
//             { "emtricitabine/rilpivirine/tenofovir", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "doravirine/lamiVUDine/tenofovir", new ValueWithNote(null, null) },
//             { "doravirine/lamiVUDine/tenofovir", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Gelclair", new ValueWithNote(null, null) },
//             { "Gelclair", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Enteral nutrition", new ValueWithNote(null, null) },
//             { "Enteral nutrition", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "GTX-102", new ValueWithNote(null, null) },
//             { "GTX-102", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "insulin soluble", new ValueWithNote(null, null) },
//             { "insulin soluble", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "ION582", new ValueWithNote(null, null) },
//             { "ION582", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Namilumab", new ValueWithNote(null, null) },
//             { "Namilumab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Ianalumab", new ValueWithNote(null, null) },
//             { "Ianalumab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "pneumococcal 13-valent conjugate vaccine", new ValueWithNote(null, null) },
//             { "pneumococcal 13-valent conjugate vaccine", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "infant formulas", new ValueWithNote(null, null) },
//             { "infant formulas", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "obexelimab", new ValueWithNote(null, null) },
//             { "obexelimab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "smallpox vaccine", new ValueWithNote(null, null) },
//             { "smallpox vaccine", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "lutikizumab", new ValueWithNote(null, null) },
//             { "lutikizumab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "probiotic", new ValueWithNote(null, null) },
//             { "probiotic", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Turoctocog alfa pegol", new ValueWithNote(null, null) },
//             { "Turoctocog alfa pegol", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "silicified microcrystalline cellulose", new ValueWithNote(null, null) },
//             { "silicified microcrystalline cellulose", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "trace elements", new ValueWithNote(null, null) },
//             { "trace elements", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Rurioctocog alfa pegol", new ValueWithNote(null, null) },
//             { "Rurioctocog alfa pegol", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Volixibat", new ValueWithNote(null, null) },
//             { "Volixibat", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "XTMAB-16", new ValueWithNote(null, null) },
//             { "XTMAB-16", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "WVE-N531", new ValueWithNote(null, null) },
//             { "WVE-N531", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Yellow soft paraffin", new ValueWithNote(null, null) },
//             { "Yellow soft paraffin", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "apitegromab", new ValueWithNote(null, null) },
//             { "apitegromab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "fluoride", new ValueWithNote(null, null) },
//             { "fluoride", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Pamrevlumab", new ValueWithNote(null, null) },
//             { "Pamrevlumab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "Prasinezumab", new ValueWithNote(null, null) },
//             { "Prasinezumab", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "prothrombin complex", new ValueWithNote(null, null) },
//             { "prothrombin complex", new ValueWithNote(null, null) }, // Confidence: 100.0%, OMOP Match: 0.0%
            { "potassium bicarbonate-potassium chloride", new ValueWithNote(null, null) },
//             { "potassium bicarbonate-potassium chloride", new ValueWithNote(null, null) }, // Confidence: 97.5%, OMOP Match: 0.0%
            { "potassium phosphate-sodium phosphate", new ValueWithNote(null, null) },
//             { "potassium phosphate-sodium phosphate", new ValueWithNote(null, null) }, // Confidence: 97.2%, OMOP Match: 0.0%
            { "meningococcal conjugate vaccine", new ValueWithNote(null, null) },
//             { "meningococcal conjugate vaccine", new ValueWithNote(null, null) }, // Confidence: 96.9%, OMOP Match: 0.0%
            { "benzoic acid-salicylic acid", new ValueWithNote(null, null) },
//             { "benzoic acid-salicylic acid", new ValueWithNote(null, null) }, // Confidence: 96.3%, OMOP Match: 0.0%
            { "lactic acid-salicylic acid", new ValueWithNote(null, null) },
//             { "lactic acid-salicylic acid", new ValueWithNote(null, null) }, // Confidence: 96.2%, OMOP Match: 0.0%
            { "emtricitabine-tenofovir", new ValueWithNote(null, null) },
//             { "emtricitabine-tenofovir", new ValueWithNote(null, null) }, // Confidence: 95.7%, OMOP Match: 0.0%
            { "nirmatrelvir-ritonavir", new ValueWithNote(null, null) },
//             { "nirmatrelvir-ritonavir", new ValueWithNote(null, null) }, // Confidence: 95.5%, OMOP Match: 0.0%
            { "BUPivacaine-fentaNYL", new ValueWithNote(null, null) },
//             { "BUPivacaine-fentaNYL", new ValueWithNote(null, null) }, // Confidence: 95.0%, OMOP Match: 0.0%
            { "lactic acid-urea", new ValueWithNote(null, null) },
//             { "lactic acid-urea", new ValueWithNote(null, null) }, // Confidence: 93.8%, OMOP Match: 0.0%
            { "sodium hyaluronate ophthalmic", new ValueWithNote(null, null) },
//             { "sodium hyaluronate ophthalmic", new ValueWithNote(null, null) }, // Confidence: 93.5%, OMOP Match: 0.0%
            { "Water for injection to", new ValueWithNote(null, null) },
//             { "Water for injection to", new ValueWithNote(null, null) }, // Confidence: 92.7%, OMOP Match: 0.0%
            { "Hydrocortisone + Urea", new ValueWithNote(null, null) },
//             { "Hydrocortisone + Urea", new ValueWithNote(null, null) }, // Confidence: 90.0%, OMOP Match: 0.0%
            { "beclometasone-formoterol", new ValueWithNote(null, null) },
//             { "beclometasone-formoterol", new ValueWithNote(null, null) }, // Confidence: 88.5%, OMOP Match: 0.0%
            { "ARGX-117", new ValueWithNote(null, null) },
//             { "ARGX-117", new ValueWithNote(null, null) }, // Confidence: 87.5%, OMOP Match: 0.0%
            { "fluticasone-formoterol", new ValueWithNote(null, null) },
//             { "fluticasone-formoterol", new ValueWithNote(null, null) }, // Confidence: 87.5%, OMOP Match: 0.0%
            { "metFORMIN-vildagliptin", new ValueWithNote(null, null) },
//             { "metFORMIN-vildagliptin", new ValueWithNote(null, null) }, // Confidence: 87.5%, OMOP Match: 0.0%
            { "hepatitis B adult vaccine", new ValueWithNote(null, null) },
//             { "hepatitis B adult vaccine", new ValueWithNote(null, null) }, // Confidence: 86.2%, OMOP Match: 0.0%
            { "human papillomavirus vaccine", new ValueWithNote(null, null) },
//             { "human papillomavirus vaccine", new ValueWithNote(null, null) }, // Confidence: 86.2%, OMOP Match: 0.0%
            { "measles/mumps/rubella vaccine", new ValueWithNote(null, null) },
//             { "measles/mumps/rubella vaccine", new ValueWithNote(null, null) }, // Confidence: 85.7%, OMOP Match: 0.0%
            { "gramicid/neomy/nystatin/triamcin otic", new ValueWithNote(null, null) },
//             { "gramicid/neomy/nystatin/triamcin otic", new ValueWithNote(null, null) }, // Confidence: 83.5%, OMOP Match: 0.0%
            { "diphtheria/poliomyelitis/tetanus vaccine", new ValueWithNote(null, null) },
//             { "diphtheria/poliomyelitis/tetanus vaccine", new ValueWithNote(null, null) }, // Confidence: 83.3%, OMOP Match: 0.0%
            { "Bacillus Calmette-Guérin", new ValueWithNote(null, null) },
//             { "Bacillus Calmette-Guérin", new ValueWithNote(null, null) }, // Confidence: 82.1%, OMOP Match: 0.0%
            { "sodium chloride, hypertonic, ophthalmic", new ValueWithNote(null, null) },
//             { "sodium chloride, hypertonic, ophthalmic", new ValueWithNote(null, null) }, // Confidence: 81.8%, OMOP Match: 0.0%
            { "hepatitis A-hepatitis B vaccine", new ValueWithNote(null, null) },
//             { "hepatitis A-hepatitis B vaccine", new ValueWithNote(null, null) }, // Confidence: 81.5%, OMOP Match: 0.0%
            { "sodium bicarbonate-sodium chloride top", new ValueWithNote(null, null) },
//             { "sodium bicarbonate-sodium chloride top", new ValueWithNote(null, null) }, // Confidence: 81.5%, OMOP Match: 0.0%
            { "beclometasone/formoterol/glycopyrronium", new ValueWithNote(null, null) },
//             { "beclometasone/formoterol/glycopyrronium", new ValueWithNote(null, null) }, // Confidence: 81.3%, OMOP Match: 0.0%
            { "conjugated estrogens-medroxyPROGESTERone", new ValueWithNote(null, null) },
//             { "conjugated estrogens-medroxyPROGESTERone", new ValueWithNote(null, null) }, // Confidence: 81.2%, OMOP Match: 0.0%
            { "other supplements", new ValueWithNote(null, null) },
//             { "other supplements", new ValueWithNote(null, null) }, // Confidence: 81.0%, OMOP Match: 0.0%
            { "calamine/coal tar/zinc oxide", new ValueWithNote(null, null) },
//             { "calamine/coal tar/zinc oxide", new ValueWithNote(null, null) }, // Confidence: 80.9%, OMOP Match: 0.0%
            { "Estradiol + norETHISTerone acetate", new ValueWithNote(null, null) },
//             { "Estradiol + norETHISTerone acetate", new ValueWithNote(null, null) }, // Confidence: 77.8%, OMOP Match: 0.0%
            { "diphth/Hib/pertussis/polio/tetanus vacc", new ValueWithNote(null, null) },
//             { "diphth/Hib/pertussis/polio/tetanus vacc", new ValueWithNote(null, null) }, // Confidence: 77.6%, OMOP Match: 0.0%
            { "Darunavir + Cobicistat + Emtricitabine +", new ValueWithNote(null, null) },
//             { "Darunavir + Cobicistat + Emtricitabine +", new ValueWithNote(null, null) }, // Confidence: 76.2%, OMOP Match: 0.0%
            { "taldefgrobep alfa (BHV-2000)", new ValueWithNote(null, null) },
//             { "taldefgrobep alfa (BHV-2000)", new ValueWithNote(null, null) }, // Confidence: 75.6%, OMOP Match: 0.0%
            { "JNJ-67484703", new ValueWithNote(null, null) },
//             { "JNJ-67484703", new ValueWithNote(null, null) }, // Confidence: 75.0%, OMOP Match: 0.0%
            { "oral rehydration salts", new ValueWithNote(null, null) },
//             { "oral rehydration salts", new ValueWithNote(null, null) }, // Confidence: 75.0%, OMOP Match: 0.0%
            { "calcium carbonate-Ca lactate gluconate", new ValueWithNote(null, null) },
//             { "calcium carbonate-Ca lactate gluconate", new ValueWithNote(null, null) }, // Confidence: 74.0%, OMOP Match: 0.0%
            { "pneumococcal 23-polyvalent vaccine", new ValueWithNote(null, null) },
//             { "pneumococcal 23-polyvalent vaccine", new ValueWithNote(null, null) }, // Confidence: 73.1%, OMOP Match: 0.0%
            { "COVID-19 mRNA vaccine (Pfizer / BioNT", new ValueWithNote(null, null) },
//             { "COVID-19 mRNA vaccine (Pfizer / BioNT", new ValueWithNote(null, null) }, // Confidence: 72.4%, OMOP Match: 0.0%
            { "Nirmatrelvir (PF-07321332) + Ritonavir", new ValueWithNote(null, null) },
//             { "Nirmatrelvir (PF-07321332) + Ritonavir", new ValueWithNote(null, null) }, // Confidence: 71.9%, OMOP Match: 0.0%
            { "sodium cromoglicate ophthalmic", new ValueWithNote(null, null) },
//             { "sodium cromoglicate ophthalmic", new ValueWithNote(null, null) }, // Confidence: 71.9%, OMOP Match: 0.0%
            { "sodium cromoglicate", new ValueWithNote(null, null) },
//             { "sodium cromoglicate", new ValueWithNote(null, null) }, // Confidence: 71.7%, OMOP Match: 0.0%
            { "alginate/calcium CO3/sodium bicarbonate", new ValueWithNote(null, null) },
//             { "alginate/calcium CO3/sodium bicarbonate", new ValueWithNote(null, null) }, // Confidence: 71.0%, OMOP Match: 0.0%
            { "Adult ST8 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST8 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST4 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST4 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST3 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST3 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST6 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST6 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST5 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST5 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST7 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST7 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST9 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST9 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "Adult ST2 parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST2 parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 70.6%, OMOP Match: 0.0%
            { "PLX-PAD cells", new ValueWithNote(null, null) },
//             { "PLX-PAD cells", new ValueWithNote(null, null) }, // Confidence: 70.0%, OMOP Match: 0.0%
            { "Adult ST7E parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST7E parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 69.6%, OMOP Match: 0.0%
            { "Adult ST1B parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST1B parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 69.6%, OMOP Match: 0.0%
            { "Adult ST1A parenteral nutrition bag", new ValueWithNote(null, null) },
//             { "Adult ST1A parenteral nutrition bag", new ValueWithNote(null, null) }, // Confidence: 69.6%, OMOP Match: 0.0%
            { "shingles (herpes zoster) vaccine, live", new ValueWithNote(null, null) },
//             { "shingles (herpes zoster) vaccine, live", new ValueWithNote(null, null) }, // Confidence: 69.0%, OMOP Match: 0.0%
            { "wound care supplies", new ValueWithNote(null, null) },
//             { "wound care supplies", new ValueWithNote(null, null) }, // Confidence: 69.0%, OMOP Match: 0.0%
            { "Platelets", new ValueWithNote(null, null) },
//             { "Platelets", new ValueWithNote(null, null) }, // Confidence: 66.7%, OMOP Match: 0.0%
            { "Parenteral Nutrition (Adults)", new ValueWithNote(null, null) },
//             { "Parenteral Nutrition (Adults)", new ValueWithNote(null, null) }, // Confidence: 66.7%, OMOP Match: 0.0%
            { "Emulsifying wax + Yellow soft paraffi", new ValueWithNote(null, null) },
//             { "Emulsifying wax + Yellow soft paraffi", new ValueWithNote(null, null) }, // Confidence: 66.7%, OMOP Match: 0.0%
            { "Parenteral Nutrition (Paediatric)", new ValueWithNote(null, null) },
//             { "Parenteral Nutrition (Paediatric)", new ValueWithNote(null, null) }, // Confidence: 65.7%, OMOP Match: 0.0%
            { "diphtheria/pertussis/tetanus vaccine", new ValueWithNote(null, null) },
//             { "diphtheria/pertussis/tetanus vaccine", new ValueWithNote(null, null) }, // Confidence: 65.1%, OMOP Match: 0.0%
            { "fat emulsion, intravenous", new ValueWithNote(null, null) },
//             { "fat emulsion, intravenous", new ValueWithNote(null, null) }, // Confidence: 64.9%, OMOP Match: 0.0%
            { "Hyoscine (base)", new ValueWithNote(null, null) },
//             { "Hyoscine (base)", new ValueWithNote(null, null) }, // Confidence: 64.3%, OMOP Match: 0.0%
            { "REGN10933 + REGN10987", new ValueWithNote(null, null) },
//             { "REGN10933 + REGN10987", new ValueWithNote(null, null) }, // Confidence: 63.3%, OMOP Match: 0.0%
            { "Sodium acid phosphate + Potassium dih", new ValueWithNote(null, null) },
//             { "Sodium acid phosphate + Potassium dih", new ValueWithNote(null, null) }, // Confidence: 60.3%, OMOP Match: 0.0%
            { "incontinence supplies", new ValueWithNote(null, null) },
//             { "incontinence supplies", new ValueWithNote(null, null) }, // Confidence: 60.0%, OMOP Match: 0.0%
            { "benzyl benzoate/lanolin/zinc oxide top", new ValueWithNote(null, null) },
//             { "benzyl benzoate/lanolin/zinc oxide top", new ValueWithNote(null, null) }, // Confidence: 59.1%, OMOP Match: 0.0%
            { "IMC-I109V", new ValueWithNote(null, null) },
//             { "IMC-I109V", new ValueWithNote(null, null) }, // Confidence: 58.8%, OMOP Match: 0.0%
            { "Emulsifying wax + Liquid paraffin + W", new ValueWithNote(null, null) },
//             { "Emulsifying wax + Liquid paraffin + W", new ValueWithNote(null, null) }, // Confidence: 57.7%, OMOP Match: 0.0%
            { "Dextran 40 with Sodium chloride 0.9% (Rh", new ValueWithNote(null, null) },
//             { "Dextran 40 with Sodium chloride 0.9% (Rh", new ValueWithNote(null, null) }, // Confidence: 57.6%, OMOP Match: 0.0%
            { "balsam/benzyl benz/bismuth/HC/ZnO top", new ValueWithNote(null, null) },
//             { "balsam/benzyl benz/bismuth/HC/ZnO top", new ValueWithNote(null, null) }, // Confidence: 57.5%, OMOP Match: 0.0%
            { "Diphtheria + Tetanus + Pertussis + Hepat", new ValueWithNote(null, null) },
//             { "Diphtheria + Tetanus + Pertussis + Hepat", new ValueWithNote(null, null) }, // Confidence: 57.4%, OMOP Match: 0.0%
            { "dexpanthenol-sodium hyaluronate ophth", new ValueWithNote(null, null) },
//             { "dexpanthenol-sodium hyaluronate ophth", new ValueWithNote(null, null) }, // Confidence: 57.1%, OMOP Match: 0.0%
            { "Ready diluted", new ValueWithNote(null, null) },
//             { "Ready diluted", new ValueWithNote(null, null) }, // Confidence: 57.1%, OMOP Match: 0.0%
            { "Red cells", new ValueWithNote(null, null) },
//             { "Red cells", new ValueWithNote(null, null) }, // Confidence: 55.2%, OMOP Match: 0.0%
            { "SRP", new ValueWithNote(null, null) },
//             { "SRP", new ValueWithNote(null, null) }, // Confidence: 54.5%, OMOP Match: 0.0%
            { "clobetasol/neomycin/nystatin", new ValueWithNote(null, null) },
//             { "clobetasol/neomycin/nystatin", new ValueWithNote(null, null) }, // Confidence: 54.3%, OMOP Match: 0.0%
            { "dipht/tet/pertussis/hep B/polio/haemoph", new ValueWithNote(null, null) },
//             { "dipht/tet/pertussis/hep B/polio/haemoph", new ValueWithNote(null, null) }, // Confidence: 52.7%, OMOP Match: 0.0%
            { "macrogol 3350 with electrolytes", new ValueWithNote(null, null) },
//             { "macrogol 3350 with electrolytes", new ValueWithNote(null, null) }, // Confidence: 50.0%, OMOP Match: 0.0%
            { "medical supplies", new ValueWithNote(null, null) },
//             { "medical supplies", new ValueWithNote(null, null) }, // Confidence: 45.5%, OMOP Match: 0.0%
            { "SMOF 60 (60mL)", new ValueWithNote(null, null) },
//             { "SMOF 60 (60mL)", new ValueWithNote(null, null) }, // Confidence: 43.5%, OMOP Match: 0.0%
            { "Intermittent pneumatic compression (IPC)", new ValueWithNote(null, null) },
//             { "Intermittent pneumatic compression (IPC)", new ValueWithNote(null, null) }, // Confidence: 37.3%, OMOP Match: 0.0%
            { "Freetext Medication", new ValueWithNote(null, null) },
//             { "Freetext Medication", new ValueWithNote(null, null) }, // Confidence: 36.7%, OMOP Match: 0.0%
            { "Sodium lactate compound (Hartmann's) inf", new ValueWithNote(null, null) },
//             { "Sodium lactate compound (Hartmann's) inf", new ValueWithNote(null, null) }, // Confidence: 31.6%, OMOP Match: 0.0%
            { "Hartmanns solution", new ValueWithNote(null, null) },
//             { "Hartmanns solution", new ValueWithNote(null, null) }, // Confidence: 17.3%, OMOP Match: 0.0%
            { "GSK3511294", new ValueWithNote(null, null) },
//             { "GSK3511294", new ValueWithNote(null, null) }, // Confidence: 10.5%, OMOP Match: 0.0%
            { "NCA", new ValueWithNote(null, null) },
//             { "NCA", new ValueWithNote(null, null) }, // Confidence: 3.5%, OMOP Match: 0.0%
            { "Amino Acids (L-lysine 2.5% and L-arginin", new ValueWithNote(null, null) },
//             { "Amino Acids (L-lysine 2.5% and L-arginin", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "blood glucose monitoring supplies", new ValueWithNote(null, null) },
//             { "blood glucose monitoring supplies", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "benzylpenicillin sodium", new ValueWithNote(null, null) },
//             { "benzylpenicillin sodium", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Blood Level Monitoring (Neonatal Unit)", new ValueWithNote(null, null) },
//             { "Blood Level Monitoring (Neonatal Unit)", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "BE1116", new ValueWithNote(null, null) },
//             { "BE1116", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "betamethasone-calcipotriol", new ValueWithNote(null, null) },
//             { "betamethasone-calcipotriol", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Buffered Sodium Chloride 0.9% Sterile IV", new ValueWithNote(null, null) },
//             { "Buffered Sodium Chloride 0.9% Sterile IV", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Carnoys solution", new ValueWithNote(null, null) },
//             { "Carnoys solution", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "coagulation factor Xa", new ValueWithNote(null, null) },
//             { "coagulation factor Xa", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Copper intrauterine contraceptive device", new ValueWithNote(null, null) },
//             { "Copper intrauterine contraceptive device", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "cinchocaine-prednisoLONE", new ValueWithNote(null, null) },
//             { "cinchocaine-prednisoLONE", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "cinchocaine-hydrocortisone", new ValueWithNote(null, null) },
//             { "cinchocaine-hydrocortisone", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "diphth/pertussis,acel/polio/tetanus vacc", new ValueWithNote(null, null) },
//             { "diphth/pertussis,acel/polio/tetanus vacc", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Cryoprecipitate", new ValueWithNote(null, null) },
//             { "Cryoprecipitate", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "emollients,", new ValueWithNote(null, null) },
//             { "emollients,", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Donor Lymphocytes - CD3", new ValueWithNote(null, null) },
//             { "Donor Lymphocytes - CD3", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Fresh frozen plasma", new ValueWithNote(null, null) },
//             { "Fresh frozen plasma", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "epoetin beta-methoxy polyethylene glycol", new ValueWithNote(null, null) },
//             { "epoetin beta-methoxy polyethylene glycol", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "heparin flush", new ValueWithNote(null, null) },
//             { "heparin flush", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "ergometrine-oxytocin", new ValueWithNote(null, null) },
//             { "ergometrine-oxytocin", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "fluorescein ophthalmic", new ValueWithNote(null, null) },
//             { "fluorescein ophthalmic", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Glucose 20% infusion (continuous)", new ValueWithNote(null, null) },
//             { "Glucose 20% infusion (continuous)", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Glucose 10% infusion", new ValueWithNote(null, null) },
//             { "Glucose 10% infusion", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Glucose 5% intravenous infusion solution", new ValueWithNote(null, null) },
//             { "Glucose 5% intravenous infusion solution", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "IDDS", new ValueWithNote(null, null) },
//             { "IDDS", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "loteprednol ophthalmic", new ValueWithNote(null, null) },
//             { "loteprednol ophthalmic", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Granulocytes", new ValueWithNote(null, null) },
//             { "Granulocytes", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "magnesium glycerophosphate", new ValueWithNote(null, null) },
//             { "magnesium glycerophosphate", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "magnesium carbonate-magnesium sulfate", new ValueWithNote(null, null) },
//             { "magnesium carbonate-magnesium sulfate", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Glucose 50% intravenous infusion solutio", new ValueWithNote(null, null) },
//             { "Glucose 50% intravenous infusion solutio", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "nitrous oxide-oxygen", new ValueWithNote(null, null) },
//             { "nitrous oxide-oxygen", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "ocular lubricant", new ValueWithNote(null, null) },
//             { "ocular lubricant", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Glucose 12.5% intravenous infusion solut", new ValueWithNote(null, null) },
//             { "Glucose 12.5% intravenous infusion solut", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "hepatitis B paediatric vaccine", new ValueWithNote(null, null) },
//             { "hepatitis B paediatric vaccine", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "influenza vaccine, inactivated", new ValueWithNote(null, null) },
//             { "influenza vaccine, inactivated", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "hyoscine BUTylbromide", new ValueWithNote(null, null) },
//             { "hyoscine BUTylbromide", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "RO7204239", new ValueWithNote(null, null) },
//             { "RO7204239", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "RO7234292", new ValueWithNote(null, null) },
//             { "RO7234292", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "pilocarpine ophthalmic", new ValueWithNote(null, null) },
//             { "pilocarpine ophthalmic", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Leech therapy", new ValueWithNote(null, null) },
//             { "Leech therapy", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Parenteral Nutrition (Neonatal Unit)", new ValueWithNote(null, null) },
//             { "Parenteral Nutrition (Neonatal Unit)", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "NCEA", new ValueWithNote(null, null) },
//             { "NCEA", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "rabies vaccine, chick embryo cell", new ValueWithNote(null, null) },
//             { "rabies vaccine, chick embryo cell", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Nutritional supplements", new ValueWithNote(null, null) },
//             { "Nutritional supplements", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "potassium acid phosphate", new ValueWithNote(null, null) },
//             { "potassium acid phosphate", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "respiratory therapy supplies", new ValueWithNote(null, null) },
//             { "respiratory therapy supplies", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Peripheral Nerve Infusion", new ValueWithNote(null, null) },
//             { "Peripheral Nerve Infusion", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Radio-opaque markers", new ValueWithNote(null, null) },
//             { "Radio-opaque markers", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Sodium Chloride 2.7% intravenous solutio", new ValueWithNote(null, null) },
//             { "Sodium Chloride 2.7% intravenous solutio", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Sodium chloride 0.9% infusion", new ValueWithNote(null, null) },
//             { "Sodium chloride 0.9% infusion", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Sodium Chloride 5% intravenous solution", new ValueWithNote(null, null) },
//             { "Sodium Chloride 5% intravenous solution", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "RSV vaccine, preF A-preF B, recombinant", new ValueWithNote(null, null) },
//             { "RSV vaccine, preF A-preF B, recombinant", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "vitamins", new ValueWithNote(null, null) },
//             { "vitamins", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "saliva substitutes", new ValueWithNote(null, null) },
//             { "saliva substitutes", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Sodium Chloride 0.45% intravenous soluti", new ValueWithNote(null, null) },
//             { "Sodium Chloride 0.45% intravenous soluti", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "support devices", new ValueWithNote(null, null) },
//             { "support devices", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Hyoscine BUTylbromide", new ValueWithNote(null, null) },
//             { "Hyoscine BUTylbromide", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Insulin soluble porcine", new ValueWithNote(null, null) },
//             { "Insulin soluble porcine", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Nitrous Oxide + Oxygen", new ValueWithNote(null, null) },
//             { "Nitrous Oxide + Oxygen", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Stem Cells - CD34", new ValueWithNote(null, null) },
//             { "Stem Cells - CD34", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Arterial line flush sodium chloride 0", new ValueWithNote(null, null) },
//             { "Arterial line flush sodium chloride 0", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Ocular lubricant", new ValueWithNote(null, null) },
//             { "Ocular lubricant", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Sodium acid phosphate", new ValueWithNote(null, null) },
//             { "Sodium acid phosphate", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Calcium lactate + Calcium phosphate +", new ValueWithNote(null, null) },
//             { "Calcium lactate + Calcium phosphate +", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Central line flush sodium chloride 0.", new ValueWithNote(null, null) },
//             { "Central line flush sodium chloride 0.", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Flupentixol decanoate", new ValueWithNote(null, null) },
//             { "Flupentixol decanoate", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Sodium cromoglicate nasal", new ValueWithNote(null, null) },
//             { "Sodium cromoglicate nasal", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "FDY-5301", new ValueWithNote(null, null) },
//             { "FDY-5301", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "fluorouracil-salicylic acid", new ValueWithNote(null, null) },
//             { "fluorouracil-salicylic acid", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "Haemofiltration fluids", new ValueWithNote(null, null) },
//             { "Haemofiltration fluids", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "PCEA", new ValueWithNote(null, null) },
//             { "PCEA", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
            { "vitamins with minerals", new ValueWithNote(null, null) },
//             { "vitamins with minerals", new ValueWithNote(null, null) }, // Confidence: 0.0%, OMOP Match: 0.0%
        };


    public string[] ColumnNotes =>
    [
        "[RxNorm API Documentation](https://lhncbc.nlm.nih.gov/RxNav/APIs/RxNormAPIs.html)",
        "[RxNorm Overview](https://www.nlm.nih.gov/research/umls/rxnorm/overview.html)",
        "[OMOP Vocabulary (OHDSI Athena)](https://athena.ohdsi.org/search-terms/start)",
        "[OMOP Common Data Model](https://ohdsi.github.io/CommonDataModel/)",
        "[OHDSI Vocabulary Documentation](https://ohdsi.github.io/CommonDataModel/cdm60.html#CONCEPT)",
    ];
}
