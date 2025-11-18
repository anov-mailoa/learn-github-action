Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM00300Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00300Service" in code, svc and config file together.
Public Class MCM00300Service
    Implements IMCM00300Service

    Public Sub Svc_R_Delete(poEntity As MCM00300Back.MCM00300DTO) Implements R_BackEnd.R_IServicebase(Of MCM00300Back.MCM00300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00300Back.MCM00300DTO) As MCM00300Back.MCM00300DTO Implements R_BackEnd.R_IServicebase(Of MCM00300Back.MCM00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00300CLS
        Dim loRtn As New MCM00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00300Back.MCM00300DTO, poCRUDMode As R_Common.eCRUDMode) As MCM00300Back.MCM00300DTO Implements R_BackEnd.R_IServicebase(Of MCM00300Back.MCM00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM00300CLS
        Dim loRtn As New MCM00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDlogRecord(poParam As MCM00300Back.MCM00300DTO) As MCM00300Back.MCM00300DTO Implements IMCM00300Service.GetDlogRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00300CLS
        Dim loRtn As New MCM00300DTO

        Try
            loRtn = loCls.GetDlogRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
