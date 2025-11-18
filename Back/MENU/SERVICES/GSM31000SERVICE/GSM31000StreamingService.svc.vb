Imports R_Common
Imports GSI00100Back
Imports System.ServiceModel.Channels
Imports GSM31000Back
Imports GSM31000Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM31000StreamingService" in code, svc and config file together.
Public Class GSM31000StreamingService
    Implements IGSM31000StreamingService

    Public Function GetHistoryList() As System.ServiceModel.Channels.Message Implements IGSM31000StreamingService.GetHistoryList
        Dim loException As New R_Exception
        Dim loCls As New GSM31000Cls
        Dim loRtnList As New List(Of GSM31000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Dim poParam As New GSM31000DTO

        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtnList = loCls.GetHistoryList(poParam)

            loList = R_Utility.R_GetChunkData(Of GSM31000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetHistoryList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of GSM31000Back.GSM31000DTO)) Implements IGSM31000StreamingService.Dummy

    End Sub
End Class
