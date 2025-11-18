' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR01110StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR01110Back
Imports PNR01110Common

Public Class PNR01110StreamingService
    Implements IPNR01110StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR01110StreamingService.GetReportData
        Dim loRtn As Message
        Dim loEx As New R_Exception
        Dim loCls As New PNR01110BackCLS
        Dim loRtnTemp As List(Of PNR01110ReportDTO)
        Dim loParam As New PNR01110BackDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR01110ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR01110Back.PNR01110BackDTO) Implements IPNR01110StreamingService.Dummy

    End Sub
End Class
