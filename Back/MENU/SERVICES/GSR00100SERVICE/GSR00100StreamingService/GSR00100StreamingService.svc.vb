Imports R_Common
Imports R_BackEnd
Imports GSR00100Back
Imports GSR00100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01500StreamingService" in code, svc and config file together.
Public Class GSR00100StreamingService
    Implements IGSR00100StreamingService

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSR00100Back.GSR00100DTO)) Implements IGSR00100StreamingService.Dummy

    End Sub

    Public Function getReportList() As System.ServiceModel.Channels.Message Implements IGSR00100StreamingService.getReportList
        Dim loEx As New R_Exception
        Dim loCls As New GSR00100Cls
        Dim loRtnTemp As List(Of GSR00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            loRtnTemp = loCls.getReportList
            loList = R_Utility.R_GetChunkData(Of GSR00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IGSR00100StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New GSR00100Cls
        Dim loRtnTemp As List(Of GSR00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSR00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CREPORT_ID = R_Utility.R_GetStreamingContext("CREPORT_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_IDS = R_Utility.R_GetStreamingContext("CEMPLOYEE_IDS")
                .CENCRYPTION_KEY = R_Utility.R_GetStreamingContext("CENCRYPTION_KEY")
            End With

            loRtnTemp = loCls.getReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of GSR00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
