Imports R_Common
Imports PYM01200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01200HeaderService" in code, svc and config file together.
Public Class PYM01200HeaderService
    Implements IPYM01200HeaderService

    Public Sub Svc_R_Delete(poEntity As PYM01200Back.PYM01200SalaryHeaderDTO) Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200SalaryHeaderDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01200Back.PYM01200SalaryHeaderDTO) As PYM01200Back.PYM01200SalaryHeaderDTO Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200SalaryHeaderDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200SalaryHeaderCls
        Dim loRtn As New PYM01200SalaryHeaderDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01200Back.PYM01200SalaryHeaderDTO, poCRUDMode As R_Common.eCRUDMode) As PYM01200Back.PYM01200SalaryHeaderDTO Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200SalaryHeaderDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200SalaryHeaderCls
        Dim loRtn As New PYM01200SalaryHeaderDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLocalCurrency(poParam As String) As String Implements IPYM01200HeaderService.getLocalCurrency
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200SalaryHeaderCls
        Dim loRtn As String

        Try
            loRtn = loCls.getLocalCurrency(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function cekProsesGaji(poParam As PYM01200Back.PYM01200SalaryHeaderDTO) As Integer Implements IPYM01200HeaderService.cekProsesGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200SalaryHeaderCls
        Dim liCheck As Integer

        Try
            liCheck = loCls.cekProsesGaji(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liCheck
    End Function

End Class
