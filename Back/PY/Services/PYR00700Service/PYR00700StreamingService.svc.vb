Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR00700Back
Imports PYR00700Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00700StreamingService" in code, svc and config file together.
Public Class PYR00700StreamingService
    Implements IPYR00700StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00700StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR00700CLS
        Dim poParam As New PYR00700DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00700StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR00700StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR00700StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR00700CLS
        Dim poParam As New PYR00700DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00700ReportDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .lToExcel = R_Utility.R_GetStreamingContext("lToExcel")
                .lShowZeroRow = R_Utility.R_GetStreamingContext("lShowZeroRow")
            End With

            loRtnList = loCls.getReportData(poParam)

            'Test Data Dummy
            'Dim dto As New PYR00700ReportDTO
            'With dto
            '    .CCELL_CODE = "Cell Code"
            '    .CCELL_NAME = "Cell Name"
            '    .CEMPLOYEE_ID = "Emp Id"
            '    .CEMPLOYEE_NAME = "Emp Name"
            '    .CGROUP_CODE = "Grp Code"
            '    .CGROUP_DESCRIPTION = "Grp Desc"
            'End With
            'loRtnList.Add(dto)

            loList = R_Utility.R_GetChunkData(Of PYR00700ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam3 As System.Collections.Generic.List(Of PYR00700Back.PYR00700DTO)) Implements IPYR00700StreamingService.Dummy

    End Sub

    Public Function getExportExcelData() As System.ServiceModel.Channels.Message Implements IPYR00700StreamingService.getExportExcelData
        Dim loException As New R_Exception
        Dim loCls As New PYR00700CLS
        Dim poParam As New PYR00700DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00700ExcelDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .lToExcel = R_Utility.R_GetStreamingContext("lToExcel")
                .lShowZeroRow = R_Utility.R_GetStreamingContext("lShowZeroRow")
            End With

            loRtnList = loCls.getExportExcelData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR00700ExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
