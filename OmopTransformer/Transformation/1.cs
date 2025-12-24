using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup discharge destination concept for A&E.")]
internal class SACTTreatmentRegimenLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "BEAM", new ValueWithNote("35803616", "BEAM") }, // 100.0%
            { "CAV", new ValueWithNote("35806944", "CAV") }, // 100.0%
            { "ChlVPP", new ValueWithNote("35805822", "ChlVPP") }, // 100.0%
            { "ICE", new ValueWithNote("35805126", "ICE") }, // 100.0%
            { "PCV", new ValueWithNote("35803682", "PCV") }, // 100.0%
            { "PEI", new ValueWithNote("912256", "PEI") }, // 100.0%
            { "R-CODOX-M / R-IVAC", new ValueWithNote("35804381", "R-CODOX-M/R-IVAC") }, // 100.0%
            { "R-CP", new ValueWithNote("35806665", "R-CP") }, // 100.0%
            { "R-DHAOx", new ValueWithNote("35805057", "R-DHAOx") }, // 100.0%
            { "R-GCVP", new ValueWithNote("35805041", "R-GCVP") }, // 100.0%
            { "MACE", new ValueWithNote("37557218", "MACE") }, // 100.0%
            { "MMM", new ValueWithNote("1524957", "MMM") }, // 100.0%
            { "FLAG-IDA", new ValueWithNote("35803457", "FLAG-Ida") }, // 100.0%
            { "FLAG", new ValueWithNote("35803501", "FLAG") }, // 100.0%
            { "MATRix", new ValueWithNote("35804413", "MATRix") }, // 100.0%
            { "VCP", new ValueWithNote("35806343", "VCP") }, // 100.0%
            { "VDC/IE", new ValueWithNote("35805450", "VDC/IE") }, // 100.0%
            { "TIP", new ValueWithNote("35806625", "TIP") }, // 100.0%
            { "ATRA / Arsenic Trioxide", new ValueWithNote("35803549", "Arsenic trioxide and ATRA") }, // 98.05%
            { "ATRA Arsenic trioxide", new ValueWithNote("35803549", "Arsenic trioxide and ATRA") }, // 96.14%
            { "Everolimus Lenvatinib", new ValueWithNote("35806906", "Everolimus and Lenvatinib") }, // 96.0%
            { "Docetaxel Nintedanib", new ValueWithNote("42542355", "Docetaxel and Nintedanib") }, // 95.89999999999999%
            { "Idelalisib Rituximab", new ValueWithNote("35804590", "Idelalisib and Rituximab") }, // 95.65%
            { "Olaparib Bevacizumab", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 95.65%
            { "Temozolomide Capecitabine", new ValueWithNote("35806577", "Capecitabine and Temozolomide") }, // 95.41%
            { "Nintedanib Docetaxel", new ValueWithNote("42542355", "Docetaxel and Nintedanib") }, // 95.30999999999999%
            { "Temozolomide Irinotecan", new ValueWithNote("35805455", "Irinotecan and Temozolomide") }, // 95.30999999999999%
            { "Abemaciclib Fulvestrant", new ValueWithNote("35804294", "Abemaciclib and Fulvestrant") }, // 95.07%
            { "Alpelisib Fulvestrant", new ValueWithNote("35101866", "Alpelisib and Fulvestrant") }, // 94.82000000000001%
            { "Encorafenib Binimetinib", new ValueWithNote("35806137", "Binimetinib and Encorafenib") }, // 94.82000000000001%
            { "Pemetrexed Cisplatin", new ValueWithNote("35806173", "Cisplatin and Pemetrexed") }, // 94.58%
            { "Dacarbazine Gemcitabine", new ValueWithNote("35806969", "Dacarbazine and Gemcitabine") }, // 94.48%
            { "Avelumab Axitinib", new ValueWithNote("35806900", "Axitinib and Avelumab") }, // 94.38%
            { "Ipilimumab Nivolumab", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 94.34%
            { "Irinotecan Temozolomide", new ValueWithNote("35805455", "Irinotecan and Temozolomide") }, // 94.34%
            { "Docetaxel Prednisolone", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 94.04%
            { "Venetoclax Azacitidine", new ValueWithNote("35803466", "Azacitidine and Venetoclax") }, // 94.04%
            { "Atezolizumab Bevacizumab", new ValueWithNote("35806408", "Atezolizumab and Bevacizumab") }, // 93.99%
            { "Ibrutinib Venetoclax", new ValueWithNote("35806097", "Ibrutinib and Venetoclax") }, // 93.99%
            { "Melphalan +/- Prednisolone", new ValueWithNote("35806351", "Melphalan and Methylprednisolone") }, // 93.89999999999999%
            { "Cyclophosphamide Prednisolone", new ValueWithNote("35803428", "Cyclophosphamide and Prednisolone") }, // 93.75%
            { "Ifosfamide Doxorubicin", new ValueWithNote("35806965", "Doxorubicin and Ifosfamide") }, // 93.55%
            { "Obinutuzumab Bendamustine", new ValueWithNote("35804585", "Bendamustine and Obinutuzumab") }, // 93.51%
            { "Cyclophosphamide Etoposide", new ValueWithNote("35806476", "Cyclophosphamide and Etoposide") }, // 93.51%
            { "Cetuximab Encorafenib", new ValueWithNote("911998", "Encorafenib and Cetuximab") }, // 93.31%
            { "Obinutuzumab Venetoclax", new ValueWithNote("35100084", "Venetoclax and Obinutuzumab") }, // 93.31%
            { "Gemcitabine Docetaxel", new ValueWithNote("35803577", "Docetaxel and Gemcitabine") }, // 93.16%
            { "Ramucirumab Paclitaxel", new ValueWithNote("35805371", "Paclitaxel and Ramucirumab") }, // 93.16%
            { "Brentuximab vedotin", new ValueWithNote("35803702", "Brentuximab vedotin monotherapy") }, // 93.12%
            { "Trifluridine-Tipiracil", new ValueWithNote("35804789", "Trifluridine and tipiracil monotherapy") }, // 93.07%
            { "Docetaxel Carboplatin Trastuzumab (TCH)", new ValueWithNote("37560271", "TCH (Docetaxel) (trastuzumab-herw)") }, // 93.02%
            { "Pomalidomide Dexamethasone", new ValueWithNote("42542407", "Pomalidomide and Dexamethasone (Pd)") }, // 93.02%
            { "Dabrafenib Trametinib", new ValueWithNote("35804100", "Dabrafenib and Trametinib") }, // 92.97%
            { "Vinblastine Methotrexate", new ValueWithNote("1525155", "Methotrexate and Vinblastine") }, // 92.97%
            { "Mitomycin Capecitabine + RT", new ValueWithNote("35803671", "Capecitabine, Mitomycin, RT") }, // 92.92%
            { "Ribociclib Fulvestrant", new ValueWithNote("35804285", "Fulvestrant and Ribociclib") }, // 92.86999999999999%
            { "Mitomycin Capecitabine", new ValueWithNote("35804560", "Capecitabine and Mitomycin") }, // 92.86999999999999%
            { "Tucatinib Capecitabine Trastuzumab", new ValueWithNote("911925", "Capecitabine and Trastuzumab (XH) and Tucatinib") }, // 92.82000000000001%
            { "Venetoclax Rituximab", new ValueWithNote("35804605", "Venetoclax and Rituximab") }, // 92.58%
            { "Cisplatin Capecitabine + RT", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 92.58%
            { "Palbociclib Fulvestrant", new ValueWithNote("35804297", "Fulvestrant and Palbociclib") }, // 92.58%
            { "Carfilzomib Dexamethasone", new ValueWithNote("35806309", "Carfilzomib and Dexamethasone (Kd)") }, // 92.33%
            { "Ixazomib Lenalidomide Dexamethasone", new ValueWithNote("35806065", "Ixazomib and Dexamethasone") }, // 92.29%
            { "Sacituzumab govitecan", new ValueWithNote("912024", "Sacituzumab govitecan monotherapy") }, // 92.29%
            { "Plerixafor + G-CSF Priming", new ValueWithNote("35101641", "Plerixafor and G-CSF") }, // 91.8%
            { "Ifosfamide Etoposide and HD Methotrexate", new ValueWithNote("35805125", "Etoposide, Ifosfamide, Methotrexate") }, // 91.8%
            { "Bevacizumab Irinotecan", new ValueWithNote("35803693", "Irinotecan and Bevacizumab") }, // 91.75%
            { "Pomalidomide + low dose Dexamethasone", new ValueWithNote("42542407", "Pomalidomide and Dexamethasone (Pd)") }, // 91.5%
            { "Paclitaxel weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 91.5%
            { "Paclitaxel (90) weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 91.46%
            { "Temozolomide with concurrent RT", new ValueWithNote("35803687", "Temozolomide and RT, then Temozolomide") }, // 91.41%
            { "Melphalan intermediate dose with Dexamethasone", new ValueWithNote("905703", "Melphalan and Dexamethasone") }, // 91.31%
            { "Ipilimumab Nivolumab (melanoma)", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 91.11%
            { "EC Docetaxel", new ValueWithNote("1525058", "EC-TL (Docetaxel)") }, // 91.06%
            { "FEC (100)", new ValueWithNote("35804212", "FEC") }, // 90.97%
            { "Docetaxel Cyclophosphamide", new ValueWithNote("35804232", "Cyclophosphamide and Docetaxel (TC)") }, // 90.86999999999999%
            { "Capecitabine (5 day) with RT", new ValueWithNote("35806890", "Capecitabine and RT") }, // 90.77%
            { "Paclitaxel albumin-bound", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 90.77%
            { "Cyclophosphamide po daily +/- Prednisolone", new ValueWithNote("35803428", "Cyclophosphamide and Prednisolone") }, // 90.62%
            { "Panobinostat Bortezomib Dexamethasone (PanBorDex)", new ValueWithNote("35806306", "Bortezomib and Dexamethasone (Vd) and Panobinostat") }, // 90.48%
            { "CHOEP-21 bolus", new ValueWithNote("35803698", "CHOEP-21") }, // 90.48%
            { "R-ESHAP (daypatient)", new ValueWithNote("35805061", "R-ESHAP") }, // 90.38000000000001%
            { "R-mini CHOP", new ValueWithNote("35805028", "R-CHOP") }, // 90.38000000000001%
            { "Gemcitabine Capecitabine", new ValueWithNote("35804557", "Capecitabine and Gemcitabine") }, // 90.28%
            { "Cisplatin Etoposide", new ValueWithNote("35805329", "Cisplatin and Etoposide (EP)") }, // 90.28%
            { "EC Docetaxel Trastuzumab", new ValueWithNote("37560133", "EC-TH (Docetaxel) (trastuzumab-dttb)") }, // 90.19%
            { "CAV (SCLC)", new ValueWithNote("35806944", "CAV") }, // 90.14%
            { "Pertuzumab Trastuzumab Docetaxel", new ValueWithNote("911985", "Docetaxel and Pertuzumab") }, // 90.14%
            { "Nivolumab Brentuximab vedotin (compassionate use)", new ValueWithNote("35805828", "Brentuximab vedotin and Nivolumab") }, // 90.09%
            { "Paclitaxel weekly (relapsed/metastatic)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 90.09%
            { "R-ESHAP (inpatient)", new ValueWithNote("35805061", "R-ESHAP") }, // 89.94%
            { "Carfilzomib Lenalidomide Dexamethasone", new ValueWithNote("35806309", "Carfilzomib and Dexamethasone (Kd)") }, // 89.89%
            { "Temozolomide with concurrent RT (support)", new ValueWithNote("35803687", "Temozolomide and RT, then Temozolomide") }, // 89.89%
            { "Lenalidomide Dexamethasone", new ValueWithNote("35806053", "Lenalidomide and Dexamethasone (Rd)") }, // 89.84%
            { "Azacitidine", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 89.84%
            { "FOLFIRINOX (adjuvant)", new ValueWithNote("35804771", "FOLFIRINOX") }, // 89.79%
            { "Paclitaxel (weekly for 3 weeks then 1 week off)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 89.79%
            { "Vinorelbine (IV) Carboplatin (CrCl)", new ValueWithNote("35806405", "Carboplatin and Vinorelbine") }, // 89.75%
            { "Cyclophosphamide po weekly +/- Prednisolone", new ValueWithNote("35803428", "Cyclophosphamide and Prednisolone") }, // 89.64999999999999%
            { "Brentuximab vedotin (compassionate use)", new ValueWithNote("35805828", "Brentuximab vedotin and Nivolumab") }, // 89.64999999999999%
            { "R-ICE modified", new ValueWithNote("35805063", "R-ICE") }, // 89.60000000000001%
            { "Paclitaxel weekly (sarcoma)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 89.60000000000001%
            { "Obinutuzumab Chlorambucil", new ValueWithNote("35804572", "Chlorambucil and Obinutuzumab (GClb)") }, // 89.55%
            { "Gemcitabine with RT (bladder)", new ValueWithNote("35804152", "Gemcitabine and RT") }, // 89.55%
            { "Epirubicin Oxaliplatin Fluorouracil", new ValueWithNote("35805353", "Fluorouracil, Oxaliplatin, RT") }, // 89.55%
            { "Avelumab", new ValueWithNote("35804159", "Avelumab monotherapy") }, // 89.5%
            { "Trastuzumab Cisplatin Capecitabine", new ValueWithNote("35805363", "Capecitabine and Cisplatin (CX) and Trastuzumab") }, // 89.45%
            { "Rituximab Gemcitabine Oxaliplatin (R-GemOx)", new ValueWithNote("37559706", "R-GemOx (rituximab-rixa)") }, // 89.4%
            { "Irinotecan Temozolomide Vincristine", new ValueWithNote("35805455", "Irinotecan and Temozolomide") }, // 89.31%
            { "Cyclophosphamide TBI (Allograft)", new ValueWithNote("35803613", "Cyclophosphamide and TBI") }, // 89.31%
            { "FEC (100) Docetaxel (100)", new ValueWithNote("1525108", "FEC-TH (Docetaxel)") }, // 89.21%
            { "Pembrolizumab Paclitaxel albumin-bound", new ValueWithNote("35804256", "Paclitaxel, nanoparticle albumin-bound and Bevacizumab") }, // 89.16%
            { "Vinorelbine (oral) Carboplatin (CrCl)", new ValueWithNote("35806405", "Carboplatin and Vinorelbine") }, // 89.16%
            { "Paclitaxel weekly Trastuzumab", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 89.11%
            { "Vinorelbine (oral) Trastuzumab", new ValueWithNote("35804242", "Vinorelbine and Trastuzumab (VH)") }, // 89.05999999999999%
            { "Apixaban", new ValueWithNote("35807094", "Apixaban monotherapy") }, // 89.05999999999999%
            { "Talimogene laherparepvec", new ValueWithNote("35806121", "Talimogene laherparepvec monotherapy") }, // 89.05999999999999%
            { "Everolimus", new ValueWithNote("35805075", "Everolimus monotherapy") }, // 89.01%
            { "Mitomycin Capecitabine with concurrent RT", new ValueWithNote("35804560", "Capecitabine and Mitomycin") }, // 89.01%
            { "Melphalan PO +/- Prednisolone", new ValueWithNote("35806351", "Melphalan and Methylprednisolone") }, // 89.01%
            { "Carfilzomib Pomalidomide Dexamethasone", new ValueWithNote("35806309", "Carfilzomib and Dexamethasone (Kd)") }, // 88.96%
            { "Capecitabine with concurrent RT", new ValueWithNote("35806890", "Capecitabine and RT") }, // 88.96%
            { "Venetoclax Azacitidine (unsuitable for intensive treatment)", new ValueWithNote("35803466", "Azacitidine and Venetoclax") }, // 88.96%
            { "Encorafenib Binimetinib (compassionate use)", new ValueWithNote("35806137", "Binimetinib and Encorafenib") }, // 88.82%
            { "Gemcitabine Paclitaxel albumin bound", new ValueWithNote("35804248", "Capecitabine and Paclitaxel, nanoparticle albumin-bound") }, // 88.77000000000001%
            { "Cisplatin Fluorouracil (CF100)", new ValueWithNote("35803676", "Cisplatin and Fluorouracil (CF)") }, // 88.67%
            { "Paclitaxel albumin-bound Trastuzumab", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 88.62%
            { "VDTPACE", new ValueWithNote("35806327", "DTPACE") }, // 88.62%
            { "Pomalidomide Dexamethasone (compassionate use)", new ValueWithNote("42542407", "Pomalidomide and Dexamethasone (Pd)") }, // 88.57000000000001%
            { "Vinorelbine (oral) Carboplatin (EDTA)", new ValueWithNote("35806398", "Carboplatin, Vinorelbine, RT") }, // 88.48%
            { "Paclitaxel weekly for 3 weeks then 1 week off", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 88.38000000000001%
            { "STELLAR Acalabrutinib monotherapy (Trial)", new ValueWithNote("35804606", "Acalabrutinib monotherapy") }, // 88.33%
            { "R-CHOP-14 bolus", new ValueWithNote("35805031", "R-CHOP-14") }, // 88.33%
            { "Bevacizumab (7.5mg/kg) Paclitaxel Carboplatin (CrCl)", new ValueWithNote("37561592", "Carboplatin and Paclitaxel (CP), Bevacizumab-aveg, Cadonilimab") }, // 88.28%
            { "Temozolomide 75 + RT", new ValueWithNote("35803686", "Temozolomide and RT") }, // 88.28%
            { "Romidepsin (compassionate use)", new ValueWithNote("35804817", "Romidepsin monotherapy") }, // 88.23%
            { "Gemcitabine (1250) Cisplatin", new ValueWithNote("35806427", "Cisplatin and Gemcitabine/Erlotinib") }, // 88.23%
            { "Ipilimumab", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 88.23%
            { "Cyclophosphamide Vincristine Dacarbazine (CVD)", new ValueWithNote("35806646", "Cyclophosphamide, Dacarbazine, Vincristine") }, // 88.18%
            { "Docetaxel Carboplatin Trastuzumab (TCH) CrCl", new ValueWithNote("37560271", "TCH (Docetaxel) (trastuzumab-herw)") }, // 88.13%
            { "Cisplatin Capecitabine with concurrent RT", new ValueWithNote("1525040", "Capecitabine and Cisplatin (CX) and RT") }, // 88.13%
            { "Capecitabine Trastuzumab", new ValueWithNote("35804312", "Capecitabine and Trastuzumab (XH)") }, // 88.09%
            { "Temozolomide", new ValueWithNote("35806135", "Temozolomide and Bevacizumab") }, // 88.09%
            { "Busulfan Cyclophosphamide (Allograft)", new ValueWithNote("35806362", "Busulfan and Cyclophosphamide, then allo HSCT") }, // 88.03999999999999%
            { "R-CVP bolus", new ValueWithNote("35805630", "R-CVP") }, // 88.03999999999999%
            { "Oxaliplatin Raltitrexed", new ValueWithNote("35806174", "Cisplatin and Raltitrexed") }, // 88.03999999999999%
            { "Afatinib", new ValueWithNote("42542279", "Afatinib and Cetuximab") }, // 87.99%
            { "Apalutamide", new ValueWithNote("1524822", "Abiraterone and Apalutamide") }, // 87.99%
            { "Lorlatinib", new ValueWithNote("35806425", "Lorlatinib monotherapy") }, // 87.99%
            { "Panobinostat Bortezomib weekly Dexamethasone (PanBorDex)", new ValueWithNote("35806306", "Bortezomib and Dexamethasone (Vd) and Panobinostat") }, // 87.94%
            { "Nintedanib", new ValueWithNote("37557063", "Nintedanib monotherapy") }, // 87.94%
            { "Dasatinib", new ValueWithNote("35804080", "Dasatinib monotherapy") }, // 87.94%
            { "IMMU-132-13 Sacituzumab govitecan (Trial)", new ValueWithNote("912024", "Sacituzumab govitecan monotherapy") }, // 87.89%
            { "Axitinib", new ValueWithNote("37560929", "Axitinib and Toripalimab") }, // 87.79%
            { "Midostaurin (compassionate use)", new ValueWithNote("35803513", "Midostaurin monotherapy") }, // 87.74%
            { "Capecitabine (5 day) with RT (pancreas)", new ValueWithNote("35806890", "Capecitabine and RT") }, // 87.74%
            { "BEAM (ambulatory)", new ValueWithNote("35803616", "BEAM") }, // 87.74%
            { "Dacomitinib", new ValueWithNote("35806428", "Dacomitinib monotherapy") }, // 87.7%
            { "Letrozole", new ValueWithNote("37557328", "Tamoxifen-Letrozole") }, // 87.7%
            { "Paclitaxel albumin bound (support)", new ValueWithNote("35804256", "Paclitaxel, nanoparticle albumin-bound and Bevacizumab") }, // 87.64999999999999%
            { "Carboplatin Etoposide Ifosfamide (CarboPEI)", new ValueWithNote("35804536", "Carboplatin and Ifosfamide") }, // 87.64999999999999%
            { "FOLFOXIRI", new ValueWithNote("35804761", "FOLFIRI") }, // 87.64999999999999%
            { "Dabrafenib Trametinib (metastatic)", new ValueWithNote("35804100", "Dabrafenib and Trametinib") }, // 87.6%
            { "Atezolizumab Paclitaxel albumin-bound", new ValueWithNote("37558548", "Paclitaxel, nanoparticle albumin-bound and Bevacizumab-bvzr") }, // 87.6%
            { "Fludarabine Melphalan Alemtuzumab (60 late) RIC", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 87.6%
            { "Bevacizumab (15mg/kg) Paclitaxel Carboplatin (CrCl)", new ValueWithNote("37561592", "Carboplatin and Paclitaxel (CP), Bevacizumab-aveg, Cadonilimab") }, // 87.6%
            { "Avelumab Axitinib (EAMS)", new ValueWithNote("35806900", "Axitinib and Avelumab") }, // 87.6%
            { "Paclitaxel Carboplatin (CrCl) with concurrent RT", new ValueWithNote("35805350", "Carboplatin and Paclitaxel (CP) and RT") }, // 87.55%
            { "FEC (100) Docetaxel (75) Pertuzumab Trastuzumab (neoadjuvant)", new ValueWithNote("37560136", "FEC-THP (Docetaxel) (trastuzumab-dttb)") }, // 87.55%
            { "Cisplatin Capecitabine", new ValueWithNote("35805335", "Capecitabine and Cisplatin (CX)") }, // 87.5%
            { "Temozolomide Irinotecan (TEMIRI)", new ValueWithNote("35805455", "Irinotecan and Temozolomide") }, // 87.5%
            { "Durvalumab", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 87.5%
            { "Cisplatin Fluorouracil (CF80)", new ValueWithNote("35803676", "Cisplatin and Fluorouracil (CF)") }, // 87.45%
            { "Regorafenib", new ValueWithNote("35804569", "Regorafenib monotherapy") }, // 87.4%
            { "Ipilimumab Nivolumab (mesothelioma)", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 87.4%
            { "rEECur Carboplatin Etoposide (CE) (NCRN Trial)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 87.35000000000001%
            { "Cisplatin Etoposide with concurrent RT (SCLC)", new ValueWithNote("35805334", "Cisplatin, Etoposide, RT") }, // 87.35000000000001%
            { "Carboplatin Capecitabine + RT (CrCl)", new ValueWithNote("35804530", "Carboplatin and RT") }, // 87.35000000000001%
            { "Atezolizumab Bevacizumab Paclitaxel Carboplatin (CrCl)", new ValueWithNote("37561589", "Carboplatin and Paclitaxel (CP), Atezolizumab, Bevacizumab-aveg") }, // 87.35000000000001%
            { "Vinorelbine PO (60) Carboplatin AUC5 (CrCl)", new ValueWithNote("35806398", "Carboplatin, Vinorelbine, RT") }, // 87.35000000000001%
            { "Carboplatin Pemetrexed (CrCl)", new ValueWithNote("35806172", "Carboplatin and Pemetrexed") }, // 87.3%
            { "Docetaxel", new ValueWithNote("35804207", "Docetaxel and Bevacizumab") }, // 87.3%
            { "Carboplatin with concurrent RT (CrCl)", new ValueWithNote("35804530", "Carboplatin and RT") }, // 87.3%
            { "Ruxolitinib", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 87.3%
            { "Cyclophosphamide oral +/- Methotrexate", new ValueWithNote("35101986", "Cyclophosphamide and Methotrexate (CM)") }, // 87.26%
            { "Raltitrexed Oxaliplatin", new ValueWithNote("35806174", "Cisplatin and Raltitrexed") }, // 87.21%
            { "Enzalutamide", new ValueWithNote("35804322", "Enzalutamide monotherapy") }, // 87.21%
            { "FLAG-IDA Venetoclax", new ValueWithNote("35803457", "FLAG-Ida") }, // 87.16000000000001%
            { "Dacarbazine (melanoma)", new ValueWithNote("35806964", "Dacarbazine and Doxorubicin") }, // 87.16000000000001%
            { "Exemestane", new ValueWithNote("37557327", "Tamoxifen-Exemestane") }, // 87.16000000000001%
            { "Clarithromycin prophylaxis", new ValueWithNote("35806104", "Clarithromycin monotherapy") }, // 87.16000000000001%
            { "Sunitinib", new ValueWithNote("905814", "Erlotinib and Sunitinib") }, // 87.11%
            { "Asciminib (compassionate use)", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 87.11%
            { "Paclitaxel weekly for 3 weeks then 1 week off (sarcoma)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 87.06%
            { "EC Docetaxel Pertuzumab Trastuzumab (adjuvant)", new ValueWithNote("37560133", "EC-TH (Docetaxel) (trastuzumab-dttb)") }, // 87.01%
            { "Bosutinib", new ValueWithNote("35804082", "Bosutinib monotherapy") }, // 87.01%
            { "Ceritinib", new ValueWithNote("35804391", "Ceritinib monotherapy") }, // 87.01%
            { "Gemcitabine (675) Docetaxel (70) (sarcoma)", new ValueWithNote("35803577", "Docetaxel and Gemcitabine") }, // 86.96000000000001%
            { "Pazopanib", new ValueWithNote("37557053", "Pazopanib/Everolimus") }, // 86.96000000000001%
            { "EC Paclitaxel (dose dense)", new ValueWithNote("1525098", "EC-TH (Paclitaxel)") }, // 86.91%
            { "Gilteritinib", new ValueWithNote("35803515", "Gilteritinib monotherapy") }, // 86.91%
            { "Vinorelbine PO (60-80) Cisplatin Daypt", new ValueWithNote("35805351", "Cisplatin, Vinorelbine, RT") }, // 86.91%
            { "Rucaparib", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 86.87%
            { "Inotuzumab ozogamicin cycle 1", new ValueWithNote("35804064", "Inotuzumab ozogamicin monotherapy") }, // 86.87%
            { "Palbociclib (aromatase inhibitor)", new ValueWithNote("37556966", "Palbociclib and Tamoxifen") }, // 86.77%
            { "ORACLE Azacitidine (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 86.77%
            { "Carboplatin Etoposide (EDTA)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 86.72%
            { "Liposomal doxorubicin", new ValueWithNote("35804264", "Pegylated liposomal doxorubicin and Bevacizumab") }, // 86.72%
            { "Ponatinib", new ValueWithNote("37557221", "Ponatinib and Blinatumomab") }, // 86.72%
            { "Lutetium-177 vipivotide tetraxetan (without support medication) (EAMS)", new ValueWithNote("1525150", "Lutetium Lu 177 vipivotide tetraxetan monotherapy") }, // 86.72%
            { "Mobocertinib", new ValueWithNote("1525157", "Mobocertinib monotherapy") }, // 86.67%
            { "Cisplatin (100) with concurrent RT", new ValueWithNote("35804144", "Cisplatin and RT") }, // 86.67%
            { "Cabozantinib", new ValueWithNote("912132", "Cabozantinib and Nivolumab") }, // 86.61999999999999%
            { "Paclitaxel (weekly for 3 weeks then 1 week off) Trastuzumab", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 86.61999999999999%
            { "PRIZM+ Zanubrutinib monotherapy (Trial)", new ValueWithNote("42542412", "Zanubrutinib monotherapy") }, // 86.61999999999999%
            { "FOLFIRINOX (metastatic)", new ValueWithNote("35804771", "FOLFIRINOX") }, // 86.61999999999999%
            { "Vinorelbine (oral) Cisplatin", new ValueWithNote("35804260", "Cisplatin and Vinorelbine (CVb)") }, // 86.57000000000001%
            { "Irinotecan", new ValueWithNote("35803693", "Irinotecan and Bevacizumab") }, // 86.57000000000001%
            { "Azacitidine (support)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 86.57000000000001%
            { "Paclitaxel weekly premedication (support)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 86.57000000000001%
            { "Carboplatin Pembrolizumab Pemetrexed (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 86.57000000000001%
            { "Temozolomide with concurrent RT (patients 65 years and over)", new ValueWithNote("35803687", "Temozolomide and RT, then Temozolomide") }, // 86.52%
            { "CA059-001 CC-95251 Azacitidine (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 86.52%
            { "Dacarbazine (sarcoma)", new ValueWithNote("35806964", "Dacarbazine and Doxorubicin") }, // 86.52%
            { "Lanreotide Depot", new ValueWithNote("35806580", "Lanreotide Depot/Autogel monotherapy") }, // 86.52%
            { "Nivolumab Oxaliplatin Capecitabine", new ValueWithNote("35805347", "Capecitabine, Oxaliplatin, RT") }, // 86.52%
            { "EC", new ValueWithNote("1525213", "D-EC") }, // 86.52%
            { "Cisplatin Etoposide with concurrent RT (NSCLC)", new ValueWithNote("37557397", "Cisplatin and Etoposide (EP) and RT") }, // 86.52%
            { "Cyclophosphamide oral +/- Prednisolone (Sarcoma)", new ValueWithNote("35803428", "Cyclophosphamide and Prednisolone") }, // 86.47%
            { "FEC (75/500)", new ValueWithNote("35804212", "FEC") }, // 86.47%
            { "Cisplatin (50) RT", new ValueWithNote("35804144", "Cisplatin and RT") }, // 86.47%
            { "Pembrolizumab Oxaliplatin Capecitabine", new ValueWithNote("35805347", "Capecitabine, Oxaliplatin, RT") }, // 86.42999999999999%
            { "Niraparib", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 86.42999999999999%
            { "Pemetrexed Carboplatin (CrCl)", new ValueWithNote("35806172", "Carboplatin and Pemetrexed") }, // 86.42999999999999%
            { "Gemcitabine Paclitaxel albumin bound (support)", new ValueWithNote("35804248", "Capecitabine and Paclitaxel, nanoparticle albumin-bound") }, // 86.38%
            { "Oxaliplatin Capecitabine (OX)", new ValueWithNote("35805347", "Capecitabine, Oxaliplatin, RT") }, // 86.38%
            { "Sotorasib", new ValueWithNote("905771", "Sotorasib monotherapy") }, // 86.28%
            { "Olaparib (compassionate use)", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 86.28%
            { "Vemurafenib", new ValueWithNote("35804101", "Vemurafenib monotherapy") }, // 86.28%
            { "ARCADIAN Vinorelbine Cisplatin with RT (Trial)", new ValueWithNote("35805351", "Cisplatin, Vinorelbine, RT") }, // 86.22999999999999%
            { "Fedratinib", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 86.18%
            { "MVAC accelerated", new ValueWithNote("35804146", "MVAC") }, // 86.18%
            { "Gemcitabine", new ValueWithNote("35804135", "Gemcitabine monotherapy") }, // 86.08%
            { "PARTNER Olaparib (Trial)", new ValueWithNote("37558813", "Olaparib and Bevacizumab-onbe") }, // 86.08%
            { "Cisplatin (50) with concurrent RT", new ValueWithNote("35804144", "Cisplatin and RT") }, // 86.08%
            { "Eribulin", new ValueWithNote("905675", "Eribulin and Trastuzumab") }, // 86.08%
            { "Abiraterone", new ValueWithNote("35806848", "Abiraterone monotherapy") }, // 86.08%
            { "Daratumumab Pomalidomide Dexamethasone", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 86.08%
            { "Bortezomib Thalidomide Dexamethasone (VTD) (28 day cycle)", new ValueWithNote("35806059", "Bortezomib and Dexamethasone (Vd)") }, // 86.08%
            { "Cyclophosphamide Lenalidomide Dexamethasone (weekly cyclophosphamide)", new ValueWithNote("35806310", "Cyclophosphamide and Dexamethasone") }, // 86.04%
            { "Cisplatin (60) Etoposide (120) (SCLC) Daypt", new ValueWithNote("35805334", "Cisplatin, Etoposide, RT") }, // 86.04%
            { "CHOP-14 bolus", new ValueWithNote("35803591", "CHOP-14") }, // 85.99%
            { "Isatuximab Pomalidomide Dexamethasone", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 85.99%
            { "Zanubrutinib", new ValueWithNote("1525175", "Zanubrutinib and Obinutuzumab") }, // 85.99%
            { "Olaparib (relapsed/metastatic)", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 85.94000000000001%
            { "Methotrexate Mercaptopurine Indometacin", new ValueWithNote("35804058", "Mercaptopurine, Methotrexate, Vincristine") }, // 85.94000000000001%
            { "Gemcitabine Capecitabine (pancreas)", new ValueWithNote("35804557", "Capecitabine and Gemcitabine") }, // 85.94000000000001%
            { "Mogamulizumab", new ValueWithNote("35804815", "Mogamulizumab monotherapy") }, // 85.89%
            { "FEC (100) Docetaxel (75) Pertuzumab Trastuzumab IV (adjuvant use only)", new ValueWithNote("37560136", "FEC-THP (Docetaxel) (trastuzumab-dttb)") }, // 85.84%
            { "Ribociclib (aromatase inhibitor)", new ValueWithNote("35804288", "Letrozole and Ribociclib") }, // 85.84%
            { "EC Docetaxel Pertuzumab Trastuzumab IV (adjuvant)", new ValueWithNote("37560133", "EC-TH (Docetaxel) (trastuzumab-dttb)") }, // 85.79%
            { "R-BAC-500", new ValueWithNote("35804616", "R-BAC") }, // 85.79%
            { "Venetoclax Azacitidine (suitable for standard intensive induction DA)", new ValueWithNote("35803466", "Azacitidine and Venetoclax") }, // 85.79%
            { "Dalteparin prophylaxis", new ValueWithNote("35807097", "Dalteparin monotherapy") }, // 85.79%
            { "Midostaurin maintenance", new ValueWithNote("35803513", "Midostaurin monotherapy") }, // 85.79%
            { "Ivosidenib", new ValueWithNote("35803517", "Ivosidenib monotherapy") }, // 85.74000000000001%
            { "Lomustine", new ValueWithNote("35805719", "Lomustine monotherapy") }, // 85.74000000000001%
            { "Atezolizumab", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 85.69%
            { "Carboplatin Vinorelbine oral with concurrent RT (CrCl)", new ValueWithNote("35806405", "Carboplatin and Vinorelbine") }, // 85.69%
            { "Ifosfamide (3g) Doxorubicin (30mg) (sarcoma)", new ValueWithNote("35806966", "Doxorubicin, Ifosfamide, RT") }, // 85.64%
            { "Bortezomib Thalidomide Dexamethasone (VTD) (21 day cycle)", new ValueWithNote("35806059", "Bortezomib and Dexamethasone (Vd)") }, // 85.64%
            { "NEPTUNES Nivolumab monotherapy (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 85.6%
            { "Olaparib", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 85.6%
            { "Paclitaxel (80) Carboplatin (AUC 2) (CrCl) weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 85.55%
            { "Liposomal doxorubicin Carboplatin (CrCl)", new ValueWithNote("35805245", "Carboplatin and Pegylated liposomal doxorubicin") }, // 85.55%
            { "ABVD (3 cycles)", new ValueWithNote("35805802", "ABVD") }, // 85.5%
            { "Osimertinib", new ValueWithNote("35804394", "Osimertinib monotherapy") }, // 85.5%
            { "Acalabrutinib", new ValueWithNote("911934", "Acalabrutinib and Obinutuzumab") }, // 85.5%
            { "Bevacizumab Pembrolizumab Carboplatin Paclitaxel (CrCl)", new ValueWithNote("37561592", "Carboplatin and Paclitaxel (CP), Bevacizumab-aveg, Cadonilimab") }, // 85.5%
            { "Gemcitabine with concurrent RT (bladder)", new ValueWithNote("35804152", "Gemcitabine and RT") }, // 85.5%
            { "Asciminib", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 85.45%
            { "Pertuzumab Trastuzumab Docetaxel (metastatic)", new ValueWithNote("911985", "Docetaxel and Pertuzumab") }, // 85.45%
            { "Ixazomib Lenalidomide Dexamethasone (named patient supply)", new ValueWithNote("35806065", "Ixazomib and Dexamethasone") }, // 85.39999999999999%
            { "Crizotinib", new ValueWithNote("35806424", "Crizotinib monotherapy") }, // 85.39999999999999%
            { "Daratumumab", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 85.39999999999999%
            { "Alectinib", new ValueWithNote("35804390", "Alectinib monotherapy") }, // 85.39999999999999%
            { "Glofitamab monotherapy (including Obinutuzumab pre-treatment) (EAMS)", new ValueWithNote("37557451", "Glofitamab monotherapy") }, // 85.39999999999999%
            { "Doxorubicin Cisplatin Cyclophosphamide (CAP)", new ValueWithNote("35806492", "Cisplatin and Cyclophosphamide") }, // 85.35000000000001%
            { "Nilotinib", new ValueWithNote("35804079", "Nilotinib monotherapy") }, // 85.35000000000001%
            { "Fludarabine Melphalan Alemtuzumab (30 late) RIC", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 85.35000000000001%
            { "Epirubicin Oxaliplatin Capecitabine (EOX)", new ValueWithNote("35805347", "Capecitabine, Oxaliplatin, RT") }, // 85.35000000000001%
            { "EV-302 Arm A Enfortumab vedotin Pembrolizumab (Trial)", new ValueWithNote("37557435", "Enfortumab vedotin and Pembrolizumab") }, // 85.35000000000001%
            { "Olaparib TABLETS", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 85.25%
            { "Cisplatin (75) Etoposide (100) (SCLC) Daypt", new ValueWithNote("35805334", "Cisplatin, Etoposide, RT") }, // 85.25%
            { "Trastuzumab Cisplatin Capecitabine (GOJ)", new ValueWithNote("35805363", "Capecitabine and Cisplatin (CX) and Trastuzumab") }, // 85.25%
            { "Inotuzumab ozogamicin cycle 2 onwards achieved CR", new ValueWithNote("35804064", "Inotuzumab ozogamicin monotherapy") }, // 85.25%
            { "Quizartinib (compassionate use)", new ValueWithNote("1524997", "7+3i and Quizartinib") }, // 85.25%
            { "Omeprazole", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 85.21%
            { "Erlotinib", new ValueWithNote("35803579", "Erlotinib and Bevacizumab") }, // 85.21%
            { "IE/VC", new ValueWithNote("35805450", "VDC/IE") }, // 85.16%
            { "Neratinib", new ValueWithNote("35804200", "Neratinib and Paclitaxel") }, // 85.16%
            { "AVENuE AVD", new ValueWithNote("35805804", "AVD") }, // 85.11%
            { "Bevacizumab (7.5mg/kg) Paclitaxel Carboplatin (CrCl) (ovarian)", new ValueWithNote("37561592", "Carboplatin and Paclitaxel (CP), Bevacizumab-aveg, Cadonilimab") }, // 85.11%
            { "EMA/CO (germ cell)", new ValueWithNote("42542356", "EMA/CO") }, // 85.11%
            { "Tivozanib", new ValueWithNote("905825", "Tivozanib monotherapy") }, // 85.06%
            { "Busulfan single dose (oral)", new ValueWithNote("35804638", "Busulfan monotherapy") }, // 85.06%
            { "MK-6482-013 Belzutifan (MK-6482) 200mg (Trial)", new ValueWithNote("905631", "Belzutifan monotherapy") }, // 85.06%
            { "Apalutamide (support)", new ValueWithNote("35806850", "Apalutamide monotherapy") }, // 85.00999999999999%
            { "Eribulin (compassionate use)", new ValueWithNote("35804265", "Eribulin monotherapy") }, // 85.00999999999999%
            { "Zoledronic acid 4 weekly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 85.00999999999999%
            { "Atezolizumab Carboplatin Etoposide (CrCl)", new ValueWithNote("35806941", "Carboplatin and Etoposide (CE) and Atezolizumab") }, // 85.00999999999999%
            { "Carboplatin Pembrolizumab Pemetrexed without pemetrexed maintenance (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 85.00999999999999%
            { "M18-803 Ibrutinib Venetoclax (Trial)", new ValueWithNote("35806097", "Ibrutinib and Venetoclax") }, // 85.00999999999999%
            { "Thiotepa Busulfan Fludarabine ATG (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 85.00999999999999%
            { "Topotecan (oral)", new ValueWithNote("37560740", "EP-Topotecan") }, // 84.96000000000001%
            { "Trastuzumab deruxtecan (Enhertu)", new ValueWithNote("42542261", "Trastuzumab deruxtecan monotherapy") }, // 84.96000000000001%
            { "Fludarabine TBI post transplant Cyclophosphamide MUD", new ValueWithNote("35803622", "Fludarabine and TBI") }, // 84.91%
            { "Abemaciclib (aromatase inhibitor)", new ValueWithNote("35804280", "Abemaciclib and Anastrozole") }, // 84.91%
            { "Cyclophosphamide Dexamethasone Rituximab (DRC)", new ValueWithNote("37556987", "Cyclophosphamide, Daunorubicin, Vincristine, Dexamethasone") }, // 84.91%
            { "rEECur Topotecan Cyclophosphamide (TC) (NCRN Trial)", new ValueWithNote("35805453", "Cyclophosphamide and Topotecan") }, // 84.91%
            { "Sorafenib", new ValueWithNote("37557016", "Erlotinib and Sorafenib") }, // 84.86%
            { "Bortezomib weekly Cyclophosphamide Dexamethasone", new ValueWithNote("35806059", "Bortezomib and Dexamethasone (Vd)") }, // 84.86%
            { "EC Docetaxel Pertuzumab Trastuzumab (neoadjuvant node positive)", new ValueWithNote("37560424", "EC-TH (Docetaxel) (trastuzumab-qyyp)") }, // 84.81%
            { "Paclitaxel weekly Phesgo SC (adjuvant use only)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 84.81%
            { "Daratumumab SC Bortezomib Thalidomide Dexamethasone", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 84.77%
            { "R-Lenalidomide", new ValueWithNote("35804591", "Lenalidomide and Rituximab (R2)") }, // 84.77%
            { "Bortezomib", new ValueWithNote("912234", "Bortezomib and Bevacizumab") }, // 84.77%
            { "Cisplatin Pembrolizumab Pemetrexed daypt", new ValueWithNote("35806412", "Cisplatin, Pemetrexed, Pembrolizumab") }, // 84.77%
            { "Brigatinib", new ValueWithNote("35806423", "Brigatinib monotherapy") }, // 84.77%
            { "Gemcitabine (1000) Carboplatin (CrCl)", new ValueWithNote("37557387", "Carboplatin, Gemcitabine, Bevacizumab") }, // 84.72%
            { "TOPAZ-1 Gemcitabine Cisplatin Durvalumab / placebo (Trial)", new ValueWithNote("37560901", "Cisplatin, Durvalumab, RT") }, // 84.72%
            { "Trastuzumab emtansine (Kadcyla)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 84.72%
            { "MK-6482-013 Belzutifan (MK-6482) 120mg (Trial)", new ValueWithNote("905631", "Belzutifan monotherapy") }, // 84.67%
            { "Ifosfamide Etoposide (5 day)", new ValueWithNote("35805125", "Etoposide, Ifosfamide, Methotrexate") }, // 84.67%
            { "Carboplatin Paclitaxel Pembrolizumab (CrCl)", new ValueWithNote("35806415", "Carboplatin and Paclitaxel (CP) and Pembrolizumab") }, // 84.67%
            { "Cisplatin RT (100 H&N) Daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 84.67%
            { "FOLFIRINOX modified (adjuvant)", new ValueWithNote("35807526", "FOLFIRINOX/modified FOLFIRINOX +/- Chemoradiation") }, // 84.61999999999999%
            { "Cisplatin (40) with concurrent RT (head and neck)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 84.57000000000001%
            { "Abemaciclib (aromatase inhibitor) (metastatic)", new ValueWithNote("35804280", "Abemaciclib and Anastrozole") }, // 84.52%
            { "Bevacizumab (15mg/kg) Paclitaxel Carboplatin (CrCl) (ovarian)", new ValueWithNote("37561592", "Carboplatin and Paclitaxel (CP), Bevacizumab-aveg, Cadonilimab") }, // 84.52%
            { "Busulfan Fludarabine ATG RIC (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 84.52%
            { "Darolutamide Docetaxel Prednisolone", new ValueWithNote("1524994", "ADT, Darolutamide, Docetaxel") }, // 84.52%
            { "Carboplatin Paclitaxel Trastuzumab (GOJ) (CrCl)", new ValueWithNote("37556960", "Carboplatin, Paclitaxel, Trastuzumab, RT") }, // 84.52%
            { "Cisplatin (75) Etoposide (100) (Neuroendocrine) daypt", new ValueWithNote("35805334", "Cisplatin, Etoposide, RT") }, // 84.47%
            { "VIP Cisplatin Etoposide Ifosfamide", new ValueWithNote("42542357", "Etoposide, Ifosfamide, Imatinib") }, // 84.42%
            { "Durvalumab Gemcitabine Cisplatin (cholangiocarcinoma) (compassionate use)", new ValueWithNote("1524839", "Cisplatin and Gemcitabine (GC) and Durvalumab") }, // 84.38%
            { "Zoledronic acid 3 weekly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 84.33%
            { "Gemcitabine (1000) Cisplatin (70) daypt", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 84.33%
            { "Pembrolizumab Pemetrexed Carboplatin (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 84.33%
            { "Daratumumab SC", new ValueWithNote("1524916", "Dara-Kd (SC daratumumab)") }, // 84.28%
            { "Cyclophosphamide Fludarabine TBI RIC (Haploidentical)", new ValueWithNote("35803627", "Fludarabine, Cyclophosphamide, TBI for dUCB or haploidentical transplant") }, // 84.28%
            { "Paclitaxel Carboplatin (EDTA)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 84.28%
            { "Azacitidine (SC)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 84.23%
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab (neoadjuvant node positive) CrCl", new ValueWithNote("37556960", "Carboplatin, Paclitaxel, Trastuzumab, RT") }, // 84.23%
            { "Paclitaxel Carboplatin (CrCl)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 84.23%
            { "Gemcitabine (1000) Cisplatin (70)", new ValueWithNote("35804565", "Gemcitabine, Cisplatin, S-1") }, // 84.23%
            { "Fludarabine Melphalan Alemtuzumab (60) RIC (MUD transplant)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 84.23%
            { "Cyclophosphamide Etoposide Procarbazine Prednisolone induction (PEP-C)", new ValueWithNote("37559899", "RT-PEPC; Induction (rituximab-rixi)") }, // 84.17999999999999%
            { "Trastuzumab emtansine (Kadcyla) (compassionate use)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 84.17999999999999%
            { "Ifosfamide high dose", new ValueWithNote("35804542", "Ifosfamide monotherapy") }, // 84.17999999999999%
            { "Ruxolitinib support", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 84.17999999999999%
            { "Paclitaxel weekly Phesgo SC (following completion of EC cycles)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 84.17999999999999%
            { "Fludarabine Cyclophosphamide Alemtuzumab (Aplastic Anemia) (Allograft)", new ValueWithNote("35804580", "Fludarabine and Alemtuzumab") }, // 84.17999999999999%
            { "Paclitaxel Carboplatin (CrCl) 7 day with RT", new ValueWithNote("35805350", "Carboplatin and Paclitaxel (CP) and RT") }, // 84.17999999999999%
            { "Trabectedin (sarcoma)", new ValueWithNote("1525050", "Doxorubicin and Trabectedin") }, // 84.17999999999999%
            { "Cisplatin Etoposide (neuroendocrine)", new ValueWithNote("35805329", "Cisplatin and Etoposide (EP)") }, // 84.17999999999999%
            { "Midostaurin Daunorubicin Cytarabine", new ValueWithNote("35803442", "Cytarabine and Daunorubicin") }, // 84.17999999999999%
            { "Olaparib TABLETS (300mg bd)", new ValueWithNote("37557191", "Abiraterone and Olaparib") }, // 84.13000000000001%
            { "Fedratinib (support)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 84.13000000000001%
            { "Pembrolizumab Carboplatin Paclitaxel (CrCl)", new ValueWithNote("35806415", "Carboplatin and Paclitaxel (CP) and Pembrolizumab") }, // 84.13000000000001%
            { "Cladribine (Litak) (SC) Rituximab (hairy cell leukaemia)", new ValueWithNote("35805757", "Cladribine and Rituximab") }, // 84.08%
            { "Docetaxel Fluorouracil Oxaliplatin (FLOT)", new ValueWithNote("35805346", "Capecitabine, Docetaxel, Oxaliplatin, RT") }, // 84.08%
            { "Temozolomide 150/200", new ValueWithNote("35806581", "Temozolomide and Thalidomide") }, // 84.08%
            { "Gemcitabine (1000) Cisplatin (25)", new ValueWithNote("35804565", "Gemcitabine, Cisplatin, S-1") }, // 84.03%
            { "Pembrolizumab Pemetrexed Carboplatin without pemetrexed maintenance (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 84.03%
            { "Ribociclib", new ValueWithNote("35804285", "Fulvestrant and Ribociclib") }, // 84.03%
            { "CNIS793B12201 Arm 3 Gemcitabine Nab-Paclitaxel (Trial)", new ValueWithNote("35804567", "Gemcitabine and nab-Paclitaxel") }, // 84.03%
            { "Cisplatin Pemetrexed Daypt", new ValueWithNote("35806173", "Cisplatin and Pemetrexed") }, // 83.98%
            { "Selpercatinib", new ValueWithNote("912062", "Selpercatinib monotherapy") }, // 83.98%
            { "Nivolumab Vinorelbine (oral) Carboplatin (neoadjuvant) (CrCl)", new ValueWithNote("35806398", "Carboplatin, Vinorelbine, RT") }, // 83.98%
            { "Dabrafenib", new ValueWithNote("35804434", "Dabrafenib monotherapy") }, // 83.98%
            { "Cemiplimab", new ValueWithNote("35804822", "Cemiplimab monotherapy") }, // 83.94%
            { "Denosumab", new ValueWithNote("35804178", "Denosumab monotherapy") }, // 83.94%
            { "Carboplatin Etoposide (EDTA) (sarcoma)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 83.94%
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab IV (neoadjuvant node positive)CrCl", new ValueWithNote("37556960", "Carboplatin, Paclitaxel, Trastuzumab, RT") }, // 83.94%
            { "Daratumumab SC Pomalidomide Dexamethasone", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 83.89%
            { "Darolutamide (non-metastatic)", new ValueWithNote("1524994", "ADT, Darolutamide, Docetaxel") }, // 83.89%
            { "Chlorambucil (days 1 to 7)", new ValueWithNote("35804622", "Chlorambucil monotherapy") }, // 83.89%
            { "Bosutinib (compassionate use)", new ValueWithNote("35804082", "Bosutinib monotherapy") }, // 83.89%
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab (neoadjuvant node neg/unknown)CrCl", new ValueWithNote("37556960", "Carboplatin, Paclitaxel, Trastuzumab, RT") }, // 83.84%
            { "Avapritinib (compassionate use)", new ValueWithNote("42542281", "Avapritinib monotherapy") }, // 83.84%
            { "Trabectedin", new ValueWithNote("1525050", "Doxorubicin and Trabectedin") }, // 83.78999999999999%
            { "Gemcitabine (lymphoma)", new ValueWithNote("35804266", "Gemcitabine and Bevacizumab") }, // 83.74000000000001%
            { "Lenvatinib (Thyroid)", new ValueWithNote("37557973", "Lenvatinib and Atezolizumab") }, // 83.74000000000001%
            { "Trametinib", new ValueWithNote("35806139", "Trametinib monotherapy") }, // 83.74000000000001%
            { "Olaparib (adjuvant)", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 83.74000000000001%
            { "Paclitaxel (80) (days 1, 8 and 15)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 83.69%
            { "Liposomal doxorubicin (support)", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 83.69%
            { "Streptozocin Capecitabine", new ValueWithNote("35806380", "Fluorouracil and Streptozocin") }, // 83.69%
            { "EC Docetaxel Pertuzumab Trastuzumab (neoadjuvant node negative / unknown)", new ValueWithNote("37560133", "EC-TH (Docetaxel) (trastuzumab-dttb)") }, // 83.69%
            { "STELLAR CHOP-R (Trial)", new ValueWithNote("35805028", "R-CHOP") }, // 83.69%
            { "Fludarabine Melphalan Alemtuzumab (90) RIC (MUD transplant)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 83.69%
            { "Cisplatin Etoposide (oral)", new ValueWithNote("35805329", "Cisplatin and Etoposide (EP)") }, // 83.69%
            { "Carboplatin Etoposide (oral etoposide days 2 and 3) (CrCl)", new ValueWithNote("35101612", "Carboplatin, Etoposide, RT") }, // 83.69%
            { "Cyclophosphamide Fludarabine Thiotepa TBI RIC (Cord transplant)", new ValueWithNote("35803619", "Cyclophosphamide, Fludarabine, Thiotepa") }, // 83.64%
            { "DREAMM-3 Pomalidomide Dexamethasone (Trial)", new ValueWithNote("42542407", "Pomalidomide and Dexamethasone (Pd)") }, // 83.64%
            { "Gemcitabine (1200) Carboplatin (CrCl)", new ValueWithNote("35806426", "Carboplatin and Gemcitabine/Erlotinib") }, // 83.64%
            { "Goserelin", new ValueWithNote("35804240", "Goserelin and Tamoxifen") }, // 83.59%
            { "Fludarabine Melphalan Alemtuzumab (60 late) RIC (off study PRO-DLI)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 83.59%
            { "Zoledronic acid 6 weekly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 83.59%
            { "Polatuzumab Rituximab Cyclophosphamide Doxorubicin Prednisolone (PR-CHP)", new ValueWithNote("37559679", "Pola-R-CHP (rituximab-rixa)") }, // 83.54%
            { "TOPAZ-1 Durvalumab / placebo monotherapy (Trial)", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 83.54%
            { "Lenalidomide (MDS)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 83.54%
            { "Osimertinib (support)", new ValueWithNote("35804394", "Osimertinib monotherapy") }, // 83.54%
            { "Atezolizumab Bevacizumab (EAMS)", new ValueWithNote("35806408", "Atezolizumab and Bevacizumab") }, // 83.54%
            { "Pembrolizumab Paclitaxel Carboplatin EC (neoadjuvant then adjuvant) (EDTA)", new ValueWithNote("905606", "Carboplatin and Etoposide (CE) and Pembrolizumab") }, // 83.5%
            { "Zoledronic acid 4 weekly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 83.5%
            { "Vismodegib (compassionate use)", new ValueWithNote("35804821", "Vismodegib monotherapy") }, // 83.5%
            { "VTDPACE", new ValueWithNote("35806290", "VTP") }, // 83.5%
            { "Carboplatin Etoposide (CrCl)", new ValueWithNote("35101612", "Carboplatin, Etoposide, RT") }, // 83.5%
            { "rEECur Topotecan Cyclophosphamide (off study)", new ValueWithNote("35805453", "Cyclophosphamide and Topotecan") }, // 83.5%
            { "Oxaliplatin Capecitabine (CapOx)", new ValueWithNote("35804791", "CapeOx and Panitumumab") }, // 83.45%
            { "Gemcitabine (1000) Cisplatin (70 split)", new ValueWithNote("35804565", "Gemcitabine, Cisplatin, S-1") }, // 83.45%
            { "Carboplatin (High grade glioma)", new ValueWithNote("35102030", "Carboplatin and Cisplatin") }, // 83.45%
            { "Vismodegib", new ValueWithNote("35804821", "Vismodegib monotherapy") }, // 83.45%
            { "Gemcitabine (1000) Cisplatin (25) daypt", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 83.45%
            { "Romiplostim", new ValueWithNote("35805922", "Romiplostim monotherapy") }, // 83.39999999999999%
            { "EC Docetaxel Pertuzumab Trastuzumab IV (neoadjuvant node positive)", new ValueWithNote("37560424", "EC-TH (Docetaxel) (trastuzumab-qyyp)") }, // 83.39999999999999%
            { "Cisplatin (50) Etoposide (50) (NSCLC) Daypt", new ValueWithNote("35805334", "Cisplatin, Etoposide, RT") }, // 83.39999999999999%
            { "COSI Thiotepa Busulphan Fludarabine ATG (TBF) (Trial)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 83.39999999999999%
            { "Bortezomib Cyclophosphamide daily Dexamethasone", new ValueWithNote("35806059", "Bortezomib and Dexamethasone (Vd)") }, // 83.39999999999999%
            { "Bortezomib daily Cyclophosphamide Dexamethasone (Amyloidosis)", new ValueWithNote("35806059", "Bortezomib and Dexamethasone (Vd)") }, // 83.39999999999999%
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab (neoadjuvant)", new ValueWithNote("37561006", "Carboplatin, Paclitaxel, Trastuzumab-dttb, RT") }, // 83.39999999999999%
            { "Vinorelbine (oral)", new ValueWithNote("35804241", "Vinorelbine monotherapy") }, // 83.35000000000001%
            { "Cytarabine high dose", new ValueWithNote("35803435", "High-dose Cytarabine monotherapy (HiDAC)") }, // 83.35000000000001%
            { "PARTNER Carboplatin Paclitaxel (Trial)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 83.35000000000001%
            { "Cisplatin (40 weekly) RT (cervix)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 83.35000000000001%
            { "Pacritinib (compassionate use)", new ValueWithNote("1525214", "Pacritinib monotherapy") }, // 83.25%
            { "Temozolomide (astrocytoma)", new ValueWithNote("35806135", "Temozolomide and Bevacizumab") }, // 83.25%
            { "Carboplatin Paclitaxel (NSCLC) (CrCl)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 83.25%
            { "Lutetium-177 oxodotreotide (without support medication)", new ValueWithNote("35806383", "Lutetium Lu 177 dotatate and Octreotide LAR") }, // 83.25%
            { "Niraparib (relapsed)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 83.25%
            { "Carboplatin Etoposide (CrCl) (Oral etoposide days 2+3)", new ValueWithNote("35101612", "Carboplatin, Etoposide, RT") }, // 83.25%
            { "Cladribine (Litak) (SC)", new ValueWithNote("35803546", "Cladribine monotherapy") }, // 83.25%
            { "Carboplatin Fluorouracil (CrCl)", new ValueWithNote("35805773", "Carboplatin and Fluorouracil") }, // 83.2%
            { "SCALOP-2 Gemcitabine Paclitaxel albumin bound (NCRN Trial)", new ValueWithNote("35804248", "Capecitabine and Paclitaxel, nanoparticle albumin-bound") }, // 83.2%
            { "Darolutamide (non-metastatic) (support)", new ValueWithNote("1524994", "ADT, Darolutamide, Docetaxel") }, // 83.15%
            { "Temozolomide 75 + RT (patients 65 years and over)", new ValueWithNote("35803686", "Temozolomide and RT") }, // 83.15%
            { "Fluorouracil (96hr CIV) infusor with RT", new ValueWithNote("35804534", "Fluorouracil and RT") }, // 83.15%
            { "Carboplatin Etoposide (EDTA) (Oral etoposide days 2+3)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 83.11%
            { "Busulfan (oral) (single dose) (support)", new ValueWithNote("35804638", "Busulfan monotherapy") }, // 83.11%
            { "Pembrolizumab Paclitaxel Carboplatin EC (neoadjuvant then adjuvant)", new ValueWithNote("35806415", "Carboplatin and Paclitaxel (CP) and Pembrolizumab") }, // 83.06%
            { "Vinorelbine oral", new ValueWithNote("35804241", "Vinorelbine monotherapy") }, // 83.06%
            { "Ruxolitinib (compassionate use)", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 83.06%
            { "Daratumumab SC Lenalidomide Dexamethasone", new ValueWithNote("35805648", "Lenalidomide, Dexamethasone, Rituximab") }, // 83.06%
            { "Anti-thymocyte globulin (ATG) equine (aplastic anaemia)", new ValueWithNote("35803736", "ATG (Horse), Cyclosporine, G-CSF") }, // 83.00999999999999%
            { "DTPACE (cyclophosphamide bolus)", new ValueWithNote("35806327", "DTPACE") }, // 83.00999999999999%
            { "Gemcitabine (1000) Carboplatin (CrCl) (ovarian)", new ValueWithNote("37557387", "Carboplatin, Gemcitabine, Bevacizumab") }, // 83.00999999999999%
            { "VAC (off study)", new ValueWithNote("35806910", "VAC") }, // 83.00999999999999%
            { "Cediranib (compassionate use)", new ValueWithNote("905688", "Cediranib monotherapy") }, // 83.00999999999999%
            { "Capecitabine (1000mg/m2)", new ValueWithNote("35804227", "Capecitabine monotherapy") }, // 83.00999999999999%
            { "MoTD Fludarabine Busulfan experimental group 2 (Trial)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 82.96%
            { "Abiraterone Prednisolone", new ValueWithNote("37556796", "Abiraterone, Radium-223, Prednisone") }, // 82.91%
            { "Liposomal doxorubicin (sarcoma)", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 82.91%
            { "Pembrolizumab Paclitaxel Carboplatin EC (neoadjuvant then adjuvant) (CrCl)", new ValueWithNote("35806415", "Carboplatin and Paclitaxel (CP) and Pembrolizumab") }, // 82.86%
            { "Paclitaxel weekly Pertuzumab Trastuzumab IV (adjuvant use only)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 82.80999999999999%
            { "Mitomycin Capecitabine 42 day", new ValueWithNote("35804560", "Capecitabine and Mitomycin") }, // 82.80999999999999%
            { "DA-EPOCH-R (etopsode phosphate)", new ValueWithNote("35804378", "DA-R-EPOCH") }, // 82.80999999999999%
            { "Pexidartinib (compassionate use)", new ValueWithNote("1524984", "Pexidartinib monotherapy") }, // 82.76%
            { "Liposomal doxorubicin Carboplatin (CrCl) (ovarian)", new ValueWithNote("35805245", "Carboplatin and Pegylated liposomal doxorubicin") }, // 82.71%
            { "Cabozantinib (RCC)", new ValueWithNote("912132", "Cabozantinib and Nivolumab") }, // 82.71%
            { "Trastuzumab emtansine (Kadcyla) (adjuvant)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 82.71%
            { "Pertuzumab (neoadjuvant)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 82.67%
            { "Daratumumab (cycle 1 standard rate then rapid rate subsequent cycles)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 82.67%
            { "Zoledronic acid (lymphoma bone protection) (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.67%
            { "Cabozantinib (compassionate use)", new ValueWithNote("912132", "Cabozantinib and Nivolumab") }, // 82.62%
            { "Cisplatin Dexamethasone Gemcitabine PEG-Asparaginase (DDGP)", new ValueWithNote("37557422", "Daunorubicin, L-Asparaginase, Vincristine, Dexamethasone") }, // 82.62%
            { "ASTX727-02 ASTX727 then Decitabine (Trial)", new ValueWithNote("912034", "Decitabine and cedazuridine monotherapy") }, // 82.62%
            { "AVENuE ABVD (Trial)", new ValueWithNote("35805802", "ABVD") }, // 82.57%
            { "Methylprednisolone 1mg/kg", new ValueWithNote("35807042", "Methylprednisolone monotherapy") }, // 82.57%
            { "Cabazitaxel", new ValueWithNote("905605", "Cabazitaxel and Prednisolone") }, // 82.57%
            { "Zoledronic acid 6 weekly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.52000000000001%
            { "EC Docetaxel Pertuzumab Trastuzumab IV (neoadjuvant node negative / unknown)", new ValueWithNote("37560133", "EC-TH (Docetaxel) (trastuzumab-dttb)") }, // 82.52000000000001%
            { "Paclitaxel Ifosfamide Cisplatin (TIP)", new ValueWithNote("35805248", "Ifosfamide and Paclitaxel") }, // 82.52000000000001%
            { "Busulfan Fludarabine ATG RIC (myelofibrosis) (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 82.47%
            { "Gemtuzumab Daunorubicin Cytarabine consolidation", new ValueWithNote("35804078", "Imatinib-based consolidation") }, // 82.47%
            { "BGB-3111-LTE1 Zanubrutinib (Trial)", new ValueWithNote("1525175", "Zanubrutinib and Obinutuzumab") }, // 82.47%
            { "Cisplatin RT (40 H&N) weekly daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 82.47%
            { "Zoledronic acid 3 weekly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.47%
            { "Cyclophosphamide Etoposide Procarbazine Prednisolone maintenance (PEP-C)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 82.47%
            { "Niraparib (Expanded access programme)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 82.47%
            { "Carfilzomib Lenalidomide Dexamethasone (CarLenDex)", new ValueWithNote("1525084", "Carfilzomib and Lenalidomide (KR)") }, // 82.47%
            { "Zoledronic acid 6 monthly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.47%
            { "Palbociclib", new ValueWithNote("37556966", "Palbociclib and Tamoxifen") }, // 82.47%
            { "Busulfan Fludarabine ATG RIC (AML/MDS) (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 82.47%
            { "Carboplatin Fluorouracil (CrCl) (H&N) daypt", new ValueWithNote("35805349", "Carboplatin, Fluorouracil, RT") }, // 82.47%
            { "DA", new ValueWithNote("35807524", "DA 3+10") }, // 82.42%
            { "Plerixafor + GCSF priming", new ValueWithNote("35101641", "Plerixafor and G-CSF") }, // 82.42%
            { "Ipilimumab Nivolumab (mesothelioma) (compassionate use)", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 82.37%
            { "CompARE Arm 5 Cisplatin Durvalumab (NCRN Trial)", new ValueWithNote("37560901", "Cisplatin, Durvalumab, RT") }, // 82.37%
            { "Capecitabine (1000)", new ValueWithNote("35804557", "Capecitabine and Gemcitabine") }, // 82.37%
            { "Olaparib capsules (400mg bd)", new ValueWithNote("37557191", "Abiraterone and Olaparib") }, // 82.37%
            { "IMC-F106C-101 IMC-F106C Paclitaxel albumin bound (Trial)", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 82.37%
            { "ABVD (ABVD 2 cycles AVD 4 cycles)", new ValueWithNote("35805802", "ABVD") }, // 82.32000000000001%
            { "Gemcitabine Dexamethasone Cisplatin (GDP)", new ValueWithNote("37556910", "Cisplatin and Gemcitabine (GC) and Gefitinib") }, // 82.32000000000001%
            { "ICE modified", new ValueWithNote("35805126", "ICE") }, // 82.32000000000001%
            { "CAR-T Fludarabine Cyclophosphamide Axicabtagene ciloleucel", new ValueWithNote("35803615", "Fludarabine, Busulfan, Cyclophosphamide") }, // 82.32000000000001%
            { "EC Paclitaxel Carboplatin (CrCl)", new ValueWithNote("1525098", "EC-TH (Paclitaxel)") }, // 82.32000000000001%
            { "Dalteparin therapeutic solid tumours", new ValueWithNote("35807097", "Dalteparin monotherapy") }, // 82.28%
            { "Gemcitabine (1000) Carboplatin (CrCl) (breast)", new ValueWithNote("37557387", "Carboplatin, Gemcitabine, Bevacizumab") }, // 82.28%
            { "Pirtobrutinib (Compassionate Use)", new ValueWithNote("37556847", "Pirtobrutinib monotherapy") }, // 82.23%
            { "Gemcitabine (pancreas)", new ValueWithNote("35804266", "Gemcitabine and Bevacizumab") }, // 82.23%
            { "R-Lenalidomide (IV rituximab cycle 1 then SC)", new ValueWithNote("37558891", "Lenalidomide and Rituximab-abbs (R2)") }, // 82.23%
            { "Cisplatin (40 weekly) RT (cervix) daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 82.23%
            { "5F9005 Hu5F9-G4 Azacitidine evaluation (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 82.17999999999999%
            { "FLAIR Ibrutinib monotherapy (NCRN Trial)", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 82.17999999999999%
            { "Ipilimumab Nivolumab (renal cell)", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 82.17999999999999%
            { "Cytarabine HD Rituximab", new ValueWithNote("35804044", "Cytarabine, Idarubicin, Rituximab") }, // 82.17999999999999%
            { "Mitotane", new ValueWithNote("35803587", "Mitotane and Streptozocin") }, // 82.17999999999999%
            { "Talazoparib (Compassionate use)", new ValueWithNote("35804270", "Talazoparib monotherapy") }, // 82.13000000000001%
            { "Crizanlizumab (support)", new ValueWithNote("42542402", "Crizanlizumab monotherapy") }, // 82.13000000000001%
            { "Cisplatin (40) with concurrent RT (cervix)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 82.13000000000001%
            { "COSI Fludarabine Busulphan 2 (FB4) (off study)", new ValueWithNote("35803625", "Busulfan, Fludarabine, Ibritumomab tiuxetan") }, // 82.08%
            { "Dexamethasone daily", new ValueWithNote("35804388", "Dexamethasone monotherapy") }, // 82.08%
            { "Avelumab (EAMS)", new ValueWithNote("35804159", "Avelumab monotherapy") }, // 82.03%
            { "Trastuzumab emtansine (Kadcyla) (metastatic)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 82.03%
            { "Sunitinib (pNET)", new ValueWithNote("905814", "Erlotinib and Sunitinib") }, // 82.03%
            { "UPSTREAM (EORTC1559) Niraparib (Trial)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 82.03%
            { "MoTD Fludarabine Busulfan MF experimental group 2 (Trial)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 81.98%
            { "OASIS II Arm B Ibrutinib Venetoclax Rituximab (Trial)", new ValueWithNote("1525137", "Ibrutinib, Venetoclax, Obinutuzumab") }, // 81.98%
            { "MoTD Fludarabine Busulfan MF experimental group 3 (Trial)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 81.98%
            { "Pertuzumab Trastuzumab IV (metastatic)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 81.93%
            { "Pertuzumab Trastuzumab IV (neoadjuvant)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 81.93%
            { "POMB/ACE", new ValueWithNote("35805049", "ACE") }, // 81.93%
            { "R-VP", new ValueWithNote("35805630", "R-CVP") }, // 81.93%
            { "Olaparib tablets (Managed access programme)", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 81.93%
            { "Dasatinib (chronic phase CML)", new ValueWithNote("905617", "Dasatinib and Blinatumomab") }, // 81.88%
            { "Docetaxel Pertuzumab Trastuzumab IV (metastatic)", new ValueWithNote("911985", "Docetaxel and Pertuzumab") }, // 81.88%
            { "Docetaxel (75) (prostate)", new ValueWithNote("35804162", "Docetaxel monotherapy") }, // 81.88%
            { "Bevacizumab 15mg/Kg", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 81.88%
            { "Paclitaxel albumin-bound Phesgo SC (metastatic)", new ValueWithNote("37558771", "Paclitaxel, nanoparticle albumin-bound and Bevacizumab-onbe") }, // 81.88%
            { "Mini-BEAM (5 day) modified", new ValueWithNote("35805837", "Mini-BEAM") }, // 81.88%
            { "Lenvatinib Pembrolizumab 42 day", new ValueWithNote("42542382", "Lenvatinib and Pembrolizumab") }, // 81.88%
            { "Daunorubicin liposomal Cytarabine liposomal (Vyxeos) induction", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 81.88%
            { "IMC-F106C-101 IMC-F106C monotherapy (Trial)", new ValueWithNote("35806908", "Interferon alfa-2c monotherapy") }, // 81.88%
            { "Docetaxel Carboplatin Phesgo SC (adjuvant) CrCl", new ValueWithNote("35806855", "Carboplatin, Docetaxel, Prednisone") }, // 81.84%
            { "Ifosfamide infusional (inpatient)", new ValueWithNote("35804542", "Ifosfamide monotherapy") }, // 81.84%
            { "Capecitabine (1250)", new ValueWithNote("35804557", "Capecitabine and Gemcitabine") }, // 81.84%
            { "Venetoclax", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 81.78999999999999%
            { "ASTX727-02 Decitabine then ASTX727 (Trial)", new ValueWithNote("912034", "Decitabine and cedazuridine monotherapy") }, // 81.78999999999999%
            { "Cyclophosphamide (oral)", new ValueWithNote("35803690", "Cyclophosphamide monotherapy") }, // 81.78999999999999%
            { "Paclitaxel weekly Carboplatin weekly (CrCl)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 81.74%
            { "STAMPEDE J HT + Abiraterone + Enzalutamide (NCRN Trial)", new ValueWithNote("911935", "Abiraterone and Enzalutamide") }, // 81.69%
            { "Bevacizumab Paclitaxel Carboplatin 21 day (CrCl) (ovarian/fallopian/peritoneal)", new ValueWithNote("37561592", "Carboplatin and Paclitaxel (CP), Bevacizumab-aveg, Cadonilimab") }, // 81.69%
            { "Isatuximab Pomalidomide Dexamethasone (EAMS)", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 81.69%
            { "daNIS-3 NIS793 mFOLFOX Bevacizumab (Trial)", new ValueWithNote("37558784", "mFOLFOX6-B (bevacizumab-onbe)") }, // 81.69%
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab IV(neoadjuvant node neg/unknown)Cr", new ValueWithNote("37556960", "Carboplatin, Paclitaxel, Trastuzumab, RT") }, // 81.64%
            { "MaxiCHOP Cytarabine HD Rituximab", new ValueWithNote("37559740", "maxi-R-CHOP/R-HiDAC (rituximab-rixa)") }, // 81.64%
            { "Vyxeos (Daunorubicin / Cytarabine) liposomal induction", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 81.64%
            { "Busulfan (oral)", new ValueWithNote("35804638", "Busulfan monotherapy") }, // 81.64%
            { "Larotrectinib (weeks 1 to 12 only)", new ValueWithNote("35806364", "Larotrectinib monotherapy") }, // 81.58999999999999%
            { "Paclitaxel Carboplatin EC (CrCl)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 81.58999999999999%
            { "Brentuximab vedotin Cyclophosphamide Doxorubicin Prednisolone (Bv-CHP)", new ValueWithNote("35805828", "Brentuximab vedotin and Nivolumab") }, // 81.58999999999999%
            { "Thiotepa Fludarabine Treosulfan (Cord transplant)", new ValueWithNote("37557094", "Busulfan, Fludarabine, Thiotepa") }, // 81.58999999999999%
            { "Chlorambucil-R (days 1 to 7)", new ValueWithNote("35804622", "Chlorambucil monotherapy") }, // 81.54%
            { "Ipilimumab Nivolumab (mesothelioma) (EAMS)", new ValueWithNote("35804435", "Ipilimumab and Nivolumab") }, // 81.54%
            { "Darolutamide Docetaxel Prednisolone (ORBIS)", new ValueWithNote("37556872", "Docetaxel, Enzalutamide, Prednisolone") }, // 81.54%
            { "P+R-ICE Arm B Pembrolizumab R-ICE (Trial)", new ValueWithNote("37559408", "R-ICE (rituximab-pvvr)") }, // 81.54%
            { "Cemiplimab (support)", new ValueWithNote("35804822", "Cemiplimab monotherapy") }, // 81.49%
            { "ECF Daypt", new ValueWithNote("35804562", "ECF") }, // 81.49%
            { "Gemcitabine (1200) Carboplatin (CrCl) (NSCLC/SCLC)", new ValueWithNote("35806426", "Carboplatin and Gemcitabine/Erlotinib") }, // 81.49%
            { "MoTD Fludarabine Busulfan experimental group 2 (off study)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 81.45%
            { "XL184-311 Cabozantinib / Placebo (Trial)", new ValueWithNote("35805797", "Cabozantinib monotherapy") }, // 81.45%
            { "Pertuzumab Trastuzumab IV (adjuvant)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 81.45%
            { "AZA-MDS-003 (NCRN 525) Azacitidine tablets / placebo (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 81.39999999999999%
            { "Bendamustine-R Polatuzumab (not BMT candidate)", new ValueWithNote("35804585", "Bendamustine and Obinutuzumab") }, // 81.39999999999999%
            { "Niraparib (first line maintenance)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 81.39999999999999%
            { "Irinotecan weekly", new ValueWithNote("35803692", "Irinotecan monotherapy") }, // 81.39999999999999%
            { "EC Docetaxel Phesgo SC (adjuvant)", new ValueWithNote("1525058", "EC-TL (Docetaxel)") }, // 81.39999999999999%
            { "Plerixafor + GCSF priming (protocol A)", new ValueWithNote("35101641", "Plerixafor and G-CSF") }, // 81.35%
            { "Cetuximab Irinotecan Modified DeGramont", new ValueWithNote("35804798", "Irinotecan and Cetuximab") }, // 81.35%
            { "AZA-MDS-003 (NCRN 525) Azacitidine tablets / placebo (NCRN trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 81.35%
            { "ENRICH Bendamustine-R (NCRN Trial)", new ValueWithNote("35804585", "Bendamustine and Obinutuzumab") }, // 81.3%
            { "Temozolomide (brain) (support)", new ValueWithNote("905662", "Cisplatin and Temozolomide") }, // 81.3%
            { "Daunorubicin liposomal Cytarabine liposomal (Vyxeos) consolidation", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 81.3%
            { "Zoledronic acid 6 monthly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 81.3%
            { "PLATO Mitomycin Capecitabine 23 days (ACT3 or ACT4) (NCRN Trial)", new ValueWithNote("35803671", "Capecitabine, Mitomycin, RT") }, // 81.3%
            { "INTERIM Dabrafenib Trametinib intermittent (Trial)", new ValueWithNote("35804100", "Dabrafenib and Trametinib") }, // 81.3%
            { "Dexamethasone 40mg 1 day", new ValueWithNote("35804388", "Dexamethasone monotherapy") }, // 81.3%
            { "Cetuximab Irinotecan Modified de Gramont", new ValueWithNote("35804798", "Irinotecan and Cetuximab") }, // 81.25%
            { "Doxorubicin Dexrazoxane", new ValueWithNote("35806578", "Doxorubicin and Streptozocin") }, // 81.25%
            { "Bexarotene induction", new ValueWithNote("35804812", "Bexarotene monotherapy") }, // 81.25%
            { "GO42661 Atezolizumab Bevacizumab/placebo Gemcitabine Cisplatin (Trial)", new ValueWithNote("912081", "Cisplatin and Gemcitabine (GC) and Atezolizumab") }, // 81.25%
            { "Melphalan high dose (Autograft)", new ValueWithNote("35806058", "Melphalan, then auto HSCT") }, // 81.2%
            { "Doxorubicin (sarcoma)", new ValueWithNote("42542300", "Doxorubicin and Fluorouracil") }, // 81.15%
            { "daNIS-3 NIS793 Tislelizumab mFOLFOX Bevacizumab (Trial)", new ValueWithNote("37561129", "mFOLFOX6, Atezolizumab, Bevacizumab-aybi") }, // 81.10000000000001%
            { "ONC001 2 weekly IV monotherapy (Trial)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 81.05%
            { "MoTD Fludarabine Busulfan MF control group 1 (Trial)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 81.05%
            { "Regorafenib (GIST)", new ValueWithNote("35804569", "Regorafenib monotherapy") }, // 81.05%
            { "Bortezomib weekly Cyclophosphamide Dexamethasone (CyBorDex) (Amyloidosis)", new ValueWithNote("35806059", "Bortezomib and Dexamethasone (Vd)") }, // 81.01%
            { "Etoposide PO (support)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 81.01%
            { "COSI Fludarabine Busulphan 4 (FB4) (Trial)", new ValueWithNote("35803625", "Busulfan, Fludarabine, Ibritumomab tiuxetan") }, // 81.01%
            { "Imatinib (sarcoma)", new ValueWithNote("35804634", "Imatinib and Interferon alfa") }, // 81.01%
            { "CAR-T Fludarabine Cyclophosphamide Tisagenlecleucel (NHL)", new ValueWithNote("35803615", "Fludarabine, Busulfan, Cyclophosphamide") }, // 81.01%
            { "IMbrave251 (MO42541) Atezolizumab Sorafenib (Trial)", new ValueWithNote("37558188", "Sorafenib and Atezolizumab") }, // 81.01%
            { "POD1UM-303 (InterAACT 2) INCMGA00012 / placebo Paclitaxel Carboplatin (Trial)", new ValueWithNote("37557944", "IP Carboplatin and Paclitaxel") }, // 80.96%
            { "Carboplatin AUC 5 CrCl (support)", new ValueWithNote("35804537", "Carboplatin monotherapy") }, // 80.96%
            { "ALL-RIC Fludarabine Melphalan Alemtuzumab (MUD) (Trial)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 80.91000000000001%
            { "Etoposide oral flexible dosing (support)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 80.91000000000001%
            { "PLATO Mitomycin Capecitabine 28 days (ACT4 or ACT5) (NCRN Trial)", new ValueWithNote("35803671", "Capecitabine, Mitomycin, RT") }, // 80.91000000000001%
            { "Capecitabine (1000) breast", new ValueWithNote("37560411", "Capecitabine and Trastuzumab-qyyp (XH)") }, // 80.86%
            { "R-CHOP-21 bolus", new ValueWithNote("37559535", "R-CHOP (rituximab-rite)") }, // 80.86%
            { "Lenvatinib Pembrolizumab 42 day (endometrial)", new ValueWithNote("42542382", "Lenvatinib and Pembrolizumab") }, // 80.81%
            { "PRIMUS 001 Paclitaxel albumin bound Gemcitabine (Trial)", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 80.76%
            { "Chlorambucil-R (continuous)", new ValueWithNote("35804622", "Chlorambucil monotherapy") }, // 80.76%
            { "Rituximab single agent (standard)", new ValueWithNote("35803432", "Rituximab monotherapy") }, // 80.76%
            { "Chlorambucil-R (days 1 to 14)", new ValueWithNote("35804622", "Chlorambucil monotherapy") }, // 80.76%
            { "Methotrexate (50)", new ValueWithNote("35804401", "IT Methotrexate and Methylprednisolone") }, // 80.76%
            { "Cetuximab weekly", new ValueWithNote("35804795", "Cetuximab monotherapy") }, // 80.76%
            { "Imatinib (CML)", new ValueWithNote("35804634", "Imatinib and Interferon alfa") }, // 80.71000000000001%
            { "CABL001E2201 Asciminib 60mg Imatinib arm (Trial)", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 80.71000000000001%
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab IV (adjuvant use only)", new ValueWithNote("35805358", "Carboplatin, Docetaxel, Fluorouracil") }, // 80.71000000000001%
            { "Oxaliplatin Capecitabine 21 day", new ValueWithNote("35805347", "Capecitabine, Oxaliplatin, RT") }, // 80.71000000000001%
            { "Lenalidomide maintenance (post autologous stem cell transplant)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 80.71000000000001%
            { "ATOMIC-MESO (POLARIS 2015-003) ADI-PEG/Placebo Cisplatin Pemetrexed (Trial)", new ValueWithNote("1524820", "Cisplatin, Pemetrexed, Sintilimab") }, // 80.66%
            { "Etoposide oral (myeloid)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 80.66%
            { "Gemtuzumab Daunorubicin Cytarabine induction", new ValueWithNote("35803442", "Cytarabine and Daunorubicin") }, // 80.66%
            { "Prednisolone reducing dose", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 80.66%
            { "Imatinib ALL", new ValueWithNote("35804083", "Imatinib monotherapy") }, // 80.66%
            { "Rituximab maintenance 1st remission only (2 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 80.66%
            { "Bortezomib weekly", new ValueWithNote("35804520", "Bortezomib monotherapy") }, // 80.62%
            { "Cyclophosphamide TBI Alemtuzumab (MUD transplant)", new ValueWithNote("35804007", "Cyclophosphamide, Etoposide, TBI") }, // 80.62%
            { "Vyxeos (Daunorubicin / Cytarabine) liposomal consolidation", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 80.62%
            { "Vinorelbine (60-80) oral", new ValueWithNote("35804241", "Vinorelbine monotherapy") }, // 80.62%
            { "213400 (ZEAL-1L) Pembrolizumab Niraparib / placebo (Trial)", new ValueWithNote("37556844", "Niraparib and Pembrolizumab") }, // 80.57%
            { "CABL001A2301 ABL001 arm (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 80.57%
            { "SCOPE 2 Carboplatin (CrCl) Paclitaxel cycles 2-4 Arms 1 and 3 (NCRN Trial)", new ValueWithNote("37556960", "Carboplatin, Paclitaxel, Trastuzumab, RT") }, // 80.47%
            { "UTX-TGR-205 Arm A Ublituximab TGR-1202 (Trial)", new ValueWithNote("905692", "Ibrutinib and Ublituximab") }, // 80.47%
            { "Pemetrexed maintenance", new ValueWithNote("35804168", "Pemetrexed monotherapy") }, // 80.47%
            { "CO43805 Mosunetuzumab cycle 1 (Trial)", new ValueWithNote("37557146", "Mosunetuzumab monotherapy") }, // 80.47%
            { "CABL001A2301 Bosutinib arm (Trial)", new ValueWithNote("35804082", "Bosutinib monotherapy") }, // 80.47%
            { "AVENuE Avelumab (Trial)", new ValueWithNote("35804159", "Avelumab monotherapy") }, // 80.42%
            { "ENRICH Bendamustine-R (Trial)", new ValueWithNote("35804017", "Bendamustine monotherapy") }, // 80.42%
            { "Cyclophosphamide IV infusion (support)", new ValueWithNote("35803690", "Cyclophosphamide monotherapy") }, // 80.42%
            { "Mitotane (Lysodren) (support)", new ValueWithNote("35803585", "Mitotane monotherapy") }, // 80.36999999999999%
            { "Trametinib (compassionate use)", new ValueWithNote("35806139", "Trametinib monotherapy") }, // 80.36999999999999%
            { "Nelarabine (aged 25 years and under) (support)", new ValueWithNote("35806983", "Nelarabine monotherapy") }, // 80.36999999999999%
            { "Epirubicin weekly", new ValueWithNote("35804228", "Epirubicin monotherapy") }, // 80.32000000000001%
            { "Enzalutamide (after at least 3 months of stable dose enzalutamide treatment)", new ValueWithNote("35804322", "Enzalutamide monotherapy") }, // 80.32000000000001%
            { "Carmustine Thiotepa (High dose)", new ValueWithNote("35803679", "Carmustine monotherapy") }, // 80.32000000000001%
            { "PETReA Rituximab SC maintenance (Trial)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 80.32000000000001%
            { "CNIS793B12201 Arm 2 NIS793 Gemcitabine Nab-Paclitaxel (Trial)", new ValueWithNote("35804567", "Gemcitabine and nab-Paclitaxel") }, // 80.27%
            { "Enzalutamide (newly diagnosed metastatic)", new ValueWithNote("37556872", "Docetaxel, Enzalutamide, Prednisolone") }, // 80.27%
            { "Cetuximab 2 weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 80.27%
            { "Cisplatin (support)", new ValueWithNote("911954", "Cisplatin and Bevacizumab") }, // 80.27%
            { "CNIS793B12201 Arm 1 Spartalizumab NIS793 Gemcitabine Nab-Paclitaxel (Trial)", new ValueWithNote("37558072", "Oxaliplatin, Paclitaxel, Tislelizumab") }, // 80.27%
            { "Doxycycline (amyloidosis)", new ValueWithNote("35806103", "Doxycycline monotherapy") }, // 80.22%
            { "SCOPE 2 Carboplatin (CrCl) Paclitaxel cycle 1 All patients (Trial)", new ValueWithNote("37561007", "Carboplatin, Paclitaxel, Trastuzumab-herw, RT") }, // 80.22%
            { "MoTD Fludarabine Melphalan experimental group 3 (Trial)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 80.17999999999999%
            { "UKALL 2011 Regimen C Augmented BFM consolidation (off study)", new ValueWithNote("35804055", "Augmented BFM consolidation") }, // 80.17999999999999%
            { "MAGNETISMM-5 (C1071005) Arm C Daratumumab Pomalidomide Dexamethasone (Trial)", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 80.17999999999999%
            { "Paclitaxel Carboplatin 21 day (CrCl)", new ValueWithNote("35805350", "Carboplatin and Paclitaxel (CP) and RT") }, // 80.13%
            { "MoTD Fludarabine Melphalan experimental group 2 (Trial)", new ValueWithNote("35803628", "Fludarabine and Melphalan") }, // 80.13%
            { "Dexamethasone pre/post docetaxel 20mg IV 8mg po 2 day", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 80.13%
            { "Dexamethasone pre/post docetaxel 20mg IV 8mg po 3 day", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 80.13%
            { "ICON 9 Olaparib Cediranib Arm 1 (Trial)", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 80.08%
            { "Sunitinib (GIST)", new ValueWithNote("35806904", "Gemcitabine and Sunitinib") }, // 80.08%
            { "ENRICH Ibrutinib Rituximab (28 day) (NCRN Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 80.08%
            { "FLAIR Ibrutinib Venetoclax (NCRN Trial)", new ValueWithNote("1525137", "Ibrutinib, Venetoclax, Obinutuzumab") }, // 80.08%
            { "Abiraterone Prednisolone (support)", new ValueWithNote("37556796", "Abiraterone, Radium-223, Prednisone") }, // 80.08%
            { "Oxaliplatin Modified de Gramont", new ValueWithNote("35805078", "Oxaliplatin monotherapy") }, // 80.08%
            { "Abiraterone Prednisolone (after at least 3 months of stable dose abiraterone)", new ValueWithNote("37556796", "Abiraterone, Radium-223, Prednisone") }, // 80.03%
            { "Dactinomycin (2 weekly) (germ cell)", new ValueWithNote("35805247", "Dactinomycin monotherapy") }, // 80.03%
            { "Irinotecan Oxaliplatin Modified DeGramont (FOLFOXIRI)", new ValueWithNote("35807526", "FOLFIRINOX/modified FOLFIRINOX +/- Chemoradiation") }, // 80.03%
            { "COSI Fludarabine Busulphan 2 (FB2) (Trial)", new ValueWithNote("35803625", "Busulfan, Fludarabine, Ibritumomab tiuxetan") }, // 79.97999999999999%
            { "Rituximab IV maintenance 1st remission only (2 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 79.97999999999999%
            { "daNIS-3 NIS793 Tislelizumab FOLFIRI Bevacizumab (Trial)", new ValueWithNote("37560777", "FOLFIRI, Bevacizumab-aybi, Cetuximab") }, // 79.97999999999999%
            { "Epirubicin (20) weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 79.93%
            { "SGN35-032 Brentuximab vedotin Cyclophosphamide Doxorubicin Prednisone (Trial)", new ValueWithNote("35804045", "Cyclophosphamide, Idarubicin, Vincristine, Prednisone") }, // 79.93%
            { "IMGN632-0802 Regimen C AZA+VEN+IMGN632 (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 79.93%
            { "Docetaxel (75) (NSCLC)", new ValueWithNote("905800", "Docetaxel and Lapatinib") }, // 79.93%
            { "Rituximab SC maintenance 2nd remission only (3 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 79.93%
            { "Doxorubicin infusion (support)", new ValueWithNote("35804134", "Doxorubicin monotherapy") }, // 79.93%
            { "Oxaliplatin Modified DeGramont", new ValueWithNote("35805078", "Oxaliplatin monotherapy") }, // 79.88%
            { "SCOPE 2 Capecitabine Cisplatin cycle 1 All patients (NCRN Trial)", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 79.88%
            { "Daratumumab (Named patient supply)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 79.88%
            { "Omeprazole premed", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 79.83%
            { "5F9003 Hu5F9-G4 Rituximab (Trial)", new ValueWithNote("37559628", "(90)YFC (rituximab-rixa)") }, // 79.83%
            { "Capecitabine (2000mg bd) 7/7", new ValueWithNote("37560493", "Capecitabine, Bevacizumab-adcd, Trastuzumab-qyyp") }, // 79.79%
            { "Midostaurin Daunorubicin Cytarabine (cytarabine bolus DA)", new ValueWithNote("35803442", "Cytarabine and Daunorubicin") }, // 79.79%
            { "Rituximab Gemcitabine Dexamethasone Cisplatin (R-GDP) (Daypatient)", new ValueWithNote("37559705", "R-GDP (rituximab-rixa)") }, // 79.79%
            { "Rituximab Gemcitabine Dexamethasone Cisplatin (R-GDP) (daypatient)", new ValueWithNote("37559705", "R-GDP (rituximab-rixa)") }, // 79.79%
            { "Cetuximab Cisplatin Fluorouracil (100 H&N) infusor", new ValueWithNote("35805359", "Cisplatin and Fluorouracil (CF) and Cetuximab") }, // 79.79%
            { "Gemcitabine Dexamethasone Cisplatin (GDP) (Daypatient)", new ValueWithNote("37556942", "Gemcitabine and Cisplatin (GC) and LD IL-2") }, // 79.74%
            { "Docetaxel Carboplatin Phesgo SC (neoadjuvant node negative / unknown) CrCl", new ValueWithNote("35806855", "Carboplatin, Docetaxel, Prednisone") }, // 79.74%
            { "FLAG Venetoclax", new ValueWithNote("37558862", "FLAG-DNX (filgrastim-sndz)") }, // 79.74%
            { "BEAM Alemtuzumab (Allograft)", new ValueWithNote("35803595", "Alemtuzumab monotherapy") }, // 79.74%
            { "CABL001E2201 Asciminib 40mg Imatinib arm (Trial)", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 79.74%
            { "SYD985.002 (TULIP) Lapatinib Capecitabine (Trial)", new ValueWithNote("35804311", "Capecitabine and Lapatinib") }, // 79.74%
            { "CA224048 Relatlimab Nivolumab BMS-986205 (Trial)", new ValueWithNote("1525060", "Nivolumab and Relatlimab") }, // 79.64%
        };

    public string[] ColumnNotes => new string[] {};
}