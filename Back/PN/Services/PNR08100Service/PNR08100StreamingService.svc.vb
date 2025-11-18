Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR08100Back
Imports PNR08100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR08100StreamingService" in code, svc and config file together.
Public Class PNR08100StreamingService
    Implements IPNR08100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR08100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR08100Cls
        Dim poParam As New PNR08100Dto
        Dim loRtnTemp As List(Of PNR08100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cBondList = R_Utility.R_GetStreamingContext("cBondList")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR08100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGsbCodeDt() As System.ServiceModel.Channels.Message Implements IPNR08100StreamingService.getGsbCodeDt
        Dim loCls As New PNR08100Cls
        Dim poParam As New PNR08100Dto
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNR08100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                '.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getGsbCodeDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR08100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGsbCodeDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR08100Back.PNR08100Dto)) Implements IPNR08100StreamingService.Dummy

    End Sub
End Class
