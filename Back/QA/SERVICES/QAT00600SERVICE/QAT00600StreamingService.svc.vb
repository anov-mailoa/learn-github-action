Imports R_BackEnd
Imports R_Common
Imports QAT00600Back
Imports QAT00600Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00600StreamingService" in code, svc and config file together.
Public Class QAT00600StreamingService
    Implements IQAT00600StreamingService

    Public Function SocializationReasonList() As System.ServiceModel.Channels.Message Implements IQAT00600StreamingService.SocializationReasonList
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtnTemp As List(Of QAT00600StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT00600DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.SocializationReasonList(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT00600StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "SocializationReasonList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SocializationRegList() As System.ServiceModel.Channels.Message Implements IQAT00600StreamingService.SocializationRegList
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtnTemp As List(Of QAT00600StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT00600DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.SocializationRegList(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT00600StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "SocializationRegList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of QAT00600Back.QAT00600RegDTO)) Implements IQAT00600StreamingService.Dummy

    End Sub

End Class
