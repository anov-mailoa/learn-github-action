Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR10100Back
Imports PNR10100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR10100StreamingService" in code, svc and config file together.
Public Class PNR10100StreamingService
    Implements IPNR10100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR10100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR10100Cls
        Dim poParam As New PNR10100Dto
        Dim loRtnTemp As List(Of PNR10100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .nYearOfServiceFrom = R_Utility.R_GetStreamingContext("nYearOfServiceFrom")
                .nYearOfServiceTo = R_Utility.R_GetStreamingContext("nYearOfServiceTo")
                .cCutOfDate = R_Utility.R_GetStreamingContext("cCutOfDate")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR10100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR10100Back.PNR10100Dto)) Implements IPNR10100StreamingService.Dummy

    End Sub
End Class
