Imports System.ServiceModel
Imports R_Common
Imports PYM01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM01100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01100StreamingService" in code, svc and config file together.
Public Class PYM01100StreamingService
    Implements IPYM01100StreamingService

    Public Function getPymFormula() As System.ServiceModel.Channels.Message Implements IPYM01100StreamingService.getPymFormula
        Dim loEx As New R_Exception
        Dim loCls As New PYM01100Cls
        Dim loRtn As New List(Of PYM01100GridDTOnon)
        Dim loRtnMessage As Message
        Dim poParam As String

        Try
            poParam = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getPymFormula(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01100GridDTOnon)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPymFormula")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParGrid As System.Collections.Generic.List(Of PYM01100Back.PYM01100GridDTO)) Implements IPYM01100StreamingService.Dummy

    End Sub
End Class
