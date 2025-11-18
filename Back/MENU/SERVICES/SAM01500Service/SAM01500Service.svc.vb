Imports R_Common
Imports SAM01500Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01500Service" in code, svc and config file together.
Public Class SAM01500Service
    Implements ISAM01500Service

    Public Sub Svc_R_Delete(poEntity As SAM01500Back.SAM01500DTO) Implements R_BackEnd.R_IServicebase(Of SAM01500Back.SAM01500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM01500Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM01500Back.SAM01500DTO) As SAM01500Back.SAM01500DTO Implements R_BackEnd.R_IServicebase(Of SAM01500Back.SAM01500DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As SAM01500Back.SAM01500DTO, poCRUDMode As R_Common.eCRUDMode) As SAM01500Back.SAM01500DTO Implements R_BackEnd.R_IServicebase(Of SAM01500Back.SAM01500DTO).Svc_R_Save

    End Function
End Class
