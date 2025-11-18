' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07150Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT07150Back
Imports System.ServiceModel

Public Class PNT07150Service
    Implements IPNT07150Service

    Public Sub Svc_R_Delete(poEntity As PNT07150Back.PNT07150DTO) Implements R_BackEnd.R_IServicebase(Of PNT07150Back.PNT07150DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT07150Back.PNT07150DTO) As PNT07150Back.PNT07150DTO Implements R_BackEnd.R_IServicebase(Of PNT07150Back.PNT07150DTO).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS
        Dim loRtn As PNT07150DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNT07150Back.PNT07150DTO, poCRUDMode As R_Common.eCRUDMode) As PNT07150Back.PNT07150DTO Implements R_BackEnd.R_IServicebase(Of PNT07150Back.PNT07150DTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS
        Dim loRtn As PNT07150DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub checkStatusValidate(poParameter As PNT07150Back.PNT07150DTO) Implements IPNT07150Service.checkStatusValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS

        Try
            loCls.checkStatusValidate(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateAdd(poParameter As PNT07150Back.PNT07150DTO) Implements IPNT07150Service.checkStatusValidateAdd
        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS

        Try
            loCls.checkStatusValidateAdd(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateDelete(poParameter As PNT07150Back.PNT07150DTO) Implements IPNT07150Service.checkStatusValidateDelete
        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS

        Try
            loCls.checkStatusValidateDelete(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DraftUndraft(poParam As PNT07150Back.PNT07150DTO) As PNT07150Back.PNT07150DTO Implements IPNT07150Service.DraftUndraft

        Dim loEx As New R_Exception
        Dim loRtn As PNT07150DTO = Nothing
        Dim loCls As New PNT07150CLS

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Function Submit(poParam As PNT07150Back.PNT07150DTO) As PNT07150Back.PNT07150DTO Implements IPNT07150Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As PNT07150DTO = Nothing
        Dim loCls As New PNT07150CLS

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function getResignDate(poParameter As PNT07150Back.PNT07150DTO) As PNT07150Back.PNT07150DTO Implements IPNT07150Service.getResignDate
        Dim loEx As New R_Exception
        Dim loCls As New PNT07150CLS
        Dim loRtn As PNT07150DTO

        Try
            loRtn = loCls.getResignDate(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
