Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR02100Back
Imports ATR02100Common
Imports R_BackEnd 
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR02100StreamingService" in code, svc and config file together.
Public Class ATR02100StreamingService
    Implements IATR02100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR02100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR02100CLS
        Dim poParam As New ATR02100DTO
        Dim loRtnList As New List(Of ATR02100ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cAllWorkgroup = R_Utility.R_GetStreamingContext("cAllWorkgroup")
                .cWorkgroupList = R_Utility.R_GetStreamingContext("cWorkgroupList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR02100ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class
