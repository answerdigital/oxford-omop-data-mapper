using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup discharge destination concept for A&E.")]
internal class SACTTreatmentRegimenLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
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
            { "AC (sarcoma)", new ValueWithNote("911936", "AC and Pembrolizumab") }, // 79.59%
            { "Ibrutinib (Waldenstrom’s macroglobulinaemia)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 79.59%
            { "DICE Arm 1 Paclitaxel (Trial)", new ValueWithNote("35804166", "Paclitaxel monotherapy") }, // 79.59%
            { "MoTD Fludarabine Melphalan control group 1 (Trial)", new ValueWithNote("35803628", "Fludarabine and Melphalan") }, // 79.59%
            { "Midostaurin (mastocytosis)", new ValueWithNote("35803509", "7+3d and Midostaurin") }, // 79.59%
            { "COSI Mini Thiotepa Busulphan Fludarabine ATG (mini TBF) (Trial)", new ValueWithNote("37557094", "Busulfan, Fludarabine, Thiotepa") }, // 79.54%
            { "ENRICH Ibrutinib Rituximab (21 day) (NCRN Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 79.54%
            { "Capecitabine (1250) metastatic", new ValueWithNote("35804311", "Capecitabine and Lapatinib") }, // 79.49000000000001%
            { "Rituximab SC maintenance 1st remission only (2 monthly)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 79.49000000000001%
            { "Ibrutinib (Mantle cell lymphoma)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 79.49000000000001%
            { "Cisplatin Imatinib", new ValueWithNote("37557015", "Cisplatin, Lapatinib, RT") }, // 79.44%
            { "Durvalumab 28 day", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 79.44%
            { "ENRICH Rituximab SC maintenance (Trial)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 79.44%
            { "Docetaxel (75) (metastatic) 21 day", new ValueWithNote("35805352", "Docetaxel, Fluorouracil, RT") }, // 79.39%
            { "SCOPE 2 Capecitabine Cisplatin cycles 2-4 Arms 2 and 4 (NCRN Trial)", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 79.39%
            { "1426-0001 Arm A BI 1387446 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 79.35%
            { "Mitomycin Modified de Gramont", new ValueWithNote("35804136", "Mitomycin monotherapy") }, // 79.35%
            { "Idarubicin IV (support)", new ValueWithNote("35803443", "Cytarabine and Idarubicin") }, // 79.35%
            { "Paclitaxel Cisplatin (ovarian) daypt", new ValueWithNote("35804527", "Cisplatin and Paclitaxel (TP)") }, // 79.35%
            { "Bexarotene maintenance", new ValueWithNote("35804812", "Bexarotene monotherapy") }, // 79.35%
            { "RAMPART Arm B (Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 79.35%
            { "CTD (weekly cyclophosphamide)", new ValueWithNote("37556838", "Cyclophosphamide and RT") }, // 79.35%
            { "Fulvestrant intramuscular injection (support)", new ValueWithNote("35804284", "Fulvestrant monotherapy") }, // 79.35%
            { "AGI-134.FIM.101 Monotherapy treatment (Trial)", new ValueWithNote("35806946", "Teniposide monotherapy") }, // 79.3%
            { "Mitomycin Fluorouracil + RT infusor daypt", new ValueWithNote("35803673", "Fluorouracil, Mitomycin, RT") }, // 79.3%
            { "Cytarabine HD 3g/m2", new ValueWithNote("35804417", "Methotrexate-Cytarabine") }, // 79.25%
            { "Panitumumab Oxaliplatin Modified DeGramont", new ValueWithNote("35804794", "FOLFOX4 and Panitumumab") }, // 79.25%
            { "Omeprazole 5 day", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 79.25%
            { "Carboplatin 21 day (CrCl)", new ValueWithNote("35804530", "Carboplatin and RT") }, // 79.25%
            { "Carboplatin AUC 1.5 CrCl (support)", new ValueWithNote("35804537", "Carboplatin monotherapy") }, // 79.25%
            { "GRN163LMYF3001  Arm A Imetelstat (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 79.25%
            { "ENRICH Ibrutinib Rituximab SC maintenance (Trial)", new ValueWithNote("37561181", "RT-PEPC; Maintenance (rituximab-abbs)") }, // 79.2%
            { "NUTIDE 302 Arm 2A NUC-3373 weekly Oxaliplatin (Trial)", new ValueWithNote("35805078", "Oxaliplatin monotherapy") }, // 79.14999999999999%
            { "COPELIA Arm 2 Cediranib Paclitaxel (Trial)", new ValueWithNote("912240", "Carboplatin and Paclitaxel (CP) and Cediranib") }, // 79.14999999999999%
            { "Daratumumab SC (cycles 1 to 6) then IV (cycle 7 onwards) (compassionate use)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 79.14999999999999%
            { "Melphalan Prednisolone Thalidomide (MPT)", new ValueWithNote("35806286", "MPT") }, // 79.14999999999999%
            { "Daratumumab Bortezomib Dexamethasone (cycles 1 to 8 only) (21 day) rapid rate", new ValueWithNote("35806306", "Bortezomib and Dexamethasone (Vd) and Panobinostat") }, // 79.10000000000001%
            { "Paclitaxel 7 day Carboplatin (CrCl) (ovarian)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 79.10000000000001%
            { "Paclitaxel Carboplatin 21 day (EDTA)", new ValueWithNote("35803572", "Carboplatin and Paclitaxel (CP)") }, // 79.10000000000001%
            { "Radium-223 (Xofigo)", new ValueWithNote("35806862", "Radium-223 monotherapy") }, // 79.10000000000001%
            { "Fludarabine Cyclophosphamide Rituximab CLL (Flu-Cy-R) (Oral)", new ValueWithNote("37561028", "Cyclophosphamide, Etoposide, Fludarabine") }, // 79.10000000000001%
            { "Panitumumab Oxaliplatin Modified de Gramont", new ValueWithNote("1525140", "mFOLFOX6 and Panitumumab") }, // 79.05%
            { "VTDPACE (cyclophosphamide bolus)", new ValueWithNote("37560709", "CVPP (Cyclophosphamide)") }, // 79.05%
            { "Dexamethasone pre/post docetaxel 8mg po 3 day", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 79.05%
            { "Bevacizumab 7.5mg/kg", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 79.05%
            { "ENRICH Ibrutinib Rituximab SC maintenance (NCRN Trial)", new ValueWithNote("37561181", "RT-PEPC; Maintenance (rituximab-abbs)") }, // 79.05%
            { "Docetaxel Phesgo SC (metastatic)", new ValueWithNote("37557335", "AC-THP (Docetaxel, Phesgo)") }, // 79.0%
            { "FCiST Streptozocin Cisplatin Fluorouracil (Neuroendocrine) inpt", new ValueWithNote("35806380", "Fluorouracil and Streptozocin") }, // 79.0%
            { "CANC3947 TITAN post trial Apalutamide (off study compassionate use)", new ValueWithNote("35806850", "Apalutamide monotherapy") }, // 79.0%
            { "Cabozantinib (RCC) (MAP)", new ValueWithNote("37557193", "Cabozantinib, Ipilimumab, Nivolumab") }, // 78.96%
            { "Radium 223 (Xofigo)", new ValueWithNote("35806862", "Radium-223 monotherapy") }, // 78.96%
            { "FEDORA (RG_21-109) Fedratinib pre-treatment (Trial)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 78.96%
            { "Durvalumab 14 day", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 78.91%
            { "PARTNER AZD6738 Durvalumab (PARTNERING) (Trial)", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 78.91%
            { "ENRICH Rituximab SC maintenance (NCRN Trial)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 78.91%
            { "Osimertinib (adjuvant) (ORBIS)", new ValueWithNote("35804394", "Osimertinib monotherapy") }, // 78.91%
            { "Docetaxel Carboplatin Phesgo SC (neoadjuvant node positive) CrCl", new ValueWithNote("37560973", "Carboplatin and Docetaxel (DCb) and Bevacizumab-adcd") }, // 78.91%
            { "Capecitabine (1250) (biliary tract)", new ValueWithNote("35804557", "Capecitabine and Gemcitabine") }, // 78.86%
            { "Etoposide IV (HLH)", new ValueWithNote("1525121", "Cytarabine and Etoposide") }, // 78.86%
            { "PARTNER FEC100 (Trial)", new ValueWithNote("37558620", "FEC and Bevacizumab-equi") }, // 78.86%
            { "PATHOS Cisplatin RT (NCRN Trial)", new ValueWithNote("35804144", "Cisplatin and RT") }, // 78.86%
            { "RAINBOW Dexamethasone Cyclophosphamide Rituximab (Trial)", new ValueWithNote("37559877", "Lenalidomide, Dexamethasone, Rituximab-rixi") }, // 78.86%
            { "Blinatumomab 3 days then 4 days (starting on Monday, Tuesday or Friday) <45kg", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.86%
            { "Etoposide oral (sarcoma)", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 78.86%
            { "COPELIA Arm 3 Olaparib Cediranib (Trial)", new ValueWithNote("37558367", "Olaparib and Bevacizumab-adcd") }, // 78.81%
            { "MoTD Fludarabine Melphalan experimental group 2 (off study)", new ValueWithNote("35803628", "Fludarabine and Melphalan") }, // 78.81%
            { "ENRICH R-CHOP (NCRN Trial)", new ValueWithNote("35805028", "R-CHOP") }, // 78.81%
            { "Imatinib (GIST/sarcomas)", new ValueWithNote("35804075", "HAM and Imatinib") }, // 78.81%
            { "Siltuximab (Castleman disease)", new ValueWithNote("35804521", "Siltuximab monotherapy") }, // 78.75999999999999%
            { "Bevacizumab (compassionate use)", new ValueWithNote("35804319", "Bevacizumab-containing therapy") }, // 78.75999999999999%
            { "AG946-C-002 Phase 2a (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 78.75999999999999%
            { "Temozolomide 150/200 (astrocytoma)", new ValueWithNote("905662", "Cisplatin and Temozolomide") }, // 78.75999999999999%
            { "UKALL 2011 Regimen B Induction standard dexamethasone (off study)", new ValueWithNote("35804388", "Dexamethasone monotherapy") }, // 78.75999999999999%
            { "ENRICH Ibrutinib Rituximab (28 day) (Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 78.75999999999999%
            { "Obinutuzumab CVP", new ValueWithNote("35102025", "CVP (Prednisolone)") }, // 78.71000000000001%
            { "CO41942 Mosun+Len Mosunetuzumab Lenalidomide cycle 1 (Trial)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 78.71000000000001%
            { "PCYC-1116-CA; Ibrutinib (commercial trial)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 78.71000000000001%
            { "Ibrutinib (CLL)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 78.71000000000001%
            { "Ibrutinib (Waldenstrom�s macroglobulinaemia)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 78.66%
            { "Blinatumomab 4 days then 3 days (starting Monday, Thursday or Friday) ambulate", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.66%
            { "Daratumumab SC Bortezomib Dexamethasone (cycles 1 to 8 only) (21 day)", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 78.66%
            { "Dexamethasone pre/post docetaxel 4mg po 3 day", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 78.66%
            { "Cyclophosphamide Fludarabine TBI FIC (MUD transplant/cord cells)", new ValueWithNote("912080", "Fludarabine and TBI for haploidentical transplant") }, // 78.66%
            { "NUTIDE 302 Arm 2B NUC-3373 weekly Irinotecan (Trial)", new ValueWithNote("35803692", "Irinotecan monotherapy") }, // 78.66%
            { "Daratumumab SC Bortezomib Dexamethasone (cycle 9 onwards) (28 day)", new ValueWithNote("35806306", "Bortezomib and Dexamethasone (Vd) and Panobinostat") }, // 78.61%
            { "Constellation (0610-02) Arm 1 CPI-0610 monotherapy (Trial)", new ValueWithNote("35806946", "Teniposide monotherapy") }, // 78.61%
            { "Trastuzumab Oxaliplatin Modified de Gramont", new ValueWithNote("35807025", "Oxaliplatin and Bevacizumab") }, // 78.61%
            { "Phesgo (Pertuzumab with Trastuzumab) SC (adjuvant)", new ValueWithNote("37560284", "Pertuzumab and Trastuzumab-herw") }, // 78.61%
            { "EC Capecitabine Daypt", new ValueWithNote("1525097", "EC-TH (Docetaxel)") }, // 78.61%
            { "Obinutuzumab maintenance", new ValueWithNote("35804583", "Obinutuzumab monotherapy") }, // 78.61%
            { "M14-239 Telisotuzumab vedotin (Trial)", new ValueWithNote("1525171", "Tisotumab vedotin monotherapy") }, // 78.61%
            { "Vincristine additional (support)", new ValueWithNote("35807043", "Vincristine monotherapy") }, // 78.61%
            { "Ibrutinib (Waldenstrom?s macroglobulinaemia)", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 78.61%
            { "BI 1280.8 Arm A BI 836845 (1000mg) Enzalutamide (Trial)", new ValueWithNote("1524841", "COG AAML0531 arm B (Gemtuzumab)") }, // 78.52%
            { "Irinotecan Modified DeGramont", new ValueWithNote("35803692", "Irinotecan monotherapy") }, // 78.52%
            { "Bevacizumab Paclitaxel Carboplatin 21 day (CrCl) (cervix)", new ValueWithNote("35806401", "Carboplatin and Paclitaxel (CP) and Bevacizumab") }, // 78.52%
            { "UKALL 2011 Regimen B Delayed intensification (off study)", new ValueWithNote("905639", "AALL0932 delayed intensification") }, // 78.47%
            { "CABL001A2001B Asciminib Imatinib arm (Trial)", new ValueWithNote("1524898", "Asciminib monotherapy") }, // 78.47%
            { "Imatinib (GIST)", new ValueWithNote("35804075", "HAM and Imatinib") }, // 78.47%
            { "Nivolumab Oxaliplatin Modified de Gramont", new ValueWithNote("35807025", "Oxaliplatin and Bevacizumab") }, // 78.42%
            { "CO41942 Mosun+Len Mosunetuzumab Lenalidomide cycles 2-12 (Trial)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 78.42%
            { "Blinatumomab 3 days then 4 days (starting Monday, Tuesday or Friday) ambulate", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.42%
            { "Blinatumomab 4 days then 3 days (starting on Monday, Thursday or Friday)", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.42%
            { "CA017-078 Gemcitabine Cisplatin (Trial)", new ValueWithNote("35806427", "Cisplatin and Gemcitabine/Erlotinib") }, // 78.42%
            { "IMMU-132-13 Paclitaxel (Trial)", new ValueWithNote("35804166", "Paclitaxel monotherapy") }, // 78.42%
            { "TRITON3 CO-338-063 Rucaparib (NCRN Trial)", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 78.36999999999999%
            { "Cetuximab 2 weekly combination (support)", new ValueWithNote("35804795", "Cetuximab monotherapy") }, // 78.36999999999999%
            { "ENRICH Ibrutinib additional (NCRN Trial)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 78.36999999999999%
            { "Larotrectinib (week 13 onwards)", new ValueWithNote("35806364", "Larotrectinib monotherapy") }, // 78.36999999999999%
            { "Irinotecan Capecitabine 21 day", new ValueWithNote("35806890", "Capecitabine and RT") }, // 78.32000000000001%
            { "UPSTREAM (EORTC1559) Durvalumab Monalizumab (Trial)", new ValueWithNote("37556827", "Durvalumab and RT") }, // 78.32000000000001%
            { "Blinatumomab 3 days then 4 days (starting on Monday, Tuesday or Friday)", new ValueWithNote("35804056", "Blinatumomab monotherapy") }, // 78.32000000000001%
            { "PRIME-RT Arm B (Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 78.32000000000001%
            { "CLEE011O12301C (NATALEE) Ribociclib arm (Trial)", new ValueWithNote("35804283", "Anastrozole, Goserelin, Ribociclib") }, // 78.32000000000001%
            { "REMoDL-A R-CHOP cycle 1 (Trial)", new ValueWithNote("35805028", "R-CHOP") }, // 78.22%
            { "FLAIR Ibrutinib Rituximab (NCRN Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 78.22%
            { "Dexamethasone pre docetaxel 16mg IV 1 day", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 78.22%
            { "Denosumab (metastases) 4 weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 78.22%
            { "MVAC accelerated daypt", new ValueWithNote("35804146", "MVAC") }, // 78.22%
            { "LOXO-BTK-20019 Arm B Ibrutinib (Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 78.22%
            { "Constellation (0610-02) Arm 4 CPI-0610 monotherapy (Trial)", new ValueWithNote("35806946", "Teniposide monotherapy") }, // 78.17%
            { "CA224048 Relatlimab Nivolumab Ipilimumab (Trial)", new ValueWithNote("1525060", "Nivolumab and Relatlimab") }, // 78.17%
            { "BP42675 Obinutuzumab pre-treatment (Trial)", new ValueWithNote("35804583", "Obinutuzumab monotherapy") }, // 78.17%
            { "Phesgo (Pertuzumab with Trastuzumab) SC (adjuvant) (support)", new ValueWithNote("37560283", "nab-Paclitaxel, Pertuzumab, Trastuzumab-herw") }, // 78.17%
            { "EZ", new ValueWithNote("37560722", "E-X") }, // 78.12%
            { "REMoDL-A Acalabrutinib R-CHOP cycles 2-6 (Trial)", new ValueWithNote("35804606", "Acalabrutinib monotherapy") }, // 78.12%
            { "PROMise PLX2853 Ruxolitinib (Trial)", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 78.12%
            { "Dexamethasone pre docetaxel 20mg IV 1 day", new ValueWithNote("35102022", "Docetaxel and Prednisolone") }, // 78.12%
            { "FEDR-MF-002 (FREEDOM 2) Fedratinib (Trial)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 78.12%
            { "FLA-IDA", new ValueWithNote("912209", "FLA") }, // 78.12%
            { "LOXO-BTK-20022 Arm A Pirtobrutinib Venetoclax Rituximab (Trial)", new ValueWithNote("1525137", "Ibrutinib, Venetoclax, Obinutuzumab") }, // 78.08%
            { "CNIS793B12301 (dANIS-2) NIS793/placebo Gemcitabine Nab-paclitaxel (Trial)", new ValueWithNote("35804567", "Gemcitabine and nab-Paclitaxel") }, // 78.08%
            { "5F9003 Hu5F9-G4 + R-GemOx cycle 1 (Trial)", new ValueWithNote("35805082", "R-GemOx") }, // 78.08%
            { "Ibrutinib (lymphoma) (compassionate use)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 78.08%
            { "UKALL 2011 Regimen C Delayed intensification (off study)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 78.08%
            { "CABL001E2201 Imatinib arm (Trial)", new ValueWithNote("1524841", "COG AAML0531 arm B (Gemtuzumab)") }, // 78.08%
            { "Abemaciclib (endocrine therapy) (adjuvant)", new ValueWithNote("35804281", "Abemaciclib and Letrozole") }, // 78.08%
            { "daNIS-3 NIS793 FOLFIRI Bevacizumab (Trial)", new ValueWithNote("37556833", "FOLFIRI, Bevacizumab, Cetuximab") }, // 78.08%
            { "EC Docetaxel Phesgo SC (neoadjuvant node positive)", new ValueWithNote("37560424", "EC-TH (Docetaxel) (trastuzumab-qyyp)") }, // 78.08%
            { "Imatinib ALL (support)", new ValueWithNote("35804634", "Imatinib and Interferon alfa") }, // 78.03%
            { "TRIZELL rAd-IFN-MM-301 Gemcitabine (Trial)", new ValueWithNote("35806586", "Docetaxel, Gemcitabine, RT") }, // 78.03%
            { "CC-4047-MM-007 (CANC4276) Bortezomib Dexamethasone Pomalidomide (NCRN Trial)", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 78.03%
            { "Carboplatin 21 day (EDTA)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 78.03%
            { "Methotrexate high dose Cytarabine high dose (primary CNS lymphoma)", new ValueWithNote("35804417", "Methotrexate-Cytarabine") }, // 77.98%
            { "Daratumumab Bortezomib Dexamethasone (cycle 9 onwards) (28 day) rapid rate", new ValueWithNote("35806306", "Bortezomib and Dexamethasone (Vd) and Panobinostat") }, // 77.98%
            { "Dexamethasone pre/post docetaxel 8mg po weekly prostate", new ValueWithNote("911997", "Emapalumab and Dexamethasone") }, // 77.98%
            { "Cyclophosphamide priming prior to PBSC harvest", new ValueWithNote("35806492", "Cisplatin and Cyclophosphamide") }, // 77.98%
            { "Irinotecan Oxaliplatin Modified de Gramont modified (neoadjuvant)", new ValueWithNote("35804150", "No neoadjuvant therapy") }, // 77.92999999999999%
            { "APHRODITE Capecitabine (Trial)", new ValueWithNote("905587", "Capecitabine and Vinorelbine") }, // 77.92999999999999%
            { "FEDORA (RG_21-109) Fedratinib Ropeginterferon alfa-2b (Trial)", new ValueWithNote("35101952", "Fedratinib monotherapy") }, // 77.88000000000001%
            { "Panitumumab Irinotecan Modified DeGramont", new ValueWithNote("35806378", "Irinotecan, Temozolomide, Dinutuximab") }, // 77.83%
            { "Irinotecan Modified de Gramont", new ValueWithNote("35803692", "Irinotecan monotherapy") }, // 77.83%
            { "Enzalutamide (metastatic hormone relapsed)", new ValueWithNote("911935", "Abiraterone and Enzalutamide") }, // 77.83%
            { "rEECur Ifosfamide (off study)", new ValueWithNote("35804542", "Ifosfamide monotherapy") }, // 77.78%
            { "Methotrexate weekly (Large granular cell leukaemia)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 77.78%
            { "Imatinib 400-600", new ValueWithNote("35804076", "Imatinib, Vincristine, Dexamethasone") }, // 77.73%
            { "STELLAR CHOP-R Acalabrutinib (Trial)", new ValueWithNote("911934", "Acalabrutinib and Obinutuzumab") }, // 77.73%
            { "CHOP-21 bolus", new ValueWithNote("35805093", "CHOP-BCG") }, // 77.73%
            { "Carboplatin VTDPACE (support)", new ValueWithNote("35804530", "Carboplatin and RT") }, // 77.73%
            { "Rituximab single agent (weekly) (support)", new ValueWithNote("35803432", "Rituximab monotherapy") }, // 77.73%
            { "Daratumumab Bortezomib Dexamethasone (neuropathy) (cycles 1 to 8 only) (21 day)", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 77.73%
            { "CO41942 Mosun+Len Mosunetuzumab SC Lenalidomide cycle 1 (Trial)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 77.69%
            { "CO41942 Mosun+Len Mosunetuzumab SC Lenalidomide cycles 2-12 (Trial)", new ValueWithNote("35803596", "Lenalidomide monotherapy") }, // 77.69%
            { "Denosumab (metastases) 12 weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 77.69%
            { "Bortezomib (TTP)", new ValueWithNote("35806279", "Bortezomib and Prednisone (VP)") }, // 77.69%
            { "Dexamethasone pre/post docetaxel 20mg IV 8mg po 3 day (RBFT)", new ValueWithNote("37560718", "Docetaxel, Prednisone, Bevacizumab-maly") }, // 77.69%
            { "GCSF filgrastim priming 0.5MU/Kg/day", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 77.69%
            { "CT7001-001 Module 2 part A (Trial)", new ValueWithNote("37557406", "COG D9602 Subgroup A Clinical Group 1 protocol") }, // 77.69%
            { "NEPTUNES Ipilimumab Nivolumab (cohort 2) (Trial)", new ValueWithNote("35806134", "Nivolumab-Ipilimumab") }, // 77.64%
            { "INITIUM (UV1-202) Ipilimumab Nivolumab (Trial)", new ValueWithNote("35804435", "Ipilimumab and Nivolumab") }, // 77.53999999999999%
            { "Mesna for cyclophosphamide 750", new ValueWithNote("35806492", "Cisplatin and Cyclophosphamide") }, // 77.53999999999999%
            { "ALL Phase 1 Induction (25-60 years)", new ValueWithNote("37561927", "No induction therapy") }, // 77.53999999999999%
            { "MAGNETISMM-5 (C1071005) Arm A Elranatamab (Trial)", new ValueWithNote("37557432", "Elranatamab monotherapy") }, // 77.49000000000001%
            { "Rituximab SC maintenance 2nd remission only (3 monthly) (Lymphoma)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 77.49000000000001%
            { "Bevacizumab 7.5mg/kg 3 weekly (support)", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 77.49000000000001%
            { "Bevacizumab maintenance", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 77.49000000000001%
            { "GCSF filgrastim priming 1.0MU/Kg/day", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 77.49000000000001%
            { "Atezolizumab 28 day", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 77.49000000000001%
            { "Acalabrutinib (CLL) (compassionate use)", new ValueWithNote("35804606", "Acalabrutinib monotherapy") }, // 77.49000000000001%
            { "OASIS II Arm A Ibrutinib Rituximab (Trial)", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 77.49000000000001%
            { "54767414MMY3003 (NCRN 2993) Daratumumab monotherapy (NCRN Trial)", new ValueWithNote("35806063", "Daratumumab monotherapy") }, // 77.44%
            { "UKALL 60+ Arm A Phase 1 and 2 induction (off study)", new ValueWithNote("37561927", "No induction therapy") }, // 77.44%
            { "Trastuzumab SC (support)", new ValueWithNote("37561200", "TCHP (Docetaxel, SC Trastuzumab)") }, // 77.44%
            { "EXCALIBER-RRMM (CC-220-MM-002) Arm A (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 77.39%
            { "Aprepitant without dexamethasone (day 1 at home)", new ValueWithNote("37561927", "No induction therapy") }, // 77.39%
            { "InterAACT Carboplatin Paclitaxel (CrCl) (off study)", new ValueWithNote("35806483", "Carboplatin and Paclitaxel (CP) and Olaparib") }, // 77.39%
            { "Daratumumab Bortezomib Dexamethasone (neuropathy) (cycles 1 to 8 only) 21 rapid", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 77.34%
            { "Ondansetron temozolomide 5 day", new ValueWithNote("35803479", "Temozolomide monotherapy") }, // 77.34%
            { "KY1044-CT01 Atezolizumab KY1044 (Trial)", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 77.34%
            { "PETReA Rituximab SC Lenalidomide maintenance (Trial)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 77.34%
            { "Mitotane (Lysodren)", new ValueWithNote("35803587", "Mitotane and Streptozocin") }, // 77.34%
            { "Irinotecan Oxaliplatin Modified de Gramont (metastatic)", new ValueWithNote("37558070", "Oxaliplatin and Paclitaxel") }, // 77.34%
            { "ALL Phase 2 Induction (25-60 years)", new ValueWithNote("37561927", "No induction therapy") }, // 77.34%
            { "ACTICCA-1 Capecitabine (Trial)", new ValueWithNote("35804247", "Capecitabine and Paclitaxel") }, // 77.29%
            { "Carboplatin AUC 10 (CrCl)", new ValueWithNote("35806073", "Carboplatin and Vincristine") }, // 77.29%
            { "Carboplatin AUC 5 (CrCl)", new ValueWithNote("37556795", "Carboplatin and Doxorubicin") }, // 77.29%
            { "Rituximab SC maintenance 1st remission only (2 monthly) (Lymphoma)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 77.29%
            { "Atezolizumab 21 day", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 77.29%
            { "Fludarabine Melphalan RIC (Allograft)", new ValueWithNote("37557862", "Fludarabine and Melphalan, then allo HSCT") }, // 77.29%
            { "Denosumab (metastases) 6 weekly", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 77.29%
            { "Panitumumab Irinotecan Modified de Gramont", new ValueWithNote("35804800", "Panitumumab monotherapy") }, // 77.29%
            { "Rituximab IV 375mg/m2", new ValueWithNote("35803432", "Rituximab monotherapy") }, // 77.25%
            { "EC Docetaxel Phesgo SC (neoadjuvant node negative / unknown)", new ValueWithNote("37557335", "AC-THP (Docetaxel, Phesgo)") }, // 77.25%
            { "UKALL 60+ Arm C Phase 1 Induction (Off Study)", new ValueWithNote("37561927", "No induction therapy") }, // 77.25%
            { "Bendamustine 90-R firstline (CLL)", new ValueWithNote("37559186", "Bendamustine and Rituximab-blit (BR)") }, // 77.25%
            { "Carboplatin desensitisation (CrCl) (support)", new ValueWithNote("42542350", "Carboplatin and Cyclophosphamide") }, // 77.2%
            { "Aprepitant without dexamethasone (day 1 on ward)", new ValueWithNote("37561927", "No induction therapy") }, // 77.2%
            { "Intrathecal Cytarabine", new ValueWithNote("35803502", "Cytarabine and Thioguanine") }, // 77.2%
            { "Aspirin 75", new ValueWithNote("35806655", "Aspirin monotherapy") }, // 77.2%
            { "Carboplatin AUC 5 EDTA (support)", new ValueWithNote("37558432", "Carboplatin, Pemetrexed, Bevacizumab-awwb") }, // 77.2%
            { "PLATFORM Arm A4 Rucaparib maintenance (NCRN Trial)", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 77.2%
            { "Bevacizumab 7.5mg/kg (support)", new ValueWithNote("35804319", "Bevacizumab-containing therapy") }, // 77.2%
            { "RADAR Arm A ABVD (Trial)", new ValueWithNote("35805802", "ABVD") }, // 77.14999999999999%
            { "Ibrutinib Rituximab (SC) maintenance (Mantle cell lymphoma) 1st line", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 77.14999999999999%
            { "AML19 FLAG-Ida course 2 standard risk (NCRN Trial)", new ValueWithNote("37558832", "FLAG-Ida (filgrastim-aafi)") }, // 77.14999999999999%
            { "Nivolumab Oxaliplatin Modified de Gramont (EAMS)", new ValueWithNote("37561943", "Oxaliplatin and Bevacizumab-aveg") }, // 77.14999999999999%
            { "EPIK-B3 (CBYL719H12301) A/B2 Paclitaxel albumin-bound Alpelisib/placebo (Trial)", new ValueWithNote("35804167", "Paclitaxel, nanoparticle albumin-bound monotherapy") }, // 77.14999999999999%
            { "LOXO-BTK-20022 Arm B Venetoclax Rituximab cycle 1 (Trial)", new ValueWithNote("37558910", "Venetoclax and Rituximab-abbs") }, // 77.10000000000001%
            { "Trastuzumab SC", new ValueWithNote("37561200", "TCHP (Docetaxel, SC Trastuzumab)") }, // 77.10000000000001%
            { "Majic Ruxolitinib PV (NCRN Trial)", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 77.10000000000001%
            { "TRIZELL rAd-IFN-MM-301 rAd-IFN Celecoxib (Trial)", new ValueWithNote("37557395", "Celecoxib, Erlotinib, Methotrexate, Nivolumab") }, // 77.10000000000001%
            { "MUK nine b VRD (SC) consolidation part 2 (Trial)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 77.10000000000001%
            { "Add Aspirin Randomised trial treatment (NCRN Trial)", new ValueWithNote("35806655", "Aspirin monotherapy") }, // 77.10000000000001%
            { "Add Aspirin randomised trial treatment (NCRN Trial)", new ValueWithNote("35806655", "Aspirin monotherapy") }, // 77.10000000000001%
            { "BREAKWATER (C4221015) Arm C mFOLFOX6 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 77.05%
            { "Doxorubicin (urgent use)", new ValueWithNote("35804134", "Doxorubicin monotherapy") }, // 77.05%
            { "UKALL 60+ Arm A Consolidation (off study)", new ValueWithNote("35804041", "Pediatric-like GRAALL consolidation") }, // 77.05%
            { "ENHANCE (5F9009) Magrolimab / placebo Azacitidine (Trial)", new ValueWithNote("35803465", "Azacitidine monotherapy") }, // 77.05%
            { "Carboplatin desensitisation (CrCl)", new ValueWithNote("42542350", "Carboplatin and Cyclophosphamide") }, // 76.95%
            { "TRIZELL rAd-IFN-MM-301 Celecoxib (Trial)", new ValueWithNote("37557395", "Celecoxib, Erlotinib, Methotrexate, Nivolumab") }, // 76.95%
            { "LOXO-BTK-20022 Arm B Venetoclax Rituximab cycles 2-25 (Trial)", new ValueWithNote("37558910", "Venetoclax and Rituximab-abbs") }, // 76.9%
            { "RELATIVITY098 (CA224098) BMS-986213 or Nivolumab (Trial)", new ValueWithNote("37557193", "Cabozantinib, Ipilimumab, Nivolumab") }, // 76.9%
            { "Trastuzumab IV", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 76.9%
            { "Cetuximab Oxaliplatin Modified de Gramont", new ValueWithNote("35807025", "Oxaliplatin and Bevacizumab") }, // 76.86%
            { "Calcium folinate 350mg", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 76.86%
            { "ACTICCA-1 Gemcitabine Cisplatin (Trial)", new ValueWithNote("35803575", "Cisplatin and Gemcitabine (GC)") }, // 76.81%
            { "UKALL 60+ Arm D Phase 1 and 2 Induction (off study)", new ValueWithNote("37561927", "No induction therapy") }, // 76.81%
            { "Denosumab (metastases) 4 weekly (28 day cycle)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 76.81%
            { "REMoDL-A R-CHOP cycles 2-6 (Trial)", new ValueWithNote("35806080", "R-CHOP/R-DHAP") }, // 76.81%
            { "Melphalan high dose (Autograft) (renal impairment)", new ValueWithNote("35806058", "Melphalan, then auto HSCT") }, // 76.71%
            { "Carboplatin AUC 5 (EDTA)", new ValueWithNote("35806400", "Carboplatin and Etoposide (CE)") }, // 76.71%
            { "ISIS-702843-CS4 Cohort A (Trial)", new ValueWithNote("37557286", "COG ANBL 0032 Regimen A") }, // 76.71%
            { "Enzalutamide (metastatic hormone relapsed) (support)", new ValueWithNote("911935", "Abiraterone and Enzalutamide") }, // 76.71%
            { "Venetoclax continuation (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 76.71%
            { "LOXO-BTK-20019 Arm A LOXO-305 (Pirtobrutinib) (Trial)", new ValueWithNote("37556847", "Pirtobrutinib monotherapy") }, // 76.71%
            { "CEeDD Cohort 3 Cetuximab Irinotecan Modified de Gramont (Trial)", new ValueWithNote("35804798", "Irinotecan and Cetuximab") }, // 76.66%
            { "INITIUM (UV1-202) UV1 Ipilimumab Nivolumab (Trial)", new ValueWithNote("35804435", "Ipilimumab and Nivolumab") }, // 76.66%
            { "FGCL-4592-082 Roxadustat / placebo (Trial)", new ValueWithNote("35803590", "Placebo") }, // 76.66%
            { "CABL001J12301 Arm 2 Imatinib (Trial)", new ValueWithNote("1524841", "COG AAML0531 arm B (Gemtuzumab)") }, // 76.66%
            { "Obinutuzumab Glofitamab (compassionate use)", new ValueWithNote("35804583", "Obinutuzumab monotherapy") }, // 76.61%
            { "Cisplatin Fluorouracil (100 H&N) infusor Daypt", new ValueWithNote("35803672", "Cisplatin and Fluorouracil (CF) and RT") }, // 76.61%
            { "Ibrutinib Rituximab (IV cycle 1 then SC c2-6) (Mantle cell lymphoma) 1st line", new ValueWithNote("35804612", "Ibrutinib and Rituximab") }, // 76.61%
            { "PCYC-1128-CA Cohort 5 Ibrutinib (NCRN Trial)", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 76.61%
            { "Carboplatin AUC 6 (CrCl)", new ValueWithNote("37556795", "Carboplatin and Doxorubicin") }, // 76.61%
            { "ICON 9 Olaparib Arm 2 (Trial)", new ValueWithNote("35804269", "Olaparib monotherapy") }, // 76.55999999999999%
            { "Cisplatin Fluorouracil (80 H&N) infusor Daypt", new ValueWithNote("35803672", "Cisplatin and Fluorouracil (CF) and RT") }, // 76.55999999999999%
            { "PROSPER Enzalutamide open label (commercial trial)", new ValueWithNote("35804322", "Enzalutamide monotherapy") }, // 76.55999999999999%
            { "PRISM (ACE-LY-111) Arm 1 Acalabrutinib AZD9150 (Trial)", new ValueWithNote("35804606", "Acalabrutinib monotherapy") }, // 76.55999999999999%
            { "R3767-ONC-1613 REGN3767 and REGN2810 combination (Trial)", new ValueWithNote("35803560", "Idarubicin, then Mitoxantrone, then Idarubicin, with ATRA") }, // 76.55999999999999%
            { "1426-0001 Arm B BI 138746 BI 754091 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 76.51%
            { "Daratumumab SC Bortezomib Dexamethasone (neuropathy) (cycles 1-8 only) (21 day)", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 76.51%
            { "Intrathecal Methotrexate", new ValueWithNote("35804095", "Methotrexate monotherapy") }, // 76.51%
            { "Cisplatin (50) (cervix)", new ValueWithNote("35102030", "Carboplatin and Cisplatin") }, // 76.51%
            { "Belantamab mafodontin (GSK2857916) (compassionate use)", new ValueWithNote("911956", "Belantamab mafodotin monotherapy") }, // 76.51%
            { "ALL Consolidation cycle 1 (25-60 years)", new ValueWithNote("1525160", "No consolidation") }, // 76.46%
            { "NUTIDE 302 Bevacizumab (support) (Trial)", new ValueWithNote("37558761", "Bevacizumab-onbe-containing therapy") }, // 76.42%
            { "SYD985.002 (TULIP) SYD985 arm (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 76.42%
            { "GO40311 BTRC4017A Trastuzumab one step fractionation (Trial)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 76.37%
            { "Denosumab (metastases)", new ValueWithNote("35804178", "Denosumab monotherapy") }, // 76.37%
            { "RiVa Arm B (Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 76.37%
            { "ATRA (Tretinoin) (Emergency use)", new ValueWithNote("35803549", "Arsenic trioxide and ATRA") }, // 76.37%
            { "Nivolumab 14 day", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 76.32%
            { "NUTIDE 701 NUC-7738 Pembrolizumab (Trial)", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 76.32%
            { "Cisplatin hydration (cisplatin dose =<40mg/m2)", new ValueWithNote("35803573", "Cisplatin monotherapy") }, // 76.32%
            { "CA017-078 Gemcitabine Cisplatin Nivolumab BMS-986205/Placebo (Trial)", new ValueWithNote("1525074", "Cisplatin and Gemcitabine (GC) and Nivolumab") }, // 76.32%
            { "FLAIR Fludarabine Cyclophosphamide Rituximab (NCRN Trial)", new ValueWithNote("37559788", "Fludarabine and Rituximab-rixi (FR)") }, // 76.32%
            { "D5330C00004 Module 2 Ceralasertib Olaparib (Trial)", new ValueWithNote("912013", "Olaparib and Bevacizumab") }, // 76.32%
            { "Prednisolone 1mg/kg 7 days", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 76.27000000000001%
            { "Phesgo (Pertuzumab with Trastuzumab) SC (metastatic)", new ValueWithNote("37560284", "Pertuzumab and Trastuzumab-herw") }, // 76.27000000000001%
            { "GCSF filgrastim (variable number of days up to 10)", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 76.27000000000001%
            { "Cyclophosphamide IV bolus for use with DTPACE or VTDPACE only (support)", new ValueWithNote("35804235", "Dose-dense Cyclophosphamide monotherapy") }, // 76.22%
            { "PK 2013 01 VDC/IE (Trial)", new ValueWithNote("35805450", "VDC/IE") }, // 76.17%
            { "PRO-DLI (Fludarabine Melphalan Alemtuzumab) (Trial)", new ValueWithNote("35803629", "Fludarabine, Melphalan, Alemtuzumab") }, // 76.12%
            { "Carboplatin AUC 7 (CrCl)", new ValueWithNote("37556795", "Carboplatin and Doxorubicin") }, // 76.07000000000001%
            { "Denosumab (metastases) 4 weekly (84 day cycle)", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 76.07000000000001%
            { "BEACOPDac escalated", new ValueWithNote("35803997", "BEAC") }, // 76.07000000000001%
            { "UKALL 2011 Regimen C Capizzi interim maintenance (off study)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 76.03%
            { "Docetaxel (100) (adjuvant) 21 day", new ValueWithNote("35806838", "ADT and Docetaxel") }, // 76.03%
            { "Irinotecan Modified DeGramont (NET)", new ValueWithNote("35803576", "Cisplatin and Irinotecan (IC)") }, // 76.03%
            { "MOTION Vismeltinib / placebo (Trial)", new ValueWithNote("35803590", "Placebo") }, // 76.03%
            { "ATRA (Tretinoin) (emergency use continuation) support", new ValueWithNote("35803552", "ATRA monotherapy") }, // 75.98%
            { "D8231C00001 AZD4573 cycle 2 onwards (Trial)", new ValueWithNote("37557285", "COG ACNS0332 Regimen D") }, // 75.92999999999999%
            { "CDK-002-101 (Trial)", new ValueWithNote("35804373", "CALGB 10-002 regimen") }, // 75.92999999999999%
            { "Constellation (0610-02) Arms 2 and 3 CPI-610 Ruxolitinib (Trial)", new ValueWithNote("35803508", "Ruxolitinib monotherapy") }, // 75.92999999999999%
            { "CRUKD/11/001;Vandeta+Selumetinib(od)dose escalation_C2onwards (EarlyPhaseTrial)", new ValueWithNote("912244", "Pemetrexed and Vandetanib") }, // 75.88000000000001%
            { "Erythropoietin zeta weekly", new ValueWithNote("42542424", "Erythropoietin alfa monotherapy") }, // 75.88000000000001%
            { "Carboplatin 21 day (CrCl) breast", new ValueWithNote("42542350", "Carboplatin and Cyclophosphamide") }, // 75.88000000000001%
            { "EV-302 Arm B Gemcitabine Cisplatin (Trial)", new ValueWithNote("35806427", "Cisplatin and Gemcitabine/Erlotinib") }, // 75.88000000000001%
            { "Trastuzumab SC 21 day", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 75.88000000000001%
            { "UKALL 2011 Regimen B Standard BFM consolidation (off study)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 75.88000000000001%
            { "UKALL 60+ Arm A Maintenance (off study)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 75.88000000000001%
            { "CHARIOT Cisplatin Capecitabine stage A2 or B induction (Trial)", new ValueWithNote("35805336", "Capecitabine, Cisplatin, RT") }, // 75.83%
            { "MATTERHORN (D910GC00001) Durvalumab/placebo FLOT (Trial)", new ValueWithNote("35804164", "Durvalumab monotherapy") }, // 75.83%
            { "MATRIX NLMT Arm J (Ceralasertib Durvalumab) (Trial)", new ValueWithNote("37559668", "MATRix (rituximab-rixa)") }, // 75.78%
            { "M16-109 (REFINE) Navitoclax monotherapy (Trial)", new ValueWithNote("37557064", "Nolatrexed monotherapy") }, // 75.78%
            { "Capecitabine (1250) adjuvant", new ValueWithNote("35804560", "Capecitabine and Mitomycin") }, // 75.78%
            { "Nivolumab 28 day", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.78%
            { "Rituximab 100mg dose (support)", new ValueWithNote("37559628", "(90)YFC (rituximab-rixa)") }, // 75.68%
            { "MonarchE Arm A Abemaciclib + SoC endocrine (NCRN Trial)", new ValueWithNote("35804258", "Abemaciclib monotherapy") }, // 75.68%
            { "KY1044-CT01 Atezolizumab KY1044 24mg infusion bag (Trial)", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 75.63%
            { "Dexrazoxane", new ValueWithNote("35805830", "DexaBEAM") }, // 75.63%
            { "RP3-301 Nivolumab cohorts 3 and 4 (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.59%
            { "STAR-221 Arm A Domvanalimab Zimberelimab FOLFOX (Trial)", new ValueWithNote("1525137", "Ibrutinib, Venetoclax, Obinutuzumab") }, // 75.59%
            { "Capecitabine Phesgo SC (metastatic)", new ValueWithNote("37560307", "Capecitabine, Bevacizumab-equi, Trastuzumab-herw") }, // 75.53999999999999%
            { "CVP bolus (patients under 70 years)", new ValueWithNote("35804599", "CVP") }, // 75.53999999999999%
            { "CRUKD/22/002 HMBD-001 Arm 1 monotherapy (Trial)", new ValueWithNote("35805376", "Hydroxyurea monotherapy") }, // 75.53999999999999%
            { "CONTRAST BI-1607 Trastuzumab (Trial)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 75.49%
            { "Daratumumab SC (c1-3) then IV (c4-8) Bortezomib Dexam (neuropathy 21d) (compas)", new ValueWithNote("35806321", "Bortezomib, Thalidomide, Dexamethasone, Panobinostat") }, // 75.49%
            { "Etoposide IV split bags support", new ValueWithNote("35803691", "Etoposide monotherapy") }, // 75.49%
            { "Pembrolizumab 400mg (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 75.49%
            { "UKALL 60+ Arm D Consolidation 1 (off study)", new ValueWithNote("35804041", "Pediatric-like GRAALL consolidation") }, // 75.49%
            { "VDTPACE (cyclophosphamide bolus)", new ValueWithNote("35806327", "DTPACE") }, // 75.44%
            { "AML19 Cytarabine high dose (NCRN Trial)", new ValueWithNote("35803556", "ATRA, Cytarabine, Idarubicin") }, // 75.44%
            { "GCSF filgrastim", new ValueWithNote("37558840", "CAD and G-CSF (filgrastim-aafi)") }, // 75.44%
            { "NG-641-03 (NEBULA) NG-641 Nivolumab (Trial)", new ValueWithNote("37557077", "Temozolomide, Nivolumab, RT") }, // 75.44%
            { "RPL-001-16 Phase 1 expansion or Phase 2 Nivolumab & RP1 (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.39%
            { "Bendamustine 90-R (NHL)", new ValueWithNote("912010", "Bendamustine and Dexamethasone") }, // 75.39%
            { "SCIB1-002 Nivolumab Ipilimumab SCIB1 (Trial)", new ValueWithNote("35806134", "Nivolumab-Ipilimumab") }, // 75.33999999999999%
            { "ALL Consolidation cycle 2 (25-60 years)", new ValueWithNote("1525160", "No consolidation") }, // 75.33999999999999%
            { "5F9005 Magrolimab Azacitidine AML/MDS expansion (Trial)", new ValueWithNote("35804643", "Azacitidine and Lenalidomide") }, // 75.29%
            { "STAMPEDE G HT + Abiraterone (NCRN Trial)", new ValueWithNote("35806848", "Abiraterone monotherapy") }, // 75.29%
            { "Co-trimoxazole 480mg 3xweekly", new ValueWithNote("37557200", "COG A9961 regimen") }, // 75.24%
            { "AML19 CPX-351 (NCRN Trial)", new ValueWithNote("35803473", "CPX-351 monotherapy") }, // 75.24%
            { "D933LC00001 (BEGONIA) Arm 1 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 75.2%
            { "ALL-RIC Intrathecal Methotrexate (Trial)", new ValueWithNote("35804095", "Methotrexate monotherapy") }, // 75.2%
            { "PRIME-RT Arm A (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 75.2%
            { "Prednisolone 1mg/kg 14 days", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 75.14999999999999%
            { "Cisplatin 21 day (ovarian) daypt", new ValueWithNote("35804144", "Cisplatin and RT") }, // 75.14999999999999%
            { "CT7001-001 Module 1 Cycle 1 onwards (Trial)", new ValueWithNote("37557409", "COG D9602 Subgroup B Clinical Group 1 protocol") }, // 75.14999999999999%
            { "BEP 5 day metastatic", new ValueWithNote("35803570", "BEP") }, // 75.1%
            { "Imatinib CML (support)", new ValueWithNote("35804634", "Imatinib and Interferon alfa") }, // 75.1%
            { "Nivolumab 28 day (compassionate use)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.05%
            { "ADCT-402-201 (Trial)", new ValueWithNote("35806821", "ADT") }, // 75.05%
            { "ACE-536-MDS-002 (COMMANDS) Epoetin alfa (Trial)", new ValueWithNote("37557841", "Erythropoetin alfa and Lenalidomide") }, // 75.05%
            { "Nivolumab 14 day (compassionate use)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.05%
            { "ACE-536-MF-001 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 75.05%
            { "KRT-232-101 28 day cycle (Trial)", new ValueWithNote("37557285", "COG ACNS0332 Regimen D") }, // 75.0%
            { "GCSF filgrastim 7 days", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 75.0%
            { "CA017-078 Nivolumab BMS-986205/Placebo adjuvant (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 75.0%
            { "Aprepitant with dexamethasone (day 1 at home)", new ValueWithNote("1525123", "Dexamethasone and Mycophenolate mofetil") }, // 75.0%
            { "MEDI4736-NHL-001 Arm B (NHL) (NCRN Trial)", new ValueWithNote("1524841", "COG AAML0531 arm B (Gemtuzumab)") }, // 74.95%
            { "D933LC00001 (BEGONIA) Arm 2 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 74.95%
            { "GS-US-546-5920 Cohort 2 Mag+MEC (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 74.95%
            { "Aprepitant with dexamethasone (day 1 on ward)", new ValueWithNote("1525123", "Dexamethasone and Mycophenolate mofetil") }, // 74.95%
            { "UKALL 60+ Arm C Maintenance (Off Study)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 74.9%
            { "PETReA Obintuzumab maintenance (Trial)", new ValueWithNote("37561184", "RT-PEPC; Maintenance (rituximab-pvvr)") }, // 74.85000000000001%
            { "Ibrutinib (CLL) (support)", new ValueWithNote("37559203", "Ibrutinib and Rituximab-blit") }, // 74.85000000000001%
            { "ALL Consolidation cycle 4 (25-60 years)", new ValueWithNote("1525160", "No consolidation") }, // 74.85000000000001%
            { "STAR-221 Arm B Nivolumab FOLFOX (Trial)", new ValueWithNote("37558452", "FOLF-CB (bevacizumab-awwb)") }, // 74.85000000000001%
            { "Pembrolizumab 200mg (relapsed/metastatic)", new ValueWithNote("37561017", "Cisplatin, Pembrolizumab, RT") }, // 74.8%
            { "BEP 3 day metastatic", new ValueWithNote("35803570", "BEP") }, // 74.76%
            { "Lansoprazole", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 74.76%
            { "GCSF filgrastim priming", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.76%
            { "ENRICH Ibrutinib maintenance (Trial)", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 74.76%
            { "D933LC00001 (BEGONIA) Arm 6 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 74.76%
            { "Methotrexate 50 (germ cell)", new ValueWithNote("35804395", "IT Cytarabine and Methotrexate") }, // 74.76%
            { "Pembrolizumab 200mg then 400mg (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.76%
            { "RADAR (Myeloma XV) RCyBorD induction (Trial)", new ValueWithNote("37558895", "GMALL-R; Induction (rituximab-abbs)") }, // 74.71%
            { "CEDAR Capecitabine RT Enadenotucirev maintenance (Trial)", new ValueWithNote("35806890", "Capecitabine and RT") }, // 74.71%
            { "Pembrolizumab 200mg then 400mg (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.71%
            { "PEMBROWM Pembrolizumab Rituximab (Trial)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.71%
            { "ONC001 Part A or Part A1 cohorts 1 and 2 (2 weekly) (Trial)", new ValueWithNote("37557406", "COG D9602 Subgroup A Clinical Group 1 protocol") }, // 74.71%
            { "GCSF filgrastim 3 days", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.71%
            { "RP3-301 RP3 Nivolumab cohorts 1 and 5 (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 74.66000000000001%
            { "Pembrolizumab 2mg/kg (metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.66000000000001%
            { "MUK nine b VRDd consolidation part 1 (Trial)", new ValueWithNote("35804041", "Pediatric-like GRAALL consolidation") }, // 74.66000000000001%
            { "GO40311 Trastuzumab cycle 1 day -1 (support) (Trial)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 74.66000000000001%
            { "UKALL 2011 Regimen B3/C3 maintenance (males) (NCRN Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 74.61%
            { "MITHRIDATE (RG_16-148) Ruxolitinib (Trial)", new ValueWithNote("37560915", "ADT, Abiraterone, Apalutamide") }, // 74.56%
            { "Cisplatin hydration (cisplatin dose >=61mg/m2)", new ValueWithNote("35803573", "Cisplatin monotherapy") }, // 74.56%
            { "ONC001 Part A1 cohort 3 (3 weekly) (Trial)", new ValueWithNote("37557408", "COG D9602 Subgroup A Clinical Group 3 protocol") }, // 74.56%
            { "Trastuzumab (8/6) (adjuvant) 21 day (support)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 74.56%
            { "Atezolizumab 28 day (adjuvant)", new ValueWithNote("35804138", "Atezolizumab monotherapy") }, // 74.56%
            { "CCS1477-02 CCS1477-MB 4 days on 3 days off bd dosing (without azoles) (Trial)", new ValueWithNote("37557288", "COG ANBL0532 Regimen B") }, // 74.51%
            { "ACCEPT Phase 1 cohort 2 and phase 2 cycles 7-8 (Trial)", new ValueWithNote("35803437", "7 plus 3d (intermediate-dose)") }, // 74.51%
            { "D8231C00001 AZD4573 cycle 1 (Trial)", new ValueWithNote("37557285", "COG ACNS0332 Regimen D") }, // 74.51%
            { "INITIUM (UV1-202) Nivolumab maintenance (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 74.46000000000001%
            { "CC-90009-AML-001 Gen 2 days 1-10 (Trial)", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.46000000000001%
            { "Ibrutinib (Mantle cell lymphoma) 2nd line", new ValueWithNote("35804582", "Ibrutinib and Obinutuzumab") }, // 74.46000000000001%
            { "Atezolizumab 21 day (relapsed/metastatic)", new ValueWithNote("37556802", "Atezolizumab and RT") }, // 74.46000000000001%
            { "GCSF pegfilgrastim", new ValueWithNote("37558841", "Cyclophosphamide and G-CSF (filgrastim-aafi)") }, // 74.37%
            { "Prednisolone 1mg/kg 21 days", new ValueWithNote("35803431", "Prednisolone monotherapy") }, // 74.37%
            { "RAMPART Arm C (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 74.32%
            { "GCSF filgrastim 5 days", new ValueWithNote("37558834", "COG AAML1421 protocol (filgrastim-aafi)") }, // 74.32%
            { "Venetoclax titration continuation (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 74.32%
            { "GS-US-546-5920 Cohort 1 Mag+Ven+Aza (Trial)", new ValueWithNote("37561077", "GMALL-R; Induction 2 (rituximab-pvvr)") }, // 74.32%
            { "D933LC00001 (BEGONIA) Arm 5 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 74.32%
            { "RMS 2005 Vinorelbine Cyclophosphamide maintenance (Off  Study)", new ValueWithNote("37556916", "Cyclophosphamide and Vincristine (CV)") }, // 74.27%
            { "RP2-001-18 Nivolumab RP2 (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 74.27%
            { "UKALL 60+ Arm B Intensification (off study)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 74.17%
            { "Aprepitant oral", new ValueWithNote("912023", "Azacitidine oral monotherapy") }, // 74.11999999999999%
            { "MATRIX NLMT Arm C (Palbociclib) (Trial)", new ValueWithNote("37560981", "Carboplatin and Paclitaxel (CP) and Penpulimab") }, // 74.07000000000001%
            { "Imatinib 400-600 (GIST/sarcomas)", new ValueWithNote("35804083", "Imatinib monotherapy") }, // 74.07000000000001%
            { "Momelotinib (Compassionate Use)", new ValueWithNote("37557051", "Docetaxel, Lenalidomide, Prednisone") }, // 74.07000000000001%
            { "Trastuzumab (8/6) (metastatic) 21 day", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 74.02%
            { "Pembrolizumab 400mg (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 74.02%
            { "Trastuzumab SC 21 day (support)", new ValueWithNote("37561200", "TCHP (Docetaxel, SC Trastuzumab)") }, // 73.97%
            { "EP", new ValueWithNote("912157", "EP, Tamoxifen, RT") }, // 73.92999999999999%
            { "LUD2015-005 Cohort D2 (NCRN Trial)", new ValueWithNote("37557285", "COG ACNS0332 Regimen D") }, // 73.88%
            { "CT7001-001 Module 4 Cycle 1 onwards (Trial)", new ValueWithNote("37557409", "COG D9602 Subgroup B Clinical Group 1 protocol") }, // 73.88%
            { "Add Aspirin Run in (NCRN Trial)", new ValueWithNote("35806655", "Aspirin monotherapy") }, // 73.88%
            { "Atezolizumab 28 day (relapsed/metastatic)", new ValueWithNote("37556802", "Atezolizumab and RT") }, // 73.88%
            { "Constellation (0610-02) Arm 3 CPI-0610 125mg + Rux R(-1) (Trial)", new ValueWithNote("37559734", "SC-EPOCH-RR (rituximab-rixa)") }, // 73.83%
            { "Cisplatin hydration (cisplatin dose 41-60mg/m2)", new ValueWithNote("35803573", "Cisplatin monotherapy") }, // 73.83%
            { "NUTIDE 302 Cohort 1c NUC-3373 + LV (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 73.83%
            { "MAP (APMM)", new ValueWithNote("35806469", "MAP") }, // 73.83%
            { "Methotrexate high dose (high grade NHL CNS prophylaxis)", new ValueWithNote("35804095", "Methotrexate monotherapy") }, // 73.83%
            { "ALKS 4230-006 ARTISTRY-6 cohort 2 (Trial)", new ValueWithNote("37557288", "COG ANBL0532 Regimen B") }, // 73.78%
            { "OCTOVA Arm B (NCRN Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 73.78%
            { "UKALL 60+ Arm B and D Maintenance (off study)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 73.78%
            { "PLATFORM Arm A3 MEDI4736 maintenance (NCRN Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 73.72999999999999%
            { "Cisplatin weekly (ovarian) daypt", new ValueWithNote("35804205", "Paclitaxel monotherapy, weekly") }, // 73.72999999999999%
            { "Cardamon maintenance (Carfilzomib) (NCRN Trial)", new ValueWithNote("35806280", "Carfilzomib monotherapy") }, // 73.68%
            { "CVP bolus (patients over 70 years)", new ValueWithNote("35804599", "CVP") }, // 73.68%
            { "RXC004/0001 (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 73.68%
            { "Aprepitant Dexamethasone (day 1 on ward)", new ValueWithNote("35804388", "Dexamethasone monotherapy") }, // 73.63%
            { "CXD101-0901; CXD101 expansion (early phase trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 73.58%
            { "Euro Ewing 2012 VDC/IE (off study)", new ValueWithNote("35805450", "VDC/IE") }, // 73.58%
            { "Samuraciclib (compassionate use)", new ValueWithNote("37561828", "Fulvestrant, Inavolisib, Palbociclib") }, // 73.58%
            { "D933LC00001 (BEGONIA) Arm 7 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 73.54%
            { "MITHRIDATE (RG_16-148) Hydroxycarbamide (Trial)", new ValueWithNote("37557012", "Nimustine, Procarbazine, RT") }, // 73.54%
            { "EDP daypatient", new ValueWithNote("35803589", "Mitotane and EDP") }, // 73.54%
            { "ADCT-301-201 (Trial)", new ValueWithNote("35806821", "ADT") }, // 73.49%
            { "NUTIDE 701 weekly (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 73.49%
            { "CompARE Arm 1 Cisplatin 40mg/m2 (NCRN Trial)", new ValueWithNote("37556873", "Cisplatin, Nimotuzumab, RT") }, // 73.49%
            { "WO41554 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 73.49%
            { "Pembrolizumab 21 day then 42 day (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 73.49%
            { "MITHRIDATE (RG_16-148) Pegylated Interferon Alfa-2a (Trial)", new ValueWithNote("35805377", "Peginterferon alfa-2a monotherapy") }, // 73.44000000000001%
            { "PETRA (D9720C00001) Module 1 (Trial)", new ValueWithNote("37557406", "COG D9602 Subgroup A Clinical Group 1 protocol") }, // 73.44000000000001%
            { "Mifamurtide (support)", new ValueWithNote("35806584", "mFOLFIRINOX") }, // 73.44000000000001%
            { "RP3-301 RP3 monotherapy cohorts 3 and 4 (Trial)", new ValueWithNote("35806484", "Rucaparib monotherapy") }, // 73.44000000000001%
            { "2102-HEM-101 FT-2102 twice daily (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 73.39%
            { "CACZ885T2301 Canakinumab/Placebo (Trial)", new ValueWithNote("35803590", "Placebo") }, // 73.39%
            { "54767414MMY3008 (CANC-4387) Daratumumab subequent therarapy (NCRN Trial)", new ValueWithNote("1524917", "Dara-Rd (SC daratumumab)") }, // 73.34%
            { "Nivolumab 14 day (relapsed/metastatic)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 73.34%
            { "ACE-536-MDS-001 (MEDALIST) (NCRN Trial)", new ValueWithNote("35804070", "Daunorubicin, Vincristine, Prednisolone, Nilotinib") }, // 73.34%
            { "UKALL 14 Imatinib (NCRN Trial)", new ValueWithNote("35804076", "Imatinib, Vincristine, Dexamethasone") }, // 73.34%
            { "RP3-301 RP3 Nivolumab (Trial)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 73.34%
            { "Nivolumab 28 day (relapsed/metastatic)", new ValueWithNote("1525060", "Nivolumab and Relatlimab") }, // 73.29%
            { "UKALL 2011 Regimen B Standard interim maintenance (off study)", new ValueWithNote("37557288", "COG ANBL0532 Regimen B") }, // 73.29%
            { "Trastuzumab (8/6) (metastatic) 21 day (support)", new ValueWithNote("35804222", "Trastuzumab monotherapy") }, // 73.29%
            { "ADVANCE Group 2 (Trial)", new ValueWithNote("37557410", "COG D9602 Subgroup B Clinical Group 2 protocol") }, // 73.29%
            { "LOXO-BTK-18001 (Trial)", new ValueWithNote("912006", "Ampicillin, Metronidazole, Bismuth") }, // 73.24000000000001%
            { "Sodium choride 0.9% 1000ml IV infusion over 60 minutes", new ValueWithNote("37561927", "No induction therapy") }, // 73.24000000000001%
            { "ONC001 Part B (Trial)", new ValueWithNote("37557409", "COG D9602 Subgroup B Clinical Group 1 protocol") }, // 73.24000000000001%
            { "Cetuximab / Panitumumab skin toxicity", new ValueWithNote("912242", "CP and Cetuximab") }, // 73.24000000000001%
            { "AMMO Arm A ASTX727 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 73.19%
            { "ALKS 4230-006 ARTISTRY-6 cohort 1 (Trial)", new ValueWithNote("37557287", "COG ANBL0532 Regimen A") }, // 73.19%
            { "Bevacizumab 14 day (neurofibromatosis 2)", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 73.19%
            { "RS-TS-101-01 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 73.14%
            { "Cetuximab skin toxicity", new ValueWithNote("35804795", "Cetuximab monotherapy") }, // 73.1%
            { "Dapsone", new ValueWithNote("37556867", "Dacarbazine, Fotemustine, Interferon alfa-2b") }, // 73.1%
            { "Paracetamol IV", new ValueWithNote("912022", "Azacitidine IV monotherapy") }, // 73.05%
            { "CHARIOT M6620 Tuesday doses (Trial)", new ValueWithNote("35805753", "EPOCH, dose-escalated") }, // 73.05%
            { "NUTIDE 301 part 1 (NUC-3373 weekly) (NCRN Trial)", new ValueWithNote("37557286", "COG ANBL 0032 Regimen A") }, // 73.05%
            { "RADAR (Myeloma XV) RCyBorIsaD (Trial)", new ValueWithNote("37561020", "Cisplatin, Vinorelbine, Bevacizumab-aybi") }, // 73.0%
            { "ACE-WM-001 ACP-196 (commercial study)", new ValueWithNote("911939", "ACP") }, // 73.0%
            { "Rituximab IV 100mg (ITP)", new ValueWithNote("37559437", "TT4 (rituximab-pvvr)") }, // 73.0%
            { "Pembrolizumab 42 day (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.95%
            { "Cardamon consolidation (CarCyDex) (NCRN Trial)", new ValueWithNote("35804078", "Imatinib-based consolidation") }, // 72.89999999999999%
            { "IMG-7289-CTP-201 IMG-7289 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 72.85000000000001%
            { "IMP-MEL IMM60 Pembrolizumab (Trial)", new ValueWithNote("35806355", "Pomalidomide, Dexamethasone, Pembrolizumab") }, // 72.85000000000001%
            { "Venetoclax doses for delay in titration (add in on date of delay) (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 72.85000000000001%
            { "DREAMM-9 Belantamab mafodontin Rd maintenance (Trial)", new ValueWithNote("911956", "Belantamab mafodotin monotherapy") }, // 72.8%
            { "BGB-3111-302 BGB-3111 (NCRN Trial)", new ValueWithNote("37557409", "COG D9602 Subgroup B Clinical Group 1 protocol") }, // 72.75%
            { "Mouth and Bowel Support Minus Metoclopramide", new ValueWithNote("912106", "Metronidazole, Tetracycline, PPI, Bismuth") }, // 72.75%
            { "DREAMM-9 Belantamab mafodontin VRd (Trial)", new ValueWithNote("911956", "Belantamab mafodotin monotherapy") }, // 72.75%
            { "CHARIOT M6620 Friday doses (Trial)", new ValueWithNote("35803437", "7 plus 3d (intermediate-dose)") }, // 72.75%
            { "Ipi-Glio Arm B (Trial)", new ValueWithNote("1524906", "Arms B (Nelarabine Arms)") }, // 72.75%
            { "Aprepitant already has antiemetic dexamethasone prescribed (day 1 on ward)", new ValueWithNote("35805911", "Dexamethasone and Eltrombopag") }, // 72.71%
            { "Cisplatin hydration daypatient", new ValueWithNote("35803573", "Cisplatin monotherapy") }, // 72.71%
            { "Nivolumab 14 day (adjuvant)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 72.71%
            { "Hydroxycarbamide (3 months)", new ValueWithNote("37561927", "No induction therapy") }, // 72.66%
            { "RXC004/0001 Module 2 (Trial)", new ValueWithNote("35804774", "FOLFOX 7/sLV5FU2") }, // 72.66%
            { "ASTX660-01 (7 days on/7 days off) (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 72.66%
            { "Lansoprazole 5 day", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 72.66%
            { "UCL/17/0629 (PROMPT) Pembrolizumab (Trial)", new ValueWithNote("37560485", "CapeOx, Pembrolizumab, Trastuzumab-qyyp") }, // 72.66%
            { "Aprepitant already has antiemetic dexamethasone prescribed (day 1 at home)", new ValueWithNote("35805911", "Dexamethasone and Eltrombopag") }, // 72.61%
            { "BP42675 RO7122290 Cibisatamab part 1 (Trial)", new ValueWithNote("1524841", "COG AAML0531 arm B (Gemtuzumab)") }, // 72.56%
            { "GCSF lenograstim", new ValueWithNote("35804588", "G-FC") }, // 72.56%
            { "Pembrolizumab 200mg (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.46000000000001%
            { "MidAC", new ValueWithNote("35803510", "HiDAC and Midostaurin") }, // 72.41%
            { "GS-US-352-4365 (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 72.36%
            { "MIV-818-101/201 (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 72.36%
            { "DS3201-A-U202 (Valentine) (Trial)", new ValueWithNote("37557409", "COG D9602 Subgroup B Clinical Group 1 protocol") }, // 72.36%
            { "SCIB1-002 Pembrolizumab SCIB1 (Trial)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.36%
            { "NG-350A-02 (FORTIFY) NG-350A Pembrolizumab (Trial)", new ValueWithNote("905721", "nab-Paclitaxel and Pembrolizumab") }, // 72.31%
            { "LOXO-BTK-20019 Arm A LOXO-305 (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 72.31%
            { "Pembrolizumab 21 day then 42 day (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.31%
            { "ACCEPT Phase 1 cohort 2 and phase 2 cycles 1-6 (Trial)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 72.31%
            { "NUTIDE 302 NUFIRI Q1W (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 72.31%
            { "Liposomal amphotericin B (Ambisome) prophylaxis", new ValueWithNote("35807092", "Daunorubicin liposomal monotherapy") }, // 72.31%
            { "ONC001 Part A1 cohort 4 (4 weekly) (Trial)", new ValueWithNote("37557286", "COG ANBL 0032 Regimen A") }, // 72.27%
            { "LUD2015-005 Cohort C-FLOT (NCRN Trial)", new ValueWithNote("35805341", "FLOT") }, // 72.22%
            { "DREAMM-9 Belantamab mafodontin VRd (every cycle) (Trial)", new ValueWithNote("911956", "Belantamab mafodotin monotherapy") }, // 72.17%
            { "UKALL 2011 Regimen B1/C1 maintenance (males) (off study)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 72.17%
            { "CC-92480-MM-001 21/28 OD schedule (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 72.17%
            { "Venetoclax extra doses for cycles delayed after titration completed (support)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 72.17%
            { "DREAMM-9 Belantamab mafodontin Rd maintenance (every cycle) (Trial)", new ValueWithNote("911956", "Belantamab mafodotin monotherapy") }, // 72.17%
            { "Difflam", new ValueWithNote("35803998", "BeEAM") }, // 72.11999999999999%
            { "Pembrolizumab 42 day (relapsed/metastatic)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 72.11999999999999%
            { "RP2-001-18 RP2 (Trial)", new ValueWithNote("35805041", "R-GCVP") }, // 72.07000000000001%
            { "Posaconazole prophylaxis", new ValueWithNote("35806852", "Ketoconazole and Hydrocortisone") }, // 72.07000000000001%
            { "Sodium chloride 0.9% IV (Venetoclax hydration)", new ValueWithNote("35804617", "Venetoclax monotherapy") }, // 72.07000000000001%
            { "Sodium chloride 0.9% 500ml IV infusion", new ValueWithNote("37561927", "No induction therapy") }, // 72.07000000000001%
            { "Nivolumab 28 day (adjuvant)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 72.02%
            { "75276617ALE1001 JNJ75276617 capsules (Trial)", new ValueWithNote("37557288", "COG ANBL0532 Regimen B") }, // 72.02%
            { "Nivolumab 14 day (EAMS)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 72.02%
            { "Ferinject 1000mg IVI", new ValueWithNote("37558763", "D-FEC+Bev (bevacizumab-onbe)") }, // 72.02%
            { "Paracetamol oral", new ValueWithNote("912023", "Azacitidine oral monotherapy") }, // 72.02%
            { "Hydroxycarbamide (alternate day dosing)", new ValueWithNote("35806663", "ACVBP, dose-adjusted") }, // 71.97%
            { "Stem cells", new ValueWithNote("35806477", "Samarium-153 with stem cell support") }, // 71.97%
            { "Nivolumab 28 day (metastatic)", new ValueWithNote("35803677", "Nivolumab monotherapy") }, // 71.97%
            { "OptiMATe Arm A MATRIx (Trial)", new ValueWithNote("35804413", "MATRix") }, // 71.92%
            { "Methylene blue", new ValueWithNote("35807019", "M-TIP") }, // 71.88%
            { "TIMEPOINT (MNA-3521-012) MTL-CEBPA Pembrolizumab (Trial)", new ValueWithNote("37557196", "Carboplatin, nab-Paclitaxel, Durvalumab, Tremelimumab") }, // 71.83%
            { "CANC3947 TITAN Open label (NCRN Trial)", new ValueWithNote("37557202", "COG ACNS0331 Standard Dose CSRT with Standard Volume Boost") }, // 71.83%
            { "TALAPRO-2 (C3441021) part 2 (Trial)", new ValueWithNote("37557517", "Talquetamab monotherapy") }, // 71.73%
            { "Pembrolizumab 21 day (adjuvant)", new ValueWithNote("35803678", "Pembrolizumab monotherapy") }, // 71.67999999999999%
            { "Pamidronate 30 28 day", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 71.67999999999999%
            { "PEACOCC (Trial)", new ValueWithNote("35805808", "BEACOPP") }, // 71.67999999999999%
            { "ARCADIAN Atovaquone (Trial)", new ValueWithNote("35806663", "ACVBP, dose-adjusted") }, // 71.67999999999999%
            { "Calcium levofolinate 175mg", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 71.67999999999999%
            { "Bevacizumab 21 day (neurofibromatosis 2)", new ValueWithNote("35803688", "Bevacizumab monotherapy") }, // 71.63000000000001%
            { "EORTC-HGUS 62113-55115 (Trial)", new ValueWithNote("37557411", "COG D9602 Subgroup B Clinical Group 3 protocol") }, // 71.63000000000001%
            { "IMP-MEL IMM60 (Trial)", new ValueWithNote("35806087", "R-MACLO/R-IVAM") }, // 71.58%
            { "Mouth and bowel support", new ValueWithNote("35803468", "Best supportive care") }, // 71.58%
            { "Sodium chloride IV infusion", new ValueWithNote("37561927", "No induction therapy") }, // 71.58%
            { "WINGMEN Xentuzumab (Trial)", new ValueWithNote("1525175", "Zanubrutinib and Obinutuzumab") }, // 71.58%
            { "OCTOVA Arm C (NCRN Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 71.58%
            { "ALL Intensification / CNS prophylaxis (25-60 years)", new ValueWithNote("35805753", "EPOCH, dose-escalated") }, // 71.53%
            { "Ibrutinib (CLL) >3years progression free interval (no comorbidities) cycles 1-3", new ValueWithNote("35804581", "Ibrutinib monotherapy") }, // 71.53%
            { "BEP 3 day adjuvant", new ValueWithNote("35807017", "Accelerated BEP") }, // 71.53%
            { "ALL Consolidation cycle 3 days 29-42 (25-60 years)", new ValueWithNote("1525160", "No consolidation") }, // 71.48%
            { "1480-0001 (IV STING) BI 1703880 Ezabenlimab (Trial)", new ValueWithNote("1524841", "COG AAML0531 arm B (Gemtuzumab)") }, // 71.48%
            { "Pembrolizumab 21 day (relapsed/metastatic)", new ValueWithNote("37556846", "Pembrolizumab and RT") }, // 71.44%
            { "Brightline-1 Doxorubicin (Trial)", new ValueWithNote("35804134", "Doxorubicin monotherapy") }, // 71.44%
            { "STP938-101 STP938 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 71.39%
            { "Codeine Phosphate po", new ValueWithNote("35806330", "PCP") }, // 71.34%
            { "IMG-7289-CTP-102 IMG-7289 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 71.34%
            { "ALL Consolidation cycle 3 days 1-28 (25-60 years)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 71.34%
            { "Potassium chloride 20mmol IV", new ValueWithNote("37556855", "7+5i and Quinine") }, // 71.34%
            { "Rituximab weekly (ITP)", new ValueWithNote("37561187", "RT-PEPC; Maintenance (rituximab-rixi)") }, // 71.28999999999999%
            { "Lamivudine", new ValueWithNote("35102008", "FOLFIRI (L-Leucovorin)") }, // 71.19%
            { "Levomepromazine", new ValueWithNote("35805108", "PMitCEBO") }, // 71.19%
            { "DREAMM-9 Belantamab mafodontin Rd maintenance (every 3rd cycle) (Trial)", new ValueWithNote("911956", "Belantamab mafodotin monotherapy") }, // 71.19%
            { "RMS 2005 IVADo cycles 1-3 (off study)", new ValueWithNote("35806087", "R-MACLO/R-IVAM") }, // 71.14%
            { "Chlorphenamine 7 days", new ValueWithNote("37556855", "7+5i and Quinine") }, // 71.14%
            { "ACE-CL-001 ACP-196 Cohort 2b (NCRN Trial)", new ValueWithNote("37557288", "COG ANBL0532 Regimen B") }, // 71.14%
            { "Darbepoeitin 3 weekly", new ValueWithNote("37556850", "7+3a") }, // 71.09%
            { "MOTION Vismeltinib (Trial)", new ValueWithNote("35806140", "Binimetinib monotherapy") }, // 71.09%
            { "Azithromycin prophylaxis (250mg) 3 x week 28 day", new ValueWithNote("35806104", "Clarithromycin monotherapy") }, // 71.09%
            { "Atropine sulphate (5 days)", new ValueWithNote("35803590", "Placebo") }, // 71.04%
            { "Isoniazid", new ValueWithNote("912006", "Ampicillin, Metronidazole, Bismuth") }, // 71.0%
            { "Ranitidine premed IV", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 70.95%
            { "Azithromycin prophylaxis (250mg) 3 x week 21 day", new ValueWithNote("912049", "Clarithromycin, Tetracycline, PPI, Bismuth") }, // 70.95%
            { "Pentamidine prophylaxis IV", new ValueWithNote("37560804", "Intrahepatic floxuridine and IV 5-FU") }, // 70.75%
            { "EP 166/50 daypt", new ValueWithNote("912046", "PGT") }, // 70.7%
            { "BEP 3 day metastatic (NSCGT) daypt", new ValueWithNote("37557411", "COG D9602 Subgroup B Clinical Group 3 protocol") }, // 70.65%
            { "Magnesium sulphate 8mmol IV", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 70.65%
            { "75276617ALE1001 JNJ75276617 (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 70.61%
            { "M16-191 Transform-1 (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 70.61%
            { "DREAMM-9 Belantamab mafodontin VRd (every 3rd cycle from cycle 4) (Trial)", new ValueWithNote("37561906", "mFOLFOX6, Bevacizumab-tnjn, Panitumumab") }, // 70.56%
            { "BEP 3 day adjuvant (BEP 111)", new ValueWithNote("35807017", "Accelerated BEP") }, // 70.56%
            { "CCS1477-02 CCS1477 3 days on 4 days off (Trial)", new ValueWithNote("37557200", "COG A9961 regimen") }, // 70.50999999999999%
            { "Cimetidine premed", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 70.50999999999999%
            { "CC-92480-MM-001 20/28 schedule (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 70.50999999999999%
            { "Metoclopramide 21 day", new ValueWithNote("37561927", "No induction therapy") }, // 70.46%
            { "EORTC-HGUS 62113-55115 (open label) (Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 70.46%
            { "ACE-CL-001 ACP-196 Cohort 8 (NCRN Trial)", new ValueWithNote("35804050", "Mini-Hyper-CVD/MA and Inotuzumab ozogamicin") }, // 70.41%
            { "NUTIDE 302 NUFOX Q1W (Trial)", new ValueWithNote("35803521", "7 plus 3d (low-dose)") }, // 70.41%
            { "RP3-301 RP3 (Trial)", new ValueWithNote("35806665", "R-CP") }, // 70.41%
            { "RATinG Lenzilumab (stage 1) (support) (Trial)", new ValueWithNote("37557973", "Lenvatinib and Atezolizumab") }, // 70.41%
            { "CA290-841 (CONFIRM) (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 70.36%
            { "Magnesium sulphate 20mmol IV", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 70.26%
            { "Ipi-Glio Arm A (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 70.26%
            { "Ondansetron for oral Vinorelbine days 1, 8 and 15", new ValueWithNote("912254", "Vinorelbine and Hydrocortisone") }, // 70.17%
            { "CC-4047-MM-013 (Commercial trial)", new ValueWithNote("905639", "AALL0932 delayed intensification") }, // 70.17%
            { "LUD2015-005 Post surgery Cohorts C and D (NCRN Trial)", new ValueWithNote("37561336", "EC-D and Bevacizumab-tnjn") }, // 70.12%
            { "BEP 5 day metastatic (NSCGT) daypt", new ValueWithNote("35807017", "Accelerated BEP") }, // 70.12%
            { "RMS 2005 IVADo IVA cycles 4-9 (off study)", new ValueWithNote("35806087", "R-MACLO/R-IVAM") }, // 70.12%
            { "Anaphylaxis prophylaxis", new ValueWithNote("35803590", "Placebo") }, // 70.07%
            { "STAMPEDE K SoC & Metformin (NCRN Trial)", new ValueWithNote("37557256", "Sitagliptin, Sirolimus, Tacrolimus") }, // 70.07%
            { "CEeDD SonoTran particles cohorts 1, 2B and 3B (Trial)", new ValueWithNote("35804820", "Sonidegib monotherapy") }, // 69.97%
            { "D9571C00001 AZD7789 (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 69.97%
            { "Allopurinol for prevention of tumour lysis syndrome", new ValueWithNote("35803535", "Mercaptopurine monotherapy") }, // 69.97%
            { "Aciclovir prophylaxis 200mg bd", new ValueWithNote("37559231", "R-ACVBP (rituximab-blit)") }, // 69.92%
            { "NX-1607-101 NX-1607 (Trial)", new ValueWithNote("35804774", "FOLFOX 7/sLV5FU2") }, // 69.92%
            { "AMM cycles 5-6 MAP (off study)", new ValueWithNote("1524959", "N5/N6") }, // 69.92%
            { "CCS1477-02 CCS1477-MB 4 days on 3 days off (Trial)", new ValueWithNote("35803521", "7 plus 3d (low-dose)") }, // 69.92%
            { "75276617ALE1001 JNJ75276617 tablets (Trial)", new ValueWithNote("35803521", "7 plus 3d (low-dose)") }, // 69.87%
            { "FLAMSA-BU >=60 years (off study)", new ValueWithNote("35806663", "ACVBP, dose-adjusted") }, // 69.82000000000001%
            { "Ciprofloxacin for prophylaxis", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 69.82000000000001%
            { "ACELARATE Acelarin infusion bag (NCRN Trial)", new ValueWithNote("35804050", "Mini-Hyper-CVD/MA and Inotuzumab ozogamicin") }, // 69.82000000000001%
            { "Lorazepam", new ValueWithNote("35803590", "Placebo") }, // 69.78%
            { "PlasmaMATCH Cohort E (NCRN Trial)", new ValueWithNote("1525042", "COG AALL0932 protocol for standard-risk") }, // 69.78%
            { "Pamidronate 30 28 day (support)", new ValueWithNote("35806301", "Zoledronic acid therapy") }, // 69.78%
            { "RomiCar (NCRN Trial)", new ValueWithNote("37559354", "CFAR (rituximab-pvvr)") }, // 69.78%
            { "Oral cryotherapy", new ValueWithNote("912023", "Azacitidine oral monotherapy") }, // 69.73%
            { "CLARITY (NCRN Trial)", new ValueWithNote("37561927", "No induction therapy") }, // 69.63000000000001%
            { "ST101-101 ST101 expansion (Trial)", new ValueWithNote("37557464", "International ALL Trial consolidation") }, // 69.58%
            { "Atropine sulphate", new ValueWithNote("35803590", "Placebo") }, // 69.48%
            { "Metoclopramide 14 day", new ValueWithNote("37557200", "COG A9961 regimen") }, // 69.48%
            { "PIANO (NCRN Trial)", new ValueWithNote("35806285", "CPR") }, // 69.38%
            { "RADAR Arm B A2VD (Trial)", new ValueWithNote("1524843", "COG AAML1031 arm A (low-risk)") }, // 69.34%
            { "Hydroxycarbamide support", new ValueWithNote("35805376", "Hydroxyurea monotherapy") }, // 69.34%
            { "Colestyramine", new ValueWithNote("912097", "Stilbamidine and Urethane") }, // 69.34%
            { "RP2-001-18 re-initiation of RP2 (Trial)", new ValueWithNote("37559454", "R-CP (rituximab-pvvr)") }, // 69.28999999999999%
            { "Micafungin", new ValueWithNote("35806584", "mFOLFIRINOX") }, // 69.28999999999999%
            { "OptiMATe Arm B MATRIx (Trial)", new ValueWithNote("35804413", "MATRix") }, // 69.28999999999999%
            { "Fosaprepitant IV", new ValueWithNote("35102004", "FOLFOX4 (L-Leucovorin)") }, // 69.24%
            { "AIDA", new ValueWithNote("35803458", "HAA") }, // 69.24%
            { "APMM 2 cycles (MAP) (off study)", new ValueWithNote("35805070", "FEAM, then auto HSCT") }, // 69.14%
            { "Loperamide", new ValueWithNote("35806828", "Flutamide, Leuprolide, RT") }, // 69.14%
            { "RP2-001-18 re-initiation of RP2 (support) (Trial)", new ValueWithNote("35806665", "R-CP") }, // 69.14%
            { "LOGIC2; Run in (early phase trial)", new ValueWithNote("35805753", "EPOCH, dose-escalated") }, // 69.08999999999999%
            { "OptiMATe Arm B R-MTX pre-phase (Trial)", new ValueWithNote("37559371", "MT-R (rituximab-pvvr)") }, // 69.08999999999999%
            { "OVM-200-100 OVM-200 (Trial)", new ValueWithNote("35806299", "VMP, then Rd") }, // 68.99%
            { "Metoclopramide 28 day", new ValueWithNote("37561927", "No induction therapy") }, // 68.89999999999999%
            { "LATITUDE (NCRN 433) Open label extension phase (NCRN Trial)", new ValueWithNote("37561726", "ECOG-ACRIN E1910 protocol with blinatumomab; Consolidation cycle 3 (rituximab-pvvr)") }, // 68.89999999999999%
            { "Hydroxycarbamide initiation", new ValueWithNote("35803683", "RT, then Carmustine") }, // 68.85%
            { "Magnesium support", new ValueWithNote("35803468", "Best supportive care") }, // 68.85%
            { "MOTION Vimseltinib (Trial)", new ValueWithNote("35805106", "PACEBOM") }, // 68.85%
            { "ROMAZA cohorts -2, -1, 1 and 2 (NCRN Trial)", new ValueWithNote("37557284", "COG ACNS0332 Regimen C") }, // 68.75%
            { "Anaphylaxis treatment", new ValueWithNote("37561927", "No induction therapy") }, // 68.65%
            { "NX-5948-301 NX-5948 (Trial)", new ValueWithNote("905639", "AALL0932 delayed intensification") }, // 68.65%
            { "RPL-001-16 re-initiation (support) (Trial)", new ValueWithNote("37557286", "COG ANBL 0032 Regimen A") }, // 68.65%
            { "Metoclopramide 7 day", new ValueWithNote("37557200", "COG A9961 regimen") }, // 68.60000000000001%
            { "RXC004/0001 run in (Trial)", new ValueWithNote("35805456", "TC, then IE, VDoxoC, VEC") }, // 68.55%
            { "Loratadine", new ValueWithNote("35803590", "Placebo") }, // 68.55%
            { "Cetirizine 28 days", new ValueWithNote("35806376", "Isotretinoin monotherapy") }, // 68.55%
            { "Cetirizine 7 days", new ValueWithNote("37556851", "7+3d and Azacitidine") }, // 68.51%
            { "ATTAINMENT Module 1 MDX-124 (Trial)", new ValueWithNote("37557286", "COG ANBL 0032 Regimen A") }, // 68.51%
            { "Ondansetron 12 days prn", new ValueWithNote("37561927", "No induction therapy") }, // 68.51%
            { "Movicol", new ValueWithNote("35806434", "CAP (Platinol)") }, // 68.46%
            { "KEYNOTE-867 (MK3475-867) (Trial)", new ValueWithNote("35803521", "7 plus 3d (low-dose)") }, // 68.36%
            { "Metoclopramide 3 day", new ValueWithNote("37557200", "COG A9961 regimen") }, // 68.16%
            { "High emetic risk ondanestron weekly cisplatin", new ValueWithNote("37556999", "Cisplatin, Tirapazamine, RT") }, // 68.07%
            { "Pyridoxine 50mg", new ValueWithNote("37556925", "Dacarbazine, Interferon alfa-2b, Tamoxifen") }, // 68.07%
            { "Famotidine", new ValueWithNote("37556935", "Fluorouracil, Levamisole, RT") }, // 68.02%
            { "Euro Ewing 2012 IE/VC (off study)", new ValueWithNote("35805450", "VDC/IE") }, // 68.02%
            { "Aciclovir prophylaxis 200mg tds", new ValueWithNote("37557285", "COG ACNS0332 Regimen D") }, // 67.97%
            { "Entecavir", new ValueWithNote("35804771", "FOLFIRINOX") }, // 67.92%
            { "Hydroxycarbamide", new ValueWithNote("37556920", "Dacarbazine and Dactinomycin") }, // 67.86999999999999%
            { "Nystatin", new ValueWithNote("912006", "Ampicillin, Metronidazole, Bismuth") }, // 67.86999999999999%
            { "Palonosetron IV", new ValueWithNote("35804757", "FOLFOX4") }, // 67.77%
            { "KEYNOTE-867 (MK3475-867-00) (Trial)", new ValueWithNote("37557259", "COG AHEP0731 protocol F") }, // 67.72%
            { "Calcium carbonate Vitamin D", new ValueWithNote("1525213", "D-EC") }, // 67.63%
            { "Ibandronic acid", new ValueWithNote("35804381", "R-CODOX-M/R-IVAC") }, // 67.58%
            { "Aciclovir-prophylaxis", new ValueWithNote("35102008", "FOLFIRI (L-Leucovorin)") }, // 67.58%
            { "Ondansetron metoclopramide 1 day", new ValueWithNote("37557200", "COG A9961 regimen") }, // 67.53%
            { "Ondansetron metoclopramide", new ValueWithNote("35803590", "Placebo") }, // 67.38%
            { "Furosemide PO 1 day", new ValueWithNote("37557200", "COG A9961 regimen") }, // 67.29%
            { "Famotidine premed", new ValueWithNote("912005", "Ampicillin and Omeprazole") }, // 67.14%
            { "Ondansetron metoclopramide days 1, 8 and 15", new ValueWithNote("35805355", "5-FU and Leucovorin, then 5-FU, Leucovorin, RT, then 5-FU and Leucovorin") }, // 66.94%
            { "ALL Maintenance (25-60 years)", new ValueWithNote("35804424", "Nordic Regimen, older patients") }, // 66.85%
            { "RP3-301 RP3 (support) (Trial)", new ValueWithNote("35806665", "R-CP") }, // 66.64999999999999%
            { "Levofloxacin prophylaxis 28 days", new ValueWithNote("37561927", "No induction therapy") }, // 66.60000000000001%
            { "CEDAR Enadenotucirev loading (Trial)", new ValueWithNote("37561927", "No induction therapy") }, // 66.5%
            { "Dexrazoxane (cardiotoxicity)", new ValueWithNote("35806578", "Doxorubicin and Streptozocin") }, // 66.16%
            { "ANIMATE (CA209-445) (Trial)", new ValueWithNote("35803590", "Placebo") }, // 66.16%
            { "Low emetic risk prochlorperazine", new ValueWithNote("912002", "Amoxicillin and Omemprazole") }, // 66.02%
            { "Sodium chloride 0.9% IV ambulatory infusor", new ValueWithNote("35805765", "No induction") }, // 65.92%
            { "Epaderm Emollient", new ValueWithNote("35806439", "MVP (Vindesine)") }, // 65.92%
            { "Fluconazole prophylaxis", new ValueWithNote("35806852", "Ketoconazole and Hydrocortisone") }, // 65.86999999999999%
            { "Ondansetron metoclopramide 5 days", new ValueWithNote("37557200", "COG A9961 regimen") }, // 65.82000000000001%
            { "PICC line pack", new ValueWithNote("35807044", "PAC") }, // 65.77%
            { "MUK nine b RD (SC) maintenance (Trial)", new ValueWithNote("35806142", "BHD") }, // 65.72%
            { "Cyclizine", new ValueWithNote("1525128", "Doxycycline-CyBorD") }, // 65.48%
            { "COMICE (Trial)", new ValueWithNote("35805123", "DICE") }, // 65.42999999999999%
            { "High emetic rsk ondansetron metoclopramide days 1, 8 and 15", new ValueWithNote("912002", "Amoxicillin and Omemprazole") }, // 64.99000000000001%
            { "High emetic risk ondansetron metoclopramide 5 days", new ValueWithNote("912002", "Amoxicillin and Omemprazole") }, // 64.94%
            { "Lorazepam daily", new ValueWithNote("35803590", "Placebo") }, // 64.84%
            { "Olanzapine", new ValueWithNote("35804338", "ECT") }, // 64.84%
            { "Rasburicase", new ValueWithNote("37556867", "Dacarbazine, Fotemustine, Interferon alfa-2b") }, // 64.75%
            { "Ondansetron day 1 oral premedication", new ValueWithNote("35803590", "Placebo") }, // 64.64999999999999%
            { "Moderate emetic risk ondansetron metoclopramide 5 days", new ValueWithNote("912002", "Amoxicillin and Omemprazole") }, // 64.64999999999999%
            { "Moderate emetic risk ondansetron 1 day", new ValueWithNote("35803590", "Placebo") }, // 64.60000000000001%
            { "Moderate emetic risk ondansetron liquids 1 day", new ValueWithNote("35803590", "Placebo") }, // 64.55%
            { "Moderate emetic risk ondansetron 3.5 days", new ValueWithNote("35803590", "Placebo") }, // 64.5%
            { "Moderate emetic risk ondansetron 5 days", new ValueWithNote("35803590", "Placebo") }, // 64.45%
            { "Darbepoeitin weekly", new ValueWithNote("35805784", "DEP") }, // 64.31%
            { "Moderate emetic risk ondansetron 1.5 days", new ValueWithNote("35803590", "Placebo") }, // 64.31%
            { "High emetic risk ondansetron 5 days", new ValueWithNote("912002", "Amoxicillin and Omemprazole") }, // 64.16%
            { "High emetic risk ondansetron 2 days", new ValueWithNote("35803590", "Placebo") }, // 64.16%
            { "High emetic risk ondansetron 1.5 days", new ValueWithNote("37561927", "No induction therapy") }, // 64.16%
            { "High emetic risk ondansetron 1 day", new ValueWithNote("35803590", "Placebo") }, // 64.16%
            { "Moderate emetic risk ondansetron 1 day weekly", new ValueWithNote("35803590", "Placebo") }, // 64.16%
            { "Paracetamol soluble", new ValueWithNote("37557474", "mFOLFIRINOX (no folinic acid)") }, // 64.16%
            { "Moderate emetic risk ondansetron metoclopramide 1 day", new ValueWithNote("35803590", "Placebo") }, // 64.16%
            { "Moderate emetic risk ondansetron metoclopramide days 1, 8 and 15", new ValueWithNote("905741", "Melphalan flufenamide and Dexamethasone") }, // 64.11%
            { "High emetic risk ondansetron 3 days", new ValueWithNote("912002", "Amoxicillin and Omemprazole") }, // 64.05999999999999%
            { "Low emetic risk domperidone", new ValueWithNote("35805108", "PMitCEBO") }, // 64.05999999999999%
            { "High emetic risk ondansetron metoclopramide 1 day", new ValueWithNote("1524952", "SJMB-96 Protocol High Risk") }, // 63.870000000000005%
            { "Colesevelam", new ValueWithNote("35803998", "BeEAM") }, // 63.77%
            { "Moderate emetic risk ondansetron liquids", new ValueWithNote("35803590", "Placebo") }, // 63.67%
            { "High emetic risk ondansetron liquids", new ValueWithNote("1524952", "SJMB-96 Protocol High Risk") }, // 63.57000000000001%
            { "High emetic risk ondansetron days 1, 8 and 15", new ValueWithNote("1524952", "SJMB-96 Protocol High Risk") }, // 63.53%
            { "AMADEUS (Trial)", new ValueWithNote("35804054", "International ALL Trial") }, // 62.45%
            { "Diprobase", new ValueWithNote("37557291", "ddA-ddT-ddC") }, // 62.21%
            { "Mesna IV", new ValueWithNote("37557079", "4i+7") }, // 61.18%
        };

    public string[] ColumnNotes => new string[] {};
}