Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR10700Back
Imports ATR10700Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR10700StreamingService" in code, svc and config file together.
Public Class ATR10700StreamingService
    Implements IATR10700StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR10700StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR10700CLS
        Dim poParam As New ATR10700DTO
        Dim loRtnList As List(Of ATR10700ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR10700ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
