Imports System.ServiceModel
Imports R_Common
Imports ESM00600Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00600Service" in code, svc and config file together.
Public Class ESM00600Service
    Implements IESM00600Service

    Public Sub Svc_R_Delete(poEntity As ESM00600Back.ESM00600DTO) Implements R_BackEnd.R_IServicebase(Of ESM00600Back.ESM00600DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00600Back.ESM00600DTO) As ESM00600Back.ESM00600DTO Implements R_BackEnd.R_IServicebase(Of ESM00600Back.ESM00600DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00600CLS
        Dim loRtn As New ESM00600DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00600Back.ESM00600DTO, poCRUDMode As R_Common.eCRUDMode) As ESM00600Back.ESM00600DTO Implements R_BackEnd.R_IServicebase(Of ESM00600Back.ESM00600DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00600CLS
        Dim loRtn As New ESM00600DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
