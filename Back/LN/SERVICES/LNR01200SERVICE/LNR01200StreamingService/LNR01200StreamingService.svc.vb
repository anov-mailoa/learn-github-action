Imports R_Common
Imports R_BackEnd
Imports LNR01200Back
Imports LNR01200Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR01200StreamingService" in code, svc and config file together.
Public Class LNR01200StreamingService
    Implements ILNR01200StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR01200StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR01200CLS
        Dim loRtnTemp As List(Of LNR01200ReportDTO)
        Dim loRtn As Message
        Dim loParam As New LNR01200DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CTRANSACTION_STATUS_LIST = R_Utility.R_GetStreamingContext("CTRANSACTION_STATUS_LIST")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .LNEW_LOAN = R_Utility.R_GetStreamingContext("LNEW_LOAN")
            End With

            loRtnTemp = loCls.getReport(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR01200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class
