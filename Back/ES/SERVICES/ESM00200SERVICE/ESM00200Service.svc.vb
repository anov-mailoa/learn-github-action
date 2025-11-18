Imports System.ServiceModel
Imports R_Common
Imports ESM00200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00200Service" in code, svc and config file together.
Public Class ESM00200Service
    Implements IESM00200Service

    Public Sub Svc_R_Delete(poEntity As ESM00200Back.ESM00200DTO) Implements R_BackEnd.R_IServicebase(Of ESM00200Back.ESM00200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00200Back.ESM00200DTO) As ESM00200Back.ESM00200DTO Implements R_BackEnd.R_IServicebase(Of ESM00200Back.ESM00200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200CLS
        Dim loRtn As ESM00200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00200Back.ESM00200DTO, poCRUDMode As R_Common.eCRUDMode) As ESM00200Back.ESM00200DTO Implements R_BackEnd.R_IServicebase(Of ESM00200Back.ESM00200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200CLS
        Dim loRtn As ESM00200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkUseInEssRole(poParam As ESM00200Back.ESM00200DTO) As Boolean Implements IESM00200Service.checkUseInEssRole
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkUseInEssRole(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
