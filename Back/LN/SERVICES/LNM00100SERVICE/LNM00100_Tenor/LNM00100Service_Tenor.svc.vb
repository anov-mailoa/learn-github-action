Imports R_BackEnd
Imports R_Common
Imports LNM00100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00100Service_Tenor" in code, svc and config file together.
Public Class LNM00100Service_Tenor
    Implements ILNM00100Service_Tenor

    Public Sub Svc_R_Delete(poEntity As LNM00100Back.LNM00100DtoTenor) Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100DtoTenor).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100_TenorCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00100Back.LNM00100DtoTenor) As LNM00100Back.LNM00100DtoTenor Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100DtoTenor).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100_TenorCls
        Dim loRtn As LNM00100DtoTenor

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00100Back.LNM00100DtoTenor, poCRUDMode As R_Common.eCRUDMode) As LNM00100Back.LNM00100DtoTenor Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100DtoTenor).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100_TenorCls
        Dim loRtn As LNM00100DtoTenor

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDataTenor(pcComId As String, cLoanType As String, cRangeCode As String) As LNM00100Back.LNM00100DtoTenor Implements ILNM00100Service_Tenor.GetDataTenor
        Dim loRtn As LNM00100DtoTenor
        Dim loCls As New LNM00100_TenorCls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.GetDataTenor(pcComId, cLoanType, cRangeCode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function MaxTerm(pcLoanType As String) As Integer Implements ILNM00100Service_Tenor.MaxTerm
        Dim loRtn As Integer
        Dim loCls As New LNM00100_TenorCls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.MaxTerm(pcLoanType)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetValidation(poParam As LNM00100Back.LNM00100DtoTenor) As LNM00100Back.LNM00100DtoTenor Implements ILNM00100Service_Tenor.GetValidation
        Dim loRtn As LNM00100DtoTenor
        Dim loCls As New LNM00100_TenorCls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.GetValidation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
