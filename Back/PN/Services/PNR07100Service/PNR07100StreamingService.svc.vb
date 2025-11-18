Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR07100Common
Imports PNR07100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR07100StreamingService" in code, svc and config file together.
Public Class PNR07100StreamingService
    Implements IPNR07100StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR07100StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loParam As New PNR07100BackDTO
        Dim loCls As New PNR07100BackCLS
        Dim loRtnTemp As List(Of PNR07100ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .lBlackList = R_Utility.R_GetStreamingContext("lBlackList")
                .cReasonList = R_Utility.R_GetStreamingContext("cReasonList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR07100ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR07100Back.PNR07100BackDTO) Implements IPNR07100StreamingService.Dummy

    End Sub
End Class
