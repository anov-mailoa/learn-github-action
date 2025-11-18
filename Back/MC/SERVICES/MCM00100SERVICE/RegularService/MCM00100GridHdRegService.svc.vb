Imports R_BackEnd
Imports R_Common
Imports MCM00100Back
Imports System.ServiceModel

Public Class MCM00100GridHdRegService
    Implements IMCM00100GridHdRegService

    Public Sub Svc_R_Delete(poEntity As MCM00100Back.MCM00100FormHdDto) Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100FormHdDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100GridHdCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00100Back.MCM00100FormHdDto) As MCM00100Back.MCM00100FormHdDto Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100FormHdDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100GridHdCls
        Dim loRtn As New MCM00100FormHdDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00100Back.MCM00100FormHdDto, poCRUDMode As R_Common.eCRUDMode) As MCM00100Back.MCM00100FormHdDto Implements R_BackEnd.R_IServicebase(Of MCM00100Back.MCM00100FormHdDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCLS As New MCM00100GridHdCls
        Dim loRtn As New MCM00100FormHdDto

        Try
            loRtn = loCLS.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Activate(poParam As MCM00100Back.MCM00100FormHdDto) As MCM00100Back.MCM00100FormHdDto Implements IMCM00100GridHdRegService.Activate
        Dim loEx As New R_Exception
        Dim loCls As New MCM00100GridHdCls
        Dim loRtn As New MCM00100FormHdDto

        Try
            loRtn = loCls.Activate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
