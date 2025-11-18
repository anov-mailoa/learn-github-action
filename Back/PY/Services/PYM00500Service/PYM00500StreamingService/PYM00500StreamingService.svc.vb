' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00500StreamingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports PYM00500Common

Public Class PYM00500StreamingService
    Implements IPYM00500StreamingService

    Public Function getJamsostekParameter() As System.ServiceModel.Channels.Message Implements IPYM00500StreamingService.getJamsostekParameter

        Dim loRtn As New List(Of PYM00500ParameterHeaderStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New PYM00500ParameterCLS
        Dim loEx As New R_Exception
        Dim poParam As New PYM00500ParameterDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.getJamsostekParameter(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00500ParameterHeaderStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getJamsostekParameter")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getCity() As System.ServiceModel.Channels.Message Implements IPYM00500StreamingService.getCity
        Dim loRtn As List(Of ComboBoxStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New PYM00500PerusahaanCLS
        Dim loEx As New R_Exception
        Dim poParam As New ComboBoxStreamingDTO

        Try
            poParam.cCountryCode = R_Utility.R_GetStreamingContext("cCountryCode")

            loRtn = loCls.getCity(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComboBoxStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCity")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getBpjstk() As System.ServiceModel.Channels.Message Implements IPYM00500StreamingService.getBpjstk
        Dim loRtn As New List(Of PYM00500PerusahaanHeaderStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New PYM00500PerusahaanCLS
        Dim loEx As New R_Exception
        Dim poParam As New PYM00500PerusahaanDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.getBpjstk(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00500PerusahaanHeaderStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBpjstk")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getBpjstkParameter() As System.ServiceModel.Channels.Message Implements IPYM00500StreamingService.getBpjstkParameter
        Dim loRtn As New List(Of PYM00500ParameterHeaderStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New PYM00500ParameterCLS
        Dim loEx As New R_Exception
        Dim poParam As New PYM00500ParameterDTO

        Try
            poParam.cBpjstkGuid = R_Utility.R_GetStreamingContext("cGuid")

            loRtn = loCls.getBpjstkParameter(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00500ParameterHeaderStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBpjstkParameter")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParPYM00500 As System.Collections.Generic.List(Of PYM00500Back.PYM00500ParameterHeaderDTO), poParPYM00502 As System.Collections.Generic.List(Of PYM00500Back.PYM00500PerusahaanHeaderDTO)) Implements IPYM00500StreamingService.Dummy

    End Sub
End Class
