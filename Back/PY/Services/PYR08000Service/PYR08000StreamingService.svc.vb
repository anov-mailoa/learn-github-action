Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR08000Back
Imports PYR08000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR08000StreamingService" in code, svc and config file together.
Public Class PYR08000StreamingService
    Implements IPYR08000StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR08000StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR08000Cls
        Dim loRtnList As New List(Of PYR08000ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR08000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .lIncludeProcess = R_Utility.R_GetStreamingContext("lIncludeProcess")
                .cProcessList = R_Utility.R_GetStreamingContext("cProcessList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .lCostCenter = R_Utility.R_GetStreamingContext("lCostCenter")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR08000ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getList() As System.ServiceModel.Channels.Message Implements IPYR08000StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New PYR08000Cls
        Dim loRtnList As New List(Of PYR08000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR08000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cFlag = R_Utility.R_GetStreamingContext("cFlag")
            End With

            loRtnList = loCls.getList(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR08000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getInterfaceData() As System.ServiceModel.Channels.Message Implements IPYR08000StreamingService.getInterfaceData
        Dim loEx As New R_Exception
        Dim loCls As New PYR08000Cls
        Dim loRtnList As New List(Of PYR08000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR08000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .lIncludeProcess = R_Utility.R_GetStreamingContext("lIncludeProcess")
                .cProcessList = R_Utility.R_GetStreamingContext("cProcessList")
                .cProcessDate = R_Utility.R_GetStreamingContext("cProcessDate")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getInterfaceData(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR08000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getInterfaceData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateDetail(poParam As PYR08000Back.PYR08000DTO) As PYR08000Back.PYR08000DTO Implements IPYR08000StreamingService.getTemplateDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYR08000Cls
        Dim loRtnTemp As New PYR08000DTO

        Try
            loRtnTemp = loCls.getTemplateDetail(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnTemp
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYR08000Back.PYR08000DTO)) Implements IPYR08000StreamingService.Dummy

    End Sub

    Public Function getExportExcelData() As System.ServiceModel.Channels.Message Implements IPYR08000StreamingService.getExportExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PYR08000Cls
        Dim loRtnList As New List(Of PYR08000excelDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR08000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .lIncludeProcess = R_Utility.R_GetStreamingContext("lIncludeProcess")
                .cProcessList = R_Utility.R_GetStreamingContext("cProcessList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .lCostCenter = R_Utility.R_GetStreamingContext("lCostCenter")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getExportExcelData(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR08000excelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
