Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM00300Back
Imports MCM00300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00300StreamingService" in code, svc and config file together.
Public Class MCM00300StreamingService
    Implements IMCM00300StreamingService

    Public Function GetBankList() As System.ServiceModel.Channels.Message Implements IMCM00300StreamingService.GetBankList
        Dim loRtnMessage As Message
        Dim loEx As New R_Exception
        Dim loCls As New MCM00300CLS
        Dim loRtn As List(Of MCM00300StreamingDTO)
        Dim loParam As New MCM00300DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetBankList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetBankList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetAccountList() As System.ServiceModel.Channels.Message Implements IMCM00300StreamingService.GetAccountList
        Dim loRtnMessage As Message
        Dim loEx As New R_Exception
        Dim loCls As New MCM00300CLS
        Dim loRtn As List(Of MCM00300StreamingDTO)
        Dim loParam As New MCM00300DTO
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cCbCode = R_Utility.R_GetStreamingContext("cCbCode")

            loRtn = loCls.GetAccountList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetAccountList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


    Public Function GetDlogList() As System.ServiceModel.Channels.Message Implements IMCM00300StreamingService.GetDlogList
        Dim loRtnMessage As Message
        Dim loEx As New R_Exception
        Dim loCls As New MCM00300CLS
        Dim loRtn As List(Of MCM00300StreamingDTO)
        Dim loParam As New MCM00300DTO
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetDlogList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDlogList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poGrid As MCM00300Back.MCM00300GridDTO) Implements IMCM00300StreamingService.Dummy

    End Sub
End Class
