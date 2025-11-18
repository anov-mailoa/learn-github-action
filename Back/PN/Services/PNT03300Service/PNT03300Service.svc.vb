' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03300Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT03300Back
Imports System.ServiceModel

Public Class PNT03300Service
    Implements IPNT03300Service

    Public Sub Svc_R_Delete(poEntity As PNT03300Back.PNT03300DTO) Implements R_BackEnd.R_IServicebase(Of PNT03300Back.PNT03300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03300Back.PNT03300DTO) As PNT03300Back.PNT03300DTO Implements R_BackEnd.R_IServicebase(Of PNT03300Back.PNT03300DTO).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS
        Dim loRtn As PNT03300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNT03300Back.PNT03300DTO, poCRUDMode As R_Common.eCRUDMode) As PNT03300Back.PNT03300DTO Implements R_BackEnd.R_IServicebase(Of PNT03300Back.PNT03300DTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS
        Dim loRtn As PNT03300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub checkStatusValidate(poParameter As PNT03300Back.PNT03300DTO) Implements IPNT03300Service.checkStatusValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS

        Try
            loCls.checkStatusValidate(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateAdd(poParameter As PNT03300Back.PNT03300DTO) Implements IPNT03300Service.checkStatusValidateAdd
        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS

        Try
            loCls.checkStatusValidateAdd(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateDelete(poParameter As PNT03300Back.PNT03300DTO) Implements IPNT03300Service.checkStatusValidateDelete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS

        Try
            loCls.checkStatusValidateDelete(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DraftUndraft(poParam As PNT03300Back.PNT03300DTO) As PNT03300Back.PNT03300DTO Implements IPNT03300Service.DraftUndraft

        Dim loEx As New R_Exception
        Dim loRtn As PNT03300DTO = Nothing
        Dim loCls As New PNT03300CLS

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Function Submit(poParam As PNT03300Back.PNT03300DTO) As PNT03300Back.PNT03300DTO Implements IPNT03300Service.Submit

        Dim loEx As New R_Exception
        Dim loRtn As PNT03300DTO = Nothing
        Dim loCls As New PNT03300CLS

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Sub EmployeeOfficialDataValidation(poParameter As PNT03300Back.PNT03300DTO) Implements IPNT03300Service.EmployeeOfficialDataValidation

        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS

        Try
            loCls.EmployeeOfficialDataValidation(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Reject(poParam As PNT03300Back.PNT03300DTO) As PNT03300Back.PNT03300DTO Implements IPNT03300Service.Reject
        Dim loEx As New R_Exception
        Dim loRtn As PNT03300DTO = Nothing
        Dim loCls As New PNT03300CLS

        Try
            loRtn = loCls.Reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkInterface(pcCompanyId As String) As PNT03300Back.PNT03300DTO Implements IPNT03300Service.checkInterface
        Dim loEx As New R_Exception
        Dim loCls As New PNT03300CLS
        Dim loRtn As New PNT03300DTO

        Try
            loRtn = loCls.checkInterface(pcCompanyId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
