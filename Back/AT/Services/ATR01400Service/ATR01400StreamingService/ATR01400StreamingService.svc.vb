Imports R_BackEnd
Imports R_Common
Imports ATR01400Back
Imports ATR01400Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01400StreamingService" in code, svc and config file together.
Public Class ATR01400StreamingService
    Implements IATR01400StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR01400StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR01400Cls
        Dim poParam As New ATR01400DTO
        Dim loRtnList As New List(Of ATR01400ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodFrom = R_Utility.R_GetStreamingContext("cPeriodFrom")
                .cPeriodTo = R_Utility.R_GetStreamingContext("cPeriodTo")
                .cLeaveTypeList = R_Utility.R_GetStreamingContext("cLeaveTypeList")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01400ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
