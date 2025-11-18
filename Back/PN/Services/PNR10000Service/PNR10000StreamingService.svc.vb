Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR10000Back
Imports PNR10000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR10000StreamingService" in code, svc and config file together.
Public Class PNR10000StreamingService
    Implements IPNR10000StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNR10000StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PNR10000CLS
        Dim poParam As New PNR10000DTO
        Dim loRtnTemp As List(Of PNR10000ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStatusFlag = R_Utility.R_GetStreamingContext("cStatusFlag")
                .cOption = R_Utility.R_GetStreamingContext("cOption")
                .cOptionCode = R_Utility.R_GetStreamingContext("cOptionCode")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR10000ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR10000Back.PNR10000DTO)) Implements IPNR10000StreamingService.Dummy

    End Sub
End Class
