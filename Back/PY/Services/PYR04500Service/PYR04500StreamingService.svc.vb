Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR04500Back
Imports PYR04500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR04500StreamingService" in code, svc and config file together.
Public Class PYR04500StreamingService
    Implements IPYR04500StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR04500StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR04500CLS
        Dim poParam As New PYR04500DTO
        Dim loRtnList As New List(Of PYR04500ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cPaymentGuidList = R_Utility.R_GetStreamingContext("cPaymentGuidList")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lSelectEmployee = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .lSummary = R_Utility.R_GetStreamingContext("lSummary")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cReportType = R_Utility.R_GetStreamingContext("cReportType")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR04500ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYR04500Back.PYR04500DTO)) Implements IPYR04500StreamingService.Dummy

    End Sub

    Public Function getBankTransferList() As System.ServiceModel.Channels.Message Implements IPYR04500StreamingService.getBankTransferList
        Dim loEx As New R_Exception
        Dim loCls As New PYR04500CLS
        Dim poParam As New PYR04500DTO
        Dim loRtnList As New List(Of PYR04500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
            End With

            loRtnList = loCls.getBankTransferList(poParam)


            loList = R_Utility.R_GetChunkData(Of PYR04500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankTransferList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IPYR04500StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYR04500CLS
        Dim poParam As New PYR04500DTO
        Dim loRtnList As New List(Of PYR04500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getPeriod(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR04500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExportExcelData() As System.ServiceModel.Channels.Message Implements IPYR04500StreamingService.getExportExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PYR04500CLS
        Dim poParam As New PYR04500DTO
        Dim loRtnList As New List(Of PYR04500ExcelDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cPaymentGuidList = R_Utility.R_GetStreamingContext("cPaymentGuidList")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lSelectEmployee = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .lSummary = R_Utility.R_GetStreamingContext("lSummary")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getExportExcelData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR04500ExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSubReportData() As System.ServiceModel.Channels.Message Implements IPYR04500StreamingService.getSubReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR04500CLS
        Dim poParam As New PYR04500DTO
        Dim loRtnList As New List(Of PYR04500ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cPaymentGuidList = R_Utility.R_GetStreamingContext("cPaymentGuidList")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lSelectEmployee = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .lSummary = R_Utility.R_GetStreamingContext("lSummary")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cReportType = R_Utility.R_GetStreamingContext("cReportType")
            End With

            loRtnList = loCls.getSubReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR04500ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSubReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
