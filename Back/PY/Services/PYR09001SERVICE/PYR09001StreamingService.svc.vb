Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR09001Back
Imports PYR09001Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR09001StreamingService" in code, svc and config file together.
Public Class PYR09001StreamingService
    Implements IPYR09001StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR09001StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR09001Cls
        Dim loRtnList As New List(Of PYR09001ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR09001DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CKPP_ID = R_Utility.R_GetStreamingContext("CKPP_ID")
                .CKLU_CODE = R_Utility.R_GetStreamingContext("CKLU_CODE")
                .CPERIODE_MULAI = R_Utility.R_GetStreamingContext("CPERIODE_MULAI")
                .CPERIODE_SELESAI = R_Utility.R_GetStreamingContext("CPERIODE_SELESAI")
                .CDASAR_PENGHASIL_BRUTO = R_Utility.R_GetStreamingContext("CDASAR_PENGHASIL_BRUTO")
                .CENCKEY = R_Utility.R_GetStreamingContext("CENCKEY")
                .CFORM_LAPORAN = R_Utility.R_GetStreamingContext("CFORM_LAPORAN")
            End With

            loRtnList = loCls.getReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR09001ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYR09001Back.PYR09001DTO)) Implements IPYR09001StreamingService.Dummy

    End Sub

    Public Function getMasaPajak() As System.ServiceModel.Channels.Message Implements IPYR09001StreamingService.getMasaPajak
        Dim loEx As New R_Exception
        Dim loCls As New PYR09001Cls
        Dim loRtnList As New List(Of PYR09001ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR09001DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CKPP_ID = R_Utility.R_GetStreamingContext("CKPP_ID")
            End With

            loRtnList = loCls.getMasaPajak(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR09001ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMasaPajak")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
