Imports R_BackEnd
Imports R_Common
Imports PNR12000Back
Imports PNR12000Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR12000StreamingService" in code, svc and config file together.
Public Class PNR12000StreamingService
    Implements IPNR12000StreamingService

    Public Sub DoWork() Implements IPNR12000StreamingService.DoWork
    End Sub

    Public Function getReportTemplate() As System.ServiceModel.Channels.Message Implements IPNR12000StreamingService.getReportTemplate

        Dim loEx As New R_Exception
        Dim loCls As New PNR12000Cls
        Dim loPar As New PNR12000DTO
        Dim loList As List(Of Byte())
        Dim loRtn As New List(Of PNR12000StreamingDTO)
        Dim loFinalRtn As Message

        Try
            With loPar
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtn = loCls.getReportTemplate(loPar)
            loList = R_Utility.R_GetChunkData(Of PNR12000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loFinalRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTemplate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loFinalRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNR12000Back.PNR12000DTO)) Implements IPNR12000StreamingService.Dummy

    End Sub

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNR12000StreamingService.getReportData

        Dim loEx As New R_Exception
        Dim loCls As New PNR12000Cls
        Dim loPar As New PNR12000DTO
        Dim loList As List(Of Byte())
        Dim loRtn As New List(Of PNR12000ReportDTO)
        Dim loFinalRtn As Message

        Try
            With loPar
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompanyId")
                .CREPORT_ID = R_Utility.R_GetStreamingContext("cReportId")
                .CEMPLOYEE_STATUS_TYPE = R_Utility.R_GetStreamingContext("cEmployeeStatus")
                .LSELECT_EMPLOYEE = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("cEmployeeId")
                .CUSER_ID = R_Utility.R_GetStreamingContext("cUserId")
                .CLANG_ID = R_Utility.R_GetStreamingContext("cLangId")
                .ENCKEY = R_Utility.R_GetStreamingContext("cEnckey")
                .LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("loExportExcel")
                .CGROUP_BY = R_Utility.R_GetStreamingContext("cGroupBy")
                .CORDER_BY = R_Utility.R_GetStreamingContext("cOrderBy")
            End With

            loRtn = loCls.getReportData(loPar)
            loList = R_Utility.R_GetChunkData(Of PNR12000ReportDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loFinalRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loFinalRtn
    End Function

    Public Function getExcelHeaderData() As System.ServiceModel.Channels.Message Implements IPNR12000StreamingService.getExcelHeaderData

        Dim loEx As New R_Exception
        Dim loCls As New PNR12000Cls
        Dim loPar As New PNR12000DTO
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loFinalRtn As Message

        Try
            With loPar
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompanyId")
                .CREPORT_ID = R_Utility.R_GetStreamingContext("cReportId")
                .CGROUP_BY = R_Utility.R_GetStreamingContext("cGroupBy")
            End With

            loRtnList = loCls.getExcelHeaderData(loPar)
            Dim loRtnList1 As New List(Of DataTable)
            loRtnList1.Add(loRtnList)

            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)
            loFinalRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelHeaderData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loFinalRtn
    End Function

    Public Function getExcelData() As System.ServiceModel.Channels.Message Implements IPNR12000StreamingService.getExportExcelData

        Dim loEx As New R_Exception
        Dim loCls As New PNR12000Cls
        Dim loPar As New PNR12000DTO
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loFinalRtn As Message

        Dim loRtnList1 As New List(Of DataTable)

        Try
            With loPar
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompanyId")
                .CREPORT_ID = R_Utility.R_GetStreamingContext("cReportId")
                .CEMPLOYEE_STATUS_TYPE = R_Utility.R_GetStreamingContext("cEmployeeStatus")
                .LSELECT_EMPLOYEE = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("cEmployeeId")
                .CUSER_ID = R_Utility.R_GetStreamingContext("cUserId")
                .CLANG_ID = R_Utility.R_GetStreamingContext("cLangId")
                .ENCKEY = R_Utility.R_GetStreamingContext("cEnckey")
                .LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("loExportExcel")
                .CGROUP_BY = R_Utility.R_GetStreamingContext("cGroupBy")
                .CORDER_BY = R_Utility.R_GetStreamingContext("cOrderBy")
            End With

            loRtnList = loCls.getExportExcelData(loPar)
            loRtnList1.Add(loRtnList)
            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)
            loFinalRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loFinalRtn
    End Function

    'Public Function getTemplateList() As System.ServiceModel.Channels.Message Implements IPNR12000StreamingService.getTemplateList

    '    Dim loCls As New PNR12000Cls
    '    Dim loEx As New R_Exception
    '    Dim poParam As New PNR12000DTO
    '    Dim loRtnList As New List(Of PNR12000StreamingDTO)
    '    Dim loList As List(Of Byte())
    '    Dim loRtn As Message = Nothing

    '    Try
    '        With poParam
    '            .CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompanyId")
    '        End With

    '        loRtnList = loCls.getTemplateList(poParam)
    '        loList = R_Utility.R_GetChunkData(Of PNR12000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
    '        loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateList")

    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn

    'End Function
End Class
