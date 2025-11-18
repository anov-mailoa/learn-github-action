Imports R_BackEnd
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports LNM00200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00200Service_Streaming" in code, svc and config file together.
Public Class LNM00200Service_Streaming
    Implements ILNM00200Service_Streaming

    Public Function getDataGrid() As System.ServiceModel.Channels.Message Implements ILNM00200Service_Streaming.getDataGrid
        Dim loRtn As New List(Of LNM00200Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNM00200Cls
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Dim loParam As New LNM00200Dto
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanCategory = R_Utility.R_GetStreamingContext("cLoanCategory")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtn = loCls.getDataGrid(loParam)
            loList = R_Utility.R_GetChunkData(Of LNM00200Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLoanType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getLoanCategory() As System.ServiceModel.Channels.Message Implements ILNM00200Service_Streaming.getLoanCategory
        Dim loRtn As New List(Of LNM00200Category_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNMCategoryCls
        Dim loEx As New R_Exception
        Dim poParam As String
        Dim loList As List(Of Byte())

        Try
            poParam = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getLoanCategory(poParam)
            loList = R_Utility.R_GetChunkData(Of LNM00200Category_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLoanCategory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNM00200Back.LNM00200Dto_R), poParComboBox As System.Collections.Generic.List(Of LNM00200Back.LNM00200CmbDto), poDimension As System.Collections.Generic.List(Of LNM00200Back.LNM00200DimensionDto)) Implements ILNM00200Service_Streaming.Dummy

    End Sub
End Class
