Imports R_Common
Imports ESI00100Back
Imports ESI00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESI00100StreamingService" in code, svc and config file together.
Public Class ESI00100Service
    Implements IESI00100Service

    Public Function getOfficialInfo(poParam As ESI00100Back.ESI00100DTO) As ESI00100Back.ESI00100DTO Implements IESI00100Service.getOfficialInfo
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtn As New ESI00100DTO

        Try
            loRtn = loCls.getOfficialInfo(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAttendanceInfo(poParam As ESI00100Back.ESI00100DTO) As ESI00100Back.ESI00100DTO Implements IESI00100Service.getAttendanceInfo
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtn As New ESI00100DTO

        Try
            loRtn = loCls.getAttendanceInfo(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As ESI00100Back.ESI00100DTO) Implements R_BackEnd.R_IServicebase(Of ESI00100Back.ESI00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESI00100Back.ESI00100DTO) As ESI00100Back.ESI00100DTO Implements R_BackEnd.R_IServicebase(Of ESI00100Back.ESI00100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ESI00100Back.ESI00100DTO, poCRUDMode As R_Common.eCRUDMode) As ESI00100Back.ESI00100DTO Implements R_BackEnd.R_IServicebase(Of ESI00100Back.ESI00100DTO).Svc_R_Save

    End Function

    Public Function checkPassword(poParam As ESI00100Back.ESI00100DTO) As Integer Implements IESI00100Service.checkPassword
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim liRtn As Integer

        Try
            liRtn = loCls.checkPassword(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return liRtn
    End Function

    Public Sub saveNewPassword(poParam As ESI00100Back.ESI00100DTO) Implements IESI00100Service.saveNewPassword
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtn As New ESI00100DTO

        Try
            loCls.saveNewPassword(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub changePhoto(poParam As ESI00100Back.ESI00100DTO) Implements IESI00100Service.changePhoto
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtn As New ESI00100DTO

        Try
            loCls.changePhoto(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getAbsencePresentLeave(poParam As ESI00100Back.ESI00100DTO) As ESI00100Back.ESI00100DTO Implements IESI00100Service.getAbsencePresentLeave
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtn As New ESI00100DTO

        Try
            loRtn = loCls.getAbsencePresentLeave(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransaction(poParam As ESI00100Back.ESI00100DTO) As ESI00100Back.ESI00100DTO Implements IESI00100Service.getTransaction
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtn As New ESI00100DTO

        Try
           
            loRtn = loCls.getTransaction(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
