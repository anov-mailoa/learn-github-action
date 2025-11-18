Imports R_Common
Imports R_BackEnd
Imports LNR00500Back
Imports LNR00500Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00500StreamingService" in code, svc and config file together.
Public Class LNR00500StreamingService
    Implements ILNR00500StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR00500StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR00500Cls
        Dim loRtnTemp As List(Of LNR00500Dto_S)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR00500Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromInstallmentDate = R_Utility.R_GetStreamingContext("cFromInstallmentDate")
                .cToInstallmentDate = R_Utility.R_GetStreamingContext("cToInstallmentDate")
                .LINSTALLMENT_DETAIL = R_Utility.R_GetStreamingContext("LINSTALLMENT_DETAIL")
                .LOUTSTANDING_ONLY = R_Utility.R_GetStreamingContext("LOUTSTANDING_ONLY")
                .CLOAN_TYPE_INFO = R_Utility.R_GetStreamingContext("CLOAN_TYPE_INFO")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .CPERIOD = R_Utility.R_GetStreamingContext("CPERIOD")
            End With

            loRtnTemp = loCls.getReport(loParam)
            loList = R_Utility.R_GetChunkData(Of LNR00500Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function



    Public Sub Dummy(poReport As System.Collections.Generic.List(Of LNR00500Back.HeaderReportDTO)) Implements ILNR00500StreamingService.Dummy

    End Sub

    Public Function getLoanTypeList() As System.ServiceModel.Channels.Message Implements ILNR00500StreamingService.getLoanTypeList
        Dim loEx As New R_Exception
        Dim loCls As New LNR00500Cls
        Dim loRtnTemp As List(Of LNR00500Dto_S)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR00500Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLoanTypeList(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR00500Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLoanTypeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getPeriodList() As System.ServiceModel.Channels.Message Implements ILNR00500StreamingService.getPeriodList
        Dim loEx As New R_Exception
        Dim loCls As New LNR00500Cls
        Dim loRtnTemp As List(Of LNR00500Dto_S)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR00500Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPeriodList(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR00500Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriodList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
