Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNT07100Back
Imports PNT07100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07100StreamingService" in code, svc and config file together.
Public Class PNT07100StreamingService
    Implements IPNT07100StreamingService

    Public Function GetOutstandingTransactionList() As System.ServiceModel.Channels.Message Implements IPNT07100StreamingService.GetOutstandingTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loParam As New PNT07100DTO
        Dim loRtnTemp As List(Of PNT07100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            loParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")

            loRtnTemp = loCls.GetOutstandingTransactionList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNT07100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetOutstandingTransactionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTrxList() As System.ServiceModel.Channels.Message Implements IPNT07100StreamingService.GetTrxList
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loParam As New PNT07100DTO
        Dim loRtnTemp As List(Of PNT07100CommonDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.GetTrxList(loParam)
            
            loList = R_Utility.R_GetChunkData(Of PNT07100CommonDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTrxList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
