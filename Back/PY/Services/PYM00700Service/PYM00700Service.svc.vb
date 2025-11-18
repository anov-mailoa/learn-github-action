Imports R_Common
Imports PYM00700Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00700Service" in code, svc and config file together.
Public Class PYM00700Service
    Implements IPYM00700Service

    Public Sub Svc_R_Delete(poEntity As PYM00700Back.PYM00700DTO) Implements R_BackEnd.R_IServicebase(Of PYM00700Back.PYM00700DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New PYM00700Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00700Back.PYM00700DTO) As PYM00700Back.PYM00700DTO Implements R_BackEnd.R_IServicebase(Of PYM00700Back.PYM00700DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtn As PYM00700DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00700Back.PYM00700DTO, poCRUDMode As R_Common.eCRUDMode) As PYM00700Back.PYM00700DTO Implements R_BackEnd.R_IServicebase(Of PYM00700Back.PYM00700DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtn As PYM00700DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function getTransferCodeHd(poEntity As PYM00700Back.PYM00700DTO) As System.Collections.Generic.List(Of PYM00700Back.PYM00700DTO) Implements IPYM00700Service.getTransferCodeHd
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYM00700Cls
    '    Dim loRtn As List(Of PYM00700DTO) = Nothing

    '    Try
    '        loRtn = loCls.getTransferCodeHd(poEntity)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function getTransferCodeDt(poEntity As PYM00700Back.PYM00700DTO) As System.Collections.Generic.List(Of PYM00700Back.PYM00700DTO) Implements IPYM00700Service.getTransferCodeDt
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYM00700Cls
    '    Dim loRtn As List(Of PYM00700DTO) = Nothing

    '    Try
    '        loRtn = loCls.getTransferCodeDt(poEntity)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function getSalaryTransferHd(poEntity As PYM00700Back.PYM00700DTO) As System.Collections.Generic.List(Of PYM00700Back.PYM00700DTO) Implements IPYM00700Service.getSalaryTransferHd
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYM00700Cls
    '    Dim loRtn As List(Of PYM00700DTO) = Nothing

    '    Try
    '        loRtn = loCls.getSalaryTransferHd(poEntity)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function checkSalaryTransferHd(poEntity As PYM00700Back.PYM00700DTO) As PYM00700Back.PYM00700DTO Implements IPYM00700Service.checkSalaryTransferHd
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYM00700Cls
    '    Dim loRtn As PYM00700DTO = Nothing

    '    Try
    '        loRtn = loCls.checkSalaryTransferHd(poEntity)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function cekSalaryTransferHd(poEntity As PYM00700Back.PYM00700DTO) As Boolean Implements IPYM00700Service.cekSalaryTransferHd
        Dim loException As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekSalaryTransferHd(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkBankAccount(poEntity As PYM00700Back.PYM00700DTO) As Boolean Implements IPYM00700Service.checkBankAccount
        Dim loException As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkBankAccount(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
