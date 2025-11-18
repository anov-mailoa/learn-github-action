Imports System.ServiceModel
Imports ATF00100Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATF00100Service" in code, svc and config file together.
Public Class ATF00100Service
    Implements IATF00100Service

    Public Sub Svc_R_Delete(poEntity As ATF00100Back.ATF00100DTO) Implements R_BackEnd.R_IServicebase(Of ATF00100Back.ATF00100DTO).Svc_R_Delete
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            loClass.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATF00100Back.ATF00100DTO) As ATF00100Back.ATF00100DTO Implements R_BackEnd.R_IServicebase(Of ATF00100Back.ATF00100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            Return loClass.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(poEntity As ATF00100Back.ATF00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATF00100Back.ATF00100DTO Implements R_BackEnd.R_IServicebase(Of ATF00100Back.ATF00100DTO).Svc_R_Save
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            Return loClass.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function BatchValidation(poParam As ATF00100Back.ATF00100DTO) As ATF00100Back.ATF00100DTO Implements IATF00100Service.BatchValidation
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            Return loClass.BatchValidation(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub DeleteBatchSection(poParam As ATF00100Back.ATF00100DTO) Implements IATF00100Service.DeleteBatchSection
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            loClass.DeleteBatchSection(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DeleteBatchValidation(poParam As ATF00100Back.ATF00100DTO) As ATF00100Back.ATF00100DTO Implements IATF00100Service.DeleteBatchValidation
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            Return loClass.DeleteBatchValidation(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub DeleteSection(poParam As ATF00100Back.ATF00100DTO) Implements IATF00100Service.DeleteSection
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            loClass.DeleteSection(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DeleteValidation(poParam As ATF00100Back.ATF00100DTO) As ATF00100Back.ATF00100DTO Implements IATF00100Service.DeleteValidation
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATF00100Cls

            Return loClass.DeleteValidation(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
