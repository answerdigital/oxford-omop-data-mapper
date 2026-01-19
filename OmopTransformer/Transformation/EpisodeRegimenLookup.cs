using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup Cancer treatment regimens concept.")]
internal class EpisodeRegimenLookup : ILookup
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
            { "Melphalan +/- Prednisolone", new ValueWithNote("35806351", "Melphalan and Methylprednisolone") }, // 93.89999999999999% NOTE: value uses Methylprednisolone not Prednisolone
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
            { "R-mini CHOP", new ValueWithNote("35805028", "R-CHOP") }, // 90.38000000000001% NOTE: value refers to full R-CHOP, key is mini dose
            { "Gemcitabine Capecitabine", new ValueWithNote("35804557", "Capecitabine and Gemcitabine") }, // 90.28%
            { "Cisplatin Etoposide", new ValueWithNote("35805329", "Cisplatin and Etoposide (EP)") }, // 90.28%
            { "EC Docetaxel Trastuzumab", new ValueWithNote("37560133", "EC-TH (Docetaxel) (trastuzumab-dttb)") }, // 90.19%
            { "CAV (SCLC)", new ValueWithNote("35806944", "CAV") }, // 90.14%
            { "Nivolumab Brentuximab vedotin (compassionate use)", new ValueWithNote("35805828", "Brentuximab vedotin and Nivolumab") }, // 90.09%
            { "Paclitaxel weekly (relapsed/metastatic)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 90.09%
            { "R-ESHAP (inpatient)", new ValueWithNote("35805061", "R-ESHAP") }, // 89.94%
            { "Temozolomide with concurrent RT (support)", new ValueWithNote("35803687", "Temozolomide and RT, then Temozolomide") }, // 89.89%
            { "Lenalidomide Dexamethasone", new ValueWithNote("35806053", "Lenalidomide and Dexamethasone (Rd)") }, // 89.84%
            { "Azacitidine", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 89.84%
            { "FOLFIRINOX (adjuvant)", new ValueWithNote("35804771", "FOLFIRINOX") }, // 89.79%
            { "Paclitaxel (weekly for 3 weeks then 1 week off)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 89.79%
            { "Vinorelbine (IV) Carboplatin (CrCl)", new ValueWithNote("35806405", "Carboplatin and Vinorelbine") }, // 89.75%
            { "Cyclophosphamide po weekly +/- Prednisolone", new ValueWithNote("35803428", "Cyclophosphamide and Prednisolone") }, // 89.64999999999999%
            { "Brentuximab vedotin (compassionate use)", new ValueWithNote("35805828", "Brentuximab vedotin and Nivolumab") }, // 89.64999999999999% NOTE: value adds Nivolumab while key suggests monotherapy
            { "R-ICE modified", new ValueWithNote("35805063", "R-ICE") }, // 89.60000000000001% NOTE: value is standard R-ICE, key says modified
            { "Paclitaxel weekly (sarcoma)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 89.60000000000001%
            { "Obinutuzumab Chlorambucil", new ValueWithNote("35804572", "Chlorambucil and Obinutuzumab (GClb)") }, // 89.55%
            { "Gemcitabine with RT (bladder)", new ValueWithNote("35804152", "Gemcitabine and RT") }, // 89.55%
            { "Avelumab", new ValueWithNote("35804159", "Avelumab monotherapy") }, // 89.5%
            { "Trastuzumab Cisplatin Capecitabine", new ValueWithNote("35805363", "Capecitabine and Cisplatin (CX) and Trastuzumab") }, // 89.45%
            { "Rituximab Gemcitabine Oxaliplatin (R-GemOx)", new ValueWithNote("37559706", "R-GemOx (rituximab-rixa)") }, // 89.4%
            { "Irinotecan Temozolomide Vincristine", new ValueWithNote("35805455", "Irinotecan and Temozolomide") }, // 89.31%
            { "Cyclophosphamide TBI (Allograft)", new ValueWithNote("35803613", "Cyclophosphamide and TBI") }, // 89.31%
            { "FEC (100) Docetaxel (100)", new ValueWithNote("1525108", "FEC-TH (Docetaxel)") }, // 89.21% NOTE: value implies trastuzumab (TH) absent from key
            { "Vinorelbine (oral) Carboplatin (CrCl)", new ValueWithNote("35806405", "Carboplatin and Vinorelbine") }, // 89.16%
            { "Vinorelbine (oral) Trastuzumab", new ValueWithNote("35804242", "Vinorelbine and Trastuzumab (VH)") }, // 89.05999999999999%
            { "Apixaban", new ValueWithNote("35807094", "Apixaban monotherapy") }, // 89.05999999999999%
            { "Talimogene laherparepvec", new ValueWithNote("35806121", "Talimogene laherparepvec monotherapy") }, // 89.05999999999999%
            { "Everolimus", new ValueWithNote("35805075", "Everolimus monotherapy") }, // 89.01%
            { "Melphalan PO +/- Prednisolone", new ValueWithNote("35806351", "Melphalan and Methylprednisolone") }, // 89.01% NOTE: value uses Methylprednisolone not Prednisolone
            { "Capecitabine with concurrent RT", new ValueWithNote("35806890", "Capecitabine and RT") }, // 88.96%
            { "Venetoclax Azacitidine (unsuitable for intensive treatment)", new ValueWithNote("35803466", "Azacitidine and Venetoclax") }, // 88.96%
            { "Encorafenib Binimetinib (compassionate use)", new ValueWithNote("35806137", "Binimetinib and Encorafenib") }, // 88.82%
            { "Cisplatin Fluorouracil (CF100)", new ValueWithNote("35803676", "Cisplatin and Fluorouracil (CF)") }, // 88.67%
            { "Paclitaxel albumin-bound Trastuzumab", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 88.62% NOTE: Trastuzumab missing from value text
            { "VDTPACE", new ValueWithNote("35806327", "DTPACE") }, // 88.62% NOTE: value drops bortezomib (V)
            { "Pomalidomide Dexamethasone (compassionate use)", new ValueWithNote("42542407", "Pomalidomide and Dexamethasone (Pd)") }, // 88.57000000000001%
            { "Vinorelbine (oral) Carboplatin (EDTA)", new ValueWithNote("35806398", "Carboplatin, Vinorelbine, RT") }, // 88.48% NOTE: value adds RT not present in key
            { "Paclitaxel weekly for 3 weeks then 1 week off", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 88.38000000000001%
            { "STELLAR Acalabrutinib monotherapy (Trial)", new ValueWithNote("35804606", "Acalabrutinib monotherapy") }, // 88.33%
            { "R-CHOP-14 bolus", new ValueWithNote("35805031", "R-CHOP-14") }, // 88.33%
            { "Temozolomide 75 + RT", new ValueWithNote("35803686", "Temozolomide and RT") }, // 88.28%
            { "Romidepsin (compassionate use)", new ValueWithNote("35804817", "Romidepsin monotherapy") }, // 88.23%
            { "Gemcitabine (1250) Cisplatin", new ValueWithNote("35806427", "Cisplatin and Gemcitabine/Erlotinib") }, // 88.23% NOTE: value adds Erlotinib
            { "Ipilimumab", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 88.23% NOTE: value adds Nivolumab
            { "Cyclophosphamide Vincristine Dacarbazine (CVD)", new ValueWithNote("35806646", "Cyclophosphamide, Dacarbazine, Vincristine") }, // 88.18%
            { "Cisplatin Capecitabine with concurrent RT", new ValueWithNote("1525040", "Capecitabine and Cisplatin (CX) and RT") }, // 88.13%
            { "Capecitabine Trastuzumab", new ValueWithNote("35804312", "Capecitabine and Trastuzumab (XH)") }, // 88.09%
            { "Busulfan Cyclophosphamide (Allograft)", new ValueWithNote("35806362", "Busulfan and Cyclophosphamide, then allo HSCT") }, // 88.03999999999999%
            { "R-CVP bolus", new ValueWithNote("35805630", "R-CVP") }, // 88.03999999999999%
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
            { "Dabrafenib Trametinib (metastatic)", new ValueWithNote("35804100", "Dabrafenib and Trametinib") }, // 87.6%
            { "Fludarabine Melphalan Alemtuzumab (60 late) RIC", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 87.6%
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
            { "Atezolizumab Bevacizumab Paclitaxel Carboplatin (CrCl)", new ValueWithNote("37561589", "Carboplatin and Paclitaxel (CP), Atezolizumab, Bevacizumab-aveg") }, // 87.35000000000001%
            { "Carboplatin Pemetrexed (CrCl)", new ValueWithNote("35806172", "Carboplatin and Pemetrexed") }, // 87.3%
            { "Carboplatin with concurrent RT (CrCl)", new ValueWithNote("35804530", "Carboplatin and RT") }, // 87.3%
            { "Ruxolitinib", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 87.3%
            { "Cyclophosphamide oral +/- Methotrexate", new ValueWithNote("35101986", "Cyclophosphamide and Methotrexate (CM)") }, // 87.26% NOTE: value fixes Methotrexate as included (key marks optional)
            { "Enzalutamide", new ValueWithNote("35804322", "Enzalutamide monotherapy") }, // 87.21%
            { "Clarithromycin prophylaxis", new ValueWithNote("35806104", "Clarithromycin monotherapy") }, // 87.16000000000001%
            { "Asciminib (compassionate use)", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 87.11%
            { "Paclitaxel weekly for 3 weeks then 1 week off (sarcoma)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 87.06%
            { "Bosutinib", new ValueWithNote("35804082", "Bosutinib monotherapy") }, // 87.01%
            { "Ceritinib", new ValueWithNote("35804391", "Ceritinib monotherapy") }, // 87.01%
            { "Gemcitabine (675) Docetaxel (70) (sarcoma)", new ValueWithNote("35803577", "Docetaxel and Gemcitabine") }, // 86.96000000000001%
            { "Pazopanib", new ValueWithNote("37557053", "Pazopanib/Everolimus") }, // 86.96000000000001% NOTE: value adds Everolimus
            { "Gilteritinib", new ValueWithNote("35803515", "Gilteritinib monotherapy") }, // 86.91%
            { "Rucaparib", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 86.87%
            { "Inotuzumab ozogamicin cycle 1", new ValueWithNote("35804064", "Inotuzumab ozogamicin monotherapy") }, // 86.87%
            { "ORACLE Azacitidine (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 86.77%
            { "Carboplatin Etoposide (EDTA)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 86.72%
            { "Zoledronic acid 6 weekly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.52000000000001%

            { "Lutetium-177 vipivotide tetraxetan (without support medication) (EAMS)", new ValueWithNote("1525150", "Lutetium Lu 177 vipivotide tetraxetan monotherapy") }, // 86.72%
            { "Mobocertinib", new ValueWithNote("1525157", "Mobocertinib monotherapy") }, // 86.67%
            { "Cisplatin (100) with concurrent RT", new ValueWithNote("35804144", "Cisplatin and RT") }, // 86.67%
            { "PRIZM+ Zanubrutinib monotherapy (Trial)", new ValueWithNote("42542412", "Zanubrutinib monotherapy") }, // 86.61999999999999%
            { "FOLFIRINOX (metastatic)", new ValueWithNote("35804771", "FOLFIRINOX") }, // 86.61999999999999%
            { "Vinorelbine (oral) Cisplatin", new ValueWithNote("35804260", "Cisplatin and Vinorelbine (CVb)") }, // 86.57000000000001%
            { "Azacitidine (support)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 86.57000000000001%
            { "Paclitaxel weekly premedication (support)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 86.57000000000001%
            { "Carboplatin Pembrolizumab Pemetrexed (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 86.57000000000001%
            { "Temozolomide with concurrent RT (patients 65 years and over)", new ValueWithNote("35803687", "Temozolomide and RT, then Temozolomide") }, // 86.52%
            { "CA059-001 CC-95251 Azacitidine (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 86.52%
            { "Lanreotide Depot", new ValueWithNote("35806580", "Lanreotide Depot/Autogel monotherapy") }, // 86.52%
            { "Cisplatin Etoposide with concurrent RT (NSCLC)", new ValueWithNote("37557397", "Cisplatin and Etoposide (EP) and RT") }, // 86.52%
            { "Cyclophosphamide oral +/- Prednisolone (Sarcoma)", new ValueWithNote("35803428", "Cyclophosphamide and Prednisolone") }, // 86.47%
            { "FEC (75/500)", new ValueWithNote("35804212", "FEC") }, // 86.47%
            { "Cisplatin (50) RT", new ValueWithNote("35804144", "Cisplatin and RT") }, // 86.47%
            { "Niraparib", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 86.42999999999999%
            { "Pemetrexed Carboplatin (CrCl)", new ValueWithNote("35806172", "Carboplatin and Pemetrexed") }, // 86.42999999999999%


            { "Sotorasib", new ValueWithNote("905771", "Sotorasib monotherapy") }, // 86.28%

            { "Vemurafenib", new ValueWithNote("35804101", "Vemurafenib monotherapy") }, // 86.28%
            { "ARCADIAN Vinorelbine Cisplatin with RT (Trial)", new ValueWithNote("35805351", "Cisplatin, Vinorelbine, RT") }, // 86.22999999999999%
            { "Fedratinib", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 86.18%
            { "MVAC accelerated", new ValueWithNote("35804146", "MVAC") }, // 86.18%
            { "Gemcitabine", new ValueWithNote("35804135", "Gemcitabine monotherapy") }, // 86.08%

            { "Cisplatin (50) with concurrent RT", new ValueWithNote("35804144", "Cisplatin and RT") }, // 86.08%

            { "Abiraterone", new ValueWithNote("35806848", "Abiraterone monotherapy") }, // 86.08%



            { "CHOP-14 bolus", new ValueWithNote("35803591", "CHOP-14") }, // 85.99%




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
            { "Olaparib", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 85.6%
            { "Liposomal doxorubicin Carboplatin (CrCl)", new ValueWithNote("35805245", "Carboplatin and Pegylated liposomal doxorubicin") }, // 85.55%
            { "ABVD (3 cycles)", new ValueWithNote("35805802", "ABVD") }, // 85.5%
            { "Osimertinib", new ValueWithNote("35804394", "Osimertinib monotherapy") }, // 85.5%
            { "Gemcitabine with concurrent RT (bladder)", new ValueWithNote("35804152", "Gemcitabine and RT") }, // 85.5%
            { "Asciminib", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 85.45%
            { "Crizotinib", new ValueWithNote("35806424", "Crizotinib monotherapy") }, // 85.39999999999999%
            { "Daratumumab", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 85.39999999999999%
            { "Alectinib", new ValueWithNote("35804390", "Alectinib monotherapy") }, // 85.39999999999999%
            { "Glofitamab monotherapy (including Obinutuzumab pre-treatment) (EAMS)", new ValueWithNote("37557451", "Glofitamab monotherapy") }, // 85.39999999999999%
            { "Nilotinib", new ValueWithNote("35804079", "Nilotinib monotherapy") }, // 85.35000000000001%
            { "Fludarabine Melphalan Alemtuzumab (30 late) RIC", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 85.35000000000001%
            { "EV-302 Arm A Enfortumab vedotin Pembrolizumab (Trial)", new ValueWithNote("37557435", "Enfortumab vedotin and Pembrolizumab") }, // 85.35000000000001%
            { "Olaparib TABLETS", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 85.25%
            { "Trastuzumab Cisplatin Capecitabine (GOJ)", new ValueWithNote("35805363", "Capecitabine and Cisplatin (CX) and Trastuzumab") }, // 85.25%
            { "Inotuzumab ozogamicin cycle 2 onwards achieved CR", new ValueWithNote("35804064", "Inotuzumab ozogamicin monotherapy") }, // 85.25%
            { "Trametinib", new ValueWithNote("35806139", "Trametinib monotherapy") }, // 83.74000000000001%
            { "AVENuE AVD", new ValueWithNote("35805804", "AVD") }, // 85.11%
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
            { "Trastuzumab deruxtecan (Enhertu)", new ValueWithNote("42542261", "Trastuzumab deruxtecan monotherapy") }, // 84.96000000000001%
            { "Abemaciclib (aromatase inhibitor)", new ValueWithNote("35804280", "Abemaciclib and Anastrozole") }, // 84.91%
            { "R-Lenalidomide", new ValueWithNote("35804591", "Lenalidomide and Rituximab (R2)") }, // 84.77%
            { "Cisplatin Pembrolizumab Pemetrexed daypt", new ValueWithNote("35806412", "Cisplatin, Pemetrexed, Pembrolizumab") }, // 84.77%
            { "Brigatinib", new ValueWithNote("35806423", "Brigatinib monotherapy") }, // 84.77%
            { "Trastuzumab emtansine (Kadcyla)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 84.72%
            { "MK-6482-013 Belzutifan (MK-6482) 120mg (Trial)", new ValueWithNote("905631", "Belzutifan monotherapy") }, // 84.67%
            { "Carboplatin Paclitaxel Pembrolizumab (CrCl)", new ValueWithNote("35806415", "Carboplatin and Paclitaxel (CP) and Pembrolizumab") }, // 84.67%
            { "Cisplatin RT (100 H&N) Daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 84.67%
            { "FOLFIRINOX modified (adjuvant)", new ValueWithNote("35807526", "FOLFIRINOX/modified FOLFIRINOX +/- Chemoradiation") }, // 84.61999999999999%
            { "Cisplatin (40) with concurrent RT (head and neck)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 84.57000000000001%
            { "Abemaciclib (aromatase inhibitor) (metastatic)", new ValueWithNote("35804280", "Abemaciclib and Anastrozole") }, // 84.52%
            { "Busulfan Fludarabine ATG RIC (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 84.52%
            { "Durvalumab Gemcitabine Cisplatin (cholangiocarcinoma) (compassionate use)", new ValueWithNote("1524839", "Cisplatin and Gemcitabine (GC) and Durvalumab") }, // 84.38%
            { "Zoledronic acid 3 weekly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 84.33%
            { "Pembrolizumab Pemetrexed Carboplatin (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 84.33%
            { "Cyclophosphamide Fludarabine TBI RIC (Haploidentical)", new ValueWithNote("35803627", "Fludarabine, Cyclophosphamide, TBI for dUCB or haploidentical transplant") }, // 84.28%
            { "Paclitaxel Carboplatin (EDTA)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 84.28%
            { "Azacitidine (SC)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 84.23%
            { "Paclitaxel Carboplatin (CrCl)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 84.23%
            { "Fludarabine Melphalan Alemtuzumab (60) RIC (MUD transplant)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 84.23%
            { "Trastuzumab emtansine (Kadcyla) (compassionate use)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 84.17999999999999%
            { "Ifosfamide high dose", new ValueWithNote("35804542", "Ifosfamide monotherapy") }, // 84.17999999999999%
            { "Ruxolitinib support", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 84.17999999999999%
            { "Paclitaxel Carboplatin (CrCl) 7 day with RT", new ValueWithNote("35805350", "Carboplatin and Paclitaxel (CP) and RT") }, // 84.17999999999999%
            { "Cisplatin Etoposide (neuroendocrine)", new ValueWithNote("35805329", "Cisplatin and Etoposide (EP)") }, // 84.17999999999999%
            { "Fedratinib (support)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 84.13000000000001%
            { "Pembrolizumab Carboplatin Paclitaxel (CrCl)", new ValueWithNote("35806415", "Carboplatin and Paclitaxel (CP) and Pembrolizumab") }, // 84.13000000000001%
            { "Cladribine (Litak) (SC) Rituximab (hairy cell leukaemia)", new ValueWithNote("35805757", "Cladribine and Rituximab") }, // 84.08%
            { "Pembrolizumab Pemetrexed Carboplatin without pemetrexed maintenance (CrCl)", new ValueWithNote("35806403", "Carboplatin, Pemetrexed, Pembrolizumab") }, // 84.03%
            { "CNIS793B12201 Arm 3 Gemcitabine Nab-Paclitaxel (Trial)", new ValueWithNote("35804567", "Gemcitabine and nab-Paclitaxel") }, // 84.03%
            { "Cisplatin Pemetrexed Daypt", new ValueWithNote("35806173", "Cisplatin and Pemetrexed") }, // 83.98%
            { "Selpercatinib", new ValueWithNote("912062", "Selpercatinib monotherapy") }, // 83.98%
            { "Dabrafenib", new ValueWithNote("35804434", "Dabrafenib monotherapy") }, // 83.98%
            { "Cemiplimab", new ValueWithNote("35804822", "Cemiplimab monotherapy") }, // 83.94%
            { "Denosumab", new ValueWithNote("35804178", "Denosumab monotherapy") }, // 83.94%
            { "Carboplatin Etoposide (EDTA) (sarcoma)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 83.94%
            { "Chlorambucil (days 1 to 7)", new ValueWithNote("35804622", "Chlorambucil monotherapy") }, // 83.89%
            { "Bosutinib (compassionate use)", new ValueWithNote("35804082", "Bosutinib monotherapy") }, // 83.89%
            { "Avapritinib (compassionate use)", new ValueWithNote("42542281", "Avapritinib monotherapy") }, // 83.84%
            { "Paclitaxel (80) (days 1, 8 and 15)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 83.69%
            { "STELLAR CHOP-R (Trial)", new ValueWithNote("35805028", "R-CHOP") }, // 83.69%
            { "Fludarabine Melphalan Alemtuzumab (90) RIC (MUD transplant)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 83.69%
            { "Cisplatin Etoposide (oral)", new ValueWithNote("35805329", "Cisplatin and Etoposide (EP)") }, // 83.69%
            { "DREAMM-3 Pomalidomide Dexamethasone (Trial)", new ValueWithNote("42542407", "Pomalidomide and Dexamethasone (Pd)") }, // 83.64%
            { "Fludarabine Melphalan Alemtuzumab (60 late) RIC (off study PRO-DLI)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 83.59%
            { "Zoledronic acid 6 weekly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 83.59%
            { "Polatuzumab Rituximab Cyclophosphamide Doxorubicin Prednisolone (PR-CHP)", new ValueWithNote("37559679", "Pola-R-CHP (rituximab-rixa)") }, // 83.54%
            { "TOPAZ-1 Durvalumab / placebo monotherapy (Trial)", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 83.54%
            { "Lenalidomide (MDS)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 83.54%
            { "Osimertinib (support)", new ValueWithNote("35804394", "Osimertinib monotherapy") }, // 83.54%
            { "Atezolizumab Bevacizumab (EAMS)", new ValueWithNote("35806408", "Atezolizumab and Bevacizumab") }, // 83.54%
            { "Zoledronic acid 4 weekly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 83.5%
            { "Vismodegib (compassionate use)", new ValueWithNote("35804821", "Vismodegib monotherapy") }, // 83.5%
            { "rEECur Topotecan Cyclophosphamide (off study)", new ValueWithNote("35805453", "Cyclophosphamide and Topotecan") }, // 83.5%
            { "Vismodegib", new ValueWithNote("35804821", "Vismodegib monotherapy") }, // 83.45%
            { "Romiplostim", new ValueWithNote("35805922", "Romiplostim monotherapy") }, // 83.39999999999999%
            { "Vinorelbine (oral)", new ValueWithNote("35804241", "Vinorelbine monotherapy") }, // 83.35000000000001%
            { "Cytarabine high dose", new ValueWithNote("35803435", "High-dose Cytarabine monotherapy (HiDAC)") }, // 83.35000000000001%
            { "PARTNER Carboplatin Paclitaxel (Trial)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 83.35000000000001%
            { "Cisplatin (40 weekly) RT (cervix)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 83.35000000000001%
            { "Pacritinib (compassionate use)", new ValueWithNote("1525214", "Pacritinib monotherapy") }, // 83.25%
            { "Cladribine (Litak) (SC)", new ValueWithNote("35803546", "Cladribine monotherapy") }, // 83.25%
            { "Carboplatin Fluorouracil (CrCl)", new ValueWithNote("35805773", "Carboplatin and Fluorouracil") }, // 83.2%
            { "Carboplatin Paclitaxel (NSCLC) (CrCl)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 83.25%
            { "Niraparib (relapsed)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 83.25%
            { "Temozolomide 75 + RT (patients 65 years and over)", new ValueWithNote("35803686", "Temozolomide and RT") }, // 83.15%
            { "Fluorouracil (96hr CIV) infusor with RT", new ValueWithNote("35804534", "Fluorouracil and RT") }, // 83.15%
            { "Carboplatin Etoposide (EDTA) (Oral etoposide days 2+3)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 83.11%
            { "Busulfan (oral) (single dose) (support)", new ValueWithNote("35804638", "Busulfan monotherapy") }, // 83.11%
            { "Vinorelbine oral", new ValueWithNote("35804241", "Vinorelbine monotherapy") }, // 83.06%
            { "Ruxolitinib (compassionate use)", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 83.06%
            { "VAC (off study)", new ValueWithNote("35806910", "VAC") }, // 83.00999999999999%
            { "Cediranib (compassionate use)", new ValueWithNote("905688", "Cediranib monotherapy") }, // 83.00999999999999%
            { "Capecitabine (1000mg/m2)", new ValueWithNote("35804227", "Capecitabine monotherapy") }, // 83.00999999999999%
            { "MoTD Fludarabine Busulfan experimental group 2 (Trial)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 82.96%
            { "Mitomycin Capecitabine 42 day", new ValueWithNote("35804560", "Capecitabine and Mitomycin") }, // 82.80999999999999%
            { "DA-EPOCH-R (etopsode phosphate)", new ValueWithNote("35804378", "DA-R-EPOCH") }, // 82.80999999999999%
            { "Pexidartinib (compassionate use)", new ValueWithNote("1524984", "Pexidartinib monotherapy") }, // 82.76%
            { "Trastuzumab emtansine (Kadcyla) (adjuvant)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 82.71%
            { "Liposomal doxorubicin Carboplatin (CrCl) (ovarian)", new ValueWithNote("35805245", "Carboplatin and Pegylated liposomal doxorubicin") }, // 82.71%
            { "Daratumumab (cycle 1 standard rate then rapid rate subsequent cycles)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 82.67%
            { "Zoledronic acid (lymphoma bone protection) (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.67%
            { "AVENuE ABVD (Trial)", new ValueWithNote("35805802", "ABVD") }, // 82.57%
            { "Methylprednisolone 1mg/kg", new ValueWithNote("35807042", "Methylprednisolone monotherapy") }, // 82.57%
            { "Cisplatin RT (40 H&N) weekly daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 82.47%
            { "Zoledronic acid 3 weekly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.47%
            { "Zoledronic acid 6 monthly", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 82.47%
            { "DA", new ValueWithNote("35807524", "DA 3+10") }, // 82.42%
            { "Plerixafor + GCSF priming", new ValueWithNote("35101641", "Plerixafor and G-CSF") }, // 82.42%
            { "Ipilimumab Nivolumab (mesothelioma) (compassionate use)", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 82.37%
            { "Busulfan Fludarabine ATG RIC (AML/MDS) (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 82.47%
            { "ABVD (ABVD 2 cycles AVD 4 cycles)", new ValueWithNote("35805802", "ABVD") }, // 82.32000000000001%
            { "Dalteparin therapeutic solid tumours", new ValueWithNote("35807097", "Dalteparin monotherapy") }, // 82.28%
            { "R-Lenalidomide (IV rituximab cycle 1 then SC)", new ValueWithNote("37558891", "Lenalidomide and Rituximab-abbs (R2)") }, // 82.23%
            { "Cisplatin (40 weekly) RT (cervix) daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 82.23%
            { "Pirtobrutinib (Compassionate Use)", new ValueWithNote("37556847", "Pirtobrutinib monotherapy") }, // 82.23%
            { "FLAIR Ibrutinib monotherapy (NCRN Trial)", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 82.17999999999999%
            { "Ipilimumab Nivolumab (renal cell)", new ValueWithNote("35806133", "Ipilimumab-Nivolumab") }, // 82.17999999999999%
            { "Talazoparib (Compassionate use)", new ValueWithNote("35804270", "Talazoparib monotherapy") }, // 82.13000000000001%
            { "Crizanlizumab (support)", new ValueWithNote("42542402", "Crizanlizumab monotherapy") }, // 82.13000000000001%
            { "Cisplatin (40) with concurrent RT (cervix)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 82.13000000000001%
            { "Dexamethasone daily", new ValueWithNote("35804388", "Dexamethasone monotherapy") }, // 82.08%
            { "Avelumab (EAMS)", new ValueWithNote("35804159", "Avelumab monotherapy") }, // 82.03%
            { "Trastuzumab emtansine (Kadcyla) (metastatic)", new ValueWithNote("35805230", "Trastuzumab emtansine monotherapy") }, // 82.03%
            { "UPSTREAM (EORTC1559) Niraparib (Trial)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 82.03%
            { "MoTD Fludarabine Busulfan MF experimental group 2 (Trial)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 81.98%
            { "Pertuzumab Trastuzumab IV (metastatic)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 81.93%
            { "Pertuzumab Trastuzumab IV (neoadjuvant)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 81.93%
            { "Olaparib tablets (Managed access programme)", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 81.93%
            { "Docetaxel (75) (prostate)", new ValueWithNote("35804162", "Docetaxel monotherapy") }, // 81.88%
            { "Bevacizumab 15mg/Kg", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 81.88%
            { "Mini-BEAM (5 day) modified", new ValueWithNote("35805837", "Mini-BEAM") }, // 81.88%
            { "Lenvatinib Pembrolizumab 42 day", new ValueWithNote("42542382", "Lenvatinib and Pembrolizumab") }, // 81.88%
            { "Venetoclax", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 81.78999999999999%
            { "ASTX727-02 Decitabine then ASTX727 (Trial)", new ValueWithNote("912034", "Decitabine and cedazuridine monotherapy") }, // 81.78999999999999%
            { "Cyclophosphamide (oral)", new ValueWithNote("35803690", "Cyclophosphamide monotherapy") }, // 81.78999999999999%
            { "Ifosfamide infusional (inpatient)", new ValueWithNote("35804542", "Ifosfamide monotherapy") }, // 81.84%
            { "STAMPEDE J HT + Abiraterone + Enzalutamide (NCRN Trial)", new ValueWithNote("911935", "Abiraterone and Enzalutamide") }, // 81.69%
            { "daNIS-3 NIS793 mFOLFOX Bevacizumab (Trial)", new ValueWithNote("37558784", "mFOLFOX6-B (bevacizumab-onbe)") }, // 81.69%
            { "MaxiCHOP Cytarabine HD Rituximab", new ValueWithNote("37559740", "maxi-R-CHOP/R-HiDAC (rituximab-rixa)") }, // 81.64%
            { "MoTD Fludarabine Busulfan experimental group 2 (off study)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 81.45%
            { "XL184-311 Cabozantinib / Placebo (Trial)", new ValueWithNote("35805797", "Cabozantinib monotherapy") }, // 81.45%
            { "Pertuzumab Trastuzumab IV (adjuvant)", new ValueWithNote("35804314", "Pertuzumab and Trastuzumab") }, // 81.45%
            { "AZA-MDS-003 (NCRN 525) Azacitidine tablets / placebo (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 81.39999999999999%
            { "Plerixafor + GCSF priming (protocol A)", new ValueWithNote("35101641", "Plerixafor and G-CSF") }, // 81.35%
            { "Cetuximab Irinotecan Modified DeGramont", new ValueWithNote("35804798", "Irinotecan and Cetuximab") }, // 81.35%
            { "AZA-MDS-003 (NCRN 525) Azacitidine tablets / placebo (NCRN trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 81.35%
            { "Busulfan (oral)", new ValueWithNote("35804638", "Busulfan monotherapy") }, // 81.64%
            { "Larotrectinib (weeks 1 to 12 only)", new ValueWithNote("35806364", "Larotrectinib monotherapy") }, // 81.58999999999999%
            { "Niraparib (first line maintenance)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 81.39999999999999%
            { "Irinotecan weekly", new ValueWithNote("35803692", "Irinotecan monotherapy") }, // 81.39999999999999%
            { "Zoledronic acid 6 monthly (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 81.3%
            { "PLATO Mitomycin Capecitabine 23 days (ACT3 or ACT4) (NCRN Trial)", new ValueWithNote("35803671", "Capecitabine, Mitomycin, RT") }, // 81.3%
            { "INTERIM Dabrafenib Trametinib intermittent (Trial)", new ValueWithNote("35804100", "Dabrafenib and Trametinib") }, // 81.3%
            { "Dexamethasone 40mg 1 day", new ValueWithNote("35804388", "Dexamethasone monotherapy") }, // 81.3%
            { "Cetuximab Irinotecan Modified de Gramont", new ValueWithNote("35804798", "Irinotecan and Cetuximab") }, // 81.25%
            { "Bexarotene induction", new ValueWithNote("35804812", "Bexarotene monotherapy") }, // 81.25%
            { "MoTD Fludarabine Busulfan MF control group 1 (Trial)", new ValueWithNote("35803612", "Busulfan and Fludarabine") }, // 81.05%
            { "Regorafenib (GIST)", new ValueWithNote("35804569", "Regorafenib monotherapy") }, // 81.05%
            { "Melphalan high dose (Autograft)", new ValueWithNote("35806058", "Melphalan, then auto HSCT") }, // 81.2%
            { "Etoposide PO (support)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 81.01%
            { "Rituximab single agent (standard)", new ValueWithNote("35803432", "Rituximab monotherapy") }, // 80.76%
            { "Cetuximab weekly", new ValueWithNote("35804795", "Cetuximab monotherapy") }, // 80.76%
            { "IMbrave251 (MO42541) Atezolizumab Sorafenib (Trial)", new ValueWithNote("37558188", "Sorafenib and Atezolizumab") }, // 81.01%
            { "Carboplatin AUC 5 CrCl (support)", new ValueWithNote("35804537", "Carboplatin monotherapy") }, // 80.96%
            { "ALL-RIC Fludarabine Melphalan Alemtuzumab (MUD) (Trial)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 80.91000000000001%
            { "Etoposide oral flexible dosing (support)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 80.91000000000001%
            { "Lenvatinib Pembrolizumab 42 day (endometrial)", new ValueWithNote("42542382", "Lenvatinib and Pembrolizumab") }, // 80.81%
            { "Lenalidomide maintenance (post autologous stem cell transplant)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 80.71000000000001%
            { "Etoposide oral (myeloid)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 80.66%
            { "ENRICH Ibrutinib Rituximab (28 day) (NCRN Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 80.08%
            { "Vinorelbine (60-80) oral", new ValueWithNote("35804241", "Vinorelbine monotherapy") }, // 80.62%
            { "213400 (ZEAL-1L) Pembrolizumab Niraparib / placebo (Trial)", new ValueWithNote("37556844", "Niraparib and Pembrolizumab") }, // 80.57%
            { "Prednisolone reducing dose", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 80.66%
            { "Imatinib ALL", new ValueWithNote("35804083", "Imatinib monotherapy") }, // 80.66%
            { "Rituximab maintenance 1st remission only (2 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 80.66%
            { "Bortezomib weekly", new ValueWithNote("35804520", "Bortezomib monotherapy") }, // 80.62%
            { "PETReA Rituximab SC maintenance (Trial)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 80.32000000000001%
            { "UKALL 2011 Regimen C Augmented BFM consolidation (off study)", new ValueWithNote("35804055", "Augmented BFM consolidation") }, // 80.17999999999999%
            { "MoTD Fludarabine Melphalan experimental group 2 (Trial)", new ValueWithNote("35803628", "Fludarabine and Melphalan") }, // 80.13%
            { "Daratumumab (Named patient supply)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 79.88%
            { "Rituximab IV maintenance 1st remission only (2 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 79.97999999999999%
            { "SYD985.002 (TULIP) Lapatinib Capecitabine (Trial)", new ValueWithNote("35804311", "Capecitabine and Lapatinib") }, // 79.74%
            { "Rituximab Gemcitabine Dexamethasone Cisplatin (R-GDP) (Daypatient)", new ValueWithNote("37559705", "R-GDP (rituximab-rixa)") }, // 79.79%
            { "Rituximab Gemcitabine Dexamethasone Cisplatin (R-GDP) (daypatient)", new ValueWithNote("37559705", "R-GDP (rituximab-rixa)") }, // 79.79%
            { "Cetuximab Cisplatin Fluorouracil (100 H&N) infusor", new ValueWithNote("35805359", "Cisplatin and Fluorouracil (CF) and Cetuximab") }, // 79.79%
            { "Dactinomycin (2 weekly) (germ cell)", new ValueWithNote("35805247", "Dactinomycin monotherapy") }, // 80.03%
            { "Irinotecan Oxaliplatin Modified DeGramont (FOLFOXIRI)", new ValueWithNote("35807526", "FOLFIRINOX/modified FOLFIRINOX +/- Chemoradiation") }, // 80.03%
            { "Rituximab SC maintenance 2nd remission only (3 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 79.93%
            { "Doxorubicin infusion (support)", new ValueWithNote("35804134", "Doxorubicin monotherapy") }, // 79.93%
            { "Cyclophosphamide IV infusion (support)", new ValueWithNote("35803690", "Cyclophosphamide monotherapy") }, // 80.42%
            { "Mitotane (Lysodren) (support)", new ValueWithNote("35803585", "Mitotane monotherapy") }, // 80.36999999999999%
            { "Trametinib (compassionate use)", new ValueWithNote("35806139", "Trametinib monotherapy") }, // 80.36999999999999%
            { "Nelarabine (aged 25 years and under) (support)", new ValueWithNote("35806983", "Nelarabine monotherapy") }, // 80.36999999999999%
            { "Epirubicin weekly", new ValueWithNote("35804228", "Epirubicin monotherapy") }, // 80.32000000000001%
            { "Enzalutamide (after at least 3 months of stable dose enzalutamide treatment)", new ValueWithNote("35804322", "Enzalutamide monotherapy") }, // 80.32000000000001%
            { "Pemetrexed maintenance", new ValueWithNote("35804168", "Pemetrexed monotherapy") }, // 80.47%
            { "CO43805 Mosunetuzumab cycle 1 (Trial)", new ValueWithNote("37557146", "Mosunetuzumab monotherapy") }, // 80.47%
            { "CABL001A2301 Bosutinib arm (Trial)", new ValueWithNote("35804082", "Bosutinib monotherapy") }, // 80.47%
            { "AVENuE Avelumab (Trial)", new ValueWithNote("35804159", "Avelumab monotherapy") }, // 80.42%
            { "Doxycycline (amyloidosis)", new ValueWithNote("35806103", "Doxycycline monotherapy") }, // 80.22%
            { "DICE Arm 1 Paclitaxel (Trial)", new ValueWithNote("35804166", "Paclitaxel monotherapy") }, // 79.59%
            { "Paclitaxel Cisplatin (ovarian) daypt", new ValueWithNote("35804527", "Cisplatin and Paclitaxel (TP)") }, // 79.35%
            { "Bexarotene maintenance", new ValueWithNote("35804812", "Bexarotene monotherapy") }, // 79.35%
            { "Mitomycin Fluorouracil + RT infusor daypt", new ValueWithNote("35803673", "Fluorouracil, Mitomycin, RT") }, // 79.3%
            { "Cytarabine HD 3g/m2", new ValueWithNote("35804417", "Methotrexate-Cytarabine") }, // 79.25% MISMATCH: value adds Methotrexate
            { "MoTD Fludarabine Melphalan control group 1 (Trial)", new ValueWithNote("35803628", "Fludarabine and Melphalan") }, // 79.59%
            { "ENRICH Ibrutinib Rituximab (21 day) (NCRN Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 79.54%
            { "Durvalumab 28 day", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 79.44%
            { "Fulvestrant intramuscular injection (support)", new ValueWithNote("35804284", "Fulvestrant monotherapy") }, // 79.35%
            { "Carboplatin AUC 1.5 CrCl (support)", new ValueWithNote("35804537", "Carboplatin monotherapy") }, // 79.25%
            { "Daratumumab SC (cycles 1 to 6) then IV (cycle 7 onwards) (compassionate use)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 79.14999999999999%
            { "Melphalan Prednisolone Thalidomide (MPT)", new ValueWithNote("35806286", "MPT") }, // 79.14999999999999%
            { "Paclitaxel 7 day Carboplatin (CrCl) (ovarian)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 79.10000000000001%
            { "Paclitaxel Carboplatin 21 day (EDTA)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 79.10000000000001%
            { "Radium-223 (Xofigo)", new ValueWithNote("35806862", "Radium-223 monotherapy") }, // 79.10000000000001%
            { "Bevacizumab 7.5mg/kg", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 79.05%
            { "CANC3947 TITAN post trial Apalutamide (off study compassionate use)", new ValueWithNote("35806850", "Apalutamide monotherapy") }, // 79.0%
            { "Radium 223 (Xofigo)", new ValueWithNote("35806862", "Radium-223 monotherapy") }, // 78.96%
            { "FEDORA (RG_21-109) Fedratinib pre-treatment (Trial)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 78.96%
            { "Durvalumab 14 day", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 78.91%
            { "Osimertinib (adjuvant) (ORBIS)", new ValueWithNote("35804394", "Osimertinib monotherapy") }, // 78.91%
            { "PATHOS Cisplatin RT (NCRN Trial)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 78.86%
            { "Blinatumomab 3 days then 4 days (starting on Monday, Tuesday or Friday) <45kg", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.86%
            { "Etoposide oral (sarcoma)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 78.86%
            { "MoTD Fludarabine Melphalan experimental group 2 (off study)", new ValueWithNote("35803628", "Fludarabine and Melphalan") }, // 78.81%
            { "ENRICH R-CHOP (NCRN Trial)", new ValueWithNote("35805028", "R-CHOP") }, // 78.81%
            { "Siltuximab (Castleman disease)", new ValueWithNote("35804521", "Siltuximab monotherapy") }, // 78.75999999999999%
            { "Bevacizumab (compassionate use)", new ValueWithNote("35804319", "Bevacizumab-containing therapy") }, // 78.75999999999999%
            { "ENRICH Ibrutinib Rituximab (28 day) (Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 78.75999999999999%
            { "Blinatumomab 4 days then 3 days (starting Monday, Thursday or Friday) ambulate", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.66%
            { "Phesgo (Pertuzumab with Trastuzumab) SC (adjuvant)", new ValueWithNote("37560284", "Pertuzumab and Trastuzumab-herw") }, // 78.61%
            { "Vincristine additional (support)", new ValueWithNote("35807043", "Vincristine monotherapy") }, // 78.61%
            { "Ibrutinib (Waldenstrom?s macroglobulinaemia)", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 78.61%
            { "Bevacizumab Paclitaxel Carboplatin 21 day (CrCl) (cervix)", new ValueWithNote("35806401", "Carboplatin and Paclitaxel (CP) and Bevacizumab") }, // 78.52%
            { "Obinutuzumab maintenance", new ValueWithNote("35804583", "Obinutuzumab monotherapy") }, // 78.61%
            { "Blinatumomab 3 days then 4 days (starting Monday, Tuesday or Friday) ambulate", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.42%
            { "Blinatumomab 4 days then 3 days (starting on Monday, Thursday or Friday)", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.42%
            { "IMMU-132-13 Paclitaxel (Trial)", new ValueWithNote("35804166", "Paclitaxel monotherapy") }, // 78.42%
            { "TRITON3 CO-338-063 Rucaparib (NCRN Trial)", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 78.36999999999999%
            { "Larotrectinib (week 13 onwards)", new ValueWithNote("35806364", "Larotrectinib monotherapy") }, // 78.36999999999999%
            { "Blinatumomab 3 days then 4 days (starting on Monday, Tuesday or Friday)", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.32000000000001%
            { "PRIME-RT Arm B (Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 78.32000000000001% // MISMATCH: key PRIME-RT Arm B; note points to Nelarabine arm.
            { "CLEE011O12301C (NATALEE) Ribociclib arm (Trial)", new ValueWithNote("35804283", "Anastrozole, Goserelin, Ribociclib") }, // 78.32000000000001%
            { "REMoDL-A R-CHOP cycle 1 (Trial)", new ValueWithNote("35805028", "R-CHOP") }, // 78.22%
            { "FLAIR Ibrutinib Rituximab (NCRN Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 78.22%
            { "MVAC accelerated daypt", new ValueWithNote("35804146", "MVAC") }, // 78.22%
            { "BP42675 Obinutuzumab pre-treatment (Trial)", new ValueWithNote("35804583", "Obinutuzumab monotherapy") }, // 78.17%
            { "FEDR-MF-002 (FREEDOM 2) Fedratinib (Trial)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 78.12%
            { "EZ", new ValueWithNote("37560722", "E-X") }, // 78.12%
            { "Abemaciclib (endocrine therapy) (adjuvant)", new ValueWithNote("35804281", "Abemaciclib and Letrozole") }, // 78.08%
            { "Methotrexate high dose Cytarabine high dose (primary CNS lymphoma)", new ValueWithNote("35804417", "Methotrexate-Cytarabine") }, // 77.98%
            { "rEECur Ifosfamide (off study)", new ValueWithNote("35804542", "Ifosfamide monotherapy") }, // 77.78%
            { "CHOP-21 bolus", new ValueWithNote("35805093", "CHOP-BCG") }, // 77.73%
            { "Rituximab single agent (weekly) (support)", new ValueWithNote("35803432", "Rituximab monotherapy") }, // 77.73%
            { "GCSF filgrastim priming 0.5MU/Kg/day", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 77.69%
            { "NEPTUNES Ipilimumab Nivolumab (cohort 2) (Trial)", new ValueWithNote("35806134", "Nivolumab-Ipilimumab") }, // 77.64%
            { "INITIUM (UV1-202) Ipilimumab Nivolumab (Trial)", new ValueWithNote("35804435", "Ipilimumab and Nivolumab") }, // 77.53999999999999%
            { "MAGNETISMM-5 (C1071005) Arm A Elranatamab (Trial)", new ValueWithNote("37557432", "Elranatamab monotherapy") }, // 77.49000000000001%
            { "Bevacizumab 7.5mg/kg 3 weekly (support)", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 77.49000000000001%
            { "Bevacizumab maintenance", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 77.49000000000001%
            { "GCSF filgrastim priming 1.0MU/Kg/day", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 77.49000000000001%
            { "Atezolizumab 28 day", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 77.49000000000001%
            { "Acalabrutinib (CLL) (compassionate use)", new ValueWithNote("35804606", "Acalabrutinib monotherapy") }, // 77.49000000000001%
            { "OASIS II Arm A Ibrutinib Rituximab (Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 77.49000000000001%
            { "54767414MMY3003 (NCRN 2993) Daratumumab monotherapy (NCRN Trial)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 77.44%
            { "Atezolizumab 21 day", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 77.29%
            { "Panitumumab Irinotecan Modified de Gramont", new ValueWithNote("35804800", "Panitumumab monotherapy") }, // 77.29%
            { "UKALL 60+ Arm C Phase 1 Induction (Off Study)", new ValueWithNote("37561927", "No induction therapy") }, // 77.25%
            { "Intrathecal Cytarabine", new ValueWithNote("35803502", "Cytarabine and Thioguanine") }, // 77.2%
            { "Carboplatin AUC 5 EDTA (support)", new ValueWithNote("37558432", "Carboplatin, Pemetrexed, Bevacizumab-awwb") }, // 77.2%
            { "PLATFORM Arm A4 Rucaparib maintenance (NCRN Trial)", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 77.2%
            { "Bevacizumab 7.5mg/kg (support)", new ValueWithNote("35804319", "Bevacizumab-containing therapy") }, // 77.2%
            { "RADAR Arm A ABVD (Trial)", new ValueWithNote("35805802", "ABVD") }, // 77.14999999999999%
            { "Ibrutinib Rituximab (SC) maintenance (Mantle cell lymphoma) 1st line", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 77.14999999999999%
            { "EPIK-B3 (CBYL719H12301) A/B2 Paclitaxel albumin-bound Alpelisib/placebo (Trial)", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 77.14999999999999%
            { "Trastuzumab SC", new ValueWithNote("37561200", "TCHP (Docetaxel, SC Trastuzumab)") }, // 77.10000000000001%
            { "MUK nine b VRD (SC) consolidation part 2 (Trial)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 77.10000000000001%
            { "Add Aspirin Randomised trial treatment (NCRN Trial)", new ValueWithNote("35806655", "Aspirin monotherapy") }, // 77.10000000000001%
            { "BREAKWATER (C4221015) Arm C mFOLFOX6 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 77.05%
            { "TRIZELL rAd-IFN-MM-301 Celecoxib (Trial)", new ValueWithNote("37557395", "Celecoxib, Erlotinib, Methotrexate, Nivolumab") }, // 76.95%
            { "RELATIVITY098 (CA224098) BMS-986213 or Nivolumab (Trial)", new ValueWithNote("37557193", "Cabozantinib, Ipilimumab, Nivolumab") }, // 76.9%
            { "Calcium folinate 350mg", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 76.86%
            { "Denosumab (metastases) 4 weekly (28 day cycle)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 76.81%
            { "REMoDL-A R-CHOP cycles 2-6 (Trial)", new ValueWithNote("35806080", "R-CHOP/R-DHAP") }, // 76.81%
            { "Enzalutamide (metastatic hormone relapsed) (support)", new ValueWithNote("911935", "Abiraterone and Enzalutamide") }, // 76.71%
            { "Venetoclax continuation (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 76.71%
            { "LOXO-BTK-20019 Arm A LOXO-305 (Pirtobrutinib) (Trial)", new ValueWithNote("37556847", "Pirtobrutinib monotherapy") }, // 76.71%
            { "CEeDD Cohort 3 Cetuximab Irinotecan Modified de Gramont (Trial)", new ValueWithNote("35804798", "Irinotecan and Cetuximab") }, // 76.66%
            { "Obinutuzumab Glofitamab (compassionate use)", new ValueWithNote("35804583", "Obinutuzumab monotherapy") }, // 76.61%
            { "Cisplatin Fluorouracil (100 H&N) infusor Daypt", new ValueWithNote("35803672", "Cisplatin and Fluorouracil (CF) and RT") }, // 76.61%
            { "Carboplatin AUC 6 (CrCl)", new ValueWithNote("37556795", "Carboplatin and Doxorubicin") }, // 76.61%
            { "ICON 9 Olaparib Arm 2 (Trial)", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 76.55999999999999%
            { "Cisplatin Fluorouracil (80 H&N) infusor Daypt", new ValueWithNote("35803672", "Cisplatin and Fluorouracil (CF) and RT") }, // 76.55999999999999%
            { "Daratumumab SC Bortezomib Dexamethasone (neuropathy) (cycles 1-8 only) (21 day)", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 76.51%
            { "Cisplatin (50) (cervix)", new ValueWithNote("35102030", "Carboplatin and Cisplatin") }, // 76.51%
            { "ALL Consolidation cycle 1 (25-60 years)", new ValueWithNote("1525160", "No consolidation") }, // 76.46%
            { "SYD985.002 (TULIP) SYD985 arm (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 76.42%
            { "GO40311 BTRC4017A Trastuzumab one step fractionation (Trial)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 76.37%
            { "Denosumab (metastases)", new ValueWithNote("35804178", "Denosumab monotherapy") }, // 76.37%
            { "ATRA (Tretinoin) (Emergency use)", new ValueWithNote("35803549", "Arsenic trioxide and ATRA") }, // 76.37%
            { "D5330C00004 Module 2 Ceralasertib Olaparib (Trial)", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 76.32%
            { "Prednisolone 1mg/kg 7 days", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 76.27000000000001%
            { "GCSF filgrastim (variable number of days up to 10)", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 76.27000000000001%
            { "Cyclophosphamide IV bolus for use with DTPACE or VTDPACE only (support)", new ValueWithNote("35804235", "Dose-dense Cyclophosphamide monotherapy") }, // 76.22%
            { "PK 2013 01 VDC/IE (Trial)", new ValueWithNote("35805450", "VDC/IE") }, // 76.17%
            { "EV-302 Arm B Gemcitabine Cisplatin (Trial)", new ValueWithNote("35806427", "Cisplatin and Gemcitabine/Erlotinib") }, // 75.88000000000001%
            { "Trastuzumab SC 21 day", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 75.88000000000001%
            { "CHARIOT Cisplatin Capecitabine stage A2 or B induction (Trial)", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 75.83%
            { "Nivolumab 28 day", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.78%
            { "RP3-301 Nivolumab cohorts 3 and 4 (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.59%
            { "CVP bolus (patients under 70 years)", new ValueWithNote("35804599", "CVP") }, // 75.53999999999999%
            { "CONTRAST BI-1607 Trastuzumab (Trial)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 75.49%
            { "Etoposide IV split bags support", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 75.49%
            { "Pembrolizumab 400mg (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 75.49%
            { "SCIB1-002 Nivolumab Ipilimumab SCIB1 (Trial)", new ValueWithNote("35806134", "Nivolumab-Ipilimumab") }, // 75.33999999999999%
            { "AML19 CPX-351 (NCRN Trial)", new ValueWithNote("35803473", "CPX-351 monotherapy") }, // 75.24%
            { "ALL-RIC Intrathecal Methotrexate (Trial)", new ValueWithNote("35804095", "Methotrexate monotherapy") }, // 75.2%
            { "Prednisolone 1mg/kg 14 days", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 75.14999999999999%
            { "BEP 5 day metastatic", new ValueWithNote("35803570", "BEP") }, // 75.1%
            { "Nivolumab 28 day (compassionate use)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.05%
            { "Nivolumab 14 day (compassionate use)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.05%
            { "GCSF filgrastim 7 days", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 75.0%
            { "BEP 3 day metastatic", new ValueWithNote("35803570", "BEP") }, // 74.76%
            { "GCSF filgrastim priming", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.76%
            { "ENRICH Ibrutinib maintenance (Trial)", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 74.76%
            { "Pembrolizumab 200mg then 400mg (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.76%
            { "Pembrolizumab 200mg then 400mg (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.71%
            { "GCSF filgrastim 3 days", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.71%
            { "Pembrolizumab 2mg/kg (metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.66000000000001%
            { "GO40311 Trastuzumab cycle 1 day -1 (support) (Trial)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 74.66000000000001%
            { "Trastuzumab (8/6) (adjuvant) 21 day (support)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 74.56%
            { "Atezolizumab 28 day (adjuvant)", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 74.56%
            { "INITIUM (UV1-202) Nivolumab maintenance (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 74.46000000000001%
            { "Prednisolone 1mg/kg 21 days", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 74.37%
            { "GCSF filgrastim 5 days", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.32%
            { "Venetoclax titration continuation (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 74.32%
            { "Imatinib 400-600 (GIST/sarcomas)", new ValueWithNote("35804083", "Imatinib monotherapy") }, // 74.07000000000001%
            { "Trastuzumab (8/6) (metastatic) 21 day", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 74.02%
            { "Pembrolizumab 400mg (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.02%
            { "Add Aspirin Run in (NCRN Trial)", new ValueWithNote("35806655", "Aspirin monotherapy") }, // 73.88%
            { "MAP (APMM)", new ValueWithNote("35806469", "MAP") }, // 73.83%
            { "Methotrexate high dose (high grade NHL CNS prophylaxis)", new ValueWithNote("35804095", "Methotrexate monotherapy") }, // 73.83%
            { "Cardamon maintenance (Carfilzomib) (NCRN Trial)", new ValueWithNote("35806280", "Carfilzomib monotherapy") }, // 73.68%
            { "CVP bolus (patients over 70 years)", new ValueWithNote("35804599", "CVP") }, // 73.68%
            { "Euro Ewing 2012 VDC/IE (off study)", new ValueWithNote("35805450", "VDC/IE") }, // 73.58%
            { "Pembrolizumab 21 day then 42 day (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 73.49%
            { "CACZ885T2301 Canakinumab/Placebo (Trial)", new ValueWithNote("35803590", "Placebo") }, // 73.39%
            { "MITHRIDATE (RG_16-148) Pegylated Interferon Alfa-2a (Trial)", new ValueWithNote("35805377", "Peginterferon alfa-2a monotherapy") }, // 73.44000000000001%
            { "54767414MMY3008 (CANC-4387) Daratumumab subequent therarapy (NCRN Trial)", new ValueWithNote("1524917", "Dara-Rd (SC daratumumab)") }, // 73.34%
            { "Nivolumab 14 day (relapsed/metastatic)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 73.34%
            { "Trastuzumab (8/6) (metastatic) 21 day (support)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 73.29%
            { "Bevacizumab 14 day (neurofibromatosis 2)", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 73.19%
            { "Cetuximab skin toxicity", new ValueWithNote("35804795", "Cetuximab monotherapy") }, // 73.1%
            { "ACE-WM-001 ACP-196 (commercial study)", new ValueWithNote("911939", "ACP") }, // 73.0%
            { "Nivolumab 14 day (adjuvant)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 72.71%
            { "Pembrolizumab 200mg (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.46000000000001%
            { "RP2-001-18 Nivolumab RP2 (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 74.27% 
            { "Pembrolizumab 42 day (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.95%
            { "Hydroxycarbamide support", new ValueWithNote("35805376", "Hydroxyurea monotherapy") }, // 69.34%
            { "OptiMATe Arm B MATRIx (Trial)", new ValueWithNote("35804413", "MATRix") }, // 69.28999999999999%
            { "OptiMATe Arm B R-MTX pre-phase (Trial)", new ValueWithNote("37559371", "MT-R (rituximab-pvvr)") }, // 69.08999999999999%
            { "NEPTUNES Nivolumab monotherapy (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 85.6%
            { "LUD2015-005 Cohort C-FLOT (NCRN Trial)", new ValueWithNote("35805341", "FLOT") }, // 72.22%
            { "Venetoclax extra doses for cycles delayed after titration completed (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 72.17%
            { "Pembrolizumab 42 day (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.11999999999999%
            { "Nivolumab 28 day (adjuvant)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 72.02%
            { "Nivolumab 14 day (EAMS)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 72.02%
            { "Nivolumab 28 day (metastatic)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 71.97%
            { "OptiMATe Arm A MATRIx (Trial)", new ValueWithNote("35804413", "MATRix") }, // 71.92%
            { "Pembrolizumab 21 day (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 71.67999999999999%
            { "Bevacizumab 21 day (neurofibromatosis 2)", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 71.63000000000001%
            { "Mouth and bowel support", new ValueWithNote("35803468", "Best supportive care") }, // 71.58%
            { "Ibrutinib (CLL) >3years progression free interval (no comorbidities) cycles 1-3", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 71.53%
            { "BEP 3 day adjuvant", new ValueWithNote("35807017", "Accelerated BEP") }, // 71.53%
            { "Brightline-1 Doxorubicin (Trial)", new ValueWithNote("35804134", "Doxorubicin monotherapy") }, // 71.44%
            { "ALL Consolidation cycle 3 days 1-28 (25-60 years)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 71.34%
            { "BEP 3 day adjuvant (BEP 111)", new ValueWithNote("35807017", "Accelerated BEP") }, // 70.56%
            { "DTPACE (cyclophosphamide bolus)", new ValueWithNote("35806327", "DTPACE") }, // 83.00999999999999%
            { "Busulfan Fludarabine ATG RIC (myelofibrosis) (Allograft)", new ValueWithNote("35803623", "Fludarabine, Busulfan, ATG") }, // 82.47%
            { "Niraparib (Expanded access programme)", new ValueWithNote("35806485", "Niraparib monotherapy") }, // 82.47%
            { "rEECur Topotecan Cyclophosphamide (TC) (NCRN Trial)", new ValueWithNote("35805453", "Cyclophosphamide and Topotecan") }, // 84.91%


            { "Docetaxel Carboplatin Trastuzumab (TCH)", new ValueWithNote("0", "No mapping") },
            { "Ixazomib Lenalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Pertuzumab Trastuzumab Docetaxel", new ValueWithNote("0", "No mapping") },
            { "Carfilzomib Lenalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Epirubicin Oxaliplatin Fluorouracil", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab Paclitaxel albumin-bound", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel weekly Trastuzumab", new ValueWithNote("0", "No mapping") },
            { "Mitomycin Capecitabine with concurrent RT", new ValueWithNote("0", "No mapping") },
            { "Carfilzomib Pomalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine Paclitaxel albumin bound", new ValueWithNote("0", "No mapping") },
            { "Bevacizumab (7.5mg/kg) Paclitaxel Carboplatin (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Trastuzumab (TCH) CrCl", new ValueWithNote("0", "No mapping") },
            { "Temozolomide", new ValueWithNote("0", "No mapping") },
            { "Oxaliplatin Raltitrexed", new ValueWithNote("0", "No mapping") },
            { "Afatinib", new ValueWithNote("0", "No mapping") },
            { "Apalutamide", new ValueWithNote("0", "No mapping") },
            { "Letrozole", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel albumin bound (support)", new ValueWithNote("0", "No mapping") },
            { "Atezolizumab Paclitaxel albumin-bound", new ValueWithNote("0", "No mapping") },
            { "Bevacizumab (15mg/kg) Paclitaxel Carboplatin (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Etoposide Ifosfamide (CarboPEI)", new ValueWithNote("0", "No mapping") },
            { "FOLFOXIRI", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Capecitabine + RT (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Vinorelbine PO (60) Carboplatin AUC5 (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Raltitrexed Oxaliplatin", new ValueWithNote("0", "No mapping") },
            { "Docetaxel", new ValueWithNote("0", "No mapping") },
            { "FLAG-IDA Venetoclax", new ValueWithNote("0", "No mapping") },
            { "Dacarbazine (melanoma)", new ValueWithNote("0", "No mapping") },
            { "Exemestane", new ValueWithNote("0", "No mapping") },
            { "Sunitinib", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Pertuzumab Trastuzumab (adjuvant)", new ValueWithNote("0", "No mapping") },
            { "EC Paclitaxel (dose dense)", new ValueWithNote("0", "No mapping") },
            { "Vinorelbine PO (60-80) Cisplatin Daypt", new ValueWithNote("0", "No mapping") },
            { "Palbociclib (aromatase inhibitor)", new ValueWithNote("0", "No mapping") },
            { "Liposomal doxorubicin", new ValueWithNote("0", "No mapping") },
            { "Ponatinib", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel (weekly for 3 weeks then 1 week off) Trastuzumab", new ValueWithNote("0", "No mapping") },
            { "Cabozantinib", new ValueWithNote("0", "No mapping") },
            { "Irinotecan", new ValueWithNote("0", "No mapping") },
            { "Dacarbazine (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "Nivolumab Oxaliplatin Capecitabine", new ValueWithNote("0", "No mapping") },
            { "EC", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab Oxaliplatin Capecitabine", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine Paclitaxel albumin bound (support)", new ValueWithNote("0", "No mapping") },
            { "Oxaliplatin Capecitabine (OX)", new ValueWithNote("0", "No mapping") },
            { "Olaparib (compassionate use)", new ValueWithNote("0", "No mapping") },
            { "PARTNER Olaparib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Eribulin", new ValueWithNote("0", "No mapping") },
            { "Daratumumab Pomalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Bortezomib Thalidomide Dexamethasone (VTD) (28 day cycle)", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide Lenalidomide Dexamethasone (weekly cyclophosphamide)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin (60) Etoposide (120) (SCLC) Daypt", new ValueWithNote("0", "No mapping") },
            { "Isatuximab Pomalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Zanubrutinib", new ValueWithNote("0", "No mapping") },
            { "Olaparib (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "Methotrexate Mercaptopurine Indometacin", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Vinorelbine oral with concurrent RT (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Ifosfamide (3g) Doxorubicin (30mg) (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "Bortezomib Thalidomide Dexamethasone (VTD) (21 day cycle)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel (80) Carboplatin (AUC 2) (CrCl) weekly", new ValueWithNote("0", "No mapping") },
            { "Acalabrutinib", new ValueWithNote("0", "No mapping") },
            { "Bevacizumab Pembrolizumab Carboplatin Paclitaxel (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Pertuzumab Trastuzumab Docetaxel (metastatic)", new ValueWithNote("0", "No mapping") },
            { "Ixazomib Lenalidomide Dexamethasone (named patient supply)", new ValueWithNote("0", "No mapping") },
            { "Doxorubicin Cisplatin Cyclophosphamide (CAP)", new ValueWithNote("0", "No mapping") },
            { "Epirubicin Oxaliplatin Capecitabine (EOX)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin (75) Etoposide (100) (SCLC) Daypt", new ValueWithNote("0", "No mapping") },
            { "Quizartinib (compassionate use)", new ValueWithNote("0", "No mapping") },
            { "Omeprazole", new ValueWithNote("0", "No mapping") },
            { "Erlotinib", new ValueWithNote("0", "No mapping") },
            { "IE/VC", new ValueWithNote("0", "No mapping") },
            { "AMM cycles 5-6 MAP (off study)", new ValueWithNote("0", "No mapping") },
            { "CCS1477-02 CCS1477-MB 4 days on 3 days off (Trial)", new ValueWithNote("0", "No mapping") },
            { "75276617ALE1001 JNJ75276617 tablets (Trial)", new ValueWithNote("0", "No mapping") },
            { "FLAMSA-BU >=60 years (off study)", new ValueWithNote("0", "No mapping") },
            { "Ciprofloxacin for prophylaxis", new ValueWithNote("0", "No mapping") },
            { "ACELARATE Acelarin infusion bag (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Lorazepam", new ValueWithNote("0", "No mapping") },
            { "PlasmaMATCH Cohort E (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Pamidronate 30 28 day (support)", new ValueWithNote("0", "No mapping") },
            { "RomiCar (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Oral cryotherapy", new ValueWithNote("0", "No mapping") },
            { "CLARITY (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "ST101-101 ST101 expansion (Trial)", new ValueWithNote("0", "No mapping") },
            { "Atropine sulphate", new ValueWithNote("0", "No mapping") },
            { "Metoclopramide 14 day", new ValueWithNote("0", "No mapping") },
            { "PIANO (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "RADAR Arm B A2VD (Trial)", new ValueWithNote("0", "No mapping") },
            { "Colestyramine", new ValueWithNote("0", "No mapping") },
            { "RP2-001-18 re-initiation of RP2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Micafungin", new ValueWithNote("0", "No mapping") },
            { "Fosaprepitant IV", new ValueWithNote("0", "No mapping") },
            { "AIDA", new ValueWithNote("0", "No mapping") },
            { "APMM 2 cycles (MAP) (off study)", new ValueWithNote("0", "No mapping") },
            { "Loperamide", new ValueWithNote("0", "No mapping") },
            { "RP2-001-18 re-initiation of RP2 (support) (Trial)", new ValueWithNote("0", "No mapping") },
            { "LOGIC2; Run in (early phase trial)", new ValueWithNote("0", "No mapping") },
            { "OVM-200-100 OVM-200 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Metoclopramide 28 day", new ValueWithNote("0", "No mapping") },
            { "LATITUDE (NCRN 433) Open label extension phase (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Hydroxycarbamide initiation", new ValueWithNote("0", "No mapping") },
            { "Magnesium support", new ValueWithNote("0", "No mapping") },
            { "MOTION Vimseltinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "ROMAZA cohorts -2, -1, 1 and 2 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Anaphylaxis treatment", new ValueWithNote("0", "No mapping") },
            { "NX-5948-301 NX-5948 (Trial)", new ValueWithNote("0", "No mapping") },
            { "RPL-001-16 re-initiation (support) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Metoclopramide 7 day", new ValueWithNote("0", "No mapping") },
            { "RXC004/0001 run in (Trial)", new ValueWithNote("0", "No mapping") },
            { "Loratadine", new ValueWithNote("0", "No mapping") },
            { "Cetirizine 28 days", new ValueWithNote("0", "No mapping") },
            { "Cetirizine 7 days", new ValueWithNote("0", "No mapping") },
            { "ATTAINMENT Module 1 MDX-124 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ondansetron 12 days prn", new ValueWithNote("0", "No mapping") },
            { "Movicol", new ValueWithNote("0", "No mapping") },
            { "KEYNOTE-867 (MK3475-867) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Metoclopramide 3 day", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondanestron weekly cisplatin", new ValueWithNote("0", "No mapping") },
            { "Pyridoxine 50mg", new ValueWithNote("0", "No mapping") },
            { "Famotidine", new ValueWithNote("0", "No mapping") },
            { "Euro Ewing 2012 IE/VC (off study)", new ValueWithNote("0", "No mapping") },
            { "Aciclovir prophylaxis 200mg tds", new ValueWithNote("0", "No mapping") },
            { "Entecavir", new ValueWithNote("0", "No mapping") },
            { "Hydroxycarbamide", new ValueWithNote("0", "No mapping") },
            { "Nystatin", new ValueWithNote("0", "No mapping") },
            { "Palonosetron IV", new ValueWithNote("0", "No mapping") },
            { "KEYNOTE-867 (MK3475-867-00) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Calcium carbonate Vitamin D", new ValueWithNote("0", "No mapping") },
            { "Ibandronic acid", new ValueWithNote("0", "No mapping") },
            { "Aciclovir-prophylaxis", new ValueWithNote("0", "No mapping") },
            { "Ondansetron metoclopramide 1 day", new ValueWithNote("0", "No mapping") },
            { "Ondansetron metoclopramide", new ValueWithNote("0", "No mapping") },
            { "Furosemide PO 1 day", new ValueWithNote("0", "No mapping") },
            { "Famotidine premed", new ValueWithNote("0", "No mapping") },
            { "Ondansetron metoclopramide days 1, 8 and 15", new ValueWithNote("0", "No mapping") },
            { "ALL Maintenance (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "RP3-301 RP3 (support) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Levofloxacin prophylaxis 28 days", new ValueWithNote("0", "No mapping") },
            { "CEDAR Enadenotucirev loading (Trial)", new ValueWithNote("0", "No mapping") },
            { "Dexrazoxane (cardiotoxicity)", new ValueWithNote("0", "No mapping") },
            { "ANIMATE (CA209-445) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Low emetic risk prochlorperazine", new ValueWithNote("0", "No mapping") },
            { "Sodium chloride 0.9% IV ambulatory infusor", new ValueWithNote("0", "No mapping") },
            { "Epaderm Emollient", new ValueWithNote("0", "No mapping") },
            { "Fluconazole prophylaxis", new ValueWithNote("0", "No mapping") },
            { "Ondansetron metoclopramide 5 days", new ValueWithNote("0", "No mapping") },
            { "PICC line pack", new ValueWithNote("0", "No mapping") },
            { "MUK nine b RD (SC) maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cyclizine", new ValueWithNote("0", "No mapping") },
            { "COMICE (Trial)", new ValueWithNote("0", "No mapping") },
            { "High emetic rsk ondansetron metoclopramide days 1, 8 and 15", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron metoclopramide 5 days", new ValueWithNote("0", "No mapping") },
            { "Lorazepam daily", new ValueWithNote("0", "No mapping") },
            { "Olanzapine", new ValueWithNote("0", "No mapping") },
            { "Rasburicase", new ValueWithNote("0", "No mapping") },
            { "Ondansetron day 1 oral premedication", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron metoclopramide 5 days", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron 1 day", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron liquids 1 day", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron 3.5 days", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron 5 days", new ValueWithNote("0", "No mapping") },
            { "Darbepoeitin weekly", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron 1.5 days", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron 5 days", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron 2 days", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron 1.5 days", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron 1 day", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron 1 day weekly", new ValueWithNote("0", "No mapping") },
            { "Paracetamol soluble", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron metoclopramide 1 day", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron metoclopramide days 1, 8 and 15", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron 3 days", new ValueWithNote("0", "No mapping") },
            { "Low emetic risk domperidone", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron metoclopramide 1 day", new ValueWithNote("0", "No mapping") },
            { "Colesevelam", new ValueWithNote("0", "No mapping") },
            { "Moderate emetic risk ondansetron liquids", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron liquids", new ValueWithNote("0", "No mapping") },
            { "High emetic risk ondansetron days 1, 8 and 15", new ValueWithNote("0", "No mapping") },
            { "AMADEUS (Trial)", new ValueWithNote("0", "No mapping") },
            { "Diprobase", new ValueWithNote("0", "No mapping") },
            { "Mesna IV", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab 21 day then 42 day (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "ACCEPT Phase 1 cohort 2 and phase 2 cycles 1-6 (Trial)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 302 NUFIRI Q1W (Trial)", new ValueWithNote("0", "No mapping") },
            { "Liposomal amphotericin B (Ambisome) prophylaxis", new ValueWithNote("0", "No mapping") },
            { "ONC001 Part A1 cohort 4 (4 weekly) (Trial)", new ValueWithNote("0", "No mapping") },
            { "DREAMM-9 Belantamab mafodontin VRd (every cycle) (Trial)", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen B1/C1 maintenance (males) (off study)", new ValueWithNote("0", "No mapping") },
            { "CC-92480-MM-001 21/28 OD schedule (Trial)", new ValueWithNote("0", "No mapping") },
            { "DREAMM-9 Belantamab mafodontin Rd maintenance (every cycle) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Difflam", new ValueWithNote("0", "No mapping") },
            { "RP2-001-18 RP2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Posaconazole prophylaxis", new ValueWithNote("0", "No mapping") },
            { "Sodium chloride 0.9% IV (Venetoclax hydration)", new ValueWithNote("0", "No mapping") },
            { "Sodium chloride 0.9% 500ml IV infusion", new ValueWithNote("0", "No mapping") },
            { "75276617ALE1001 JNJ75276617 capsules (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ferinject 1000mg IVI", new ValueWithNote("0", "No mapping") },
            { "Paracetamol oral", new ValueWithNote("0", "No mapping") },
            { "Hydroxycarbamide (alternate day dosing)", new ValueWithNote("0", "No mapping") },
            { "Stem cells", new ValueWithNote("0", "No mapping") },
            { "Methylene blue", new ValueWithNote("0", "No mapping") },
            { "TIMEPOINT (MNA-3521-012) MTL-CEBPA Pembrolizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "CANC3947 TITAN Open label (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "TALAPRO-2 (C3441021) part 2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Pamidronate 30 28 day", new ValueWithNote("0", "No mapping") },
            { "PEACOCC (Trial)", new ValueWithNote("0", "No mapping") },
            { "ARCADIAN Atovaquone (Trial)", new ValueWithNote("0", "No mapping") },
            { "Calcium levofolinate 175mg", new ValueWithNote("0", "No mapping") },
            { "EORTC-HGUS 62113-55115 (Trial)", new ValueWithNote("0", "No mapping") },
            { "IMP-MEL IMM60 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Sodium chloride IV infusion", new ValueWithNote("0", "No mapping") },
            { "WINGMEN Xentuzumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "OCTOVA Arm C (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "ALL Intensification / CNS prophylaxis (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "ALL Consolidation cycle 3 days 29-42 (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "1480-0001 (IV STING) BI 1703880 Ezabenlimab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab 21 day (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "STP938-101 STP938 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Codeine Phosphate po", new ValueWithNote("0", "No mapping") },
            { "IMG-7289-CTP-102 IMG-7289 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Potassium chloride 20mmol IV", new ValueWithNote("0", "No mapping") },
            { "Rituximab weekly (ITP)", new ValueWithNote("0", "No mapping") },
            { "Lamivudine", new ValueWithNote("0", "No mapping") },
            { "Levomepromazine", new ValueWithNote("0", "No mapping") },
            { "DREAMM-9 Belantamab mafodontin Rd maintenance (every 3rd cycle) (Trial)", new ValueWithNote("0", "No mapping") },
            { "RMS 2005 IVADo cycles 1-3 (off study)", new ValueWithNote("0", "No mapping") },
            { "Chlorphenamine 7 days", new ValueWithNote("0", "No mapping") },
            { "ACE-CL-001 ACP-196 Cohort 2b (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Darbepoeitin 3 weekly", new ValueWithNote("0", "No mapping") },
            { "MOTION Vismeltinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Azithromycin prophylaxis (250mg) 3 x week 28 day", new ValueWithNote("0", "No mapping") },
            { "Atropine sulphate (5 days)", new ValueWithNote("0", "No mapping") },
            { "Isoniazid", new ValueWithNote("0", "No mapping") },
            { "Ranitidine premed IV", new ValueWithNote("0", "No mapping") },
            { "Azithromycin prophylaxis (250mg) 3 x week 21 day", new ValueWithNote("0", "No mapping") },
            { "Pentamidine prophylaxis IV", new ValueWithNote("0", "No mapping") },
            { "EP 166/50 daypt", new ValueWithNote("0", "No mapping") },
            { "BEP 3 day metastatic (NSCGT) daypt", new ValueWithNote("0", "No mapping") },
            { "Magnesium sulphate 8mmol IV", new ValueWithNote("0", "No mapping") },
            { "75276617ALE1001 JNJ75276617 (Trial)", new ValueWithNote("0", "No mapping") },
            { "M16-191 Transform-1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "DREAMM-9 Belantamab mafodontin VRd (every 3rd cycle from cycle 4) (Trial)", new ValueWithNote("0", "No mapping") },
            { "CCS1477-02 CCS1477 3 days on 4 days off (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cimetidine premed", new ValueWithNote("0", "No mapping") },
            { "CC-92480-MM-001 20/28 schedule (Trial)", new ValueWithNote("0", "No mapping") },
            { "Metoclopramide 21 day", new ValueWithNote("0", "No mapping") },
            { "EORTC-HGUS 62113-55115 (open label) (Trial)", new ValueWithNote("0", "No mapping") },
            { "ACE-CL-001 ACP-196 Cohort 8 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 302 NUFOX Q1W (Trial)", new ValueWithNote("0", "No mapping") },
            { "RP3-301 RP3 (Trial)", new ValueWithNote("0", "No mapping") },
            { "RATinG Lenzilumab (stage 1) (support) (Trial)", new ValueWithNote("0", "No mapping") },
            { "CA290-841 (CONFIRM) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Magnesium sulphate 20mmol IV", new ValueWithNote("0", "No mapping") },
            { "Ipi-Glio Arm A (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ondansetron for oral Vinorelbine days 1, 8 and 15", new ValueWithNote("0", "No mapping") },
            { "CC-4047-MM-013 (Commercial trial)", new ValueWithNote("0", "No mapping") },
            { "LUD2015-005 Post surgery Cohorts C and D (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "BEP 5 day metastatic (NSCGT) daypt", new ValueWithNote("0", "No mapping") },
            { "RMS 2005 IVADo IVA cycles 4-9 (off study)", new ValueWithNote("0", "No mapping") },
            { "Anaphylaxis prophylaxis", new ValueWithNote("0", "No mapping") },
            { "STAMPEDE K SoC & Metformin (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "CEeDD SonoTran particles cohorts 1, 2B and 3B (Trial)", new ValueWithNote("0", "No mapping") },
            { "D9571C00001 AZD7789 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Allopurinol for prevention of tumour lysis syndrome", new ValueWithNote("0", "No mapping") },
            { "Aciclovir prophylaxis 200mg bd", new ValueWithNote("0", "No mapping") },
            { "NX-1607-101 NX-1607 (Trial)", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen B Standard BFM consolidation (off study)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm A Maintenance (off study)", new ValueWithNote("0", "No mapping") },
            { "MATTERHORN (D910GC00001) Durvalumab/placebo FLOT (Trial)", new ValueWithNote("0", "No mapping") },
            { "MATRIX NLMT Arm J (Ceralasertib Durvalumab) (Trial)", new ValueWithNote("0", "No mapping") },
            { "M16-109 (REFINE) Navitoclax monotherapy (Trial)", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (1250) adjuvant", new ValueWithNote("0", "No mapping") },
            { "Rituximab 100mg dose (support)", new ValueWithNote("0", "No mapping") },
            { "MonarchE Arm A Abemaciclib + SoC endocrine (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "KY1044-CT01 Atezolizumab KY1044 24mg infusion bag (Trial)", new ValueWithNote("0", "No mapping") },
            { "Dexrazoxane", new ValueWithNote("0", "No mapping") },
            { "STAR-221 Arm A Domvanalimab Zimberelimab FOLFOX (Trial)", new ValueWithNote("0", "No mapping") },
            { "Capecitabine Phesgo SC (metastatic)", new ValueWithNote("0", "No mapping") },
            { "CRUKD/22/002 HMBD-001 Arm 1 monotherapy (Trial)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC (c1-3) then IV (c4-8) Bortezomib Dexam (neuropathy 21d) (compas)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm D Consolidation 1 (off study)", new ValueWithNote("0", "No mapping") },
            { "VDTPACE (cyclophosphamide bolus)", new ValueWithNote("0", "No mapping") },
            { "AML19 Cytarabine high dose (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "GCSF filgrastim", new ValueWithNote("0", "No mapping") },
            { "NG-641-03 (NEBULA) NG-641 Nivolumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "RPL-001-16 Phase 1 expansion or Phase 2 Nivolumab & RP1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Bendamustine 90-R (NHL)", new ValueWithNote("0", "No mapping") },
            { "ALL Consolidation cycle 2 (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "5F9005 Magrolimab Azacitidine AML/MDS expansion (Trial)", new ValueWithNote("0", "No mapping") },
            { "STAMPEDE G HT + Abiraterone (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Co-trimoxazole 480mg 3xweekly", new ValueWithNote("0", "No mapping") },
            { "D933LC00001 (BEGONIA) Arm 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "PRIME-RT Arm A (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin 21 day (ovarian) daypt", new ValueWithNote("0", "No mapping") },
            { "CT7001-001 Module 1 Cycle 1 onwards (Trial)", new ValueWithNote("0", "No mapping") },
            { "Imatinib CML (support)", new ValueWithNote("0", "No mapping") },
            { "ADCT-402-201 (Trial)", new ValueWithNote("0", "No mapping") },
            { "ACE-536-MDS-002 (COMMANDS) Epoetin alfa (Trial)", new ValueWithNote("0", "No mapping") },
            { "ACE-536-MF-001 (Trial)", new ValueWithNote("0", "No mapping") },
            { "KRT-232-101 28 day cycle (Trial)", new ValueWithNote("0", "No mapping") },
            { "MEDI4736-NHL-001 Arm B (NHL) (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "D933LC00001 (BEGONIA) Arm 2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "GS-US-546-5920 Cohort 2 Mag+MEC (Trial)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant with dexamethasone (day 1 on ward)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm C Maintenance (Off Study)", new ValueWithNote("0", "No mapping") },
            { "PETReA Obintuzumab maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (CLL) (support)", new ValueWithNote("0", "No mapping") },
            { "ALL Consolidation cycle 4 (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "STAR-221 Arm B Nivolumab FOLFOX (Trial)", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab 200mg (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "CA017-078 Nivolumab BMS-986205/Placebo adjuvant (Trial)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant with dexamethasone (day 1 at home)", new ValueWithNote("0", "No mapping") },
            { "D933LC00001 (BEGONIA) Arm 6 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Methotrexate 50 (germ cell)", new ValueWithNote("0", "No mapping") },
            { "Lansoprazole", new ValueWithNote("0", "No mapping") },
            { "RADAR (Myeloma XV) RCyBorD induction (Trial)", new ValueWithNote("0", "No mapping") },
            { "CEDAR Capecitabine RT Enadenotucirev maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "PEMBROWM Pembrolizumab Rituximab (Trial)", new ValueWithNote("0", "No mapping") },
            { "ONC001 Part A or Part A1 cohorts 1 and 2 (2 weekly) (Trial)", new ValueWithNote("0", "No mapping") },
            { "RP3-301 RP3 Nivolumab cohorts 1 and 5 (Trial)", new ValueWithNote("0", "No mapping") },
            { "MUK nine b VRDd consolidation part 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen B3/C3 maintenance (males) (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "MITHRIDATE (RG_16-148) Ruxolitinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin hydration (cisplatin dose >=61mg/m2)", new ValueWithNote("0", "No mapping") },
            { "ONC001 Part A1 cohort 3 (3 weekly) (Trial)", new ValueWithNote("0", "No mapping") },
            { "CCS1477-02 CCS1477-MB 4 days on 3 days off bd dosing (without azoles) (Trial)", new ValueWithNote("0", "No mapping") },
            { "ACCEPT Phase 1 cohort 2 and phase 2 cycles 7-8 (Trial)", new ValueWithNote("0", "No mapping") },
            { "D8231C00001 AZD4573 cycle 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "CC-90009-AML-001 Gen 2 days 1-10 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (Mantle cell lymphoma) 2nd line", new ValueWithNote("0", "No mapping") },
            { "Atezolizumab 21 day (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "GCSF pegfilgrastim", new ValueWithNote("0", "No mapping") },
            { "RAMPART Arm C (Trial)", new ValueWithNote("0", "No mapping") },
            { "GS-US-546-5920 Cohort 1 Mag+Ven+Aza (Trial)", new ValueWithNote("0", "No mapping") },
            { "D933LC00001 (BEGONIA) Arm 5 (Trial)", new ValueWithNote("0", "No mapping") },
            { "RMS 2005 Vinorelbine Cyclophosphamide maintenance (Off  Study)", new ValueWithNote("0", "No mapping") },
            { "Fludarabine Melphalan RIC (Allograft)", new ValueWithNote("0", "No mapping") },
            { "Denosumab (metastases) 6 weekly", new ValueWithNote("0", "No mapping") },
            { "Rituximab IV 375mg/m2", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Phesgo SC (neoadjuvant node negative / unknown)", new ValueWithNote("0", "No mapping") },
            { "Bendamustine 90-R firstline (CLL)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin desensitisation (CrCl) (support)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant without dexamethasone (day 1 on ward)", new ValueWithNote("0", "No mapping") },
            { "Aspirin 75", new ValueWithNote("0", "No mapping") },
            { "AML19 FLAG-Ida course 2 standard risk (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Nivolumab Oxaliplatin Modified de Gramont (EAMS)", new ValueWithNote("0", "No mapping") },
            { "LOXO-BTK-20022 Arm B Venetoclax Rituximab cycle 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Majic Ruxolitinib PV (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "TRIZELL rAd-IFN-MM-301 rAd-IFN Celecoxib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Add Aspirin randomised trial treatment (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Doxorubicin (urgent use)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm A Consolidation (off study)", new ValueWithNote("0", "No mapping") },
            { "ENHANCE (5F9009) Magrolimab / placebo Azacitidine (Trial)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin desensitisation (CrCl)", new ValueWithNote("0", "No mapping") },
            { "LOXO-BTK-20022 Arm B Venetoclax Rituximab cycles 2-25 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Trastuzumab IV", new ValueWithNote("0", "No mapping") },
            { "Cetuximab Oxaliplatin Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "ACTICCA-1 Gemcitabine Cisplatin (Trial)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm D Phase 1 and 2 Induction (off study)", new ValueWithNote("0", "No mapping") },
            { "Melphalan high dose (Autograft) (renal impairment)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin AUC 5 (EDTA)", new ValueWithNote("0", "No mapping") },
            { "ISIS-702843-CS4 Cohort A (Trial)", new ValueWithNote("0", "No mapping") },
            { "INITIUM (UV1-202) UV1 Ipilimumab Nivolumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "FGCL-4592-082 Roxadustat / placebo (Trial)", new ValueWithNote("0", "No mapping") },
            { "CABL001J12301 Arm 2 Imatinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib Rituximab (IV cycle 1 then SC c2-6) (Mantle cell lymphoma) 1st line", new ValueWithNote("0", "No mapping") },
            { "PCYC-1128-CA Cohort 5 Ibrutinib (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "PROSPER Enzalutamide open label (commercial trial)", new ValueWithNote("0", "No mapping") },
            { "PRISM (ACE-LY-111) Arm 1 Acalabrutinib AZD9150 (Trial)", new ValueWithNote("0", "No mapping") },
            { "R3767-ONC-1613 REGN3767 and REGN2810 combination (Trial)", new ValueWithNote("0", "No mapping") },
            { "1426-0001 Arm B BI 138746 BI 754091 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Intrathecal Methotrexate", new ValueWithNote("0", "No mapping") },
            { "Belantamab mafodontin (GSK2857916) (compassionate use)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 302 Bevacizumab (support) (Trial)", new ValueWithNote("0", "No mapping") },
            { "RiVa Arm B (Trial)", new ValueWithNote("0", "No mapping") },
            { "Nivolumab 14 day", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 701 NUC-7738 Pembrolizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin hydration (cisplatin dose =<40mg/m2)", new ValueWithNote("0", "No mapping") },
            { "CA017-078 Gemcitabine Cisplatin Nivolumab BMS-986205/Placebo (Trial)", new ValueWithNote("0", "No mapping") },
            { "FLAIR Fludarabine Cyclophosphamide Rituximab (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Phesgo (Pertuzumab with Trastuzumab) SC (metastatic)", new ValueWithNote("0", "No mapping") },
            { "PRO-DLI (Fludarabine Melphalan Alemtuzumab) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin AUC 7 (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Denosumab (metastases) 4 weekly (84 day cycle)", new ValueWithNote("0", "No mapping") },
            { "BEACOPDac escalated", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen C Capizzi interim maintenance (off study)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel (100) (adjuvant) 21 day", new ValueWithNote("0", "No mapping") },
            { "Irinotecan Modified DeGramont (NET)", new ValueWithNote("0", "No mapping") },
            { "ATRA (Tretinoin) (emergency use continuation) support", new ValueWithNote("0", "No mapping") },
            { "D8231C00001 AZD4573 cycle 2 onwards (Trial)", new ValueWithNote("0", "No mapping") },
            { "CDK-002-101 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Constellation (0610-02) Arms 2 and 3 CPI-610 Ruxolitinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "CRUKD/11/001;Vandeta+Selumetinib(od)dose escalation_C2onwards (EarlyPhaseTrial)", new ValueWithNote("0", "No mapping") },
            { "Erythropoietin zeta weekly", new ValueWithNote("0", "No mapping") },
            { "Carboplatin 21 day (CrCl) breast", new ValueWithNote("0", "No mapping") },
            { "Imatinib (GIST)", new ValueWithNote("0", "No mapping") },
            { "Nivolumab Oxaliplatin Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "CO41942 Mosun+Len Mosunetuzumab Lenalidomide cycles 2-12 (Trial)", new ValueWithNote("0", "No mapping") },
            { "CA017-078 Gemcitabine Cisplatin (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cetuximab 2 weekly combination (support)", new ValueWithNote("0", "No mapping") },
            { "ENRICH Ibrutinib additional (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Irinotecan Capecitabine 21 day", new ValueWithNote("0", "No mapping") },
            { "UPSTREAM (EORTC1559) Durvalumab Monalizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre docetaxel 16mg IV 1 day", new ValueWithNote("0", "No mapping") },
            { "Denosumab (metastases) 4 weekly", new ValueWithNote("0", "No mapping") },
            { "LOXO-BTK-20019 Arm B Ibrutinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Constellation (0610-02) Arm 4 CPI-0610 monotherapy (Trial)", new ValueWithNote("0", "No mapping") },
            { "CA224048 Relatlimab Nivolumab Ipilimumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Phesgo (Pertuzumab with Trastuzumab) SC (adjuvant) (support)", new ValueWithNote("0", "No mapping") },
            { "REMoDL-A Acalabrutinib R-CHOP cycles 2-6 (Trial)", new ValueWithNote("0", "No mapping") },
            { "PROMise PLX2853 Ruxolitinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre docetaxel 20mg IV 1 day", new ValueWithNote("0", "No mapping") },
            { "FLA-IDA", new ValueWithNote("0", "No mapping") },
            { "LOXO-BTK-20022 Arm A Pirtobrutinib Venetoclax Rituximab (Trial)", new ValueWithNote("0", "No mapping") },
            { "CNIS793B12301 (dANIS-2) NIS793/placebo Gemcitabine Nab-paclitaxel (Trial)", new ValueWithNote("0", "No mapping") },
            { "5F9003 Hu5F9-G4 + R-GemOx cycle 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (lymphoma) (compassionate use)", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen C Delayed intensification (off study)", new ValueWithNote("0", "No mapping") },
            { "CABL001E2201 Imatinib arm (Trial)", new ValueWithNote("0", "No mapping") },
            { "daNIS-3 NIS793 FOLFIRI Bevacizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Phesgo SC (neoadjuvant node positive)", new ValueWithNote("0", "No mapping") },
            { "Imatinib ALL (support)", new ValueWithNote("0", "No mapping") },
            { "TRIZELL rAd-IFN-MM-301 Gemcitabine (Trial)", new ValueWithNote("0", "No mapping") },
            { "CC-4047-MM-007 (CANC4276) Bortezomib Dexamethasone Pomalidomide (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin 21 day (EDTA)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab Bortezomib Dexamethasone (cycle 9 onwards) (28 day) rapid rate", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre/post docetaxel 8mg po weekly prostate", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide priming prior to PBSC harvest", new ValueWithNote("0", "No mapping") },
            { "Irinotecan Oxaliplatin Modified de Gramont modified (neoadjuvant)", new ValueWithNote("0", "No mapping") },
            { "APHRODITE Capecitabine (Trial)", new ValueWithNote("0", "No mapping") },
            { "FEDORA (RG_21-109) Fedratinib Ropeginterferon alfa-2b (Trial)", new ValueWithNote("0", "No mapping") },
            { "Panitumumab Irinotecan Modified DeGramont", new ValueWithNote("0", "No mapping") },
            { "Irinotecan Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "Enzalutamide (metastatic hormone relapsed)", new ValueWithNote("0", "No mapping") },
            { "Methotrexate weekly (Large granular cell leukaemia)", new ValueWithNote("0", "No mapping") },
            { "Imatinib 400-600", new ValueWithNote("0", "No mapping") },
            { "STELLAR CHOP-R Acalabrutinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin VTDPACE (support)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab Bortezomib Dexamethasone (neuropathy) (cycles 1 to 8 only) (21 day)", new ValueWithNote("0", "No mapping") },
            { "CO41942 Mosun+Len Mosunetuzumab SC Lenalidomide cycle 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "CO41942 Mosun+Len Mosunetuzumab SC Lenalidomide cycles 2-12 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Denosumab (metastases) 12 weekly", new ValueWithNote("0", "No mapping") },
            { "Bortezomib (TTP)", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre/post docetaxel 20mg IV 8mg po 3 day (RBFT)", new ValueWithNote("0", "No mapping") },
            { "CT7001-001 Module 2 part A (Trial)", new ValueWithNote("0", "No mapping") },
            { "Mesna for cyclophosphamide 750", new ValueWithNote("0", "No mapping") },
            { "ALL Phase 1 Induction (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "Rituximab SC maintenance 2nd remission only (3 monthly) (Lymphoma)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm A Phase 1 and 2 induction (off study)", new ValueWithNote("0", "No mapping") },
            { "Trastuzumab SC (support)", new ValueWithNote("0", "No mapping") },
            { "EXCALIBER-RRMM (CC-220-MM-002) Arm A (Trial)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant without dexamethasone (day 1 at home)", new ValueWithNote("0", "No mapping") },
            { "InterAACT Carboplatin Paclitaxel (CrCl) (off study)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab Bortezomib Dexamethasone (neuropathy) (cycles 1 to 8 only) 21 rapid", new ValueWithNote("0", "No mapping") },
            { "Ondansetron temozolomide 5 day", new ValueWithNote("0", "No mapping") },
            { "KY1044-CT01 Atezolizumab KY1044 (Trial)", new ValueWithNote("0", "No mapping") },
            { "PETReA Rituximab SC Lenalidomide maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "Mitotane (Lysodren)", new ValueWithNote("0", "No mapping") },
            { "Irinotecan Oxaliplatin Modified de Gramont (metastatic)", new ValueWithNote("0", "No mapping") },
            { "ALL Phase 2 Induction (25-60 years)", new ValueWithNote("0", "No mapping") },
            { "ACTICCA-1 Capecitabine (Trial)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin AUC 10 (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin AUC 5 (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Rituximab SC maintenance 1st remission only (2 monthly) (Lymphoma)", new ValueWithNote("0", "No mapping") },
            { "CA224048 Relatlimab Nivolumab BMS-986205 (Trial)", new ValueWithNote("0", "No mapping") },
            { "AC (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (Waldenstrom’s macroglobulinaemia)", new ValueWithNote("0", "No mapping") },
            { "Midostaurin (mastocytosis)", new ValueWithNote("0", "No mapping") },
            { "COSI Mini Thiotepa Busulphan Fludarabine ATG (mini TBF) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (1250) metastatic", new ValueWithNote("0", "No mapping") },
            { "Rituximab SC maintenance 1st remission only (2 monthly)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (Mantle cell lymphoma)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin Imatinib", new ValueWithNote("0", "No mapping") },
            { "ENRICH Rituximab SC maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel (75) (metastatic) 21 day", new ValueWithNote("0", "No mapping") },
            { "SCOPE 2 Capecitabine Cisplatin cycles 2-4 Arms 2 and 4 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "1426-0001 Arm A BI 1387446 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Mitomycin Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "Idarubicin IV (support)", new ValueWithNote("0", "No mapping") },
            { "RAMPART Arm B (Trial)", new ValueWithNote("0", "No mapping") },
            { "CTD (weekly cyclophosphamide)", new ValueWithNote("0", "No mapping") },
            { "AGI-134.FIM.101 Monotherapy treatment (Trial)", new ValueWithNote("0", "No mapping") },
            { "Panitumumab Oxaliplatin Modified DeGramont", new ValueWithNote("0", "No mapping") },
            { "Omeprazole 5 day", new ValueWithNote("0", "No mapping") },
            { "Carboplatin 21 day (CrCl)", new ValueWithNote("0", "No mapping") },
            { "GRN163LMYF3001  Arm A Imetelstat (Trial)", new ValueWithNote("0", "No mapping") },
            { "ENRICH Ibrutinib Rituximab SC maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 302 Arm 2A NUC-3373 weekly Oxaliplatin (Trial)", new ValueWithNote("0", "No mapping") },
            { "COPELIA Arm 2 Cediranib Paclitaxel (Trial)", new ValueWithNote("0", "No mapping") },
            { "Fludarabine Cyclophosphamide Rituximab CLL (Flu-Cy-R) (Oral)", new ValueWithNote("0", "No mapping") },
            { "Panitumumab Oxaliplatin Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "VTDPACE (cyclophosphamide bolus)", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre/post docetaxel 8mg po 3 day", new ValueWithNote("0", "No mapping") },
            { "ENRICH Ibrutinib Rituximab SC maintenance (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Phesgo SC (metastatic)", new ValueWithNote("0", "No mapping") },
            { "FCiST Streptozocin Cisplatin Fluorouracil (Neuroendocrine) inpt", new ValueWithNote("0", "No mapping") },
            { "Cabozantinib (RCC) (MAP)", new ValueWithNote("0", "No mapping") },
            { "PARTNER AZD6738 Durvalumab (PARTNERING) (Trial)", new ValueWithNote("0", "No mapping") },
            { "ENRICH Rituximab SC maintenance (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Phesgo SC (neoadjuvant node positive) CrCl", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (1250) (biliary tract)", new ValueWithNote("0", "No mapping") },
            { "Etoposide IV (HLH)", new ValueWithNote("0", "No mapping") },
            { "PARTNER FEC100 (Trial)", new ValueWithNote("0", "No mapping") },
            { "RAINBOW Dexamethasone Cyclophosphamide Rituximab (Trial)", new ValueWithNote("0", "No mapping") },
            { "COPELIA Arm 3 Olaparib Cediranib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Imatinib (GIST/sarcomas)", new ValueWithNote("0", "No mapping") },
            { "AG946-C-002 Phase 2a (Trial)", new ValueWithNote("0", "No mapping") },
            { "Temozolomide 150/200 (astrocytoma)", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen B Induction standard dexamethasone (off study)", new ValueWithNote("0", "No mapping") },
            { "Obinutuzumab CVP", new ValueWithNote("0", "No mapping") },
            { "CO41942 Mosun+Len Mosunetuzumab Lenalidomide cycle 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "PCYC-1116-CA; Ibrutinib (commercial trial)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (CLL)", new ValueWithNote("0", "No mapping") },
            { "Ibrutinib (Waldenstrom�s macroglobulinaemia)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC Bortezomib Dexamethasone (cycles 1 to 8 only) (21 day)", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre/post docetaxel 4mg po 3 day", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide Fludarabine TBI FIC (MUD transplant/cord cells)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 302 Arm 2B NUC-3373 weekly Irinotecan (Trial)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC Bortezomib Dexamethasone (cycle 9 onwards) (28 day)", new ValueWithNote("0", "No mapping") },
            { "Constellation (0610-02) Arm 1 CPI-0610 monotherapy (Trial)", new ValueWithNote("0", "No mapping") },
            { "Trastuzumab Oxaliplatin Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "EC Capecitabine Daypt", new ValueWithNote("0", "No mapping") },
            { "M14-239 Telisotuzumab vedotin (Trial)", new ValueWithNote("0", "No mapping") },
            { "BI 1280.8 Arm A BI 836845 (1000mg) Enzalutamide (Trial)", new ValueWithNote("0", "No mapping") },
            { "Irinotecan Modified DeGramont", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen B Delayed intensification (off study)", new ValueWithNote("0", "No mapping") },
            { "CABL001A2001B Asciminib Imatinib arm (Trial)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab Bortezomib Dexamethasone (cycles 1 to 8 only) (21 day) rapid rate", new ValueWithNote("0", "No mapping") },
            { "Bortezomib weekly Cyclophosphamide Dexamethasone (CyBorDex) (Amyloidosis)", new ValueWithNote("0", "No mapping") },
            { "COSI Fludarabine Busulphan 4 (FB4) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Imatinib (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "CAR-T Fludarabine Cyclophosphamide Tisagenlecleucel (NHL)", new ValueWithNote("0", "No mapping") },
            { "POD1UM-303 (InterAACT 2) INCMGA00012 / placebo Paclitaxel Carboplatin (Trial)", new ValueWithNote("0", "No mapping") },
            { "PLATO Mitomycin Capecitabine 28 days (ACT4 or ACT5) (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (1000) breast", new ValueWithNote("0", "No mapping") },
            { "R-CHOP-21 bolus", new ValueWithNote("0", "No mapping") },
            { "PRIMUS 001 Paclitaxel albumin bound Gemcitabine (Trial)", new ValueWithNote("0", "No mapping") },
            { "Chlorambucil-R (continuous)", new ValueWithNote("0", "No mapping") },
            { "Chlorambucil-R (days 1 to 14)", new ValueWithNote("0", "No mapping") },
            { "Methotrexate (50)", new ValueWithNote("0", "No mapping") },
            { "Imatinib (CML)", new ValueWithNote("0", "No mapping") },
            { "CABL001E2201 Asciminib 60mg Imatinib arm (Trial)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab IV (adjuvant use only)", new ValueWithNote("0", "No mapping") },
            { "Oxaliplatin Capecitabine 21 day", new ValueWithNote("0", "No mapping") },
            { "ATOMIC-MESO (POLARIS 2015-003) ADI-PEG/Placebo Cisplatin Pemetrexed (Trial)", new ValueWithNote("0", "No mapping") },
            { "Gemtuzumab Daunorubicin Cytarabine induction", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide TBI Alemtuzumab (MUD transplant)", new ValueWithNote("0", "No mapping") },
            { "Vyxeos (Daunorubicin / Cytarabine) liposomal consolidation", new ValueWithNote("0", "No mapping") },
            { "CABL001A2301 ABL001 arm (Trial)", new ValueWithNote("0", "No mapping") },
            { "SCOPE 2 Carboplatin (CrCl) Paclitaxel cycles 2-4 Arms 1 and 3 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "UTX-TGR-205 Arm A Ublituximab TGR-1202 (Trial)", new ValueWithNote("0", "No mapping") },
            { "ENRICH Bendamustine-R (Trial)", new ValueWithNote("0", "No mapping") },
            { "Carmustine Thiotepa (High dose)", new ValueWithNote("0", "No mapping") },
            { "CNIS793B12201 Arm 2 NIS793 Gemcitabine Nab-Paclitaxel (Trial)", new ValueWithNote("0", "No mapping") },
            { "Enzalutamide (newly diagnosed metastatic)", new ValueWithNote("0", "No mapping") },
            { "Cetuximab 2 weekly", new ValueWithNote("0", "No mapping") },
            { "Cisplatin (support)", new ValueWithNote("0", "No mapping") },
            { "CNIS793B12201 Arm 1 Spartalizumab NIS793 Gemcitabine Nab-Paclitaxel (Trial)", new ValueWithNote("0", "No mapping") },
            { "SCOPE 2 Carboplatin (CrCl) Paclitaxel cycle 1 All patients (Trial)", new ValueWithNote("0", "No mapping") },
            { "MoTD Fludarabine Melphalan experimental group 3 (Trial)", new ValueWithNote("0", "No mapping") },
            { "MAGNETISMM-5 (C1071005) Arm C Daratumumab Pomalidomide Dexamethasone (Trial)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel Carboplatin 21 day (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre/post docetaxel 20mg IV 8mg po 2 day", new ValueWithNote("0", "No mapping") },
            { "Dexamethasone pre/post docetaxel 20mg IV 8mg po 3 day", new ValueWithNote("0", "No mapping") },
            { "ICON 9 Olaparib Cediranib Arm 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Sunitinib (GIST)", new ValueWithNote("0", "No mapping") },
            { "FLAIR Ibrutinib Venetoclax (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Abiraterone Prednisolone (support)", new ValueWithNote("0", "No mapping") },
            { "Oxaliplatin Modified de Gramont", new ValueWithNote("0", "No mapping") },
            { "Abiraterone Prednisolone (after at least 3 months of stable dose abiraterone)", new ValueWithNote("0", "No mapping") },
            { "COSI Fludarabine Busulphan 2 (FB2) (Trial)", new ValueWithNote("0", "No mapping") },
            { "daNIS-3 NIS793 Tislelizumab FOLFIRI Bevacizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Epirubicin (20) weekly", new ValueWithNote("0", "No mapping") },
            { "SGN35-032 Brentuximab vedotin Cyclophosphamide Doxorubicin Prednisone (Trial)", new ValueWithNote("0", "No mapping") },
            { "IMGN632-0802 Regimen C AZA+VEN+IMGN632 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel (75) (NSCLC)", new ValueWithNote("0", "No mapping") },
            { "Oxaliplatin Modified DeGramont", new ValueWithNote("0", "No mapping") },
            { "SCOPE 2 Capecitabine Cisplatin cycle 1 All patients (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Omeprazole premed", new ValueWithNote("0", "No mapping") },
            { "5F9003 Hu5F9-G4 Rituximab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (2000mg bd) 7/7", new ValueWithNote("0", "No mapping") },
            { "Midostaurin Daunorubicin Cytarabine (cytarabine bolus DA)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine Dexamethasone Cisplatin (GDP) (Daypatient)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Phesgo SC (neoadjuvant node negative / unknown) CrCl", new ValueWithNote("0", "No mapping") },
            { "FLAG Venetoclax", new ValueWithNote("0", "No mapping") },
            { "BEAM Alemtuzumab (Allograft)", new ValueWithNote("0", "No mapping") },
            { "CABL001E2201 Asciminib 40mg Imatinib arm (Trial)", new ValueWithNote("0", "No mapping") },
            { "CompARE Arm 5 Cisplatin Durvalumab (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (1000)", new ValueWithNote("0", "No mapping") },
            { "Olaparib capsules (400mg bd)", new ValueWithNote("0", "No mapping") },
            { "IMC-F106C-101 IMC-F106C Paclitaxel albumin bound (Trial)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine Dexamethasone Cisplatin (GDP)", new ValueWithNote("0", "No mapping") },
            { "ICE modified", new ValueWithNote("0", "No mapping") },
            { "CAR-T Fludarabine Cyclophosphamide Axicabtagene ciloleucel", new ValueWithNote("0", "No mapping") },
            { "EC Paclitaxel Carboplatin (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Carboplatin (CrCl) (breast)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (pancreas)", new ValueWithNote("0", "No mapping") },
            { "5F9005 Hu5F9-G4 Azacitidine evaluation (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cytarabine HD Rituximab", new ValueWithNote("0", "No mapping") },
            { "Mitotane", new ValueWithNote("0", "No mapping") },
            { "COSI Fludarabine Busulphan 2 (FB4) (off study)", new ValueWithNote("0", "No mapping") },
            { "Sunitinib (pNET)", new ValueWithNote("0", "No mapping") },
            { "OASIS II Arm B Ibrutinib Venetoclax Rituximab (Trial)", new ValueWithNote("0", "No mapping") },
            { "MoTD Fludarabine Busulfan MF experimental group 3 (Trial)", new ValueWithNote("0", "No mapping") },
            { "POMB/ACE", new ValueWithNote("0", "No mapping") },
            { "R-VP", new ValueWithNote("0", "No mapping") },
            { "Dasatinib (chronic phase CML)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Pertuzumab Trastuzumab IV (metastatic)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel albumin-bound Phesgo SC (metastatic)", new ValueWithNote("0", "No mapping") },
            { "Daunorubicin liposomal Cytarabine liposomal (Vyxeos) induction", new ValueWithNote("0", "No mapping") },
            { "IMC-F106C-101 IMC-F106C monotherapy (Trial)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Phesgo SC (adjuvant) CrCl", new ValueWithNote("0", "No mapping") },
            { "Capecitabine (1250)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel weekly Carboplatin weekly (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Bevacizumab Paclitaxel Carboplatin 21 day (CrCl) (ovarian/fallopian/peritoneal)", new ValueWithNote("0", "No mapping") },
            { "Isatuximab Pomalidomide Dexamethasone (EAMS)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab IV(neoadjuvant node neg/unknown)Cr", new ValueWithNote("0", "No mapping") },
            { "Vyxeos (Daunorubicin / Cytarabine) liposomal induction", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel Carboplatin EC (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Brentuximab vedotin Cyclophosphamide Doxorubicin Prednisolone (Bv-CHP)", new ValueWithNote("0", "No mapping") },
            { "Thiotepa Fludarabine Treosulfan (Cord transplant)", new ValueWithNote("0", "No mapping") },
            { "Chlorambucil-R (days 1 to 7)", new ValueWithNote("0", "No mapping") },
            { "Ipilimumab Nivolumab (mesothelioma) (EAMS)", new ValueWithNote("0", "No mapping") },
            { "Darolutamide Docetaxel Prednisolone (ORBIS)", new ValueWithNote("0", "No mapping") },
            { "P+R-ICE Arm B Pembrolizumab R-ICE (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cemiplimab (support)", new ValueWithNote("0", "No mapping") },
            { "ECF Daypt", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1200) Carboplatin (CrCl) (NSCLC/SCLC)", new ValueWithNote("0", "No mapping") },
            { "Bendamustine-R Polatuzumab (not BMT candidate)", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Phesgo SC (adjuvant)", new ValueWithNote("0", "No mapping") },
            { "ENRICH Bendamustine-R (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Temozolomide (brain) (support)", new ValueWithNote("0", "No mapping") },
            { "Daunorubicin liposomal Cytarabine liposomal (Vyxeos) consolidation", new ValueWithNote("0", "No mapping") },
            { "Doxorubicin Dexrazoxane", new ValueWithNote("0", "No mapping") },
            { "GO42661 Atezolizumab Bevacizumab/placebo Gemcitabine Cisplatin (Trial)", new ValueWithNote("0", "No mapping") },
            { "Doxorubicin (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "daNIS-3 NIS793 Tislelizumab mFOLFOX Bevacizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "ONC001 2 weekly IV monotherapy (Trial)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Etoposide (oral etoposide days 2 and 3) (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide Fludarabine Thiotepa TBI RIC (Cord transplant)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1200) Carboplatin (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Goserelin", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab Paclitaxel Carboplatin EC (neoadjuvant then adjuvant) (EDTA)", new ValueWithNote("0", "No mapping") },
            { "VTDPACE", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Etoposide (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Oxaliplatin Capecitabine (CapOx)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Cisplatin (70 split)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin (High grade glioma)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Cisplatin (25) daypt", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Pertuzumab Trastuzumab IV (neoadjuvant node positive)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin (50) Etoposide (50) (NSCLC) Daypt", new ValueWithNote("0", "No mapping") },
            { "COSI Thiotepa Busulphan Fludarabine ATG (TBF) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Bortezomib Cyclophosphamide daily Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Bortezomib daily Cyclophosphamide Dexamethasone (Amyloidosis)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab (neoadjuvant)", new ValueWithNote("0", "No mapping") },
            { "Temozolomide (astrocytoma)", new ValueWithNote("0", "No mapping") },
            { "Lutetium-177 oxodotreotide (without support medication)", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Etoposide (CrCl) (Oral etoposide days 2+3)", new ValueWithNote("0", "No mapping") },
            { "SCALOP-2 Gemcitabine Paclitaxel albumin bound (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Darolutamide (non-metastatic) (support)", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab Paclitaxel Carboplatin EC (neoadjuvant then adjuvant)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC Lenalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Anti-thymocyte globulin (ATG) equine (aplastic anaemia)", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Carboplatin (CrCl) (ovarian)", new ValueWithNote("0", "No mapping") },
            { "Abiraterone Prednisolone", new ValueWithNote("0", "No mapping") },
            { "Liposomal doxorubicin (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "Pembrolizumab Paclitaxel Carboplatin EC (neoadjuvant then adjuvant) (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel weekly Pertuzumab Trastuzumab IV (adjuvant use only)", new ValueWithNote("0", "No mapping") },
            { "Cabozantinib (RCC)", new ValueWithNote("0", "No mapping") },
            { "Pertuzumab (neoadjuvant)", new ValueWithNote("0", "No mapping") },
            { "Cabozantinib (compassionate use)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin Dexamethasone Gemcitabine PEG-Asparaginase (DDGP)", new ValueWithNote("0", "No mapping") },
            { "ASTX727-02 ASTX727 then Decitabine (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cabazitaxel", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Pertuzumab Trastuzumab IV (neoadjuvant node negative / unknown)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel Ifosfamide Cisplatin (TIP)", new ValueWithNote("0", "No mapping") },
            { "Gemtuzumab Daunorubicin Cytarabine consolidation", new ValueWithNote("0", "No mapping") },
            { "BGB-3111-LTE1 Zanubrutinib (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide Etoposide Procarbazine Prednisolone maintenance (PEP-C)", new ValueWithNote("0", "No mapping") },
            { "Carfilzomib Lenalidomide Dexamethasone (CarLenDex)", new ValueWithNote("0", "No mapping") },
            { "Palbociclib", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Fluorouracil (CrCl) (H&N) daypt", new ValueWithNote("0", "No mapping") },
            { "Neratinib", new ValueWithNote("0", "No mapping") },
            { "Bevacizumab (7.5mg/kg) Paclitaxel Carboplatin (CrCl) (ovarian)", new ValueWithNote("0", "No mapping") },
            { "Thiotepa Busulfan Fludarabine ATG (Allograft)", new ValueWithNote("0", "No mapping") },
            { "Topotecan (oral)", new ValueWithNote("0", "No mapping") },
            { "Fludarabine TBI post transplant Cyclophosphamide MUD", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide Dexamethasone Rituximab (DRC)", new ValueWithNote("0", "No mapping") },
            { "Sorafenib", new ValueWithNote("0", "No mapping") },
            { "Bortezomib weekly Cyclophosphamide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Pertuzumab Trastuzumab (neoadjuvant node positive)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel weekly Phesgo SC (adjuvant use only)", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC Bortezomib Thalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Bortezomib", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Carboplatin (CrCl)", new ValueWithNote("0", "No mapping") },
            { "TOPAZ-1 Gemcitabine Cisplatin Durvalumab / placebo (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ifosfamide Etoposide (5 day)", new ValueWithNote("0", "No mapping") },
            { "Bevacizumab (15mg/kg) Paclitaxel Carboplatin (CrCl) (ovarian)", new ValueWithNote("0", "No mapping") },
            { "Darolutamide Docetaxel Prednisolone", new ValueWithNote("0", "No mapping") },
            { "Carboplatin Paclitaxel Trastuzumab (GOJ) (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin (75) Etoposide (100) (Neuroendocrine) daypt", new ValueWithNote("0", "No mapping") },
            { "VIP Cisplatin Etoposide Ifosfamide", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Cisplatin (70) daypt", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab (neoadjuvant node positive) CrCl", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Cisplatin (70)", new ValueWithNote("0", "No mapping") },
            { "Cyclophosphamide Etoposide Procarbazine Prednisolone induction (PEP-C)", new ValueWithNote("0", "No mapping") },
            { "Paclitaxel weekly Phesgo SC (following completion of EC cycles)", new ValueWithNote("0", "No mapping") },
            { "Fludarabine Cyclophosphamide Alemtuzumab (Aplastic Anemia) (Allograft)", new ValueWithNote("0", "No mapping") },
            { "Trabectedin (sarcoma)", new ValueWithNote("0", "No mapping") },
            { "Midostaurin Daunorubicin Cytarabine", new ValueWithNote("0", "No mapping") },
            { "Olaparib TABLETS (300mg bd)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Fluorouracil Oxaliplatin (FLOT)", new ValueWithNote("0", "No mapping") },
            { "Temozolomide 150/200", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (1000) Cisplatin (25)", new ValueWithNote("0", "No mapping") },
            { "Ribociclib", new ValueWithNote("0", "No mapping") },
            { "Nivolumab Vinorelbine (oral) Carboplatin (neoadjuvant) (CrCl)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab IV (neoadjuvant node positive)CrCl", new ValueWithNote("0", "No mapping") },
            { "Daratumumab SC Pomalidomide Dexamethasone", new ValueWithNote("0", "No mapping") },
            { "Darolutamide (non-metastatic)", new ValueWithNote("0", "No mapping") },
            { "Docetaxel Carboplatin Pertuzumab Trastuzumab (neoadjuvant node neg/unknown)CrCl", new ValueWithNote("0", "No mapping") },
            { "Trabectedin", new ValueWithNote("0", "No mapping") },
            { "Gemcitabine (lymphoma)", new ValueWithNote("0", "No mapping") },
            { "Lenvatinib (Thyroid)", new ValueWithNote("0", "No mapping") },
            { "Olaparib (adjuvant)", new ValueWithNote("0", "No mapping") },
            { "Liposomal doxorubicin (support)", new ValueWithNote("0", "No mapping") },
            { "Streptozocin Capecitabine", new ValueWithNote("0", "No mapping") },
            { "EC Docetaxel Pertuzumab Trastuzumab (neoadjuvant node negative / unknown)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm B Intensification (off study)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant oral", new ValueWithNote("0", "No mapping") },
            { "MATRIX NLMT Arm C (Palbociclib) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Momelotinib (Compassionate Use)", new ValueWithNote("0", "No mapping") },
            { "Trastuzumab SC 21 day (support)", new ValueWithNote("0", "No mapping") },
            { "EP", new ValueWithNote("0", "No mapping") },
            { "LUD2015-005 Cohort D2 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "CT7001-001 Module 4 Cycle 1 onwards (Trial)", new ValueWithNote("0", "No mapping") },
            { "Atezolizumab 28 day (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "Constellation (0610-02) Arm 3 CPI-0610 125mg + Rux R(-1) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin hydration (cisplatin dose 41-60mg/m2)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 302 Cohort 1c NUC-3373 + LV (Trial)", new ValueWithNote("0", "No mapping") },
            { "ALKS 4230-006 ARTISTRY-6 cohort 2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "OCTOVA Arm B (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "UKALL 60+ Arm B and D Maintenance (off study)", new ValueWithNote("0", "No mapping") },
            { "PLATFORM Arm A3 MEDI4736 maintenance (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin weekly (ovarian) daypt", new ValueWithNote("0", "No mapping") },
            { "RXC004/0001 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant Dexamethasone (day 1 on ward)", new ValueWithNote("0", "No mapping") },
            { "CXD101-0901; CXD101 expansion (early phase trial)", new ValueWithNote("0", "No mapping") },
            { "Samuraciclib (compassionate use)", new ValueWithNote("0", "No mapping") },
            { "D933LC00001 (BEGONIA) Arm 7 (Trial)", new ValueWithNote("0", "No mapping") },
            { "MITHRIDATE (RG_16-148) Hydroxycarbamide (Trial)", new ValueWithNote("0", "No mapping") },
            { "EDP daypatient", new ValueWithNote("0", "No mapping") },
            { "ADCT-301-201 (Trial)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 701 weekly (Trial)", new ValueWithNote("0", "No mapping") },
            { "CompARE Arm 1 Cisplatin 40mg/m2 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "WO41554 (Trial)", new ValueWithNote("0", "No mapping") },
            { "PETRA (D9720C00001) Module 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Mifamurtide (support)", new ValueWithNote("0", "No mapping") },
            { "RP3-301 RP3 monotherapy cohorts 3 and 4 (Trial)", new ValueWithNote("0", "No mapping") },
            { "2102-HEM-101 FT-2102 twice daily (Trial)", new ValueWithNote("0", "No mapping") },
            { "ACE-536-MDS-001 (MEDALIST) (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "UKALL 14 Imatinib (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "RP3-301 RP3 Nivolumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Nivolumab 28 day (relapsed/metastatic)", new ValueWithNote("0", "No mapping") },
            { "UKALL 2011 Regimen B Standard interim maintenance (off study)", new ValueWithNote("0", "No mapping") },
            { "ADVANCE Group 2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "LOXO-BTK-18001 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Sodium choride 0.9% 1000ml IV infusion over 60 minutes", new ValueWithNote("0", "No mapping") },
            { "ONC001 Part B (Trial)", new ValueWithNote("0", "No mapping") },
            { "Cetuximab / Panitumumab skin toxicity", new ValueWithNote("0", "No mapping") },
            { "AMMO Arm A ASTX727 (Trial)", new ValueWithNote("0", "No mapping") },
            { "ALKS 4230-006 ARTISTRY-6 cohort 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "RS-TS-101-01 (Trial)", new ValueWithNote("0", "No mapping") },
            { "Dapsone", new ValueWithNote("0", "No mapping") },
            { "Paracetamol IV", new ValueWithNote("0", "No mapping") },
            { "CHARIOT M6620 Tuesday doses (Trial)", new ValueWithNote("0", "No mapping") },
            { "NUTIDE 301 part 1 (NUC-3373 weekly) (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "RADAR (Myeloma XV) RCyBorIsaD (Trial)", new ValueWithNote("0", "No mapping") },
            { "Rituximab IV 100mg (ITP)", new ValueWithNote("0", "No mapping") },
            { "Cardamon consolidation (CarCyDex) (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "IMG-7289-CTP-201 IMG-7289 (Trial)", new ValueWithNote("0", "No mapping") },
            { "IMP-MEL IMM60 Pembrolizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Venetoclax doses for delay in titration (add in on date of delay) (support)", new ValueWithNote("0", "No mapping") },
            { "DREAMM-9 Belantamab mafodontin Rd maintenance (Trial)", new ValueWithNote("0", "No mapping") },
            { "BGB-3111-302 BGB-3111 (NCRN Trial)", new ValueWithNote("0", "No mapping") },
            { "Mouth and Bowel Support Minus Metoclopramide", new ValueWithNote("0", "No mapping") },
            { "DREAMM-9 Belantamab mafodontin VRd (Trial)", new ValueWithNote("0", "No mapping") },
            { "CHARIOT M6620 Friday doses (Trial)", new ValueWithNote("0", "No mapping") },
            { "Ipi-Glio Arm B (Trial)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant already has antiemetic dexamethasone prescribed (day 1 on ward)", new ValueWithNote("0", "No mapping") },
            { "Cisplatin hydration daypatient", new ValueWithNote("0", "No mapping") },
            { "Hydroxycarbamide (3 months)", new ValueWithNote("0", "No mapping") },
            { "RXC004/0001 Module 2 (Trial)", new ValueWithNote("0", "No mapping") },
            { "ASTX660-01 (7 days on/7 days off) (Trial)", new ValueWithNote("0", "No mapping") },
            { "Lansoprazole 5 day", new ValueWithNote("0", "No mapping") },
            { "UCL/17/0629 (PROMPT) Pembrolizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "Aprepitant already has antiemetic dexamethasone prescribed (day 1 at home)", new ValueWithNote("0", "No mapping") },
            { "BP42675 RO7122290 Cibisatamab part 1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "GCSF lenograstim", new ValueWithNote("0", "No mapping") },
            { "MidAC", new ValueWithNote("0", "No mapping") },
            { "GS-US-352-4365 (Trial)", new ValueWithNote("0", "No mapping") },
            { "MIV-818-101/201 (Trial)", new ValueWithNote("0", "No mapping") },
            { "DS3201-A-U202 (Valentine) (Trial)", new ValueWithNote("0", "No mapping") },
            { "SCIB1-002 Pembrolizumab SCIB1 (Trial)", new ValueWithNote("0", "No mapping") },
            { "NG-350A-02 (FORTIFY) NG-350A Pembrolizumab (Trial)", new ValueWithNote("0", "No mapping") },
            { "LOXO-BTK-20019 Arm A LOXO-305 (Trial)", new ValueWithNote("0", "No mapping") },
            { "MOTION Vismeltinib / placebo (Trial)", new ValueWithNote("0", "No mapping") },
        };

    public string[] ColumnNotes => Array.Empty<string>();
}