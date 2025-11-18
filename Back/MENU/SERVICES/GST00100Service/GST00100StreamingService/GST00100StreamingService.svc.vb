Imports R_Common
Imports R_BackEnd
Imports GST00100Back
Imports GST00100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GST00100StreamingService" in code, svc and config file together.
Public Class GST00100StreamingService
    Implements IGST00100StreamingService

    Public Function getGridInbox() As System.ServiceModel.Channels.Message Implements IGST00100StreamingService.getGridInbox
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtnTemp As List(Of GST00100InboxGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getGridInbox(loParam)
            loList = R_Utility.R_GetChunkData(Of GST00100InboxGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridInbox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridOutbox() As System.ServiceModel.Channels.Message Implements IGST00100StreamingService.getGridOutbox
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtnTemp As List(Of GST00100InboxGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getGridOutbox(loParam)
            loList = R_Utility.R_GetChunkData(Of GST00100InboxGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridOutbox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridOutbox1() As System.ServiceModel.Channels.Message Implements IGST00100StreamingService.getGridOutbox1
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtnTemp As List(Of GST00100OutboxGrid2DTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getGridOutbox1(loParam)
            loList = R_Utility.R_GetChunkData(Of GST00100OutboxGrid2DTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridOutbox1")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridDraft() As System.ServiceModel.Channels.Message Implements IGST00100StreamingService.getGridDraft
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtnTemp As List(Of GST00100InboxGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getGridDraft(loParam)
            loList = R_Utility.R_GetChunkData(Of GST00100InboxGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridDraft")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of GST00100Back.GST00100InboxGridDTO), poPar2 As System.Collections.Generic.List(Of GST00100Back.GST00100OutboxGrid2DTO)) Implements IGST00100StreamingService.Dummy

    End Sub
End Class
