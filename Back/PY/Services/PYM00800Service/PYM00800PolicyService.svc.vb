Imports R_Common
Imports PYM00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00800PolicyService" in code, svc and config file together.
Public Class PYM00800PolicyService
    Implements IPYM00800PolicyService

    Public Sub Svc_R_Delete(poEntity As PYM00800Back.PYM00800PolicyDTO) Implements R_BackEnd.R_IServicebase(Of PYM00800Back.PYM00800PolicyDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00800Back.PYM00800PolicyDTO) As PYM00800Back.PYM00800PolicyDTO Implements R_BackEnd.R_IServicebase(Of PYM00800Back.PYM00800PolicyDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyCls
        Dim loRtn As PYM00800PolicyDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00800Back.PYM00800PolicyDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00800Back.PYM00800PolicyDTO Implements R_BackEnd.R_IServicebase(Of PYM00800Back.PYM00800PolicyDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyCls
        Dim loRtn As PYM00800PolicyDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkSalaryPolicyUsage(poParam As PYM00800Back.PYM00800PolicyDTO) As Boolean Implements IPYM00800PolicyService.checkSalaryPolicyUsage
        Dim loRtn As Boolean
        Dim loCls As New PYM00800PolicyCls
        Dim loException As New R_Exception

        Try
            loRtn = loCls.checkSalaryPolicyUsage(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkPolicyDetail(poParam As PYM00800Back.PYM00800PolicyDTO) As Boolean Implements IPYM00800PolicyService.checkPolicyDetail
        Dim loRtn As Boolean
        Dim loCls As New PYM00800PolicyCls
        Dim loException As New R_Exception

        Try
            loRtn = loCls.checkPolicyDetail(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYM00800Back.PYM00800UsageDTO)) Implements IPYM00800PolicyService.Dummy

    End Sub

End Class
