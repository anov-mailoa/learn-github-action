' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT00100StreamingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT00100Common
Imports PNT00100BACK
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class PNT00100StreamingService
    Implements IPNT00100StreamingService

    Public Function getCmbEmployeeType() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbEmployeeType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbEmployeeType(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbEmployeeType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbSalaryType() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbSalaryType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbSalaryType(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbSalaryType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbSubGrade() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbSubGrade
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cGrade = R_Utility.R_GetStreamingContext("cGrade")
            loRtn = loCls.getCmbSubGrade(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbSubGrade")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbTaxType() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbTaxType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbTaxType(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbTaxType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbBloodType() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbBloodType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO

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

    Public Function getCmbMarital() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbMarital
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO

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

    Public Function getCmbNationality() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbNationality
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO

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

    Public Function getCmbReligion() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbReligion
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO

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

    Public Function getCmbOwnership() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbOwnership
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO

        Try

            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbOwnership(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbOwnership")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getAdditionalInfo() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getAdditionalInfo
        Dim loRtnTemp As List(Of PNT00100AdditionalInfoStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT00100AdditionalInfoCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100AdditionalInfoDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cCreateBy = R_Utility.R_GetStreamingContext("cCreateBy")
            poParam.cUpdateBy = R_Utility.R_GetStreamingContext("cUpdateBy")
            poParam.dUpdateDate = R_Utility.R_GetStreamingContext("dUpdateDate")
            poParam.dCreateDate = R_Utility.R_GetStreamingContext("dCreateDate")

            loRtnTemp = loCls.getAdditionalInfo(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100AdditionalInfoStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAdditionalInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSalutation() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbSalutation
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO


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

    Public Function getCmbCategoryValue() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbCategoryValue
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNT00100AdditionalInfoCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100AdditionalInfoDTO

        Try

            poParam.cCategoryClass = R_Utility.R_GetStreamingContext("cCategoryClass")
            loRtn = loCls.getCmbCategoryValue(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbCategoryValue")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getFamilyData() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getFamilyData
        Dim loCls As New PNT00100FamilyDataCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100FamilyDataDTO
        Dim loRtnTemp As List(Of PNT00100FamilyDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.getFamilyData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100FamilyDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFamilyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmergencyData() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getEmergencyData
        Dim loCls As New PNT00100EmergencyDataCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100EmergencyDataDTO
        Dim loRtnTemp As List(Of PNT00100EmergencyDataStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getEmergencyData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100EmergencyDataStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmergencyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEducationData() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getEducationData
        Dim loCls As New PNT00100EducationCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100EducationDTO
        Dim loRtnTemp As List(Of PNT00100EducationStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getEducationData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100EducationStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEducationData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLanguage() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getLanguage
        Dim loCls As New PNT00100LanguageCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100LanguageGridDTO
        Dim loRtnTemp As List(Of PNT00100LanguageStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getLanguage(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100LanguageStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLanguage")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getWorkExp() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getWorkExp
        Dim loCls As New PNT00100WorkExpCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100WorkExpDTO
        Dim loRtnTemp As List(Of PNT00100WorkExpStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")

            loRtnTemp = loCls.getWorkExp(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100WorkExpStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getWorkExp")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDuplicate() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getDuplicate
        Dim loCls As New PNT00100DuplicateCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100DuplicateDTO
        Dim loRtnTemp As List(Of PNT00100DuplicateStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")

            loRtnTemp = loCls.getDuplicate(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100DuplicateStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDuplicate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getBankAccList() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getBankAccList
        Dim loCls As New PNT00100BankAccCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100BankAccGridDTO
        Dim loRtnTemp As List(Of PNT00100BankAccStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getBankAccList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100BankAccStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankAccList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCurrencyCode() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getCmbCurrencyCode
        Dim loCls As New PNT00100BankAccCLS
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNT00100BankAccStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loRtnTemp = loCls.getCmbCurrencyCode()
            loList = R_Utility.R_GetChunkData(Of PNT00100BankAccStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCurrencyCode")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParPNT00101 As System.Collections.Generic.List(Of PNT00100Back.PNT00100AdditionalInfoGridHeaderDTO), poParPNT00102 As System.Collections.Generic.List(Of PNT00100Back.PNT00100FamilyDataGridHeaderDTO), poParPNT00105 As System.Collections.Generic.List(Of PNT00100Back.PNT00100EducationGridHeaderDTO), poParPNT00108 As System.Collections.Generic.List(Of PNT00100Back.PNT00100WorkExpGridHeaderDTO), poParPNT00110 As System.Collections.Generic.List(Of PNT00100Back.PNT00100DuplicateGridDTO)) Implements IPNT00100StreamingService.Dummy

    End Sub

    Public Function getApplicantList() As System.ServiceModel.Channels.Message Implements IPNT00100StreamingService.getApplicantList
        Dim loCls As New PNT00100OfficialCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNT00100OfficialDTO
        Dim loRtnTemp As List(Of PNT00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getApplicantList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getApplicantList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
