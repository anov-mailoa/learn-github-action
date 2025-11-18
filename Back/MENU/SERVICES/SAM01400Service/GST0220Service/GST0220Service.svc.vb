Imports R_Common
Imports SAM01400Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GST0220Service" in code, svc and config file together.
Public Class GST0220Service
    Implements IGST0220Service

    Public Sub Svc_R_Delete(poEntity As SAM01400Back.GST0220DTO) Implements R_BackEnd.R_IServicebase(Of SAM01400Back.GST0220DTO).Svc_R_Delete
        Dim loException As New R_Exception

        Try
            Dim loClass As New GST0220Cls

            loClass.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM01400Back.GST0220DTO) As SAM01400Back.GST0220DTO Implements R_BackEnd.R_IServicebase(Of SAM01400Back.GST0220DTO).Svc_R_GetRecord
        Dim loException As New R_Exception

        Try
            Dim loClass As New GST0220Cls

            Return loClass.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(poEntity As SAM01400Back.GST0220DTO, poCRUDMode As R_Common.eCRUDMode) As SAM01400Back.GST0220DTO Implements R_BackEnd.R_IServicebase(Of SAM01400Back.GST0220DTO).Svc_R_Save
        Dim loException As New R_Exception

        Try
            Dim loClass As New GST0220Cls

            Return loClass.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function svcGetUserExceptionList() As System.Collections.Generic.List(Of SAM01400Back.GST0220DTO) Implements IGST0220Service.svcGetUserExceptionList
        Dim loException As New R_Exception

        Try
            Dim loClass As New GST0220Cls

            Return loClass.fGetUserExceptionList()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function svcGetUserList() As System.Collections.Generic.List(Of SAM01400Back.GST0220UserDTO) Implements IGST0220Service.svcGetUserList
        Dim loException As New R_Exception

        Try
            Dim loClass As New GST0220Cls

            Return loClass.fGetUserList()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
