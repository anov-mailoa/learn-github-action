Imports System.ServiceModel.Channels
Imports ATR00800Back
Imports R_Common
Imports ATR00800Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00800StreamingService" in code, svc and config file together.
Public Class ATR00800StreamingService
    Implements IATR00800StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00800StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00800CLS
        Dim poParam As New ATR00800DTO
        Dim loRtnList As New List(Of ATR00800ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loChunk As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .lAllWorkgroup = R_Utility.R_GetStreamingContext("lAllWorkgroup")
                .cWorkgroupList = R_Utility.R_GetStreamingContext("cWorkgroupList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getReport(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATR00800ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLegend() As System.ServiceModel.Channels.Message Implements IATR00800StreamingService.getLegend
        Dim loException As New R_Exception
        Dim loCls As New ATR00800CLS
        Dim poParam As New ATR00800DTO
        Dim loRtnList As New List(Of ATR00800ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getLegend(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00800ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLegend")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
