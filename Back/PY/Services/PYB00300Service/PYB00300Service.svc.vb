Imports R_Common
Imports PYB00300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00300Service" in code, svc and config file together.
Public Class PYB00300Service
    Implements IPYB00300Service

    Public Sub cekProsesGaji(poParam As PYB00300Back.PYB00300DTO) Implements IPYB00300Service.cekProsesGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYB00300CLS

        Try
            loCls.cekProsesGaji(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetEndPeriod(poParam As PYB00300Back.PYB00300DTO) As String Implements IPYB00300Service.GetEndPeriod
        Dim loEx As New R_Exception
        Dim loRtn As String
        Dim loCls As New PYB00300CLS

        Try
            loRtn = loCls.GetEndPeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetSalaryGroup(poParam As PYB00300Back.PYB00300DTO) As PYB00300Back.PYB00300DTO Implements IPYB00300Service.GetSalaryGroup
        Dim loEx As New R_Exception
        Dim loRtn As New PYB00300DTO
        Dim loCls As New PYB00300CLS

        Try
            loRtn = loCls.GetSalaryGroup(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPayrollSytemParameter(pcCompId As String) As Integer Implements IPYB00300Service.getPayrollSytemParameter
        Dim loEx As New R_Exception
        Dim loCls As New PYB00300CLS
        Dim liCheck As Integer

        Try
            liCheck = loCls.getPayrollSytemParameter(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liCheck
    End Function
End Class
