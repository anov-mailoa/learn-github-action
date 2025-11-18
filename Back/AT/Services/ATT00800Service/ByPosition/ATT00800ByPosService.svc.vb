Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ATT00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800ByPosService" in code, svc and config file together.
Public Class ATT00800ByPosService
    Implements IATT00800ByPosService

    Public Sub prosesSave(ByVal poParam As ATT00800Back.ATT00800ByPosDTO) Implements IATT00800ByPosService.prosesSave
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800ByPosCls
        Try
            loCls.prosesSave(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub prosesSaveAsDraft(ByVal poParam As ATT00800Back.ATT00800ByPosDTO) Implements IATT00800ByPosService.prosesSaveAsDraft
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800ByPosCls
        Try
            loCls.prosesSaveAsDraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
