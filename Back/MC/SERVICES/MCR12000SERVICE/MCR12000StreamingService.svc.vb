' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR12000StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select MCR12000StreamingService.svc or MCR12000StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCR12000Common
Imports MCR12000Back
Imports SIAPP_SERVICE_MC


Public Class MCR12000StreamingService
    Implements IMCR12000StreamingService

    Public Sub Dummy(poParam As List(Of MCR12000DTO)) Implements IMCR12000StreamingService.Dummy

    End Sub

    Public Function getExportExcelData() As Message Implements IMCR12000StreamingService.getExportExcelData

        Dim loEx As New R_Exception
        Dim loCls As New MCR12000Cls
        Dim poParam As New MCR12000DTO
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loRtnList1 As New List(Of DataTable)

        Try
            With poParam
                poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                poParam.CREPORT_ID = R_Utility.R_GetStreamingContext("CREPORT_ID")
                poParam.CEMPLOYEE_STATUS_TYPE = R_Utility.R_GetStreamingContext("CEMPLOYEE_STATUS_TYPE")
                poParam.CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                poParam.CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                poParam.CEND_DATE = R_Utility.R_GetStreamingContext("CEND_DATE")
                poParam.LSELECT_EMPLOYEE = R_Utility.R_GetStreamingContext("LSELECT_EMPLOYEE")
                poParam.CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                poParam.CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                poParam.ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
                poParam.LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("LEXPORT_TO_EXCEL")
                poParam.CGROUP_BY = R_Utility.R_GetStreamingContext("CGROUP_BY")
                poParam.CORDER_BY = R_Utility.R_GetStreamingContext("CORDER_BY")
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

    Public Function getExportExcelHeader() As Message Implements IMCR12000StreamingService.getExportExcelHeader

        Dim loEx As New R_Exception
        Dim loCls As New MCR12000Cls
        Dim poParam As New MCR12000DTO
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                poParam.CREPORT_ID = R_Utility.R_GetStreamingContext("CREPORT_ID")
                poParam.CGROUP_BY = R_Utility.R_GetStreamingContext("CGROUP_BY")
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

    Public Function getReportData() As Message Implements IMCR12000StreamingService.getReportData

        Dim loEx As New R_Exception
        Dim loCls As New MCR12000Cls
        Dim poParam As New MCR12000DTO
        Dim loRtnList As New List(Of MCR12000ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                poParam.CREPORT_ID = R_Utility.R_GetStreamingContext("CREPORT_ID")
                poParam.CEMPLOYEE_STATUS_TYPE = R_Utility.R_GetStreamingContext("CEMPLOYEE_STATUS_TYPE")
                poParam.CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                poParam.CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                poParam.CEND_DATE = R_Utility.R_GetStreamingContext("CEND_DATE")
                poParam.LSELECT_EMPLOYEE = R_Utility.R_GetStreamingContext("LSELECT_EMPLOYEE")
                poParam.CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                poParam.CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                poParam.ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
                poParam.LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("LEXPORT_TO_EXCEL")
                poParam.CGROUP_BY = R_Utility.R_GetStreamingContext("CGROUP_BY")
                poParam.CORDER_BY = R_Utility.R_GetStreamingContext("CORDER_BY")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR12000ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn

    End Function

    Public Function getCmbReportTemplateList() As System.ServiceModel.Channels.Message Implements IMCR12000StreamingService.getCmbReportTemplateList
        Dim loCls As New MCR12000Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCR12000DTO
        Dim loRtnList As New List(Of MCR12000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getCmbReportTemplateList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR12000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbReportTemplateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


End Class
