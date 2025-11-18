Imports System.ServiceModel
Imports R_Common
Imports PYM04500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM04500Service" in code, svc and config file together.
Public Class PYM04500Service
    Implements IPYM04500Service

    Public Sub Svc_R_Delete(poEntity As PYM04500Back.PYM04500DTO) Implements R_BackEnd.R_IServicebase(Of PYM04500Back.PYM04500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM04500CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM04500Back.PYM04500DTO) As PYM04500Back.PYM04500DTO Implements R_BackEnd.R_IServicebase(Of PYM04500Back.PYM04500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM04500CLS
        Dim loRtn As New PYM04500DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM04500Back.PYM04500DTO, poCRUDMode As R_Common.eCRUDMode) As PYM04500Back.PYM04500DTO Implements R_BackEnd.R_IServicebase(Of PYM04500Back.PYM04500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM04500CLS
        Dim loRtn As New PYM04500DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub saveFullNameParam(poParam As System.Collections.Generic.List(Of PYM04500Back.PYM04500GridDTO)) Implements IPYM04500Service.saveFullNameParam
        Dim loEx As New R_Exception
        Dim loCls As New PYM04500CLS
        Try
            loCls.saveFullNameParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub getCheckSyntax(pcSyntax As String, plFilter As Boolean) Implements IPYM04500Service.getCheckSyntax
        Dim loCls As New PYM04500CLS
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcSyntax, plFilter)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
