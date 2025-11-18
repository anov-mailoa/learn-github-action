Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM06100Service" in code, svc and config file together.
Public Class PNM06100Service
    Implements IPNM06100Service

    Public Sub Svc_R_Delete(poEntity As PNM06100Back.PNM06100DTO) Implements R_BackEnd.R_IServicebase(Of PNM06100Back.PNM06100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM06100LetterTemplateCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM06100Back.PNM06100DTO) As PNM06100Back.PNM06100DTO Implements R_BackEnd.R_IServicebase(Of PNM06100Back.PNM06100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM06100LetterTemplateCLS
        Dim loRtn As PNM06100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM06100Back.PNM06100DTO, poCRUDMode As R_Common.eCRUDMode) As PNM06100Back.PNM06100DTO Implements R_BackEnd.R_IServicebase(Of PNM06100Back.PNM06100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM06100LetterTemplateCLS
        Dim loRtn As PNM06100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
