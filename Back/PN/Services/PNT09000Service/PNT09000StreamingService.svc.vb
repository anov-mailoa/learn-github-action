Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNT09000Common
Imports PNT09000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09000StreamingService" in code, svc and config file together.
Public Class PNT09000StreamingService
    Implements IPNT09000StreamingService

    Public Function getPnhEmpOffense() As System.ServiceModel.Channels.Message Implements IPNT09000StreamingService.getPnhEmpOffense
        Dim loCls As New EmpPunishListCls
        Dim loRtnTemp As List(Of PNT09100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT09100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDateNow = R_Utility.R_GetStreamingContext("cDateNow")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getPnhEmpOffense(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT09100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnhEmpOffense")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNT09000StreamingService.getReportData
        Dim loCls As New EmpPunishListCls
        Dim loRtnTemp As List(Of PNT09100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT09100ReportDTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CLOGIN_ID = R_Utility.R_GetStreamingContext("CLOGIN_ID")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT09100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DummyPNT09400(poParam As System.Collections.Generic.List(Of PNT09000Back.PNT09400StreamingDTO)) Implements IPNT09000StreamingService.DummyPNT09400

    End Sub

    Public Sub DummyPNT09300(poParam As System.Collections.Generic.List(Of PNT09000Back.PNT09300StreamingDTO)) Implements IPNT09000StreamingService.DummyPNT09300

    End Sub
End Class
