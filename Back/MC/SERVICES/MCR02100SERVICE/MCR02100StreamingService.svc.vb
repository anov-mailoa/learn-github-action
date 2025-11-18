Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR02100Back
Imports MCR02100Common
Imports R_BackEnd
Imports SIAPP_SERVICE_MC
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR02100StreamingService" in code, svc and config file together.
Public Class MCR02100StreamingService
    Implements IMCR02100StreamingService

    Public Function getExcel() As Message Implements IMCR02100StreamingService.getExcel
        Dim loException As New R_Exception
        Dim loCls As New MCR02100Cls
        Dim poParam As New MCR02100Dto
        Dim loRtnList As New List(Of MCR02100ExcelDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cReport = R_Utility.R_GetStreamingContext("cReport")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cTransactionStatus = R_Utility.R_GetStreamingContext("cTransactionStatus")
                .LWITH_SUBITEM = R_Utility.R_GetStreamingContext("LWITH_SUBITEM")
                .LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("LEXPORT_TO_EXCEL")
            End With

            loRtnList = loCls.getExcel(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR02100ExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcel")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR02100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New MCR02100Cls
        Dim poParam As New MCR02100Dto
        Dim loRtnList As New List(Of MCR02100ReportDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cReport = R_Utility.R_GetStreamingContext("cReport")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cTransactionStatus = R_Utility.R_GetStreamingContext("cTransactionStatus")
                .LWITH_SUBITEM = R_Utility.R_GetStreamingContext("LWITH_SUBITEM")
                .LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("LEXPORT_TO_EXCEL")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR02100ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of MCR02100Back.MCR02100Dto)) Implements IMCR02100StreamingService.Dummy

    End Sub

End Class
