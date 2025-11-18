Imports System.ServiceModel
Imports R_Common
Imports PYM08000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM08000Service" in code, svc and config file together.
Public Class PYM08000Service
    Implements IPYM08000Service

    Public Sub Svc_R_Delete(poEntity As PYM08000Back.PYM08000DTO) Implements R_BackEnd.R_IServicebase(Of PYM08000Back.PYM08000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM08000CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM08000Back.PYM08000DTO) As PYM08000Back.PYM08000DTO Implements R_BackEnd.R_IServicebase(Of PYM08000Back.PYM08000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM08000CLS
        Dim loRtn As New PYM08000DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM08000Back.PYM08000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM08000Back.PYM08000DTO Implements R_BackEnd.R_IServicebase(Of PYM08000Back.PYM08000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM08000CLS
        Dim loRtn As New PYM08000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLastSeq(pcCompId As String) As Integer Implements IPYM08000Service.getLastSeq
        Dim loEx As New R_Exception
        Dim loCls As New PYM08000CLS
        Dim liCheck As Integer
        Try
            liCheck = loCls.getLastSeq(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liCheck
    End Function

    Public Sub getCheckSyntax(pcCompId As String, pcSyntax As String) Implements IPYM08000Service.getCheckSyntax
        Dim loCls As New PYM08000CLS
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcCompId, pcSyntax)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub saveFullNameParam(poParam As System.Collections.Generic.List(Of PYM08000Back.PYM08000DTO)) Implements IPYM08000Service.saveFullNameParam
        Dim loEx As New R_Exception
        Dim loCls As New PYM08000CLS
        Try
            loCls.saveFullNameParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
