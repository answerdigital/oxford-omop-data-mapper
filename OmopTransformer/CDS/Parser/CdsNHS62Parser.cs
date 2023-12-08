using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.CDS.Parser;

internal class CdsNhs62Parser
{
    private readonly ILogger<CdsNhs62Parser> _logger;

    public CdsNhs62Parser(ILogger<CdsNhs62Parser> logger)
    {
        _logger = logger;
    }

    public IReadOnlyCollection<Message> ReadFile(string path, CancellationToken cancellationToken)
    {
        List<Message> messages = new();

        Stopwatch stopwatch = Stopwatch.StartNew();

        using var reader = new StreamReader(path);

        Message message = new();

        while (reader.ReadLine() is { } row)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var messageType = row.Substring(0, 2);

            if (messageType == "01")
            {
                var cdsVersion = row.SubstringOrNullOffByOne(38, 6);

                if (cdsVersion != "NHS6-2")
                {
                    _logger.LogCritical("Unsupported CDS version. {0}.", cdsVersion);
                    throw new NotSupportedException($"Unsupported CDS file version {cdsVersion}. Supported version is NHS6-2.");
                }

                if (message.Line01 != null)
                {
                    messages.Add(message);
                        
                    message = new();
                }

                message.Line01 = ParseLine01(row);
            }
            else if (messageType == "02")
            {
                message.Line02.Add(ParseLine02(row));
            }
            else if (messageType == "03")
            {
                message.Line03.Add(ParseLine03(row));
            }
            else if (messageType == "04")
            {
                message.Line04.Add(ParseLine04(row));
            }
            else if (messageType == "05")
            {
                message.Line05.Add(ParseLine05(row));
            }
            else if (messageType == "06")
            {
                message.Line06.Add(ParseLine06(row));
            }
            else if (messageType == "07")
            {
                message.Line07.Add(ParseLine07(row));
            }
            else if (messageType == "08")
            {
                message.Line08.Add(ParseLine08(row));
            }
            else if (messageType == "09")
            {
                message.Line09.Add(ParseLine09(row));
            }
            else if (messageType == "10")
            {
                message.Line10.Add(ParseLine10(row));
            }
            else if (messageType == "11")
            {
                message.Line11.Add(ParseLine11(row));
            }
            else if (messageType == "12")
            {
                message.Line12.Add(ParseLine12(row));
            }
        }

        stopwatch.Stop();

        return messages;
    }

    private static Line01 ParseLine01(string row)
    {
        return new Line01(row)
        {
            LineId = row.SubstringOrNullOffByOne(1, 2),
            RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
            CdsVersion = row.SubstringOrNullOffByOne(38, 6),
            CdsRecordType = row.SubstringOrNullOffByOne(44, 3),
            CdsBulkReplacementGroup = row.SubstringOrNullOffByOne(47, 3),
            CdsProtocolIdentifier = row.SubstringOrNullOffByOne(50, 3),
            CdsUniqueIdentifier = row.SubstringOrNullOffByOne(53, 35),
            CDSUpdateType = row.SubstringOrNullOffByOne(88, 1),
            CdsApplicableDate = row.SubstringOrNullOffByOne(89, 8),
            CdsApplicableTime = row.SubstringOrNullOffByOne(97, 6),
            CDSExtractDate = row.SubstringOrNullOffByOne(103, 8),
            CDSExtractTime = row.SubstringOrNullOffByOne(111, 6),
            CDSReportPeriodStartDate = row.SubstringOrNullOffByOne(117, 8),
            CDSReportPeriodEndDate = row.SubstringOrNullOffByOne(125, 8),
            CDSCensusDate = row.SubstringOrNullOffByOne(133, 8),
            CDSActivityDate = row.SubstringOrNullOffByOne(141, 8),
            CDSSenderIdentity = row.SubstringOrNullOffByOne(149, 12),
            CDSPrimaryRecipientIdentity = row.SubstringOrNullOffByOne(161, 12),
            CDSCopyRecipientIdentity1 = row.SubstringOrNullOffByOne(173, 12),
            CDSCopyRecipientIdentity2 = row.SubstringOrNullOffByOne(185, 12),
            CDSCopyRecipientIdentity3 = row.SubstringOrNullOffByOne(197, 12),
            CDSCopyRecipientIdentity4 = row.SubstringOrNullOffByOne(209, 12),
            CDSCopyRecipientIdentity5 = row.SubstringOrNullOffByOne(221, 12),
            CDSCopyRecipientIdentity6 = row.SubstringOrNullOffByOne(233, 12),
            CDSCopyRecipientIdentity7 = row.SubstringOrNullOffByOne(245, 12),
            UniqueBookingReferenceNumberConverted = row.SubstringOrNullOffByOne(257, 12),
            PatientPathwayIdentifier = row.SubstringOrNullOffByOne(269, 20),
            OrganisationCodeofthePatientPathwayIdentifier = row.SubstringOrNullOffByOne(289, 12),
            ReferralToTreatmentPeriodStatus = row.SubstringOrNullOffByOne(301, 2),
            WaitingTimeMeasurementType = row.SubstringOrNullOffByOne(303, 2),
            ReferralToTreatmentPeriodStartDate = row.SubstringOrNullOffByOne(305, 8),
            ReferralToTreatmentPeriodEndDate = row.SubstringOrNullOffByOne(313, 8),
            LocalPatientID = row.SubstringOrNullOffByOne(321, 10),
            OrganisationCodeLocalPatientID = row.SubstringOrNullOffByOne(331, 12),
            NHSNumberStatusIndicator = row.SubstringOrNullOffByOne(343, 2),
            NHSNumber = row.SubstringOrNullOffByOne(345, 10),
            WithheldFlag = row.SubstringOrNullOffByOne(355, 1),
            WithheldIdentityReason = row.SubstringOrNullOffByOne(356, 2),
            DateofBirth = row.SubstringOrNullOffByOne(358, 8),
            PatientNameType = row.SubstringOrNullOffByOne(366, 2),
            PatientFullName = row.SubstringOrNullOffByOne(368, 70),
            PatientRequestedName = row.SubstringOrNullOffByOne(438, 70),
            PatientTitle = row.SubstringOrNullOffByOne(508, 35),
            PatientForename = row.SubstringOrNullOffByOne(543, 35),
            PatientSurname = row.SubstringOrNullOffByOne(578, 35),
            PatientNameSuffix = row.SubstringOrNullOffByOne(613, 35),
            PatientInitials = row.SubstringOrNullOffByOne(648, 35),
            PatientAddressType = row.SubstringOrNullOffByOne(683, 2),
            PatientUnstructuredAddress = row.SubstringOrNullOffByOne(685, 175),
            PatientAddressStructured1 = row.SubstringOrNullOffByOne(860, 35),
            PatientAddressStructured2 = row.SubstringOrNullOffByOne(895, 35),
            PatientAddressStructured3 = row.SubstringOrNullOffByOne(930, 35),
            PatientAddressStructured4 = row.SubstringOrNullOffByOne(965, 35),
            PatientAddressStructured5 = row.SubstringOrNullOffByOne(1000, 35),
            Postcode = row.SubstringOrNullOffByOne(1035, 8),
            OrganisationCodeResidenceResponsibility = row.SubstringOrNullOffByOne(1043, 12),
            PersonCurrentGenderCode = row.SubstringOrNullOffByOne(1055, 1),
            CarerSupportIndicator = row.SubstringOrNullOffByOne(1056, 2),
            EthnicCategory = row.SubstringOrNullOffByOne(1058, 2),
            PersonMaritalStatus = row.SubstringOrNullOffByOne(1060, 1),
            BirthWeight = row.SubstringOrNullOffByOne(1061, 4),
            LiveStillBirthIndicator = row.SubstringOrNullOffByOne(1065, 1),
            TotalPreviousPregnancies = row.SubstringOrNullOffByOne(1066, 2),
            CommissioningSerialNumber = row.SubstringOrNullOffByOne(1068, 6),
            NHSServiceAgreementLineNumber = row.SubstringOrNullOffByOne(1074, 10),
            ProvidersReferenceNumber = row.SubstringOrNullOffByOne(1084, 17),
            CommissionersReferenceNumber = row.SubstringOrNullOffByOne(1101, 17),
            OrganisationCodeCodeofProvider = row.SubstringOrNullOffByOne(1118, 12),
            OrganisationCodeCodeofCommissioner = row.SubstringOrNullOffByOne(1130, 12),
            NHSServiceAgreementChangeDate = row.SubstringOrNullOffByOne(1142, 8),
            GeneralMedicalPractitionerSpecified = row.SubstringOrNullOffByOne(1150, 8),
            GPPracticeRegistered = row.SubstringOrNullOffByOne(1158, 12),
            ReferrerCode = row.SubstringOrNullOffByOne(1170, 8),
            ReferringOrganisationCode = row.SubstringOrNullOffByOne(1178, 12),
            DirectAccessReferralIndicator = row.SubstringOrNullOffByOne(1190, 1),
            ConsultantCode = row.SubstringOrNullOffByOne(1191, 8),
            CareProfessionalMainSpecialtyCode = row.SubstringOrNullOffByOne(1199, 3),
            ActivityTreatmentFunctionCode = row.SubstringOrNullOffByOne(1202, 3),
            LocalSubSpecialtyCode = row.SubstringOrNullOffByOne(1205, 8)
        };
    }

    private static Line02 ParseLine02(string row)
    {
        var line02 =
            new Line02(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                LineCount = row.SubstringOrNullOffByOne(38, 3),
                DiagnosisSchemeInUse = row.SubstringOrNullOffByOne(41, 2)
            };

        var diagnoses =
            GetRepeating(
                    row,
                    43 - 1,
                    7,
                    50,
                    Diagnosis.FromText)
            .ToList();

        if (diagnoses.Any())
        {
            if (line02.LineCount == "001")
            {
                line02.PrimaryDiagnosis = diagnoses[0];
                line02.SecondaryDiagnoses = diagnoses.Skip(1).ToList();
            }
            else
            {
                line02.SecondaryDiagnoses = diagnoses;
            }
        }

        return line02;
    }

    private static Line03 ParseLine03(string row)
    {
        var line03 =
            new Line03(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                LineCount = row.SubstringOrNullOffByOne(38, 3),
                ProcedureSchemeInUse = row.SubstringOrNullOffByOne(41, 2)
            };

        var procedures =
            GetRepeating(
                    row,
                    43 - 1,
                    42,
                    50,
                    Procedure.FromText)
                .ToList();

        if (procedures.Any())
        {
            if (line03.LineCount == "001")
            {
                line03.PrimaryProcedure = procedures[0];
                line03.SecondaryProcedures = procedures.Skip(1).ToList();
            }
            else
            {
                line03.SecondaryProcedures = procedures;
            }
        }

        return line03;
    }

    private static Line04 ParseLine04(string row)
    {
        var line04 =
            new Line04(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                LineCount = row.SubstringOrNullOffByOne(38, 3),
                LocationClass = row.SubstringOrNullOffByOne(41, 2),
                SiteCodeofTreatment = row.SubstringOrNullOffByOne(43, 12),
                ActivityLocationType = row.SubstringOrNullOffByOne(55, 3),
                IntendedClinicalCareIntensityCode = row.SubstringOrNullOffByOne(58, 2),
                AgeGroupIntended = row.SubstringOrNullOffByOne(60, 1),
                SexofPatientsCode = row.SubstringOrNullOffByOne(61, 1),
                WardNightPeriodAvailabilityCode = row.SubstringOrNullOffByOne(62, 1),
                WardDayPeriodAvailabilityCode = row.SubstringOrNullOffByOne(63, 1),
                StartDateWardStay = row.SubstringOrNullOffByOne(64, 8),
                StartTimeWardStay = row.SubstringOrNullOffByOne(72, 6),
                EndDateWardStay = row.SubstringOrNullOffByOne(78, 8),
                EndTimeWardStay = row.SubstringOrNullOffByOne(86, 6),
                WardSecurityLevel = row.SubstringOrNullOffByOne(92, 1),
                WardCode = row.SubstringOrNullOffByOne(93, 12),
                ClinicCode = row.SubstringOrNullOffByOne(105, 12),
                DetainedandorLongTermPsychiatricCensusDate = row.SubstringOrNullOffByOne(117, 8)
            };
        return line04;
    }

    private static Line05 ParseLine05(string row)
    {
        var line05 =
            new Line05(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                HospitalProviderSpellNumber = row.SubstringOrNullOffByOne(38, 12),
                AdministrativeCategoryCode = row.SubstringOrNullOffByOne(50, 2),
                PatientClassification = row.SubstringOrNullOffByOne(52, 1),
                AdmissionMethodCode = row.SubstringOrNullOffByOne(53, 2),
                SourceofAdmissionCode = row.SubstringOrNullOffByOne(55, 2),
                StartDateHospitalProviderSpell = row.SubstringOrNullOffByOne(57, 8),
                StartTimeHospitalProviderSpell = row.SubstringOrNullOffByOne(65, 6),
                AgeOnAdmission = row.SubstringOrNullOffByOne(71, 3),
                AmbulanceIncidentNumber = row.SubstringOrNullOffByOne(74, 20),
                OrganisationCodeConveyingAmbulanceTrust = row.SubstringOrNullOffByOne(94, 12),
                DischargeDestinationCode = row.SubstringOrNullOffByOne(106, 2),
                DischargeMethod = row.SubstringOrNullOffByOne(108, 1),
                DischargeReadyDateHospitalProviderSpell = row.SubstringOrNullOffByOne(109, 8),
                DischargeDateHospitalProviderSpell = row.SubstringOrNullOffByOne(117, 8),
                DischargeTimeHospitalProviderSpell = row.SubstringOrNullOffByOne(125, 6),
                DischargetoHospitalatHomeServiceIndicator = row.SubstringOrNullOffByOne(131, 1),
                MentalHealthActLegalClassificationCodeonAdmission = row.SubstringOrNullOffByOne(132, 2),
                MentalHealthActLegalStatusClassificationCodeAtCensusDate = row.SubstringOrNullOffByOne(134, 2),
                DateDetentionCommenced = row.SubstringOrNullOffByOne(136, 8),
                AgeAtCensus = row.SubstringOrNullOffByOne(144, 3),
                DurationOfCareToPsychiatricCensusDate = row.SubstringOrNullOffByOne(147, 5),
                DurationOfDetention = row.SubstringOrNullOffByOne(152, 5),
                MentalHealthAct2007MentalCategory = row.SubstringOrNullOffByOne(157, 1),
                StatusOfPatientIncludedInThePsychiatricCensusCode = row.SubstringOrNullOffByOne(158, 1),
                EpisodeNumber = row.SubstringOrNullOffByOne(159, 2),
                LastEpisodeinSpellIndicator = row.SubstringOrNullOffByOne(161, 1),
                OperationStatusCode = row.SubstringOrNullOffByOne(162, 1),
                NeonatalLevelofCare = row.SubstringOrNullOffByOne(163, 1),
                FirstRegularDayNightAdmission = row.SubstringOrNullOffByOne(164, 1),
                PsychiatricPatientStatus = row.SubstringOrNullOffByOne(165, 1),
                EpisodeStartDate = row.SubstringOrNullOffByOne(166, 8),
                EpisodeStartTime = row.SubstringOrNullOffByOne(174, 6),
                EpisodeEndDate = row.SubstringOrNullOffByOne(180, 8),
                EpisodeEndTime = row.SubstringOrNullOffByOne(188, 6),
                AgeAtCDSActivityDate = row.SubstringOrNullOffByOne(194, 3),
                MultiProfessionalorMultidisciplinaryConsultationIndicationCode =
                    row.SubstringOrNullOffByOne(197, 1),
                RehabilitationAssessmentTeamType = row.SubstringOrNullOffByOne(198, 1),
                LengthofStayAdjustmentRehabilitation = row.SubstringOrNullOffByOne(199, 3),
                LengthOfStayAdjustmentSpecialistPalliativeCare = row.SubstringOrNullOffByOne(202, 3),
                DurationofElectiveWait = row.SubstringOrNullOffByOne(290, 4),
                IntendedManagement = row.SubstringOrNullOffByOne(294, 1),
                DecidedtoAdmitDate = row.SubstringOrNullOffByOne(295, 8),
                EarliestReasonableOfferDate = row.SubstringOrNullOffByOne(303, 8)
            };

        line05.OverseasVisitors =
            GetRepeating(
                    row,
                    205 - 1,
                    17,
                    5,
                    OverseasVisitor.FromText)
                .ToList();
        return line05;
    }

    private static Line06 ParseLine06(string row)
    {
        var line06 =
            new Line06(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                LineCount = row.SubstringOrNullOffByOne(38, 3),
                CriticalCareTypeID = row.SubstringOrNullOffByOne(41, 2),
                CriticalCareLocalIdentifier = row.SubstringOrNullOffByOne(43, 8),
                CriticalCareStartDate = row.SubstringOrNullOffByOne(51, 8),
                CriticalCareStartTime = row.SubstringOrNullOffByOne(59, 6),
                CriticalCareUnitFunction = row.SubstringOrNullOffByOne(65, 2),
                GestationLengthAtDelivery = row.SubstringOrNullOffByOne(67, 2),
                UnitBedConfiguration = row.SubstringOrNullOffByOne(69, 2),
                CriticalCareAdmissionSource = row.SubstringOrNullOffByOne(71, 2),
                CriticalCareSourceLocation = row.SubstringOrNullOffByOne(73, 2),
                CriticalCareAdmissionType = row.SubstringOrNullOffByOne(75, 2),
                AdvancedRespiratorySupportDays = row.SubstringOrNullOffByOne(77, 3),
                BasicRespiratorySupportsDays = row.SubstringOrNullOffByOne(80, 3),
                AdvancedCardiovascularSupportDays = row.SubstringOrNullOffByOne(83, 3),
                BasicCardiovascularSupportDays = row.SubstringOrNullOffByOne(86, 3),
                RenalSupportDays = row.SubstringOrNullOffByOne(89, 3),
                NeurologicalSupportDays = row.SubstringOrNullOffByOne(92, 3),
                GastroIntestinalSupportDays = row.SubstringOrNullOffByOne(95, 3),
                DermatologicalSupportDays = row.SubstringOrNullOffByOne(98, 3),
                LiverSupportDays = row.SubstringOrNullOffByOne(101, 3),
                OrganSupportMaximum = row.SubstringOrNullOffByOne(104, 2),
                CriticalCareLevel2Days = row.SubstringOrNullOffByOne(106, 3),
                CriticalCareLevel3Days = row.SubstringOrNullOffByOne(109, 3),
                CriticalCareDischargeDate = row.SubstringOrNullOffByOne(112, 8),
                CriticalCareDischargeTime = row.SubstringOrNullOffByOne(120, 6),
                CriticalCareDischargeReadyDate = row.SubstringOrNullOffByOne(126, 8),
                CriticalCareDischargeReadyTime = row.SubstringOrNullOffByOne(134, 6),
                CriticalCareDischargeStatus = row.SubstringOrNullOffByOne(140, 2),
                CriticalCareDischargeDestination = row.SubstringOrNullOffByOne(142, 2),
                CriticalCareDischargeLocation = row.SubstringOrNullOffByOne(144, 2)
            };
        return line06;
    }

    private static Line07 ParseLine07(string row)
    {
        var line07 =
            new Line07(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                CriticalCareCount = row.SubstringOrNullOffByOne(38, 3),
                LineCount = row.SubstringOrNullOffByOne(41, 3),
                ActivityDateCriticalCare = row.SubstringOrNullOffByOne(44, 8),
                PersonWeight = row.SubstringOrNullOffByOne(52, 7),
                CriticalCareActivityCode1 = row.SubstringOrNullOffByOne(59, 2),
                CriticalCareActivityCode2 = row.SubstringOrNullOffByOne(61, 2),
                CriticalCareActivityCode3 = row.SubstringOrNullOffByOne(63, 2),
                CriticalCareActivityCode4 = row.SubstringOrNullOffByOne(65, 2),
                CriticalCareActivityCode5 = row.SubstringOrNullOffByOne(67, 2),
                CriticalCareActivityCode6 = row.SubstringOrNullOffByOne(69, 2),
                CriticalCareActivityCode7 = row.SubstringOrNullOffByOne(71, 2),
                CriticalCareActivityCode8 = row.SubstringOrNullOffByOne(73, 2),
                CriticalCareActivityCode9 = row.SubstringOrNullOffByOne(75, 2),
                CriticalCareActivityCode10 = row.SubstringOrNullOffByOne(77, 2),
                CriticalCareActivityCode11 = row.SubstringOrNullOffByOne(79, 2),
                CriticalCareActivityCode12 = row.SubstringOrNullOffByOne(81, 2),
                CriticalCareActivityCode13 = row.SubstringOrNullOffByOne(83, 2),
                CriticalCareActivityCode14 = row.SubstringOrNullOffByOne(85, 2),
                CriticalCareActivityCode15 = row.SubstringOrNullOffByOne(87, 2),
                CriticalCareActivityCode16 = row.SubstringOrNullOffByOne(89, 2),
                CriticalCareActivityCode17 = row.SubstringOrNullOffByOne(91, 2),
                CriticalCareActivityCode18 = row.SubstringOrNullOffByOne(93, 2),
                CriticalCareActivityCode19 = row.SubstringOrNullOffByOne(95, 2),
                CriticalCareActivityCode20 = row.SubstringOrNullOffByOne(97, 2),
                HighCostDrugsOPCS1 = row.SubstringOrNullOffByOne(99, 4),
                HighCostDrugsOPCS2 = row.SubstringOrNullOffByOne(103, 4),
                HighCostDrugsOPCS3 = row.SubstringOrNullOffByOne(107, 4),
                HighCostDrugsOPCS4 = row.SubstringOrNullOffByOne(111, 4),
                HighCostDrugsOPCS5 = row.SubstringOrNullOffByOne(115, 4),
                HighCostDrugsOPCS6 = row.SubstringOrNullOffByOne(119, 4),
                HighCostDrugsOPCS7 = row.SubstringOrNullOffByOne(123, 4),
                HighCostDrugsOPCS8 = row.SubstringOrNullOffByOne(127, 4),
                HighCostDrugsOPCS9 = row.SubstringOrNullOffByOne(131, 4),
                HighCostDrugsOPCS10 = row.SubstringOrNullOffByOne(135, 4),
                HighCostDrugsOPCS11 = row.SubstringOrNullOffByOne(139, 4),
                HighCostDrugsOPCS12 = row.SubstringOrNullOffByOne(143, 4),
                HighCostDrugsOPCS13 = row.SubstringOrNullOffByOne(147, 4),
                HighCostDrugsOPCS14 = row.SubstringOrNullOffByOne(151, 4),
                HighCostDrugsOPCS15 = row.SubstringOrNullOffByOne(155, 4),
                HighCostDrugsOPCS16 = row.SubstringOrNullOffByOne(159, 4),
                HighCostDrugsOPCS17 = row.SubstringOrNullOffByOne(163, 4),
                HighCostDrugsOPCS18 = row.SubstringOrNullOffByOne(167, 4),
                HighCostDrugsOPCS19 = row.SubstringOrNullOffByOne(171, 4),
                HighCostDrugsOPCS20 = row.SubstringOrNullOffByOne(175, 4)
            };
        return line07;
    }

    private static Line12 ParseLine12(string row)
    {
        var line12 =
            new Line12(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                LineCount = row.SubstringOrNullOffByOne(38, 3),
                InvestigationSchemeinUse = row.SubstringOrNullOffByOne(41, 2)
            };

        var investigations =
            GetRepeating(
                    row,
                    43 - 1,
                    6,
                    51,
                    text => text)
                .ToList();

        if (investigations.Any())
        {
            if (line12.LineCount == "001")
            {
                line12.PrimaryInvestigation = investigations[0];
                line12.SecondaryInvestigations = investigations.Skip(1).ToList();
            }
            else
            {
                line12.SecondaryInvestigations = investigations;
            }
        }

        return line12;
    }

    private static Line08 ParseLine08(string row)
    {
        var line08 =
            new Line08(row)
            {
                LineId = row.SubstringOrNullOffByOne(1, 2),
                RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
                NumberofBabies = row.SubstringOrNullOffByOne(38, 1),
                FirstAntenatalAssessmentDate = row.SubstringOrNullOffByOne(39, 8),
                GeneralMedicalPractitionerAntenatalCare = row.SubstringOrNullOffByOne(47, 8),
                GeneralMedicalPractitionerPracticeAntenatalCare = row.SubstringOrNullOffByOne(55, 12),
                LocationClass = row.SubstringOrNullOffByOne(67, 2),
                ActivityLocationType = row.SubstringOrNullOffByOne(69, 3),
                DeliveryPlaceTypeIntended = row.SubstringOrNullOffByOne(72, 1),
                DeliveryPlaceChangeReason = row.SubstringOrNullOffByOne(73, 1),
                AnaestheticDuringLabourDelivery = row.SubstringOrNullOffByOne(74, 1),
                AnaestheticGivenPostLabourDelivery = row.SubstringOrNullOffByOne(75, 1),
                GestationLengthLabourOnset = row.SubstringOrNullOffByOne(76, 2),
                LabourDeliveryOnsetMethod = row.SubstringOrNullOffByOne(78, 1),
                DeliveryDate = row.SubstringOrNullOffByOne(79, 8),
                AgeAtCDSActivityDate = row.SubstringOrNullOffByOne(87, 3),
                LocalPatientID = row.SubstringOrNullOffByOne(90, 10),
                OrganisationCodeLocalPatientID = row.SubstringOrNullOffByOne(100, 12),
                NHSNumberStatusIndicator = row.SubstringOrNullOffByOne(112, 2),
                NHSNumber = row.SubstringOrNullOffByOne(114, 10),
                WithheldFlag = row.SubstringOrNullOffByOne(124, 1),
                WithheldIdentityReason = row.SubstringOrNullOffByOne(125, 2),
                MotherBirthDate = row.SubstringOrNullOffByOne(127, 8),
                OverseasVisitorStatusAtCDSActivityDate = row.SubstringOrNullOffByOne(135, 1),
                PatientAddressType = row.SubstringOrNullOffByOne(136, 2),
                PatientUnstructuredAddress = row.SubstringOrNullOffByOne(138, 175),
                PatientStructured1 = row.SubstringOrNullOffByOne(313, 35),
                PatientStructured2 = row.SubstringOrNullOffByOne(348, 35),
                PatientStructured3 = row.SubstringOrNullOffByOne(383, 35),
                PatientStructured4 = row.SubstringOrNullOffByOne(418, 35),
                PatientStructured5 = row.SubstringOrNullOffByOne(453, 35),
                Postcode = row.SubstringOrNullOffByOne(488, 8),
                OrganisationCodeResidenceResponsibility = row.SubstringOrNullOffByOne(496, 12)
            };

        var birthDetails =
            GetRepeating(
                row,
                508 - 1,
                64,
                9,
                BirthDetails.FromText);

        line08.BirthDetails = birthDetails.ToList();
        return line08;
    }

    private static Line09 ParseLine09(string row)
    {
        return new Line09(row)
        {
            LineId = row.SubstringOrNullOffByOne(1, 2),
            RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
            AttendanceIdentifier = row.SubstringOrNullOffByOne(38, 12),
            AdministrativeCategoryCode = row.SubstringOrNullOffByOne(50, 2),
            AttendedOrDidNotAttendCode = row.SubstringOrNullOffByOne(52, 1),
            FirstAttendanceCode = row.SubstringOrNullOffByOne(53, 1),
            MedicalStaffTypeSeeingPatient = row.SubstringOrNullOffByOne(54, 2),
            OperationStatusCode = row.SubstringOrNullOffByOne(56, 1),
            OutcomeofAttendanceCode = row.SubstringOrNullOffByOne(57, 1),
            AppointmentDate = row.SubstringOrNullOffByOne(58, 8),
            AppointmentTime = row.SubstringOrNullOffByOne(66, 6),
            ExpectedDurationOfAppointment = row.SubstringOrNullOffByOne(72, 3),
            AgeAtCDSActivityDate = row.SubstringOrNullOffByOne(75, 3),
            OverseasVisitorStatusClassificationAtCDSActivityDate = row.SubstringOrNullOffByOne(78, 1),
            EarliestReasonableOfferDate = row.SubstringOrNullOffByOne(79, 8),
            EarliestClinicallyAppropriateDate = row.SubstringOrNullOffByOne(87, 8),
            ConsultationMediumUsed = row.SubstringOrNullOffByOne(95, 2),
            MultiProfessionalorMultidisciplinaryConsultationIndicationCode = row.SubstringOrNullOffByOne(97, 1),
            RehabilitationAssessmentTeamType = row.SubstringOrNullOffByOne(98, 1),
            PriorityTypeCode = row.SubstringOrNullOffByOne(99, 1),
            ServiceTypeRequestedCode = row.SubstringOrNullOffByOne(100, 1),
            SourceofReferralforOutpatients = row.SubstringOrNullOffByOne(101, 2),
            ReferralRequestReceivedDate = row.SubstringOrNullOffByOne(103, 8),
            LastDNAorPatientCancelledDate = row.SubstringOrNullOffByOne(111, 8)
        };
    }

    private static Line10 ParseLine10(string row)
    {
        return new Line10(row)
        {
            LineId = row.SubstringOrNullOffByOne(1, 2),
            RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
            EALAdmissionEntryNumber = row.SubstringOrNullOffByOne(38, 12),
            AdministrativeCategoryCode = row.SubstringOrNullOffByOne(50, 2),
            CountofDaysSuspended = row.SubstringOrNullOffByOne(52, 4),
            ElectiveAdmissionListStatus = row.SubstringOrNullOffByOne(56, 2),
            ElectiveAdmissionTypeCode = row.SubstringOrNullOffByOne(58, 2),
            IntendedManagementCode = row.SubstringOrNullOffByOne(60, 1),
            PriorityTypeCode = row.SubstringOrNullOffByOne(61, 1),
            IntendedProcedureStatusCode = row.SubstringOrNullOffByOne(62, 1),
            DecidedtoAdmitDate = row.SubstringOrNullOffByOne(63, 8),
            AgeAtCDSActivityDate = row.SubstringOrNullOffByOne(71, 3),
            OverseasVisitorStatusClassificationAtCDSActivityDate = row.SubstringOrNullOffByOne(74, 1),
            GuaranteedAdmissionDate = row.SubstringOrNullOffByOne(75, 8),
            LastDNAorCancelledDate = row.SubstringOrNullOffByOne(83, 8),
            WaitingListEntryLastReviewedDate = row.SubstringOrNullOffByOne(91, 8),
            AdmissionOfferOutcome = row.SubstringOrNullOffByOne(99, 1),
            OfferedforAdmissionDate = row.SubstringOrNullOffByOne(100, 8),
            EarliestReasonableOfferDate = row.SubstringOrNullOffByOne(108, 8),
            OriginalDecidedtoAdmitDate = row.SubstringOrNullOffByOne(116, 8),
            RemovalReasonCode = row.SubstringOrNullOffByOne(124, 1),
            RemovalDate = row.SubstringOrNullOffByOne(125, 8),
            SuspensionStartDate = row.SubstringOrNullOffByOne(133, 8),
            SuspensionEndDate = row.SubstringOrNullOffByOne(141, 8)
        };
    }

    private static Line11 ParseLine11(string row)
    {
        return new Line11(row)
        {
            LineId = row.SubstringOrNullOffByOne(1, 2),
            RecordConnectionIdentifier = row.SubstringOrNullOffByOne(3, 35),
            AttendanceNumber = row.SubstringOrNullOffByOne(38, 12),
            ArrivalModeCode = row.SubstringOrNullOffByOne(50, 1),
            AttendanceCategoryCode = row.SubstringOrNullOffByOne(51, 1),
            AttendanceDisposal = row.SubstringOrNullOffByOne(52, 2),
            IncidentLocationType = row.SubstringOrNullOffByOne(54, 2),
            PatientGroup = row.SubstringOrNullOffByOne(56, 2),
            SourceofReferral = row.SubstringOrNullOffByOne(58, 2),
            AEDepartmentType = row.SubstringOrNullOffByOne(60, 2),
            ArrivalDate = row.SubstringOrNullOffByOne(62, 8),
            ArrivalTime = row.SubstringOrNullOffByOne(70, 6),
            AgeAtCDSActivityDate = row.SubstringOrNullOffByOne(76, 3),
            OverseasVisitorStatusClassificationAtCDSActivityDate = row.SubstringOrNullOffByOne(79, 1),
            InitialAssessmentDate = row.SubstringOrNullOffByOne(80, 8),
            InitialAssessmentTime = row.SubstringOrNullOffByOne(88, 6),
            DateSeenforTreatment = row.SubstringOrNullOffByOne(94, 8),
            TimeSeenforTreatment = row.SubstringOrNullOffByOne(102, 6),
            AttendanceConclusionDate = row.SubstringOrNullOffByOne(108, 8),
            AttendanceConclusionTime = row.SubstringOrNullOffByOne(116, 6),
            DepartureDate = row.SubstringOrNullOffByOne(122, 8),
            DepartureTime = row.SubstringOrNullOffByOne(130, 6),
            AmbulanceIncidentNumber = row.SubstringOrNullOffByOne(136, 20),
            OrganisationCodeConveyingAmbulanceTrust = row.SubstringOrNullOffByOne(156, 12),
            AEStaffMemberCode = row.SubstringOrNullOffByOne(168, 3)
        };
    }

    private static IEnumerable<T> GetRepeating<T>(string text, int index, int size, int count, Func<string, T?> parse)
    {
        for (var i = 0; i < count; i++)
        {
            if ((index + size) >= text.Length)
            {
                yield break;
            }

            var record = parse(text.Substring(index, size));

            if (record == null)
                yield break;

            yield return record;

            index += size;
        }
    }
}