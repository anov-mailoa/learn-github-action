Imports R_Common
Imports R_BackEnd
Imports LNM00300Back
Imports System.ServiceModel.Channels
Imports LNM00300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM0300Service_Streaming" in code, svc and config file together.
Public Class LNM0300Service_Streaming
    Implements ILNM0300Service_Streaming

    Public Function getDataGrid() As System.ServiceModel.Channels.Message Implements ILNM0300Service_Streaming.getDataGrid
        Dim loRtn As New List(Of LNM00300Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNM00300Cls
        Dim loEx As New R_Exception
        Dim poParam As String
        Dim loList As List(Of Byte())

        Try
            poParam = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getDataGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of LNM00300Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class
