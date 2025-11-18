Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200LicenceDataService" in code, svc and config file together.
Public Class PNT03200LicenceDataService
    Implements IPNT03200LicenceDataService

    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200LicenceDataDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200LicenceDataDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200LicenceDataCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200LicenceDataDTO) As PNT03200Back.PNT03200LicenceDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200LicenceDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200LicenceDataCls
        Dim loRtn As PNT03200LicenceDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200LicenceDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200LicenceDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200LicenceDataDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200LicenceDataCls
        Dim loRtn As PNT03200LicenceDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function removeDocument(poParameter As PNT03200Back.PNT03200LicenceDataDTO) As PNT03200Back.PNT03200LicenceDataDTO Implements IPNT03200LicenceDataService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200LicenceDataCls
        Dim loRtn As PNT03200LicenceDataDTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT03200Back.PNT03200LicenceDataDTO) As PNT03200Back.PNT03200LicenceDataDTO Implements IPNT03200LicenceDataService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200LicenceDataCls
        Dim loRtn As PNT03200LicenceDataDTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
