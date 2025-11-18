Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
Imports ESM00100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00100StreamingService" in code, svc and config file together.
Public Class ESM00100StreamingService
    Implements IESM00100StreamingService

    Public Function GetApprovalCodeList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetApprovalCodeList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralCls
        Dim loRtnTemp As List(Of ESM00100NonStructuralStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CAPPROVAL_MODE = R_Utility.R_GetStreamingContext("CAPPROVAL_MODE")
                .LEXCEPTION = R_Utility.R_GetStreamingContext("LEXCEPTION")
            End With

            loRtnTemp = loCls.GetApprovalCodeList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100NonStructuralStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetApprovalCodeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetApprovalPositionsList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetApprovalPositionsList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralCls
        Dim loRtnTemp As List(Of ESM00100NonStructuralStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CAPPROVAL_CODE = R_Utility.R_GetStreamingContext("CAPPROVAL_CODE")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")

                .CAPPROVAL_MODE = R_Utility.R_GetStreamingContext("CAPPROVAL_MODE")
                .LEXCEPTION = R_Utility.R_GetStreamingContext("LEXCEPTION")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CFLAG = R_Utility.R_GetStreamingContext("CFLAG")
            End With

            loRtnTemp = loCls.GetApprovalPositionsList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100NonStructuralStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetApprovalPositionsList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetApproverList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetApproverList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralApproverCls
        Dim loRtnTemp As List(Of ESM00100NonStructuralStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CAPPROVAL_CODE = R_Utility.R_GetStreamingContext("CAPPROVAL_CODE")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetApproverList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100NonStructuralStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetApproverList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls
        Dim loRtnTemp As List(Of ESM00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.GetTransactionList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetPositionLookUpList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetPositionLookUpList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls
        Dim loRtnTemp As List(Of ESM00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CAPPROVAL_CODE = R_Utility.R_GetStreamingContext("CAPPROVAL_CODE")
                .LAPPROVER = R_Utility.R_GetStreamingContext("LAPPROVER")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetPositionLookUpList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetPositionLookUpList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetStructuralPositionsList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetStructuralPositionsList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100StructuralCls
        Dim loRtnTemp As List(Of ESM00100StructuralStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CAPPROVAL_CODE = R_Utility.R_GetStreamingContext("CAPPROVAL_CODE")
                .LAPPROVER = R_Utility.R_GetStreamingContext("LAPPROVER")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetStructuralPositionsList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100StructuralStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetStructuralPositionsList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEscalateLookUpList() As System.ServiceModel.Channels.Message Implements IESM00100StreamingService.GetEscalateLookUpList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralApproverCls
        Dim loRtnTemp As List(Of ESM00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM00100ParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CAPPROVER_CODE = R_Utility.R_GetStreamingContext("CAPPROVER_CODE")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetEscalateLookUpList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEscalateLookUpList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DummyDTO(poPar As System.Collections.Generic.List(Of ESM00100Back.ESM00100ParamDTO)) Implements IESM00100StreamingService.DummyDTO

    End Sub

End Class
