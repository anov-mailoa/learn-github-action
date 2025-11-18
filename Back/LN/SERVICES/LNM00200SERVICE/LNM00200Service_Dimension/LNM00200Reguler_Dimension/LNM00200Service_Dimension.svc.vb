Imports R_BackEnd
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00201Service" in code, svc and config file together.
Public Class LNM00200Service_Dimension
    Implements ILNM00200Service_Dimension

    Public Sub Svc_R_Delete(poEntity As LNM00200Back.LNM00200Dto_Dimension) Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Dto_Dimension).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00200Back.LNM00200Dto_Dimension) As LNM00200Back.LNM00200Dto_Dimension Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Dto_Dimension).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls_Dimension
        Dim loRtn As LNM00200Dto_Dimension

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00200Back.LNM00200Dto_Dimension, poCRUDMode As R_Common.eCRUDMode) As LNM00200Back.LNM00200Dto_Dimension Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Dto_Dimension).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls_Dimension
        Dim loRtn As LNM00200Dto_Dimension

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getValidate(pcCompId As String, pcLoanType As String) As Integer Implements ILNM00200Service_Dimension.getValidate
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls_Dimension
        Dim loRtn As Integer

        Try
            loRtn = loCls.getValidate(pcCompId, pcLoanType)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RSP_Build_Loan_Policy_Matrix(poParam As LNM00200Back.LNM00200Dto_Dimension) Implements ILNM00200Service_Dimension.RSP_Build_Loan_Policy_Matrix
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls_Dimension

        Try
            loCls.RSP_Build_Loan_Policy_Matrix(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
