Imports R_Common
Imports R_BackEnd
Imports LNR00100Back
Imports System.ServiceModel.Channels
Imports LNR00100Common
Imports SIAPP_SERVICE_LN
' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00100StreamingService" in code, svc and config file together.
Public Class LNR00100StreamingService
    Implements ILNR00100StreamingService

    Public Function getExportExcelData() As Message Implements ILNR00100StreamingService.getExportExcelData
        Dim loEx As New R_Exception
        Dim loCls As New LNR00100Cls
        Dim poParam As New LNR00100Dto
        Dim loRtnList As New DataTable
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loRtnList1 As New List(Of DataTable)

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cFromInstallmentDate = R_Utility.R_GetStreamingContext("cFromInstallmentDate")
            poParam.cToInstallmentDate = R_Utility.R_GetStreamingContext("cToInstallmentDate")
            poParam.cLoanStatus = R_Utility.R_GetStreamingContext("cLoanStatus")
            poParam.LINSTALLMENT_DETAIL = R_Utility.R_GetStreamingContext("LINSTALLMENT_DETAIL")
            poParam.CLOAN_TYPE = R_Utility.R_GetStreamingContext("CLOAN_TYPE")
            poParam.cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
            poParam.cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
            poParam.cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.CPERIOD = R_Utility.R_GetStreamingContext("CPERIOD")
            poParam.LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("EXCEL")

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

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR00100StreamingService.getReport
        Dim loEx As New R_Exception
        Dim loCls As New LNR00100Cls
        Dim loRtnTemp As List(Of LNR00100Dto_S)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR00100Dto
        Dim loList As List(Of Byte())
        'test doank
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromInstallmentDate = R_Utility.R_GetStreamingContext("cFromInstallmentDate")
                .cToInstallmentDate = R_Utility.R_GetStreamingContext("cToInstallmentDate")
                .cLoanStatus = R_Utility.R_GetStreamingContext("cLoanStatus")
                .LINSTALLMENT_DETAIL = R_Utility.R_GetStreamingContext("LINSTALLMENT_DETAIL")
                .CLOAN_TYPE = R_Utility.R_GetStreamingContext("CLOAN_TYPE")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .CPERIOD = R_Utility.R_GetStreamingContext("CPERIOD")
                .LEXPORT_TO_EXCEL = R_Utility.R_GetStreamingContext("EXCEL")
            End With

            loRtnTemp = loCls.getReport(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR00100Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLoanTypeList() As System.ServiceModel.Channels.Message Implements ILNR00100StreamingService.getLoanTypeList
        Dim loEx As New R_Exception
        Dim loCls As New LNR00100Cls
        Dim loRtnTemp As List(Of LNR00100Dto_S)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR00100Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLoanTypeList(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR00100Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLoanTypeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParReguler As System.Collections.Generic.List(Of LNR00100Back.LNR00100Dto_R), poParReport As System.Collections.Generic.List(Of LNR00100Back.ReportHeaderDTO)) Implements ILNR00100StreamingService.Dummy

    End Sub

    Public Function getPeriodList() As System.ServiceModel.Channels.Message Implements ILNR00100StreamingService.getPeriodList
        Dim loEx As New R_Exception
        Dim loCls As New LNR00100Cls
        Dim loRtnTemp As List(Of LNR00100Dto_S)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR00100Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPeriodList(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR00100Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriodList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
