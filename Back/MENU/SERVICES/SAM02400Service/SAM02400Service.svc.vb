' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02400Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02400Service.svc or SAM02400Service.svc.vb at the Solution Explorer and start debugging.
Imports R_BackEnd
Imports R_Common
Imports SAM02400Back
Imports TelerikMenuService

Public Class SAM02400Service
    Implements ISAM02400Service

    Public Sub Svc_R_Delete(poEntity As SAM02400DTO) Implements R_IServicebase(Of SAM02400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02400DTO) As SAM02400DTO Implements R_IServicebase(Of SAM02400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM02400Cls
        Dim loRtn As SAM02400DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM02400DTO, poCRUDMode As eCRUDMode) As SAM02400DTO Implements R_IServicebase(Of SAM02400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM02400Cls
        Dim loRtn As SAM02400DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckSMTPId(pcSMTPId As String) As String Implements ISAM02400Service.CheckSMTPId
        Dim loEx As New R_Exception
        Dim loCls As New SAM02400Cls
        Dim loRtn As String = ""

        Try
            loRtn = loCls.CheckSMTPId(pcSMTPId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
