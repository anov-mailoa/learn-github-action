Imports R_Common
Imports R_BackEnd
Imports EST00100Back
Imports EST00100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST00100StreamingService" in code, svc and config file together.
Public Class EST00100StreamingService
    Implements IEST00100StreamingService

    Public Function GetTransactionList() As System.ServiceModel.Channels.Message Implements IEST00100StreamingService.GetTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New EST00100Cls
        Dim loRtnTemp As List(Of EST00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .CAPPROVAL_TRANS_TYPE = R_Utility.R_GetStreamingContext("CAPPROVAL_TRANS_TYPE")
            End With

            loRtnTemp = loCls.GetTransactionList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub ParamDTO(poPar As System.Collections.Generic.List(Of EST00100Back.EST00100DTO)) Implements IEST00100StreamingService.ParamDTO

    End Sub

    Public Function GetCmbReasonList() As System.ServiceModel.Channels.Message Implements IEST00100StreamingService.GetCmbReasonList
        Dim loEx As New R_Exception
        Dim loCls As New EST00100Cls
        Dim loRtnTemp As List(Of ComboBoxStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetCmbReasonList(loParam)

            loList = R_Utility.R_GetChunkData(Of ComboBoxStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbReasonList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransType(poParam As EST00100Back.EST00100DTO) As String Implements IEST00100StreamingService.getTransType
        Dim loEx As New R_Exception
        Dim loCls As New EST00100Cls
        Dim lcTemp As String

        Try
            lcTemp = loCls.getTransType(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcTemp
    End Function

    Public Function GetEscalateTransactionList() As System.ServiceModel.Channels.Message Implements IEST00100StreamingService.GetEscalateTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New EST00100Cls
        Dim loRtnTemp As List(Of EST00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .CAPPROVAL_TRANS_TYPE = R_Utility.R_GetStreamingContext("CAPPROVAL_TRANS_TYPE")
            End With

            loRtnTemp = loCls.GetEscalateTransactionList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEscalateTransactionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
