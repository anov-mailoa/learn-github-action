Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00300Back
Imports ATT00300Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00300StreamingService" in code, svc and config file together.
Public Class ATT00300StreamingService
    Implements IATT00300StreamingService
     
    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT00300StreamingService.getHistory
        Dim loRtn As New List(Of ATT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception
        Dim loParam As New ATT00300DTO
        Dim loChunk As New List(Of Byte())


        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loParam.cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")
            loRtn = loCls.getHistory(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPermission() As System.ServiceModel.Channels.Message Implements IATT00300StreamingService.getPermission
        Dim loRtn As New List(Of ATT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getPermission(pcCompId, pcUserId, pcLangId)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPermission")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getReason() As System.ServiceModel.Channels.Message Implements IATT00300StreamingService.getReason
        Dim loRtn As New List(Of CmbDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getReason(pcCompId)
            loChunk = R_Utility.R_GetChunkData(Of CmbDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getReason")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATT00300StreamingService.getEmployee
        Dim loRtn As New List(Of ATT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtn = loCls.getEmployee(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getLookUpEmployee() As System.ServiceModel.Channels.Message Implements IATT00300StreamingService.getLookUpEmployee
        Dim loRtn As New List(Of ATT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
                .cShiftCode = R_Utility.R_GetStreamingContext("cShiftCode")
            End With

            loRtn = loCls.getLookUpEmployee(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLookUpEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbShift() As System.ServiceModel.Channels.Message Implements IATT00300StreamingService.getCmbShift
        Dim loRtn As New List(Of ATT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
                .cShiftCode = R_Utility.R_GetStreamingContext("cShiftCode")
            End With

            loRtn = loCls.getCmbShift(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getCmbShift")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
