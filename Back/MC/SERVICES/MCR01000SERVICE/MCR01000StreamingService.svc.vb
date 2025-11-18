Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR01000Back
Imports MCR01000Common
Imports R_BackEnd
Imports SIAPP_SERVICE_MC
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR01000StreamingService" in code, svc and config file together.
Public Class MCR01000StreamingService
    Implements IMCR01000StreamingService

    Public Function getExcel() As Message Implements IMCR01000StreamingService.getExcel
        Dim loException As New R_Exception
        Dim loCls As New MCR01000Cls
        Dim poParam As New MCR01000Dto
        Dim loRtnList As New List(Of MCR01000ExcelDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .LEXPORT_TO_XLS = R_Utility.R_GetStreamingContext("EXPORT")
            End With

            loRtnList = loCls.getExcel(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR01000ExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcel")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR01000StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New MCR01000Cls
        Dim poParam As New MCR01000Dto
        Dim loRtnList As New List(Of MCR01000ReportDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .LEXPORT_TO_XLS = R_Utility.R_GetStreamingContext("EXCEL")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR01000ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getYear() As System.ServiceModel.Channels.Message Implements IMCR01000StreamingService.getYear
        Dim loException As New R_Exception
        Dim loCls As New MCR01000Cls
        Dim poParam As New MCR01000Dto
        Dim loRtnList As New List(Of MCR01000StreamingDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStatus = R_Utility.R_GetStreamingContext("cStatus")
            End With

            loRtnList = loCls.getyear(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR01000StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnList.AsEnumerable, "getYear")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of MCR01000Back.MCR01000Dto)) Implements IMCR01000StreamingService.Dummy

    End Sub

End Class
