Imports R_Common
Imports R_BackEnd
Imports GSM00700Back
Imports GSM00700Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00700StreamingService" in code, svc and config file together.
Public Class GSM00700StreamingService
    Implements IGSM00700StreamingService

    Public Function getListGeography() As System.ServiceModel.Channels.Message Implements IGSM00700StreamingService.getListGeography
        Dim loException As New R_Exception
        Dim loCls As New GSM00700Cls
        Dim loRtnTemp As List(Of GSM00700StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New GSM00700DTO
        Dim loList As List(Of Byte())

        Try

            poParam.lActiveFlag = R_Utility.R_GetStreamingContext("lActiveFlag")

            loRtnTemp = loCls.getListGeography(poParam)
            loList = R_Utility.R_GetChunkData(Of GSM00700StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGeography")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM00700Back.GSM00700TreeDTO)) Implements IGSM00700StreamingService.Dummy

    End Sub
End Class
