Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR05250Back
Imports PNR05250Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR05250StreamingService" in code, svc and config file together.
Public Class PNR05250StreamingService
    Implements IPNR05250StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR05250StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05250BackCLS
        Dim loParam As New PNR05250BackDTO
        Dim loRtnTemp As List(Of PNR05250ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05250ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PNR05250Back.PNR05250BackStreamingDTO), poParam As PNR05250Back.PNR05250BackDTO) Implements IPNR05250StreamingService.Dummy

    End Sub
End Class
