Imports R_Common
Imports GSM01200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01200Service" in code, svc and config file together.
Public Class GSM01200Service
    Implements IGSM01200Service


    Public Sub Svc_R_Delete(poEntity As GSM01200Back.GSM01200DTO) Implements R_BackEnd.R_IServicebase(Of GSM01200Back.GSM01200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01200Back.GSM01200DTO) As GSM01200Back.GSM01200DTO Implements R_BackEnd.R_IServicebase(Of GSM01200Back.GSM01200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01200Cls
        Dim loRtn As GSM01200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01200Back.GSM01200DTO, poCRUDMode As R_Common.eCRUDMode) As GSM01200Back.GSM01200DTO Implements R_BackEnd.R_IServicebase(Of GSM01200Back.GSM01200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01200Cls
        Dim loRtn As GSM01200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbRate(pcCompId As String) As System.Collections.Generic.List(Of GSM01200Back.GSM01200CmbDTO) Implements IGSM01200Service.getCmbRate
        Dim loEx As New R_Exception
        Dim loCls As New GSM01200Cls
        Dim loRtn As List(Of GSM01200CmbDTO)

        Try
            loRtn = loCls.getCmbRate(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
