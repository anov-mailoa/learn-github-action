Imports R_BackEnd
Imports R_Common
Imports PYM01300Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports PYM01300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01300StreamingService" in code, svc and config file together.
Public Class PYM01300StreamingService
    Implements IPYM01300StreamingService

    Public Function getNemObjekPajak() As System.ServiceModel.Channels.Message Implements IPYM01300StreamingService.getNemObjekPajak
        Dim loRtn As New List(Of PYM01300StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New PYM01300Cls
        Dim loEx As New R_Exception
        Dim poParam As New PYM01300GridDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With
            loRtn = loCls.getNemObjekPajak(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "NemObjekPajak")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParamGrid As System.Collections.Generic.List(Of PYM01300Back.PYM01300GridDTO)) Implements IPYM01300StreamingService.Dummy

    End Sub
End Class
