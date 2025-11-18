Imports R_Common
Imports R_BackEnd
Imports LNT00500Back
Imports System.ServiceModel.Channels
Imports LNT00500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00500StreamingService" in code, svc and config file together.
Public Class LNT00500StreamingService
    Implements ILNT00500StreamingService

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00500Back.LNT00500Dto)) Implements ILNT00500StreamingService.Dummy

    End Sub

    Public Function getCmbTransaction() As System.ServiceModel.Channels.Message Implements ILNT00500StreamingService.getCmbTransaction
        Dim loRtn As New List(Of LNT00500StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New LNT00500Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00500Dto
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With
            loRtn = loCls.getCmbTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTransaction")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getTransList() As System.ServiceModel.Channels.Message Implements ILNT00500StreamingService.getTransList
        Dim loRtn As New List(Of LNT00500StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New LNT00500Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00500Dto
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With
            loRtn = loCls.getTransList(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

End Class
