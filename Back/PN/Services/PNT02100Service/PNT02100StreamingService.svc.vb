Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNT02100Common
Imports PNT02100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT02100StreamingService" in code, svc and config file together.
Public Class PNT02100StreamingService
    Implements IPNT02100StreamingService

    Public Function getPntTransactionHd() As System.ServiceModel.Channels.Message Implements IPNT02100StreamingService.getPntTransactionHd
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim poParam As New PNT02100GridDTO
        Dim loRtnTemp As List(Of PNT02100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cToCompanyId = R_Utility.R_GetStreamingContext("cToCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")

            loRtnTemp = loCls.getPntTransactionHd(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT02100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "PntTransactionHd")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransferRegis() As System.ServiceModel.Channels.Message Implements IPNT02100StreamingService.getTransferRegis
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim poParam As New PNT02100GridDTO
        Dim loRtnTemp As List(Of PNT02100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .lViewMode = R_Utility.R_GetStreamingContext("lViewMode")
            End With

            loRtnTemp = loCls.getTransferRegis(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT02100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "TransferRegis")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSubGrade() As System.ServiceModel.Channels.Message Implements IPNT02100StreamingService.getCmbSubGrade
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message
        Dim loCls As New PNT02100Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNT02100DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
            End With

            loRtn = loCls.getCmbSubGrade(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbSubGrade")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNT02100Back.PNT02100GridDTO)) Implements IPNT02100StreamingService.Dummy

    End Sub
End Class
