' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02700Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02700Service.svc or SAM02700Service.svc.vb at the Solution Explorer and start debugging.
Imports R_BackEnd
Imports R_Common
Imports SAM02700Back

Public Class SAM02700Service
    Implements ISAM02700Service

    Public Sub Svc_R_Delete(poEntity As SAM02700DTO) Implements R_IServicebase(Of SAM02700DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02700Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02700DTO) As SAM02700DTO Implements R_IServicebase(Of SAM02700DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM02700Cls
        Dim loRtn As SAM02700DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM02700DTO, poCRUDMode As eCRUDMode) As SAM02700DTO Implements R_IServicebase(Of SAM02700DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM02700Cls
        Dim loRtn As SAM02700DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
