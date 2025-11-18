Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01300ReimbursementDtService" in code, svc and config file together.
Public Class ESM01300ReimbursementDtService
    Implements IESM01300ReimbursementDtService

    Public Sub Svc_R_Delete(poEntity As ESM01300Back.ESM01300ReimbursementDtDTO) Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300ReimbursementDtDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementDtCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01300Back.ESM01300ReimbursementDtDTO) As ESM01300Back.ESM01300ReimbursementDtDTO Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300ReimbursementDtDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementDtCLS
        Dim loRtn As New ESM01300ReimbursementDtDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01300Back.ESM01300ReimbursementDtDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01300Back.ESM01300ReimbursementDtDTO Implements R_BackEnd.R_IServicebase(Of ESM01300Back.ESM01300ReimbursementDtDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementDtCLS
        Dim loRtn As New ESM01300ReimbursementDtDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
