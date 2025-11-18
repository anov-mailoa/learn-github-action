Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR06100Back
Imports PNR06100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR06100StreamingService" in code, svc and config file together.
Public Class PNR06100StreamingService
    Implements IPNR06100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR06100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR06100Cls
        Dim poParam As New PNR06100Dto
        Dim loRtnTemp As List(Of PNR06100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cOptDevice = R_Utility.R_GetStreamingContext("cOptDevice")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR06100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR06100Back.PNR06100Dto)) Implements IPNR06100StreamingService.Dummy

    End Sub
End Class
