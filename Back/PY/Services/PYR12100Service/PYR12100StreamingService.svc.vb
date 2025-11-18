Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR12100Common
Imports PYR12100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR12100StreamingService" in code, svc and config file together.
Public Class PYR12100StreamingService
    Implements IPYR12100StreamingService

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PYR12100Back.PYR12100DTO)) Implements IPYR12100StreamingService.Dummy

    End Sub

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR12100StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYR12100Cls
        Dim poParam As New PYR12100DTO
        Dim loRtnList As New List(Of PYR12100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IPYR12100StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYR12100Cls
        Dim poParam As New PYR12100DTO
        Dim loRtnList As New List(Of PYR12100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getProcess() As System.ServiceModel.Channels.Message Implements IPYR12100StreamingService.getProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYR12100Cls
        Dim poParam As New PYR12100DTO
        Dim loRtnList As New List(Of PYR12100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getProcess(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcess")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR12100StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR12100Cls
        Dim poParam As New PYR12100DTO
        Dim loRtnList As New List(Of PYR12100ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromIndex = R_Utility.R_GetStreamingContext("cFromIndex")
                .cToIndex = R_Utility.R_GetStreamingContext("cToIndex")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lSelectEmployee = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .cSalaryValueMode = R_Utility.R_GetStreamingContext("cSalaryValueMode")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .lExportToExcel = R_Utility.R_GetStreamingContext("lExportToExcel")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12100ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getExportExcelData() As System.ServiceModel.Channels.Message Implements IPYR12100StreamingService.getExportExcelData
        Dim loException As New R_Exception
        Dim loCls As New PYR12100Cls
        Dim poParam As New PYR12100DTO
        Dim loRtnList As New List(Of PYR12100ExcelDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromIndex = R_Utility.R_GetStreamingContext("cFromIndex")
                .cToIndex = R_Utility.R_GetStreamingContext("cToIndex")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cEmployeeStatusType = R_Utility.R_GetStreamingContext("cEmployeeStatusType")
                .lSelectEmployee = R_Utility.R_GetStreamingContext("lSelectEmployee")
                .cSalaryValueMode = R_Utility.R_GetStreamingContext("cSalaryValueMode")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .lExportToExcel = R_Utility.R_GetStreamingContext("lExportToExcel")
            End With

            loRtnList = loCls.getExportExcelData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12100ExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getReportSize(pcCompId As String) As String Implements IPYR12100StreamingService.getReportSize
        Dim loEx As New R_Exception
        Dim loCls As New PYR12100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getReportSize(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
