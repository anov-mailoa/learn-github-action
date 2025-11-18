Imports R_Common
Imports PYM01100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01100Service" in code, svc and config file together.
Public Class PYM01100Service
    Implements IPYM01100Service

    Public Sub Svc_R_Delete(poEntity As PYM01100Back.PYM01100DTO) Implements R_BackEnd.R_IServicebase(Of PYM01100Back.PYM01100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01100Back.PYM01100DTO) As PYM01100Back.PYM01100DTO Implements R_BackEnd.R_IServicebase(Of PYM01100Back.PYM01100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01100Cls
        Dim loRtn As PYM01100DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01100Back.PYM01100DTO, poCRUDMode As R_Common.eCRUDMode) As PYM01100Back.PYM01100DTO Implements R_BackEnd.R_IServicebase(Of PYM01100Back.PYM01100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01100Cls
        Dim loRtn As PYM01100DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function getPymFormula(pcCompId As String) As System.Collections.Generic.List(Of PYM01100Back.PYM01100DTO) Implements IPYM01100Service.getPymFormula
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYM01100Cls
    '    Dim loRtn As List(Of PYM01100DTO) = Nothing

    '    Try
    '        loRtn = loCls.getPymFormula(pcCompId)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Sub CheckSyntax(pcCompId As String, pcSyntax As String) Implements IPYM01100Service.CheckSyntax
        Dim loCls As New PYM01100Cls
        Dim loEx As New R_Exception


        Try
            loCls.CheckSyntax(pcCompId, pcSyntax)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkFormulaUsage(poParam As PYM01100Back.PYM01100DTO) As Boolean Implements IPYM01100Service.checkFormulaUsage
        Dim loCls As New PYM01100Cls
        Dim loEx As New R_Exception
        Dim llCheck As Boolean


        Try
            llCheck = loCls.checkFormulaUsage(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llCheck
    End Function
End Class
