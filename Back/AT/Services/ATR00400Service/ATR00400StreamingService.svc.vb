Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00400Back
Imports ATR00400Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00400StreamingService" in code, svc and config file together.
Public Class ATR00400StreamingService
    Implements IATR00400StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00400StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00400CLS
        Dim poParam As New ATR00400DTO
        Dim loRtnList As List(Of ATR00400StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .iAllOvertime = R_Utility.R_GetStreamingContext("iAllOvertime")
                .cOvertimeType = R_Utility.R_GetStreamingContext("cOvertimeType")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .iAllStatus = R_Utility.R_GetStreamingContext("iAllStatus")
                .cTransStatus = R_Utility.R_GetStreamingContext("cTransStatus")
                .iAllEmployee = R_Utility.R_GetStreamingContext("iAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReportType = R_Utility.R_GetStreamingContext("cReportType")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
