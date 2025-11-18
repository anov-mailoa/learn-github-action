Imports R_Common
Imports R_BackEnd
Imports GSM01400Back
Imports GSM01400Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01400StreamingService" in code, svc and config file together.
Public Class GSM01400StreamingService
    Implements IGSM01400StreamingService


    Public Function getMasterTemplateList() As System.ServiceModel.Channels.Message Implements IGSM01400StreamingService.getMasterTemplateList
        Dim loEx As New R_Exception
        Dim loCls As New GSM01400Cls
        Dim loRtnTemp As List(Of GSM01400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01400DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getMasterTemplateList(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMasterTemplateList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
