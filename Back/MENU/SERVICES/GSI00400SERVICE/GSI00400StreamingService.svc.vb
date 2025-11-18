Imports R_Common
Imports GSI00400Back
Imports GSI00400Common
Imports System.ServiceModel.Channels
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSI00400StreamingService" in code, svc and config file together.
Public Class GSI00400StreamingService
    Implements IGSI00400StreamingService

    Public Function getEmailList() As System.ServiceModel.Channels.Message Implements IGSI00400StreamingService.getEmailList
        Dim loException As New R_Exception
        Dim loCls As New GSI00400Cls
        Dim loRtnTemp As List(Of GSI00400StreamDTO)
        Dim loRtn As Message
        Dim loParam As New GSI00400DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.getEmailList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of GSI00400StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmailList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
