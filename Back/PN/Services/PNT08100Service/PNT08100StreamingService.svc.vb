Imports R_Common
Imports System.ServiceModel.Channels
Imports PNT08100Back
Imports PNT08100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT08100StreamingService" in code, svc and config file together.
Public Class PNT08100StreamingService
    Implements IPNT08100StreamingService

    Public Function getEmployeeBondList() As System.ServiceModel.Channels.Message Implements IPNT08100StreamingService.getEmployeeBondList
        Dim loCls As New PNT08100CLS
        Dim loRtnTemp As List(Of PNT08100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT08100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getEmployeeBondList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT08100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeBondList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNT08100StreamingService.getReportData
        Dim loCls As New PNT08100CLS
        Dim loRtnTemp As List(Of PNT08100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT08100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cRefNo = R_Utility.R_GetStreamingContext("cRefNo")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT08100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
