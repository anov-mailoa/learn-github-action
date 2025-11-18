Imports R_BackEnd
Imports R_Common
Imports PNT03200Common
Imports PNT03200Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200StreamingService" in code, svc and config file together.
Public Class PNT03200StreamingService
    Implements IPNT03200StreamingService

    Public Function getAdditionalInfo() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getAdditionalInfo
        Dim loRtnTemp As List(Of PNT03200AdditionalInfoStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200AdditionalInfoCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200AdditionalInfoDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getAdditionalInfo(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200AdditionalInfoStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAdditionalInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbBloodType() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbBloodType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT03200PersonalDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200PersonalDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbBloodType(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbBloodType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbEmployeeType() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbEmployeeType

    End Function

    Public Function getCmbMarital() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbMarital
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT03200PersonalDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200PersonalDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbMarital(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbMarital")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbNationality() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbNationality
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT03200PersonalDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200PersonalDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbNationality(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbNationality")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbReligion() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbReligion
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT03200PersonalDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200PersonalDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbReligion(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbReligion")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbIdentityType() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbIdentityType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT03200PersonalDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200PersonalDataDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbIdentityType(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbIdentityType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbSalutation() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbSalutation
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT03200PersonalDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200PersonalDataDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbSalutation(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbSalutation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getFamilyData() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getFamilyData
        Dim loRtnTemp As List(Of PNT03200FamilyDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200FamilyDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200FamilyDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cPersonalDate = R_Utility.R_GetStreamingContext("dDate")

            loRtnTemp = loCls.getFamilyData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200FamilyDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFamilyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEducationData() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getEducationData
        Dim loRtnTemp As List(Of PNT03200EducationDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200EducationDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200EducationDataDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getEducationData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200EducationDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEducationData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmergencyData() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getEmergencyData
        Dim loRtnTemp As List(Of PNT03200EmergencyDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200EmergencyDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200EmergencyDataDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getEmergencyData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200EmergencyDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmergencyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLanguageData() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getLanguageData
        Dim loRtnTemp As List(Of PNT03200LanguageDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200LanguagesDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200LanguageDataDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getLanguageData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200LanguageDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLanguageData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getWorkExp() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getWorkExp
        Dim loRtnTemp As List(Of PNT03200WorkExperienceStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200WorkExperienceCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200WorkExperienceDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getWorkExp(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200WorkExperienceStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getWorkExp")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLicenceData() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getLicenceData
        Dim loRtnTemp As List(Of PNT03200LicenceDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200LicenceDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200LicenceDataDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")

            loRtnTemp = loCls.getLicenceData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200LicenceDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLicenceData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getBankAccData() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getBankAccData
        Dim loRtnTemp As List(Of PNT03200AccountStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200BankAccDataCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200AccountDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            End With

            loRtnTemp = loCls.getBankAccList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200AccountStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankAccData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCurrencyCode() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getCmbCurrencyCode
        Dim loRtnTemp As List(Of PNT03200AccountStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200BankAccDataCls
        Dim loEx As New R_Exception

        Try

            loRtnTemp = loCls.getCmbCurrencyCode()
            loList = R_Utility.R_GetChunkData(Of PNT03200AccountStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCurrencyCode")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedical() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getMedical
        Dim loRtnTemp As List(Of PNT03200MedicalStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200MedicalCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200MedicalDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getMedical(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200MedicalStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedical")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalHistory() As System.ServiceModel.Channels.Message Implements IPNT03200StreamingService.getMedicalHistory
        Dim loRtnTemp As List(Of PNT03200MedicalHistoryStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03200MedicalHistoryCls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03200MedicalHistoryDTO

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getMedicalHistory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03200MedicalHistoryStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParPNT03200Additional As System.Collections.Generic.List(Of PNT03200Back.PNT03200AdditionalInfoGridDTO), poParPNT03200Family As System.Collections.Generic.List(Of PNT03200Back.PNT03200FamilyDataGridDTO), poParPNT03200EducationDataGrid As System.Collections.Generic.List(Of PNT03200Back.PNT03200EducationDataGridDTO), poParPNT03200WorkExpDataGrid As System.Collections.Generic.List(Of PNT03200Back.PNT03200WorkExperienceGridDTO), poParPNT03200LicenceDataGrid As System.Collections.Generic.List(Of PNT03200Back.PNT03200LicenceDataGridDTO)) Implements IPNT03200StreamingService.Dummy

    End Sub

    Public Sub Medical(poParPNT03200MedicalGrid As System.Collections.Generic.List(Of PNT03200Back.PNT03200MedicalGridDTO), poParPNT03200MedicalHistoryGrid As System.Collections.Generic.List(Of PNT03200Back.PNT03200MedicalHistoryGridDTO)) Implements IPNT03200StreamingService.Medical

    End Sub
End Class
