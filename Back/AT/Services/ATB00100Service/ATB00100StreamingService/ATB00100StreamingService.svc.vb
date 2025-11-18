' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00100StreamingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports ATB00100Common
Imports ATB00100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATB00100StreamingService
    Implements IATB00100StreamingService

    Public Function getMachine() As System.ServiceModel.Channels.Message Implements IATB00100StreamingService.getMachine

        Dim loRtn As New List(Of ATB00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00100CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00100DTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cGuid = R_Utility.R_GetStreamingContext("cGuid")

            loRtn = loCls.getMachine(poParam)
            loList = R_Utility.R_GetChunkData(Of ATB00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "MachineData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Sub Dummy(poParATB00100 As System.Collections.Generic.List(Of ATB00100Back.ATB00100GridDTO)) Implements IATB00100StreamingService.Dummy

    End Sub
End Class
