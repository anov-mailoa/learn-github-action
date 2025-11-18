Imports System.ServiceModel
Imports R_Common
Imports GSM00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00700Service" in code, svc and config file together.
Public Class GSM00700Service
    Implements IGSM00700Service

    Public Sub Svc_R_Delete(poEntity As GSM00700Back.GSM00700DTO) Implements R_BackEnd.R_IServicebase(Of GSM00700Back.GSM00700DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM00700Back.GSM00700DTO) As GSM00700Back.GSM00700DTO Implements R_BackEnd.R_IServicebase(Of GSM00700Back.GSM00700DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM00700Cls
        Dim loRtn As GSM00700DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM00700Back.GSM00700DTO, poCRUDMode As R_Common.eCRUDMode) As GSM00700Back.GSM00700DTO Implements R_BackEnd.R_IServicebase(Of GSM00700Back.GSM00700DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM00700Cls
        Dim loRtn As GSM00700DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ActivateProcess(poParam As GSM00700Back.GSM00700DTO) As GSM00700Back.GSM00700DTO Implements IGSM00700Service.ActivateProcess
        Dim loEx As New R_Exception
        Dim loCls As New GSM00700Cls
        Dim loRtn As New GSM00700DTO

        Try
            loRtn = loCls.ActivateProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckFlagUpload() As Boolean Implements IGSM00700Service.CheckFlagUpload
        Dim loEx As New R_Exception
        Dim loCls As New GSM00700Cls
        Dim loRtn As New Boolean

        Try
            loRtn = loCls.CheckFlagUpload()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
