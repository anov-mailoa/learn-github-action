Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200EmergencyDataService" in code, svc and config file together.
Public Class PNM05200EmergencyDataService
    Implements IPNM05200EmergencyDataService

    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200EmergencyDataDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200EmergencyDataDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200EmergencyDataCls


        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200EmergencyDataDTO) As PNM05200Back.PNM05200EmergencyDataDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200EmergencyDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200EmergencyDataCls
        Dim loRtn As New PNM05200EmergencyDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200EmergencyDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200EmergencyDataDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200EmergencyDataDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200EmergencyDataCls
        Dim loRtn As New PNM05200EmergencyDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
