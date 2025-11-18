' NOTE: You can use the "Rename" command on the context menu to change the class name "GSB00100Service" in code, svc and config file together.
Imports R_Common
Imports GSB00100Back

Public Class GSB00100Service
    Implements IGSB00100Service

    Public Sub Svc_R_Delete(poEntity As GSB00100Back.GSB00100DTO) Implements R_BackEnd.R_IServicebase(Of GSB00100Back.GSB00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSB00100Back.GSB00100DTO) As GSB00100Back.GSB00100DTO Implements R_BackEnd.R_IServicebase(Of GSB00100Back.GSB00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSB00100CLS
        Dim loRtn As New GSB00100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSB00100Back.GSB00100DTO, poCRUDMode As R_Common.eCRUDMode) As GSB00100Back.GSB00100DTO Implements R_BackEnd.R_IServicebase(Of GSB00100Back.GSB00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSB00100CLS
        Dim loRtn As New GSB00100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
