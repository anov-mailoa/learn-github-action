Imports R_Common
Imports PYB00200Back
Imports SIAPP_SERVICE_PY

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00200Service" in code, svc and config file together.
Public Class PYB00200Service
    Implements IPYB00200Service

    Public Function checkEmpBankTransfer(poParam As PYB00200Back.PYB00200Grid_R) As Integer Implements IPYB00200Service.checkEmpBankTransfer
        Dim loEx As New R_Exception
        Dim liCheck As Integer
        Dim loCls As New PYB00200Cls

        Try
            liCheck = loCls.checkEmpBankTransfer(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liCheck
    End Function

    Public Function GetSingleResignSalaryProcess(poParam As PYB00200Back.PYB00200Dto) As PYB00200Back.PYB00200Dto Implements IPYB00200Service.GetSingleResignSalaryProcess
        Dim loEx As New R_Exception
        Dim loRtn As New PYB00200Dto
        Dim loCls As New PYB00200Cls

        Try
            loRtn = loCls.GetSingleResignSalaryProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetSingleSalaryProcess(poParam As PYB00200Back.PYB00200Dto) As PYB00200Back.PYB00200Grid_R Implements IPYB00200Service.GetSingleSalaryProcess
        Dim loEx As New R_Exception
        Dim loRtn As New PYB00200Grid_R
        Dim loCls As New PYB00200Cls

        Try
            loRtn = loCls.GetSingleSalaryProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub cancelExtendResign(poParam As PYB00200Back.PYB00200Dto) Implements IPYB00200Service.cancelExtendResign
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls

        Try
            loCls.cancelExtendResign(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkValidasiWarning(poParam As PYB00200Grid_R) As String Implements IPYB00200Service.checkValidasiWarning
        Dim loEx As New R_Exception
        Dim liCheck As String
        Dim loCls As New PYB00200Cls

        Try
            liCheck = loCls.checkValidasiWarning(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liCheck
    End Function
End Class
