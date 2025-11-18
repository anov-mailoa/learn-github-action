Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports MCR01050BACK
Imports MCR01050COMMON
Imports SIAPP_SERVICE_MC
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR01050StreamingService" in code, svc and config file together.
Public Class MCR01050StreamingService
    Implements IMCR01050StreamingService

    Public Function getExcel() As Message Implements IMCR01050StreamingService.getExcel
        Dim loEx As New R_Exception
        Dim loCls As New MCR01050Cls
        Dim loParam As New MCR01050DTO
        Dim loRtn As List(Of MCR01050ExcelDTO)
        Dim loList As List(Of Byte())
        Dim loRtnMessage As Message = Nothing

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LEXPORT_TO_XLS = R_Utility.R_GetStreamingContext("EXPORT")
            End With

            loRtn = loCls.getExcel(loParam)
            loList = R_Utility.R_GetChunkData(Of MCR01050ExcelDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcel")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements IMCR01050StreamingService.GetReport
        Dim loEx As New R_Exception
        Dim loCls As New MCR01050Cls
        Dim loParam As New MCR01050DTO
        Dim loRtn As List(Of MCR01050ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtnMessage As Message = Nothing

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LEXPORT_TO_XLS = R_Utility.R_GetStreamingContext("EXPORT")
            End With

            loRtn = loCls.GetReport(loParam)
            loList = R_Utility.R_GetChunkData(Of MCR01050ReportDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetYear() As System.ServiceModel.Channels.Message Implements IMCR01050StreamingService.GetYear
        Dim loEx As New R_Exception
        Dim loCls As New MCR01050Cls
        Dim loParam As New MCR01050DTO
        Dim loRtn As List(Of MCR01050ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtnMessage As Message = Nothing

        Try

            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.GetYear(loParam)
            loList = R_Utility.R_GetChunkData(Of MCR01050ReportDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetYear")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub ParamDTO(poPar As System.Collections.Generic.List(Of MCR01050BACK.MCR01050DTO)) Implements IMCR01050StreamingService.ParamDTO

    End Sub

End Class
