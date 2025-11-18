Imports System.ServiceModel
Imports R_Common
Imports ESM00300Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00300Service" in code, svc and config file together.
Public Class ESM00300Service
    Implements IESM00300Service

    Public Sub Svc_R_Delete(poEntity As ESM00300Back.ESM00300DTO) Implements R_BackEnd.R_IServicebase(Of ESM00300Back.ESM00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00300CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00300Back.ESM00300DTO) As ESM00300Back.ESM00300DTO Implements R_BackEnd.R_IServicebase(Of ESM00300Back.ESM00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00300CLS
        Dim loRtn As ESM00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00300Back.ESM00300DTO, poCRUDMode As R_Common.eCRUDMode) As ESM00300Back.ESM00300DTO Implements R_BackEnd.R_IServicebase(Of ESM00300Back.ESM00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00300CLS
        Dim loRtn As ESM00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkUseEssMember(poParam As ESM00300Back.ESM00300DTO) As Boolean Implements IESM00300Service.checkUseEssMember
        Dim loEx As New R_Exception
        Dim loCls As New ESM00300CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkUseEssMember(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
