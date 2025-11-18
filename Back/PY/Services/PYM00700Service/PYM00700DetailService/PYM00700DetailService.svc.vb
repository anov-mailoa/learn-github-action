Imports R_Common
Imports PYM00700Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00700DetailService" in code, svc and config file together.
Public Class PYM00700DetailService
    Implements IPYM00700DetailService

    Public Sub Svc_R_Delete(poEntity As PYM00700Back.PYM00700DetailDTO) Implements R_BackEnd.R_IServicebase(Of PYM00700Back.PYM00700DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00700DetailCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00700Back.PYM00700DetailDTO) As PYM00700Back.PYM00700DetailDTO Implements R_BackEnd.R_IServicebase(Of PYM00700Back.PYM00700DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00700DetailCls
        Dim loRtn As PYM00700DetailDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00700Back.PYM00700DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00700Back.PYM00700DetailDTO Implements R_BackEnd.R_IServicebase(Of PYM00700Back.PYM00700DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00700DetailCls
        Dim loRtn As PYM00700DetailDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
