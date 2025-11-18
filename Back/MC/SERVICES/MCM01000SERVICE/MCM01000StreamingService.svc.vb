Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM01000Back
Imports MCM01000Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM01000StreamingService" in code, svc and config file together.
Public Class MCM01000StreamingService
    Implements IMCM01000StreamingService

    Public Function GetYearList() As System.ServiceModel.Channels.Message Implements IMCM01000StreamingService.GetYearList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As List(Of MCM01000StreamingDTO)
        Dim loParam As New MCM01000DTO
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetYearList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetYearList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poGrid As MCM01000Back.MCM01000GridDTO) Implements IMCM01000StreamingService.Dummy

    End Sub

    Public Function GetCMBRateType() As System.ServiceModel.Channels.Message Implements IMCM01000StreamingService.GetCMBRateType
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As List(Of MCM01000StreamingDTO)
        Dim loParam As New MCM01000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtn = loCls.GetCMBRateType(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCMBRateType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetDlogList() As System.ServiceModel.Channels.Message Implements IMCM01000StreamingService.GetDlogList
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As List(Of MCM01000StreamingDTO)
        Dim loParam As New MCM01000DTO
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetDlogList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDlogList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
