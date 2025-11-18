Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200MedicalHistoryService" in code, svc and config file together.
Public Class PNM05200MedicalHistoryService
    Implements IPNM05200MedicalHistoryService


    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200MedicalHistoryDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200MedicalHistoryDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200MedicalHistoryCls


        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200MedicalHistoryDTO) As PNM05200Back.PNM05200MedicalHistoryDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200MedicalHistoryDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200MedicalHistoryCls
        Dim loRtn As New PNM05200MedicalHistoryDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200MedicalHistoryDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200MedicalHistoryDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200MedicalHistoryDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200MedicalHistoryCls
        Dim loRtn As New PNM05200MedicalHistoryDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
