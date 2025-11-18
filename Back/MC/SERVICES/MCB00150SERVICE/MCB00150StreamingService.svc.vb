Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCB00150Back
Imports MCB00150Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCB00150StreamingService" in code, svc and config file together.
Public Class MCB00150StreamingService
    Implements IMCB00150StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IMCB00150StreamingService.GetEmployeeList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCB00150Cls
        Dim loRtn As List(Of MCB00150StreamingDTO)
        Dim loParam As New MCB00150DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtn = loCls.GetEmployeeList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB00150StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetYearList() As System.ServiceModel.Channels.Message Implements IMCB00150StreamingService.GetYearList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCB00150Cls
        Dim loRtn As List(Of MCB00150StreamingDTO)
        Dim loParam As New MCB00150DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtn = loCls.GetYearList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB00150StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetYearList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub ParamDTO(poPar As System.Collections.Generic.List(Of MCB00150Back.MCB00150DTO)) Implements IMCB00150StreamingService.ParamDTO

    End Sub

    Public Function GetDimensionList() As System.ServiceModel.Channels.Message Implements IMCB00150StreamingService.GetDimensionList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCB00150Cls
        Dim loRtn As List(Of MCB00150StreamingDTO)
        Dim loParam As New MCB00150DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtn = loCls.GetDimensionList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB00150StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDimensionList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetMedicalRuleList() As System.ServiceModel.Channels.Message Implements IMCB00150StreamingService.GetMedicalRuleList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCB00150Cls
        Dim loRtn As List(Of MCB00150StreamingDTO)
        Dim loParam As New MCB00150DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
            End With

            loRtn = loCls.GetMedicalRuleList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB00150StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalRuleList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
