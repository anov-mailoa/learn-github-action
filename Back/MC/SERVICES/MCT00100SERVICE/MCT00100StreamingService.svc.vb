Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT00100Back
Imports MCT00100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT00100StreamingService" in code, svc and config file together.
Public Class MCT00100StreamingService
    Implements IMCT00100StreamingService

    Public Function GetMedicalClaimList() As System.ServiceModel.Channels.Message Implements IMCT00100StreamingService.GetMedicalClaimList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As List(Of MCT00100StreamingDTO)
        Dim loParam As New MCT00100HdDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtn = loCls.GetMedicalClaimList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalClaimList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetMedicalSubItemList() As System.ServiceModel.Channels.Message Implements IMCT00100StreamingService.GetMedicalSubItemList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As List(Of MCT00100StreamingDTO)
        Dim loParam As New MCT00100DtDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtn = loCls.GetMedicalSubItemList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalSubItemList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetCMBMedicalSubItem() As System.ServiceModel.Channels.Message Implements IMCT00100StreamingService.GetCMBMedicalSubItem
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As List(Of MCT00100StreamingDTO)
        Dim loParam As New MCT00100DtDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cItemId = R_Utility.R_GetStreamingContext("cItemId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtn = loCls.GetCMBMedicalSubItem(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCMBMedicalSubItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetCMBMedicalInstitution() As System.ServiceModel.Channels.Message Implements IMCT00100StreamingService.GetCMBMedicalInstitution
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As List(Of MCT00100StreamingDTO)
        Dim loParam As New MCT00100DtDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtn = loCls.GetCMBMedicalInstitution(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCMBMedicalInstitution")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poGridHd As MCT00100Back.MCT00100GridHdDTO, poGridDt As MCT00100Back.MCT00100GridDtDTO) Implements IMCT00100StreamingService.Dummy

    End Sub

    Public Function GetCMBMedicalItem() As System.ServiceModel.Channels.Message Implements IMCT00100StreamingService.GetCMBMedicalItem
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As List(Of MCT00100StreamingDTO)
        Dim loParam As New MCT00100HdDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cDateNow = R_Utility.R_GetStreamingContext("cDateNow")
            End With

            loRtn = loCls.GetCMBMedicalItem(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCMBMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetCMBCurrency() As System.ServiceModel.Channels.Message Implements IMCT00100StreamingService.GetCMBCurrency
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As List(Of MCT00100StreamingDTO)
        Dim loParam As New MCT00100HdDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cDateNow = R_Utility.R_GetStreamingContext("cDateNow")
            End With

            loRtn = loCls.GetCMBCurrency(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCMBCurrency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
