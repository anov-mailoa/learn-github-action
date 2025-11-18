Imports R_Common
Imports SAI00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAI00100Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAI00100Service.svc or SAI00100Service.svc.vb at the Solution Explorer and start debugging.
Public Class SAI00100Service
    Implements ISAI00100Service

    Public Function GetCountHistory(pcCompanyId As String, pcTimeRange As String, pcUserId As String, pcProgram As String) As Integer Implements ISAI00100Service.GetCountHistory
        Dim loEx As New R_Exception
        Dim loCls As New SAI00100Cls
        Dim liRtn As Integer

        Try
            liRtn = loCls.GetCountHistory(pcCompanyId, pcTimeRange, pcUserId, pcProgram)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return liRtn
    End Function

    Public Sub DeleteHistory(pcCompanyId As String, pcTimeRange As String, pcUserId As String, pcProgram As String) Implements ISAI00100Service.DeleteHistory
        Dim loEx As New R_Exception
        Dim loCls As New SAI00100Cls

        Try
            loCls.DeleteHistory(pcCompanyId, pcTimeRange, pcUserId, pcProgram)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
