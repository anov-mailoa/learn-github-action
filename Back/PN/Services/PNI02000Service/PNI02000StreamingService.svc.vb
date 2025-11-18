Imports System.ServiceModel.Channels
Imports PNI02000Back
Imports PNI02000Common
Imports R_Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNI02000StreamingService" in code, svc and config file together.
Public Class PNI02000StreamingService
    Implements IPNI02000StreamingService

    Public Function getOutstanding() As System.ServiceModel.Channels.Message Implements IPNI02000StreamingService.getOutstanding
        Dim loCls As New PNI02000Cls
        Dim poParam As New PNI02000StreamingDTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI02000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cCultureId = R_Utility.R_GetStreamingContext("cCultureId")
            End With

            loRtnTemp = loCls.getOutstanding(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOutstanding")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getOutstandingTransaction() As System.ServiceModel.Channels.Message Implements IPNI02000StreamingService.getOutstandingTransaction
        Dim loCls As New PNI02000Cls
        Dim poParam As New PNI02000StreamingDTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI02000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cCultureId = R_Utility.R_GetStreamingContext("cCultureId")
            End With

            loRtnTemp = loCls.getOutstandingTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOutstandingTransaction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransactionType() As System.ServiceModel.Channels.Message Implements IPNI02000StreamingService.getTransactionType
        Dim loCls As New PNI02000Cls
        Dim poParam As New PNI02000StreamingDTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI02000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTransactionType(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransactionType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
