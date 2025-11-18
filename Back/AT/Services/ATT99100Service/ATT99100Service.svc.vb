Imports ATT99100Back
Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT99100Service" in code, svc and config file together.
Public Class ATT99100Service
    Implements IATT99100Service

    Public Sub Svc_R_Delete(poEntity As ATT99100Back.ATT99100DTO) Implements R_BackEnd.R_IServicebase(Of ATT99100Back.ATT99100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT99100Back.ATT99100DTO) As ATT99100Back.ATT99100DTO Implements R_BackEnd.R_IServicebase(Of ATT99100Back.ATT99100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT99100Back.ATT99100DTO, poCRUDMode As R_Common.eCRUDMode) As ATT99100Back.ATT99100DTO Implements R_BackEnd.R_IServicebase(Of ATT99100Back.ATT99100DTO).Svc_R_Save

    End Function

    Public Function getTransType(poParam As ATT99100Back.ATT99100DTO) As String Implements IATT99100Service.getTransType
        Dim loEx As New R_Exception
        Dim loCls As New ATT99100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getTransType(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub cancelProcess(poParam As ATT99100Back.ATT99100DTO) Implements IATT99100Service.cancelProcess
        Dim loEx As New R_Exception
        Dim loCls As New ATT99100Cls

        Try
            loCls.cancelProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getTable(poParam As ATT99100Back.ATT99100DTO) As String Implements IATT99100Service.getTable
        Dim loEx As New R_Exception
        Dim loCls As New ATT99100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getTable(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
