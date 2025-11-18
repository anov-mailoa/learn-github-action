Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR06900Common
Imports PYR06900Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR06900StreamingService" in code, svc and config file together.
Public Class PYR06900StreamingService
    Implements IPYR06900StreamingService

    Public Function getCmbPaymentType() As System.ServiceModel.Channels.Message Implements IPYR06900StreamingService.getCmbPaymentType
        Dim loCls As New PYR06900Cls
        Dim poParam As New PYR06900DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR06900StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
            End With

            loRtnList = loCls.getCmbPaymentType(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR06900StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPaymentType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroupList() As System.ServiceModel.Channels.Message Implements IPYR06900StreamingService.getSalaryGroupList
        Dim loCls As New PYR06900Cls
        Dim poParam As New PYR06900DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR06900StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getSalaryGroupList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR06900StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroupList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbJabatan() As System.ServiceModel.Channels.Message Implements IPYR06900StreamingService.getCmbJabatan
        Dim loCls As New PYR06900Cls
        Dim poParam As New PYR06900DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR06900StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbJabatan(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR06900StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbJabatan")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR06900StreamingService.getReportData
        Dim loCls As New PYR06900Cls
        Dim poParam As New PYR06900DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR06900ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cKurangLebihBayar = R_Utility.R_GetStreamingContext("cKurangLebihBayar")
                .cKppId = R_Utility.R_GetStreamingContext("cKppId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR06900ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSptSetting(poParam As PYR06900Back.PYR06900DTO) As PYR06900Back.PYR06900DTO Implements IPYR06900StreamingService.getSptSetting
        Dim loEx As New R_Exception
        Dim loCls As New PYR06900Cls
        Dim loRtnTemp As New PYR06900DTO

        Try
            loRtnTemp = loCls.getSptSetting(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnTemp
    End Function

    Public Function getExportExcelData() As System.ServiceModel.Channels.Message Implements IPYR06900StreamingService.getExportExcelData
        Dim loCls As New PYR06900Cls
        Dim poParam As New PYR06900DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Dim loRtnList1 As New List(Of DataTable)
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cKurangLebihBayar = R_Utility.R_GetStreamingContext("cKurangLebihBayar")
                .cKppId = R_Utility.R_GetStreamingContext("cKppId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cGroupBy = R_Utility.R_GetStreamingContext("cGroupBy")
            End With

            loRtnList = loCls.getExportExcelData(poParam)

            loRtnList1.Add(loRtnList)

            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExportExcelHeader() As System.ServiceModel.Channels.Message Implements IPYR06900StreamingService.getExportExcelHeader
        Dim loCls As New PYR06900Cls
        Dim poParam As New PYR06900DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Dim loRtnList1 As New List(Of DataTable)
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getExportExcelHeader(poParam)

            loRtnList1.Add(loRtnList)

            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExportExcelHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
