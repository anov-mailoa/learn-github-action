Imports R_Common
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM00100Service" in code, svc and config file together.
Public Class PNM00100Service
    Implements IPNM00100Service

    Public Sub DoWork() Implements IPNM00100Service.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNM00100Back.PNM00100DTO) Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM00100Back.PNM00100DTO) As PNM00100Back.PNM00100DTO Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Dim loRtn As New PNM00100DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM00100Back.PNM00100DTO, poCRUDMode As R_Common.eCRUDMode) As PNM00100Back.PNM00100DTO Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Dim loRtn As New PNM00100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getRecord(poParam As PNM00100Back.PNM00100DTO) As PNM00100Back.PNM00100DTO Implements IPNM00100Service.getRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Dim loRtn As New PNM00100DTO
        Try
            loRtn = loCls.getRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkPntTransactionHd(poParam As PNM00100Back.PNM00100DTO) As Boolean Implements IPNM00100Service.checkPntTransactionHd
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Dim loRtn As New Boolean
        Try
            loRtn = loCls.checkPntTransactionHd(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub RSP_ADD_EMPLOYEE_TYPE() Implements IPNM00100Service.RSP_ADD_EMPLOYEE_TYPE
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Try
            loCls.RSP_ADD_EMPLOYEE_TYPE()
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getCheckSyntax(poParam As PNM00100Back.PNM00100DTO) As PNM00100Back.PNM00100DTO Implements IPNM00100Service.getCheckSyntax
        Dim loRtn As New PNM00100DTO
        Dim loCls As New PNM00100CLS
        Dim loEx As New R_Exception

        Try

            loRtn = loCls.getCheckSyntax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
