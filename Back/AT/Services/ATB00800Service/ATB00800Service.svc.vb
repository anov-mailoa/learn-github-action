Imports System.ServiceModel
Imports R_Common
Imports ATB00800Back
Imports ATB00800Common
Imports R_BackEnd

Public Class ATB00800Service
    Implements IATB00800Service


    Public Sub Svc_R_Delete(poEntity As ATB00800Back.ATB00800DTO) Implements R_BackEnd.R_IServicebase(Of ATB00800Back.ATB00800DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATB00800CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATB00800Back.ATB00800DTO) As ATB00800Back.ATB00800DTO Implements R_BackEnd.R_IServicebase(Of ATB00800Back.ATB00800DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATB00800Back.ATB00800DTO, poCRUDMode As R_Common.eCRUDMode) As ATB00800Back.ATB00800DTO Implements R_BackEnd.R_IServicebase(Of ATB00800Back.ATB00800DTO).Svc_R_Save

    End Function

    Public Function DraftSubmit(poCurrent As ATB00800Back.ATB00800DTO) As ATB00800Back.ATB00800DTO Implements IATB00800Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATB00800CLS
        Dim loRtn As New ATB00800DTO

        Try
            loRtn = loCls.DraftSubmit(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpWorkGroupDesc(poCurrent As ATB00800Back.ATB00800DTO) As String Implements IATB00800Service.getLookUpWorkGroupDesc
        Dim loEx As New R_Exception
        Dim loCls As New ATB00800CLS
        Dim loRtn As String

        Try
            loRtn = loCls.getLookUpWorkGroupDesc(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
