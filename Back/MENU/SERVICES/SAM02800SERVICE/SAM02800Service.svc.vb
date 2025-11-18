' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02800Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02800Service.svc or SAM02800Service.svc.vb at the Solution Explorer and start debugging.
Imports R_BackEnd
Imports R_Common
Imports SAM02800Back
Imports SAM02800Common
Imports TelerikMenuService

Public Class SAM02800Service
    Implements ISAM02800Service

    Public Sub Svc_R_Delete(poEntity As SAM02800DTO) Implements R_IServicebase(Of SAM02800DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02800DTO) As SAM02800DTO Implements R_IServicebase(Of SAM02800DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800Cls
        Dim loRtn As SAM02800DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM02800DTO, poCRUDMode As eCRUDMode) As SAM02800DTO Implements R_IServicebase(Of SAM02800DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800Cls
        Dim loRtn As SAM02800DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub AssignmentDashboardProcess(poEntity As AssignmentDashboardProcessDTO) Implements ISAM02800Service.AssignmentDashboardProcess
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800UserDashboardCls

        Try
            loCls.AssignmentDashboardProcess(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub DeleteUserDashboard(poEntity As DeleteUserDashboardDTO) Implements ISAM02800Service.DeleteUserDashboard
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800UserDashboardCls

        Try
            loCls.DeleteUserDashboard(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub EditUserDashboard(poEntity As EditUserDashboardDTO) Implements ISAM02800Service.EditUserDashboard
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800UserDashboardCls

        Try
            loCls.EditUserDashboard(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
