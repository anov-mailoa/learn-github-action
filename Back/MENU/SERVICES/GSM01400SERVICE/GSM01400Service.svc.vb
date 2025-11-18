Imports R_Common
Imports GSM01400Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01400Service" in code, svc and config file together.
Public Class GSM01400Service
    Implements IGSM01400Service

    Public Sub Svc_R_Delete(poEntity As GSM01400Back.GSM01400DTO) Implements R_BackEnd.R_IServicebase(Of GSM01400Back.GSM01400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01400Back.GSM01400DTO) As GSM01400Back.GSM01400DTO Implements R_BackEnd.R_IServicebase(Of GSM01400Back.GSM01400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01400Cls
        Dim loRtn As New GSM01400DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01400Back.GSM01400DTO, poCRUDMode As R_Common.eCRUDMode) As GSM01400Back.GSM01400DTO Implements R_BackEnd.R_IServicebase(Of GSM01400Back.GSM01400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01400Cls
        Dim loRtn As New GSM01400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
