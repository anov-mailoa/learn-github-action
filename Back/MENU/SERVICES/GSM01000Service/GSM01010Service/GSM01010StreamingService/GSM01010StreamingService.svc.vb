Imports R_Common
Imports R_BackEnd
Imports GSM01000Back
Imports GSM01000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01010StreamingService" in code, svc and config file together.
Public Class GSM01010StreamingService
    Implements IGSM01010StreamingService

    Public Function getDataGridTransNum() As System.ServiceModel.Channels.Message Implements IGSM01010StreamingService.getDataGridTransNum
        Dim loException As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtnTemp As List(Of GSM01010DocNumGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01010DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getDataGridTransNum(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01010DocNumGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataGridTransNum")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM01000Back.GSM01010DocNumGridDTO)) Implements IGSM01010StreamingService.Dummy

    End Sub
End Class
