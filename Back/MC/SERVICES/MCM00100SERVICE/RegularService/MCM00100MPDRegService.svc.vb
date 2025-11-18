Imports R_BackEnd
Imports R_Common
Imports MCM00100Back
Imports System.ServiceModel

Public Class MCM00100MPDRegService
    Implements IMCM00100MPDRegService

    Public Sub Svc_R_Delete(poEntity As MCM00100Back.MCM00100MPDDto) Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100MPDDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100MPDCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00100Back.MCM00100MPDDto) As MCM00100Back.MCM00100MPDDto Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100MPDDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100MPDCls
        Dim loRtn As New MCM00100MPDDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00100Back.MCM00100MPDDto, poCRUDMode As R_Common.eCRUDMode) As MCM00100Back.MCM00100MPDDto Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100MPDDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCLS As New MCM00100MPDCls
        Dim loRtn As New MCM00100MPDDto

        Try
            loRtn = loCLS.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
