Imports R_Common
Imports R_BackEnd
Imports GSM01000Back
Imports GSM01000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01030StreamingService" in code, svc and config file together.
Public Class GSM01030StreamingService
    Implements IGSM01030StreamingService

    Public Function getTransParam() As System.ServiceModel.Channels.Message Implements IGSM01030StreamingService.getTransParam
        Dim loException As New R_Exception
        Dim loCls As New GSM01030Cls
        Dim loRtnTemp As List(Of GSM01030ParamDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01030ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getTransParam(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01030ParamDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransParam")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
