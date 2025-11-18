Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00530Back
Imports ATR00530Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00530StreamingService" in code, svc and config file together.
Public Class ATR00530StreamingService
    Implements IATR00530StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00530StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00530CLS
        Dim poParam As New ATR00530DTO
        Dim loRtnList As List(Of ATR00530StreamingDTO)
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
            loList = R_Utility.R_GetChunkData(Of ATR00530StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
