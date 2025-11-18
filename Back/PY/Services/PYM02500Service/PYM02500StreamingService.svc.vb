Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM02500Back
Imports PYM02500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM02500StreamingService" in code, svc and config file together.
Public Class PYM02500StreamingService
    Implements IPYM02500StreamingService

    Public Function getListOfSubGrade() As System.ServiceModel.Channels.Message Implements IPYM02500StreamingService.getListOfSubGrade
        Dim loCls As New PYM02500CLS
        Dim loParam As New PYM02500DTO
        Dim loRtnList As New List(Of PYM02500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getListOfSubGrade(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM02500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfSubGrade")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListCurrency() As System.ServiceModel.Channels.Message Implements IPYM02500StreamingService.getListCurrency
        Dim loCls As New PYM02500CLS
        Dim loRtnList As New List(Of PYM02500StreamingDTO)
        Dim loRtn As Message
        Dim loEx As New R_Exception

        Try
            loRtnList = loCls.getListCurrency()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM02500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListCurrency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
