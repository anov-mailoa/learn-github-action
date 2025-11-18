Imports R_Common
Imports R_BackEnd
Imports LNR10300BACK
Imports LNR10300COMMON
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR10300StreamingService" in code, svc and config file together.
Public Class LNR10300StreamingService
    Implements ILNR10300StreamingService

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of LNR10300BACK.LNR10300DTO)) Implements ILNR10300StreamingService.Dummy

    End Sub

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements ILNR10300StreamingService.GetReport
        Dim loException As New R_Exception
        Dim loCls As New LNR10300Cls
        Dim loRtnTemp As List(Of LNR10300ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNR10300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CLOAN_PERIOD = R_Utility.R_GetStreamingContext("CLOAN_PERIOD")
                .CLOAN_TYPE_LIST = R_Utility.R_GetStreamingContext("CLOAN_TYPE_LIST")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.GetReport(loParam)
            loList = R_Utility.R_GetChunkData(Of LNR10300ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function GetPeriodList() As System.ServiceModel.Channels.Message Implements ILNR10300StreamingService.GetPeriodList
        Dim loException As New R_Exception
        Dim loCls As New LNR10300Cls
        Dim loRtnTemp As List(Of LNR10300ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim pcCompId As String = ""

        Try
            pcCompId = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnTemp = loCls.GetPeriodList(pcCompId)
            loList = R_Utility.R_GetChunkData(Of LNR10300ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetPeriodList")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLoanTypeList() As System.ServiceModel.Channels.Message Implements ILNR10300StreamingService.GetLoanTypeList
        Dim loException As New R_Exception
        Dim loCls As New LNR10300Cls
        Dim loRtnTemp As List(Of LNR10300ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim pcCompId As String = ""

        Try
            pcCompId = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnTemp = loCls.GetLoanTypeList(pcCompId)
            loList = R_Utility.R_GetChunkData(Of LNR10300ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLoanTypeList")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
