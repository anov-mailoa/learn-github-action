Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR08000Back
Imports MCR08000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR08000StreamingService" in code, svc and config file together.
Public Class MCR08000StreamingService
    Implements IMCR08000StreamingService

    Public Function getDataReport() As System.ServiceModel.Channels.Message Implements IMCR08000StreamingService.getDataReport
        Dim loException As New R_Exception
        Dim loCls As New MCR08000CLS
        Dim poParam As New MCR08000ReportDTO
        Dim loRtnList As New List(Of MCR08000StreamingReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cSortBy = R_Utility.R_GetStreamingContext("cSortBy")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getDataReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR08000StreamingReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class
