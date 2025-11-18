Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports PNM05200Common
Imports System.ServiceModel.Channels
Imports SIAPP_SERVICE_PN
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200StreamingService" in code, svc and config file together.

Public Class PNM05200StreamingService
    Implements IPNM05200StreamingService


    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getEmployee
        Dim loRtnTemp As List(Of PNM05200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200DTO


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cOfficialStatus = R_Utility.R_GetStreamingContext("cOfficialStatus")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
            End With

            loRtnTemp = loCls.getEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCategory() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getCategory
        Dim loRtnTemp As List(Of PNM05220StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05220Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05220DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cCategoryValue = R_Utility.R_GetStreamingContext("cCategoryValue")

            loRtnTemp = loCls.getCategory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05220StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCategory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPosition() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getPosition
        Dim loRtnTemp As List(Of PNM05230StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05230Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05230DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.getPosition(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05230StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmpType() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getEmpType
        Dim loRtnTemp As List(Of PNM05240StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05240Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05240DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.getEmpType(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05240StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTrainingHistory() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getTrainingHistory
        Dim loRtnTemp As List(Of PNM05250StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05250Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05250DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getTrainingHistory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05250StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrainingHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getBondAggreement() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getBondAggreement
        Dim loRtnTemp As List(Of PNM05260StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05260Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05260DTO

        Try

            'poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            'poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            'poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getBondAggreement(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05260StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBondAggreement")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAppreciation() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getAppreciation
        Dim loRtnTemp As List(Of PNM05270StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05270Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05270DTO

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getAppreciation(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05270StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAppreciation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPunishment() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getPunishment
        Dim loRtnTemp As List(Of PNM05280StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05280Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05280DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getPunishment(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05280StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPunishment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocumentInfoFacilities() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getDocumentInfoFacilities
        Dim loRtnTemp As List(Of PNM05290StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05290Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05290DTO

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            End With

            loRtnTemp = loCls.getDocumentInfoFacilities(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05290StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocumentInfoFacilities")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getInterface() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getInterface
        Dim loRtnTemp As List(Of PNM05300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05300Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05300DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cLoginId")
            poParam.dDate = R_Utility.R_GetStreamingContext("dDate")

            loRtnTemp = loCls.getInterface(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getInterface")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getFamilyData() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getFamilyData
        Dim loRtnTemp As List(Of PNM05200FamilyDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200FamilyDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200FamilyDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getFamilyData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200FamilyDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFamilyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmergencyData() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getEmergencyData
        Dim loRtnTemp As List(Of PNM05200EmergencyDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200EmergencyDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200EmergencyDataDTO

        Try

            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getEmergencyData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200EmergencyDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmergencyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getFormalEducation() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getFormalEducation
        Dim loRtnTemp As List(Of PNM05200FormalEducationStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200FormalEducationCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200FormalEducationDTO

        Try
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getFormalEducation(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200FormalEducationStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFormalEducation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLanguages() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getLanguages
        Dim loRtnTemp As List(Of PNM05200LanguageStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200LanguagesCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200LanguageDTO

        Try
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getLanguages(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200LanguageStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLanguages")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getWorkExperience() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getWorkExperience
        Dim loRtnTemp As List(Of PNM05200WorkExperienceStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200WorkExperienceCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200WorkExperienceDTO

        Try
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getWorkExperience(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200WorkExperienceStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getWorkExperience")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLicence() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getLicence
        Dim loRtnTemp As List(Of PNM05200LicenceStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200LicenceCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200LicenceDTO

        Try
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getLicence(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200LicenceStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLicence")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPrevTrainingHistory() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getPrevTrainingHistory
        Dim loRtnTemp As List(Of PNM05250StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05250Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05250DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getPrevTrainingHistory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05250StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPrevTrainingHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedical() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getMedical
        Dim loRtnTemp As List(Of PNM05200MedicalStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200MedicalCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200MedicalDTO


        Try
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getMedical(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200MedicalStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedical")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPersonalBank() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getPersonalBank
        Dim loRtnTemp As List(Of PNM05200PersonalBankStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200PersonalBankCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200PersonalBankDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            End With

            loRtnTemp = loCls.getPersonalBank(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200PersonalBankStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPersonalBank")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalHistory() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getMedicalHistory
        Dim loRtnTemp As List(Of PNM05200MedicalHistoryStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05200MedicalHistoryCls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05200MedicalHistoryDTO

        Try
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getMedicalHistory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05200MedicalHistoryStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridFacility() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getGridFacility
        Dim loRtnTemp As List(Of PNM05291StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05290Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05290DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            End With

            loRtnTemp = loCls.getGridFacility(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05291StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridFacility")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParPNM05200Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05200DTO), poParPNM05220Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05220GridDTO), poParPNM05230Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05230DTO), poParPNM05240 As System.Collections.Generic.List(Of PNM05200Back.PNM05240DTO), poParPNM05250Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05250GridDTO), poParPNM05260Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05260GridDTO), poParPNM05270Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05270GridDTO), poParPNM05280Grid As System.Collections.Generic.List(Of PNM05200Back.PNM05280GridDTO), poParPNM05200FamilyGrid As System.Collections.Generic.List(Of PNM05200Back.PNM05200FamilyDataGridDTO), poParPNM05200FormalEducationGrid As System.Collections.Generic.List(Of PNM05200Back.PNM05200FormalEducationGridDTO), poParPNM05200WorkExperienceGrid As System.Collections.Generic.List(Of PNM05200Back.PNM05200WorkExperienceGridDTO), poParPNM05200LicenceGrid As System.Collections.Generic.List(Of PNM05200Back.PNM05200LicenceGridDTO), poParPNM05200MedicalGrid As System.Collections.Generic.List(Of PNM05200Back.PNM05200MedicalGridDTO), poParPNM05200MedicalPhysicalStreaming As System.Collections.Generic.List(Of PNM05200Back.PNM05200MedicalPhysicalStreamingDTO), poParPNM05200MedicalDiseaseStreaming As System.Collections.Generic.List(Of PNM05200Back.PNM05200MedicalDiseaseStreamingDTO), poParPNM05200MedicalHistoryGrid As System.Collections.Generic.List(Of PNM05200Back.PNM05200MedicalHistoryGridDTO)) Implements IPNM05200StreamingService.Dummy

    End Sub

    Public Function getCmbCategory() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getCmbCategory
        Dim loRtnTemp As List(Of PNM05250StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05250Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05250DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbCategory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05250StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCategory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSubject() As System.ServiceModel.Channels.Message Implements IPNM05200StreamingService.getCmbSubject
        Dim loRtnTemp As List(Of PNM05250StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM05250Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM05250DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCatTrainingCode = R_Utility.R_GetStreamingContext("cCatTrainingCode")
            End With

            loRtnTemp = loCls.getCmbSubject(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05250StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbSubject")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
