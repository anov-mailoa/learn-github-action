Imports R_BackEnd
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports LNM00200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00201Service_Streaming" in code, svc and config file together.
Public Class LNM00200Service_Streaming_Dimension
    Implements ILNM00200Service_Streaming_Dimension


    Public Sub Dummy(poParamStreaming As System.Collections.Generic.List(Of LNM00200Back.LNM00200Dto_Dimension_S), poParamReguler As System.Collections.Generic.List(Of LNM00200Back.LNM00200Dto_Dimension_R)) Implements ILNM00200Service_Streaming_Dimension.Dummy

    End Sub

    Public Function getGridDimension() As System.ServiceModel.Channels.Message Implements ILNM00200Service_Streaming_Dimension.getGridDimension

    End Function

    Public Function RSP_Get_Loan_Policy_Matrix() As System.ServiceModel.Channels.Message Implements ILNM00200Service_Streaming_Dimension.RSP_Get_Loan_Policy_Matrix
        Dim loRtn As New List(Of LNM00200DimensionStreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNM00200Cls_Dimension
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Dim loParam As New LNM00200Dto_Dimension
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")


            loRtn = loCls.RSP_Get_Loan_Policy_Matrix(loParam)
            loList = R_Utility.R_GetChunkData(Of LNM00200DimensionStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Get_Loan_Policy_Matrix")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class
