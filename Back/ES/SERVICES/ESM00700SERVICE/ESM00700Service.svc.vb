Imports R_Common
Imports ESM00700Back
Imports SIAPP_SERVICE_ES

' NOTE: You can use the "Rename" command on the context menu to change the class name "GST0200Service" in code, svc and config file together.
Public Class ESM00700Service
    Implements IESM00700Service

    Public Sub sSetPasswordExpired(poParam As ESM00700DTO) Implements IESM00700Service.sSetPasswordExpired
        Dim loException As New R_Exception

        Try
            Dim loClass As New ESM00700Cls

            loClass.sSetPasswordExpired(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub Svc_R_Delete(poEntity As ESM00700Back.ESM00700DTO) Implements R_BackEnd.R_IServicebase(Of ESM00700Back.ESM00700DTO).Svc_R_Delete
        Dim loException As New R_Exception

        Try
            Dim loClass As New ESM00700Cls

            loClass.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00700Back.ESM00700DTO) As ESM00700Back.ESM00700DTO Implements R_BackEnd.R_IServicebase(Of ESM00700Back.ESM00700DTO).Svc_R_GetRecord
        Dim loException As New R_Exception

        Try
            Dim loClass As New ESM00700Cls

            Return loClass.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(poEntity As ESM00700Back.ESM00700DTO, poCRUDMode As R_Common.eCRUDMode) As ESM00700Back.ESM00700DTO Implements R_BackEnd.R_IServicebase(Of ESM00700Back.ESM00700DTO).Svc_R_Save
        Dim loException As New R_Exception

        Try
            Dim loClass As New ESM00700Cls

            Return loClass.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
