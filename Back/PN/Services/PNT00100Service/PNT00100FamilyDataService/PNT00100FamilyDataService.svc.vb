' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT00100FamilyDataService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel
Imports SIAPP_PUB_DTO

Public Class PNT00100FamilyDataService
    Implements IPNT00100FamilyDataService

    Public Sub Svc_R_Delete(poEntity As PNT00100Back.PNT00100FamilyDataDTO) Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100FamilyDataDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100FamilyDataCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT00100Back.PNT00100FamilyDataDTO) As PNT00100Back.PNT00100FamilyDataDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100FamilyDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100FamilyDataCLS
        Dim loRtn As PNT00100FamilyDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT00100Back.PNT00100FamilyDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNT00100Back.PNT00100FamilyDataDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100FamilyDataDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100FamilyDataCLS
        Dim loRtn As PNT00100FamilyDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function removeDocument(poParameter As PNT00100Back.PNT00100FamilyDataDTO) As PNT00100Back.PNT00100FamilyDataDTO Implements IPNT00100FamilyDataService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100FamilyDataCLS
        Dim loRtn As PNT00100FamilyDataDTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT00100Back.PNT00100FamilyDataDTO) As PNT00100Back.PNT00100FamilyDataDTO Implements IPNT00100FamilyDataService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100FamilyDataCLS
        Dim loRtn As PNT00100FamilyDataDTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
