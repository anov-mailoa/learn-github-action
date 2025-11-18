Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ATT00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800ListService" in code, svc and config file together.
Public Class ATT00800ListService

    Implements IATT00800ListService

    Public Sub ProsesDelAttCorrTrans(ByVal poParam As ATT00800Back.ATT00800DTO) Implements IATT00800ListService.ProsesDelAttCorrTrans
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800Cls
        Try
            loCls.ProsesDelAttCorrTrans(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub ReDraftProses(ByVal poParam As ATT00800Back.ATT00800DTO) Implements IATT00800ListService.ReDraftProses
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800Cls
        Try
            loCls.ReDraftProses(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub SubmitProses(ByVal poParam As ATT00800Back.ATT00800DTO) Implements IATT00800ListService.SubmitProses
        Dim loEx As New R_Exception()
        Dim loCls As New ATT00800Cls
        Try
            loCls.SubmitProses(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
