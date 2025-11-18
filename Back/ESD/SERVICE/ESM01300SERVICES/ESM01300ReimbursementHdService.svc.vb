Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01300ReimbursementHdService" in code, svc and config file together.
Public Class ESM01300ReimbursementHdService
    Implements IESM01300ReimbursementHdService

    Public Sub Svc_R_Delete(poEntity As ESM01300Back.ESM01300ReimbursementHdDTO) Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300ReimbursementHdDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01300Back.ESM01300ReimbursementHdDTO) As ESM01300Back.ESM01300ReimbursementHdDTO Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300ReimbursementHdDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtn As New ESM01300ReimbursementHdDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01300Back.ESM01300ReimbursementHdDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01300Back.ESM01300ReimbursementHdDTO Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300ReimbursementHdDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtn As New ESM01300ReimbursementHdDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLimitPolicyYear(pcCompId As Object) As String Implements IESM01300ReimbursementHdService.GetLimitPolicyYear
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtn As String = ""

        Try
            loRtn = loCls.GetLimitPolicyYear(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLocalCurrency(pcCompId As Object) As String Implements IESM01300ReimbursementHdService.GetLocalCurrency
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtn As String = ""

        Try
            loRtn = loCls.GetLocalCurrency(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function GetRemainingLimit(poParam As ESM01300Back.ESM01300ReimbursementHdDTO) As Decimal Implements IESM01300ReimbursementHdService.GetRemainingLimit
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ESM01300ReimbursementHdCLS
    '    Dim loRtn As Decimal

    '    Try
    '        loRtn = loCls.GetRemainingLimit(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Annual Salary Card
    Public Function GetTaxStatus(poParam As ESM01300Back.ESM01300DTO) As String Implements IESM01300ReimbursementHdService.GetTaxStatus
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300AnnualSalaryCls
        Dim loRtn As String = ""

        Try
            loRtn = loCls.GetTaxStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCurrencyRate(poParam As ESM01300Back.ESM01300ReimbursementHdDTO) As Decimal Implements IESM01300ReimbursementHdService.GetCurrencyRate
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtn As New Decimal

        Try
            loRtn = loCls.GetCurrencyRate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedical(poParam As ESM01300Back.ESM01300ReimbursementHdDTO) As Integer Implements IESM01300ReimbursementHdService.GetMedical
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtn As New Integer

        Try
            loRtn = loCls.GetMedical(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub checkPassword(poParam As ESM01300Back.ESM01300DTO) Implements IESM01300ReimbursementHdService.checkPassword
        Dim loException As New R_Exception
        Dim loCls As New ESM01300AnnualSalaryCls
        Dim loParam As New ESM01300DTO

        Try
            loCls.checkPassword(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getPDF(poParam As ESM01300Back.ESM01300DTO) As ESM01300Back.ESM01300DTO Implements IESM01300ReimbursementHdService.getPDF
        Dim loException As New R_Exception
        Dim loCls As New ESM01300AnnualSalaryCls
        Dim loParam As New ESM01300DTO
        Dim loRtn As New ESM01300DTO

        Try
            loRtn = loCls.getPDF(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
