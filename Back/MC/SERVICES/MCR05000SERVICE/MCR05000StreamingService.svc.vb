Imports System.ServiceModel.Channels
Imports R_Common
Imports MCR05000Back
Imports MCR05000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR05000StreamingService" in code, svc and config file together.
Public Class MCR05000StreamingService
    Implements IMCR05000StreamingService


    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IMCR05000StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New MCR05000Cls
        Dim poParam As New MCR05000DTO
        Dim loRtnList As New List(Of MCR05000ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEnckey = R_Utility.R_GetStreamingContext("cEncKey")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR05000ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Sub Dummy() Implements IMCR05000StreamingService.Dummy

    End Sub
End Class
