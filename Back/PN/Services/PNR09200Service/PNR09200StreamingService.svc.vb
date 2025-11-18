Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR09200Back
Imports PNR09200Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR09200StreamingService" in code, svc and config file together.
Public Class PNR09200StreamingService
    Implements IPNR09200StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR09200StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR09200Cls
        Dim poParam As New PNR09200Dto
        Dim loRtnTemp As List(Of PNR09200ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cAppreciationList = R_Utility.R_GetStreamingContext("cAppreciationList")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR09200ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPnmAppreciation() As System.ServiceModel.Channels.Message Implements IPNR09200StreamingService.getPnmAppreciation
        Dim loCls As New PNR09200Cls
        Dim poParam As New PNR09200Dto
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNR09200StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPnmAppreciation(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR09200StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmAppreciation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR09200Back.PNR09200Dto)) Implements IPNR09200StreamingService.Dummy

    End Sub
End Class
