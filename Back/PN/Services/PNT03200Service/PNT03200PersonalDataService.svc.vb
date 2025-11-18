Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200PersonalDataService" in code, svc and config file together.
Public Class PNT03200PersonalDataService
    Implements IPNT03200PersonalDataService

    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200PersonalDataDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200PersonalDataDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200PersonalDataDTO) As PNT03200Back.PNT03200PersonalDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200PersonalDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls
        Dim loRtn As PNT03200PersonalDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200PersonalDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200PersonalDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200PersonalDataDTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls
        Dim loRtn As PNT03200PersonalDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT03200Back.PNT03200PersonalDataDTO) As PNT03200Back.PNT03200PersonalDataDTO Implements IPNT03200PersonalDataService.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As PNT03200PersonalDataDTO = Nothing

        Try
            loRtn = New PNT03200PersonalDataCls().DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As PNT03200Back.PNT03200PersonalDataDTO) As PNT03200Back.PNT03200PersonalDataDTO Implements IPNT03200PersonalDataService.Submit
        Dim loEx As New R_Exception
        Dim loRtn As PNT03200PersonalDataDTO = Nothing

        Try
            loRtn = New PNT03200PersonalDataCls().Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkStatusDraft(poParam As PNT03200Back.PNT03200PersonalDataDTO) As String Implements IPNT03200PersonalDataService.checkStatusDraft
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls

        Try
            loCls.checkStatusDraft(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub checkStatusValidate(poParam As PNT03200Back.PNT03200PersonalDataDTO) Implements IPNT03200PersonalDataService.checkStatusValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls

        Try
            loCls.checkStatusValidate(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateDelete(poParam As PNT03200Back.PNT03200PersonalDataDTO) Implements IPNT03200PersonalDataService.checkStatusValidateDelete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls

        Try
            loCls.checkStatusValidateDelete(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function validasiPersonalDataEmployeeKey(poParam As PNT03200Back.PNT03200PersonalDataDTO) As PNT03200Back.PNT03200PersonalDataDTO Implements IPNT03200PersonalDataService.validasiPersonalDataEmployeeKey
        Dim loEx As New R_Exception
        Dim loRtn As PNT03200PersonalDataDTO = Nothing

        Try
            loRtn = New PNT03200PersonalDataCls().validasiPersonalDataEmployeeKey(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub CheckValidateEmployeeResignation(poParam As PNT03200Back.PNT03200PersonalDataDTO) Implements IPNT03200PersonalDataService.CheckValidateEmployeeResignation
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls

        Try
            loCls.CheckValidateEmployeeResignation(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getPersonalData(poParam As PNT03200Back.PNT03200PersonalDataDTO) As PNT03200Back.PNT03200PersonalDataDTO Implements IPNT03200PersonalDataService.getPersonalData
        'Dim loEx As New R_Exception
        'Dim loCls As New PNT03200PersonalDataCls
        'Dim loRtn As PNT03200PersonalDataDTO

        'Try
        '    loRtn = loCls.getPersonalData(poParam)

        'Catch ex As Exception

        'End Try

        'loEx.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

    Public Function checkLocalNationality(poParam As PNT03200Back.PNT03200PersonalDataDTO) As String Implements IPNT03200PersonalDataService.checkLocalNationality
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls
        Dim loRtn As String

        Try
            loRtn = loCls.checkLocalNationality(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpPersonalData(poParam As PNT03200Back.PNT03200PersonalDataDTO) As PNT03200Back.PNT03200PersonalDataDTO Implements IPNT03200PersonalDataService.getLookUpPersonalData
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls
        Dim loRtn As PNT03200PersonalDataDTO

        Try
            loRtn = loCls.getLookUpPersonalEmployee(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub checkStatusValidateAdd(poParam As PNT03200Back.PNT03200PersonalDataDTO) Implements IPNT03200PersonalDataService.checkStatusValidateAdd
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PersonalDataCls

        Try
            loCls.checkStatusValidateAdd(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
