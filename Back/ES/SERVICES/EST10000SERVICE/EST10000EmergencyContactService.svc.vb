Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000EmergencyContactService" in code, svc and config file together.
Public Class EST10000EmergencyContactService
    Implements IEST10000EmergencyContactService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000EmergencyDataDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000EmergencyDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000EmergencyDataDTO) As EST10000Back.EST10000EmergencyDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000EmergencyDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000EmergencyDataCls
        Dim loRtn As New EST10000EmergencyDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000EmergencyDataDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000EmergencyDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000EmergencyDataDTO).Svc_R_Save

    End Function

    Public Sub ApprovalEmergencyData(poParam As EST10000Back.EST10000EmergencyDataDTO) Implements IEST10000EmergencyContactService.ApprovalEmergencyData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000EmergencyDataCls
        Try
            loCls.ApprovalEmergencyData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
