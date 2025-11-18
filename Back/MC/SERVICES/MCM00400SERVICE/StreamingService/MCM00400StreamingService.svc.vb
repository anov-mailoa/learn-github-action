Imports R_BackEnd
Imports R_Common
Imports MCM00400Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCM00400Common

Public Class MCM00400StreamingService
    Implements IMCM00400StreamingService
    Public Function getMCM00400list() As System.ServiceModel.Channels.Message Implements IMCM00400StreamingService.getMCM00400list
        Dim loParam As New MCM00400GridDto
        Dim loRtn As List(Of MCM00400StreamingDto)
        Dim loRtnMsg As Message
        Dim loEx As New R_Exception
        Dim loCls As New MCM00400Cls
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.getMCM00400list(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM00400StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMCM00400list")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMsg
    End Function

End Class
