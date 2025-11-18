Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000LicenseService" in code, svc and config file together.
Public Class EST10000LicenseService
    Implements IEST10000LicenseService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000LicenceDataDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000LicenceDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000LicenceDataDTO) As EST10000Back.EST10000LicenceDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000LicenceDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000LicenceDataCls
        Dim loRtn As New EST10000LicenceDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000LicenceDataDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000LicenceDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000LicenceDataDTO).Svc_R_Save

    End Function

    Public Sub ApprovalLicenceData(poParam As EST10000Back.EST10000LicenceDataDTO) Implements IEST10000LicenseService.ApprovalLicenceData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000LicenceDataCls
        Try
            loCls.ApprovalLicenceData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
