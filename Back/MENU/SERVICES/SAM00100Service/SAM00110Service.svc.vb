Imports System.ServiceModel
Imports R_Common
Imports SAM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM00110Service" in code, svc and config file together.
Public Class SAM00110Service
    Implements ISAM00110Service

    Public Sub Svc_R_Delete(poEntity As SAM00100Back.SAM00110DTO) Implements R_BackEnd.R_IServicebase(Of SAM00100Back.SAM00110DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM00110Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM00100Back.SAM00110DTO) As SAM00100Back.SAM00110DTO Implements R_BackEnd.R_IServicebase(Of SAM00100Back.SAM00110DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM00110Cls
        Dim loRtn As SAM00110DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM00100Back.SAM00110DTO, poCRUDMode As R_Common.eCRUDMode) As SAM00100Back.SAM00110DTO Implements R_BackEnd.R_IServicebase(Of SAM00100Back.SAM00110DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM00110Cls
        Dim loRtn As SAM00110DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
