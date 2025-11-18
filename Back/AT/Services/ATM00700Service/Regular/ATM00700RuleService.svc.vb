Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00700RuleService" in code, svc and config file together.
Public Class ATM00700RuleService
    Implements IATM00700RuleService

    Public Sub Svc_R_Delete(poEntity As ATM00700Back.ATM00700RulesDTO) Implements R_BackEnd.R_IServicebase(Of ATM00700Back.ATM00700RulesDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00700RulesCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00700Back.ATM00700RulesDTO) As ATM00700Back.ATM00700RulesDTO Implements R_BackEnd.R_IServicebase(Of ATM00700Back.ATM00700RulesDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00700RulesCls
        Dim loRtn As New ATM00700RulesDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00700Back.ATM00700RulesDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00700Back.ATM00700RulesDTO Implements R_BackEnd.R_IServicebase(Of ATM00700Back.ATM00700RulesDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00700RulesCls
        Dim loRtn As New ATM00700RulesDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
