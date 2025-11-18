Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ATT00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800ByEmpService" in code, svc and config file together.
Public Class ATT00800ByEmpService
    Implements IATT00800ByEmpService

    Public Sub prosesSave(ByVal poParam As ATT00800Back.ATT00800ByEmpDTO) Implements IATT00800ByEmpService.prosesSave
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800ByEmpCls
        Try
            'loCls.prosesSave(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub prosesSaveAsDraft(ByVal poParam As ATT00800Back.ATT00800ByEmpDTO) Implements IATT00800ByEmpService.prosesSaveAsDraft
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800ByEmpCls
        Try
            'loCls.prosesSaveAsDraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
