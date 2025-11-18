Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATR12000Common
Imports ATR12000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR12000StreamingService" in code, svc and config file together.
Public Class ATR12000StreamingService
    Implements IATR12000StreamingService

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of ATR12000Back.ATR12000DTO)) Implements IATR12000StreamingService.Dummy

    End Sub

    Public Function getExportExcelData() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getExportExcelData
        Dim loEx As New R_Exception
        Dim loCls As New ATR12000CLS
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Dim loRtnList1 As New List(Of DataTable)



        Try
            'With poParam
            '    .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            '    .cReportId = R_Utility.R_GetStreamingContext("cReportId")
            '    .cFromIndex = R_Utility.R_GetStreamingContext("cFromIndex")
            '    .cToIndex = R_Utility.R_GetStreamingContext("cToIndex")
            '    .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            '    .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            '    .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
            '    .lSelectEmployee = R_Utility.R_GetStreamingContext("lSelectEmployee")
            '    .cSalaryValueMode = R_Utility.R_GetStreamingContext("cSalaryValueMode")
            '    .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
            '    .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            '    .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            '    .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
            '    .lExportToExcel = R_Utility.R_GetStreamingContext("lExportToExcel")
            '    .cGroupBy = R_Utility.R_GetStreamingContext("cGroupBy")
            'End With
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportId = R_Utility.R_GetStreamingContext("cReportId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lExportToExcel = R_Utility.R_GetStreamingContext("lExportToExcel")
                .cGroupBy = R_Utility.R_GetStreamingContext("cGroupBy")
                .lAllWG = R_Utility.R_GetStreamingContext("lAllWG")
                .cWGList = R_Utility.R_GetStreamingContext("cWGList")

            End With

            loRtnList = loCls.getExportExcelData(poParam)

            loRtnList1.Add(loRtnList)

            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getExportExcelHeader() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getExportExcelHeader
        Dim loEx As New R_Exception
        Dim loCls As New ATR12000CLS
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportId = R_Utility.R_GetStreamingContext("cReportId")
                .cSalaryValueMode = R_Utility.R_GetStreamingContext("cSalaryValueMode")
                .cGroupBy = R_Utility.R_GetStreamingContext("cGroupBy")
            End With

            loRtnList = loCls.getExportExcelHeader(poParam)

            Dim loRtnList1 As New List(Of DataTable)
            loRtnList1.Add(loRtnList)

            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New ATR12000CLS
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New List(Of ATR12000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR12000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New ATR12000CLS
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New List(Of ATR12000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR12000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getProcess() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getProcess
        Dim loEx As New R_Exception
        Dim loCls As New ATR12000CLS
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New List(Of ATR12000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getProcess(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR12000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcess")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New ATR12000CLS
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New List(Of ATR12000ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportId = R_Utility.R_GetStreamingContext("cReportId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lExportToExcel = R_Utility.R_GetStreamingContext("lExportToExcel")
                .cGroupBy = R_Utility.R_GetStreamingContext("cGroupBy")
                .lAllWG = R_Utility.R_GetStreamingContext("lAllWG")
                .cWGList = R_Utility.R_GetStreamingContext("cWGList")

            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR12000ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getTemplateList() As System.ServiceModel.Channels.Message Implements IATR12000StreamingService.getTemplateList
        Dim loCls As New ATR12000CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATR12000DTO
        Dim loRtnList As New List(Of ATR12000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getTemplateList(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR12000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
