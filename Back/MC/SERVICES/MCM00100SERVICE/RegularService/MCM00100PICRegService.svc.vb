Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM00100Back

Public Class MCM00100PICRegService
    Implements IMCM00100PICRegService

    Public Sub Svc_R_Delete(poEntity As MCM00100Back.MCM00100PICDto) Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100PICDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100PICCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00100Back.MCM00100PICDto) As MCM00100Back.MCM00100PICDto Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100PICDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100PICCls
        Dim loRtn As New MCM00100PICDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00100Back.MCM00100PICDto, poCRUDMode As R_Common.eCRUDMode) As MCM00100Back.MCM00100PICDto Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100PICDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCLS As New MCM00100PICCls
        Dim loRtn As New MCM00100PICDto

        Try
            loRtn = loCLS.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
