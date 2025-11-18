Imports R_Common
Imports SAM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02300Service" in code, svc and config file together.
Public Class SAM02300Service
    Implements ISAM02300Service

    Public Sub Svc_R_Delete(poEntity As SAM02300Back.SAM02300DTO) Implements R_BackEnd.R_IServicebase(Of SAM02300Back.SAM02300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02300Back.SAM02300DTO) As SAM02300Back.SAM02300DTO Implements R_BackEnd.R_IServicebase(Of SAM02300Back.SAM02300DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As SAM02300Back.SAM02300DTO, poCRUDMode As R_Common.eCRUDMode) As SAM02300Back.SAM02300DTO Implements R_BackEnd.R_IServicebase(Of SAM02300Back.SAM02300DTO).Svc_R_Save

    End Function
End Class
