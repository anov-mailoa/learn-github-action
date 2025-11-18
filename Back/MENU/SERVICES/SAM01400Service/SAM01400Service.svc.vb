Imports R_Common
Imports SAM01400Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01400Service" in code, svc and config file together.
Public Class SAM01400Service
    Implements ISAM01400Service

    Public Sub Svc_R_Delete(poEntity As SAM01400Back.SAM01400DTO) Implements R_BackEnd.R_IServicebase(Of SAM01400Back.SAM01400DTO).Svc_R_Delete
        Dim loException As New R_Exception

        Try
            Dim loClass As New SAM01400Back.SAM01400Cls

            loClass.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM01400Back.SAM01400DTO) As SAM01400Back.SAM01400DTO Implements R_BackEnd.R_IServicebase(Of SAM01400Back.SAM01400DTO).Svc_R_GetRecord
        Dim loException As New R_Exception

        Try
            Dim loClass As New SAM01400Back.SAM01400Cls

            Return loClass.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(poEntity As SAM01400Back.SAM01400DTO, poCRUDMode As R_Common.eCRUDMode) As SAM01400Back.SAM01400DTO Implements R_BackEnd.R_IServicebase(Of SAM01400Back.SAM01400DTO).Svc_R_Save
        Dim loException As New R_Exception

        Try
            Dim loClass As New SAM01400Back.SAM01400Cls

            Return loClass.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function CheckCompany() As Integer Implements ISAM01400Service.CheckCompany
        Dim loEx As New R_Exception
        Dim loCls As New SAM01400Cls

        Try
            Return loCls.CheckCompany()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
