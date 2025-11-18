Imports R_Common
Imports PYM01600Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01600Service" in code, svc and config file together.
Public Class PYM01600Service
    Implements IPYM01600Service

    Public Sub Svc_R_Delete(poEntity As PYM01600Back.PYM01600DTO) Implements R_BackEnd.R_IServicebase(Of PYM01600Back.PYM01600DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01600Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01600Back.PYM01600DTO) As PYM01600Back.PYM01600DTO Implements R_BackEnd.R_IServicebase(Of PYM01600Back.PYM01600DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01600Cls
        Dim loRtn As PYM01600DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01600Back.PYM01600DTO, poCRUDMode As R_Common.eCRUDMode) As PYM01600Back.PYM01600DTO Implements R_BackEnd.R_IServicebase(Of PYM01600Back.PYM01600DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01600Cls
        Dim loRtn As PYM01600DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
