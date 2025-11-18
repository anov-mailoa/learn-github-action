Imports R_BackEnd
Imports R_Common
Imports LNM00100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00100Service_Reguler" in code, svc and config file together.
Public Class LNM00100Service_Reguler
    Implements ILNM00100Service_Reguler

    Public Sub Svc_R_Delete(poEntity As LNM00100Back.LNM00100Dto) Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00100Back.LNM00100Dto) As LNM00100Back.LNM00100Dto Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100Cls
        Dim loRtn As LNM00100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00100Back.LNM00100Dto, poCRUDMode As R_Common.eCRUDMode) As LNM00100Back.LNM00100Dto Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100Cls
        Dim loRtn As LNM00100Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataLoan(pcCoid As String) As LNM00100Back.LNM00100Dto Implements ILNM00100Service_Reguler.getDataLoan
        Dim loRtn As New LNM00100Dto
        Dim loCls As New LNM00100Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getDataLoan(pcCoid)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataLogin(pcCoid As String) As LNM00100Back.LNM00100Dto Implements ILNM00100Service_Reguler.getDataLogin
        Dim loRtn As New LNM00100Dto
        Dim loCls As New LNM00100Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getDataLogin(pcCoid)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub InsertNullData(poParam As LNM00100Back.LNM00100Dto) Implements ILNM00100Service_Reguler.InsertNullData
        Dim loCls As New LNM00100Cls
        Dim loEx As New R_Exception

        Try
            loCls.InsertNullData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function ValidateAuthority(poParam As LNM00100Back.LNM00100Dto) As Integer Implements ILNM00100Service_Reguler.ValidateAuthority
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.ValidateAuthority(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
