Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR05000Common
Imports PYR05000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR05000StreamingService" in code, svc and config file together.
Public Class PYR05000StreamingService
    Implements IPYR05000StreamingService

    Public Function getCmbMonth() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getCmbMonth
        Dim loCls As New PYR05000Cls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR05000ParameterStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbMonth(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR05000ParameterStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbMonth")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPaymentType() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getCmbPaymentType
        Dim loCls As New PYR05000Cls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR05000ParameterStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
            End With

            loRtnList = loCls.getCmbPaymentType(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR05000ParameterStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPaymentType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function getKelasRawatInapList() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getKelasRawatInapList
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYR05000Cls
    '    Dim loRtn As New List(Of PYR05000ParameterStreamingDTO)
    '    Dim loRtnMessage As Message = Nothing

    '    Try
    '        loRtn = loCls.getKelasRawatInapList()
    '        loRtnMessage = R_StreamUtility(Of PYR05000ParameterStreamingDTO).WriteToMessage(loRtn.AsEnumerable, "getKelasRawatInapList")

    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtnMessage
    'End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getReportData
        Dim loCls As New PYR05000Cls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYM14600ReportHeaderDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeBpjsPerusahaan = R_Utility.R_GetStreamingContext("cKodeBpjsPerusahaan")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cMonth = R_Utility.R_GetStreamingContext("cMonth")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM14600ReportHeaderDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportDataHeader() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getReportDataHeader
        Dim loCls As New PYR05000Cls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYM14600ReportHeaderDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeBpjsPerusahaan = R_Utility.R_GetStreamingContext("cKodeBpjsPerusahaan")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cMonth = R_Utility.R_GetStreamingContext("cMonth")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cJenisMutasi = R_Utility.R_GetStreamingContext("cJenisMutasi")
                .cTanggalMutasi = R_Utility.R_GetStreamingContext("cTanggalMutasi")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReportDataHeader(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM14600ReportHeaderDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportDataHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportDataPekerjaBaru() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getReportDataPekerjaBaru
        Dim loCls As New PYR05000KeanggotaanCls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYM14600ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeBpjsPerusahaan = R_Utility.R_GetStreamingContext("cKodeBpjsPerusahaan")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cMonth = R_Utility.R_GetStreamingContext("cMonth")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReportDataPekerjaBaru(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM14600ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportDataPekerjaBaru")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportDataPekerjaLama() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getReportDataPekerjaLama
        Dim loCls As New PYR05000KeanggotaanCls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYM14600ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeBpjsPerusahaan = R_Utility.R_GetStreamingContext("cKodeBpjsPerusahaan")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cMonth = R_Utility.R_GetStreamingContext("cMonth")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReportDataPekerjaLama(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM14600ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportDataPekerjaLama")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportDataRincianBulanan() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getReportDataRincianBulanan
        Dim loCls As New PYR05000KeanggotaanCls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYM14600ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeBpjsPerusahaan = R_Utility.R_GetStreamingContext("cKodeBpjsPerusahaan")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cMonth = R_Utility.R_GetStreamingContext("cMonth")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReportDataRincianBulanan(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM14600ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportDataRincianBulanan")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroupList() As System.ServiceModel.Channels.Message Implements IPYR05000StreamingService.getSalaryGroupList
        Dim loCls As New PYR05000Cls
        Dim poParam As New PYR05000DTO
        Dim loEx As New R_Exception
        Dim loRtnList As New List(Of PYR05000ParameterStreamingDTO)
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
            loList = R_Utility.R_GetChunkData(Of PYR05000ParameterStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroupList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGridCarrier As System.Collections.Generic.List(Of PYR05000Back.PYR05000ParameterGridDTO), poParam As System.Collections.Generic.List(Of PYR05000Back.PYR05000DTO)) Implements IPYR05000StreamingService.Dummy

    End Sub
End Class
