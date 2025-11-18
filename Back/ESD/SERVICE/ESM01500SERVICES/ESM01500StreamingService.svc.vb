Imports R_Common
Imports ESM01500Back
Imports System.ServiceModel.Channels
Imports ESM01500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01100StreamingService" in code, svc and config file together.
Public Class ESM01500StreamingService
    Implements IESM01500StreamingService
    Public Function getDelegateList() As System.ServiceModel.Channels.Message Implements IESM01500StreamingService.getDelegateList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01500CLS
        Dim loRtnTemp As List(Of ESM01500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01500ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CFLAG = R_Utility.R_GetStreamingContext("CFLAG")
            End With

            loRtnTemp = loCls.getDelegateList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDelegateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
