Imports System.ServiceModel
Imports R_Common
Imports PYM08100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM08100Service" in code, svc and config file together.
Public Class PYM08100Service
    Implements IPYM08100Service

    Public Function getLastSeq(pcCompId As String) As Integer Implements IPYM08100Service.getLastSeq
        Dim loEx As New R_Exception
        Dim loCls As New PYM08100CLS
        Dim liCheck As Integer
        Try
            liCheck = loCls.getLastSeq(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liCheck
    End Function

    Public Sub Svc_R_Delete(poEntity As PYM08100Back.PYM08100DTO) Implements R_BackEnd.R_IServicebase(Of PYM08100Back.PYM08100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM08100CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM08100Back.PYM08100DTO) As PYM08100Back.PYM08100DTO Implements R_BackEnd.R_IServicebase(Of PYM08100Back.PYM08100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM08100CLS
        Dim loRtn As New PYM08100DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM08100Back.PYM08100DTO, poCRUDMode As R_Common.eCRUDMode) As PYM08100Back.PYM08100DTO Implements R_BackEnd.R_IServicebase(Of PYM08100Back.PYM08100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM08100CLS
        Dim loRtn As New PYM08100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub saveFullNameParam(poParam As System.Collections.Generic.List(Of PYM08100Back.PYM08100GridDTO)) Implements IPYM08100Service.saveFullNameParam
        Dim loEx As New R_Exception
        Dim loCls As New PYM08100CLS
        Try
            loCls.saveFullNameParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub getCheckSyntax(plBreakToEmpLvl As Boolean, pcSyntax As String, plFilterFormula As Boolean) Implements IPYM08100Service.getCheckSyntax
        Dim loCls As New PYM08100CLS
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(plBreakToEmpLvl, pcSyntax, plFilterFormula)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
