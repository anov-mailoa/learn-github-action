Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR09100Back
Imports PNR09100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR09100StreamingService" in code, svc and config file together.
Public Class PNR09100StreamingService
    Implements IPNR09100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR09100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR09100Cls
        Dim poParam As New PNR09100Dto
        Dim loRtnTemp As List(Of PNR09100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPunishmentList = R_Utility.R_GetStreamingContext("cPunishmentList")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR09100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR09100Back.PNR09100Dto)) Implements IPNR09100StreamingService.Dummy

    End Sub
End Class
