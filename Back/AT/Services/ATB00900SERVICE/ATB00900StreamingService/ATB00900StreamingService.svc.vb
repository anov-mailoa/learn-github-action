' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00900StreamingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports ATB00900Common
Imports ATB00900Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATB00900StreamingService
    Implements IATB00900StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATB00900StreamingService.getData

        Dim loRtn As New List(Of ATB00900StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00900CLS
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Dim lcCompanyId As String
        Dim lcUserId As String
        Dim lcKeyGuid As String
        Try
            lcCompanyId = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            lcUserId = R_Utility.R_GetStreamingContext("CUSER_ID")
            lcKeyGuid = R_Utility.R_GetStreamingContext("CKEY_GUID")

            loRtn = loCls.getData(lcCompanyId, lcUserId, lcKeyGuid)
            loList = R_Utility.R_GetChunkData(Of ATB00900StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

End Class
