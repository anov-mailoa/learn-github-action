' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02500Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02500Service.svc or SAM02500Service.svc.vb at the Solution Explorer and start debugging.
Imports R_BackEnd
Imports R_Common
Imports SAM02500Back
Imports TelerikMenuService

Public Class SAM02500Service
    Implements ISAM02500Service

    Public Sub Svc_R_Delete(poEntity As SAM02500DTO) Implements R_IServicebase(Of SAM02500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02500Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub Reprocess(pcCompanyId As String, pcEmailId As String) Implements ISAM02500Service.Reprocess
        Dim loEx As New R_Exception
        Dim loCls As New SAM02500Cls

        Try
            loCls.Reprocess(pcCompanyId, pcEmailId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02500DTO) As SAM02500DTO Implements R_IServicebase(Of SAM02500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM02500Cls
        Dim loRtn As SAM02500DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM02500DTO, poCRUDMode As eCRUDMode) As SAM02500DTO Implements R_IServicebase(Of SAM02500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM02500Cls
        Dim loRtn As SAM02500DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
