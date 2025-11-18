Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNT05200Common
Imports PNT05200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT05200StreamingService" in code, svc and config file together.
Public Class PNT05200StreamingService
    Implements IPNT05200StreamingService

    Public Function getPntTransactionHd() As System.ServiceModel.Channels.Message Implements IPNT05200StreamingService.getPntTransactionHd
        Dim loException As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim poParam As New PNT05200GridDTO
        Dim loRtnTemp As List(Of PNT05200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cToCompanyId = R_Utility.R_GetStreamingContext("cToCompanyId")

            loRtnTemp = loCls.getPntTransactionHd(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT05200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "PntTransactionHd")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransferRegis() As System.ServiceModel.Channels.Message Implements IPNT05200StreamingService.getTransferRegis
        Dim loException As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim poParam As New PNT05200GridDTO
        Dim loRtnTemp As List(Of PNT05200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransCode")
            poParam.lFlag = R_Utility.R_GetStreamingContext("lFlag")

            loRtnTemp = loCls.getTransferRegis(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT05200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "TransferRegistration")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNT05200Back.PNT05200GridDTO)) Implements IPNT05200StreamingService.Dummy

    End Sub
End Class
