Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR04110Back
Imports PNR04110Common

Public Class PNR04110StreamingService
    Implements IPNR04110StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR04110StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR04110BackCls
        Dim loParam As New PNR04110BackGridDto
        Dim loRtnTemp As List(Of PNR04110BackReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR04110BackReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
