Imports R_BackEnd
Imports R_Common
Imports LNM00100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00100Service_Medical" in code, svc and config file together.
Public Class LNM00100Service_Medical
    Implements ILNM00100Service_Medical

    Public Sub Svc_R_Delete(poEntity As LNM00100Back.LNM00100DtoMedical) Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100DtoMedical).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100_Medical_Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00100Back.LNM00100DtoMedical) As LNM00100Back.LNM00100DtoMedical Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100DtoMedical).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100_Medical_Cls
        Dim loRtn As LNM00100DtoMedical

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00100Back.LNM00100DtoMedical, poCRUDMode As R_Common.eCRUDMode) As LNM00100Back.LNM00100DtoMedical Implements R_BackEnd.R_IServicebase(Of LNM00100Back.LNM00100DtoMedical).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00100_Medical_Cls
        Dim loRtn As LNM00100DtoMedical

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedical(pcCoid As String) As LNM00100Back.LNM00100DtoMedical Implements ILNM00100Service_Medical.GetMedical
        Dim loRtn As New LNM00100DtoMedical
        Dim loCls As New LNM00100_Medical_Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.GetMedical(pcCoid)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
