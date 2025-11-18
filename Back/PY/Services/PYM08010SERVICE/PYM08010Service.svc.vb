Imports System.ServiceModel
Imports R_Common
Imports PYM08010Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM08010Service" in code, svc and config file together.
Public Class PYM08010Service
    Implements IPYM08010Service

    Public Sub Svc_R_Delete(poEntity As PYM08010Back.PYM08010DTO) Implements R_BackEnd.R_IServicebase(Of PYM08010Back.PYM08010DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM08010CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM08010Back.PYM08010DTO) As PYM08010Back.PYM08010DTO Implements R_BackEnd.R_IServicebase(Of PYM08010Back.PYM08010DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM08010CLS
        Dim loRtn As New PYM08010DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM08010Back.PYM08010DTO, poCRUDMode As R_Common.eCRUDMode) As PYM08010Back.PYM08010DTO Implements R_BackEnd.R_IServicebase(Of PYM08010Back.PYM08010DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM08010CLS
        Dim loRtn As New PYM08010DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
