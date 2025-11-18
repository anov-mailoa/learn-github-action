Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
Imports ESM01300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01300LoanEntryService" in code, svc and config file together.
Public Class ESM01300LoanEntryService
    Implements IESM01300LoanEntryService

    Public Sub Svc_R_Delete(poEntity As ESM01300Back.ESM01300LoanParameterDTO) Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300LoanParameterDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanEntryCLS
        Dim loParam As New ESM01300LoanParameterDTO

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01300Back.ESM01300LoanParameterDTO) As ESM01300Back.ESM01300LoanParameterDTO Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300LoanParameterDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanEntryCLS
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loRtn As New ESM01300LoanParameterDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01300Back.ESM01300LoanParameterDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01300Back.ESM01300LoanParameterDTO Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300LoanParameterDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanEntryCLS
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loRtn As New ESM01300LoanParameterDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRecord(poParam As ESM01300Back.ESM01300LoanParameterDTO) As ESM01300Back.ESM01300LoanParameterDTO Implements IESM01300LoanEntryService.getRecord
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loRtn As New ESM01300LoanParameterDTO

        Try
            loRtn = loCls.R_GetRecord(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function CheckLoanPrincipal(poParam As ESM01300Back.ESM01300LoanParameterDTO) As String Implements IESM01300LoanEntryService.CheckLoanPrincipal
    '    Dim loException As New R_Exception
    '    Dim loCls As New ESM01300LoanEntryCLS
    '    Dim loParam As New ESM01300LoanParameterDTO
    '    Dim loRtn As String = ""

    '    Try
    '        loRtn = loCls.CheckLoanPrincipal(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function GetInterestInstallment(poParam As ESM01300Back.ESM01300LoanParameterDTO) As ESM01300Back.ESM01300LoanEntryDTO Implements IESM01300LoanEntryService.GetInterestInstallment
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanEntryCLS
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loRtn As New ESM01300LoanEntryDTO

        Try
            loRtn = loCls.GetInterestInstallment(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
