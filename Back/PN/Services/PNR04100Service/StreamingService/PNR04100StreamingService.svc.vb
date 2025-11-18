Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR04100Back
Imports PNR04100Common

Public Class PNR04100StreamingService
    Implements IPNR04100StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR04100StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR04100Cls
        Dim loRtnTemp As List(Of PNR04100ReportDto)
        Dim loParam As New PNR04100GridDto
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCutOfDate = R_Utility.R_GetStreamingContext("cCutOfDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR04100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

End Class
