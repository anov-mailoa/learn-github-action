Imports R_BackEnd
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00200Service_LoanType" in code, svc and config file together.
Public Class LNM00200Service_LoanType
    Implements ILNM00200Service_LoanType

    Public Sub Svc_R_Delete(poEntity As LNM00200Back.LNM00200Dto) Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00200Back.LNM00200Dto) As LNM00200Back.LNM00200Dto Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls
        Dim loRtn As LNM00200Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00200Back.LNM00200Dto, poCRUDMode As R_Common.eCRUDMode) As LNM00200Back.LNM00200Dto Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00200Cls
        Dim loRtn As LNM00200Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function QueryTester(pcParam As String) As System.Collections.Generic.List(Of LNM00200Back.LNM00200Dto) Implements ILNM00200Service_LoanType.QueryTester
    '    Dim loRtn As New List(Of LNM00200Dto)
    '    Dim loCls As New LNM00200Cls
    '    Dim loEx As New R_Exception

    '    Try
    '        loRtn = loCls.QueryTester(pcParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function
End Class
