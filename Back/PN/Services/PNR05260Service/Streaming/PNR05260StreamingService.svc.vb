Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR05260Back
Imports PNR05260Common

Public Class PNR05260StreamingService
    Implements IPNR05260StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR05260StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05260BackCls
        Dim loParam As New PNR05260GridDto
        Dim loRtnTemp As List(Of PNR05260ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
            loParam.cOrderBy = R_Utility.R_GetStreamingContext("cOrderBy")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05260ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
