Imports R_Common
Imports R_BackEnd
Imports GSM01200Back
Imports GSM01200Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01200StreamingService" in code, svc and config file together.
Public Class GSM01200StreamingService
    Implements IGSM01200StreamingService

    Public Function getGridCurr() As System.ServiceModel.Channels.Message Implements IGSM01200StreamingService.getGridCurr
        Dim loException As New R_Exception
        Dim loCls As New GSM01200Cls
        Dim loRtnTemp As List(Of GSM01200GridCurrDTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            loRtnTemp = loCls.getGridCurr()
            loList = R_Utility.R_GetChunkData(Of GSM01200GridCurrDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridCurr")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridRate() As System.ServiceModel.Channels.Message Implements IGSM01200StreamingService.getGridRate
        Dim loException As New R_Exception
        Dim loCls As New GSM01200Cls
        Dim loRtnTemp As List(Of GSM01200GridRateDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01200DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
            End With

            loRtnTemp = loCls.getGridRate(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01200GridRateDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridRate")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of GSM01200Back.GSM01200GridCurrDTO), poPar2 As System.Collections.Generic.List(Of GSM01200Back.GSM01200GridRateDTO)) Implements IGSM01200StreamingService.Dummy

    End Sub
End Class
