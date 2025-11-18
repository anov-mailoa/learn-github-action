Imports R_Common
Imports R_BackEnd
Imports GSM00400Back
Imports GSM00400Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00410StreamingService" in code, svc and config file together.
Public Class GSM00410StreamingService
    Implements IGSM00410StreamingService

    Public Function checkCenterDB() As System.ServiceModel.Channels.Message Implements IGSM00410StreamingService.checkCenterDB
        Dim loEx As New R_Exception
        Dim loCls As New GSM00400Cls
        Dim loRtnTemp As List(Of GSM00410DTO)
        Dim loRtn As Message = Nothing
        Dim loParam As List(Of GSM00410DTO)
        Dim loParamObj As String
        Dim loList As List(Of Byte())

        Try
            loParamObj = R_Utility.R_GetStreamingContext("oList")

            loParam = R_Utility.XMLToObject(Of List(Of GSM00410DTO))(loParamObj)

            loRtnTemp = loCls.checkCenterDB(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00410DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "checkCenterDB")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM00400Back.GSM00400DTO)) Implements IGSM00410StreamingService.Dummy

    End Sub
End Class
