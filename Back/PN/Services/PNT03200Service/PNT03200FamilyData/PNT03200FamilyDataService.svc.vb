Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200FamilyDataService" in code, svc and config file together.
Public Class PNT03200FamilyDataService
    Implements IPNT03200FamilyDataService


    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200FamilyDataDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200FamilyDataDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200FamilyDataDTO) As PNT03200Back.PNT03200FamilyDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200FamilyDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls
        Dim loRtn As PNT03200FamilyDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200FamilyDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200FamilyDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200FamilyDataDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls
        Dim loRtn As PNT03200FamilyDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub checkStatusValidate(poParam As PNT03200Back.PNT03200FamilyDataDTO) Implements IPNT03200FamilyDataService.checkStatusValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls

        Try
            loCls.checkStatusValidate(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateDelete(poParam As PNT03200Back.PNT03200FamilyDataDTO) Implements IPNT03200FamilyDataService.checkStatusValidateDelete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls

        Try
            loCls.checkStatusValidateDelete(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function removeDocument(poParameter As PNT03200Back.PNT03200FamilyDataDTO) As PNT03200Back.PNT03200FamilyDataDTO Implements IPNT03200FamilyDataService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls
        Dim loRtn As PNT03200FamilyDataDTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT03200Back.PNT03200FamilyDataDTO) As PNT03200Back.PNT03200FamilyDataDTO Implements IPNT03200FamilyDataService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200FamilyDataCls
        Dim loRtn As PNT03200FamilyDataDTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
