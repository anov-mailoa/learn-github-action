Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYM00100Back
Imports PYM00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00100StreamingService" in code, svc and config file together.
Public Class PYM00100StreamingService
    Implements IPYM00100StreamingService

    Public Function getDataProportionalAtt() As System.ServiceModel.Channels.Message Implements IPYM00100StreamingService.getDataProportionalAtt
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls
        Dim poParam As New PYM00100DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM00100StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getDataProportionalAtt(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataProportionalAtt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetComboReportId() As System.ServiceModel.Channels.Message Implements IPYM00100StreamingService.GetComboReportId
        Dim loEx As New R_Exception
        Dim loCls As New PYM0010002CLS
        Dim poParam As String
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing

        Try
            poParam = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnList = loCls.GetComboReportId(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetComboReportId")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetComboTemplateId() As System.ServiceModel.Channels.Message Implements IPYM00100StreamingService.GetComboTemplateId
        Dim loEx As New R_Exception
        Dim loCls As New PYM0010002CLS
        Dim poParam As String
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing

        Try
            poParam = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnList = loCls.GetComboTemplateId(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetComboTemplateId")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
