Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR10200Back
Imports PNR10200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR10200StreamingService" in code, svc and config file together.
Public Class PNR10200StreamingService
    Implements IPNR10200StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNR10200StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR10200CLS
        Dim poParam As New PNR10200DTO
        Dim loRtnTemp As List(Of PNR10200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR10200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR10200Back.PNR10200DTO)) Implements IPNR10200StreamingService.Dummy

    End Sub

    Public Function getExcelData() As System.ServiceModel.Channels.Message Implements IPNR10200StreamingService.getExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PNR10200CLS
        Dim poParam As New PNR10200DTO
        Dim loRtnTemp As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .LPRINT_HEADER = R_Utility.R_GetStreamingContext("LPRINT_HEADER")
            End With

            loRtnTemp = loCls.getExcelData(poParam)
            Dim loRtnList1 As New List(Of DataTable)
            loRtnList1.Add(loRtnTemp)

            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
