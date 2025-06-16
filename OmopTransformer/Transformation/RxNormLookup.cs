using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Oxford Prescribing data to RxNorm Concept ID Mapping")]
internal class RxNormLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "ajmaline", new ValueWithNote("19105879", "ajmaline") },
//             { "ajmaline", new ValueWithNote("19105879", "ajmaline") }, // confidence: 100.0%, omop match: 100.0%
            { "albumin human", new ValueWithNote("1344143", "albumin human, usp") },
//             { "albumin human", new ValueWithNote("1344143", "albumin human, usp") }, // confidence: 100.0%, omop match: 100.0%
            { "alfentanil", new ValueWithNote("19059528", "alfentanil") },
//             { "alfentanil", new ValueWithNote("19059528", "alfentanil") }, // confidence: 100.0%, omop match: 100.0%
            { "acamprosate", new ValueWithNote("19043959", "acamprosate") },
//             { "acamprosate", new ValueWithNote("19043959", "acamprosate") }, // confidence: 100.0%, omop match: 100.0%
            { "acarbose", new ValueWithNote("1529331", "acarbose") },
//             { "acarbose", new ValueWithNote("1529331", "acarbose") }, // confidence: 100.0%, omop match: 100.0%
            { "amitriptyline", new ValueWithNote("710062", "amitriptyline") },
//             { "amitriptyline", new ValueWithNote("710062", "amitriptyline") }, // confidence: 100.0%, omop match: 100.0%
            { "amphotericin b liposomal", new ValueWithNote("19056402", "amphotericin b liposomal") },
//             { "amphotericin b liposomal", new ValueWithNote("19056402", "amphotericin b liposomal") }, // confidence: 100.0%, omop match: 100.0%
            { "acetarsol", new ValueWithNote("44012478", "acetarsol") },
//             { "acetarsol", new ValueWithNote("44012478", "acetarsol") }, // confidence: 100.0%, omop match: 100.0%
            { "acetazolamide", new ValueWithNote("929435", "acetazolamide") },
//             { "acetazolamide", new ValueWithNote("929435", "acetazolamide") }, // confidence: 100.0%, omop match: 100.0%
            { "antithymocyte immunoglobulin (rabbit)", new ValueWithNote("19003472", "rabbit anti-human t-lymphocyte globulin") },
//             { "antithymocyte immunoglobulin (rabbit)", new ValueWithNote("19003472", "rabbit anti-human t-lymphocyte globulin") }, // confidence: 100.0%, omop match: 100.0%
            { "aceclofenac", new ValueWithNote("19029393", "aceclofenac") },
//             { "aceclofenac", new ValueWithNote("19029393", "aceclofenac") }, // confidence: 100.0%, omop match: 100.0%
            { "abatacept", new ValueWithNote("1186087", "abatacept") },
//             { "abatacept", new ValueWithNote("1186087", "abatacept") }, // confidence: 100.0%, omop match: 100.0%
            { "acebutolol", new ValueWithNote("1319998", "acebutolol") },
//             { "acebutolol", new ValueWithNote("1319998", "acebutolol") }, // confidence: 100.0%, omop match: 100.0%
            { "adenosine", new ValueWithNote("1309204", "adenosine") },
//             { "adenosine", new ValueWithNote("1309204", "adenosine") }, // confidence: 100.0%, omop match: 100.0%
            { "abacavir", new ValueWithNote("1736971", "abacavir") },
//             { "abacavir", new ValueWithNote("1736971", "abacavir") }, // confidence: 100.0%, omop match: 100.0%
            { "abacavir/dolutegravir/lamivudine", new ValueWithNote("36029673", "abacavir / dolutegravir / lamivudine") },
//             { "abacavir/dolutegravir/lamivudine", new ValueWithNote("36029673", "abacavir / dolutegravir / lamivudine") }, // confidence: 100.0%, omop match: 100.0%
            { "apomorphine", new ValueWithNote("837027", "apomorphine") },
//             { "apomorphine", new ValueWithNote("837027", "apomorphine") }, // confidence: 100.0%, omop match: 100.0%
            { "aprepitant", new ValueWithNote("936748", "aprepitant") },
//             { "aprepitant", new ValueWithNote("936748", "aprepitant") }, // confidence: 100.0%, omop match: 100.0%
            { "adapalene", new ValueWithNote("981774", "adapalene") },
//             { "adapalene", new ValueWithNote("981774", "adapalene") }, // confidence: 100.0%, omop match: 100.0%
            { "aliskiren", new ValueWithNote("1317967", "aliskiren") },
//             { "aliskiren", new ValueWithNote("1317967", "aliskiren") }, // confidence: 100.0%, omop match: 100.0%
            { "amiodarone", new ValueWithNote("1309944", "amiodarone") },
//             { "amiodarone", new ValueWithNote("1309944", "amiodarone") }, // confidence: 100.0%, omop match: 100.0%
            { "amikacin", new ValueWithNote("1790868", "amikacin") },
//             { "amikacin", new ValueWithNote("1790868", "amikacin") }, // confidence: 100.0%, omop match: 100.0%
            { "aminophylline", new ValueWithNote("1105775", "aminophylline") },
//             { "aminophylline", new ValueWithNote("1105775", "aminophylline") }, // confidence: 100.0%, omop match: 100.0%
            { "atomoxetine", new ValueWithNote("742185", "atomoxetine") },
//             { "atomoxetine", new ValueWithNote("742185", "atomoxetine") }, // confidence: 100.0%, omop match: 100.0%
            { "acitretin", new ValueWithNote("929638", "acitretin") },
//             { "acitretin", new ValueWithNote("929638", "acitretin") }, // confidence: 100.0%, omop match: 100.0%
            { "acrivastine", new ValueWithNote("1140123", "acrivastine") },
//             { "acrivastine", new ValueWithNote("1140123", "acrivastine") }, // confidence: 100.0%, omop match: 100.0%
            { "albutrepenonacog alfa", new ValueWithNote("35606573", "albutrepenonacog alfa") },
//             { "albutrepenonacog alfa", new ValueWithNote("35606573", "albutrepenonacog alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "alginate", new ValueWithNote("43013872", "alginate") },
//             { "alginate", new ValueWithNote("43013872", "alginate") }, // confidence: 100.0%, omop match: 100.0%
            { "alimemazine", new ValueWithNote("19005570", "trimeprazine") },
//             { "alimemazine", new ValueWithNote("19005570", "trimeprazine") }, // confidence: 100.0%, omop match: 100.0%
            { "alverine", new ValueWithNote("19030751", "alverine") },
//             { "alverine", new ValueWithNote("19030751", "alverine") }, // confidence: 100.0%, omop match: 100.0%
            { "albendazole", new ValueWithNote("1753745", "albendazole") },
//             { "albendazole", new ValueWithNote("1753745", "albendazole") }, // confidence: 100.0%, omop match: 100.0%
            { "alfuzosin", new ValueWithNote("930021", "alfuzosin") },
//             { "alfuzosin", new ValueWithNote("930021", "alfuzosin") }, // confidence: 100.0%, omop match: 100.0%
            { "amisulpride", new ValueWithNote("19057607", "amisulpride") },
//             { "amisulpride", new ValueWithNote("19057607", "amisulpride") }, // confidence: 100.0%, omop match: 100.0%
            { "apalutamide", new ValueWithNote("963987", "apalutamide") },
//             { "apalutamide", new ValueWithNote("963987", "apalutamide") }, // confidence: 100.0%, omop match: 100.0%
            { "almitrine", new ValueWithNote("19113052", "almitrine") },
//             { "almitrine", new ValueWithNote("19113052", "almitrine") }, // confidence: 100.0%, omop match: 100.0%
            { "alogliptin", new ValueWithNote("43013884", "alogliptin") },
//             { "alogliptin", new ValueWithNote("43013884", "alogliptin") }, // confidence: 100.0%, omop match: 100.0%
            { "atazanavir", new ValueWithNote("1727223", "atazanavir") },
//             { "atazanavir", new ValueWithNote("1727223", "atazanavir") }, // confidence: 100.0%, omop match: 100.0%
            { "anastrozole", new ValueWithNote("1348265", "anastrozole") },
//             { "anastrozole", new ValueWithNote("1348265", "anastrozole") }, // confidence: 100.0%, omop match: 100.0%
            { "artesunate", new ValueWithNote("19018511", "artesunate") },
//             { "artesunate", new ValueWithNote("19018511", "artesunate") }, // confidence: 100.0%, omop match: 100.0%
            { "aminolevulinic acid", new ValueWithNote("904351", "aminolevulinic acid") },
//             { "aminolevulinic acid", new ValueWithNote("904351", "aminolevulinic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "axitinib", new ValueWithNote("42709322", "axitinib") },
//             { "axitinib", new ValueWithNote("42709322", "axitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "alitretinoin", new ValueWithNote("941052", "alitretinoin") },
//             { "alitretinoin", new ValueWithNote("941052", "alitretinoin") }, // confidence: 100.0%, omop match: 100.0%
            { "allopurinol", new ValueWithNote("1167322", "allopurinol") },
//             { "allopurinol", new ValueWithNote("1167322", "allopurinol") }, // confidence: 100.0%, omop match: 100.0%
            { "amorolfine", new ValueWithNote("19032619", "amorolfine") },
//             { "amorolfine", new ValueWithNote("19032619", "amorolfine") }, // confidence: 100.0%, omop match: 100.0%
            { "amoxicillin", new ValueWithNote("1713332", "amoxicillin") },
//             { "amoxicillin", new ValueWithNote("1713332", "amoxicillin") }, // confidence: 100.0%, omop match: 100.0%
            { "aztreonam", new ValueWithNote("1715117", "aztreonam") },
//             { "aztreonam", new ValueWithNote("1715117", "aztreonam") }, // confidence: 100.0%, omop match: 100.0%
            { "alendronic acid", new ValueWithNote("19055729", "alendronic acid") },
//             { "alendronic acid", new ValueWithNote("19055729", "alendronic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "alirocumab", new ValueWithNote("46275447", "alirocumab") },
//             { "alirocumab", new ValueWithNote("46275447", "alirocumab") }, // confidence: 100.0%, omop match: 100.0%
            { "atenolol", new ValueWithNote("1314002", "atenolol") },
//             { "atenolol", new ValueWithNote("1314002", "atenolol") }, // confidence: 100.0%, omop match: 100.0%
            { "aluminium hydroxide", new ValueWithNote("985247", "aluminum hydroxide") },
//             { "aluminium hydroxide", new ValueWithNote("985247", "aluminum hydroxide") }, // confidence: 100.0%, omop match: 100.0%
            { "amlitelimab", new ValueWithNote("1254461", "amlitelimab") },
//             { "amlitelimab", new ValueWithNote("1254461", "amlitelimab") }, // confidence: 100.0%, omop match: 100.0%
            { "arachis oil", new ValueWithNote("19033278", "peanut oil") },
//             { "arachis oil", new ValueWithNote("19033278", "peanut oil") }, // confidence: 100.0%, omop match: 100.0%
            { "almotriptan", new ValueWithNote("1103552", "almotriptan") },
//             { "almotriptan", new ValueWithNote("1103552", "almotriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "aluminium chloride", new ValueWithNote("957393", "aluminum chloride") },
//             { "aluminium chloride", new ValueWithNote("957393", "aluminum chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "anagrelide", new ValueWithNote("1381253", "anagrelide") },
//             { "anagrelide", new ValueWithNote("1381253", "anagrelide") }, // confidence: 100.0%, omop match: 100.0%
            { "apixaban", new ValueWithNote("43013024", "apixaban") },
//             { "apixaban", new ValueWithNote("43013024", "apixaban") }, // confidence: 100.0%, omop match: 100.0%
            { "atovaquone", new ValueWithNote("1781733", "atovaquone") },
//             { "atovaquone", new ValueWithNote("1781733", "atovaquone") }, // confidence: 100.0%, omop match: 100.0%
            { "avacopan", new ValueWithNote("702027", "avacopan") },
//             { "avacopan", new ValueWithNote("702027", "avacopan") }, // confidence: 100.0%, omop match: 100.0%
            { "atorvastatin", new ValueWithNote("1545958", "atorvastatin") },
//             { "atorvastatin", new ValueWithNote("1545958", "atorvastatin") }, // confidence: 100.0%, omop match: 100.0%
            { "atropine", new ValueWithNote("914335", "atropine") },
//             { "atropine", new ValueWithNote("914335", "atropine") }, // confidence: 100.0%, omop match: 100.0%
            { "baricitinib", new ValueWithNote("1510627", "baricitinib") },
//             { "baricitinib", new ValueWithNote("1510627", "baricitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "azathioprine", new ValueWithNote("19014878", "azathioprine") },
//             { "azathioprine", new ValueWithNote("19014878", "azathioprine") }, // confidence: 100.0%, omop match: 100.0%
            { "baclofen", new ValueWithNote("715233", "baclofen") },
//             { "baclofen", new ValueWithNote("715233", "baclofen") }, // confidence: 100.0%, omop match: 100.0%
            { "calcitonin", new ValueWithNote("42900359", "calcitonin") },
//             { "calcitonin", new ValueWithNote("42900359", "calcitonin") }, // confidence: 100.0%, omop match: 100.0%
            { "barium", new ValueWithNote("42898624", "barium") },
//             { "barium", new ValueWithNote("42898624", "barium") }, // confidence: 100.0%, omop match: 100.0%
            { "bedaquiline", new ValueWithNote("43012518", "bedaquiline") },
//             { "bedaquiline", new ValueWithNote("43012518", "bedaquiline") }, // confidence: 100.0%, omop match: 100.0%
            { "cefalexin", new ValueWithNote("1786621", "cephalexin") },
//             { "cefalexin", new ValueWithNote("1786621", "cephalexin") }, // confidence: 100.0%, omop match: 100.0%
            { "cefepime", new ValueWithNote("1748975", "cefepime") },
//             { "cefepime", new ValueWithNote("1748975", "cefepime") }, // confidence: 100.0%, omop match: 100.0%
            { "belumosudil", new ValueWithNote("701423", "belumosudil") },
//             { "belumosudil", new ValueWithNote("701423", "belumosudil") }, // confidence: 100.0%, omop match: 100.0%
            { "benzoyl peroxide", new ValueWithNote("918172", "benzoyl peroxide") },
//             { "benzoyl peroxide", new ValueWithNote("918172", "benzoyl peroxide") }, // confidence: 100.0%, omop match: 100.0%
            { "betahistine", new ValueWithNote("19020124", "betahistine") },
//             { "betahistine", new ValueWithNote("19020124", "betahistine") }, // confidence: 100.0%, omop match: 100.0%
            { "cefotaxime", new ValueWithNote("1774470", "cefotaxime") },
//             { "cefotaxime", new ValueWithNote("1774470", "cefotaxime") }, // confidence: 100.0%, omop match: 100.0%
            { "cefuroxime", new ValueWithNote("1778162", "cefuroxime") },
//             { "cefuroxime", new ValueWithNote("1778162", "cefuroxime") }, // confidence: 100.0%, omop match: 100.0%
            { "bicalutamide", new ValueWithNote("1344381", "bicalutamide") },
//             { "bicalutamide", new ValueWithNote("1344381", "bicalutamide") }, // confidence: 100.0%, omop match: 100.0%
            { "amantadine", new ValueWithNote("19087090", "amantadine") },
//             { "amantadine", new ValueWithNote("19087090", "amantadine") }, // confidence: 100.0%, omop match: 100.0%
            { "amidotrizoate", new ValueWithNote("19022596", "diatrizoate") },
//             { "amidotrizoate", new ValueWithNote("19022596", "diatrizoate") }, // confidence: 100.0%, omop match: 100.0%
            { "chlorothiazide", new ValueWithNote("992590", "chlorothiazide") },
//             { "chlorothiazide", new ValueWithNote("992590", "chlorothiazide") }, // confidence: 100.0%, omop match: 100.0%
            { "bezafibrate", new ValueWithNote("19022956", "bezafibrate") },
//             { "bezafibrate", new ValueWithNote("19022956", "bezafibrate") }, // confidence: 100.0%, omop match: 100.0%
            { "bisoprolol", new ValueWithNote("1338005", "bisoprolol") },
//             { "bisoprolol", new ValueWithNote("1338005", "bisoprolol") }, // confidence: 100.0%, omop match: 100.0%
            { "abiraterone", new ValueWithNote("40239056", "abiraterone") },
//             { "abiraterone", new ValueWithNote("40239056", "abiraterone") }, // confidence: 100.0%, omop match: 100.0%
            { "acenocoumarol", new ValueWithNote("19024063", "acenocoumarol") },
//             { "acenocoumarol", new ValueWithNote("19024063", "acenocoumarol") }, // confidence: 100.0%, omop match: 100.0%
            { "bleomycin", new ValueWithNote("1329241", "bleomycin") },
//             { "bleomycin", new ValueWithNote("1329241", "bleomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "botulinum toxin type a", new ValueWithNote("729855", "botulinum toxin type a") },
//             { "botulinum toxin type a", new ValueWithNote("729855", "botulinum toxin type a") }, // confidence: 100.0%, omop match: 100.0%
            { "amiloride", new ValueWithNote("991382", "amiloride") },
//             { "amiloride", new ValueWithNote("991382", "amiloride") }, // confidence: 100.0%, omop match: 100.0%
            { "amobarbital", new ValueWithNote("712757", "amobarbital") },
//             { "amobarbital", new ValueWithNote("712757", "amobarbital") }, // confidence: 100.0%, omop match: 100.0%
            { "bromocriptine", new ValueWithNote("730548", "bromocriptine") },
//             { "bromocriptine", new ValueWithNote("730548", "bromocriptine") }, // confidence: 100.0%, omop match: 100.0%
            { "bambuterol", new ValueWithNote("19034275", "bambuterol") },
//             { "bambuterol", new ValueWithNote("19034275", "bambuterol") }, // confidence: 100.0%, omop match: 100.0%
            { "ascorbic acid", new ValueWithNote("19011773", "ascorbic acid") },
//             { "ascorbic acid", new ValueWithNote("19011773", "ascorbic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "aspirin", new ValueWithNote("1112807", "aspirin") },
//             { "aspirin", new ValueWithNote("1112807", "aspirin") }, // confidence: 100.0%, omop match: 100.0%
            { "anakinra", new ValueWithNote("1114375", "anakinra") },
//             { "anakinra", new ValueWithNote("1114375", "anakinra") }, // confidence: 100.0%, omop match: 100.0%
            { "arginine", new ValueWithNote("19006410", "arginine") },
//             { "arginine", new ValueWithNote("19006410", "arginine") }, // confidence: 100.0%, omop match: 100.0%
            { "avatrombopag", new ValueWithNote("1510483", "avatrombopag") },
//             { "avatrombopag", new ValueWithNote("1510483", "avatrombopag") }, // confidence: 100.0%, omop match: 100.0%
            { "aripiprazole", new ValueWithNote("757688", "aripiprazole") },
//             { "aripiprazole", new ValueWithNote("757688", "aripiprazole") }, // confidence: 100.0%, omop match: 100.0%
            { "belimumab", new ValueWithNote("40236987", "belimumab") },
//             { "belimumab", new ValueWithNote("40236987", "belimumab") }, // confidence: 100.0%, omop match: 100.0%
            { "benzalkonium chloride", new ValueWithNote("19011436", "benzalkonium chloride") },
//             { "benzalkonium chloride", new ValueWithNote("19011436", "benzalkonium chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "azithromycin", new ValueWithNote("1734104", "azithromycin") },
//             { "azithromycin", new ValueWithNote("1734104", "azithromycin") }, // confidence: 100.0%, omop match: 100.0%
            { "cimetidine", new ValueWithNote("997276", "cimetidine") },
//             { "cimetidine", new ValueWithNote("997276", "cimetidine") }, // confidence: 100.0%, omop match: 100.0%
            { "ciprofibrate", new ValueWithNote("19050375", "ciprofibrate") },
//             { "ciprofibrate", new ValueWithNote("19050375", "ciprofibrate") }, // confidence: 100.0%, omop match: 100.0%
            { "cabotegravir", new ValueWithNote("739588", "cabotegravir") },
//             { "cabotegravir", new ValueWithNote("739588", "cabotegravir") }, // confidence: 100.0%, omop match: 100.0%
            { "calcium carbonate", new ValueWithNote("19035704", "calcium carbonate") },
//             { "calcium carbonate", new ValueWithNote("19035704", "calcium carbonate") }, // confidence: 100.0%, omop match: 100.0%
            { "balsalazide", new ValueWithNote("934262", "balsalazide") },
//             { "balsalazide", new ValueWithNote("934262", "balsalazide") }, // confidence: 100.0%, omop match: 100.0%
            { "captopril", new ValueWithNote("1340128", "captopril") },
//             { "captopril", new ValueWithNote("1340128", "captopril") }, // confidence: 100.0%, omop match: 100.0%
            { "casirivimab", new ValueWithNote("37003288", "casirivimab") },
//             { "casirivimab", new ValueWithNote("37003288", "casirivimab") }, // confidence: 100.0%, omop match: 100.0%
            { "cisatracurium", new ValueWithNote("19015726", "cisatracurium") },
//             { "cisatracurium", new ValueWithNote("19015726", "cisatracurium") }, // confidence: 100.0%, omop match: 100.0%
            { "cefixime", new ValueWithNote("1796435", "cefixime") },
//             { "cefixime", new ValueWithNote("1796435", "cefixime") }, // confidence: 100.0%, omop match: 100.0%
            { "ceftazidime", new ValueWithNote("1776684", "ceftazidime") },
//             { "ceftazidime", new ValueWithNote("1776684", "ceftazidime") }, // confidence: 100.0%, omop match: 100.0%
            { "benzbromarone", new ValueWithNote("19016754", "benzbromarone") },
//             { "benzbromarone", new ValueWithNote("19016754", "benzbromarone") }, // confidence: 100.0%, omop match: 100.0%
            { "axatilimab", new ValueWithNote("1735157", "axatilimab") },
//             { "axatilimab", new ValueWithNote("1735157", "axatilimab") }, // confidence: 100.0%, omop match: 100.0%
            { "azilsartan", new ValueWithNote("40235485", "azilsartan") },
//             { "azilsartan", new ValueWithNote("40235485", "azilsartan") }, // confidence: 100.0%, omop match: 100.0%
            { "clobazam", new ValueWithNote("19050832", "clobazam") },
//             { "clobazam", new ValueWithNote("19050832", "clobazam") }, // confidence: 100.0%, omop match: 100.0%
            { "clodronic acid", new ValueWithNote("19024249", "clodronic acid") },
//             { "clodronic acid", new ValueWithNote("19024249", "clodronic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "bendroflumethiazide", new ValueWithNote("1316354", "bendroflumethiazide") },
//             { "bendroflumethiazide", new ValueWithNote("1316354", "bendroflumethiazide") }, // confidence: 100.0%, omop match: 100.0%
            { "bevacizumab", new ValueWithNote("1397141", "bevacizumab") },
//             { "bevacizumab", new ValueWithNote("1397141", "bevacizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "biotin", new ValueWithNote("19024770", "biotin") },
//             { "biotin", new ValueWithNote("19024770", "biotin") }, // confidence: 100.0%, omop match: 100.0%
            { "clonidine", new ValueWithNote("1398937", "clonidine") },
//             { "clonidine", new ValueWithNote("1398937", "clonidine") }, // confidence: 100.0%, omop match: 100.0%
            { "brivaracetam", new ValueWithNote("35604901", "brivaracetam") },
//             { "brivaracetam", new ValueWithNote("35604901", "brivaracetam") }, // confidence: 100.0%, omop match: 100.0%
            { "benzydamine", new ValueWithNote("19019620", "benzydamine") },
//             { "benzydamine", new ValueWithNote("19019620", "benzydamine") }, // confidence: 100.0%, omop match: 100.0%
            { "chorionic gonadotrophin", new ValueWithNote("1563600", "chorionic gonadotropin") },
//             { "chorionic gonadotrophin", new ValueWithNote("1563600", "chorionic gonadotropin") }, // confidence: 100.0%, omop match: 100.0%
            { "bromazepam", new ValueWithNote("19030353", "bromazepam") },
//             { "bromazepam", new ValueWithNote("19030353", "bromazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "budesonide", new ValueWithNote("939259", "budesonide") },
//             { "budesonide", new ValueWithNote("939259", "budesonide") }, // confidence: 100.0%, omop match: 100.0%
            { "citric acid", new ValueWithNote("950435", "citric acid") },
//             { "citric acid", new ValueWithNote("950435", "citric acid") }, // confidence: 100.0%, omop match: 100.0%
            { "calcitriol", new ValueWithNote("19035631", "calcitriol") },
//             { "calcitriol", new ValueWithNote("19035631", "calcitriol") }, // confidence: 100.0%, omop match: 100.0%
            { "caffeine", new ValueWithNote("1134439", "caffeine") },
//             { "caffeine", new ValueWithNote("1134439", "caffeine") }, // confidence: 100.0%, omop match: 100.0%
            { "basiliximab", new ValueWithNote("19038440", "basiliximab") },
//             { "basiliximab", new ValueWithNote("19038440", "basiliximab") }, // confidence: 100.0%, omop match: 100.0%
            { "bisacodyl", new ValueWithNote("924939", "bisacodyl") },
//             { "bisacodyl", new ValueWithNote("924939", "bisacodyl") }, // confidence: 100.0%, omop match: 100.0%
            { "benralizumab", new ValueWithNote("792993", "benralizumab") },
//             { "benralizumab", new ValueWithNote("792993", "benralizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "calcium lactate", new ValueWithNote("19058896", "calcium lactate") },
//             { "calcium lactate", new ValueWithNote("19058896", "calcium lactate") }, // confidence: 100.0%, omop match: 100.0%
            { "canakinumab", new ValueWithNote("40161669", "canakinumab") },
//             { "canakinumab", new ValueWithNote("40161669", "canakinumab") }, // confidence: 100.0%, omop match: 100.0%
            { "benzathine benzylpenicillin", new ValueWithNote("19130393", "penicillin g benzathine") },
//             { "benzathine benzylpenicillin", new ValueWithNote("19130393", "penicillin g benzathine") }, // confidence: 100.0%, omop match: 100.0%
            { "betamethasone", new ValueWithNote("920458", "betamethasone") },
//             { "betamethasone", new ValueWithNote("920458", "betamethasone") }, // confidence: 100.0%, omop match: 100.0%
            { "bupivacaine", new ValueWithNote("732893", "bupivacaine") },
//             { "bupivacaine", new ValueWithNote("732893", "bupivacaine") }, // confidence: 100.0%, omop match: 100.0%
            { "cabergoline", new ValueWithNote("1558471", "cabergoline") },
//             { "cabergoline", new ValueWithNote("1558471", "cabergoline") }, // confidence: 100.0%, omop match: 100.0%
            { "cannabidiol", new ValueWithNote("1510417", "cannabidiol") },
//             { "cannabidiol", new ValueWithNote("1510417", "cannabidiol") }, // confidence: 100.0%, omop match: 100.0%
            { "capecitabine", new ValueWithNote("1337620", "capecitabine") },
//             { "capecitabine", new ValueWithNote("1337620", "capecitabine") }, // confidence: 100.0%, omop match: 100.0%
            { "carbidopa/entacapone/levodopa", new ValueWithNote("36030184", "carbidopa / entacapone / levodopa") },
//             { "carbidopa/entacapone/levodopa", new ValueWithNote("36030184", "carbidopa / entacapone / levodopa") }, // confidence: 100.0%, omop match: 100.0%
            { "carbocisteine", new ValueWithNote("19041843", "carbocysteine") },
//             { "carbocisteine", new ValueWithNote("19041843", "carbocysteine") }, // confidence: 100.0%, omop match: 100.0%
            { "carglumic acid", new ValueWithNote("19102150", "carglumic acid") },
//             { "carglumic acid", new ValueWithNote("19102150", "carglumic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "ceftriaxone", new ValueWithNote("1777806", "ceftriaxone") },
//             { "ceftriaxone", new ValueWithNote("1777806", "ceftriaxone") }, // confidence: 100.0%, omop match: 100.0%
            { "bumetanide", new ValueWithNote("932745", "bumetanide") },
//             { "bumetanide", new ValueWithNote("932745", "bumetanide") }, // confidence: 100.0%, omop match: 100.0%
            { "bupropion", new ValueWithNote("750982", "bupropion") },
//             { "bupropion", new ValueWithNote("750982", "bupropion") }, // confidence: 100.0%, omop match: 100.0%
            { "clobetasol", new ValueWithNote("998415", "clobetasol") },
//             { "clobetasol", new ValueWithNote("998415", "clobetasol") }, // confidence: 100.0%, omop match: 100.0%
            { "buspirone", new ValueWithNote("733301", "buspirone") },
//             { "buspirone", new ValueWithNote("733301", "buspirone") }, // confidence: 100.0%, omop match: 100.0%
            { "calamine", new ValueWithNote("902616", "calamine") },
//             { "calamine", new ValueWithNote("902616", "calamine") }, // confidence: 100.0%, omop match: 100.0%
            { "caplacizumab", new ValueWithNote("1366428", "caplacizumab") },
//             { "caplacizumab", new ValueWithNote("1366428", "caplacizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "carbimazole", new ValueWithNote("19040606", "carbimazole") },
//             { "carbimazole", new ValueWithNote("19040606", "carbimazole") }, // confidence: 100.0%, omop match: 100.0%
            { "buprenorphine", new ValueWithNote("1133201", "buprenorphine") },
//             { "buprenorphine", new ValueWithNote("1133201", "buprenorphine") }, // confidence: 100.0%, omop match: 100.0%
            { "c1 esterase inhibitor", new ValueWithNote("45892906", "c1 esterase inhibitor") },
//             { "c1 esterase inhibitor", new ValueWithNote("45892906", "c1 esterase inhibitor") }, // confidence: 100.0%, omop match: 100.0%
            { "calcipotriol", new ValueWithNote("908921", "calcipotriene") },
//             { "calcipotriol", new ValueWithNote("908921", "calcipotriene") }, // confidence: 100.0%, omop match: 100.0%
            { "coal tar", new ValueWithNote("1000995", "coal tar") },
//             { "coal tar", new ValueWithNote("1000995", "coal tar") }, // confidence: 100.0%, omop match: 100.0%
            { "cefazolin", new ValueWithNote("1771162", "cefazolin") },
//             { "cefazolin", new ValueWithNote("1771162", "cefazolin") }, // confidence: 100.0%, omop match: 100.0%
            { "chlortalidone", new ValueWithNote("1395058", "chlorthalidone") },
//             { "chlortalidone", new ValueWithNote("1395058", "chlorthalidone") }, // confidence: 100.0%, omop match: 100.0%
            { "cinnarizine", new ValueWithNote("19097481", "cinnarizine") },
//             { "cinnarizine", new ValueWithNote("19097481", "cinnarizine") }, // confidence: 100.0%, omop match: 100.0%
            { "citalopram", new ValueWithNote("797617", "citalopram") },
//             { "citalopram", new ValueWithNote("797617", "citalopram") }, // confidence: 100.0%, omop match: 100.0%
            { "celecoxib", new ValueWithNote("1118084", "celecoxib") },
//             { "celecoxib", new ValueWithNote("1118084", "celecoxib") }, // confidence: 100.0%, omop match: 100.0%
            { "carvedilol", new ValueWithNote("1346823", "carvedilol") },
//             { "carvedilol", new ValueWithNote("1346823", "carvedilol") }, // confidence: 100.0%, omop match: 100.0%
            { "caspofungin", new ValueWithNote("1718054", "caspofungin") },
//             { "caspofungin", new ValueWithNote("1718054", "caspofungin") }, // confidence: 100.0%, omop match: 100.0%
            { "calcium acetate", new ValueWithNote("951469", "calcium acetate") },
//             { "calcium acetate", new ValueWithNote("951469", "calcium acetate") }, // confidence: 100.0%, omop match: 100.0%
            { "calcium chloride", new ValueWithNote("19036781", "calcium chloride") },
//             { "calcium chloride", new ValueWithNote("19036781", "calcium chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "canagliflozin", new ValueWithNote("43526465", "canagliflozin") },
//             { "canagliflozin", new ValueWithNote("43526465", "canagliflozin") }, // confidence: 100.0%, omop match: 100.0%
            { "cefiderocol", new ValueWithNote("37498010", "cefiderocol") },
//             { "cefiderocol", new ValueWithNote("37498010", "cefiderocol") }, // confidence: 100.0%, omop match: 100.0%
            { "cenobamate", new ValueWithNote("37497998", "cenobamate") },
//             { "cenobamate", new ValueWithNote("37497998", "cenobamate") }, // confidence: 100.0%, omop match: 100.0%
            { "clomifene", new ValueWithNote("1598819", "clomiphene") },
//             { "clomifene", new ValueWithNote("1598819", "clomiphene") }, // confidence: 100.0%, omop match: 100.0%
            { "clomipramine", new ValueWithNote("798834", "clomipramine") },
//             { "clomipramine", new ValueWithNote("798834", "clomipramine") }, // confidence: 100.0%, omop match: 100.0%
            { "cangrelor", new ValueWithNote("46275677", "cangrelor") },
//             { "cangrelor", new ValueWithNote("46275677", "cangrelor") }, // confidence: 100.0%, omop match: 100.0%
            { "capsaicin", new ValueWithNote("939881", "capsaicin") },
//             { "capsaicin", new ValueWithNote("939881", "capsaicin") }, // confidence: 100.0%, omop match: 100.0%
            { "certolizumab pegol", new ValueWithNote("912263", "certolizumab pegol") },
//             { "certolizumab pegol", new ValueWithNote("912263", "certolizumab pegol") }, // confidence: 100.0%, omop match: 100.0%
            { "chloral hydrate", new ValueWithNote("19054996", "chloral hydrate") },
//             { "chloral hydrate", new ValueWithNote("19054996", "chloral hydrate") }, // confidence: 100.0%, omop match: 100.0%
            { "carbamazepine", new ValueWithNote("740275", "carbamazepine") },
//             { "carbamazepine", new ValueWithNote("740275", "carbamazepine") }, // confidence: 100.0%, omop match: 100.0%
            { "cefoxitin", new ValueWithNote("1775741", "cefoxitin") },
//             { "cefoxitin", new ValueWithNote("1775741", "cefoxitin") }, // confidence: 100.0%, omop match: 100.0%
            { "clonazepam", new ValueWithNote("798874", "clonazepam") },
//             { "clonazepam", new ValueWithNote("798874", "clonazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "clopidogrel", new ValueWithNote("1322184", "clopidogrel") },
//             { "clopidogrel", new ValueWithNote("1322184", "clopidogrel") }, // confidence: 100.0%, omop match: 100.0%
            { "cilazapril", new ValueWithNote("19050216", "cilazapril") },
//             { "cilazapril", new ValueWithNote("19050216", "cilazapril") }, // confidence: 100.0%, omop match: 100.0%
            { "cycloserine", new ValueWithNote("1710446", "cycloserine") },
//             { "cycloserine", new ValueWithNote("1710446", "cycloserine") }, // confidence: 100.0%, omop match: 100.0%
            { "colchicine", new ValueWithNote("1101554", "colchicine") },
//             { "colchicine", new ValueWithNote("1101554", "colchicine") }, // confidence: 100.0%, omop match: 100.0%
            { "colestyramine", new ValueWithNote("19095309", "cholestyramine resin") },
//             { "colestyramine", new ValueWithNote("19095309", "cholestyramine resin") }, // confidence: 100.0%, omop match: 100.0%
            { "celiprolol", new ValueWithNote("19049145", "celiprolol") },
//             { "celiprolol", new ValueWithNote("19049145", "celiprolol") }, // confidence: 100.0%, omop match: 100.0%
            { "chloroquine", new ValueWithNote("1792515", "chloroquine") },
//             { "chloroquine", new ValueWithNote("1792515", "chloroquine") }, // confidence: 100.0%, omop match: 100.0%
            { "cyproterone", new ValueWithNote("19010792", "cyproterone") },
//             { "cyproterone", new ValueWithNote("19010792", "cyproterone") }, // confidence: 100.0%, omop match: 100.0%
            { "dabrafenib", new ValueWithNote("43532299", "dabrafenib") },
//             { "dabrafenib", new ValueWithNote("43532299", "dabrafenib") }, // confidence: 100.0%, omop match: 100.0%
            { "chlorambucil", new ValueWithNote("1390051", "chlorambucil") },
//             { "chlorambucil", new ValueWithNote("1390051", "chlorambucil") }, // confidence: 100.0%, omop match: 100.0%
            { "clozapine", new ValueWithNote("800878", "clozapine") },
//             { "clozapine", new ValueWithNote("800878", "clozapine") }, // confidence: 100.0%, omop match: 100.0%
            { "crizotinib", new ValueWithNote("40242675", "crizotinib") },
//             { "crizotinib", new ValueWithNote("40242675", "crizotinib") }, // confidence: 100.0%, omop match: 100.0%
            { "clarithromycin", new ValueWithNote("1750500", "clarithromycin") },
//             { "clarithromycin", new ValueWithNote("1750500", "clarithromycin") }, // confidence: 100.0%, omop match: 100.0%
            { "clindamycin", new ValueWithNote("997881", "clindamycin") },
//             { "clindamycin", new ValueWithNote("997881", "clindamycin") }, // confidence: 100.0%, omop match: 100.0%
            { "chlordiazepoxide", new ValueWithNote("990678", "chlordiazepoxide") },
//             { "chlordiazepoxide", new ValueWithNote("990678", "chlordiazepoxide") }, // confidence: 100.0%, omop match: 100.0%
            { "colistimethate sodium", new ValueWithNote("19112658", "colistimethate sodium") },
//             { "colistimethate sodium", new ValueWithNote("19112658", "colistimethate sodium") }, // confidence: 100.0%, omop match: 100.0%
            { "chlorpromazine", new ValueWithNote("794852", "chlorpromazine") },
//             { "chlorpromazine", new ValueWithNote("794852", "chlorpromazine") }, // confidence: 100.0%, omop match: 100.0%
            { "dapagliflozin", new ValueWithNote("44785829", "dapagliflozin") },
//             { "dapagliflozin", new ValueWithNote("44785829", "dapagliflozin") }, // confidence: 100.0%, omop match: 100.0%
            { "dapsone", new ValueWithNote("1711759", "dapsone") },
//             { "dapsone", new ValueWithNote("1711759", "dapsone") }, // confidence: 100.0%, omop match: 100.0%
            { "clotrimazole", new ValueWithNote("1000632", "clotrimazole") },
//             { "clotrimazole", new ValueWithNote("1000632", "clotrimazole") }, // confidence: 100.0%, omop match: 100.0%
            { "dabigatran", new ValueWithNote("45775372", "dabigatran") },
//             { "dabigatran", new ValueWithNote("45775372", "dabigatran") }, // confidence: 100.0%, omop match: 100.0%
            { "demeclocycline", new ValueWithNote("1714527", "demeclocycline") },
//             { "demeclocycline", new ValueWithNote("1714527", "demeclocycline") }, // confidence: 100.0%, omop match: 100.0%
            { "cilostazol", new ValueWithNote("1350310", "cilostazol") },
//             { "cilostazol", new ValueWithNote("1350310", "cilostazol") }, // confidence: 100.0%, omop match: 100.0%
            { "crotamiton", new ValueWithNote("969276", "crotamiton") },
//             { "crotamiton", new ValueWithNote("969276", "crotamiton") }, // confidence: 100.0%, omop match: 100.0%
            { "ciprofloxacin", new ValueWithNote("1797513", "ciprofloxacin") },
//             { "ciprofloxacin", new ValueWithNote("1797513", "ciprofloxacin") }, // confidence: 100.0%, omop match: 100.0%
            { "cyclizine", new ValueWithNote("909358", "cyclizine") },
//             { "cyclizine", new ValueWithNote("909358", "cyclizine") }, // confidence: 100.0%, omop match: 100.0%
            { "crizanlizumab", new ValueWithNote("37497670", "crizanlizumab") },
//             { "crizanlizumab", new ValueWithNote("37497670", "crizanlizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "colesevelam", new ValueWithNote("1518148", "colesevelam") },
//             { "colesevelam", new ValueWithNote("1518148", "colesevelam") }, // confidence: 100.0%, omop match: 100.0%
            { "daptomycin", new ValueWithNote("1786617", "daptomycin") },
//             { "daptomycin", new ValueWithNote("1786617", "daptomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "darifenacin", new ValueWithNote("916230", "darifenacin") },
//             { "darifenacin", new ValueWithNote("916230", "darifenacin") }, // confidence: 100.0%, omop match: 100.0%
            { "choline salicylate", new ValueWithNote("19042282", "choline salicylate") },
//             { "choline salicylate", new ValueWithNote("19042282", "choline salicylate") }, // confidence: 100.0%, omop match: 100.0%
            { "ciclesonide", new ValueWithNote("902938", "ciclesonide") },
//             { "ciclesonide", new ValueWithNote("902938", "ciclesonide") }, // confidence: 100.0%, omop match: 100.0%
            { "cm-101", new ValueWithNote("1254269", "cm-101") },
//             { "cm-101", new ValueWithNote("1254269", "cm-101") }, // confidence: 100.0%, omop match: 100.0%
            { "darbepoetin alfa", new ValueWithNote("1304643", "darbepoetin alfa") },
//             { "darbepoetin alfa", new ValueWithNote("1304643", "darbepoetin alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "darunavir", new ValueWithNote("1756831", "darunavir") },
//             { "darunavir", new ValueWithNote("1756831", "darunavir") }, // confidence: 100.0%, omop match: 100.0%
            { "cyproheptadine", new ValueWithNote("1110727", "cyproheptadine") },
//             { "cyproheptadine", new ValueWithNote("1110727", "cyproheptadine") }, // confidence: 100.0%, omop match: 100.0%
            { "dequalinium", new ValueWithNote("19016063", "dequalinium") },
//             { "dequalinium", new ValueWithNote("19016063", "dequalinium") }, // confidence: 100.0%, omop match: 100.0%
            { "dalteparin", new ValueWithNote("1301065", "dalteparin") },
//             { "dalteparin", new ValueWithNote("1301065", "dalteparin") }, // confidence: 100.0%, omop match: 100.0%
            { "dexamfetamine", new ValueWithNote("719311", "dextroamphetamine") },
//             { "dexamfetamine", new ValueWithNote("719311", "dextroamphetamine") }, // confidence: 100.0%, omop match: 100.0%
            { "ciclosporin", new ValueWithNote("19010482", "cyclosporine") },
//             { "ciclosporin", new ValueWithNote("19010482", "cyclosporine") }, // confidence: 100.0%, omop match: 100.0%
            { "deferiprone", new ValueWithNote("19011091", "deferiprone") },
//             { "deferiprone", new ValueWithNote("19011091", "deferiprone") }, // confidence: 100.0%, omop match: 100.0%
            { "desloratadine", new ValueWithNote("1103006", "desloratadine") },
//             { "desloratadine", new ValueWithNote("1103006", "desloratadine") }, // confidence: 100.0%, omop match: 100.0%
            { "desogestrel", new ValueWithNote("1588000", "desogestrel") },
//             { "desogestrel", new ValueWithNote("1588000", "desogestrel") }, // confidence: 100.0%, omop match: 100.0%
            { "dexmedetomidine", new ValueWithNote("19061088", "dexmedetomidine") },
//             { "dexmedetomidine", new ValueWithNote("19061088", "dexmedetomidine") }, // confidence: 100.0%, omop match: 100.0%
            { "degarelix", new ValueWithNote("19058410", "degarelix") },
//             { "degarelix", new ValueWithNote("19058410", "degarelix") }, // confidence: 100.0%, omop match: 100.0%
            { "desmopressin", new ValueWithNote("1517070", "desmopressin") },
//             { "desmopressin", new ValueWithNote("1517070", "desmopressin") }, // confidence: 100.0%, omop match: 100.0%
            { "dinoprostone", new ValueWithNote("1329415", "dinoprostone") },
//             { "dinoprostone", new ValueWithNote("1329415", "dinoprostone") }, // confidence: 100.0%, omop match: 100.0%
            { "cidofovir", new ValueWithNote("1745072", "cidofovir") },
//             { "cidofovir", new ValueWithNote("1745072", "cidofovir") }, // confidence: 100.0%, omop match: 100.0%
            { "dexamethasone", new ValueWithNote("1518254", "dexamethasone") },
//             { "dexamethasone", new ValueWithNote("1518254", "dexamethasone") }, // confidence: 100.0%, omop match: 100.0%
            { "diamorphine", new ValueWithNote("19022417", "heroin") },
//             { "diamorphine", new ValueWithNote("19022417", "heroin") }, // confidence: 100.0%, omop match: 100.0%
            { "clemastine", new ValueWithNote("1197677", "clemastine") },
//             { "clemastine", new ValueWithNote("1197677", "clemastine") }, // confidence: 100.0%, omop match: 100.0%
            { "clobetasone", new ValueWithNote("19005129", "clobetasone") },
//             { "clobetasone", new ValueWithNote("19005129", "clobetasone") }, // confidence: 100.0%, omop match: 100.0%
            { "diazepam", new ValueWithNote("723013", "diazepam") },
//             { "diazepam", new ValueWithNote("723013", "diazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "diazoxide", new ValueWithNote("1523280", "diazoxide") },
//             { "diazoxide", new ValueWithNote("1523280", "diazoxide") }, // confidence: 100.0%, omop match: 100.0%
            { "clofazimine", new ValueWithNote("1798476", "clofazimine") },
//             { "clofazimine", new ValueWithNote("1798476", "clofazimine") }, // confidence: 100.0%, omop match: 100.0%
            { "dutasteride", new ValueWithNote("989482", "dutasteride") },
//             { "dutasteride", new ValueWithNote("989482", "dutasteride") }, // confidence: 100.0%, omop match: 100.0%
            { "dolutegravir", new ValueWithNote("43560385", "dolutegravir") },
//             { "dolutegravir", new ValueWithNote("43560385", "dolutegravir") }, // confidence: 100.0%, omop match: 100.0%
            { "doxapram", new ValueWithNote("738152", "doxapram") },
//             { "doxapram", new ValueWithNote("738152", "doxapram") }, // confidence: 100.0%, omop match: 100.0%
            { "doxepin", new ValueWithNote("738156", "doxepin") },
//             { "doxepin", new ValueWithNote("738156", "doxepin") }, // confidence: 100.0%, omop match: 100.0%
            { "eftrenonacog alfa", new ValueWithNote("44818493", "coagulation factor ix recombinant immunoglobulin g1 fusion protein") },
//             { "eftrenonacog alfa", new ValueWithNote("44818493", "coagulation factor ix recombinant immunoglobulin g1 fusion protein") }, // confidence: 100.0%, omop match: 100.0%
            { "elexacaftor/ivacaftor/tezacaftor", new ValueWithNote("779006", "elexacaftor / ivacaftor / tezacaftor") },
//             { "elexacaftor/ivacaftor/tezacaftor", new ValueWithNote("779006", "elexacaftor / ivacaftor / tezacaftor") }, // confidence: 100.0%, omop match: 100.0%
            { "diethylamine salicylate", new ValueWithNote("19029278", "diethylamine salicylate") },
//             { "diethylamine salicylate", new ValueWithNote("19029278", "diethylamine salicylate") }, // confidence: 100.0%, omop match: 100.0%
            { "colestipol", new ValueWithNote("1501617", "colestipol") },
//             { "colestipol", new ValueWithNote("1501617", "colestipol") }, // confidence: 100.0%, omop match: 100.0%
            { "empagliflozin", new ValueWithNote("45774751", "empagliflozin") },
//             { "empagliflozin", new ValueWithNote("45774751", "empagliflozin") }, // confidence: 100.0%, omop match: 100.0%
            { "dulaglutide", new ValueWithNote("45774435", "dulaglutide") },
//             { "dulaglutide", new ValueWithNote("45774435", "dulaglutide") }, // confidence: 100.0%, omop match: 100.0%
            { "efgartigimod alfa", new ValueWithNote("702468", "efgartigimod alfa") },
//             { "efgartigimod alfa", new ValueWithNote("702468", "efgartigimod alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "cyanocobalamin", new ValueWithNote("1308738", "vitamin b12") },
//             { "cyanocobalamin", new ValueWithNote("1308738", "vitamin b12") }, // confidence: 100.0%, omop match: 100.0%
            { "danaparoid", new ValueWithNote("19026343", "danaparoid") },
//             { "danaparoid", new ValueWithNote("19026343", "danaparoid") }, // confidence: 100.0%, omop match: 100.0%
            { "eltrombopag", new ValueWithNote("19012346", "eltrombopag") },
//             { "eltrombopag", new ValueWithNote("19012346", "eltrombopag") }, // confidence: 100.0%, omop match: 100.0%
            { "dantrolene", new ValueWithNote("711714", "dantrolene") },
//             { "dantrolene", new ValueWithNote("711714", "dantrolene") }, // confidence: 100.0%, omop match: 100.0%
            { "deflazacort", new ValueWithNote("19086888", "deflazacort") },
//             { "deflazacort", new ValueWithNote("19086888", "deflazacort") }, // confidence: 100.0%, omop match: 100.0%
            { "dalbavancin", new ValueWithNote("45774861", "dalbavancin") },
//             { "dalbavancin", new ValueWithNote("45774861", "dalbavancin") }, // confidence: 100.0%, omop match: 100.0%
            { "eplerenone", new ValueWithNote("1309799", "eplerenone") },
//             { "eplerenone", new ValueWithNote("1309799", "eplerenone") }, // confidence: 100.0%, omop match: 100.0%
            { "diflucortolone", new ValueWithNote("19026096", "diflucortolone") },
//             { "diflucortolone", new ValueWithNote("19026096", "diflucortolone") }, // confidence: 100.0%, omop match: 100.0%
            { "esmolol", new ValueWithNote("19063575", "esmolol") },
//             { "esmolol", new ValueWithNote("19063575", "esmolol") }, // confidence: 100.0%, omop match: 100.0%
            { "etelcalcetide", new ValueWithNote("1593331", "etelcalcetide") },
//             { "etelcalcetide", new ValueWithNote("1593331", "etelcalcetide") }, // confidence: 100.0%, omop match: 100.0%
            { "entecavir", new ValueWithNote("1711246", "entecavir") },
//             { "entecavir", new ValueWithNote("1711246", "entecavir") }, // confidence: 100.0%, omop match: 100.0%
            { "epirubicin", new ValueWithNote("1344354", "epirubicin") },
//             { "epirubicin", new ValueWithNote("1344354", "epirubicin") }, // confidence: 100.0%, omop match: 100.0%
            { "diltiazem", new ValueWithNote("1328165", "diltiazem") },
//             { "diltiazem", new ValueWithNote("1328165", "diltiazem") }, // confidence: 100.0%, omop match: 100.0%
            { "deferasirox", new ValueWithNote("40127988", "deferasirox") },
//             { "deferasirox", new ValueWithNote("40127988", "deferasirox") }, // confidence: 100.0%, omop match: 100.0%
            { "defibrotide", new ValueWithNote("42898933", "defibrotide") },
//             { "defibrotide", new ValueWithNote("42898933", "defibrotide") }, // confidence: 100.0%, omop match: 100.0%
            { "eprosartan", new ValueWithNote("1346686", "eprosartan") },
//             { "eprosartan", new ValueWithNote("1346686", "eprosartan") }, // confidence: 100.0%, omop match: 100.0%
            { "eptacog alfa", new ValueWithNote("19065771", "eptacog alfa activated") },
//             { "eptacog alfa", new ValueWithNote("19065771", "eptacog alfa activated") }, // confidence: 100.0%, omop match: 100.0%
            { "disopyramide", new ValueWithNote("1335606", "disopyramide") },
//             { "disopyramide", new ValueWithNote("1335606", "disopyramide") }, // confidence: 100.0%, omop match: 100.0%
            { "etomidate", new ValueWithNote("19050488", "etomidate") },
//             { "etomidate", new ValueWithNote("19050488", "etomidate") }, // confidence: 100.0%, omop match: 100.0%
            { "ferrous fumarate", new ValueWithNote("1595799", "ferrous fumarate") },
//             { "ferrous fumarate", new ValueWithNote("1595799", "ferrous fumarate") }, // confidence: 100.0%, omop match: 100.0%
            { "delafloxacin", new ValueWithNote("1592954", "delafloxacin") },
//             { "delafloxacin", new ValueWithNote("1592954", "delafloxacin") }, // confidence: 100.0%, omop match: 100.0%
            { "delandistrogene moxeparvovec", new ValueWithNote("746024", "delandistrogene moxeparvovec") },
//             { "delandistrogene moxeparvovec", new ValueWithNote("746024", "delandistrogene moxeparvovec") }, // confidence: 100.0%, omop match: 100.0%
            { "difelikefalin", new ValueWithNote("701764", "difelikefalin") },
//             { "difelikefalin", new ValueWithNote("701764", "difelikefalin") }, // confidence: 100.0%, omop match: 100.0%
            { "denosumab", new ValueWithNote("40222444", "denosumab") },
//             { "denosumab", new ValueWithNote("40222444", "denosumab") }, // confidence: 100.0%, omop match: 100.0%
            { "dipyridamole", new ValueWithNote("1331270", "dipyridamole") },
//             { "dipyridamole", new ValueWithNote("1331270", "dipyridamole") }, // confidence: 100.0%, omop match: 100.0%
            { "docusate", new ValueWithNote("941258", "docusate") },
//             { "docusate", new ValueWithNote("941258", "docusate") }, // confidence: 100.0%, omop match: 100.0%
            { "etonogestrel", new ValueWithNote("1519936", "etonogestrel") },
//             { "etonogestrel", new ValueWithNote("1519936", "etonogestrel") }, // confidence: 100.0%, omop match: 100.0%
            { "etoposide", new ValueWithNote("1350504", "etoposide") },
//             { "etoposide", new ValueWithNote("1350504", "etoposide") }, // confidence: 100.0%, omop match: 100.0%
            { "fludarabine", new ValueWithNote("1395557", "fludarabine") },
//             { "fludarabine", new ValueWithNote("1395557", "fludarabine") }, // confidence: 100.0%, omop match: 100.0%
            { "doxazosin", new ValueWithNote("1363053", "doxazosin") },
//             { "doxazosin", new ValueWithNote("1363053", "doxazosin") }, // confidence: 100.0%, omop match: 100.0%
            { "fosfomycin", new ValueWithNote("956653", "fosfomycin") },
//             { "fosfomycin", new ValueWithNote("956653", "fosfomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "fulvestrant", new ValueWithNote("1304044", "fulvestrant") },
//             { "fulvestrant", new ValueWithNote("1304044", "fulvestrant") }, // confidence: 100.0%, omop match: 100.0%
            { "fampridine", new ValueWithNote("40170680", "dalfampridine") },
//             { "fampridine", new ValueWithNote("40170680", "dalfampridine") }, // confidence: 100.0%, omop match: 100.0%
            { "doxycycline", new ValueWithNote("1738521", "doxycycline") },
//             { "doxycycline", new ValueWithNote("1738521", "doxycycline") }, // confidence: 100.0%, omop match: 100.0%
            { "dronedarone", new ValueWithNote("40163615", "dronedarone") },
//             { "dronedarone", new ValueWithNote("40163615", "dronedarone") }, // confidence: 100.0%, omop match: 100.0%
            { "gentamicin", new ValueWithNote("45892419", "gentamicin") },
//             { "gentamicin", new ValueWithNote("45892419", "gentamicin") }, // confidence: 100.0%, omop match: 100.0%
            { "doravirine", new ValueWithNote("35200446", "doravirine") },
//             { "doravirine", new ValueWithNote("35200446", "doravirine") }, // confidence: 100.0%, omop match: 100.0%
            { "dosulepin", new ValueWithNote("19037989", "dothiepin") },
//             { "dosulepin", new ValueWithNote("19037989", "dothiepin") }, // confidence: 100.0%, omop match: 100.0%
            { "emicizumab", new ValueWithNote("793042", "emicizumab") },
//             { "emicizumab", new ValueWithNote("793042", "emicizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "epoetin alfa", new ValueWithNote("1301125", "epoetin alfa") },
//             { "epoetin alfa", new ValueWithNote("1301125", "epoetin alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "ferrous gluconate", new ValueWithNote("1396012", "ferrous gluconate") },
//             { "ferrous gluconate", new ValueWithNote("1396012", "ferrous gluconate") }, // confidence: 100.0%, omop match: 100.0%
            { "etoricoxib", new ValueWithNote("19011355", "etoricoxib") },
//             { "etoricoxib", new ValueWithNote("19011355", "etoricoxib") }, // confidence: 100.0%, omop match: 100.0%
            { "factor ix", new ValueWithNote("1351935", "factor ix") },
//             { "factor ix", new ValueWithNote("1351935", "factor ix") }, // confidence: 100.0%, omop match: 100.0%
            { "ergocalciferol", new ValueWithNote("19045045", "ergocalciferol") },
//             { "ergocalciferol", new ValueWithNote("19045045", "ergocalciferol") }, // confidence: 100.0%, omop match: 100.0%
            { "fidaxomicin", new ValueWithNote("40239985", "fidaxomicin") },
//             { "fidaxomicin", new ValueWithNote("40239985", "fidaxomicin") }, // confidence: 100.0%, omop match: 100.0%
            { "filgotinib", new ValueWithNote("35891916", "filgotinib") },
//             { "filgotinib", new ValueWithNote("35891916", "filgotinib") }, // confidence: 100.0%, omop match: 100.0%
            { "edoxaban", new ValueWithNote("45892847", "edoxaban") },
//             { "edoxaban", new ValueWithNote("45892847", "edoxaban") }, // confidence: 100.0%, omop match: 100.0%
            { "esomeprazole", new ValueWithNote("904453", "esomeprazole") },
//             { "esomeprazole", new ValueWithNote("904453", "esomeprazole") }, // confidence: 100.0%, omop match: 100.0%
            { "fingolimod", new ValueWithNote("40226579", "fingolimod") },
//             { "fingolimod", new ValueWithNote("40226579", "fingolimod") }, // confidence: 100.0%, omop match: 100.0%
            { "flumazenil", new ValueWithNote("19055153", "flumazenil") },
//             { "flumazenil", new ValueWithNote("19055153", "flumazenil") }, // confidence: 100.0%, omop match: 100.0%
            { "efavirenz", new ValueWithNote("1738135", "efavirenz") },
//             { "efavirenz", new ValueWithNote("1738135", "efavirenz") }, // confidence: 100.0%, omop match: 100.0%
            { "eflornithine", new ValueWithNote("978236", "eflornithine") },
//             { "eflornithine", new ValueWithNote("978236", "eflornithine") }, // confidence: 100.0%, omop match: 100.0%
            { "flurbiprofen", new ValueWithNote("1156378", "flurbiprofen") },
//             { "flurbiprofen", new ValueWithNote("1156378", "flurbiprofen") }, // confidence: 100.0%, omop match: 100.0%
            { "flutamide", new ValueWithNote("1356461", "flutamide") },
//             { "flutamide", new ValueWithNote("1356461", "flutamide") }, // confidence: 100.0%, omop match: 100.0%
            { "efmoroctocog alfa", new ValueWithNote("45776421", "efmoroctocog alfa") },
//             { "efmoroctocog alfa", new ValueWithNote("45776421", "efmoroctocog alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "eletriptan", new ValueWithNote("1189697", "eletriptan") },
//             { "eletriptan", new ValueWithNote("1189697", "eletriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "diethylstilbestrol", new ValueWithNote("1525866", "diethylstilbestrol") },
//             { "diethylstilbestrol", new ValueWithNote("1525866", "diethylstilbestrol") }, // confidence: 100.0%, omop match: 100.0%
            { "glimepiride", new ValueWithNote("1597756", "glimepiride") },
//             { "glimepiride", new ValueWithNote("1597756", "glimepiride") }, // confidence: 100.0%, omop match: 100.0%
            { "desferrioxamine", new ValueWithNote("1711947", "deferoxamine") },
//             { "desferrioxamine", new ValueWithNote("1711947", "deferoxamine") }, // confidence: 100.0%, omop match: 100.0%
            { "dimethyl fumarate", new ValueWithNote("43526424", "dimethyl fumarate") },
//             { "dimethyl fumarate", new ValueWithNote("43526424", "dimethyl fumarate") }, // confidence: 100.0%, omop match: 100.0%
            { "disulfiram", new ValueWithNote("735850", "disulfiram") },
//             { "disulfiram", new ValueWithNote("735850", "disulfiram") }, // confidence: 100.0%, omop match: 100.0%
            { "fluvastatin", new ValueWithNote("1549686", "fluvastatin") },
//             { "fluvastatin", new ValueWithNote("1549686", "fluvastatin") }, // confidence: 100.0%, omop match: 100.0%
            { "fluvoxamine", new ValueWithNote("751412", "fluvoxamine") },
//             { "fluvoxamine", new ValueWithNote("751412", "fluvoxamine") }, // confidence: 100.0%, omop match: 100.0%
            { "droperidol", new ValueWithNote("739323", "droperidol") },
//             { "droperidol", new ValueWithNote("739323", "droperidol") }, // confidence: 100.0%, omop match: 100.0%
            { "eculizumab", new ValueWithNote("19080458", "eculizumab") },
//             { "eculizumab", new ValueWithNote("19080458", "eculizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "formoterol", new ValueWithNote("1196677", "formoterol") },
//             { "formoterol", new ValueWithNote("1196677", "formoterol") }, // confidence: 100.0%, omop match: 100.0%
            { "enoxaparin", new ValueWithNote("1301025", "enoxaparin") },
//             { "enoxaparin", new ValueWithNote("1301025", "enoxaparin") }, // confidence: 100.0%, omop match: 100.0%
            { "gonadorelin", new ValueWithNote("19089810", "gonadorelin") },
//             { "gonadorelin", new ValueWithNote("19089810", "gonadorelin") }, // confidence: 100.0%, omop match: 100.0%
            { "glycopyrronium", new ValueWithNote("45775571", "glycopyrronium") },
//             { "glycopyrronium", new ValueWithNote("45775571", "glycopyrronium") }, // confidence: 100.0%, omop match: 100.0%
            { "entacapone", new ValueWithNote("782211", "entacapone") },
//             { "entacapone", new ValueWithNote("782211", "entacapone") }, // confidence: 100.0%, omop match: 100.0%
            { "donepezil", new ValueWithNote("715997", "donepezil") },
//             { "donepezil", new ValueWithNote("715997", "donepezil") }, // confidence: 100.0%, omop match: 100.0%
            { "dornase alfa", new ValueWithNote("1125443", "dornase alfa") },
//             { "dornase alfa", new ValueWithNote("1125443", "dornase alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "epoetin beta", new ValueWithNote("19001311", "epoetin beta") },
//             { "epoetin beta", new ValueWithNote("19001311", "epoetin beta") }, // confidence: 100.0%, omop match: 100.0%
            { "epoetin zeta", new ValueWithNote("21014076", "epoetin zeta") },
//             { "epoetin zeta", new ValueWithNote("21014076", "epoetin zeta") }, // confidence: 100.0%, omop match: 100.0%
            { "fentanyl", new ValueWithNote("1154029", "fentanyl") },
//             { "fentanyl", new ValueWithNote("1154029", "fentanyl") }, // confidence: 100.0%, omop match: 100.0%
            { "finasteride", new ValueWithNote("996416", "finasteride") },
//             { "finasteride", new ValueWithNote("996416", "finasteride") }, // confidence: 100.0%, omop match: 100.0%
            { "etodolac", new ValueWithNote("1195492", "etodolac") },
//             { "etodolac", new ValueWithNote("1195492", "etodolac") }, // confidence: 100.0%, omop match: 100.0%
            { "ezetimibe", new ValueWithNote("1526475", "ezetimibe") },
//             { "ezetimibe", new ValueWithNote("1526475", "ezetimibe") }, // confidence: 100.0%, omop match: 100.0%
            { "ertapenem", new ValueWithNote("1717963", "ertapenem") },
//             { "ertapenem", new ValueWithNote("1717963", "ertapenem") }, // confidence: 100.0%, omop match: 100.0%
            { "eslicarbazepine", new ValueWithNote("44507780", "eslicarbazepine") },
//             { "eslicarbazepine", new ValueWithNote("44507780", "eslicarbazepine") }, // confidence: 100.0%, omop match: 100.0%
            { "flavoxate", new ValueWithNote("954853", "flavoxate") },
//             { "flavoxate", new ValueWithNote("954853", "flavoxate") }, // confidence: 100.0%, omop match: 100.0%
            { "flecainide", new ValueWithNote("1354860", "flecainide") },
//             { "flecainide", new ValueWithNote("1354860", "flecainide") }, // confidence: 100.0%, omop match: 100.0%
            { "factor xiii", new ValueWithNote("19106100", "factor xiii") },
//             { "factor xiii", new ValueWithNote("19106100", "factor xiii") }, // confidence: 100.0%, omop match: 100.0%
            { "ferric derisomaltose", new ValueWithNote("37498615", "ferric derisomaltose") },
//             { "ferric derisomaltose", new ValueWithNote("37498615", "ferric derisomaltose") }, // confidence: 100.0%, omop match: 100.0%
            { "ethanol", new ValueWithNote("955372", "ethanol") },
//             { "ethanol", new ValueWithNote("955372", "ethanol") }, // confidence: 100.0%, omop match: 100.0%
            { "ethinylestradiol", new ValueWithNote("1549786", "ethinyl estradiol") },
//             { "ethinylestradiol", new ValueWithNote("1549786", "ethinyl estradiol") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin isophane", new ValueWithNote("46221581", "insulin isophane") },
//             { "insulin isophane", new ValueWithNote("46221581", "insulin isophane") }, // confidence: 100.0%, omop match: 100.0%
            { "enalapril", new ValueWithNote("1341927", "enalapril") },
//             { "enalapril", new ValueWithNote("1341927", "enalapril") }, // confidence: 100.0%, omop match: 100.0%
            { "ephedrine", new ValueWithNote("1143374", "ephedrine") },
//             { "ephedrine", new ValueWithNote("1143374", "ephedrine") }, // confidence: 100.0%, omop match: 100.0%
            { "ferrous sulfate", new ValueWithNote("1396131", "ferrous sulfate") },
//             { "ferrous sulfate", new ValueWithNote("1396131", "ferrous sulfate") }, // confidence: 100.0%, omop match: 100.0%
            { "isavuconazole", new ValueWithNote("35606695", "isavuconazole") },
//             { "isavuconazole", new ValueWithNote("35606695", "isavuconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "isocarboxazid", new ValueWithNote("781705", "isocarboxazid") },
//             { "isocarboxazid", new ValueWithNote("781705", "isocarboxazid") }, // confidence: 100.0%, omop match: 100.0%
            { "epoprostenol", new ValueWithNote("1354118", "epoprostenol") },
//             { "epoprostenol", new ValueWithNote("1354118", "epoprostenol") }, // confidence: 100.0%, omop match: 100.0%
            { "finerenone", new ValueWithNote("1537451", "finerenone") },
//             { "finerenone", new ValueWithNote("1537451", "finerenone") }, // confidence: 100.0%, omop match: 100.0%
            { "flucytosine", new ValueWithNote("1755112", "flucytosine") },
//             { "flucytosine", new ValueWithNote("1755112", "flucytosine") }, // confidence: 100.0%, omop match: 100.0%
            { "isoniazid", new ValueWithNote("1782521", "isoniazid") },
//             { "isoniazid", new ValueWithNote("1782521", "isoniazid") }, // confidence: 100.0%, omop match: 100.0%
            { "felodipine", new ValueWithNote("1353776", "felodipine") },
//             { "felodipine", new ValueWithNote("1353776", "felodipine") }, // confidence: 100.0%, omop match: 100.0%
            { "hydrocortisone", new ValueWithNote("975125", "hydrocortisone") },
//             { "hydrocortisone", new ValueWithNote("975125", "hydrocortisone") }, // confidence: 100.0%, omop match: 100.0%
            { "hydroxyzine", new ValueWithNote("777221", "hydroxyzine") },
//             { "hydroxyzine", new ValueWithNote("777221", "hydroxyzine") }, // confidence: 100.0%, omop match: 100.0%
            { "fluorescein", new ValueWithNote("996625", "fluorescein") },
//             { "fluorescein", new ValueWithNote("996625", "fluorescein") }, // confidence: 100.0%, omop match: 100.0%
            { "etanercept", new ValueWithNote("1151789", "etanercept") },
//             { "etanercept", new ValueWithNote("1151789", "etanercept") }, // confidence: 100.0%, omop match: 100.0%
            { "evolocumab", new ValueWithNote("46287466", "evolocumab") },
//             { "evolocumab", new ValueWithNote("46287466", "evolocumab") }, // confidence: 100.0%, omop match: 100.0%
            { "flupentixol", new ValueWithNote("19055982", "flupenthixol") },
//             { "flupentixol", new ValueWithNote("19055982", "flupenthixol") }, // confidence: 100.0%, omop match: 100.0%
            { "hyoscine", new ValueWithNote("965748", "scopolamine") },
//             { "hyoscine", new ValueWithNote("965748", "scopolamine") }, // confidence: 100.0%, omop match: 100.0%
            { "ibuprofen", new ValueWithNote("1177480", "ibuprofen") },
//             { "ibuprofen", new ValueWithNote("1177480", "ibuprofen") }, // confidence: 100.0%, omop match: 100.0%
            { "fludroxycortide", new ValueWithNote("956266", "flurandrenolide") },
//             { "fludroxycortide", new ValueWithNote("956266", "flurandrenolide") }, // confidence: 100.0%, omop match: 100.0%
            { "flurazepam", new ValueWithNote("756349", "flurazepam") },
//             { "flurazepam", new ValueWithNote("756349", "flurazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "isosorbide mononitrate", new ValueWithNote("19069136", "isosorbide mononitrate") },
//             { "isosorbide mononitrate", new ValueWithNote("19069136", "isosorbide mononitrate") }, // confidence: 100.0%, omop match: 100.0%
            { "ivabradine", new ValueWithNote("46234437", "ivabradine") },
//             { "ivabradine", new ValueWithNote("46234437", "ivabradine") }, // confidence: 100.0%, omop match: 100.0%
            { "inclisiran", new ValueWithNote("1758562", "inclisiran") },
//             { "inclisiran", new ValueWithNote("1758562", "inclisiran") }, // confidence: 100.0%, omop match: 100.0%
            { "fosaprepitant", new ValueWithNote("35605594", "fosaprepitant") },
//             { "fosaprepitant", new ValueWithNote("35605594", "fosaprepitant") }, // confidence: 100.0%, omop match: 100.0%
            { "ergometrine", new ValueWithNote("1345205", "ergonovine") },
//             { "ergometrine", new ValueWithNote("1345205", "ergonovine") }, // confidence: 100.0%, omop match: 100.0%
            { "indocyanine green", new ValueWithNote("19078612", "indocyanine green") },
//             { "indocyanine green", new ValueWithNote("19078612", "indocyanine green") }, // confidence: 100.0%, omop match: 100.0%
            { "indometacin", new ValueWithNote("1178663", "indomethacin") },
//             { "indometacin", new ValueWithNote("1178663", "indomethacin") }, // confidence: 100.0%, omop match: 100.0%
            { "fluticasone", new ValueWithNote("1149380", "fluticasone") },
//             { "fluticasone", new ValueWithNote("1149380", "fluticasone") }, // confidence: 100.0%, omop match: 100.0%
            { "fomepizole", new ValueWithNote("19022479", "fomepizole") },
//             { "fomepizole", new ValueWithNote("19022479", "fomepizole") }, // confidence: 100.0%, omop match: 100.0%
            { "factor viii", new ValueWithNote("1352213", "factor viii") },
//             { "factor viii", new ValueWithNote("1352213", "factor viii") }, // confidence: 100.0%, omop match: 100.0%
            { "factor viii inhibitor bypassing fraction", new ValueWithNote("19080406", "anti-inhibitor coagulant complex") },
//             { "factor viii inhibitor bypassing fraction", new ValueWithNote("19080406", "anti-inhibitor coagulant complex") }, // confidence: 100.0%, omop match: 100.0%
            { "fludrocortisone", new ValueWithNote("1555120", "fludrocortisone") },
//             { "fludrocortisone", new ValueWithNote("1555120", "fludrocortisone") }, // confidence: 100.0%, omop match: 100.0%
            { "fluorouracil", new ValueWithNote("955632", "fluorouracil") },
//             { "fluorouracil", new ValueWithNote("955632", "fluorouracil") }, // confidence: 100.0%, omop match: 100.0%
            { "foscarnet", new ValueWithNote("1724700", "foscarnet") },
//             { "foscarnet", new ValueWithNote("1724700", "foscarnet") }, // confidence: 100.0%, omop match: 100.0%
            { "folic acid", new ValueWithNote("19111620", "folic acid") },
//             { "folic acid", new ValueWithNote("19111620", "folic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "frovatriptan", new ValueWithNote("1189458", "frovatriptan") },
//             { "frovatriptan", new ValueWithNote("1189458", "frovatriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "glatiramer", new ValueWithNote("751889", "glatiramer") },
//             { "glatiramer", new ValueWithNote("751889", "glatiramer") }, // confidence: 100.0%, omop match: 100.0%
            { "glipizide", new ValueWithNote("1560171", "glipizide") },
//             { "glipizide", new ValueWithNote("1560171", "glipizide") }, // confidence: 100.0%, omop match: 100.0%
            { "famciclovir", new ValueWithNote("1703603", "famciclovir") },
//             { "famciclovir", new ValueWithNote("1703603", "famciclovir") }, // confidence: 100.0%, omop match: 100.0%
            { "famotidine", new ValueWithNote("953076", "famotidine") },
//             { "famotidine", new ValueWithNote("953076", "famotidine") }, // confidence: 100.0%, omop match: 100.0%
            { "ketamine", new ValueWithNote("785649", "ketamine") },
//             { "ketamine", new ValueWithNote("785649", "ketamine") }, // confidence: 100.0%, omop match: 100.0%
            { "ketotifen", new ValueWithNote("986117", "ketotifen") },
//             { "ketotifen", new ValueWithNote("986117", "ketotifen") }, // confidence: 100.0%, omop match: 100.0%
            { "gefitinib", new ValueWithNote("1319193", "gefitinib") },
//             { "gefitinib", new ValueWithNote("1319193", "gefitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "inebilizumab", new ValueWithNote("1146077", "inebilizumab") },
//             { "inebilizumab", new ValueWithNote("1146077", "inebilizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "escitalopram", new ValueWithNote("715939", "escitalopram") },
//             { "escitalopram", new ValueWithNote("715939", "escitalopram") }, // confidence: 100.0%, omop match: 100.0%
            { "estradiol", new ValueWithNote("1548195", "estradiol") },
//             { "estradiol", new ValueWithNote("1548195", "estradiol") }, // confidence: 100.0%, omop match: 100.0%
            { "fexofenadine", new ValueWithNote("1153428", "fexofenadine") },
//             { "fexofenadine", new ValueWithNote("1153428", "fexofenadine") }, // confidence: 100.0%, omop match: 100.0%
            { "hemin", new ValueWithNote("19067303", "hemin") },
//             { "hemin", new ValueWithNote("19067303", "hemin") }, // confidence: 100.0%, omop match: 100.0%
            { "heparin", new ValueWithNote("1367571", "heparin") },
//             { "heparin", new ValueWithNote("1367571", "heparin") }, // confidence: 100.0%, omop match: 100.0%
            { "gliclazide", new ValueWithNote("19059796", "gliclazide") },
//             { "gliclazide", new ValueWithNote("19059796", "gliclazide") }, // confidence: 100.0%, omop match: 100.0%
            { "fibrinogen", new ValueWithNote("19054702", "fibrinogen") },
//             { "fibrinogen", new ValueWithNote("19054702", "fibrinogen") }, // confidence: 100.0%, omop match: 100.0%
            { "interferon beta-1a", new ValueWithNote("722424", "interferon beta-1a") },
//             { "interferon beta-1a", new ValueWithNote("722424", "interferon beta-1a") }, // confidence: 100.0%, omop match: 100.0%
            { "estriol", new ValueWithNote("19049038", "estriol") },
//             { "estriol", new ValueWithNote("19049038", "estriol") }, // confidence: 100.0%, omop match: 100.0%
            { "iohexol", new ValueWithNote("19080985", "iohexol") },
//             { "iohexol", new ValueWithNote("19080985", "iohexol") }, // confidence: 100.0%, omop match: 100.0%
            { "fluocinolone", new ValueWithNote("996541", "fluocinolone") },
//             { "fluocinolone", new ValueWithNote("996541", "fluocinolone") }, // confidence: 100.0%, omop match: 100.0%
            { "leuprorelin", new ValueWithNote("1351541", "leuprolide") },
//             { "leuprorelin", new ValueWithNote("1351541", "leuprolide") }, // confidence: 100.0%, omop match: 100.0%
            { "ethosuximide", new ValueWithNote("750119", "ethosuximide") },
//             { "ethosuximide", new ValueWithNote("750119", "ethosuximide") }, // confidence: 100.0%, omop match: 100.0%
            { "exenatide", new ValueWithNote("1583722", "exenatide") },
//             { "exenatide", new ValueWithNote("1583722", "exenatide") }, // confidence: 100.0%, omop match: 100.0%
            { "fenofibrate", new ValueWithNote("1551803", "fenofibrate") },
//             { "fenofibrate", new ValueWithNote("1551803", "fenofibrate") }, // confidence: 100.0%, omop match: 100.0%
            { "fluoxetine", new ValueWithNote("755695", "fluoxetine") },
//             { "fluoxetine", new ValueWithNote("755695", "fluoxetine") }, // confidence: 100.0%, omop match: 100.0%
            { "fondaparinux", new ValueWithNote("1315865", "fondaparinux") },
//             { "fondaparinux", new ValueWithNote("1315865", "fondaparinux") }, // confidence: 100.0%, omop match: 100.0%
            { "iron dextran", new ValueWithNote("1381661", "iron-dextran complex") },
//             { "iron dextran", new ValueWithNote("1381661", "iron-dextran complex") }, // confidence: 100.0%, omop match: 100.0%
            { "isotretinoin", new ValueWithNote("984232", "isotretinoin") },
//             { "isotretinoin", new ValueWithNote("984232", "isotretinoin") }, // confidence: 100.0%, omop match: 100.0%
            { "letermovir", new ValueWithNote("792929", "letermovir") },
//             { "letermovir", new ValueWithNote("792929", "letermovir") }, // confidence: 100.0%, omop match: 100.0%
            { "furosemide", new ValueWithNote("956874", "furosemide") },
//             { "furosemide", new ValueWithNote("956874", "furosemide") }, // confidence: 100.0%, omop match: 100.0%
            { "linaclotide", new ValueWithNote("42900505", "linaclotide") },
//             { "linaclotide", new ValueWithNote("42900505", "linaclotide") }, // confidence: 100.0%, omop match: 100.0%
            { "levofloxacin", new ValueWithNote("1742253", "levofloxacin") },
//             { "levofloxacin", new ValueWithNote("1742253", "levofloxacin") }, // confidence: 100.0%, omop match: 100.0%
            { "linagliptin", new ValueWithNote("40239216", "linagliptin") },
//             { "linagliptin", new ValueWithNote("40239216", "linagliptin") }, // confidence: 100.0%, omop match: 100.0%
            { "gabapentin", new ValueWithNote("797399", "gabapentin") },
//             { "gabapentin", new ValueWithNote("797399", "gabapentin") }, // confidence: 100.0%, omop match: 100.0%
            { "golimumab", new ValueWithNote("19041065", "golimumab") },
//             { "golimumab", new ValueWithNote("19041065", "golimumab") }, // confidence: 100.0%, omop match: 100.0%
            { "hydroxychloroquine", new ValueWithNote("1777087", "hydroxychloroquine") },
//             { "hydroxychloroquine", new ValueWithNote("1777087", "hydroxychloroquine") }, // confidence: 100.0%, omop match: 100.0%
            { "idarucizumab", new ValueWithNote("35602981", "idarucizumab") },
//             { "idarucizumab", new ValueWithNote("35602981", "idarucizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "imlifidase", new ValueWithNote("35894914", "imlifidase") },
//             { "imlifidase", new ValueWithNote("35894914", "imlifidase") }, // confidence: 100.0%, omop match: 100.0%
            { "lomustine", new ValueWithNote("1391846", "lomustine") },
//             { "lomustine", new ValueWithNote("1391846", "lomustine") }, // confidence: 100.0%, omop match: 100.0%
            { "gelatin", new ValueWithNote("19058092", "gelatin") },
//             { "gelatin", new ValueWithNote("19058092", "gelatin") }, // confidence: 100.0%, omop match: 100.0%
            { "granisetron", new ValueWithNote("1000772", "granisetron") },
//             { "granisetron", new ValueWithNote("1000772", "granisetron") }, // confidence: 100.0%, omop match: 100.0%
            { "interferon gamma-1b", new ValueWithNote("1380191", "interferon gamma-1b") },
//             { "interferon gamma-1b", new ValueWithNote("1380191", "interferon gamma-1b") }, // confidence: 100.0%, omop match: 100.0%
            { "menadiol", new ValueWithNote("19009057", "menadiol") },
//             { "menadiol", new ValueWithNote("19009057", "menadiol") }, // confidence: 100.0%, omop match: 100.0%
            { "lofepramine", new ValueWithNote("19091830", "lofepramine") },
//             { "lofepramine", new ValueWithNote("19091830", "lofepramine") }, // confidence: 100.0%, omop match: 100.0%
            { "ferric carboxymaltose", new ValueWithNote("43560392", "ferric carboxymaltose") },
//             { "ferric carboxymaltose", new ValueWithNote("43560392", "ferric carboxymaltose") }, // confidence: 100.0%, omop match: 100.0%
            { "glycine irrigation", new ValueWithNote("40046876", "glycine irrigation solution") },
//             { "glycine irrigation", new ValueWithNote("40046876", "glycine irrigation solution") }, // confidence: 100.0%, omop match: 100.0%
            { "goserelin", new ValueWithNote("1366310", "goserelin") },
//             { "goserelin", new ValueWithNote("1366310", "goserelin") }, // confidence: 100.0%, omop match: 100.0%
            { "melphalan", new ValueWithNote("1301267", "melphalan") },
//             { "melphalan", new ValueWithNote("1301267", "melphalan") }, // confidence: 100.0%, omop match: 100.0%
            { "fluconazole", new ValueWithNote("1754994", "fluconazole") },
//             { "fluconazole", new ValueWithNote("1754994", "fluconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "metronidazole", new ValueWithNote("1707164", "metronidazole") },
//             { "metronidazole", new ValueWithNote("1707164", "metronidazole") }, // confidence: 100.0%, omop match: 100.0%
            { "minocycline", new ValueWithNote("1708880", "minocycline") },
//             { "minocycline", new ValueWithNote("1708880", "minocycline") }, // confidence: 100.0%, omop match: 100.0%
            { "fluticasone/umeclidinium/vilanterol", new ValueWithNote("778971", "fluticasone / umeclidinium / vilanterol") },
//             { "fluticasone/umeclidinium/vilanterol", new ValueWithNote("778971", "fluticasone / umeclidinium / vilanterol") }, // confidence: 100.0%, omop match: 100.0%
            { "hexaminolevulinate", new ValueWithNote("43532423", "hexyl 5-aminolevulinate") },
//             { "hexaminolevulinate", new ValueWithNote("43532423", "hexyl 5-aminolevulinate") }, // confidence: 100.0%, omop match: 100.0%
            { "lacosamide", new ValueWithNote("19087394", "lacosamide") },
//             { "lacosamide", new ValueWithNote("19087394", "lacosamide") }, // confidence: 100.0%, omop match: 100.0%
            { "galantamine", new ValueWithNote("757627", "galantamine") },
//             { "galantamine", new ValueWithNote("757627", "galantamine") }, // confidence: 100.0%, omop match: 100.0%
            { "nabilone", new ValueWithNote("913440", "nabilone") },
//             { "nabilone", new ValueWithNote("913440", "nabilone") }, // confidence: 100.0%, omop match: 100.0%
            { "nicotinamide", new ValueWithNote("19018419", "niacinamide") },
//             { "nicotinamide", new ValueWithNote("19018419", "niacinamide") }, // confidence: 100.0%, omop match: 100.0%
            { "human cytomegalovirus immunoglobulin", new ValueWithNote("963762", "cytomegalovirus immune globulin, human") },
//             { "human cytomegalovirus immunoglobulin", new ValueWithNote("963762", "cytomegalovirus immune globulin, human") }, // confidence: 100.0%, omop match: 100.0%
            { "mepacrine", new ValueWithNote("19060400", "quinacrine") },
//             { "mepacrine", new ValueWithNote("19060400", "quinacrine") }, // confidence: 100.0%, omop match: 100.0%
            { "nilotinib", new ValueWithNote("1394023", "nilotinib") },
//             { "nilotinib", new ValueWithNote("1394023", "nilotinib") }, // confidence: 100.0%, omop match: 100.0%
            { "nintedanib", new ValueWithNote("45775396", "nintedanib") },
//             { "nintedanib", new ValueWithNote("45775396", "nintedanib") }, // confidence: 100.0%, omop match: 100.0%
            { "hydrochlorothiazide", new ValueWithNote("974166", "hydrochlorothiazide") },
//             { "hydrochlorothiazide", new ValueWithNote("974166", "hydrochlorothiazide") }, // confidence: 100.0%, omop match: 100.0%
            { "ganciclovir", new ValueWithNote("1757803", "ganciclovir") },
//             { "ganciclovir", new ValueWithNote("1757803", "ganciclovir") }, // confidence: 100.0%, omop match: 100.0%
            { "ginkgo", new ValueWithNote("1391889", "ginkgo biloba extract") },
//             { "ginkgo", new ValueWithNote("1391889", "ginkgo biloba extract") }, // confidence: 100.0%, omop match: 100.0%
            { "haloperidol", new ValueWithNote("766529", "haloperidol") },
//             { "haloperidol", new ValueWithNote("766529", "haloperidol") }, // confidence: 100.0%, omop match: 100.0%
            { "honey", new ValueWithNote("19071840", "honey preparation") },
//             { "honey", new ValueWithNote("19071840", "honey preparation") }, // confidence: 100.0%, omop match: 100.0%
            { "lenograstim", new ValueWithNote("19009705", "lenograstim") },
//             { "lenograstim", new ValueWithNote("19009705", "lenograstim") }, // confidence: 100.0%, omop match: 100.0%
            { "lercanidipine", new ValueWithNote("19015802", "lercanidipine") },
//             { "lercanidipine", new ValueWithNote("19015802", "lercanidipine") }, // confidence: 100.0%, omop match: 100.0%
            { "methenamine", new ValueWithNote("904356", "methenamine") },
//             { "methenamine", new ValueWithNote("904356", "methenamine") }, // confidence: 100.0%, omop match: 100.0%
            { "letrozole", new ValueWithNote("1315946", "letrozole") },
//             { "letrozole", new ValueWithNote("1315946", "letrozole") }, // confidence: 100.0%, omop match: 100.0%
            { "methylphenidate", new ValueWithNote("705944", "methylphenidate") },
//             { "methylphenidate", new ValueWithNote("705944", "methylphenidate") }, // confidence: 100.0%, omop match: 100.0%
            { "mifepristone", new ValueWithNote("1508439", "mifepristone") },
//             { "mifepristone", new ValueWithNote("1508439", "mifepristone") }, // confidence: 100.0%, omop match: 100.0%
            { "glycerol", new ValueWithNote("961145", "glycerin") },
//             { "glycerol", new ValueWithNote("961145", "glycerin") }, // confidence: 100.0%, omop match: 100.0%
            { "glyceryl trinitrate", new ValueWithNote("1361711", "nitroglycerin") },
//             { "glyceryl trinitrate", new ValueWithNote("1361711", "nitroglycerin") }, // confidence: 100.0%, omop match: 100.0%
            { "mitomycin", new ValueWithNote("1389036", "mitomycin") },
//             { "mitomycin", new ValueWithNote("1389036", "mitomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "mometasone", new ValueWithNote("905233", "mometasone") },
//             { "mometasone", new ValueWithNote("905233", "mometasone") }, // confidence: 100.0%, omop match: 100.0%
            { "glucose", new ValueWithNote("1560524", "glucose") },
//             { "glucose", new ValueWithNote("1560524", "glucose") }, // confidence: 100.0%, omop match: 100.0%
            { "levothyroxine", new ValueWithNote("1501700", "levothyroxine") },
//             { "levothyroxine", new ValueWithNote("1501700", "levothyroxine") }, // confidence: 100.0%, omop match: 100.0%
            { "hydroxocobalamin", new ValueWithNote("1377023", "hydroxocobalamin") },
//             { "hydroxocobalamin", new ValueWithNote("1377023", "hydroxocobalamin") }, // confidence: 100.0%, omop match: 100.0%
            { "hydrogen peroxide", new ValueWithNote("1776430", "hydrogen peroxide") },
//             { "hydrogen peroxide", new ValueWithNote("1776430", "hydrogen peroxide") }, // confidence: 100.0%, omop match: 100.0%
            { "olodaterol", new ValueWithNote("45775116", "olodaterol") },
//             { "olodaterol", new ValueWithNote("45775116", "olodaterol") }, // confidence: 100.0%, omop match: 100.0%
            { "olsalazine", new ValueWithNote("916282", "olsalazine") },
//             { "olsalazine", new ValueWithNote("916282", "olsalazine") }, // confidence: 100.0%, omop match: 100.0%
            { "griseofulvin", new ValueWithNote("1763779", "griseofulvin") },
//             { "griseofulvin", new ValueWithNote("1763779", "griseofulvin") }, // confidence: 100.0%, omop match: 100.0%
            { "liothyronine", new ValueWithNote("1505346", "liothyronine") },
//             { "liothyronine", new ValueWithNote("1505346", "liothyronine") }, // confidence: 100.0%, omop match: 100.0%
            { "mupirocin", new ValueWithNote("951511", "mupirocin") },
//             { "mupirocin", new ValueWithNote("951511", "mupirocin") }, // confidence: 100.0%, omop match: 100.0%
            { "nafarelin", new ValueWithNote("1507558", "nafarelin") },
//             { "nafarelin", new ValueWithNote("1507558", "nafarelin") }, // confidence: 100.0%, omop match: 100.0%
            { "omalizumab", new ValueWithNote("1110942", "omalizumab") },
//             { "omalizumab", new ValueWithNote("1110942", "omalizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "oxytocin", new ValueWithNote("1326115", "oxytocin") },
//             { "oxytocin", new ValueWithNote("1326115", "oxytocin") }, // confidence: 100.0%, omop match: 100.0%
            { "icatibant", new ValueWithNote("40242044", "icatibant") },
//             { "icatibant", new ValueWithNote("40242044", "icatibant") }, // confidence: 100.0%, omop match: 100.0%
            { "imipramine", new ValueWithNote("778268", "imipramine") },
//             { "imipramine", new ValueWithNote("778268", "imipramine") }, // confidence: 100.0%, omop match: 100.0%
            { "hepatitis b immunoglobulin", new ValueWithNote("501343", "hepatitis b immune globulin") },
//             { "hepatitis b immunoglobulin", new ValueWithNote("501343", "hepatitis b immune globulin") }, // confidence: 100.0%, omop match: 100.0%
            { "naftidrofuryl", new ValueWithNote("19014035", "nafronyl") },
//             { "naftidrofuryl", new ValueWithNote("19014035", "nafronyl") }, // confidence: 100.0%, omop match: 100.0%
            { "indoramin", new ValueWithNote("19078808", "indoramin") },
//             { "indoramin", new ValueWithNote("19078808", "indoramin") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin degludec", new ValueWithNote("35602717", "insulin degludec") },
//             { "insulin degludec", new ValueWithNote("35602717", "insulin degludec") }, // confidence: 100.0%, omop match: 100.0%
            { "hexetidine", new ValueWithNote("19068839", "hexetidine") },
//             { "hexetidine", new ValueWithNote("19068839", "hexetidine") }, // confidence: 100.0%, omop match: 100.0%
            { "hydromorphone", new ValueWithNote("1126658", "hydromorphone") },
//             { "hydromorphone", new ValueWithNote("1126658", "hydromorphone") }, // confidence: 100.0%, omop match: 100.0%
            { "loratadine", new ValueWithNote("1107830", "loratadine") },
//             { "loratadine", new ValueWithNote("1107830", "loratadine") }, // confidence: 100.0%, omop match: 100.0%
            { "losartan", new ValueWithNote("1367500", "losartan") },
//             { "losartan", new ValueWithNote("1367500", "losartan") }, // confidence: 100.0%, omop match: 100.0%
            { "isoprenaline", new ValueWithNote("1183554", "isoproterenol") },
//             { "isoprenaline", new ValueWithNote("1183554", "isoproterenol") }, // confidence: 100.0%, omop match: 100.0%
            { "magnesium aspartate", new ValueWithNote("19019131", "magnesium aspartate") },
//             { "magnesium aspartate", new ValueWithNote("19019131", "magnesium aspartate") }, // confidence: 100.0%, omop match: 100.0%
            { "hydralazine", new ValueWithNote("1373928", "hydralazine") },
//             { "hydralazine", new ValueWithNote("1373928", "hydralazine") }, // confidence: 100.0%, omop match: 100.0%
            { "lactulose", new ValueWithNote("987245", "lactulose") },
//             { "lactulose", new ValueWithNote("987245", "lactulose") }, // confidence: 100.0%, omop match: 100.0%
            { "imdevimab", new ValueWithNote("37003293", "imdevimab") },
//             { "imdevimab", new ValueWithNote("37003293", "imdevimab") }, // confidence: 100.0%, omop match: 100.0%
            { "medium chain triglycerides", new ValueWithNote("42899398", "medium chain triglycerides") },
//             { "medium chain triglycerides", new ValueWithNote("42899398", "medium chain triglycerides") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin aspart", new ValueWithNote("1567198", "insulin aspart, human") },
//             { "insulin aspart", new ValueWithNote("1567198", "insulin aspart, human") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin glargine", new ValueWithNote("1502905", "insulin glargine") },
//             { "insulin glargine", new ValueWithNote("1502905", "insulin glargine") }, // confidence: 100.0%, omop match: 100.0%
            { "pegvisomant", new ValueWithNote("1503432", "pegvisomant") },
//             { "pegvisomant", new ValueWithNote("1503432", "pegvisomant") }, // confidence: 100.0%, omop match: 100.0%
            { "pentamidine", new ValueWithNote("1730370", "pentamidine") },
//             { "pentamidine", new ValueWithNote("1730370", "pentamidine") }, // confidence: 100.0%, omop match: 100.0%
            { "ibandronic acid", new ValueWithNote("19011068", "ibandronic acid") },
//             { "ibandronic acid", new ValueWithNote("19011068", "ibandronic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "nicotine", new ValueWithNote("718583", "nicotine") },
//             { "nicotine", new ValueWithNote("718583", "nicotine") }, // confidence: 100.0%, omop match: 100.0%
            { "permethrin", new ValueWithNote("922868", "permethrin") },
//             { "permethrin", new ValueWithNote("922868", "permethrin") }, // confidence: 100.0%, omop match: 100.0%
            { "pimecrolimus", new ValueWithNote("915935", "pimecrolimus") },
//             { "pimecrolimus", new ValueWithNote("915935", "pimecrolimus") }, // confidence: 100.0%, omop match: 100.0%
            { "indapamide", new ValueWithNote("978555", "indapamide") },
//             { "indapamide", new ValueWithNote("978555", "indapamide") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin detemir", new ValueWithNote("1516976", "insulin detemir") },
//             { "insulin detemir", new ValueWithNote("1516976", "insulin detemir") }, // confidence: 100.0%, omop match: 100.0%
            { "nitric oxide", new ValueWithNote("19020068", "nitric oxide") },
//             { "nitric oxide", new ValueWithNote("19020068", "nitric oxide") }, // confidence: 100.0%, omop match: 100.0%
            { "octreotide", new ValueWithNote("1522957", "octreotide") },
//             { "octreotide", new ValueWithNote("1522957", "octreotide") }, // confidence: 100.0%, omop match: 100.0%
            { "plerixafor", new ValueWithNote("19017581", "plerixafor") },
//             { "plerixafor", new ValueWithNote("19017581", "plerixafor") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin lispro", new ValueWithNote("1550023", "insulin lispro") },
//             { "insulin lispro", new ValueWithNote("1550023", "insulin lispro") }, // confidence: 100.0%, omop match: 100.0%
            { "leflunomide", new ValueWithNote("1101898", "leflunomide") },
//             { "leflunomide", new ValueWithNote("1101898", "leflunomide") }, // confidence: 100.0%, omop match: 100.0%
            { "levonorgestrel", new ValueWithNote("1589505", "levonorgestrel") },
//             { "levonorgestrel", new ValueWithNote("1589505", "levonorgestrel") }, // confidence: 100.0%, omop match: 100.0%
            { "olanzapine", new ValueWithNote("785788", "olanzapine") },
//             { "olanzapine", new ValueWithNote("785788", "olanzapine") }, // confidence: 100.0%, omop match: 100.0%
            { "posaconazole", new ValueWithNote("1704139", "posaconazole") },
//             { "posaconazole", new ValueWithNote("1704139", "posaconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "linezolid", new ValueWithNote("1736887", "linezolid") },
//             { "linezolid", new ValueWithNote("1736887", "linezolid") }, // confidence: 100.0%, omop match: 100.0%
            { "olmesartan", new ValueWithNote("40226742", "olmesartan") },
//             { "olmesartan", new ValueWithNote("40226742", "olmesartan") }, // confidence: 100.0%, omop match: 100.0%
            { "orlistat", new ValueWithNote("741530", "orlistat") },
//             { "orlistat", new ValueWithNote("741530", "orlistat") }, // confidence: 100.0%, omop match: 100.0%
            { "ixekizumab", new ValueWithNote("35603563", "ixekizumab") },
//             { "ixekizumab", new ValueWithNote("35603563", "ixekizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "ketoconazole", new ValueWithNote("985708", "ketoconazole") },
//             { "ketoconazole", new ValueWithNote("985708", "ketoconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "ivermectin", new ValueWithNote("1784444", "ivermectin") },
//             { "ivermectin", new ValueWithNote("1784444", "ivermectin") }, // confidence: 100.0%, omop match: 100.0%
            { "labetalol", new ValueWithNote("1386957", "labetalol") },
//             { "labetalol", new ValueWithNote("1386957", "labetalol") }, // confidence: 100.0%, omop match: 100.0%
            { "ketoprofen", new ValueWithNote("1185922", "ketoprofen") },
//             { "ketoprofen", new ValueWithNote("1185922", "ketoprofen") }, // confidence: 100.0%, omop match: 100.0%
            { "lacidipine", new ValueWithNote("19004539", "lacidipine") },
//             { "lacidipine", new ValueWithNote("19004539", "lacidipine") }, // confidence: 100.0%, omop match: 100.0%
            { "lanolin", new ValueWithNote("19087317", "lanolin") },
//             { "lanolin", new ValueWithNote("19087317", "lanolin") }, // confidence: 100.0%, omop match: 100.0%
            { "pravastatin", new ValueWithNote("1551860", "pravastatin") },
//             { "pravastatin", new ValueWithNote("1551860", "pravastatin") }, // confidence: 100.0%, omop match: 100.0%
            { "prazosin", new ValueWithNote("1350489", "prazosin") },
//             { "prazosin", new ValueWithNote("1350489", "prazosin") }, // confidence: 100.0%, omop match: 100.0%
            { "imatinib", new ValueWithNote("1304107", "imatinib") },
//             { "imatinib", new ValueWithNote("1304107", "imatinib") }, // confidence: 100.0%, omop match: 100.0%
            { "imiquimod", new ValueWithNote("981691", "imiquimod") },
//             { "imiquimod", new ValueWithNote("981691", "imiquimod") }, // confidence: 100.0%, omop match: 100.0%
            { "lanreotide", new ValueWithNote("1503501", "lanreotide") },
//             { "lanreotide", new ValueWithNote("1503501", "lanreotide") }, // confidence: 100.0%, omop match: 100.0%
            { "lenalidomide", new ValueWithNote("19026972", "lenalidomide") },
//             { "lenalidomide", new ValueWithNote("19026972", "lenalidomide") }, // confidence: 100.0%, omop match: 100.0%
            { "primaquine", new ValueWithNote("1751310", "primaquine") },
//             { "primaquine", new ValueWithNote("1751310", "primaquine") }, // confidence: 100.0%, omop match: 100.0%
            { "lithium", new ValueWithNote("19124477", "lithium") },
//             { "lithium", new ValueWithNote("19124477", "lithium") }, // confidence: 100.0%, omop match: 100.0%
            { "levobupivacaine", new ValueWithNote("19098741", "levobupivacaine") },
//             { "levobupivacaine", new ValueWithNote("19098741", "levobupivacaine") }, // confidence: 100.0%, omop match: 100.0%
            { "propylthiouracil", new ValueWithNote("1554072", "propylthiouracil") },
//             { "propylthiouracil", new ValueWithNote("1554072", "propylthiouracil") }, // confidence: 100.0%, omop match: 100.0%
            { "pyrazinamide", new ValueWithNote("1759455", "pyrazinamide") },
//             { "pyrazinamide", new ValueWithNote("1759455", "pyrazinamide") }, // confidence: 100.0%, omop match: 100.0%
            { "magnesium oxide", new ValueWithNote("993631", "magnesium oxide") },
//             { "magnesium oxide", new ValueWithNote("993631", "magnesium oxide") }, // confidence: 100.0%, omop match: 100.0%
            { "magnesium sulfate", new ValueWithNote("19093848", "magnesium sulfate") },
//             { "magnesium sulfate", new ValueWithNote("19093848", "magnesium sulfate") }, // confidence: 100.0%, omop match: 100.0%
            { "loprazolam", new ValueWithNote("19042550", "triazulenone") },
//             { "loprazolam", new ValueWithNote("19042550", "triazulenone") }, // confidence: 100.0%, omop match: 100.0%
            { "lymecycline", new ValueWithNote("19092353", "lymecycline") },
//             { "lymecycline", new ValueWithNote("19092353", "lymecycline") }, // confidence: 100.0%, omop match: 100.0%
            { "pyridostigmine", new ValueWithNote("759740", "pyridostigmine") },
//             { "pyridostigmine", new ValueWithNote("759740", "pyridostigmine") }, // confidence: 100.0%, omop match: 100.0%
            { "rabeprazole", new ValueWithNote("911735", "rabeprazole") },
//             { "rabeprazole", new ValueWithNote("911735", "rabeprazole") }, // confidence: 100.0%, omop match: 100.0%
            { "melatonin", new ValueWithNote("1301152", "melatonin") },
//             { "melatonin", new ValueWithNote("1301152", "melatonin") }, // confidence: 100.0%, omop match: 100.0%
            { "mesna", new ValueWithNote("1354698", "mesna") },
//             { "mesna", new ValueWithNote("1354698", "mesna") }, // confidence: 100.0%, omop match: 100.0%
            { "lamotrigine", new ValueWithNote("705103", "lamotrigine") },
//             { "lamotrigine", new ValueWithNote("705103", "lamotrigine") }, // confidence: 100.0%, omop match: 100.0%
            { "paracetamol", new ValueWithNote("1125315", "acetaminophen") },
//             { "paracetamol", new ValueWithNote("1125315", "acetaminophen") }, // confidence: 100.0%, omop match: 100.0%
            { "insulin glulisine", new ValueWithNote("1544838", "insulin glulisine, human") },
//             { "insulin glulisine", new ValueWithNote("1544838", "insulin glulisine, human") }, // confidence: 100.0%, omop match: 100.0%
            { "irbesartan", new ValueWithNote("1347384", "irbesartan") },
//             { "irbesartan", new ValueWithNote("1347384", "irbesartan") }, // confidence: 100.0%, omop match: 100.0%
            { "mebeverine", new ValueWithNote("19008994", "mebeverine") },
//             { "mebeverine", new ValueWithNote("19008994", "mebeverine") }, // confidence: 100.0%, omop match: 100.0%
            { "magnesium citrate", new ValueWithNote("967861", "magnesium citrate") },
//             { "magnesium citrate", new ValueWithNote("967861", "magnesium citrate") }, // confidence: 100.0%, omop match: 100.0%
            { "ramipril", new ValueWithNote("1334456", "ramipril") },
//             { "ramipril", new ValueWithNote("1334456", "ramipril") }, // confidence: 100.0%, omop match: 100.0%
            { "remdesivir", new ValueWithNote("37499271", "remdesivir") },
//             { "remdesivir", new ValueWithNote("37499271", "remdesivir") }, // confidence: 100.0%, omop match: 100.0%
            { "methyl salicylate", new ValueWithNote("909440", "methyl salicylate") },
//             { "methyl salicylate", new ValueWithNote("909440", "methyl salicylate") }, // confidence: 100.0%, omop match: 100.0%
            { "miconazole", new ValueWithNote("907879", "miconazole") },
//             { "miconazole", new ValueWithNote("907879", "miconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "levomepromazine", new ValueWithNote("19005147", "methotrimeprazine") },
//             { "levomepromazine", new ValueWithNote("19005147", "methotrimeprazine") }, // confidence: 100.0%, omop match: 100.0%
            { "lidocaine", new ValueWithNote("989878", "lidocaine") },
//             { "lidocaine", new ValueWithNote("989878", "lidocaine") }, // confidence: 100.0%, omop match: 100.0%
            { "ribavirin", new ValueWithNote("1762711", "ribavirin") },
//             { "ribavirin", new ValueWithNote("1762711", "ribavirin") }, // confidence: 100.0%, omop match: 100.0%
            { "rifampicin", new ValueWithNote("1763204", "rifampin") },
//             { "rifampicin", new ValueWithNote("1763204", "rifampin") }, // confidence: 100.0%, omop match: 100.0%
            { "methocarbamol", new ValueWithNote("704943", "methocarbamol") },
//             { "methocarbamol", new ValueWithNote("704943", "methocarbamol") }, // confidence: 100.0%, omop match: 100.0%
            { "methylnaltrexone", new ValueWithNote("909841", "methylnaltrexone") },
//             { "methylnaltrexone", new ValueWithNote("909841", "methylnaltrexone") }, // confidence: 100.0%, omop match: 100.0%
            { "paricalcitol", new ValueWithNote("1517740", "paricalcitol") },
//             { "paricalcitol", new ValueWithNote("1517740", "paricalcitol") }, // confidence: 100.0%, omop match: 100.0%
            { "perindopril", new ValueWithNote("1373225", "perindopril") },
//             { "perindopril", new ValueWithNote("1373225", "perindopril") }, // confidence: 100.0%, omop match: 100.0%
            { "isosorbide dinitrate", new ValueWithNote("1383925", "isosorbide dinitrate") },
//             { "isosorbide dinitrate", new ValueWithNote("1383925", "isosorbide dinitrate") }, // confidence: 100.0%, omop match: 100.0%
            { "ispaghula", new ValueWithNote("19132967", "ispaghula extract") },
//             { "ispaghula", new ValueWithNote("19132967", "ispaghula extract") }, // confidence: 100.0%, omop match: 100.0%
            { "mirtazapine", new ValueWithNote("725131", "mirtazapine") },
//             { "mirtazapine", new ValueWithNote("725131", "mirtazapine") }, // confidence: 100.0%, omop match: 100.0%
            { "misoprostol", new ValueWithNote("1150871", "misoprostol") },
//             { "misoprostol", new ValueWithNote("1150871", "misoprostol") }, // confidence: 100.0%, omop match: 100.0%
            { "liraglutide", new ValueWithNote("40170911", "liraglutide") },
//             { "liraglutide", new ValueWithNote("40170911", "liraglutide") }, // confidence: 100.0%, omop match: 100.0%
            { "lisinopril", new ValueWithNote("1308216", "lisinopril") },
//             { "lisinopril", new ValueWithNote("1308216", "lisinopril") }, // confidence: 100.0%, omop match: 100.0%
            { "rilpivirine", new ValueWithNote("40238930", "rilpivirine") },
//             { "rilpivirine", new ValueWithNote("40238930", "rilpivirine") }, // confidence: 100.0%, omop match: 100.0%
            { "micafungin", new ValueWithNote("19018013", "micafungin") },
//             { "micafungin", new ValueWithNote("19018013", "micafungin") }, // confidence: 100.0%, omop match: 100.0%
            { "lixisenatide", new ValueWithNote("44506754", "lixisenatide") },
//             { "lixisenatide", new ValueWithNote("44506754", "lixisenatide") }, // confidence: 100.0%, omop match: 100.0%
            { "loperamide", new ValueWithNote("991876", "loperamide") },
//             { "loperamide", new ValueWithNote("991876", "loperamide") }, // confidence: 100.0%, omop match: 100.0%
            { "lorazepam", new ValueWithNote("791967", "lorazepam") },
//             { "lorazepam", new ValueWithNote("791967", "lorazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "lormetazepam", new ValueWithNote("19007977", "lormetazepam") },
//             { "lormetazepam", new ValueWithNote("19007977", "lormetazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "rocuronium", new ValueWithNote("19003953", "rocuronium") },
//             { "rocuronium", new ValueWithNote("19003953", "rocuronium") }, // confidence: 100.0%, omop match: 100.0%
            { "ivacaftor", new ValueWithNote("42709323", "ivacaftor") },
//             { "ivacaftor", new ValueWithNote("42709323", "ivacaftor") }, // confidence: 100.0%, omop match: 100.0%
            { "naldemedine", new ValueWithNote("1593619", "naldemedine") },
//             { "naldemedine", new ValueWithNote("1593619", "naldemedine") }, // confidence: 100.0%, omop match: 100.0%
            { "mannitol", new ValueWithNote("994058", "mannitol") },
//             { "mannitol", new ValueWithNote("994058", "mannitol") }, // confidence: 100.0%, omop match: 100.0%
            { "ketorolac", new ValueWithNote("1136980", "ketorolac") },
//             { "ketorolac", new ValueWithNote("1136980", "ketorolac") }, // confidence: 100.0%, omop match: 100.0%
            { "morphine", new ValueWithNote("1110410", "morphine") },
//             { "morphine", new ValueWithNote("1110410", "morphine") }, // confidence: 100.0%, omop match: 100.0%
            { "naloxegol", new ValueWithNote("45774613", "naloxegol") },
//             { "naloxegol", new ValueWithNote("45774613", "naloxegol") }, // confidence: 100.0%, omop match: 100.0%
            { "romosozumab", new ValueWithNote("1511251", "romosozumab") },
//             { "romosozumab", new ValueWithNote("1511251", "romosozumab") }, // confidence: 100.0%, omop match: 100.0%
            { "rufinamide", new ValueWithNote("19006586", "rufinamide") },
//             { "rufinamide", new ValueWithNote("19006586", "rufinamide") }, // confidence: 100.0%, omop match: 100.0%
            { "lansoprazole", new ValueWithNote("929887", "lansoprazole") },
//             { "lansoprazole", new ValueWithNote("929887", "lansoprazole") }, // confidence: 100.0%, omop match: 100.0%
            { "lanthanum carbonate", new ValueWithNote("990028", "lanthanum carbonate") },
//             { "lanthanum carbonate", new ValueWithNote("990028", "lanthanum carbonate") }, // confidence: 100.0%, omop match: 100.0%
            { "malathion", new ValueWithNote("993979", "malathion") },
//             { "malathion", new ValueWithNote("993979", "malathion") }, // confidence: 100.0%, omop match: 100.0%
            { "medroxyprogesterone", new ValueWithNote("1500211", "medroxyprogesterone") },
//             { "medroxyprogesterone", new ValueWithNote("1500211", "medroxyprogesterone") }, // confidence: 100.0%, omop match: 100.0%
            { "megestrol", new ValueWithNote("1300978", "megestrol") },
//             { "megestrol", new ValueWithNote("1300978", "megestrol") }, // confidence: 100.0%, omop match: 100.0%
            { "menthol", new ValueWithNote("901656", "menthol") },
//             { "menthol", new ValueWithNote("901656", "menthol") }, // confidence: 100.0%, omop match: 100.0%
            { "mepolizumab", new ValueWithNote("35606631", "mepolizumab") },
//             { "mepolizumab", new ValueWithNote("35606631", "mepolizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "metaraminol", new ValueWithNote("19003303", "metaraminol") },
//             { "metaraminol", new ValueWithNote("19003303", "metaraminol") }, // confidence: 100.0%, omop match: 100.0%
            { "salmeterol", new ValueWithNote("1137529", "salmeterol") },
//             { "salmeterol", new ValueWithNote("1137529", "salmeterol") }, // confidence: 100.0%, omop match: 100.0%
            { "neomycin", new ValueWithNote("915981", "neomycin") },
//             { "neomycin", new ValueWithNote("915981", "neomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "nirsevimab", new ValueWithNote("746155", "nirsevimab") },
//             { "nirsevimab", new ValueWithNote("746155", "nirsevimab") }, // confidence: 100.0%, omop match: 100.0%
            { "nusinersen", new ValueWithNote("1593031", "nusinersen") },
//             { "nusinersen", new ValueWithNote("1593031", "nusinersen") }, // confidence: 100.0%, omop match: 100.0%
            { "methadone", new ValueWithNote("1103640", "methadone") },
//             { "methadone", new ValueWithNote("1103640", "methadone") }, // confidence: 100.0%, omop match: 100.0%
            { "plasma protein fraction", new ValueWithNote("19025693", "plasma protein fraction") },
//             { "plasma protein fraction", new ValueWithNote("19025693", "plasma protein fraction") }, // confidence: 100.0%, omop match: 100.0%
            { "oxcarbazepine", new ValueWithNote("718122", "oxcarbazepine") },
//             { "oxcarbazepine", new ValueWithNote("718122", "oxcarbazepine") }, // confidence: 100.0%, omop match: 100.0%
            { "methotrexate", new ValueWithNote("1305058", "methotrexate") },
//             { "methotrexate", new ValueWithNote("1305058", "methotrexate") }, // confidence: 100.0%, omop match: 100.0%
            { "omeprazole", new ValueWithNote("923645", "omeprazole") },
//             { "omeprazole", new ValueWithNote("923645", "omeprazole") }, // confidence: 100.0%, omop match: 100.0%
            { "methoxyflurane", new ValueWithNote("19005257", "methoxyflurane") },
//             { "methoxyflurane", new ValueWithNote("19005257", "methoxyflurane") }, // confidence: 100.0%, omop match: 100.0%
            { "metolazone", new ValueWithNote("907013", "metolazone") },
//             { "metolazone", new ValueWithNote("907013", "metolazone") }, // confidence: 100.0%, omop match: 100.0%
            { "oxycodone", new ValueWithNote("1124957", "oxycodone") },
//             { "oxycodone", new ValueWithNote("1124957", "oxycodone") }, // confidence: 100.0%, omop match: 100.0%
            { "paliperidone", new ValueWithNote("40137339", "paliperidone") },
//             { "paliperidone", new ValueWithNote("40137339", "paliperidone") }, // confidence: 100.0%, omop match: 100.0%
            { "metyrapone", new ValueWithNote("19007490", "metyrapone") },
//             { "metyrapone", new ValueWithNote("19007490", "metyrapone") }, // confidence: 100.0%, omop match: 100.0%
            { "midodrine", new ValueWithNote("1308368", "midodrine") },
//             { "midodrine", new ValueWithNote("1308368", "midodrine") }, // confidence: 100.0%, omop match: 100.0%
            { "mebendazole", new ValueWithNote("1794280", "mebendazole") },
//             { "mebendazole", new ValueWithNote("1794280", "mebendazole") }, // confidence: 100.0%, omop match: 100.0%
            { "palivizumab", new ValueWithNote("537647", "palivizumab") },
//             { "palivizumab", new ValueWithNote("537647", "palivizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "papaverine", new ValueWithNote("1326901", "papaverine") },
//             { "papaverine", new ValueWithNote("1326901", "papaverine") }, // confidence: 100.0%, omop match: 100.0%
            { "midazolam", new ValueWithNote("708298", "midazolam") },
//             { "midazolam", new ValueWithNote("708298", "midazolam") }, // confidence: 100.0%, omop match: 100.0%
            { "mizolastine", new ValueWithNote("19086100", "mizolastine") },
//             { "mizolastine", new ValueWithNote("19086100", "mizolastine") }, // confidence: 100.0%, omop match: 100.0%
            { "parecoxib", new ValueWithNote("19003570", "parecoxib") },
//             { "parecoxib", new ValueWithNote("19003570", "parecoxib") }, // confidence: 100.0%, omop match: 100.0%
            { "meloxicam", new ValueWithNote("1150345", "meloxicam") },
//             { "meloxicam", new ValueWithNote("1150345", "meloxicam") }, // confidence: 100.0%, omop match: 100.0%
            { "moclobemide", new ValueWithNote("19010652", "moclobemide") },
//             { "moclobemide", new ValueWithNote("19010652", "moclobemide") }, // confidence: 100.0%, omop match: 100.0%
            { "naproxen", new ValueWithNote("1115008", "naproxen") },
//             { "naproxen", new ValueWithNote("1115008", "naproxen") }, // confidence: 100.0%, omop match: 100.0%
            { "ondansetron", new ValueWithNote("1000560", "ondansetron") },
//             { "ondansetron", new ValueWithNote("1000560", "ondansetron") }, // confidence: 100.0%, omop match: 100.0%
            { "naratriptan", new ValueWithNote("1118117", "naratriptan") },
//             { "naratriptan", new ValueWithNote("1118117", "naratriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium dihydrogen phosphate", new ValueWithNote("990499", "sodium phosphate, monobasic") },
//             { "sodium dihydrogen phosphate", new ValueWithNote("990499", "sodium phosphate, monobasic") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium feredetate", new ValueWithNote("19001131", "sodium ironedetate") },
//             { "sodium feredetate", new ValueWithNote("19001131", "sodium ironedetate") }, // confidence: 100.0%, omop match: 100.0%
            { "meningococcal group b vaccine", new ValueWithNote("45775636", "meningococcal group b vaccine") },
//             { "meningococcal group b vaccine", new ValueWithNote("45775636", "meningococcal group b vaccine") }, // confidence: 100.0%, omop match: 100.0%
            { "mitotane", new ValueWithNote("1309161", "mitotane") },
//             { "mitotane", new ValueWithNote("1309161", "mitotane") }, // confidence: 100.0%, omop match: 100.0%
            { "moxonidine", new ValueWithNote("19011021", "moxonidine") },
//             { "moxonidine", new ValueWithNote("19011021", "moxonidine") }, // confidence: 100.0%, omop match: 100.0%
            { "pancreatin", new ValueWithNote("926487", "pancreatin") },
//             { "pancreatin", new ValueWithNote("926487", "pancreatin") }, // confidence: 100.0%, omop match: 100.0%
            { "paroxetine", new ValueWithNote("722031", "paroxetine") },
//             { "paroxetine", new ValueWithNote("722031", "paroxetine") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium citrate", new ValueWithNote("976545", "potassium citrate") },
//             { "potassium citrate", new ValueWithNote("976545", "potassium citrate") }, // confidence: 100.0%, omop match: 100.0%
            { "pristinamycin", new ValueWithNote("19125201", "pristinamycin") },
//             { "pristinamycin", new ValueWithNote("19125201", "pristinamycin") }, // confidence: 100.0%, omop match: 100.0%
            { "mercaptopurine", new ValueWithNote("1436650", "mercaptopurine") },
//             { "mercaptopurine", new ValueWithNote("1436650", "mercaptopurine") }, // confidence: 100.0%, omop match: 100.0%
            { "metformin", new ValueWithNote("1503297", "metformin") },
//             { "metformin", new ValueWithNote("1503297", "metformin") }, // confidence: 100.0%, omop match: 100.0%
            { "nadolol", new ValueWithNote("1313200", "nadolol") },
//             { "nadolol", new ValueWithNote("1313200", "nadolol") }, // confidence: 100.0%, omop match: 100.0%
            { "nitrofurantoin", new ValueWithNote("920293", "nitrofurantoin") },
//             { "nitrofurantoin", new ValueWithNote("920293", "nitrofurantoin") }, // confidence: 100.0%, omop match: 100.0%
            { "neostigmine", new ValueWithNote("717136", "neostigmine") },
//             { "neostigmine", new ValueWithNote("717136", "neostigmine") }, // confidence: 100.0%, omop match: 100.0%
            { "sugammadex", new ValueWithNote("35604506", "sugammadex") },
//             { "sugammadex", new ValueWithNote("35604506", "sugammadex") }, // confidence: 100.0%, omop match: 100.0%
            { "sumatriptan", new ValueWithNote("1140643", "sumatriptan") },
//             { "sumatriptan", new ValueWithNote("1140643", "sumatriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "pegfilgrastim", new ValueWithNote("1325608", "pegfilgrastim") },
//             { "pegfilgrastim", new ValueWithNote("1325608", "pegfilgrastim") }, // confidence: 100.0%, omop match: 100.0%
            { "perampanel", new ValueWithNote("42904177", "perampanel") },
//             { "perampanel", new ValueWithNote("42904177", "perampanel") }, // confidence: 100.0%, omop match: 100.0%
            { "nizatidine", new ValueWithNote("950696", "nizatidine") },
//             { "nizatidine", new ValueWithNote("950696", "nizatidine") }, // confidence: 100.0%, omop match: 100.0%
            { "nortriptyline", new ValueWithNote("721724", "nortriptyline") },
//             { "nortriptyline", new ValueWithNote("721724", "nortriptyline") }, // confidence: 100.0%, omop match: 100.0%
            { "pasireotide", new ValueWithNote("43012417", "pasireotide") },
//             { "pasireotide", new ValueWithNote("43012417", "pasireotide") }, // confidence: 100.0%, omop match: 100.0%
            { "pentosan polysulfate sodium", new ValueWithNote("19011333", "pentosan polysulphate sodium") },
//             { "pentosan polysulfate sodium", new ValueWithNote("19011333", "pentosan polysulphate sodium") }, // confidence: 100.0%, omop match: 100.0%
            { "promazine", new ValueWithNote("19052903", "promazine") },
//             { "promazine", new ValueWithNote("19052903", "promazine") }, // confidence: 100.0%, omop match: 100.0%
            { "propiverine", new ValueWithNote("19077093", "propiverine") },
//             { "propiverine", new ValueWithNote("19077093", "propiverine") }, // confidence: 100.0%, omop match: 100.0%
            { "methyldopa", new ValueWithNote("1305447", "methyldopa") },
//             { "methyldopa", new ValueWithNote("1305447", "methyldopa") }, // confidence: 100.0%, omop match: 100.0%
            { "methylprednisolone", new ValueWithNote("1506270", "methylprednisolone") },
//             { "methylprednisolone", new ValueWithNote("1506270", "methylprednisolone") }, // confidence: 100.0%, omop match: 100.0%
            { "nicardipine", new ValueWithNote("1318137", "nicardipine") },
//             { "nicardipine", new ValueWithNote("1318137", "nicardipine") }, // confidence: 100.0%, omop match: 100.0%
            { "nimodipine", new ValueWithNote("1319133", "nimodipine") },
//             { "nimodipine", new ValueWithNote("1319133", "nimodipine") }, // confidence: 100.0%, omop match: 100.0%
            { "phenobarbital", new ValueWithNote("734275", "phenobarbital") },
//             { "phenobarbital", new ValueWithNote("734275", "phenobarbital") }, // confidence: 100.0%, omop match: 100.0%
            { "pioglitazone", new ValueWithNote("1525215", "pioglitazone") },
//             { "pioglitazone", new ValueWithNote("1525215", "pioglitazone") }, // confidence: 100.0%, omop match: 100.0%
            { "olive oil", new ValueWithNote("42900448", "olive oil") },
//             { "olive oil", new ValueWithNote("42900448", "olive oil") }, // confidence: 100.0%, omop match: 100.0%
            { "orphenadrine", new ValueWithNote("724394", "orphenadrine") },
//             { "orphenadrine", new ValueWithNote("724394", "orphenadrine") }, // confidence: 100.0%, omop match: 100.0%
            { "pyrimethamine", new ValueWithNote("1760039", "pyrimethamine") },
//             { "pyrimethamine", new ValueWithNote("1760039", "pyrimethamine") }, // confidence: 100.0%, omop match: 100.0%
            { "quinapril", new ValueWithNote("1331235", "quinapril") },
//             { "quinapril", new ValueWithNote("1331235", "quinapril") }, // confidence: 100.0%, omop match: 100.0%
            { "methylthioninium chloride", new ValueWithNote("905518", "methylene blue") },
//             { "methylthioninium chloride", new ValueWithNote("905518", "methylene blue") }, // confidence: 100.0%, omop match: 100.0%
            { "metoclopramide", new ValueWithNote("906780", "metoclopramide") },
//             { "metoclopramide", new ValueWithNote("906780", "metoclopramide") }, // confidence: 100.0%, omop match: 100.0%
            { "metoprolol", new ValueWithNote("1307046", "metoprolol") },
//             { "metoprolol", new ValueWithNote("1307046", "metoprolol") }, // confidence: 100.0%, omop match: 100.0%
            { "mexiletine", new ValueWithNote("1307542", "mexiletine") },
//             { "mexiletine", new ValueWithNote("1307542", "mexiletine") }, // confidence: 100.0%, omop match: 100.0%
            { "nitrazepam", new ValueWithNote("19020021", "nitrazepam") },
//             { "nitrazepam", new ValueWithNote("19020021", "nitrazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "pentoxifylline", new ValueWithNote("1331247", "pentoxifylline") },
//             { "pentoxifylline", new ValueWithNote("1331247", "pentoxifylline") }, // confidence: 100.0%, omop match: 100.0%
            { "perhexiline", new ValueWithNote("19032359", "perhexiline") },
//             { "perhexiline", new ValueWithNote("19032359", "perhexiline") }, // confidence: 100.0%, omop match: 100.0%
            { "tamoxifen", new ValueWithNote("1436678", "tamoxifen") },
//             { "tamoxifen", new ValueWithNote("1436678", "tamoxifen") }, // confidence: 100.0%, omop match: 100.0%
            { "teicoplanin", new ValueWithNote("19078399", "teicoplanin") },
//             { "teicoplanin", new ValueWithNote("19078399", "teicoplanin") }, // confidence: 100.0%, omop match: 100.0%
            { "nystatin", new ValueWithNote("922570", "nystatin") },
//             { "nystatin", new ValueWithNote("922570", "nystatin") }, // confidence: 100.0%, omop match: 100.0%
            { "oxybutynin", new ValueWithNote("918906", "oxybutynin") },
//             { "oxybutynin", new ValueWithNote("918906", "oxybutynin") }, // confidence: 100.0%, omop match: 100.0%
            { "pantoprazole", new ValueWithNote("948078", "pantoprazole") },
//             { "pantoprazole", new ValueWithNote("948078", "pantoprazole") }, // confidence: 100.0%, omop match: 100.0%
            { "paraldehyde", new ValueWithNote("19027181", "paraldehyde") },
//             { "paraldehyde", new ValueWithNote("19027181", "paraldehyde") }, // confidence: 100.0%, omop match: 100.0%
            { "piroxicam", new ValueWithNote("1146810", "piroxicam") },
//             { "piroxicam", new ValueWithNote("1146810", "piroxicam") }, // confidence: 100.0%, omop match: 100.0%
            { "phenoxybenzamine", new ValueWithNote("1335301", "phenoxybenzamine") },
//             { "phenoxybenzamine", new ValueWithNote("1335301", "phenoxybenzamine") }, // confidence: 100.0%, omop match: 100.0%
            { "phenylephrine", new ValueWithNote("1135766", "phenylephrine") },
//             { "phenylephrine", new ValueWithNote("1135766", "phenylephrine") }, // confidence: 100.0%, omop match: 100.0%
            { "poractant alfa", new ValueWithNote("19091377", "poractant alfa") },
//             { "poractant alfa", new ValueWithNote("19091377", "poractant alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "mirabegron", new ValueWithNote("42873636", "mirabegron") },
//             { "mirabegron", new ValueWithNote("42873636", "mirabegron") }, // confidence: 100.0%, omop match: 100.0%
            { "paromomycin", new ValueWithNote("1727443", "paromomycin") },
//             { "paromomycin", new ValueWithNote("1727443", "paromomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "pazopanib", new ValueWithNote("40167554", "pazopanib") },
//             { "pazopanib", new ValueWithNote("40167554", "pazopanib") }, // confidence: 100.0%, omop match: 100.0%
            { "petrolatum", new ValueWithNote("19033354", "petrolatum") },
//             { "petrolatum", new ValueWithNote("19033354", "petrolatum") }, // confidence: 100.0%, omop match: 100.0%
            { "piracetam", new ValueWithNote("19046654", "piracetam") },
//             { "piracetam", new ValueWithNote("19046654", "piracetam") }, // confidence: 100.0%, omop match: 100.0%
            { "ranitidine", new ValueWithNote("961047", "ranitidine") },
//             { "ranitidine", new ValueWithNote("961047", "ranitidine") }, // confidence: 100.0%, omop match: 100.0%
            { "rasagiline", new ValueWithNote("715710", "rasagiline") },
//             { "rasagiline", new ValueWithNote("715710", "rasagiline") }, // confidence: 100.0%, omop match: 100.0%
            { "telmisartan", new ValueWithNote("1317640", "telmisartan") },
//             { "telmisartan", new ValueWithNote("1317640", "telmisartan") }, // confidence: 100.0%, omop match: 100.0%
            { "temocillin", new ValueWithNote("19100438", "temocillin") },
//             { "temocillin", new ValueWithNote("19100438", "temocillin") }, // confidence: 100.0%, omop match: 100.0%
            { "mirikizumab", new ValueWithNote("746977", "mirikizumab") },
//             { "mirikizumab", new ValueWithNote("746977", "mirikizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium canrenoate", new ValueWithNote("19019629", "canrenoate potassium") },
//             { "potassium canrenoate", new ValueWithNote("19019629", "canrenoate potassium") }, // confidence: 100.0%, omop match: 100.0%
            { "moxifloxacin", new ValueWithNote("1716903", "moxifloxacin") },
//             { "moxifloxacin", new ValueWithNote("1716903", "moxifloxacin") }, // confidence: 100.0%, omop match: 100.0%
            { "rivaroxaban", new ValueWithNote("40241331", "rivaroxaban") },
//             { "rivaroxaban", new ValueWithNote("40241331", "rivaroxaban") }, // confidence: 100.0%, omop match: 100.0%
            { "phenytoin", new ValueWithNote("740910", "phenytoin") },
//             { "phenytoin", new ValueWithNote("740910", "phenytoin") }, // confidence: 100.0%, omop match: 100.0%
            { "pholcodine", new ValueWithNote("19024213", "pholcodine") },
//             { "pholcodine", new ValueWithNote("19024213", "pholcodine") }, // confidence: 100.0%, omop match: 100.0%
            { "rosuvastatin", new ValueWithNote("1510813", "rosuvastatin") },
//             { "rosuvastatin", new ValueWithNote("1510813", "rosuvastatin") }, // confidence: 100.0%, omop match: 100.0%
            { "ruxolitinib", new ValueWithNote("40244464", "ruxolitinib") },
//             { "ruxolitinib", new ValueWithNote("40244464", "ruxolitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium iodate", new ValueWithNote("19095275", "potassium iodate") },
//             { "potassium iodate", new ValueWithNote("19095275", "potassium iodate") }, // confidence: 100.0%, omop match: 100.0%
            { "pramipexole", new ValueWithNote("720810", "pramipexole") },
//             { "pramipexole", new ValueWithNote("720810", "pramipexole") }, // confidence: 100.0%, omop match: 100.0%
            { "pivmecillinam", new ValueWithNote("19088223", "amdinocillin pivoxil") },
//             { "pivmecillinam", new ValueWithNote("19088223", "amdinocillin pivoxil") }, // confidence: 100.0%, omop match: 100.0%
            { "pizotifen", new ValueWithNote("19047076", "pizotyline") },
//             { "pizotifen", new ValueWithNote("19047076", "pizotyline") }, // confidence: 100.0%, omop match: 100.0%
            { "mycophenolate mofetil", new ValueWithNote("19003999", "mycophenolate mofetil") },
//             { "mycophenolate mofetil", new ValueWithNote("19003999", "mycophenolate mofetil") }, // confidence: 100.0%, omop match: 100.0%
            { "teriflunomide", new ValueWithNote("42900584", "teriflunomide") },
//             { "teriflunomide", new ValueWithNote("42900584", "teriflunomide") }, // confidence: 100.0%, omop match: 100.0%
            { "terlipressin", new ValueWithNote("19119253", "terlipressin") },
//             { "terlipressin", new ValueWithNote("19119253", "terlipressin") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium iodide", new ValueWithNote("19049909", "potassium iodide") },
//             { "potassium iodide", new ValueWithNote("19049909", "potassium iodide") }, // confidence: 100.0%, omop match: 100.0%
            { "propafenone", new ValueWithNote("1353256", "propafenone") },
//             { "propafenone", new ValueWithNote("1353256", "propafenone") }, // confidence: 100.0%, omop match: 100.0%
            { "palonosetron", new ValueWithNote("911354", "palonosetron") },
//             { "palonosetron", new ValueWithNote("911354", "palonosetron") }, // confidence: 100.0%, omop match: 100.0%
            { "pseudoephedrine", new ValueWithNote("1154332", "pseudoephedrine") },
//             { "pseudoephedrine", new ValueWithNote("1154332", "pseudoephedrine") }, // confidence: 100.0%, omop match: 100.0%
            { "raltegravir", new ValueWithNote("1712889", "raltegravir") },
//             { "raltegravir", new ValueWithNote("1712889", "raltegravir") }, // confidence: 100.0%, omop match: 100.0%
            { "penicillamine", new ValueWithNote("19028050", "penicillamine") },
//             { "penicillamine", new ValueWithNote("19028050", "penicillamine") }, // confidence: 100.0%, omop match: 100.0%
            { "pentazocine", new ValueWithNote("1130585", "pentazocine") },
//             { "pentazocine", new ValueWithNote("1130585", "pentazocine") }, // confidence: 100.0%, omop match: 100.0%
            { "selegiline", new ValueWithNote("766209", "selegiline") },
//             { "selegiline", new ValueWithNote("766209", "selegiline") }, // confidence: 100.0%, omop match: 100.0%
            { "semaglutide", new ValueWithNote("793143", "semaglutide") },
//             { "semaglutide", new ValueWithNote("793143", "semaglutide") }, // confidence: 100.0%, omop match: 100.0%
            { "naloxone", new ValueWithNote("1114220", "naloxone") },
//             { "naloxone", new ValueWithNote("1114220", "naloxone") }, // confidence: 100.0%, omop match: 100.0%
            { "naltrexone", new ValueWithNote("1714319", "naltrexone") },
//             { "naltrexone", new ValueWithNote("1714319", "naltrexone") }, // confidence: 100.0%, omop match: 100.0%
            { "sevelamer", new ValueWithNote("952004", "sevelamer") },
//             { "sevelamer", new ValueWithNote("952004", "sevelamer") }, // confidence: 100.0%, omop match: 100.0%
            { "sildenafil", new ValueWithNote("1316262", "sildenafil") },
//             { "sildenafil", new ValueWithNote("1316262", "sildenafil") }, // confidence: 100.0%, omop match: 100.0%
            { "procaine benzylpenicillin", new ValueWithNote("19130403", "penicillin g procaine") },
//             { "procaine benzylpenicillin", new ValueWithNote("19130403", "penicillin g procaine") }, // confidence: 100.0%, omop match: 100.0%
            { "protamine", new ValueWithNote("19054245", "protamines") },
//             { "protamine", new ValueWithNote("19054245", "protamines") }, // confidence: 100.0%, omop match: 100.0%
            { "phenindione", new ValueWithNote("19033934", "phenindione") },
//             { "phenindione", new ValueWithNote("19033934", "phenindione") }, // confidence: 100.0%, omop match: 100.0%
            { "silver sulfadiazine", new ValueWithNote("966956", "silver sulfadiazine") },
//             { "silver sulfadiazine", new ValueWithNote("966956", "silver sulfadiazine") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium benzoate", new ValueWithNote("19116573", "sodium benzoate") },
//             { "sodium benzoate", new ValueWithNote("19116573", "sodium benzoate") }, // confidence: 100.0%, omop match: 100.0%
            { "prucalopride", new ValueWithNote("1356018", "prucalopride") },
//             { "prucalopride", new ValueWithNote("1356018", "prucalopride") }, // confidence: 100.0%, omop match: 100.0%
            { "quinine", new ValueWithNote("1760616", "quinine") },
//             { "quinine", new ValueWithNote("1760616", "quinine") }, // confidence: 100.0%, omop match: 100.0%
            { "secukinumab", new ValueWithNote("45892883", "secukinumab") },
//             { "secukinumab", new ValueWithNote("45892883", "secukinumab") }, // confidence: 100.0%, omop match: 100.0%
            { "tetanus immunoglobulin", new ValueWithNote("35604680", "tetanus immune globulin") },
//             { "tetanus immunoglobulin", new ValueWithNote("35604680", "tetanus immune globulin") }, // confidence: 100.0%, omop match: 100.0%
            { "tigecycline", new ValueWithNote("1742432", "tigecycline") },
//             { "tigecycline", new ValueWithNote("1742432", "tigecycline") }, // confidence: 100.0%, omop match: 100.0%
            { "prilocaine", new ValueWithNote("951279", "prilocaine") },
//             { "prilocaine", new ValueWithNote("951279", "prilocaine") }, // confidence: 100.0%, omop match: 100.0%
            { "probenecid", new ValueWithNote("1151422", "probenecid") },
//             { "probenecid", new ValueWithNote("1151422", "probenecid") }, // confidence: 100.0%, omop match: 100.0%
            { "phytomenadione", new ValueWithNote("19044727", "vitamin k1") },
//             { "phytomenadione", new ValueWithNote("19044727", "vitamin k1") }, // confidence: 100.0%, omop match: 100.0%
            { "pilocarpine", new ValueWithNote("945286", "pilocarpine") },
//             { "pilocarpine", new ValueWithNote("945286", "pilocarpine") }, // confidence: 100.0%, omop match: 100.0%
            { "tiotropium", new ValueWithNote("1106776", "tiotropium") },
//             { "tiotropium", new ValueWithNote("1106776", "tiotropium") }, // confidence: 100.0%, omop match: 100.0%
            { "simvastatin", new ValueWithNote("1539403", "simvastatin") },
//             { "simvastatin", new ValueWithNote("1539403", "simvastatin") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium chloride", new ValueWithNote("967823", "sodium chloride") },
//             { "sodium chloride", new ValueWithNote("967823", "sodium chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium chloride", new ValueWithNote("19049105", "potassium chloride") },
//             { "potassium chloride", new ValueWithNote("19049105", "potassium chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "tolbutamide", new ValueWithNote("1502855", "tolbutamide") },
//             { "tolbutamide", new ValueWithNote("1502855", "tolbutamide") }, // confidence: 100.0%, omop match: 100.0%
            { "tranylcypromine", new ValueWithNote("703470", "tranylcypromine") },
//             { "tranylcypromine", new ValueWithNote("703470", "tranylcypromine") }, // confidence: 100.0%, omop match: 100.0%
            { "promethazine", new ValueWithNote("1153013", "promethazine") },
//             { "promethazine", new ValueWithNote("1153013", "promethazine") }, // confidence: 100.0%, omop match: 100.0%
            { "propranolol", new ValueWithNote("1353766", "propranolol") },
//             { "propranolol", new ValueWithNote("1353766", "propranolol") }, // confidence: 100.0%, omop match: 100.0%
            { "nicorandil", new ValueWithNote("19014977", "nicorandil") },
//             { "nicorandil", new ValueWithNote("19014977", "nicorandil") }, // confidence: 100.0%, omop match: 100.0%
            { "ofloxacin", new ValueWithNote("923081", "ofloxacin") },
//             { "ofloxacin", new ValueWithNote("923081", "ofloxacin") }, // confidence: 100.0%, omop match: 100.0%
            { "raloxifene", new ValueWithNote("1513103", "raloxifene") },
//             { "raloxifene", new ValueWithNote("1513103", "raloxifene") }, // confidence: 100.0%, omop match: 100.0%
            { "quinidine", new ValueWithNote("1360421", "quinidine") },
//             { "quinidine", new ValueWithNote("1360421", "quinidine") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium bicarbonate", new ValueWithNote("939506", "sodium bicarbonate") },
//             { "sodium bicarbonate", new ValueWithNote("939506", "sodium bicarbonate") }, // confidence: 100.0%, omop match: 100.0%
            { "ritonavir", new ValueWithNote("1748921", "ritonavir") },
//             { "ritonavir", new ValueWithNote("1748921", "ritonavir") }, // confidence: 100.0%, omop match: 100.0%
            { "rizatriptan", new ValueWithNote("1154077", "rizatriptan") },
//             { "rizatriptan", new ValueWithNote("1154077", "rizatriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "trifluoperazine", new ValueWithNote("704984", "trifluoperazine") },
//             { "trifluoperazine", new ValueWithNote("704984", "trifluoperazine") }, // confidence: 100.0%, omop match: 100.0%
            { "reboxetine", new ValueWithNote("19084693", "reboxetine") },
//             { "reboxetine", new ValueWithNote("19084693", "reboxetine") }, // confidence: 100.0%, omop match: 100.0%
            { "reslizumab", new ValueWithNote("35603983", "reslizumab") },
//             { "reslizumab", new ValueWithNote("35603983", "reslizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "upadacitinib", new ValueWithNote("1361580", "upadacitinib") },
//             { "upadacitinib", new ValueWithNote("1361580", "upadacitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "urea", new ValueWithNote("906914", "urea") },
//             { "urea", new ValueWithNote("906914", "urea") }, // confidence: 100.0%, omop match: 100.0%
            { "ropinirole", new ValueWithNote("713823", "ropinirole") },
//             { "ropinirole", new ValueWithNote("713823", "ropinirole") }, // confidence: 100.0%, omop match: 100.0%
            { "ropivacaine", new ValueWithNote("1136487", "ropivacaine") },
//             { "ropivacaine", new ValueWithNote("1136487", "ropivacaine") }, // confidence: 100.0%, omop match: 100.0%
            { "prochlorperazine", new ValueWithNote("752061", "prochlorperazine") },
//             { "prochlorperazine", new ValueWithNote("752061", "prochlorperazine") }, // confidence: 100.0%, omop match: 100.0%
            { "procyclidine", new ValueWithNote("752276", "procyclidine") },
//             { "procyclidine", new ValueWithNote("752276", "procyclidine") }, // confidence: 100.0%, omop match: 100.0%
            { "rifabutin", new ValueWithNote("1777417", "rifabutin") },
//             { "rifabutin", new ValueWithNote("1777417", "rifabutin") }, // confidence: 100.0%, omop match: 100.0%
            { "rifaximin", new ValueWithNote("1735947", "rifaximin") },
//             { "rifaximin", new ValueWithNote("1735947", "rifaximin") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium picosulfate", new ValueWithNote("19025115", "picosulfate sodium") },
//             { "sodium picosulfate", new ValueWithNote("19025115", "picosulfate sodium") }, // confidence: 100.0%, omop match: 100.0%
            { "omega-3 fatty acids", new ValueWithNote("19106973", "omega-3 fatty acids") },
//             { "omega-3 fatty acids", new ValueWithNote("19106973", "omega-3 fatty acids") }, // confidence: 100.0%, omop match: 100.0%
            { "rozanolixizumab", new ValueWithNote("746106", "rozanolixizumab") },
//             { "rozanolixizumab", new ValueWithNote("746106", "rozanolixizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "propofol", new ValueWithNote("753626", "propofol") },
//             { "propofol", new ValueWithNote("753626", "propofol") }, // confidence: 100.0%, omop match: 100.0%
            { "pyridoxine", new ValueWithNote("19005046", "pyridoxine") },
//             { "pyridoxine", new ValueWithNote("19005046", "pyridoxine") }, // confidence: 100.0%, omop match: 100.0%
            { "riluzole", new ValueWithNote("735951", "riluzole") },
//             { "riluzole", new ValueWithNote("735951", "riluzole") }, // confidence: 100.0%, omop match: 100.0%
            { "rituximab", new ValueWithNote("1314273", "rituximab") },
//             { "rituximab", new ValueWithNote("1314273", "rituximab") }, // confidence: 100.0%, omop match: 100.0%
            { "oxandrolone", new ValueWithNote("1524769", "oxandrolone") },
//             { "oxandrolone", new ValueWithNote("1524769", "oxandrolone") }, // confidence: 100.0%, omop match: 100.0%
            { "oxazepam", new ValueWithNote("724816", "oxazepam") },
//             { "oxazepam", new ValueWithNote("724816", "oxazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "urokinase", new ValueWithNote("1307515", "urokinase") },
//             { "urokinase", new ValueWithNote("1307515", "urokinase") }, // confidence: 100.0%, omop match: 100.0%
            { "valsartan", new ValueWithNote("1308842", "valsartan") },
//             { "valsartan", new ValueWithNote("1308842", "valsartan") }, // confidence: 100.0%, omop match: 100.0%
            { "vardenafil", new ValueWithNote("1311276", "vardenafil") },
//             { "vardenafil", new ValueWithNote("1311276", "vardenafil") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium citrate", new ValueWithNote("977968", "sodium citrate") },
//             { "sodium citrate", new ValueWithNote("977968", "sodium citrate") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium hyaluronate", new ValueWithNote("19106560", "sodium hyaluronate") },
//             { "sodium hyaluronate", new ValueWithNote("19106560", "sodium hyaluronate") }, // confidence: 100.0%, omop match: 100.0%
            { "rasburicase", new ValueWithNote("1304565", "rasburicase") },
//             { "rasburicase", new ValueWithNote("1304565", "rasburicase") }, // confidence: 100.0%, omop match: 100.0%
            { "peginterferon alfa-2a", new ValueWithNote("1714165", "peginterferon alfa-2a") },
//             { "peginterferon alfa-2a", new ValueWithNote("1714165", "peginterferon alfa-2a") }, // confidence: 100.0%, omop match: 100.0%
            { "vecuronium", new ValueWithNote("19012598", "vecuronium") },
//             { "vecuronium", new ValueWithNote("19012598", "vecuronium") }, // confidence: 100.0%, omop match: 100.0%
            { "vildagliptin", new ValueWithNote("19122137", "vildagliptin") },
//             { "vildagliptin", new ValueWithNote("19122137", "vildagliptin") }, // confidence: 100.0%, omop match: 100.0%
            { "rivastigmine", new ValueWithNote("733523", "rivastigmine") },
//             { "rivastigmine", new ValueWithNote("733523", "rivastigmine") }, // confidence: 100.0%, omop match: 100.0%
            { "romiplostim", new ValueWithNote("19032407", "romiplostim") },
//             { "romiplostim", new ValueWithNote("19032407", "romiplostim") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium tetradecyl sulfate", new ValueWithNote("19070012", "sodium tetradecyl sulfate") },
//             { "sodium tetradecyl sulfate", new ValueWithNote("19070012", "sodium tetradecyl sulfate") }, // confidence: 100.0%, omop match: 100.0%
            { "somatropin", new ValueWithNote("1584910", "somatropin") },
//             { "somatropin", new ValueWithNote("1584910", "somatropin") }, // confidence: 100.0%, omop match: 100.0%
            { "peppermint oil", new ValueWithNote("19086712", "peppermint oil") },
//             { "peppermint oil", new ValueWithNote("19086712", "peppermint oil") }, // confidence: 100.0%, omop match: 100.0%
            { "vitamin e", new ValueWithNote("19009540", "vitamin e") },
//             { "vitamin e", new ValueWithNote("19009540", "vitamin e") }, // confidence: 100.0%, omop match: 100.0%
            { "risedronate sodium", new ValueWithNote("19122562", "risedronate sodium") },
//             { "risedronate sodium", new ValueWithNote("19122562", "risedronate sodium") }, // confidence: 100.0%, omop match: 100.0%
            { "roflumilast", new ValueWithNote("40236897", "roflumilast") },
//             { "roflumilast", new ValueWithNote("40236897", "roflumilast") }, // confidence: 100.0%, omop match: 100.0%
            { "sarilumab", new ValueWithNote("1594587", "sarilumab") },
//             { "sarilumab", new ValueWithNote("1594587", "sarilumab") }, // confidence: 100.0%, omop match: 100.0%
            { "sulindac", new ValueWithNote("1236607", "sulindac") },
//             { "sulindac", new ValueWithNote("1236607", "sulindac") }, // confidence: 100.0%, omop match: 100.0%
            { "zinc sulfate", new ValueWithNote("19044522", "zinc sulfate") },
//             { "zinc sulfate", new ValueWithNote("19044522", "zinc sulfate") }, // confidence: 100.0%, omop match: 100.0%
            { "zolpidem", new ValueWithNote("744740", "zolpidem") },
//             { "zolpidem", new ValueWithNote("744740", "zolpidem") }, // confidence: 100.0%, omop match: 100.0%
            { "stiripentol", new ValueWithNote("35200286", "stiripentol") },
//             { "stiripentol", new ValueWithNote("35200286", "stiripentol") }, // confidence: 100.0%, omop match: 100.0%
            { "sulfasalazine", new ValueWithNote("964339", "sulfasalazine") },
//             { "sulfasalazine", new ValueWithNote("964339", "sulfasalazine") }, // confidence: 100.0%, omop match: 100.0%
            { "temozolomide", new ValueWithNote("1341149", "temozolomide") },
//             { "temozolomide", new ValueWithNote("1341149", "temozolomide") }, // confidence: 100.0%, omop match: 100.0%
            { "terbinafine", new ValueWithNote("1741309", "terbinafine") },
//             { "terbinafine", new ValueWithNote("1741309", "terbinafine") }, // confidence: 100.0%, omop match: 100.0%
            { "sofosbuvir/velpatasvir/voxilaprevir", new ValueWithNote("778968", "sofosbuvir / velpatasvir / voxilaprevir") },
//             { "sofosbuvir/velpatasvir/voxilaprevir", new ValueWithNote("778968", "sofosbuvir / velpatasvir / voxilaprevir") }, // confidence: 100.0%, omop match: 100.0%
            { "erythromycin injection", new ValueWithNote("35603399", "erythromycin injection") },
//             { "erythromycin injection", new ValueWithNote("35603399", "erythromycin injection") }, // confidence: 100.0%, omop match: 100.0%
            { "rotigotine", new ValueWithNote("786426", "rotigotine") },
//             { "rotigotine", new ValueWithNote("786426", "rotigotine") }, // confidence: 100.0%, omop match: 100.0%
            { "povidone iodine", new ValueWithNote("1750087", "povidone-iodine") },
//             { "povidone iodine", new ValueWithNote("1750087", "povidone-iodine") }, // confidence: 100.0%, omop match: 100.0%
            { "praziquantel", new ValueWithNote("1750461", "praziquantel") },
//             { "praziquantel", new ValueWithNote("1750461", "praziquantel") }, // confidence: 100.0%, omop match: 100.0%
            { "solifenacin", new ValueWithNote("916005", "solifenacin") },
//             { "solifenacin", new ValueWithNote("916005", "solifenacin") }, // confidence: 100.0%, omop match: 100.0%
            { "sterile water", new ValueWithNote("19009608", "sterile water") },
//             { "sterile water", new ValueWithNote("19009608", "sterile water") }, // confidence: 100.0%, omop match: 100.0%
            { "sulfadiazine", new ValueWithNote("1836391", "sulfadiazine") },
//             { "sulfadiazine", new ValueWithNote("1836391", "sulfadiazine") }, // confidence: 100.0%, omop match: 100.0%
            { "thalidomide", new ValueWithNote("19137042", "thalidomide") },
//             { "thalidomide", new ValueWithNote("19137042", "thalidomide") }, // confidence: 100.0%, omop match: 100.0%
            { "theophylline", new ValueWithNote("1237049", "theophylline") },
//             { "theophylline", new ValueWithNote("1237049", "theophylline") }, // confidence: 100.0%, omop match: 100.0%
            { "siponimod", new ValueWithNote("1510913", "siponimod") },
//             { "siponimod", new ValueWithNote("1510913", "siponimod") }, // confidence: 100.0%, omop match: 100.0%
            { "suxamethonium", new ValueWithNote("836208", "succinylcholine") },
//             { "suxamethonium", new ValueWithNote("836208", "succinylcholine") }, // confidence: 100.0%, omop match: 100.0%
            { "tadalafil", new ValueWithNote("1336926", "tadalafil") },
//             { "tadalafil", new ValueWithNote("1336926", "tadalafil") }, // confidence: 100.0%, omop match: 100.0%
            { "thiopental", new ValueWithNote("700253", "thiopental") },
//             { "thiopental", new ValueWithNote("700253", "thiopental") }, // confidence: 100.0%, omop match: 100.0%
            { "tinzaparin", new ValueWithNote("1308473", "tinzaparin") },
//             { "tinzaparin", new ValueWithNote("1308473", "tinzaparin") }, // confidence: 100.0%, omop match: 100.0%
            { "follitropin alfa", new ValueWithNote("1542948", "follitropin alfa") },
//             { "follitropin alfa", new ValueWithNote("1542948", "follitropin alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "haloperidol decanoate", new ValueWithNote("19068898", "haloperidol decanoate") },
//             { "haloperidol decanoate", new ValueWithNote("19068898", "haloperidol decanoate") }, // confidence: 100.0%, omop match: 100.0%
            { "terazosin", new ValueWithNote("1341238", "terazosin") },
//             { "terazosin", new ValueWithNote("1341238", "terazosin") }, // confidence: 100.0%, omop match: 100.0%
            { "teriparatide", new ValueWithNote("1521987", "teriparatide") },
//             { "teriparatide", new ValueWithNote("1521987", "teriparatide") }, // confidence: 100.0%, omop match: 100.0%
            { "sertraline", new ValueWithNote("739138", "sertraline") },
//             { "sertraline", new ValueWithNote("739138", "sertraline") }, // confidence: 100.0%, omop match: 100.0%
            { "simoctocog alfa", new ValueWithNote("35604968", "simoctocog alfa") },
//             { "simoctocog alfa", new ValueWithNote("35604968", "simoctocog alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "tetracycline", new ValueWithNote("1836948", "tetracycline") },
//             { "tetracycline", new ValueWithNote("1836948", "tetracycline") }, // confidence: 100.0%, omop match: 100.0%
            { "thyrotropin alpha", new ValueWithNote("19063297", "thyrotropin alfa") },
//             { "thyrotropin alpha", new ValueWithNote("19063297", "thyrotropin alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "sirolimus", new ValueWithNote("19034726", "sirolimus") },
//             { "sirolimus", new ValueWithNote("19034726", "sirolimus") }, // confidence: 100.0%, omop match: 100.0%
            { "tezepelumab", new ValueWithNote("702498", "tezepelumab") },
//             { "tezepelumab", new ValueWithNote("702498", "tezepelumab") }, // confidence: 100.0%, omop match: 100.0%
            { "tiopronin", new ValueWithNote("903031", "tiopronin") },
//             { "tiopronin", new ValueWithNote("903031", "tiopronin") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium polystyrene sulfonate", new ValueWithNote("19078126", "sodium polystyrene sulfonate") },
//             { "sodium polystyrene sulfonate", new ValueWithNote("19078126", "sodium polystyrene sulfonate") }, // confidence: 100.0%, omop match: 100.0%
            { "sorafenib", new ValueWithNote("1363387", "sorafenib") },
//             { "sorafenib", new ValueWithNote("1363387", "sorafenib") }, // confidence: 100.0%, omop match: 100.0%
            { "pregabalin", new ValueWithNote("734354", "pregabalin") },
//             { "pregabalin", new ValueWithNote("734354", "pregabalin") }, // confidence: 100.0%, omop match: 100.0%
            { "procarbazine", new ValueWithNote("1351779", "procarbazine") },
//             { "procarbazine", new ValueWithNote("1351779", "procarbazine") }, // confidence: 100.0%, omop match: 100.0%
            { "sotalol", new ValueWithNote("1370109", "sotalol") },
//             { "sotalol", new ValueWithNote("1370109", "sotalol") }, // confidence: 100.0%, omop match: 100.0%
            { "sulpiride", new ValueWithNote("19136626", "sulpiride") },
//             { "sulpiride", new ValueWithNote("19136626", "sulpiride") }, // confidence: 100.0%, omop match: 100.0%
            { "tirofiban", new ValueWithNote("19017067", "tirofiban") },
//             { "tirofiban", new ValueWithNote("19017067", "tirofiban") }, // confidence: 100.0%, omop match: 100.0%
            { "topotecan", new ValueWithNote("1378509", "topotecan") },
//             { "topotecan", new ValueWithNote("1378509", "topotecan") }, // confidence: 100.0%, omop match: 100.0%
            { "tacrolimus", new ValueWithNote("950637", "tacrolimus") },
//             { "tacrolimus", new ValueWithNote("950637", "tacrolimus") }, // confidence: 100.0%, omop match: 100.0%
            { "tolvaptan", new ValueWithNote("19036797", "tolvaptan") },
//             { "tolvaptan", new ValueWithNote("19036797", "tolvaptan") }, // confidence: 100.0%, omop match: 100.0%
            { "trandolapril", new ValueWithNote("1342439", "trandolapril") },
//             { "trandolapril", new ValueWithNote("1342439", "trandolapril") }, // confidence: 100.0%, omop match: 100.0%
            { "promethazine hydrochloride", new ValueWithNote("19012193", "promethazine hydrochloride") },
//             { "promethazine hydrochloride", new ValueWithNote("19012193", "promethazine hydrochloride") }, // confidence: 100.0%, omop match: 100.0%
            { "propantheline", new ValueWithNote("953391", "propantheline") },
//             { "propantheline", new ValueWithNote("953391", "propantheline") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium glycerophosphate", new ValueWithNote("45892326", "sodium glycerophosphate") },
//             { "sodium glycerophosphate", new ValueWithNote("45892326", "sodium glycerophosphate") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium phenylbutyrate", new ValueWithNote("19048721", "sodium phenylbutyrate") },
//             { "sodium phenylbutyrate", new ValueWithNote("19048721", "sodium phenylbutyrate") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium phosphate", new ValueWithNote("19027362", "potassium phosphate") },
//             { "potassium phosphate", new ValueWithNote("19027362", "potassium phosphate") }, // confidence: 100.0%, omop match: 100.0%
            { "ravulizumab", new ValueWithNote("1356009", "ravulizumab") },
//             { "ravulizumab", new ValueWithNote("1356009", "ravulizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "torasemide", new ValueWithNote("942350", "torsemide") },
//             { "torasemide", new ValueWithNote("942350", "torsemide") }, // confidence: 100.0%, omop match: 100.0%
            { "turoctocog alfa", new ValueWithNote("35604313", "turoctocog alfa") },
//             { "turoctocog alfa", new ValueWithNote("35604313", "turoctocog alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "tretinoin", new ValueWithNote("903643", "tretinoin") },
//             { "tretinoin", new ValueWithNote("903643", "tretinoin") }, // confidence: 100.0%, omop match: 100.0%
            { "trimipramine", new ValueWithNote("705755", "trimipramine") },
//             { "trimipramine", new ValueWithNote("705755", "trimipramine") }, // confidence: 100.0%, omop match: 100.0%
            { "tryptophan", new ValueWithNote("19006186", "tryptophan") },
//             { "tryptophan", new ValueWithNote("19006186", "tryptophan") }, // confidence: 100.0%, omop match: 100.0%
            { "riboflavin", new ValueWithNote("19062817", "riboflavin") },
//             { "riboflavin", new ValueWithNote("19062817", "riboflavin") }, // confidence: 100.0%, omop match: 100.0%
            { "risankizumab", new ValueWithNote("1511348", "risankizumab") },
//             { "risankizumab", new ValueWithNote("1511348", "risankizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "trisodium citrate", new ValueWithNote("19065826", "trisodium citrate") },
//             { "trisodium citrate", new ValueWithNote("19065826", "trisodium citrate") }, // confidence: 100.0%, omop match: 100.0%
            { "tapentadol", new ValueWithNote("19026459", "tapentadol") },
//             { "tapentadol", new ValueWithNote("19026459", "tapentadol") }, // confidence: 100.0%, omop match: 100.0%
            { "varicella vaccine", new ValueWithNote("42800027", "varicella-zoster virus vaccine live (oka-merck) strain") },
//             { "varicella vaccine", new ValueWithNote("42800027", "varicella-zoster virus vaccine live (oka-merck) strain") }, // confidence: 100.0%, omop match: 100.0%
            { "salbutamol", new ValueWithNote("1154343", "albuterol") },
//             { "salbutamol", new ValueWithNote("1154343", "albuterol") }, // confidence: 100.0%, omop match: 100.0%
            { "terbutaline", new ValueWithNote("1236744", "terbutaline") },
//             { "terbutaline", new ValueWithNote("1236744", "terbutaline") }, // confidence: 100.0%, omop match: 100.0%
            { "zanamivir", new ValueWithNote("1708748", "zanamivir") },
//             { "zanamivir", new ValueWithNote("1708748", "zanamivir") }, // confidence: 100.0%, omop match: 100.0%
            { "zoledronic acid", new ValueWithNote("1524674", "zoledronic acid") },
//             { "zoledronic acid", new ValueWithNote("1524674", "zoledronic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "saxagliptin", new ValueWithNote("40166035", "saxagliptin") },
//             { "saxagliptin", new ValueWithNote("40166035", "saxagliptin") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium zirconium cyclosilicate", new ValueWithNote("1510687", "sodium zirconium cyclosilicate") },
//             { "sodium zirconium cyclosilicate", new ValueWithNote("1510687", "sodium zirconium cyclosilicate") }, // confidence: 100.0%, omop match: 100.0%
            { "spironolactone", new ValueWithNote("970250", "spironolactone") },
//             { "spironolactone", new ValueWithNote("970250", "spironolactone") }, // confidence: 100.0%, omop match: 100.0%
            { "ursodeoxycholic acid", new ValueWithNote("19010877", "ursodiol") },
//             { "ursodeoxycholic acid", new ValueWithNote("19010877", "ursodiol") }, // confidence: 100.0%, omop match: 100.0%
            { "tetracosactide", new ValueWithNote("19008009", "cosyntropin") },
//             { "tetracosactide", new ValueWithNote("19008009", "cosyntropin") }, // confidence: 100.0%, omop match: 100.0%
            { "tobramycin", new ValueWithNote("902722", "tobramycin") },
//             { "tobramycin", new ValueWithNote("902722", "tobramycin") }, // confidence: 100.0%, omop match: 100.0%
            { "vitamin a", new ValueWithNote("19008339", "vitamin a") },
//             { "vitamin a", new ValueWithNote("19008339", "vitamin a") }, // confidence: 100.0%, omop match: 100.0%
            { "vortioxetine", new ValueWithNote("44507700", "vortioxetine") },
//             { "vortioxetine", new ValueWithNote("44507700", "vortioxetine") }, // confidence: 100.0%, omop match: 100.0%
            { "voxelotor", new ValueWithNote("37497986", "voxelotor") },
//             { "voxelotor", new ValueWithNote("37497986", "voxelotor") }, // confidence: 100.0%, omop match: 100.0%
            { "valproate", new ValueWithNote("745466", "valproate") },
//             { "valproate", new ValueWithNote("745466", "valproate") }, // confidence: 100.0%, omop match: 100.0%
            { "vonicog alfa", new ValueWithNote("1718111", "vonicog alfa") },
//             { "vonicog alfa", new ValueWithNote("1718111", "vonicog alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "fusidic acid", new ValueWithNote("19112521", "fusidic acid") },
//             { "fusidic acid", new ValueWithNote("19112521", "fusidic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "sodium thiosulfate", new ValueWithNote("940004", "sodium thiosulfate") },
//             { "sodium thiosulfate", new ValueWithNote("940004", "sodium thiosulfate") }, // confidence: 100.0%, omop match: 100.0%
            { "sotrovimab", new ValueWithNote("1536976", "sotrovimab") },
//             { "sotrovimab", new ValueWithNote("1536976", "sotrovimab") }, // confidence: 100.0%, omop match: 100.0%
            { "zopiclone", new ValueWithNote("19044883", "zopiclone") },
//             { "zopiclone", new ValueWithNote("19044883", "zopiclone") }, // confidence: 100.0%, omop match: 100.0%
            { "tacalcitol", new ValueWithNote("19008361", "tacalcitol") },
//             { "tacalcitol", new ValueWithNote("19008361", "tacalcitol") }, // confidence: 100.0%, omop match: 100.0%
            { "tamsulosin", new ValueWithNote("924566", "tamsulosin") },
//             { "tamsulosin", new ValueWithNote("924566", "tamsulosin") }, // confidence: 100.0%, omop match: 100.0%
            { "tocilizumab", new ValueWithNote("40171288", "tocilizumab") },
//             { "tocilizumab", new ValueWithNote("40171288", "tocilizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "tofacitinib", new ValueWithNote("42904205", "tofacitinib") },
//             { "tofacitinib", new ValueWithNote("42904205", "tofacitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "temazepam", new ValueWithNote("836715", "temazepam") },
//             { "temazepam", new ValueWithNote("836715", "temazepam") }, // confidence: 100.0%, omop match: 100.0%
            { "tenecteplase", new ValueWithNote("19098548", "tenecteplase") },
//             { "tenecteplase", new ValueWithNote("19098548", "tenecteplase") }, // confidence: 100.0%, omop match: 100.0%
            { "tramadol", new ValueWithNote("1103314", "tramadol") },
//             { "tramadol", new ValueWithNote("1103314", "tramadol") }, // confidence: 100.0%, omop match: 100.0%
            { "trazodone", new ValueWithNote("703547", "trazodone") },
//             { "trazodone", new ValueWithNote("703547", "trazodone") }, // confidence: 100.0%, omop match: 100.0%
            { "sucralfate", new ValueWithNote("1036228", "sucralfate") },
//             { "sucralfate", new ValueWithNote("1036228", "sucralfate") }, // confidence: 100.0%, omop match: 100.0%
            { "sucroferric oxyhydroxide", new ValueWithNote("44785066", "sucroferric oxyhydroxide") },
//             { "sucroferric oxyhydroxide", new ValueWithNote("44785066", "sucroferric oxyhydroxide") }, // confidence: 100.0%, omop match: 100.0%
            { "tetracaine", new ValueWithNote("1036884", "tetracaine") },
//             { "tetracaine", new ValueWithNote("1036884", "tetracaine") }, // confidence: 100.0%, omop match: 100.0%
            { "thiamine", new ValueWithNote("19137312", "thiamine") },
//             { "thiamine", new ValueWithNote("19137312", "thiamine") }, // confidence: 100.0%, omop match: 100.0%
            { "trihexyphenidyl", new ValueWithNote("705178", "trihexyphenidyl") },
//             { "trihexyphenidyl", new ValueWithNote("705178", "trihexyphenidyl") }, // confidence: 100.0%, omop match: 100.0%
            { "tuberculin purified protein derivative", new ValueWithNote("19058274", "purified protein derivative of tuberculin") },
//             { "tuberculin purified protein derivative", new ValueWithNote("19058274", "purified protein derivative of tuberculin") }, // confidence: 100.0%, omop match: 100.0%
            { "sucrose", new ValueWithNote("19136247", "sucrose") },
//             { "sucrose", new ValueWithNote("19136247", "sucrose") }, // confidence: 100.0%, omop match: 100.0%
            { "sunitinib", new ValueWithNote("1336539", "sunitinib") },
//             { "sunitinib", new ValueWithNote("1336539", "sunitinib") }, // confidence: 100.0%, omop match: 100.0%
            { "tiagabine", new ValueWithNote("715458", "tiagabine") },
//             { "tiagabine", new ValueWithNote("715458", "tiagabine") }, // confidence: 100.0%, omop match: 100.0%
            { "tiaprofenic acid", new ValueWithNote("19100755", "tiaprofenic acid") },
//             { "tiaprofenic acid", new ValueWithNote("19100755", "tiaprofenic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "pirfenidone", new ValueWithNote("45775206", "pirfenidone") },
//             { "pirfenidone", new ValueWithNote("45775206", "pirfenidone") }, // confidence: 100.0%, omop match: 100.0%
            { "ticagrelor", new ValueWithNote("40241186", "ticagrelor") },
//             { "ticagrelor", new ValueWithNote("40241186", "ticagrelor") }, // confidence: 100.0%, omop match: 100.0%
            { "zinc oxide", new ValueWithNote("911064", "zinc oxide") },
//             { "zinc oxide", new ValueWithNote("911064", "zinc oxide") }, // confidence: 100.0%, omop match: 100.0%
            { "ustekinumab", new ValueWithNote("40161532", "ustekinumab") },
//             { "ustekinumab", new ValueWithNote("40161532", "ustekinumab") }, // confidence: 100.0%, omop match: 100.0%
            { "verapamil", new ValueWithNote("1307863", "verapamil") },
//             { "verapamil", new ValueWithNote("1307863", "verapamil") }, // confidence: 100.0%, omop match: 100.0%
            { "sulfadiazine silver", new ValueWithNote("966956", "silver sulfadiazine") },
//             { "sulfadiazine silver", new ValueWithNote("966956", "silver sulfadiazine") }, // confidence: 100.0%, omop match: 100.0%
            { "triamcinolone hexacetonide", new ValueWithNote("19101172", "triamcinolone hexacetonide") },
//             { "triamcinolone hexacetonide", new ValueWithNote("19101172", "triamcinolone hexacetonide") }, // confidence: 100.0%, omop match: 100.0%
            { "tinidazole", new ValueWithNote("1702559", "tinidazole") },
//             { "tinidazole", new ValueWithNote("1702559", "tinidazole") }, // confidence: 100.0%, omop match: 100.0%
            { "tizanidine", new ValueWithNote("778474", "tizanidine") },
//             { "tizanidine", new ValueWithNote("778474", "tizanidine") }, // confidence: 100.0%, omop match: 100.0%
            { "calcium gluconate", new ValueWithNote("19037038", "calcium gluconate") },
//             { "calcium gluconate", new ValueWithNote("19037038", "calcium gluconate") }, // confidence: 100.0%, omop match: 100.0%
            { "tolcapone", new ValueWithNote("715727", "tolcapone") },
//             { "tolcapone", new ValueWithNote("715727", "tolcapone") }, // confidence: 100.0%, omop match: 100.0%
            { "triptorelin", new ValueWithNote("1343039", "triptorelin") },
//             { "triptorelin", new ValueWithNote("1343039", "triptorelin") }, // confidence: 100.0%, omop match: 100.0%
            { "valproic acid", new ValueWithNote("19010963", "valproic acid") },
//             { "valproic acid", new ValueWithNote("19010963", "valproic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "trospium", new ValueWithNote("991825", "trospium") },
//             { "trospium", new ValueWithNote("991825", "trospium") }, // confidence: 100.0%, omop match: 100.0%
            { "tranexamic acid", new ValueWithNote("1303425", "tranexamic acid") },
//             { "tranexamic acid", new ValueWithNote("1303425", "tranexamic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "triamcinolone", new ValueWithNote("903963", "triamcinolone") },
//             { "triamcinolone", new ValueWithNote("903963", "triamcinolone") }, // confidence: 100.0%, omop match: 100.0%
            { "vedolizumab", new ValueWithNote("45774639", "vedolizumab") },
//             { "vedolizumab", new ValueWithNote("45774639", "vedolizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "vigabatrin", new ValueWithNote("19020002", "vigabatrin") },
//             { "vigabatrin", new ValueWithNote("19020002", "vigabatrin") }, // confidence: 100.0%, omop match: 100.0%
            { "erythromycin", new ValueWithNote("1746940", "erythromycin") },
//             { "erythromycin", new ValueWithNote("1746940", "erythromycin") }, // confidence: 100.0%, omop match: 100.0%
            { "allantoin", new ValueWithNote("966376", "allantoin") },
//             { "allantoin", new ValueWithNote("966376", "allantoin") }, // confidence: 100.0%, omop match: 100.0%
            { "interferon alfa-2a", new ValueWithNote("1379969", "interferon alfa-2a") },
//             { "interferon alfa-2a", new ValueWithNote("1379969", "interferon alfa-2a") }, // confidence: 100.0%, omop match: 100.0%
            { "liquid paraffin", new ValueWithNote("908523", "mineral oil") },
//             { "liquid paraffin", new ValueWithNote("908523", "mineral oil") }, // confidence: 100.0%, omop match: 100.0%
            { "cetylpyridinium", new ValueWithNote("989301", "cetylpyridinium") },
//             { "cetylpyridinium", new ValueWithNote("989301", "cetylpyridinium") }, // confidence: 100.0%, omop match: 100.0%
            { "ulipristal", new ValueWithNote("40225722", "ulipristal") },
//             { "ulipristal", new ValueWithNote("40225722", "ulipristal") }, // confidence: 100.0%, omop match: 100.0%
            { "umeclidinium", new ValueWithNote("44785907", "umeclidinium") },
//             { "umeclidinium", new ValueWithNote("44785907", "umeclidinium") }, // confidence: 100.0%, omop match: 100.0%
            { "varenicline", new ValueWithNote("780442", "varenicline") },
//             { "varenicline", new ValueWithNote("780442", "varenicline") }, // confidence: 100.0%, omop match: 100.0%
            { "warfarin", new ValueWithNote("1310149", "warfarin") },
//             { "warfarin", new ValueWithNote("1310149", "warfarin") }, // confidence: 100.0%, omop match: 100.0%
            { "lithium citrate", new ValueWithNote("767410", "lithium citrate") },
//             { "lithium citrate", new ValueWithNote("767410", "lithium citrate") }, // confidence: 100.0%, omop match: 100.0%
            { "zinc acetate", new ValueWithNote("979096", "zinc acetate") },
//             { "zinc acetate", new ValueWithNote("979096", "zinc acetate") }, // confidence: 100.0%, omop match: 100.0%
            { "methylprednisolone sodium succinate", new ValueWithNote("19026798", "methylprednisolone sodium succinate") },
//             { "methylprednisolone sodium succinate", new ValueWithNote("19026798", "methylprednisolone sodium succinate") }, // confidence: 100.0%, omop match: 100.0%
            { "carbomer 980", new ValueWithNote("42898572", "carbomer homopolymer type c") },
//             { "carbomer 980", new ValueWithNote("42898572", "carbomer homopolymer type c") }, // confidence: 100.0%, omop match: 100.0%
            { "glucosamine", new ValueWithNote("1360332", "glucosamine") },
//             { "glucosamine", new ValueWithNote("1360332", "glucosamine") }, // confidence: 100.0%, omop match: 100.0%
            { "nonacog alfa", new ValueWithNote("46274289", "nonacog alfa") },
//             { "nonacog alfa", new ValueWithNote("46274289", "nonacog alfa") }, // confidence: 100.0%, omop match: 100.0%
            { "polyvinyl alcohol", new ValueWithNote("948856", "polyvinyl alcohol") },
//             { "polyvinyl alcohol", new ValueWithNote("948856", "polyvinyl alcohol") }, // confidence: 100.0%, omop match: 100.0%
            { "olanzapine embonate", new ValueWithNote("46274261", "olanzapine pamoate") },
//             { "olanzapine embonate", new ValueWithNote("46274261", "olanzapine pamoate") }, // confidence: 100.0%, omop match: 100.0%
            { "acetylcysteine", new ValueWithNote("1139042", "acetylcysteine") },
//             { "acetylcysteine", new ValueWithNote("1139042", "acetylcysteine") }, // confidence: 100.0%, omop match: 100.0%
            { "aclidinium", new ValueWithNote("42873639", "aclidinium") },
//             { "aclidinium", new ValueWithNote("42873639", "aclidinium") }, // confidence: 100.0%, omop match: 100.0%
            { "adalimumab", new ValueWithNote("1119119", "adalimumab") },
//             { "adalimumab", new ValueWithNote("1119119", "adalimumab") }, // confidence: 100.0%, omop match: 100.0%
            { "hydrocortisone butyrate", new ValueWithNote("19002396", "hydrocortisone butyrate") },
//             { "hydrocortisone butyrate", new ValueWithNote("19002396", "hydrocortisone butyrate") }, // confidence: 100.0%, omop match: 100.0%
            { "testosterone propionate", new ValueWithNote("19002851", "testosterone propionate") },
//             { "testosterone propionate", new ValueWithNote("19002851", "testosterone propionate") }, // confidence: 100.0%, omop match: 100.0%
            { "alemtuzumab", new ValueWithNote("1312706", "alemtuzumab") },
//             { "alemtuzumab", new ValueWithNote("1312706", "alemtuzumab") }, // confidence: 100.0%, omop match: 100.0%
            { "alfacalcidol", new ValueWithNote("19014202", "alfacalcidol") },
//             { "alfacalcidol", new ValueWithNote("19014202", "alfacalcidol") }, // confidence: 100.0%, omop match: 100.0%
            { "alteplase", new ValueWithNote("1347450", "alteplase") },
//             { "alteplase", new ValueWithNote("1347450", "alteplase") }, // confidence: 100.0%, omop match: 100.0%
            { "alum", new ValueWithNote("19115033", "aluminum potassium sulfate") },
//             { "alum", new ValueWithNote("19115033", "aluminum potassium sulfate") }, // confidence: 100.0%, omop match: 100.0%
            { "ambrisentan", new ValueWithNote("1337068", "ambrisentan") },
//             { "ambrisentan", new ValueWithNote("1337068", "ambrisentan") }, // confidence: 100.0%, omop match: 100.0%
            { "amlodipine", new ValueWithNote("1332418", "amlodipine") },
//             { "amlodipine", new ValueWithNote("1332418", "amlodipine") }, // confidence: 100.0%, omop match: 100.0%
            { "atracurium", new ValueWithNote("19014341", "atracurium") },
//             { "atracurium", new ValueWithNote("19014341", "atracurium") }, // confidence: 100.0%, omop match: 100.0%
            { "azelaic acid", new ValueWithNote("19018514", "azelaic acid") },
//             { "azelaic acid", new ValueWithNote("19018514", "azelaic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "belatacept", new ValueWithNote("40239665", "belatacept") },
//             { "belatacept", new ValueWithNote("40239665", "belatacept") }, // confidence: 100.0%, omop match: 100.0%
            { "benzocaine", new ValueWithNote("917006", "benzocaine") },
//             { "benzocaine", new ValueWithNote("917006", "benzocaine") }, // confidence: 100.0%, omop match: 100.0%
            { "bexarotene", new ValueWithNote("1389888", "bexarotene") },
//             { "bexarotene", new ValueWithNote("1389888", "bexarotene") }, // confidence: 100.0%, omop match: 100.0%
            { "bivalirudin", new ValueWithNote("19084670", "bivalirudin") },
//             { "bivalirudin", new ValueWithNote("19084670", "bivalirudin") }, // confidence: 100.0%, omop match: 100.0%
            { "bosentan", new ValueWithNote("1321636", "bosentan") },
//             { "bosentan", new ValueWithNote("1321636", "bosentan") }, // confidence: 100.0%, omop match: 100.0%
            { "botulinum b toxin", new ValueWithNote("729959", "botulinum toxin type b") },
//             { "botulinum b toxin", new ValueWithNote("729959", "botulinum toxin type b") }, // confidence: 100.0%, omop match: 100.0%
            { "candesartan", new ValueWithNote("1351557", "candesartan") },
//             { "candesartan", new ValueWithNote("1351557", "candesartan") }, // confidence: 100.0%, omop match: 100.0%
            { "carboprost", new ValueWithNote("19049150", "carboprost") },
//             { "carboprost", new ValueWithNote("19049150", "carboprost") }, // confidence: 100.0%, omop match: 100.0%
            { "cefradine", new ValueWithNote("1786842", "cephradine") },
//             { "cefradine", new ValueWithNote("1786842", "cephradine") }, // confidence: 100.0%, omop match: 100.0%
            { "ceftaroline fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") },
//             { "ceftaroline fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") }, // confidence: 100.0%, omop match: 100.0%
            { "cetirizine", new ValueWithNote("1149196", "cetirizine") },
//             { "cetirizine", new ValueWithNote("1149196", "cetirizine") }, // confidence: 100.0%, omop match: 100.0%
            { "chloramphenicol", new ValueWithNote("990069", "chloramphenicol") },
//             { "chloramphenicol", new ValueWithNote("990069", "chloramphenicol") }, // confidence: 100.0%, omop match: 100.0%
            { "chlorhexidine", new ValueWithNote("1790812", "chlorhexidine") },
//             { "chlorhexidine", new ValueWithNote("1790812", "chlorhexidine") }, // confidence: 100.0%, omop match: 100.0%
            { "cinacalcet", new ValueWithNote("1548111", "cinacalcet") },
//             { "cinacalcet", new ValueWithNote("1548111", "cinacalcet") }, // confidence: 100.0%, omop match: 100.0%
            { "codeine", new ValueWithNote("1201620", "codeine") },
//             { "codeine", new ValueWithNote("1201620", "codeine") }, // confidence: 100.0%, omop match: 100.0%
            { "cyclophosphamide", new ValueWithNote("1310317", "cyclophosphamide") },
//             { "cyclophosphamide", new ValueWithNote("1310317", "cyclophosphamide") }, // confidence: 100.0%, omop match: 100.0%
            { "danazol", new ValueWithNote("1511449", "danazol") },
//             { "danazol", new ValueWithNote("1511449", "danazol") }, // confidence: 100.0%, omop match: 100.0%
            { "dasatinib", new ValueWithNote("1358436", "dasatinib") },
//             { "dasatinib", new ValueWithNote("1358436", "dasatinib") }, // confidence: 100.0%, omop match: 100.0%
            { "dexpanthenol", new ValueWithNote("988294", "dexpanthenol") },
//             { "dexpanthenol", new ValueWithNote("988294", "dexpanthenol") }, // confidence: 100.0%, omop match: 100.0%
            { "diclofenac", new ValueWithNote("1124300", "diclofenac") },
//             { "diclofenac", new ValueWithNote("1124300", "diclofenac") }, // confidence: 100.0%, omop match: 100.0%
            { "digoxin", new ValueWithNote("1326303", "digoxin") },
//             { "digoxin", new ValueWithNote("1326303", "digoxin") }, // confidence: 100.0%, omop match: 100.0%
            { "dihydrocodeine", new ValueWithNote("1189596", "dihydrocodeine") },
//             { "dihydrocodeine", new ValueWithNote("1189596", "dihydrocodeine") }, // confidence: 100.0%, omop match: 100.0%
            { "domperidone", new ValueWithNote("19037833", "domperidone") },
//             { "domperidone", new ValueWithNote("19037833", "domperidone") }, // confidence: 100.0%, omop match: 100.0%
            { "duloxetine", new ValueWithNote("715259", "duloxetine") },
//             { "duloxetine", new ValueWithNote("715259", "duloxetine") }, // confidence: 100.0%, omop match: 100.0%
            { "dupilumab", new ValueWithNote("1593467", "dupilumab") },
//             { "dupilumab", new ValueWithNote("1593467", "dupilumab") }, // confidence: 100.0%, omop match: 100.0%
            { "emtricitabine", new ValueWithNote("1703069", "emtricitabine") },
//             { "emtricitabine", new ValueWithNote("1703069", "emtricitabine") }, // confidence: 100.0%, omop match: 100.0%
            { "enzalutamide", new ValueWithNote("42900250", "enzalutamide") },
//             { "enzalutamide", new ValueWithNote("42900250", "enzalutamide") }, // confidence: 100.0%, omop match: 100.0%
            { "erlotinib", new ValueWithNote("1325363", "erlotinib") },
//             { "erlotinib", new ValueWithNote("1325363", "erlotinib") }, // confidence: 100.0%, omop match: 100.0%
            { "ethambutol", new ValueWithNote("1749301", "ethambutol") },
//             { "ethambutol", new ValueWithNote("1749301", "ethambutol") }, // confidence: 100.0%, omop match: 100.0%
            { "ethyl chloride", new ValueWithNote("950316", "ethyl chloride") },
//             { "ethyl chloride", new ValueWithNote("950316", "ethyl chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "etravirine", new ValueWithNote("1758536", "etravirine") },
//             { "etravirine", new ValueWithNote("1758536", "etravirine") }, // confidence: 100.0%, omop match: 100.0%
            { "everolimus", new ValueWithNote("19011440", "everolimus") },
//             { "everolimus", new ValueWithNote("19011440", "everolimus") }, // confidence: 100.0%, omop match: 100.0%
            { "exemestane", new ValueWithNote("1398399", "exemestane") },
//             { "exemestane", new ValueWithNote("1398399", "exemestane") }, // confidence: 100.0%, omop match: 100.0%
            { "febuxostat", new ValueWithNote("19017742", "febuxostat") },
//             { "febuxostat", new ValueWithNote("19017742", "febuxostat") }, // confidence: 100.0%, omop match: 100.0%
            { "fesoterodine", new ValueWithNote("19027958", "fesoterodine") },
//             { "fesoterodine", new ValueWithNote("19027958", "fesoterodine") }, // confidence: 100.0%, omop match: 100.0%
            { "filgrastim", new ValueWithNote("1304850", "filgrastim") },
//             { "filgrastim", new ValueWithNote("1304850", "filgrastim") }, // confidence: 100.0%, omop match: 100.0%
            { "fluphenazine", new ValueWithNote("756018", "fluphenazine") },
//             { "fluphenazine", new ValueWithNote("756018", "fluphenazine") }, // confidence: 100.0%, omop match: 100.0%
            { "glucagon", new ValueWithNote("1560278", "glucagon") },
//             { "glucagon", new ValueWithNote("1560278", "glucagon") }, // confidence: 100.0%, omop match: 100.0%
            { "hyaluronidase", new ValueWithNote("19073699", "hyaluronidase") },
//             { "hyaluronidase", new ValueWithNote("19073699", "hyaluronidase") }, // confidence: 100.0%, omop match: 100.0%
            { "hydroxycarbamide", new ValueWithNote("1377141", "hydroxyurea") },
//             { "hydroxycarbamide", new ValueWithNote("1377141", "hydroxyurea") }, // confidence: 100.0%, omop match: 100.0%
            { "indacaterol", new ValueWithNote("40240664", "indacaterol") },
//             { "indacaterol", new ValueWithNote("40240664", "indacaterol") }, // confidence: 100.0%, omop match: 100.0%
            { "infliximab", new ValueWithNote("937368", "infliximab") },
//             { "infliximab", new ValueWithNote("937368", "infliximab") }, // confidence: 100.0%, omop match: 100.0%
            { "ipratropium", new ValueWithNote("1112921", "ipratropium") },
//             { "ipratropium", new ValueWithNote("1112921", "ipratropium") }, // confidence: 100.0%, omop match: 100.0%
            { "iron sucrose", new ValueWithNote("1395773", "iron sucrose") },
//             { "iron sucrose", new ValueWithNote("1395773", "iron sucrose") }, // confidence: 100.0%, omop match: 100.0%
            { "itraconazole", new ValueWithNote("1703653", "itraconazole") },
//             { "itraconazole", new ValueWithNote("1703653", "itraconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "lamivudine", new ValueWithNote("1704183", "lamivudine") },
//             { "lamivudine", new ValueWithNote("1704183", "lamivudine") }, // confidence: 100.0%, omop match: 100.0%
            { "levetiracetam", new ValueWithNote("711584", "levetiracetam") },
//             { "levetiracetam", new ValueWithNote("711584", "levetiracetam") }, // confidence: 100.0%, omop match: 100.0%
            { "levocetirizine", new ValueWithNote("1136422", "levocetirizine") },
//             { "levocetirizine", new ValueWithNote("1136422", "levocetirizine") }, // confidence: 100.0%, omop match: 100.0%
            { "magnesium chloride", new ValueWithNote("19092849", "magnesium chloride") },
//             { "magnesium chloride", new ValueWithNote("19092849", "magnesium chloride") }, // confidence: 100.0%, omop match: 100.0%
            { "magnesium hydroxide", new ValueWithNote("992956", "magnesium hydroxide") },
//             { "magnesium hydroxide", new ValueWithNote("992956", "magnesium hydroxide") }, // confidence: 100.0%, omop match: 100.0%
            { "memantine", new ValueWithNote("701322", "memantine") },
//             { "memantine", new ValueWithNote("701322", "memantine") }, // confidence: 100.0%, omop match: 100.0%
            { "meptazinol", new ValueWithNote("19003010", "meptazinol") },
//             { "meptazinol", new ValueWithNote("19003010", "meptazinol") }, // confidence: 100.0%, omop match: 100.0%
            { "meropenem", new ValueWithNote("1709170", "meropenem") },
//             { "meropenem", new ValueWithNote("1709170", "meropenem") }, // confidence: 100.0%, omop match: 100.0%
            { "minoxidil", new ValueWithNote("1309068", "minoxidil") },
//             { "minoxidil", new ValueWithNote("1309068", "minoxidil") }, // confidence: 100.0%, omop match: 100.0%
            { "modafinil", new ValueWithNote("710650", "modafinil") },
//             { "modafinil", new ValueWithNote("710650", "modafinil") }, // confidence: 100.0%, omop match: 100.0%
            { "montelukast", new ValueWithNote("1154161", "montelukast") },
//             { "montelukast", new ValueWithNote("1154161", "montelukast") }, // confidence: 100.0%, omop match: 100.0%
            { "mycophenolic acid", new ValueWithNote("19012565", "mycophenolic acid") },
//             { "mycophenolic acid", new ValueWithNote("19012565", "mycophenolic acid") }, // confidence: 100.0%, omop match: 100.0%
            { "nabumetone", new ValueWithNote("1113648", "nabumetone") },
//             { "nabumetone", new ValueWithNote("1113648", "nabumetone") }, // confidence: 100.0%, omop match: 100.0%
            { "natalizumab", new ValueWithNote("735843", "natalizumab") },
//             { "natalizumab", new ValueWithNote("735843", "natalizumab") }, // confidence: 100.0%, omop match: 100.0%
            { "nebivolol", new ValueWithNote("1314577", "nebivolol") },
//             { "nebivolol", new ValueWithNote("1314577", "nebivolol") }, // confidence: 100.0%, omop match: 100.0%
            { "nefopam", new ValueWithNote("19015602", "nefopam") },
//             { "nefopam", new ValueWithNote("19015602", "nefopam") }, // confidence: 100.0%, omop match: 100.0%
            { "nevirapine", new ValueWithNote("1769389", "nevirapine") },
//             { "nevirapine", new ValueWithNote("1769389", "nevirapine") }, // confidence: 100.0%, omop match: 100.0%
            { "nifedipine", new ValueWithNote("1318853", "nifedipine") },
//             { "nifedipine", new ValueWithNote("1318853", "nifedipine") }, // confidence: 100.0%, omop match: 100.0%
            { "nitazoxanide", new ValueWithNote("1715315", "nitazoxanide") },
//             { "nitazoxanide", new ValueWithNote("1715315", "nitazoxanide") }, // confidence: 100.0%, omop match: 100.0%
            { "octenidine", new ValueWithNote("1366603", "octenidine") },
//             { "octenidine", new ValueWithNote("1366603", "octenidine") }, // confidence: 100.0%, omop match: 100.0%
            { "oseltamivir", new ValueWithNote("1799139", "oseltamivir") },
//             { "oseltamivir", new ValueWithNote("1799139", "oseltamivir") }, // confidence: 100.0%, omop match: 100.0%
            { "oxytetracycline", new ValueWithNote("925952", "oxytetracycline") },
//             { "oxytetracycline", new ValueWithNote("925952", "oxytetracycline") }, // confidence: 100.0%, omop match: 100.0%
            { "pamidronate disodium", new ValueWithNote("19007069", "pamidronate disodium") },
//             { "pamidronate disodium", new ValueWithNote("19007069", "pamidronate disodium") }, // confidence: 100.0%, omop match: 100.0%
            { "potassium permanganate", new ValueWithNote("19135788", "potassium permanganate") },
//             { "potassium permanganate", new ValueWithNote("19135788", "potassium permanganate") }, // confidence: 100.0%, omop match: 100.0%
            { "prasugrel", new ValueWithNote("40163718", "prasugrel") },
//             { "prasugrel", new ValueWithNote("40163718", "prasugrel") }, // confidence: 100.0%, omop match: 100.0%
            { "prednisolone", new ValueWithNote("1550557", "prednisolone") },
//             { "prednisolone", new ValueWithNote("1550557", "prednisolone") }, // confidence: 100.0%, omop match: 100.0%
            { "primidone", new ValueWithNote("751347", "primidone") },
//             { "primidone", new ValueWithNote("751347", "primidone") }, // confidence: 100.0%, omop match: 100.0%
            { "progesterone", new ValueWithNote("1552310", "progesterone") },
//             { "progesterone", new ValueWithNote("1552310", "progesterone") }, // confidence: 100.0%, omop match: 100.0%
            { "quetiapine", new ValueWithNote("766814", "quetiapine") },
//             { "quetiapine", new ValueWithNote("766814", "quetiapine") }, // confidence: 100.0%, omop match: 100.0%
            { "ranolazine", new ValueWithNote("1337107", "ranolazine") },
//             { "ranolazine", new ValueWithNote("1337107", "ranolazine") }, // confidence: 100.0%, omop match: 100.0%
            { "repaglinide", new ValueWithNote("1516766", "repaglinide") },
//             { "repaglinide", new ValueWithNote("1516766", "repaglinide") }, // confidence: 100.0%, omop match: 100.0%
            { "rfviia", new ValueWithNote("19065771", "eptacog alfa activated") },
//             { "rfviia", new ValueWithNote("19065771", "eptacog alfa activated") }, // confidence: 100.0%, omop match: 100.0%
            { "rimegepant", new ValueWithNote("37498993", "rimegepant") },
//             { "rimegepant", new ValueWithNote("37498993", "rimegepant") }, // confidence: 100.0%, omop match: 100.0%
            { "risperidone", new ValueWithNote("735979", "risperidone") },
//             { "risperidone", new ValueWithNote("735979", "risperidone") }, // confidence: 100.0%, omop match: 100.0%
            { "roxadustat", new ValueWithNote("35834902", "roxadustat") },
//             { "roxadustat", new ValueWithNote("35834902", "roxadustat") }, // confidence: 100.0%, omop match: 100.0%
            { "selenium", new ValueWithNote("966282", "selenium") },
//             { "selenium", new ValueWithNote("966282", "selenium") }, // confidence: 100.0%, omop match: 100.0%
            { "senna", new ValueWithNote("938268", "sennosides, usp") },
//             { "senna", new ValueWithNote("938268", "sennosides, usp") }, // confidence: 100.0%, omop match: 100.0%
            { "silver nitrate", new ValueWithNote("966913", "silver nitrate") },
//             { "silver nitrate", new ValueWithNote("966913", "silver nitrate") }, // confidence: 100.0%, omop match: 100.0%
            { "sitagliptin", new ValueWithNote("1580747", "sitagliptin") },
//             { "sitagliptin", new ValueWithNote("1580747", "sitagliptin") }, // confidence: 100.0%, omop match: 100.0%
            { "sultiame", new ValueWithNote("19000921", "sulthiame") },
//             { "sultiame", new ValueWithNote("19000921", "sulthiame") }, // confidence: 100.0%, omop match: 100.0%
            { "talc", new ValueWithNote("1036667", "talc") },
//             { "talc", new ValueWithNote("1036667", "talc") }, // confidence: 100.0%, omop match: 100.0%
            { "tenofovir", new ValueWithNote("19011093", "tenofovir") },
//             { "tenofovir", new ValueWithNote("19011093", "tenofovir") }, // confidence: 100.0%, omop match: 100.0%
            { "testosterone", new ValueWithNote("1636780", "testosterone") },
//             { "testosterone", new ValueWithNote("1636780", "testosterone") }, // confidence: 100.0%, omop match: 100.0%
            { "tetrabenazine", new ValueWithNote("836877", "tetrabenazine") },
//             { "tetrabenazine", new ValueWithNote("836877", "tetrabenazine") }, // confidence: 100.0%, omop match: 100.0%
            { "tibolone", new ValueWithNote("19041933", "tibolone") },
//             { "tibolone", new ValueWithNote("19041933", "tibolone") }, // confidence: 100.0%, omop match: 100.0%
            { "timolol", new ValueWithNote("902427", "timolol") },
//             { "timolol", new ValueWithNote("902427", "timolol") }, // confidence: 100.0%, omop match: 100.0%
            { "tirzepatide", new ValueWithNote("779705", "tirzepatide") },
//             { "tirzepatide", new ValueWithNote("779705", "tirzepatide") }, // confidence: 100.0%, omop match: 100.0%
            { "tolterodine", new ValueWithNote("913782", "tolterodine") },
//             { "tolterodine", new ValueWithNote("913782", "tolterodine") }, // confidence: 100.0%, omop match: 100.0%
            { "topiramate", new ValueWithNote("742267", "topiramate") },
//             { "topiramate", new ValueWithNote("742267", "topiramate") }, // confidence: 100.0%, omop match: 100.0%
            { "tozorakimab", new ValueWithNote("36860143", "tozorakimab") },
//             { "tozorakimab", new ValueWithNote("36860143", "tozorakimab") }, // confidence: 100.0%, omop match: 100.0%
            { "trimethoprim", new ValueWithNote("1705674", "trimethoprim") },
//             { "trimethoprim", new ValueWithNote("1705674", "trimethoprim") }, // confidence: 100.0%, omop match: 100.0%
            { "valganciclovir", new ValueWithNote("1703063", "valganciclovir") },
//             { "valganciclovir", new ValueWithNote("1703063", "valganciclovir") }, // confidence: 100.0%, omop match: 100.0%
            { "vancomycin", new ValueWithNote("1707687", "vancomycin") },
//             { "vancomycin", new ValueWithNote("1707687", "vancomycin") }, // confidence: 100.0%, omop match: 100.0%
            { "venlafaxine", new ValueWithNote("743670", "venlafaxine") },
//             { "venlafaxine", new ValueWithNote("743670", "venlafaxine") }, // confidence: 100.0%, omop match: 100.0%
            { "voriconazole", new ValueWithNote("1714277", "voriconazole") },
//             { "voriconazole", new ValueWithNote("1714277", "voriconazole") }, // confidence: 100.0%, omop match: 100.0%
            { "zidovudine", new ValueWithNote("1710612", "zidovudine") },
//             { "zidovudine", new ValueWithNote("1710612", "zidovudine") }, // confidence: 100.0%, omop match: 100.0%
            { "zolmitriptan", new ValueWithNote("1116031", "zolmitriptan") },
//             { "zolmitriptan", new ValueWithNote("1116031", "zolmitriptan") }, // confidence: 100.0%, omop match: 100.0%
            { "zuclopenthixol", new ValueWithNote("19010886", "zuclopenthixol") },
//             { "zuclopenthixol", new ValueWithNote("19010886", "zuclopenthixol") }, // confidence: 100.0%, omop match: 100.0%
            { "cod liver oil", new ValueWithNote("19101604", "cod liver oil") },
//             { "cod liver oil", new ValueWithNote("19101604", "cod liver oil") }, // confidence: 100.0%, omop match: 100.0%
            { "moroctocog alfa", new ValueWithNote("46274287", "antihemophilic factor, human recombinant residues 743-1636 deleted") },
//             { "moroctocog alfa", new ValueWithNote("46274287", "antihemophilic factor, human recombinant residues 743-1636 deleted") }, // confidence: 100.0%, omop match: 100.0%
            { "nateglinide", new ValueWithNote("1502826", "nateglinide") },
//             { "nateglinide", new ValueWithNote("1502826", "nateglinide") }, // confidence: 100.0%, omop match: 100.0%
            { "phenelzine", new ValueWithNote("733896", "phenelzine") },
//             { "phenelzine", new ValueWithNote("733896", "phenelzine") }, // confidence: 100.0%, omop match: 100.0%
            { "testosterone undecanoate", new ValueWithNote("19100455", "testosterone undecanoate") },
//             { "testosterone undecanoate", new ValueWithNote("19100455", "testosterone undecanoate") }, // confidence: 100.0%, omop match: 100.0%
            { "anti-d (rho) immunoglobulin", new ValueWithNote("535714", "rho(d) immune globulin") },
//             { "anti-d (rho) immunoglobulin", new ValueWithNote("535714", "rho(d) immune globulin") }, // confidence: 98.1%, omop match: 100.0%
            { "conjugated oestrogens", new ValueWithNote("1549080", "estrogens, conjugated (usp)") },
//             { "conjugated oestrogens", new ValueWithNote("1549080", "estrogens, conjugated (usp)") }, // confidence: 97.6%, omop match: 100.0%
            { "white soft paraffin", new ValueWithNote("19033354", "petrolatum") },
//             { "white soft paraffin", new ValueWithNote("19033354", "petrolatum") }, // confidence: 97.4%, omop match: 100.0%
            { "charcoal, activated", new ValueWithNote("1701928", "activated charcoal") },
//             { "charcoal, activated", new ValueWithNote("1701928", "activated charcoal") }, // confidence: 97.3%, omop match: 100.0%
            { "tenofovir alafenamide + emtricitabine", new ValueWithNote("778947", "emtricitabine / tenofovir alafenamide") },
//             { "tenofovir alafenamide + emtricitabine", new ValueWithNote("778947", "emtricitabine / tenofovir alafenamide") }, // confidence: 97.3%, omop match: 100.0%
            { "sodium biphosphate-sodium phosphate", new ValueWithNote("36028653", "sodium phosphate / sodium phosphate, monobasic") },
//             { "sodium biphosphate-sodium phosphate", new ValueWithNote("36028653", "sodium phosphate / sodium phosphate, monobasic") }, // confidence: 97.1%, omop match: 100.0%
            { "factor viii + von willebrand factor", new ValueWithNote("36030083", "factor viii / von willebrand factor") },
//             { "factor viii + von willebrand factor", new ValueWithNote("36030083", "factor viii / von willebrand factor") }, // confidence: 97.1%, omop match: 100.0%
            { "calcium carbonate + ergocalciferol", new ValueWithNote("36028357", "calcium carbonate / ergocalciferol") },
//             { "calcium carbonate + ergocalciferol", new ValueWithNote("36028357", "calcium carbonate / ergocalciferol") }, // confidence: 97.1%, omop match: 100.0%
            { "isoniazid/pyrazinamide/rifampicin", new ValueWithNote("36030016", "isoniazid / pyrazinamide / rifampin") },
//             { "isoniazid/pyrazinamide/rifampicin", new ValueWithNote("36030016", "isoniazid / pyrazinamide / rifampin") }, // confidence: 96.9%, omop match: 100.0%
            { "hydrochlorothiazide-telmisartan", new ValueWithNote("36030113", "hydrochlorothiazide / telmisartan") },
//             { "hydrochlorothiazide-telmisartan", new ValueWithNote("36030113", "hydrochlorothiazide / telmisartan") }, // confidence: 96.8%, omop match: 100.0%
            { "hydrochlorothiazide-olmesartan", new ValueWithNote("36030964", "hydrochlorothiazide / olmesartan") },
//             { "hydrochlorothiazide-olmesartan", new ValueWithNote("36030964", "hydrochlorothiazide / olmesartan") }, // confidence: 96.7%, omop match: 100.0%
            { "hydrochlorothiazide-lisinopril", new ValueWithNote("36030000", "hydrochlorothiazide / lisinopril") },
//             { "hydrochlorothiazide-lisinopril", new ValueWithNote("36030000", "hydrochlorothiazide / lisinopril") }, // confidence: 96.7%, omop match: 100.0%
            { "hydrochlorothiazide-irbesartan", new ValueWithNote("36029999", "hydrochlorothiazide / irbesartan") },
//             { "hydrochlorothiazide-irbesartan", new ValueWithNote("36029999", "hydrochlorothiazide / irbesartan") }, // confidence: 96.7%, omop match: 100.0%
            { "hydrocortisone-oxytetracycline", new ValueWithNote("36029281", "hydrocortisone / oxytetracycline") },
//             { "hydrocortisone-oxytetracycline", new ValueWithNote("36029281", "hydrocortisone / oxytetracycline") }, // confidence: 96.7%, omop match: 100.0%
            { "ascorbic acid-ferrous sulfate", new ValueWithNote("36029893", "ascorbic acid / ferrous sulfate") },
//             { "ascorbic acid-ferrous sulfate", new ValueWithNote("36029893", "ascorbic acid / ferrous sulfate") }, // confidence: 96.6%, omop match: 100.0%
            { "citric acid-potassium citrate", new ValueWithNote("36029947", "citric acid / potassium citrate") },
//             { "citric acid-potassium citrate", new ValueWithNote("36029947", "citric acid / potassium citrate") }, // confidence: 96.6%, omop match: 100.0%
            { "colecalciferol", new ValueWithNote("19095164", "cholecalciferol") },
//             { "colecalciferol", new ValueWithNote("19095164", "cholecalciferol") }, // confidence: 96.6%, omop match: 100.0%
            { "hydrochlorothiazide-quinapril", new ValueWithNote("36030100", "hydrochlorothiazide / quinapril") },
//             { "hydrochlorothiazide-quinapril", new ValueWithNote("36030100", "hydrochlorothiazide / quinapril") }, // confidence: 96.6%, omop match: 100.0%
            { "hydrochlorothiazide-valsartan", new ValueWithNote("36030008", "hydrochlorothiazide / valsartan") },
//             { "hydrochlorothiazide-valsartan", new ValueWithNote("36030008", "hydrochlorothiazide / valsartan") }, // confidence: 96.6%, omop match: 100.0%
            { "chlorhexidine + chlorobutanol", new ValueWithNote("36030287", "chlorhexidine / chlorobutanol") },
//             { "chlorhexidine + chlorobutanol", new ValueWithNote("36030287", "chlorhexidine / chlorobutanol") }, // confidence: 96.6%, omop match: 100.0%
            { "benzoyl peroxide-clindamycin", new ValueWithNote("36030343", "benzoyl peroxide / clindamycin") },
//             { "benzoyl peroxide-clindamycin", new ValueWithNote("36030343", "benzoyl peroxide / clindamycin") }, // confidence: 96.4%, omop match: 100.0%
            { "hydrochlorothiazide-losartan", new ValueWithNote("36030001", "hydrochlorothiazide / losartan") },
//             { "hydrochlorothiazide-losartan", new ValueWithNote("36030001", "hydrochlorothiazide / losartan") }, // confidence: 96.4%, omop match: 100.0%
            { "amiloride + cyclopenthiazide", new ValueWithNote("36030291", "amiloride / cyclopenthiazide") },
//             { "amiloride + cyclopenthiazide", new ValueWithNote("36030291", "amiloride / cyclopenthiazide") }, // confidence: 96.4%, omop match: 100.0%
            { "beclometasone", new ValueWithNote("1115572", "beclomethasone") },
//             { "beclometasone", new ValueWithNote("1115572", "beclomethasone") }, // confidence: 96.3%, omop match: 100.0%
            { "ferrous fumarate-folic acid", new ValueWithNote("36028638", "ferrous fumarate / folic acid") },
//             { "ferrous fumarate-folic acid", new ValueWithNote("36028638", "ferrous fumarate / folic acid") }, // confidence: 96.3%, omop match: 100.0%
            { "immunoglobulin intravenous", new ValueWithNote("551749", "immunoglobulins, intravenous") },
//             { "immunoglobulin intravenous", new ValueWithNote("551749", "immunoglobulins, intravenous") }, // confidence: 96.3%, omop match: 100.0%
            { ".teriflunomide", new ValueWithNote("42900584", "teriflunomide") },
//             { ".teriflunomide", new ValueWithNote("42900584", "teriflunomide") }, // confidence: 96.3%, omop match: 100.0%
            { "chlorhexidine + tetracaine", new ValueWithNote("36030325", "chlorhexidine / tetracaine") },
//             { "chlorhexidine + tetracaine", new ValueWithNote("36030325", "chlorhexidine / tetracaine") }, // confidence: 96.2%, omop match: 100.0%
            { "betamethasone-clotrimazole", new ValueWithNote("36029270", "betamethasone / clotrimazole") },
//             { "betamethasone-clotrimazole", new ValueWithNote("36029270", "betamethasone / clotrimazole") }, // confidence: 96.2%, omop match: 100.0%
            { "ferrous sulfate-folic acid", new ValueWithNote("36028169", "ferrous sulfate / folic acid") },
//             { "ferrous sulfate-folic acid", new ValueWithNote("36028169", "ferrous sulfate / folic acid") }, // confidence: 96.2%, omop match: 100.0%
            { "adapalene-benzoyl peroxide", new ValueWithNote("36031106", "adapalene / benzoyl peroxide") },
//             { "adapalene-benzoyl peroxide", new ValueWithNote("36031106", "adapalene / benzoyl peroxide") }, // confidence: 96.2%, omop match: 100.0%
            { "iodine + potassium iodide", new ValueWithNote("36030121", "iodine / potassium iodide") },
//             { "iodine + potassium iodide", new ValueWithNote("36030121", "iodine / potassium iodide") }, // confidence: 96.0%, omop match: 100.0%
            { "hypromellose + dextran 70", new ValueWithNote("36030364", "dextran 70 / hypromellose") },
//             { "hypromellose + dextran 70", new ValueWithNote("36030364", "dextran 70 / hypromellose") }, // confidence: 96.0%, omop match: 100.0%
            { "dolutegravir-rilpivirine", new ValueWithNote("36029814", "dolutegravir / rilpivirine") },
//             { "dolutegravir-rilpivirine", new ValueWithNote("36029814", "dolutegravir / rilpivirine") }, // confidence: 95.8%, omop match: 100.0%
            { "estradiol-levonorgestrel", new ValueWithNote("36030367", "estradiol / levonorgestrel") },
//             { "estradiol-levonorgestrel", new ValueWithNote("36030367", "estradiol / levonorgestrel") }, // confidence: 95.8%, omop match: 100.0%
            { "hydrocortisone-lidocaine", new ValueWithNote("36029276", "hydrocortisone / lidocaine") },
//             { "hydrocortisone-lidocaine", new ValueWithNote("36029276", "hydrocortisone / lidocaine") }, // confidence: 95.8%, omop match: 100.0%
            { "glecaprevir-pibrentasvir", new ValueWithNote("778969", "glecaprevir / pibrentasvir") },
//             { "glecaprevir-pibrentasvir", new ValueWithNote("778969", "glecaprevir / pibrentasvir") }, // confidence: 95.8%, omop match: 100.0%
            { "benzocaine + tyrothricin", new ValueWithNote("36030792", "benzocaine / tyrothricin") },
//             { "benzocaine + tyrothricin", new ValueWithNote("36030792", "benzocaine / tyrothricin") }, // confidence: 95.8%, omop match: 100.0%
            { "artemether-lumefantrine", new ValueWithNote("778783", "artemether / lumefantrine") },
//             { "artemether-lumefantrine", new ValueWithNote("778783", "artemether / lumefantrine") }, // confidence: 95.7%, omop match: 100.0%
            { "dolutegravir-lamivudine", new ValueWithNote("36029861", "dolutegravir / lamivudine") },
//             { "dolutegravir-lamivudine", new ValueWithNote("36029861", "dolutegravir / lamivudine") }, // confidence: 95.7%, omop match: 100.0%
            { "umeclidinium-vilanterol", new ValueWithNote("778926", "umeclidinium / vilanterol") },
//             { "umeclidinium-vilanterol", new ValueWithNote("778926", "umeclidinium / vilanterol") }, // confidence: 95.7%, omop match: 100.0%
            { "calcium phosphate + colecalciferol", new ValueWithNote("36030284", "calcium phosphate / cholecalciferol") },
//             { "calcium phosphate + colecalciferol", new ValueWithNote("36030284", "calcium phosphate / cholecalciferol") }, // confidence: 95.7%, omop match: 100.0%
            { "coal tar-salicylic acid", new ValueWithNote("36030531", "coal tar / salicylic acid") },
//             { "coal tar-salicylic acid", new ValueWithNote("36030531", "coal tar / salicylic acid") }, // confidence: 95.7%, omop match: 100.0%
            { "buprenorphine-naloxone", new ValueWithNote("36030126", "buprenorphine / naloxone") },
//             { "buprenorphine-naloxone", new ValueWithNote("36030126", "buprenorphine / naloxone") }, // confidence: 95.5%, omop match: 100.0%
            { "ceftolozane-tazobactam", new ValueWithNote("778933", "ceftolozane / tazobactam") },
//             { "ceftolozane-tazobactam", new ValueWithNote("778933", "ceftolozane / tazobactam") }, // confidence: 95.5%, omop match: 100.0%
            { "diclofenac-misoprostol", new ValueWithNote("36029967", "diclofenac / misoprostol") },
//             { "diclofenac-misoprostol", new ValueWithNote("36029967", "diclofenac / misoprostol") }, // confidence: 95.5%, omop match: 100.0%
            { "fluticasone-salmeterol", new ValueWithNote("778784", "fluticasone / salmeterol") },
//             { "fluticasone-salmeterol", new ValueWithNote("778784", "fluticasone / salmeterol") }, // confidence: 95.5%, omop match: 100.0%
            { "dutasteride-tamsulosin", new ValueWithNote("36027018", "dutasteride / tamsulosin") },
//             { "dutasteride-tamsulosin", new ValueWithNote("36027018", "dutasteride / tamsulosin") }, // confidence: 95.5%, omop match: 100.0%
            { "metformin-pioglitazone", new ValueWithNote("36030280", "metformin / pioglitazone") },
//             { "metformin-pioglitazone", new ValueWithNote("36030280", "metformin / pioglitazone") }, // confidence: 95.5%, omop match: 100.0%
            { "sofosbuvir-velpatasvir", new ValueWithNote("778954", "sofosbuvir / velpatasvir") },
//             { "sofosbuvir-velpatasvir", new ValueWithNote("778954", "sofosbuvir / velpatasvir") }, // confidence: 95.5%, omop match: 100.0%
            { "fluticasone-vilanterol", new ValueWithNote("778919", "fluticasone / vilanterol") },
//             { "fluticasone-vilanterol", new ValueWithNote("778919", "fluticasone / vilanterol") }, // confidence: 95.5%, omop match: 100.0%
            { "tipiracil-trifluridine", new ValueWithNote("36029751", "tipiracil / trifluridine") },
//             { "tipiracil-trifluridine", new ValueWithNote("36029751", "tipiracil / trifluridine") }, // confidence: 95.5%, omop match: 100.0%
            { "aclidinium-formoterol", new ValueWithNote("779005", "aclidinium / formoterol") },
//             { "aclidinium-formoterol", new ValueWithNote("779005", "aclidinium / formoterol") }, // confidence: 95.2%, omop match: 100.0%
            { "avibactam-ceftazidime", new ValueWithNote("36029713", "avibactam / ceftazidime") },
//             { "avibactam-ceftazidime", new ValueWithNote("36029713", "avibactam / ceftazidime") }, // confidence: 95.2%, omop match: 100.0%
            { "amlodipine-olmesartan", new ValueWithNote("36029071", "amlodipine / olmesartan") },
//             { "amlodipine-olmesartan", new ValueWithNote("36029071", "amlodipine / olmesartan") }, // confidence: 95.2%, omop match: 100.0%
            { "budesonide-formoterol", new ValueWithNote("36030143", "budesonide / formoterol") },
//             { "budesonide-formoterol", new ValueWithNote("36030143", "budesonide / formoterol") }, // confidence: 95.2%, omop match: 100.0%
            { "dimeticone", new ValueWithNote("916662", "dimethicone") },
//             { "dimeticone", new ValueWithNote("916662", "dimethicone") }, // confidence: 95.2%, omop match: 100.0%
            { "esomeprazole-naproxen", new ValueWithNote("36031122", "esomeprazole / naproxen") },
//             { "esomeprazole-naproxen", new ValueWithNote("36031122", "esomeprazole / naproxen") }, // confidence: 95.2%, omop match: 100.0%
            { "ezetimibe-simvastatin", new ValueWithNote("36030246", "ezetimibe / simvastatin") },
//             { "ezetimibe-simvastatin", new ValueWithNote("36030246", "ezetimibe / simvastatin") }, // confidence: 95.2%, omop match: 100.0%
            { "meropenem-vaborbactam", new ValueWithNote("36029808", "meropenem / vaborbactam") },
//             { "meropenem-vaborbactam", new ValueWithNote("36029808", "meropenem / vaborbactam") }, // confidence: 95.2%, omop match: 100.0%
            { "heparinoid", new ValueWithNote("19113045", "heparinoids") },
//             { "heparinoid", new ValueWithNote("19113045", "heparinoids") }, // confidence: 95.2%, omop match: 100.0%
            { "lamivudine-zidovudine", new ValueWithNote("36030019", "lamivudine / zidovudine") },
//             { "lamivudine-zidovudine", new ValueWithNote("36030019", "lamivudine / zidovudine") }, // confidence: 95.2%, omop match: 100.0%
            { "simeticone", new ValueWithNote("966991", "simethicone") },
//             { "simeticone", new ValueWithNote("966991", "simethicone") }, // confidence: 95.2%, omop match: 100.0%
            { "metformin-sitagliptin", new ValueWithNote("36030770", "metformin / sitagliptin") },
//             { "metformin-sitagliptin", new ValueWithNote("36030770", "metformin / sitagliptin") }, // confidence: 95.2%, omop match: 100.0%
            { "olodaterol-tiotropium", new ValueWithNote("778944", "olodaterol / tiotropium") },
//             { "olodaterol-tiotropium", new ValueWithNote("778944", "olodaterol / tiotropium") }, // confidence: 95.2%, omop match: 100.0%
            { "ledipasvir-sofosbuvir", new ValueWithNote("778931", "ledipasvir / sofosbuvir") },
//             { "ledipasvir-sofosbuvir", new ValueWithNote("778931", "ledipasvir / sofosbuvir") }, // confidence: 95.2%, omop match: 100.0%
            { ".apremilast", new ValueWithNote("44816294", "apremilast") },
//             { ".apremilast", new ValueWithNote("44816294", "apremilast") }, // confidence: 95.2%, omop match: 100.0%
            { "wasp venom", new ValueWithNote("19011001", "wasp venoms") },
//             { "wasp venom", new ValueWithNote("19011001", "wasp venoms") }, // confidence: 95.2%, omop match: 100.0%
            { "urea + lauromacrogols", new ValueWithNote("36030315", "lauromacrogols / urea") },
//             { "urea + lauromacrogols", new ValueWithNote("36030315", "lauromacrogols / urea") }, // confidence: 95.2%, omop match: 100.0%
            { "atenolol + nifedipine", new ValueWithNote("36030155", "atenolol / nifedipine") },
//             { "atenolol + nifedipine", new ValueWithNote("36030155", "atenolol / nifedipine") }, // confidence: 95.2%, omop match: 100.0%
            { "caffeine + ergotamine", new ValueWithNote("36029919", "caffeine / ergotamine") },
//             { "caffeine + ergotamine", new ValueWithNote("36029919", "caffeine / ergotamine") }, // confidence: 95.2%, omop match: 100.0%
            { "atovaquone-proguanil", new ValueWithNote("36030109", "atovaquone / proguanil") },
//             { "atovaquone-proguanil", new ValueWithNote("36030109", "atovaquone / proguanil") }, // confidence: 95.0%, omop match: 100.0%
            { "ivacaftor-lumacaftor", new ValueWithNote("778938", "ivacaftor / lumacaftor") },
//             { "ivacaftor-lumacaftor", new ValueWithNote("778938", "ivacaftor / lumacaftor") }, // confidence: 95.0%, omop match: 100.0%
            { "ivacaftor-tezacaftor", new ValueWithNote("778976", "ivacaftor / tezacaftor") },
//             { "ivacaftor-tezacaftor", new ValueWithNote("778976", "ivacaftor / tezacaftor") }, // confidence: 95.0%, omop match: 100.0%
            { "sacubitril-valsartan", new ValueWithNote("778939", "sacubitril / valsartan") },
//             { "sacubitril-valsartan", new ValueWithNote("778939", "sacubitril / valsartan") }, // confidence: 95.0%, omop match: 100.0%
            { "amlodipine-valsartan", new ValueWithNote("36030761", "amlodipine / valsartan") },
//             { "amlodipine-valsartan", new ValueWithNote("36030761", "amlodipine / valsartan") }, // confidence: 95.0%, omop match: 100.0%
            { "cobicistat-darunavir", new ValueWithNote("778934", "cobicistat / darunavir") },
//             { "cobicistat-darunavir", new ValueWithNote("778934", "cobicistat / darunavir") }, // confidence: 95.0%, omop match: 100.0%
            { "lidocaine-prilocaine", new ValueWithNote("36029745", "lidocaine / prilocaine") },
//             { "lidocaine-prilocaine", new ValueWithNote("36029745", "lidocaine / prilocaine") }, // confidence: 95.0%, omop match: 100.0%
            { "abacavir-lamivudine", new ValueWithNote("36030299", "abacavir / lamivudine") },
//             { "abacavir-lamivudine", new ValueWithNote("36030299", "abacavir / lamivudine") }, // confidence: 94.7%, omop match: 100.0%
            { "adrenaline", new ValueWithNote("44814295", "adrenalin") },
//             { "adrenaline", new ValueWithNote("44814295", "adrenalin") }, // confidence: 94.7%, omop match: 100.0%
            { "fibrinogen-thrombin", new ValueWithNote("36030145", "fibrinogen / thrombin") },
//             { "fibrinogen-thrombin", new ValueWithNote("36030145", "fibrinogen / thrombin") }, // confidence: 94.7%, omop match: 100.0%
            { "lopinavir-ritonavir", new ValueWithNote("36030114", "lopinavir / ritonavir") },
//             { "lopinavir-ritonavir", new ValueWithNote("36030114", "lopinavir / ritonavir") }, // confidence: 94.7%, omop match: 100.0%
            { "rabies immunoglobulin, human", new ValueWithNote("19135830", "rabies immune globulin, human") },
//             { "rabies immunoglobulin, human", new ValueWithNote("19135830", "rabies immune globulin, human") }, // confidence: 94.7%, omop match: 100.0%
            { "coal tar + lecithin", new ValueWithNote("36030357", "coal tar / lecithin") },
//             { "coal tar + lecithin", new ValueWithNote("36030357", "coal tar / lecithin") }, // confidence: 94.7%, omop match: 100.0%
            { "factor viii-von willebrand factor", new ValueWithNote("36030083", "factor viii / von willebrand factor") },
//             { "factor viii-von willebrand factor", new ValueWithNote("36030083", "factor viii / von willebrand factor") }, // confidence: 94.1%, omop match: 100.0%
            { "ethinylestradiol + norethisterone", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") },
//             { "ethinylestradiol + norethisterone", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") }, // confidence: 94.1%, omop match: 100.0%
            { "l-acetylcarnitine", new ValueWithNote("19037596", "acetylcarnitine") },
//             { "l-acetylcarnitine", new ValueWithNote("19037596", "acetylcarnitine") }, // confidence: 93.8%, omop match: 100.0%
            { "chlorphenamine", new ValueWithNote("19049707", "chlorphenoxamine") },
//             { "chlorphenamine", new ValueWithNote("19049707", "chlorphenoxamine") }, // confidence: 93.3%, omop match: 100.0%
            { "estradiol-medroxyprogesterone", new ValueWithNote("36030310", "estradiol / medroxyprogesterone") },
//             { "estradiol-medroxyprogesterone", new ValueWithNote("36030310", "estradiol / medroxyprogesterone") }, // confidence: 93.3%, omop match: 100.0%
            { "betamethasone-salicylic acid", new ValueWithNote("36027016", "betamethasone / salicylic acid") },
//             { "betamethasone-salicylic acid", new ValueWithNote("36027016", "betamethasone / salicylic acid") }, // confidence: 93.1%, omop match: 100.0%
            { "calcium carbonate-prasterone", new ValueWithNote("36028330", "calcium carbonate / prasterone") },
//             { "calcium carbonate-prasterone", new ValueWithNote("36028330", "calcium carbonate / prasterone") }, // confidence: 93.1%, omop match: 100.0%
            { "lidocaine-methylprednisolone", new ValueWithNote("36029284", "lidocaine / methylprednisolone") },
//             { "lidocaine-methylprednisolone", new ValueWithNote("36029284", "lidocaine / methylprednisolone") }, // confidence: 93.1%, omop match: 100.0%
            { "loperamide-simeticone", new ValueWithNote("36030021", "loperamide / simethicone") },
//             { "loperamide-simeticone", new ValueWithNote("36030021", "loperamide / simethicone") }, // confidence: 93.0%, omop match: 100.0%
            { "bendroflumethiazide-timolol", new ValueWithNote("36030341", "bendroflumethiazide / timolol") },
//             { "bendroflumethiazide-timolol", new ValueWithNote("36030341", "bendroflumethiazide / timolol") }, // confidence: 92.9%, omop match: 100.0%
            { "clotrimazole-hydrocortisone", new ValueWithNote("36030105", "clotrimazole / hydrocortisone") },
//             { "clotrimazole-hydrocortisone", new ValueWithNote("36030105", "clotrimazole / hydrocortisone") }, // confidence: 92.9%, omop match: 100.0%
            { "glycopyrronium-neostigmine", new ValueWithNote("36028189", "glycopyrronium / neostigmine") },
//             { "glycopyrronium-neostigmine", new ValueWithNote("36028189", "glycopyrronium / neostigmine") }, // confidence: 92.6%, omop match: 100.0%
            { "estradiol/norethisterone/relugolix", new ValueWithNote("779054", "estradiol / norethindrone / relugolix") },
//             { "estradiol/norethisterone/relugolix", new ValueWithNote("779054", "estradiol / norethindrone / relugolix") }, // confidence: 92.5%, omop match: 100.0%
            { "crotamiton-hydrocortisone", new ValueWithNote("36029273", "crotamiton / hydrocortisone") },
//             { "crotamiton-hydrocortisone", new ValueWithNote("36029273", "crotamiton / hydrocortisone") }, // confidence: 92.3%, omop match: 100.0%
            { "erythromycin-zinc acetate", new ValueWithNote("36030166", "erythromycin / zinc acetate") },
//             { "erythromycin-zinc acetate", new ValueWithNote("36030166", "erythromycin / zinc acetate") }, // confidence: 92.3%, omop match: 100.0%
            { "formoterol-glycopyrronium", new ValueWithNote("36029773", "formoterol / glycopyrronium") },
//             { "formoterol-glycopyrronium", new ValueWithNote("36029773", "formoterol / glycopyrronium") }, // confidence: 92.3%, omop match: 100.0%
            { "hydrocortisone-miconazole", new ValueWithNote("36029277", "hydrocortisone / miconazole") },
//             { "hydrocortisone-miconazole", new ValueWithNote("36029277", "hydrocortisone / miconazole") }, // confidence: 92.3%, omop match: 100.0%
            { "hypromellose ophthalmic", new ValueWithNote("40056206", "hypromellose ophthalmic gel") },
//             { "hypromellose ophthalmic", new ValueWithNote("40056206", "hypromellose ophthalmic gel") }, // confidence: 92.0%, omop match: 100.0%
            { "betamethasone-clioquinol", new ValueWithNote("36027015", "betamethasone / clioquinol") },
//             { "betamethasone-clioquinol", new ValueWithNote("36027015", "betamethasone / clioquinol") }, // confidence: 92.0%, omop match: 100.0%
            { "dydrogesterone-estradiol", new ValueWithNote("36030766", "dydrogesterone / estradiol") },
//             { "dydrogesterone-estradiol", new ValueWithNote("36030766", "dydrogesterone / estradiol") }, // confidence: 92.0%, omop match: 100.0%
            { "cetrimide-chlorhexidine", new ValueWithNote("36029297", "cetrimide / chlorhexidine") },
//             { "cetrimide-chlorhexidine", new ValueWithNote("36029297", "cetrimide / chlorhexidine") }, // confidence: 91.7%, omop match: 100.0%
            { "chlorhexidine-lidocaine", new ValueWithNote("36029292", "chlorhexidine / lidocaine") },
//             { "chlorhexidine-lidocaine", new ValueWithNote("36029292", "chlorhexidine / lidocaine") }, // confidence: 91.7%, omop match: 100.0%
            { "ganciclovir ophthalmic", new ValueWithNote("40047166", "ganciclovir ophthalmic gel") },
//             { "ganciclovir ophthalmic", new ValueWithNote("40047166", "ganciclovir ophthalmic gel") }, // confidence: 91.7%, omop match: 100.0%
            { "ethinylestradiol + norethisterone ace", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") },
//             { "ethinylestradiol + norethisterone ace", new ValueWithNote("36030139", "ethinyl estradiol / norethindrone") }, // confidence: 91.7%, omop match: 100.0%
            { "ubidecarenone-vitamin e", new ValueWithNote("36029194", "ubidecarenone / vitamin e") },
//             { "ubidecarenone-vitamin e", new ValueWithNote("36029194", "ubidecarenone / vitamin e") }, // confidence: 91.7%, omop match: 100.0%
            { "valaciclovir", new ValueWithNote("1717704", "valacyclovir") },
//             { "valaciclovir", new ValueWithNote("1717704", "valacyclovir") }, // confidence: 91.7%, omop match: 100.0%
            { "quinine bisulphate", new ValueWithNote("19135856", "quinine bisulfate") },
//             { "quinine bisulphate", new ValueWithNote("19135856", "quinine bisulfate") }, // confidence: 91.4%, omop match: 100.0%
            { "chlorhexidine-neomycin", new ValueWithNote("36031065", "chlorhexidine / neomycin") },
//             { "chlorhexidine-neomycin", new ValueWithNote("36031065", "chlorhexidine / neomycin") }, // confidence: 91.3%, omop match: 100.0%
            { "indapamide-perindopril", new ValueWithNote("36030141", "indapamide / perindopril") },
//             { "indapamide-perindopril", new ValueWithNote("36030141", "indapamide / perindopril") }, // confidence: 91.3%, omop match: 100.0%
            { "sodium chloride nasal", new ValueWithNote("40080074", "sodium chloride nasal gel") },
//             { "sodium chloride nasal", new ValueWithNote("40080074", "sodium chloride nasal gel") }, // confidence: 91.3%, omop match: 100.0%
            { "ethinylestradiol-norelgestromin", new ValueWithNote("36030133", "ethinyl estradiol / norelgestromin") },
            { "ethinylestradiol-levonorgestrel", new ValueWithNote("36029985", "ethinyl estradiol / levonorgestrel") },
//             { "ethinylestradiol-levonorgestrel", new ValueWithNote("36029985", "ethinyl estradiol / levonorgestrel") }, // confidence: 90.9%, omop match: 100.0%
            { "heparinoid-salicylic acid", new ValueWithNote("36028188", "heparinoids / salicylic acid") },
//             { "heparinoid-salicylic acid", new ValueWithNote("36028188", "heparinoids / salicylic acid") }, // confidence: 90.6%, omop match: 100.0%
            { "amiloride-bumetanide", new ValueWithNote("36030337", "amiloride / bumetanide") },
//             { "amiloride-bumetanide", new ValueWithNote("36030337", "amiloride / bumetanide") }, // confidence: 90.5%, omop match: 100.0%
            { "oxymetazoline nasal", new ValueWithNote("739543", "oxymetazoline nasal gel") },
//             { "oxymetazoline nasal", new ValueWithNote("739543", "oxymetazoline nasal gel") }, // confidence: 90.5%, omop match: 100.0%
            { "ethinylestradiol-norgestimate", new ValueWithNote("36029986", "ethinyl estradiol / norgestimate") },
//             { "ethinylestradiol-norgestimate", new ValueWithNote("36029986", "ethinyl estradiol / norgestimate") }, // confidence: 90.3%, omop match: 100.0%
            { "drospirenone-ethinylestradiol", new ValueWithNote("36031101", "drospirenone / ethinyl estradiol") },
//             { "drospirenone-ethinylestradiol", new ValueWithNote("36031101", "drospirenone / ethinyl estradiol") }, // confidence: 90.3%, omop match: 100.0%
            { "mefenamic acid", new ValueWithNote("19125097", "meclofenamic acid") },
//             { "mefenamic acid", new ValueWithNote("19125097", "meclofenamic acid") }, // confidence: 90.3%, omop match: 100.0%
            { "mucin + xylitol", new ValueWithNote("36030769", "mucins / xylitol") },
//             { "mucin + xylitol", new ValueWithNote("36030769", "mucins / xylitol") }, // confidence: 90.3%, omop match: 100.0%
            { "allantoin-lidocaine", new ValueWithNote("36030317", "allantoin / lidocaine") },
//             { "allantoin-lidocaine", new ValueWithNote("36030317", "allantoin / lidocaine") }, // confidence: 90.0%, omop match: 100.0%
            { "desogestrel-ethinylestradiol", new ValueWithNote("36030123", "desogestrel / ethinyl estradiol") },
//             { "desogestrel-ethinylestradiol", new ValueWithNote("36030123", "desogestrel / ethinyl estradiol") }, // confidence: 90.0%, omop match: 100.0%
            { "felodipine-ramipril", new ValueWithNote("36030144", "felodipine / ramipril") },
//             { "felodipine-ramipril", new ValueWithNote("36030144", "felodipine / ramipril") }, // confidence: 90.0%, omop match: 100.0%
            { "mesalazine", new ValueWithNote("968426", "mesalamine") },
//             { "mesalazine", new ValueWithNote("968426", "mesalamine") }, // confidence: 90.0%, omop match: 100.0%
            { "timolol ophthalmic", new ValueWithNote("40087909", "timolol ophthalmic gel") },
//             { "timolol ophthalmic", new ValueWithNote("40087909", "timolol ophthalmic gel") }, // confidence: 90.0%, omop match: 100.0%
            { "urea hydrogen peroxide otic", new ValueWithNote("958999", "carbamide peroxide") },
//             { "urea hydrogen peroxide otic", new ValueWithNote("958999", "carbamide peroxide") }, // confidence: 89.8%, omop match: 100.0%
            { "budesonide/formoterol/glycopyrronium", new ValueWithNote("779032", "budesonide / formoterol / glycopyrronium") },
//             { "budesonide/formoterol/glycopyrronium", new ValueWithNote("779032", "budesonide / formoterol / glycopyrronium") }, // confidence: 89.5%, omop match: 100.0%
            { "naloxone-oxycodone", new ValueWithNote("36029671", "naloxone / oxycodone") },
//             { "naloxone-oxycodone", new ValueWithNote("36029671", "naloxone / oxycodone") }, // confidence: 89.5%, omop match: 100.0%
            { "ceftoraline fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") },
//             { "ceftoraline fosamil", new ValueWithNote("46274210", "ceftaroline fosamil") }, // confidence: 89.5%, omop match: 100.0%
            { "ethinylestradiol-gestodene", new ValueWithNote("36030295", "ethinyl estradiol / gestodene") },
//             { "ethinylestradiol-gestodene", new ValueWithNote("36030295", "ethinyl estradiol / gestodene") }, // confidence: 89.3%, omop match: 100.0%
            { "aciclovir", new ValueWithNote("1703687", "acyclovir") },
//             { "aciclovir", new ValueWithNote("1703687", "acyclovir") }, // confidence: 88.9%, omop match: 100.0%
            { "immunoglobulin normal intramuscular", new ValueWithNote("505117", "intramuscular immunoglobulin") },
//             { "immunoglobulin normal intramuscular", new ValueWithNote("505117", "intramuscular immunoglobulin") }, // confidence: 88.9%, omop match: 100.0%
            { "cetrimide-dimeticone", new ValueWithNote("36027191", "cetrimide / dimethicone") },
//             { "cetrimide-dimeticone", new ValueWithNote("36027191", "cetrimide / dimethicone") }, // confidence: 88.4%, omop match: 100.0%
            { "flucloxacillin", new ValueWithNote("1800835", "cloxacillin") },
//             { "flucloxacillin", new ValueWithNote("1800835", "cloxacillin") }, // confidence: 88.0%, omop match: 100.0%
            { "folinic acid", new ValueWithNote("19129642", "oxolinic acid") },
//             { "folinic acid", new ValueWithNote("19129642", "oxolinic acid") }, // confidence: 88.0%, omop match: 100.0%
            { "norethisterone", new ValueWithNote("19050090", "ethisterone") },
//             { "norethisterone", new ValueWithNote("19050090", "ethisterone") }, // confidence: 88.0%, omop match: 100.0%
            { "calcium polystyrene sulfonate", new ValueWithNote("19112563", "calcium polystyrene sulfonate product") },
//             { "calcium polystyrene sulfonate", new ValueWithNote("19112563", "calcium polystyrene sulfonate product") }, // confidence: 87.9%, omop match: 100.0%
            { "insulin isophane biphasic porcine", new ValueWithNote("19053996", "hypurin porcine biphasic isophane") },
//             { "insulin isophane biphasic porcine", new ValueWithNote("19053996", "hypurin porcine biphasic isophane") }, // confidence: 87.9%, omop match: 100.0%
            { "methylprednisolone oral", new ValueWithNote("1506270", "methylprednisolone") },
//             { "methylprednisolone oral", new ValueWithNote("1506270", "methylprednisolone") }, // confidence: 87.8%, omop match: 100.0%
            { "varicella immunoglobulin", new ValueWithNote("543291", "varicella-zoster immune globulin") },
//             { "varicella immunoglobulin", new ValueWithNote("543291", "varicella-zoster immune globulin") }, // confidence: 87.3%, omop match: 100.0%
            { "xylometazoline nasal", new ValueWithNote("40101014", "xylometazoline nasal spray") },
//             { "xylometazoline nasal", new ValueWithNote("40101014", "xylometazoline nasal spray") }, // confidence: 87.0%, omop match: 100.0%
            { "chloramphenicol ophthalmic", new ValueWithNote("36216751", "chloramphenicol ophthalmic product") },
//             { "chloramphenicol ophthalmic", new ValueWithNote("36216751", "chloramphenicol ophthalmic product") }, // confidence: 86.7%, omop match: 100.0%
            { "fluorometholone ophthalmic", new ValueWithNote("36224796", "fluorometholone ophthalmic product") },
//             { "fluorometholone ophthalmic", new ValueWithNote("36224796", "fluorometholone ophthalmic product") }, // confidence: 86.7%, omop match: 100.0%
            { "sodium chloride ophthalmic", new ValueWithNote("36227316", "sodium chloride ophthalmic product") },
//             { "sodium chloride ophthalmic", new ValueWithNote("36227316", "sodium chloride ophthalmic product") }, // confidence: 86.7%, omop match: 100.0%
            { "isoniazid-rifampicin", new ValueWithNote("36029269", "isoniazid / rifampin") },
//             { "isoniazid-rifampicin", new ValueWithNote("36029269", "isoniazid / rifampin") }, // confidence: 86.4%, omop match: 100.0%
            { "paracetamol-tramadol", new ValueWithNote("36030125", "acetaminophen / tramadol") },
//             { "paracetamol-tramadol", new ValueWithNote("36030125", "acetaminophen / tramadol") }, // confidence: 86.4%, omop match: 100.0%
            { "triamcinolone nasal", new ValueWithNote("40085508", "triamcinolone nasal spray") },
//             { "triamcinolone nasal", new ValueWithNote("40085508", "triamcinolone nasal spray") }, // confidence: 86.4%, omop match: 100.0%
            { "sodium citrate ophthalmic", new ValueWithNote("36218153", "citrate ophthalmic product") },
//             { "sodium citrate ophthalmic", new ValueWithNote("36218153", "citrate ophthalmic product") }, // confidence: 86.3%, omop match: 100.0%
            { "acetylcysteine ophthalmic", new ValueWithNote("36216795", "acetylcysteine ophthalmic product") },
//             { "acetylcysteine ophthalmic", new ValueWithNote("36216795", "acetylcysteine ophthalmic product") }, // confidence: 86.2%, omop match: 100.0%
            { "cyclopentolate ophthalmic", new ValueWithNote("36213819", "cyclopentolate ophthalmic product") },
//             { "cyclopentolate ophthalmic", new ValueWithNote("36213819", "cyclopentolate ophthalmic product") }, // confidence: 86.2%, omop match: 100.0%
            { "sodium citrate irrigation", new ValueWithNote("36224415", "sodium citrate irrigation product") },
//             { "sodium citrate irrigation", new ValueWithNote("36224415", "sodium citrate irrigation product") }, // confidence: 86.2%, omop match: 100.0%
            { "apraclonidine ophthalmic", new ValueWithNote("36215199", "apraclonidine ophthalmic product") },
//             { "apraclonidine ophthalmic", new ValueWithNote("36215199", "apraclonidine ophthalmic product") }, // confidence: 85.7%, omop match: 100.0%
            { "betamethasone ophthalmic", new ValueWithNote("36212153", "betamethasone ophthalmic product") },
//             { "betamethasone ophthalmic", new ValueWithNote("36212153", "betamethasone ophthalmic product") }, // confidence: 85.7%, omop match: 100.0%
            { "ciprofloxacin ophthalmic", new ValueWithNote("36217289", "ciprofloxacin ophthalmic product") },
//             { "ciprofloxacin ophthalmic", new ValueWithNote("36217289", "ciprofloxacin ophthalmic product") }, // confidence: 85.7%, omop match: 100.0%
            { "dexamethasone ophthalmic", new ValueWithNote("36215259", "dexamethasone ophthalmic product") },
//             { "dexamethasone ophthalmic", new ValueWithNote("36215259", "dexamethasone ophthalmic product") }, // confidence: 85.7%, omop match: 100.0%
            { "phenylephrine ophthalmic", new ValueWithNote("36223312", "phenylephrine ophthalmic product") },
//             { "phenylephrine ophthalmic", new ValueWithNote("36223312", "phenylephrine ophthalmic product") }, // confidence: 85.7%, omop match: 100.0%
            { "brinzolamide ophthalmic", new ValueWithNote("36219538", "brinzolamide ophthalmic product") },
//             { "brinzolamide ophthalmic", new ValueWithNote("36219538", "brinzolamide ophthalmic product") }, // confidence: 85.2%, omop match: 100.0%
            { "levofloxacin ophthalmic", new ValueWithNote("36221026", "levofloxacin ophthalmic product") },
//             { "levofloxacin ophthalmic", new ValueWithNote("36221026", "levofloxacin ophthalmic product") }, // confidence: 85.2%, omop match: 100.0%
            { "sodium bicarbonate otic", new ValueWithNote("36227308", "sodium bicarbonate otic product") },
//             { "sodium bicarbonate otic", new ValueWithNote("36227308", "sodium bicarbonate otic product") }, // confidence: 85.2%, omop match: 100.0%
            { "moxifloxacin ophthalmic", new ValueWithNote("36213853", "moxifloxacin ophthalmic product") },
//             { "moxifloxacin ophthalmic", new ValueWithNote("36213853", "moxifloxacin ophthalmic product") }, // confidence: 85.2%, omop match: 100.0%
            { "prednisolone ophthalmic", new ValueWithNote("36220910", "prednisolone ophthalmic product") },
//             { "prednisolone ophthalmic", new ValueWithNote("36220910", "prednisolone ophthalmic product") }, // confidence: 85.2%, omop match: 100.0%
//            { "brimonidine-brinzolamide ophthalmic", new ValueWithNote(null, null) },
////             { "brimonidine-brinzolamide ophthalmic", new ValueWithNote("36246176", "brimonidine / brinzolamide ophthalmic product") }, // confidence: 85.0%, omop match: 100.0%
//            { "ipratropium nasal", new ValueWithNote(null, null) },
////             { "ipratropium nasal", new ValueWithNote("40049465", "ipratropium nasal spray") }, // confidence: 85.0%, omop match: 100.0%
//            { "brimonidine ophthalmic", new ValueWithNote(null, null) },
////             { "brimonidine ophthalmic", new ValueWithNote("36219537", "brimonidine ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "bimatoprost ophthalmic", new ValueWithNote(null, null) },
////             { "bimatoprost ophthalmic", new ValueWithNote("36226260", "bimatoprost ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "dorzolamide ophthalmic", new ValueWithNote(null, null) },
////             { "dorzolamide ophthalmic", new ValueWithNote("36224178", "dorzolamide ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "latanoprost ophthalmic", new ValueWithNote(null, null) },
////             { "latanoprost ophthalmic", new ValueWithNote("36226918", "latanoprost ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "levobunolol ophthalmic", new ValueWithNote(null, null) },
////             { "levobunolol ophthalmic", new ValueWithNote("36221015", "levobunolol ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "propamidine ophthalmic", new ValueWithNote(null, null) },
////             { "propamidine ophthalmic", new ValueWithNote("36211817", "propamidine ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "olopatadine ophthalmic", new ValueWithNote(null, null) },
////             { "olopatadine ophthalmic", new ValueWithNote("36223879", "olopatadine ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "tropicamide ophthalmic", new ValueWithNote(null, null) },
////             { "tropicamide ophthalmic", new ValueWithNote("36227351", "tropicamide ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "witch hazel ophthalmic", new ValueWithNote(null, null) },
////             { "witch hazel ophthalmic", new ValueWithNote("36227261", "witch hazel ophthalmic product") }, // confidence: 84.6%, omop match: 100.0%
//            { "beclometasone nasal", new ValueWithNote(null, null) },
////             { "beclometasone nasal", new ValueWithNote("40010699", "beclomethasone nasal spray") }, // confidence: 84.4%, omop match: 100.0%
//            { "betamethasone-neomycin ophthalmic", new ValueWithNote(null, null) },
////             { "betamethasone-neomycin ophthalmic", new ValueWithNote("36212136", "betamethasone / neomycin ophthalmic product") }, // confidence: 84.2%, omop match: 100.0%
//            { "azelastine nasal", new ValueWithNote(null, null) },
////             { "azelastine nasal", new ValueWithNote("40133581", "azelastine nasal spray") }, // confidence: 84.2%, omop match: 100.0%
//            { "gentamicin-hydrocortisone otic", new ValueWithNote(null, null) },
////             { "gentamicin-hydrocortisone otic", new ValueWithNote("36029279", "gentamicin / hydrocortisone") }, // confidence: 84.2%, omop match: 100.0%
//            { "mometasone nasal", new ValueWithNote(null, null) },
////             { "mometasone nasal", new ValueWithNote("40066277", "mometasone nasal spray") }, // confidence: 84.2%, omop match: 100.0%
//            { "budesonide nasal", new ValueWithNote(null, null) },
////             { "budesonide nasal", new ValueWithNote("40020313", "budesonide nasal spray") }, // confidence: 84.2%, omop match: 100.0%
//            { "azelastine-fluticasone nasal", new ValueWithNote(null, null) },
////             { "azelastine-fluticasone nasal", new ValueWithNote("778911", "azelastine / fluticasone") }, // confidence: 84.0%, omop match: 100.0%
//            { "azelastine ophthalmic", new ValueWithNote(null, null) },
////             { "azelastine ophthalmic", new ValueWithNote("36225520", "azelastine ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "cefuroxime ophthalmic", new ValueWithNote(null, null) },
////             { "cefuroxime ophthalmic", new ValueWithNote("36217283", "cefuroxime ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "diclofenac ophthalmic", new ValueWithNote(null, null) },
////             { "diclofenac ophthalmic", new ValueWithNote("36217233", "diclofenac ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "epinastine ophthalmic", new ValueWithNote(null, null) },
////             { "epinastine ophthalmic", new ValueWithNote("36225777", "epinastine ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "gentamicin ophthalmic", new ValueWithNote(null, null) },
////             { "gentamicin ophthalmic", new ValueWithNote("1594375", "gentamicin ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "lodoxamide ophthalmic", new ValueWithNote(null, null) },
////             { "lodoxamide ophthalmic", new ValueWithNote("36221142", "lodoxamide ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "tetracaine ophthalmic", new ValueWithNote(null, null) },
////             { "tetracaine ophthalmic", new ValueWithNote("36221743", "tetracaine ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "travoprost ophthalmic", new ValueWithNote(null, null) },
////             { "travoprost ophthalmic", new ValueWithNote("36225495", "travoprost ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "tafluprost ophthalmic", new ValueWithNote(null, null) },
////             { "tafluprost ophthalmic", new ValueWithNote("36238005", "tafluprost ophthalmic product") }, // confidence: 84.0%, omop match: 100.0%
//            { "bromfenac ophthalmic", new ValueWithNote(null, null) },
////             { "bromfenac ophthalmic", new ValueWithNote("36219545", "bromfenac ophthalmic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "chloramphenicol otic", new ValueWithNote(null, null) },
////             { "chloramphenicol otic", new ValueWithNote("36216754", "chloramphenicol otic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "dicycloverine", new ValueWithNote(null, null) },
////             { "dicycloverine", new ValueWithNote("1710446", "cycloserine") }, // confidence: 83.3%, omop match: 100.0%
//            { "ephedrine nasal", new ValueWithNote(null, null) },
////             { "ephedrine nasal", new ValueWithNote("40037821", "ephedrine nasal spray") }, // confidence: 83.3%, omop match: 100.0%
//            { "ketorolac ophthalmic", new ValueWithNote(null, null) },
////             { "ketorolac ophthalmic", new ValueWithNote("36225366", "ketorolac ophthalmic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "nepafenac ophthalmic", new ValueWithNote(null, null) },
////             { "nepafenac ophthalmic", new ValueWithNote("36223788", "nepafenac ophthalmic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "ofloxacin ophthalmic", new ValueWithNote(null, null) },
////             { "ofloxacin ophthalmic", new ValueWithNote("36227393", "ofloxacin ophthalmic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "betaxolol ophthalmic", new ValueWithNote(null, null) },
////             { "betaxolol ophthalmic", new ValueWithNote("36212161", "betaxolol ophthalmic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "ketotifen ophthalmic", new ValueWithNote(null, null) },
////             { "ketotifen ophthalmic", new ValueWithNote("36225372", "ketotifen ophthalmic product") }, // confidence: 83.3%, omop match: 100.0%
//            { "atropine ophthalmic", new ValueWithNote(null, null) },
////             { "atropine ophthalmic", new ValueWithNote("36212940", "atropine ophthalmic product") }, // confidence: 82.6%, omop match: 100.0%
//            { "insulin isophane bovine", new ValueWithNote(null, null) },
////             { "insulin isophane bovine", new ValueWithNote("46221581", "insulin isophane") }, // confidence: 82.1%, omop match: 100.0%
//            { "ciprofloxacin otic", new ValueWithNote(null, null) },
////             { "ciprofloxacin otic", new ValueWithNote("36217292", "ciprofloxacin otic product") }, // confidence: 81.8%, omop match: 100.0%
//            { "citric acid/mg oxide/na picosulfate", new ValueWithNote(null, null) },
////             { "citric acid/mg oxide/na picosulfate", new ValueWithNote("36029516", "citric acid / magnesium oxide / picosulfurate") }, // confidence: 81.5%, omop match: 100.0%
//            { "lidocaine-phenylephrine nasal", new ValueWithNote(null, null) },
////             { "lidocaine-phenylephrine nasal", new ValueWithNote("36030085", "lidocaine / phenylephrine") }, // confidence: 81.5%, omop match: 100.0%
//            { "zuclopenthixol acetate injection", new ValueWithNote(null, null) },
////             { "zuclopenthixol acetate injection", new ValueWithNote("19121994", "zuclopenthixol acetate") }, // confidence: 81.5%, omop match: 100.0%
//            { "amylmetacresol-dichlorobenzyl alc top", new ValueWithNote(null, null) },
////             { "amylmetacresol-dichlorobenzyl alc top", new ValueWithNote("36028603", "amylmetacresol / dichlorobenzyl alcohol / menthol") }, // confidence: 81.4%, omop match: 100.0%
//            { "timolol-travoprost ophthalmic", new ValueWithNote(null, null) },
////             { "timolol-travoprost ophthalmic", new ValueWithNote("40099457", "travoprost ophthalmic solution") }, // confidence: 81.4%, omop match: 100.0%
//            { "fluticasone nasal", new ValueWithNote(null, null) },
////             { "fluticasone nasal", new ValueWithNote("36220588", "fluticasone nasal product") }, // confidence: 81.0%, omop match: 100.0%
//            { "convalescent plasma", new ValueWithNote(null, null) },
////             { "convalescent plasma", new ValueWithNote("33000", "covid-19 convalescent plasma") }, // confidence: 80.9%, omop match: 100.0%
//            { "clioquinol-flumetasone otic", new ValueWithNote(null, null) },
////             { "clioquinol-flumetasone otic", new ValueWithNote("36030361", "clioquinol / flumethasone") }, // confidence: 80.8%, omop match: 100.0%
//            { "estradiol + norethisterone", new ValueWithNote(null, null) },
////             { "estradiol + norethisterone", new ValueWithNote("36030820", "ethinyl estradiol / ethisterone") }, // confidence: 80.7%, omop match: 100.0%
//            { "acetic acid otic", new ValueWithNote(null, null) },
////             { "acetic acid otic", new ValueWithNote("36217021", "acetic acid otic product") }, // confidence: 80.0%, omop match: 100.0%
//            { "benzalkonium chloride-cetrimide", new ValueWithNote(null, null) },
////             { "benzalkonium chloride-cetrimide", new ValueWithNote("36030307", "benzalkonium / cetrimide") }, // confidence: 80.0%, omop match: 100.0%
//            { "citric acid-magnesium carbonate", new ValueWithNote(null, null) },
////             { "citric acid-magnesium carbonate", new ValueWithNote("36030486", "citric acid / magnesium oxide / sodium carbonate") }, // confidence: 80.0%, omop match: 100.0%
//            { "digoxin specific antibody", new ValueWithNote(null, null) },
////             { "digoxin specific antibody", new ValueWithNote("35603726", "ovine digoxin immune fab") }, // confidence: 80.0%, omop match: 100.0%
//            { "urea (13-c)", new ValueWithNote(null, null) },
////             { "urea (13-c)", new ValueWithNote("19054337", "urea c-13") }, // confidence: 80.0%, omop match: 100.0%
//            { "potassium chloride 20mmol with glucose 5", new ValueWithNote(null, null) },
////             { "potassium chloride 20mmol with glucose 5", new ValueWithNote("36030057", "glucose / potassium chloride") }, // confidence: 79.4%, omop match: 100.0%
//            { "potassium chloride 20mmol with glucose 2", new ValueWithNote(null, null) },
////             { "potassium chloride 20mmol with glucose 2", new ValueWithNote("36030057", "glucose / potassium chloride") }, // confidence: 79.4%, omop match: 100.0%
//            { "potassium chloride 10mmol with glucose 1", new ValueWithNote(null, null) },
////             { "potassium chloride 10mmol with glucose 1", new ValueWithNote("36030057", "glucose / potassium chloride") }, // confidence: 79.4%, omop match: 100.0%
//            { "potassium chloride 10mmol with glucose 5", new ValueWithNote(null, null) },
////             { "potassium chloride 10mmol with glucose 5", new ValueWithNote("36030057", "glucose / potassium chloride") }, // confidence: 79.4%, omop match: 100.0%
//            { "potassium chloride 20mmol with glucose 1", new ValueWithNote(null, null) },
////             { "potassium chloride 20mmol with glucose 1", new ValueWithNote("36030057", "glucose / potassium chloride") }, // confidence: 79.4%, omop match: 100.0%
//            { "chlorhexidine-fluoride", new ValueWithNote(null, null) },
////             { "chlorhexidine-fluoride", new ValueWithNote("36027304", "chlorhexidine / sodium fluoride") }, // confidence: 79.2%, omop match: 100.0%
//            { "ciclosporin ophthalmic", new ValueWithNote(null, null) },
////             { "ciclosporin ophthalmic", new ValueWithNote("36213827", "cyclosporine ophthalmic product") }, // confidence: 79.2%, omop match: 100.0%
//            { "aciclovir ophthalmic", new ValueWithNote(null, null) },
////             { "aciclovir ophthalmic", new ValueWithNote("36217182", "acyclovir ophthalmic product") }, // confidence: 79.2%, omop match: 100.0%
//            { "amphotericin b (fungizone)", new ValueWithNote(null, null) },
////             { "amphotericin b (fungizone)", new ValueWithNote("19098044", "amphotericin b 30 mg/ml [fungizone]") }, // confidence: 78.7%, omop match: 100.0%
//            { "zuclopenthixol decanoate depot inject", new ValueWithNote(null, null) },
////             { "zuclopenthixol decanoate depot inject", new ValueWithNote("19121997", "zuclopenthixol decanoate") }, // confidence: 78.7%, omop match: 100.0%
//            { "insulin isophane biphasic", new ValueWithNote(null, null) },
////             { "insulin isophane biphasic", new ValueWithNote("46221581", "insulin isophane") }, // confidence: 78.0%, omop match: 100.0%
//            { "potassium ascorbate ophthalmic", new ValueWithNote(null, null) },
////             { "potassium ascorbate ophthalmic", new ValueWithNote("36027699", "calcium ascorbate / potassium") }, // confidence: 78.0%, omop match: 100.0%
//            { "fentanyl-levobupivacaine", new ValueWithNote(null, null) },
////             { "fentanyl-levobupivacaine", new ValueWithNote("19098741", "levobupivacaine") }, // confidence: 76.9%, omop match: 100.0%
//            { "cocaine nasal", new ValueWithNote(null, null) },
////             { "cocaine nasal", new ValueWithNote("36213696", "cocaine nasal product") }, // confidence: 76.5%, omop match: 100.0%
//            { "estradiol-norethisterone", new ValueWithNote(null, null) },
////             { "estradiol-norethisterone", new ValueWithNote("36030820", "ethinyl estradiol / ethisterone") }, // confidence: 76.4%, omop match: 100.0%
//            { "immunoglobulin subcutaneous", new ValueWithNote(null, null) },
////             { "immunoglobulin subcutaneous", new ValueWithNote("551749", "immunoglobulins, intravenous") }, // confidence: 76.4%, omop match: 100.0%
//            { "liquid paraffin + magnesium hydroxide", new ValueWithNote(null, null) },
////             { "liquid paraffin + magnesium hydroxide", new ValueWithNote("36215463", "magnesium hydroxide oral liquid product") }, // confidence: 76.3%, omop match: 100.0%
//            { "antazoline-xylometazoline ophthalmic", new ValueWithNote(null, null) },
////             { "antazoline-xylometazoline ophthalmic", new ValueWithNote("36030351", "antazoline / xylometazoline") }, // confidence: 76.2%, omop match: 100.0%
//            { "argipressin (vasopressin)", new ValueWithNote(null, null) },
////             { "argipressin (vasopressin)", new ValueWithNote("19006871", "argipressin") }, // confidence: 76.0%, omop match: 100.0%
//            { "betamethasone-fusidic acid", new ValueWithNote(null, null) },
////             { "betamethasone-fusidic acid", new ValueWithNote("36027464", "betamethasone / fusidate") }, // confidence: 76.0%, omop match: 100.0%
//            { "lidocaine + adrenaline + tetracaine", new ValueWithNote(null, null) },
////             { "lidocaine + adrenaline + tetracaine", new ValueWithNote("36028515", "adrenalone / tetracaine") }, // confidence: 75.9%, omop match: 100.0%
//            { "insulin aspart biphasic", new ValueWithNote(null, null) },
////             { "insulin aspart biphasic", new ValueWithNote("1567198", "insulin aspart, human") }, // confidence: 75.7%, omop match: 100.0%
//            { "insulin lispro biphasic", new ValueWithNote(null, null) },
////             { "insulin lispro biphasic", new ValueWithNote("1550023", "insulin lispro") }, // confidence: 75.7%, omop match: 100.0%
//            { "bee venom", new ValueWithNote(null, null) },
////             { "bee venom", new ValueWithNote("514834", "honey bee venom") }, // confidence: 75.0%, omop match: 100.0%
//            { "ispaghula-senna", new ValueWithNote(null, null) },
////             { "ispaghula-senna", new ValueWithNote("19132967", "ispaghula extract") }, // confidence: 75.0%, omop match: 100.0%
//            { "terpin + codeine", new ValueWithNote(null, null) },
////             { "terpin + codeine", new ValueWithNote("36030564", "codeine / terpin hydrate") }, // confidence: 75.0%, omop match: 100.0%
//            { "alpha tocopherol + selenium", new ValueWithNote(null, null) },
////             { "alpha tocopherol + selenium", new ValueWithNote("19056802", "alpha tocopherol") }, // confidence: 74.4%, omop match: 100.0%
//            { "brinzolamide-timolol ophthalmic", new ValueWithNote(null, null) },
////             { "brinzolamide-timolol ophthalmic", new ValueWithNote("36219538", "brinzolamide ophthalmic product") }, // confidence: 74.2%, omop match: 100.0%
//            { "phenoxymethylpenicillin potassium", new ValueWithNote(null, null) },
////             { "phenoxymethylpenicillin potassium", new ValueWithNote("19133859", "penicillin v potassium 50 mg/ml oral solution") }, // confidence: 74.2%, omop match: 100.0%
//            { "glucose 4% with 0.18% sodium chloride in", new ValueWithNote(null, null) },
////             { "glucose 4% with 0.18% sodium chloride in", new ValueWithNote("36029299", "glucose / sodium chloride") }, // confidence: 73.8%, omop match: 100.0%
//            { "glucose 5% with 0.45% sodium chloride in", new ValueWithNote(null, null) },
////             { "glucose 5% with 0.45% sodium chloride in", new ValueWithNote("36029299", "glucose / sodium chloride") }, // confidence: 73.8%, omop match: 100.0%
//            { "glucose 5% with 0.9% sodium chloride int", new ValueWithNote(null, null) },
////             { "glucose 5% with 0.9% sodium chloride int", new ValueWithNote("36029299", "glucose / sodium chloride") }, // confidence: 73.8%, omop match: 100.0%
//            { "glucose 10% with sodium chloride 0.18% i", new ValueWithNote(null, null) },
////             { "glucose 10% with sodium chloride 0.18% i", new ValueWithNote("36029299", "glucose / sodium chloride") }, // confidence: 73.8%, omop match: 100.0%
//            { "brimonidine-timolol ophthalmic", new ValueWithNote(null, null) },
////             { "brimonidine-timolol ophthalmic", new ValueWithNote("36030258", "brimonidine / timolol") }, // confidence: 73.5%, omop match: 100.0%
//            { "dorzolamide-timolol ophthalmic", new ValueWithNote(null, null) },
////             { "dorzolamide-timolol ophthalmic", new ValueWithNote("36030344", "dorzolamide / timolol") }, // confidence: 73.5%, omop match: 100.0%
//            { "bimatoprost-timolol ophthalmic", new ValueWithNote(null, null) },
////             { "bimatoprost-timolol ophthalmic", new ValueWithNote("36226260", "bimatoprost ophthalmic product") }, // confidence: 73.3%, omop match: 100.0%
//            { "liquid paraffin ophthalmic", new ValueWithNote(null, null) },
////             { "liquid paraffin ophthalmic", new ValueWithNote("908523", "mineral oil") }, // confidence: 73.2%, omop match: 100.0%
//            { "ichthammol-zinc oxide", new ValueWithNote(null, null) },
////             { "ichthammol-zinc oxide", new ValueWithNote("36030285", "ichthammol / zinc oxide") }, // confidence: 72.7%, omop match: 100.0%
//            { "tafluprost-timolol ophthalmic", new ValueWithNote(null, null) },
////             { "tafluprost-timolol ophthalmic", new ValueWithNote("36238005", "tafluprost ophthalmic product") }, // confidence: 72.4%, omop match: 100.0%
//            { "trometamol (tham))", new ValueWithNote(null, null) },
////             { "trometamol (tham))", new ValueWithNote("1511352", "trometamol citrate") }, // confidence: 72.2%, omop match: 100.0%
//            { "dexamethasone/neomycin/polymyxin b ophth", new ValueWithNote(null, null) },
////             { "dexamethasone/neomycin/polymyxin b ophth", new ValueWithNote("36213940", "dexamethasone / neomycin / polymyxin b ophthalmic product") }, // confidence: 72.2%, omop match: 100.0%
//            { "piperacillin-tazobactam (tazocin equival", new ValueWithNote(null, null) },
////             { "piperacillin-tazobactam (tazocin equival", new ValueWithNote("46275426", "piperacillin / tazobactam injection") }, // confidence: 72.0%, omop match: 100.0%
//            { "proxymetacaine ophthalmic", new ValueWithNote(null, null) },
////             { "proxymetacaine ophthalmic", new ValueWithNote("929504", "proparacaine") }, // confidence: 71.8%, omop match: 100.0%
//            { "lidocaine-zinc oxide", new ValueWithNote(null, null) },
////             { "lidocaine-zinc oxide", new ValueWithNote("36030290", "lidocaine / zinc oxide") }, // confidence: 71.4%, omop match: 100.0%
//            { "sodium alginate-potassium bicarbonate", new ValueWithNote(null, null) },
////             { "sodium alginate-potassium bicarbonate", new ValueWithNote("36028316", "alginic acid / sodium bicarbonate") }, // confidence: 71.4%, omop match: 100.0%
//            { "acetic acid/dexamethasone/neomycin otic", new ValueWithNote(null, null) },
////             { "acetic acid/dexamethasone/neomycin otic", new ValueWithNote("36213943", "dexamethasone / neomycin otic product") }, // confidence: 71.1%, omop match: 100.0%
//            { "calcium citrate + colecalciferol", new ValueWithNote(null, null) },
////             { "calcium citrate + colecalciferol", new ValueWithNote("36027950", "calcium citrate / cholecalciferol") }, // confidence: 70.8%, omop match: 100.0%
//            { "al hydroxide/mg hydroxide/simeticone", new ValueWithNote(null, null) },
////             { "al hydroxide/mg hydroxide/simeticone", new ValueWithNote("36027592", "aluminum hydroxide / simethicone") }, // confidence: 70.6%, omop match: 100.0%
//            { "latanoprost-timolol ophthalmic", new ValueWithNote(null, null) },
////             { "latanoprost-timolol ophthalmic", new ValueWithNote("36030140", "latanoprost / timolol") }, // confidence: 70.6%, omop match: 100.0%
//            { "oxybuprocaine ophthalmic", new ValueWithNote(null, null) },
////             { "oxybuprocaine ophthalmic", new ValueWithNote("935529", "benoxinate") }, // confidence: 70.3%, omop match: 100.0%
//            { "soft paraffin + wool fat", new ValueWithNote(null, null) },
////             { "soft paraffin + wool fat", new ValueWithNote("19033354", "petrolatum") }, // confidence: 70.3%, omop match: 100.0%
//            { "corticotrophin releasing hormone", new ValueWithNote(null, null) },
////             { "corticotrophin releasing hormone", new ValueWithNote("19048699", "corticotropin-releasing hormone") }, // confidence: 69.8%, omop match: 100.0%
//            { "alginic acid/calcium carbonate/na bic", new ValueWithNote(null, null) },
////             { "alginic acid/calcium carbonate/na bic", new ValueWithNote("36027575", "alginic acid / calcium carbonate") }, // confidence: 69.6%, omop match: 100.0%
//            { "calcium acetate-magnesium carbonate", new ValueWithNote(null, null) },
////             { "calcium acetate-magnesium carbonate", new ValueWithNote("778779", "calcium acetate / magnesium carbonate") }, // confidence: 69.4%, omop match: 100.0%
//            { "aluminium acetate", new ValueWithNote(null, null) },
////             { "aluminium acetate", new ValueWithNote("42898412", "aluminum") }, // confidence: 69.2%, omop match: 100.0%
//            { "polihexanide ophthalmic", new ValueWithNote(null, null) },
////             { "polihexanide ophthalmic", new ValueWithNote("43525903", "polihexanide") }, // confidence: 68.6%, omop match: 100.0%
//            { "mercaptamine ophthalmic", new ValueWithNote(null, null) },
////             { "mercaptamine ophthalmic", new ValueWithNote("910888", "cysteamine") }, // confidence: 68.6%, omop match: 100.0%
//            { "liquid paraffin + isopropyl myristate", new ValueWithNote(null, null) },
////             { "liquid paraffin + isopropyl myristate", new ValueWithNote("19003568", "isopropyl myristate") }, // confidence: 67.9%, omop match: 100.0%
//            { "mg acetate/mg carbonate/mg hydroxide", new ValueWithNote(null, null) },
////             { "mg acetate/mg carbonate/mg hydroxide", new ValueWithNote("43012385", "magnesium carbonate hydroxide") }, // confidence: 67.7%, omop match: 100.0%
//            { "continuous epidural infusion", new ValueWithNote(null, null) },
////             { "continuous epidural infusion", new ValueWithNote("19100021", "pranoxen continus") }, // confidence: 66.7%, omop match: 100.0%
//            { "dexamethasone-tobramycin ophthalmic", new ValueWithNote(null, null) },
////             { "dexamethasone-tobramycin ophthalmic", new ValueWithNote("40027456", "dexamethasone / tobramycin ophthalmic ointment") }, // confidence: 66.7%, omop match: 100.0%
//            { "ispaghula-mebeverine", new ValueWithNote(null, null) },
////             { "ispaghula-mebeverine", new ValueWithNote("19008994", "mebeverine") }, // confidence: 66.7%, omop match: 100.0%
//            { "white soft paraffin + liquid paraffin", new ValueWithNote(null, null) },
////             { "white soft paraffin + liquid paraffin", new ValueWithNote("19033354", "petrolatum") }, // confidence: 66.7%, omop match: 100.0%
//            { "potassium acid tartrate-potassium bicarb", new ValueWithNote(null, null) },
////             { "potassium acid tartrate-potassium bicarb", new ValueWithNote("36027949", "potassium bicarbonate / potassium tartrate") }, // confidence: 65.9%, omop match: 100.0%
//            { "glucose 2.5% with 0.45% sodium chloride", new ValueWithNote(null, null) },
////             { "glucose 2.5% with 0.45% sodium chloride", new ValueWithNote("40221365", "50 ml sodium chloride 4.5 mg/ml injection") }, // confidence: 65.7%, omop match: 100.0%
//            { "imipenem/cilastatin/relebactam", new ValueWithNote(null, null) },
////             { "imipenem/cilastatin/relebactam", new ValueWithNote("36030067", "cilastatin / imipenem / relebactam") }, // confidence: 65.6%, omop match: 100.0%
//            { "haemophilus b-meningococcal conj vaccine", new ValueWithNote(null, null) },
////             { "haemophilus b-meningococcal conj vaccine", new ValueWithNote("530009", "0.5 ml haemophilus influenzae b (ross strain) capsular polysaccharide meningococcal protein conjugate vaccine 0.265 mg/ml injection") }, // confidence: 65.5%, omop match: 100.0%
//            { "glucose 5% to", new ValueWithNote(null, null) },
////             { "glucose 5% to", new ValueWithNote("19095012", "glucose 82.5 mg/ml") }, // confidence: 64.5%, omop match: 100.0%
//            { "calamine-glycerol", new ValueWithNote(null, null) },
////             { "calamine-glycerol", new ValueWithNote("961145", "glycerin") }, // confidence: 64.0%, omop match: 100.0%
//            { "fusidic acid ophthalmic", new ValueWithNote(null, null) },
////             { "fusidic acid ophthalmic", new ValueWithNote("36220424", "fusidate ophthalmic product") }, // confidence: 64.0%, omop match: 100.0%
//            { "calamine-menthol", new ValueWithNote(null, null) },
////             { "calamine-menthol", new ValueWithNote("36029578", "calamine / menthol / zinc oxide") }, // confidence: 63.8%, omop match: 100.0%
//            { "continuous subcutaneous", new ValueWithNote(null, null) },
////             { "continuous subcutaneous", new ValueWithNote("19053549", "mst continus") }, // confidence: 62.9%, omop match: 100.0%
//            { "dronabinol + cannabidiol", new ValueWithNote(null, null) },
////             { "dronabinol + cannabidiol", new ValueWithNote("1510417", "cannabidiol") }, // confidence: 62.9%, omop match: 100.0%
//            { "hamamelis ophthalmic", new ValueWithNote(null, null) },
////             { "hamamelis ophthalmic", new ValueWithNote("959196", "witch hazel") }, // confidence: 62.9%, omop match: 100.0%
//            { "sng001 (interferon -ß1a)", new ValueWithNote(null, null) },
////             { "sng001 (interferon -ß1a)", new ValueWithNote("40053881", "interferons") }, // confidence: 62.9%, omop match: 100.0%
//            { "adrenaline-lidocaine", new ValueWithNote(null, null) },
////             { "adrenaline-lidocaine", new ValueWithNote("44814295", "adrenalin") }, // confidence: 62.1%, omop match: 100.0%
//            { "alteplase ophthalmic", new ValueWithNote(null, null) },
////             { "alteplase ophthalmic", new ValueWithNote("1347450", "alteplase") }, // confidence: 62.1%, omop match: 100.0%
//            { "fusidic acid-hydrocortisone", new ValueWithNote(null, null) },
////             { "fusidic acid-hydrocortisone", new ValueWithNote("36028432", "fusidate / hydrocortisone") }, // confidence: 61.5%, omop match: 100.0%
//            { "dexamethasone/framycetin/gramicid ophth", new ValueWithNote(null, null) },
////             { "dexamethasone/framycetin/gramicid ophth", new ValueWithNote("36027970", "framycetin / gramicidin") }, // confidence: 61.3%, omop match: 100.0%
//            { "castor oil + zinc oxide", new ValueWithNote(null, null) },
////             { "castor oil + zinc oxide", new ValueWithNote("950933", "castor oil") }, // confidence: 60.6%, omop match: 100.0%
//            { "meningococcal groups a + c + w135 + y", new ValueWithNote(null, null) },
////             { "meningococcal groups a + c + w135 + y", new ValueWithNote("514015", "meningococcal polysaccharide vaccine group y") }, // confidence: 59.3%, omop match: 100.0%
//            { "potassium chloride 0.2% (27 mmol/l) in g", new ValueWithNote(null, null) },
////             { "potassium chloride 0.2% (27 mmol/l) in g", new ValueWithNote("19101198", "potassium 7.7 mmol") }, // confidence: 58.6%, omop match: 100.0%
//            { "potassium chloride 0.6% (80 mmol/l) in s", new ValueWithNote(null, null) },
////             { "potassium chloride 0.6% (80 mmol/l) in s", new ValueWithNote("19101211", "potassium 8.4 mmol") }, // confidence: 58.6%, omop match: 100.0%
//            { "adrenaline-bupivacaine", new ValueWithNote(null, null) },
////             { "adrenaline-bupivacaine", new ValueWithNote("44814295", "adrenalin") }, // confidence: 58.1%, omop match: 100.0%
//            { "frangula-sterculia", new ValueWithNote(null, null) },
////             { "frangula-sterculia", new ValueWithNote("19016537", "frangula preparation") }, // confidence: 57.9%, omop match: 100.0%
//            { "continuous subcutaneous infusion", new ValueWithNote(null, null) },
////             { "continuous subcutaneous infusion", new ValueWithNote("19100536", "nitrocontin continus") }, // confidence: 57.7%, omop match: 100.0%
//            { "mercaptamine (cysteamine)", new ValueWithNote(null, null) },
////             { "mercaptamine (cysteamine)", new ValueWithNote("910888", "cysteamine") }, // confidence: 57.1%, omop match: 100.0%
//            { "potassium chloride 0.15% (20 mmol/l) in", new ValueWithNote(null, null) },
////             { "potassium chloride 0.15% (20 mmol/l) in", new ValueWithNote("19101200", "potassium 10 mmol") }, // confidence: 57.1%, omop match: 100.0%
//            { "clobetasol/oxytetracycline/nystatin topi", new ValueWithNote(null, null) },
////             { "clobetasol/oxytetracycline/nystatin topi", new ValueWithNote("36227369", "nystatin / oxytetracycline pill") }, // confidence: 56.3%, omop match: 100.0%
//            { "bupivacaine + clonidine", new ValueWithNote(null, null) },
////             { "bupivacaine + clonidine", new ValueWithNote("1398937", "clonidine") }, // confidence: 56.2%, omop match: 100.0%
//            { "potassium chloride 0.3% (40 mmol/l) in s", new ValueWithNote(null, null) },
////             { "potassium chloride 0.3% (40 mmol/l) in s", new ValueWithNote("19101200", "potassium 10 mmol") }, // confidence: 56.1%, omop match: 100.0%
//            { "potassium chloride 0.3% (40 mmol/l) in g", new ValueWithNote(null, null) },
////             { "potassium chloride 0.3% (40 mmol/l) in g", new ValueWithNote("19101200", "potassium 10 mmol") }, // confidence: 56.1%, omop match: 100.0%
//            { "estriol applicator", new ValueWithNote(null, null) },
////             { "estriol applicator", new ValueWithNote("19049038", "estriol") }, // confidence: 56.0%, omop match: 100.0%
//            { "estradiol-dydrogesterone", new ValueWithNote(null, null) },
////             { "estradiol-dydrogesterone", new ValueWithNote("36030766", "dydrogesterone / estradiol") }, // confidence: 56.0%, omop match: 100.0%
//            { "emulsifying ointment + phenoxyethanol", new ValueWithNote(null, null) },
////             { "emulsifying ointment + phenoxyethanol", new ValueWithNote("19058343", "phenoxyethanol") }, // confidence: 54.9%, omop match: 100.0%
//            { "insulin isophane porcine", new ValueWithNote(null, null) },
////             { "insulin isophane porcine", new ValueWithNote("40052072", "insulin isophane injectable suspension [hypurin porcine isophane]") }, // confidence: 53.9%, omop match: 100.0%
//            { "retinol + vitamin d", new ValueWithNote(null, null) },
////             { "retinol + vitamin d", new ValueWithNote("19008339", "vitamin a") }, // confidence: 53.8%, omop match: 100.0%
//            { "chlorhexidine-nystatin", new ValueWithNote(null, null) },
////             { "chlorhexidine-nystatin", new ValueWithNote("922570", "nystatin") }, // confidence: 53.3%, omop match: 100.0%
//            { "paed 3k 1l (aqueous)", new ValueWithNote(null, null) },
////             { "paed 3k 1l (aqueous)", new ValueWithNote("43526318", "potassium triiodide") }, // confidence: 52.9%, omop match: 100.0%
//            { "al hydroxide/dicycloverine/mgo/simet", new ValueWithNote(null, null) },
////             { "al hydroxide/dicycloverine/mgo/simet", new ValueWithNote("36029063", "magnesium hydroxide / simethicone") }, // confidence: 52.2%, omop match: 100.0%
//            { "sodium bicarbonate-sodium biphosphate", new ValueWithNote(null, null) },
////             { "sodium bicarbonate-sodium biphosphate", new ValueWithNote("36029231", "potassium bicarbonate / sodium bicarbonate / sodium citrate") }, // confidence: 52.1%, omop match: 100.0%
//            { "neonatal main (aqueous)", new ValueWithNote(null, null) },
////             { "neonatal main (aqueous)", new ValueWithNote("19053623", "opticrom aqueous") }, // confidence: 51.3%, omop match: 100.0%
//            { "ubidecarenone (ubiquinone)", new ValueWithNote(null, null) },
////             { "ubidecarenone (ubiquinone)", new ValueWithNote("43526994", "ubiquinone q2") }, // confidence: 51.3%, omop match: 100.0%
//            { "benzalkonium/dimeticone/hc/nystatin top", new ValueWithNote(null, null) },
////             { "benzalkonium/dimeticone/hc/nystatin top", new ValueWithNote("40167927", "benzalkonium topical gel [sentry hc hotspot]") }, // confidence: 50.6%, omop match: 100.0%
//            { "neat", new ValueWithNote(null, null) },
////             { "neat", new ValueWithNote("42904273", "neatsfoot oil") }, // confidence: 47.1%, omop match: 100.0%
//            { "cetylpyridium/chlorocresol/lidocaine top", new ValueWithNote(null, null) },
////             { "cetylpyridium/chlorocresol/lidocaine top", new ValueWithNote("19037891", "chlorocresol") }, // confidence: 46.2%, omop match: 100.0%
//            { "pca", new ValueWithNote(null, null) },
////             { "pca", new ValueWithNote("43531981", "lauryl pca") }, // confidence: 46.2%, omop match: 100.0%
//            { "imipenem-cilastatin", new ValueWithNote(null, null) },
////             { "imipenem-cilastatin", new ValueWithNote("36030067", "cilastatin / imipenem / relebactam") }, // confidence: 44.4%, omop match: 100.0%
//            { "drug chart reminder", new ValueWithNote(null, null) },
////             { "drug chart reminder", new ValueWithNote("40175669", "stachybotrys chartarum allergenic extract") }, // confidence: 43.9%, omop match: 100.0%
//            { "guselkumab-golimumab-jnj78934804", new ValueWithNote(null, null) },
////             { "guselkumab-golimumab-jnj78934804", new ValueWithNote("19041065", "golimumab") }, // confidence: 43.9%, omop match: 100.0%
//            { "amifampridine (3,4 dap)", new ValueWithNote(null, null) },
////             { "amifampridine (3,4 dap)", new ValueWithNote("1355889", "amifampridine") }, // confidence: 40.0%, omop match: 100.0%
//            { "additional chemotherapy and/or chemother", new ValueWithNote(null, null) },
////             { "additional chemotherapy and/or chemother", new ValueWithNote("36232901", "baza cleanse and protect medicated pad or tape") }, // confidence: 39.5%, omop match: 100.0%
            //{ "bcg", new ValueWithNote(null, null) },
//             { "bcg", new ValueWithNote("36248976", "tice bcg topical product") }, // confidence: 22.2%, omop match: 100.0%
            { "taurolock", new ValueWithNote("2901073", "taurolock") },
//             { "taurolock", new ValueWithNote("2901073", "taurolock") }, // confidence: 0.0%, omop match: 100.0%
            { "hepatitis a vaccine", new ValueWithNote("40047409", "hepatitis a vaccines") },
//             { "hepatitis a vaccine", new ValueWithNote("40047409", "hepatitis a vaccines") }, // confidence: 100.0%, omop match: 97.4%
            { "calcium-vitamin d", new ValueWithNote("43126501", "calcium/vitamine d") },
//             { "calcium-vitamin d", new ValueWithNote("43126501", "calcium/vitamine d") }, // confidence: 94.1%, omop match: 97.1%
            { "dibotermin alfa", new ValueWithNote("43126075", "alfa dibotermin") },
//             { "dibotermin alfa", new ValueWithNote("43126075", "alfa dibotermin") }, // confidence: 100.0%, omop match: 93.3%
            { "co-trimoxazole", new ValueWithNote("21018085", "co-trimoxazole") },
//             { "co-trimoxazole", new ValueWithNote("21018085", "co-trimoxazole") }, // confidence: 0.0%, omop match: 92.9%
            { "co-danthrusate", new ValueWithNote("21015003", "co-danthrusate") },
//             { "co-danthrusate", new ValueWithNote("21015003", "co-danthrusate") }, // confidence: 0.0%, omop match: 92.9%
            { "co-amilofruse", new ValueWithNote("21014899", "co-amilofruse") },
//             { "co-amilofruse", new ValueWithNote("21014899", "co-amilofruse") }, // confidence: 0.0%, omop match: 92.3%
            { "co-danthramer", new ValueWithNote("21014474", "co-danthramer") },
//             { "co-danthramer", new ValueWithNote("21014474", "co-danthramer") }, // confidence: 0.0%, omop match: 92.3%
            { "co-cyprindiol", new ValueWithNote("21014586", "co-cyprindiol") },
//             { "co-cyprindiol", new ValueWithNote("21014586", "co-cyprindiol") }, // confidence: 0.0%, omop match: 92.3%
            { "grass pollen", new ValueWithNote("36879220", "grass pollen") },
//             { "grass pollen", new ValueWithNote("36879220", "grass pollen") }, // confidence: 100.0%, omop match: 91.7%
            { "co-magaldrox", new ValueWithNote("21018430", "co-magaldrox") },
//             { "co-magaldrox", new ValueWithNote("21018430", "co-magaldrox") }, // confidence: 0.0%, omop match: 91.7%
            { "co-amilozide", new ValueWithNote("21018645", "co-amilozide") },
//             { "co-amilozide", new ValueWithNote("21018645", "co-amilozide") }, // confidence: 0.0%, omop match: 91.7%
            { "co-careldopa", new ValueWithNote("21017760", "co-careldopa") },
//             { "co-careldopa", new ValueWithNote("21017760", "co-careldopa") }, // confidence: 0.0%, omop match: 91.7%
            { "co-amoxiclav", new ValueWithNote("21015284", "co-amoxiclav") },
//             { "co-amoxiclav", new ValueWithNote("21015284", "co-amoxiclav") }, // confidence: 0.0%, omop match: 91.7%
            { "co-beneldopa", new ValueWithNote("21014753", "co-beneldopa") },
//             { "co-beneldopa", new ValueWithNote("21014753", "co-beneldopa") }, // confidence: 0.0%, omop match: 91.7%
            { "rotavirus vaccine", new ValueWithNote("19018193", "rotavirus vaccines") },
//             { "rotavirus vaccine", new ValueWithNote("19018193", "rotavirus vaccines") }, // confidence: 100.0%, omop match: 91.4%
            { "agomelatine", new ValueWithNote("21014017", "agomelatine") },
//             { "agomelatine", new ValueWithNote("21014017", "agomelatine") }, // confidence: 100.0%, omop match: 90.9%
            { "co-dydramol", new ValueWithNote("21016567", "co-dydramol") },
//             { "co-dydramol", new ValueWithNote("21016567", "co-dydramol") }, // confidence: 0.0%, omop match: 90.9%
            { "co-tenidone", new ValueWithNote("21015431", "co-tenidone") },
//             { "co-tenidone", new ValueWithNote("21015431", "co-tenidone") }, // confidence: 0.0%, omop match: 90.9%
            { "rupatadine", new ValueWithNote("21014003", "rupatadine") },
//             { "rupatadine", new ValueWithNote("21014003", "rupatadine") }, // confidence: 100.0%, omop match: 90.0%
            { "zonisamide", new ValueWithNote("744798", "zonisamide") },
//             { "zonisamide", new ValueWithNote("744798", "zonisamide") }, // confidence: 100.0%, omop match: 90.0%
//            { "co-codamol", new ValueWithNote(null, null) },
////             { "co-codamol", new ValueWithNote("21018553", "co-codamol") }, // confidence: 0.0%, omop match: 90.0%
//            { "asundexian", new ValueWithNote(null, null) },
////             { "asundexian", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "bilastine", new ValueWithNote(null, null) },
////             { "bilastine", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "bictegravir/emtricitabine/tenofovir", new ValueWithNote(null, null) },
////             { "bictegravir/emtricitabine/tenofovir", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "argx-119", new ValueWithNote(null, null) },
////             { "argx-119", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "covid-19 vaccine", new ValueWithNote(null, null) },
////             { "covid-19 vaccine", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "efavirenz/emtricitabine/tenofovir", new ValueWithNote(null, null) },
////             { "efavirenz/emtricitabine/tenofovir", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "emtricitabine/rilpivirine/tenofovir", new ValueWithNote(null, null) },
////             { "emtricitabine/rilpivirine/tenofovir", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "doravirine/lamivudine/tenofovir", new ValueWithNote(null, null) },
////             { "doravirine/lamivudine/tenofovir", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "gelclair", new ValueWithNote(null, null) },
////             { "gelclair", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "enteral nutrition", new ValueWithNote(null, null) },
////             { "enteral nutrition", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "gtx-102", new ValueWithNote(null, null) },
////             { "gtx-102", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "insulin soluble", new ValueWithNote(null, null) },
////             { "insulin soluble", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "ion582", new ValueWithNote(null, null) },
////             { "ion582", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "namilumab", new ValueWithNote(null, null) },
////             { "namilumab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "ianalumab", new ValueWithNote(null, null) },
////             { "ianalumab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "pneumococcal 13-valent conjugate vaccine", new ValueWithNote(null, null) },
////             { "pneumococcal 13-valent conjugate vaccine", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "infant formulas", new ValueWithNote(null, null) },
////             { "infant formulas", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "obexelimab", new ValueWithNote(null, null) },
////             { "obexelimab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "smallpox vaccine", new ValueWithNote(null, null) },
////             { "smallpox vaccine", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "lutikizumab", new ValueWithNote(null, null) },
////             { "lutikizumab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "probiotic", new ValueWithNote(null, null) },
////             { "probiotic", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "turoctocog alfa pegol", new ValueWithNote(null, null) },
////             { "turoctocog alfa pegol", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "silicified microcrystalline cellulose", new ValueWithNote(null, null) },
////             { "silicified microcrystalline cellulose", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "trace elements", new ValueWithNote(null, null) },
////             { "trace elements", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "rurioctocog alfa pegol", new ValueWithNote(null, null) },
////             { "rurioctocog alfa pegol", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "volixibat", new ValueWithNote(null, null) },
////             { "volixibat", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "xtmab-16", new ValueWithNote(null, null) },
////             { "xtmab-16", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "wve-n531", new ValueWithNote(null, null) },
////             { "wve-n531", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "yellow soft paraffin", new ValueWithNote(null, null) },
////             { "yellow soft paraffin", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "apitegromab", new ValueWithNote(null, null) },
////             { "apitegromab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "fluoride", new ValueWithNote(null, null) },
////             { "fluoride", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "pamrevlumab", new ValueWithNote(null, null) },
////             { "pamrevlumab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "prasinezumab", new ValueWithNote(null, null) },
////             { "prasinezumab", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "prothrombin complex", new ValueWithNote(null, null) },
////             { "prothrombin complex", new ValueWithNote(null, null) }, // confidence: 100.0%, omop match: 0.0%
//            { "potassium bicarbonate-potassium chloride", new ValueWithNote(null, null) },
////             { "potassium bicarbonate-potassium chloride", new ValueWithNote(null, null) }, // confidence: 97.5%, omop match: 0.0%
//            { "potassium phosphate-sodium phosphate", new ValueWithNote(null, null) },
////             { "potassium phosphate-sodium phosphate", new ValueWithNote(null, null) }, // confidence: 97.2%, omop match: 0.0%
//            { "meningococcal conjugate vaccine", new ValueWithNote(null, null) },
////             { "meningococcal conjugate vaccine", new ValueWithNote(null, null) }, // confidence: 96.9%, omop match: 0.0%
//            { "benzoic acid-salicylic acid", new ValueWithNote(null, null) },
////             { "benzoic acid-salicylic acid", new ValueWithNote(null, null) }, // confidence: 96.3%, omop match: 0.0%
//            { "lactic acid-salicylic acid", new ValueWithNote(null, null) },
////             { "lactic acid-salicylic acid", new ValueWithNote(null, null) }, // confidence: 96.2%, omop match: 0.0%
//            { "emtricitabine-tenofovir", new ValueWithNote(null, null) },
////             { "emtricitabine-tenofovir", new ValueWithNote(null, null) }, // confidence: 95.7%, omop match: 0.0%
//            { "nirmatrelvir-ritonavir", new ValueWithNote(null, null) },
////             { "nirmatrelvir-ritonavir", new ValueWithNote(null, null) }, // confidence: 95.5%, omop match: 0.0%
//            { "bupivacaine-fentanyl", new ValueWithNote(null, null) },
////             { "bupivacaine-fentanyl", new ValueWithNote(null, null) }, // confidence: 95.0%, omop match: 0.0%
//            { "lactic acid-urea", new ValueWithNote(null, null) },
////             { "lactic acid-urea", new ValueWithNote(null, null) }, // confidence: 93.8%, omop match: 0.0%
//            { "sodium hyaluronate ophthalmic", new ValueWithNote(null, null) },
////             { "sodium hyaluronate ophthalmic", new ValueWithNote(null, null) }, // confidence: 93.5%, omop match: 0.0%
//            { "water for injection to", new ValueWithNote(null, null) },
////             { "water for injection to", new ValueWithNote(null, null) }, // confidence: 92.7%, omop match: 0.0%
//            { "hydrocortisone + urea", new ValueWithNote(null, null) },
////             { "hydrocortisone + urea", new ValueWithNote(null, null) }, // confidence: 90.0%, omop match: 0.0%
//            { "beclometasone-formoterol", new ValueWithNote(null, null) },
////             { "beclometasone-formoterol", new ValueWithNote(null, null) }, // confidence: 88.5%, omop match: 0.0%
//            { "argx-117", new ValueWithNote(null, null) },
////             { "argx-117", new ValueWithNote(null, null) }, // confidence: 87.5%, omop match: 0.0%
//            { "fluticasone-formoterol", new ValueWithNote(null, null) },
////             { "fluticasone-formoterol", new ValueWithNote(null, null) }, // confidence: 87.5%, omop match: 0.0%
//            { "metformin-vildagliptin", new ValueWithNote(null, null) },
////             { "metformin-vildagliptin", new ValueWithNote(null, null) }, // confidence: 87.5%, omop match: 0.0%
//            { "hepatitis b adult vaccine", new ValueWithNote(null, null) },
////             { "hepatitis b adult vaccine", new ValueWithNote(null, null) }, // confidence: 86.2%, omop match: 0.0%
//            { "human papillomavirus vaccine", new ValueWithNote(null, null) },
////             { "human papillomavirus vaccine", new ValueWithNote(null, null) }, // confidence: 86.2%, omop match: 0.0%
//            { "measles/mumps/rubella vaccine", new ValueWithNote(null, null) },
////             { "measles/mumps/rubella vaccine", new ValueWithNote(null, null) }, // confidence: 85.7%, omop match: 0.0%
//            { "gramicid/neomy/nystatin/triamcin otic", new ValueWithNote(null, null) },
////             { "gramicid/neomy/nystatin/triamcin otic", new ValueWithNote(null, null) }, // confidence: 83.5%, omop match: 0.0%
//            { "diphtheria/poliomyelitis/tetanus vaccine", new ValueWithNote(null, null) },
////             { "diphtheria/poliomyelitis/tetanus vaccine", new ValueWithNote(null, null) }, // confidence: 83.3%, omop match: 0.0%
//            { "bacillus calmette-guérin", new ValueWithNote(null, null) },
////             { "bacillus calmette-guérin", new ValueWithNote(null, null) }, // confidence: 82.1%, omop match: 0.0%
//            { "sodium chloride, hypertonic, ophthalmic", new ValueWithNote(null, null) },
////             { "sodium chloride, hypertonic, ophthalmic", new ValueWithNote(null, null) }, // confidence: 81.8%, omop match: 0.0%
//            { "hepatitis a-hepatitis b vaccine", new ValueWithNote(null, null) },
////             { "hepatitis a-hepatitis b vaccine", new ValueWithNote(null, null) }, // confidence: 81.5%, omop match: 0.0%
//            { "sodium bicarbonate-sodium chloride top", new ValueWithNote(null, null) },
////             { "sodium bicarbonate-sodium chloride top", new ValueWithNote(null, null) }, // confidence: 81.5%, omop match: 0.0%
//            { "beclometasone/formoterol/glycopyrronium", new ValueWithNote(null, null) },
////             { "beclometasone/formoterol/glycopyrronium", new ValueWithNote(null, null) }, // confidence: 81.3%, omop match: 0.0%
//            { "conjugated estrogens-medroxyprogesterone", new ValueWithNote(null, null) },
////             { "conjugated estrogens-medroxyprogesterone", new ValueWithNote(null, null) }, // confidence: 81.2%, omop match: 0.0%
//            { "other supplements", new ValueWithNote(null, null) },
////             { "other supplements", new ValueWithNote(null, null) }, // confidence: 81.0%, omop match: 0.0%
//            { "calamine/coal tar/zinc oxide", new ValueWithNote(null, null) },
////             { "calamine/coal tar/zinc oxide", new ValueWithNote(null, null) }, // confidence: 80.9%, omop match: 0.0%
//            { "estradiol + norethisterone acetate", new ValueWithNote(null, null) },
////             { "estradiol + norethisterone acetate", new ValueWithNote(null, null) }, // confidence: 77.8%, omop match: 0.0%
//            { "diphth/hib/pertussis/polio/tetanus vacc", new ValueWithNote(null, null) },
////             { "diphth/hib/pertussis/polio/tetanus vacc", new ValueWithNote(null, null) }, // confidence: 77.6%, omop match: 0.0%
//            { "darunavir + cobicistat + emtricitabine +", new ValueWithNote(null, null) },
////             { "darunavir + cobicistat + emtricitabine +", new ValueWithNote(null, null) }, // confidence: 76.2%, omop match: 0.0%
//            { "taldefgrobep alfa (bhv-2000)", new ValueWithNote(null, null) },
////             { "taldefgrobep alfa (bhv-2000)", new ValueWithNote(null, null) }, // confidence: 75.6%, omop match: 0.0%
//            { "jnj-67484703", new ValueWithNote(null, null) },
////             { "jnj-67484703", new ValueWithNote(null, null) }, // confidence: 75.0%, omop match: 0.0%
//            { "oral rehydration salts", new ValueWithNote(null, null) },
////             { "oral rehydration salts", new ValueWithNote(null, null) }, // confidence: 75.0%, omop match: 0.0%
//            { "calcium carbonate-ca lactate gluconate", new ValueWithNote(null, null) },
////             { "calcium carbonate-ca lactate gluconate", new ValueWithNote(null, null) }, // confidence: 74.0%, omop match: 0.0%
//            { "pneumococcal 23-polyvalent vaccine", new ValueWithNote(null, null) },
////             { "pneumococcal 23-polyvalent vaccine", new ValueWithNote(null, null) }, // confidence: 73.1%, omop match: 0.0%
//            { "covid-19 mrna vaccine (pfizer / biont", new ValueWithNote(null, null) },
////             { "covid-19 mrna vaccine (pfizer / biont", new ValueWithNote(null, null) }, // confidence: 72.4%, omop match: 0.0%
//            { "nirmatrelvir (pf-07321332) + ritonavir", new ValueWithNote(null, null) },
////             { "nirmatrelvir (pf-07321332) + ritonavir", new ValueWithNote(null, null) }, // confidence: 71.9%, omop match: 0.0%
//            { "sodium cromoglicate ophthalmic", new ValueWithNote(null, null) },
////             { "sodium cromoglicate ophthalmic", new ValueWithNote(null, null) }, // confidence: 71.9%, omop match: 0.0%
//            { "sodium cromoglicate", new ValueWithNote(null, null) },
////             { "sodium cromoglicate", new ValueWithNote(null, null) }, // confidence: 71.7%, omop match: 0.0%
//            { "alginate/calcium co3/sodium bicarbonate", new ValueWithNote(null, null) },
////             { "alginate/calcium co3/sodium bicarbonate", new ValueWithNote(null, null) }, // confidence: 71.0%, omop match: 0.0%
//            { "adult st8 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st8 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st4 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st4 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st3 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st3 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st6 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st6 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st5 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st5 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st7 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st7 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st9 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st9 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "adult st2 parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st2 parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 70.6%, omop match: 0.0%
//            { "plx-pad cells", new ValueWithNote(null, null) },
////             { "plx-pad cells", new ValueWithNote(null, null) }, // confidence: 70.0%, omop match: 0.0%
//            { "adult st7e parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st7e parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 69.6%, omop match: 0.0%
//            { "adult st1b parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st1b parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 69.6%, omop match: 0.0%
//            { "adult st1a parenteral nutrition bag", new ValueWithNote(null, null) },
////             { "adult st1a parenteral nutrition bag", new ValueWithNote(null, null) }, // confidence: 69.6%, omop match: 0.0%
//            { "shingles (herpes zoster) vaccine, live", new ValueWithNote(null, null) },
////             { "shingles (herpes zoster) vaccine, live", new ValueWithNote(null, null) }, // confidence: 69.0%, omop match: 0.0%
//            { "wound care supplies", new ValueWithNote(null, null) },
////             { "wound care supplies", new ValueWithNote(null, null) }, // confidence: 69.0%, omop match: 0.0%
//            { "platelets", new ValueWithNote(null, null) },
////             { "platelets", new ValueWithNote(null, null) }, // confidence: 66.7%, omop match: 0.0%
//            { "parenteral nutrition (adults)", new ValueWithNote(null, null) },
////             { "parenteral nutrition (adults)", new ValueWithNote(null, null) }, // confidence: 66.7%, omop match: 0.0%
//            { "emulsifying wax + yellow soft paraffi", new ValueWithNote(null, null) },
////             { "emulsifying wax + yellow soft paraffi", new ValueWithNote(null, null) }, // confidence: 66.7%, omop match: 0.0%
//            { "parenteral nutrition (paediatric)", new ValueWithNote(null, null) },
////             { "parenteral nutrition (paediatric)", new ValueWithNote(null, null) }, // confidence: 65.7%, omop match: 0.0%
//            { "diphtheria/pertussis/tetanus vaccine", new ValueWithNote(null, null) },
////             { "diphtheria/pertussis/tetanus vaccine", new ValueWithNote(null, null) }, // confidence: 65.1%, omop match: 0.0%
//            { "fat emulsion, intravenous", new ValueWithNote(null, null) },
////             { "fat emulsion, intravenous", new ValueWithNote(null, null) }, // confidence: 64.9%, omop match: 0.0%
//            { "hyoscine (base)", new ValueWithNote(null, null) },
////             { "hyoscine (base)", new ValueWithNote(null, null) }, // confidence: 64.3%, omop match: 0.0%
//            { "regn10933 + regn10987", new ValueWithNote(null, null) },
////             { "regn10933 + regn10987", new ValueWithNote(null, null) }, // confidence: 63.3%, omop match: 0.0%
//            { "sodium acid phosphate + potassium dih", new ValueWithNote(null, null) },
////             { "sodium acid phosphate + potassium dih", new ValueWithNote(null, null) }, // confidence: 60.3%, omop match: 0.0%
//            { "incontinence supplies", new ValueWithNote(null, null) },
////             { "incontinence supplies", new ValueWithNote(null, null) }, // confidence: 60.0%, omop match: 0.0%
//            { "benzyl benzoate/lanolin/zinc oxide top", new ValueWithNote(null, null) },
////             { "benzyl benzoate/lanolin/zinc oxide top", new ValueWithNote(null, null) }, // confidence: 59.1%, omop match: 0.0%
//            { "imc-i109v", new ValueWithNote(null, null) },
////             { "imc-i109v", new ValueWithNote(null, null) }, // confidence: 58.8%, omop match: 0.0%
//            { "emulsifying wax + liquid paraffin + w", new ValueWithNote(null, null) },
////             { "emulsifying wax + liquid paraffin + w", new ValueWithNote(null, null) }, // confidence: 57.7%, omop match: 0.0%
//            { "dextran 40 with sodium chloride 0.9% (rh", new ValueWithNote(null, null) },
////             { "dextran 40 with sodium chloride 0.9% (rh", new ValueWithNote(null, null) }, // confidence: 57.6%, omop match: 0.0%
//            { "balsam/benzyl benz/bismuth/hc/zno top", new ValueWithNote(null, null) },
////             { "balsam/benzyl benz/bismuth/hc/zno top", new ValueWithNote(null, null) }, // confidence: 57.5%, omop match: 0.0%
//            { "diphtheria + tetanus + pertussis + hepat", new ValueWithNote(null, null) },
////             { "diphtheria + tetanus + pertussis + hepat", new ValueWithNote(null, null) }, // confidence: 57.4%, omop match: 0.0%
//            { "dexpanthenol-sodium hyaluronate ophth", new ValueWithNote(null, null) },
////             { "dexpanthenol-sodium hyaluronate ophth", new ValueWithNote(null, null) }, // confidence: 57.1%, omop match: 0.0%
//            { "ready diluted", new ValueWithNote(null, null) },
////             { "ready diluted", new ValueWithNote(null, null) }, // confidence: 57.1%, omop match: 0.0%
//            { "red cells", new ValueWithNote(null, null) },
////             { "red cells", new ValueWithNote(null, null) }, // confidence: 55.2%, omop match: 0.0%
//            { "srp", new ValueWithNote(null, null) },
////             { "srp", new ValueWithNote(null, null) }, // confidence: 54.5%, omop match: 0.0%
//            { "clobetasol/neomycin/nystatin", new ValueWithNote(null, null) },
////             { "clobetasol/neomycin/nystatin", new ValueWithNote(null, null) }, // confidence: 54.3%, omop match: 0.0%
//            { "dipht/tet/pertussis/hep b/polio/haemoph", new ValueWithNote(null, null) },
////             { "dipht/tet/pertussis/hep b/polio/haemoph", new ValueWithNote(null, null) }, // confidence: 52.7%, omop match: 0.0%
//            { "macrogol 3350 with electrolytes", new ValueWithNote(null, null) },
////             { "macrogol 3350 with electrolytes", new ValueWithNote(null, null) }, // confidence: 50.0%, omop match: 0.0%
//            { "medical supplies", new ValueWithNote(null, null) },
////             { "medical supplies", new ValueWithNote(null, null) }, // confidence: 45.5%, omop match: 0.0%
//            { "smof 60 (60ml)", new ValueWithNote(null, null) },
////             { "smof 60 (60ml)", new ValueWithNote(null, null) }, // confidence: 43.5%, omop match: 0.0%
//            { "intermittent pneumatic compression (ipc)", new ValueWithNote(null, null) },
////             { "intermittent pneumatic compression (ipc)", new ValueWithNote(null, null) }, // confidence: 37.3%, omop match: 0.0%
//            { "freetext medication", new ValueWithNote(null, null) },
////             { "freetext medication", new ValueWithNote(null, null) }, // confidence: 36.7%, omop match: 0.0%
//            { "sodium lactate compound (hartmann's) inf", new ValueWithNote(null, null) },
////             { "sodium lactate compound (hartmann's) inf", new ValueWithNote(null, null) }, // confidence: 31.6%, omop match: 0.0%
//            { "hartmanns solution", new ValueWithNote(null, null) },
////             { "hartmanns solution", new ValueWithNote(null, null) }, // confidence: 17.3%, omop match: 0.0%
//            { "gsk3511294", new ValueWithNote(null, null) },
////             { "gsk3511294", new ValueWithNote(null, null) }, // confidence: 10.5%, omop match: 0.0%
//            { "nca", new ValueWithNote(null, null) },
////             { "nca", new ValueWithNote(null, null) }, // confidence: 3.5%, omop match: 0.0%
//            { "amino acids (l-lysine 2.5% and l-arginin", new ValueWithNote(null, null) },
////             { "amino acids (l-lysine 2.5% and l-arginin", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "blood glucose monitoring supplies", new ValueWithNote(null, null) },
////             { "blood glucose monitoring supplies", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "benzylpenicillin sodium", new ValueWithNote(null, null) },
////             { "benzylpenicillin sodium", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "blood level monitoring (neonatal unit)", new ValueWithNote(null, null) },
////             { "blood level monitoring (neonatal unit)", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "be1116", new ValueWithNote(null, null) },
////             { "be1116", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "betamethasone-calcipotriol", new ValueWithNote(null, null) },
////             { "betamethasone-calcipotriol", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "buffered sodium chloride 0.9% sterile iv", new ValueWithNote(null, null) },
////             { "buffered sodium chloride 0.9% sterile iv", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "carnoys solution", new ValueWithNote(null, null) },
////             { "carnoys solution", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "coagulation factor xa", new ValueWithNote(null, null) },
////             { "coagulation factor xa", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "copper intrauterine contraceptive device", new ValueWithNote(null, null) },
////             { "copper intrauterine contraceptive device", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "cinchocaine-prednisolone", new ValueWithNote(null, null) },
////             { "cinchocaine-prednisolone", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "cinchocaine-hydrocortisone", new ValueWithNote(null, null) },
////             { "cinchocaine-hydrocortisone", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "diphth/pertussis,acel/polio/tetanus vacc", new ValueWithNote(null, null) },
////             { "diphth/pertussis,acel/polio/tetanus vacc", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "cryoprecipitate", new ValueWithNote(null, null) },
////             { "cryoprecipitate", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "emollients,", new ValueWithNote(null, null) },
////             { "emollients,", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "donor lymphocytes - cd3", new ValueWithNote(null, null) },
////             { "donor lymphocytes - cd3", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "fresh frozen plasma", new ValueWithNote(null, null) },
////             { "fresh frozen plasma", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "epoetin beta-methoxy polyethylene glycol", new ValueWithNote(null, null) },
////             { "epoetin beta-methoxy polyethylene glycol", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "heparin flush", new ValueWithNote(null, null) },
////             { "heparin flush", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "ergometrine-oxytocin", new ValueWithNote(null, null) },
////             { "ergometrine-oxytocin", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "fluorescein ophthalmic", new ValueWithNote(null, null) },
////             { "fluorescein ophthalmic", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "glucose 20% infusion (continuous)", new ValueWithNote(null, null) },
////             { "glucose 20% infusion (continuous)", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "glucose 10% infusion", new ValueWithNote(null, null) },
////             { "glucose 10% infusion", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "glucose 5% intravenous infusion solution", new ValueWithNote(null, null) },
////             { "glucose 5% intravenous infusion solution", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "idds", new ValueWithNote(null, null) },
////             { "idds", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "loteprednol ophthalmic", new ValueWithNote(null, null) },
////             { "loteprednol ophthalmic", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "granulocytes", new ValueWithNote(null, null) },
////             { "granulocytes", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "magnesium glycerophosphate", new ValueWithNote(null, null) },
////             { "magnesium glycerophosphate", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "magnesium carbonate-magnesium sulfate", new ValueWithNote(null, null) },
////             { "magnesium carbonate-magnesium sulfate", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "glucose 50% intravenous infusion solutio", new ValueWithNote(null, null) },
////             { "glucose 50% intravenous infusion solutio", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "nitrous oxide-oxygen", new ValueWithNote(null, null) },
////             { "nitrous oxide-oxygen", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "ocular lubricant", new ValueWithNote(null, null) },
////             { "ocular lubricant", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "glucose 12.5% intravenous infusion solut", new ValueWithNote(null, null) },
////             { "glucose 12.5% intravenous infusion solut", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "hepatitis b paediatric vaccine", new ValueWithNote(null, null) },
////             { "hepatitis b paediatric vaccine", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "influenza vaccine, inactivated", new ValueWithNote(null, null) },
////             { "influenza vaccine, inactivated", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "hyoscine butylbromide", new ValueWithNote(null, null) },
////             { "hyoscine butylbromide", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "ro7204239", new ValueWithNote(null, null) },
////             { "ro7204239", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "ro7234292", new ValueWithNote(null, null) },
////             { "ro7234292", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "pilocarpine ophthalmic", new ValueWithNote(null, null) },
////             { "pilocarpine ophthalmic", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "leech therapy", new ValueWithNote(null, null) },
////             { "leech therapy", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "parenteral nutrition (neonatal unit)", new ValueWithNote(null, null) },
////             { "parenteral nutrition (neonatal unit)", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "ncea", new ValueWithNote(null, null) },
////             { "ncea", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "rabies vaccine, chick embryo cell", new ValueWithNote(null, null) },
////             { "rabies vaccine, chick embryo cell", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "nutritional supplements", new ValueWithNote(null, null) },
////             { "nutritional supplements", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "potassium acid phosphate", new ValueWithNote(null, null) },
////             { "potassium acid phosphate", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "respiratory therapy supplies", new ValueWithNote(null, null) },
////             { "respiratory therapy supplies", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "peripheral nerve infusion", new ValueWithNote(null, null) },
////             { "peripheral nerve infusion", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "radio-opaque markers", new ValueWithNote(null, null) },
////             { "radio-opaque markers", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "sodium chloride 2.7% intravenous solutio", new ValueWithNote(null, null) },
////             { "sodium chloride 2.7% intravenous solutio", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "sodium chloride 0.9% infusion", new ValueWithNote(null, null) },
////             { "sodium chloride 0.9% infusion", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "sodium chloride 5% intravenous solution", new ValueWithNote(null, null) },
////             { "sodium chloride 5% intravenous solution", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "rsv vaccine, pref a-pref b, recombinant", new ValueWithNote(null, null) },
////             { "rsv vaccine, pref a-pref b, recombinant", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "vitamins", new ValueWithNote(null, null) },
////             { "vitamins", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "saliva substitutes", new ValueWithNote(null, null) },
////             { "saliva substitutes", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "sodium chloride 0.45% intravenous soluti", new ValueWithNote(null, null) },
////             { "sodium chloride 0.45% intravenous soluti", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "support devices", new ValueWithNote(null, null) },
////             { "support devices", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "hyoscine butylbromide", new ValueWithNote(null, null) },
////             { "hyoscine butylbromide", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "insulin soluble porcine", new ValueWithNote(null, null) },
////             { "insulin soluble porcine", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "nitrous oxide + oxygen", new ValueWithNote(null, null) },
////             { "nitrous oxide + oxygen", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "stem cells - cd34", new ValueWithNote(null, null) },
////             { "stem cells - cd34", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "arterial line flush sodium chloride 0", new ValueWithNote(null, null) },
////             { "arterial line flush sodium chloride 0", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "ocular lubricant", new ValueWithNote(null, null) },
////             { "ocular lubricant", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "sodium acid phosphate", new ValueWithNote(null, null) },
////             { "sodium acid phosphate", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "calcium lactate + calcium phosphate +", new ValueWithNote(null, null) },
////             { "calcium lactate + calcium phosphate +", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "central line flush sodium chloride 0.", new ValueWithNote(null, null) },
////             { "central line flush sodium chloride 0.", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "flupentixol decanoate", new ValueWithNote(null, null) },
////             { "flupentixol decanoate", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "sodium cromoglicate nasal", new ValueWithNote(null, null) },
////             { "sodium cromoglicate nasal", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "fdy-5301", new ValueWithNote(null, null) },
////             { "fdy-5301", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "fluorouracil-salicylic acid", new ValueWithNote(null, null) },
////             { "fluorouracil-salicylic acid", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "haemofiltration fluids", new ValueWithNote(null, null) },
////             { "haemofiltration fluids", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "pcea", new ValueWithNote(null, null) },
////             { "pcea", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
//            { "vitamins with minerals", new ValueWithNote(null, null) },
////             { "vitamins with minerals", new ValueWithNote(null, null) }, // confidence: 0.0%, omop match: 0.0%
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
