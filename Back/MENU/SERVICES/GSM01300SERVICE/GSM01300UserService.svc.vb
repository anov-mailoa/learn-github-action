Imports R_Common
Imports GSM01300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01300Service" in code, svc and config file together.
Public Class GSM01300UserService
    Implements IGSM01300UserService

    Public Sub Svc_R_Delete(poEntity As GSM01300Back.GSM01300UserDTO) Implements R_BackEnd.R_IServicebase(Of GSM01300Back.GSM01300UserDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300UserCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01300Back.GSM01300UserDTO) As GSM01300Back.GSM01300UserDTO Implements R_BackEnd.R_IServicebase(Of GSM01300Back.GSM01300UserDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300UserCls
        Dim loRtn As New GSM01300UserDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01300Back.GSM01300UserDTO, poCRUDMode As R_Common.eCRUDMode) As GSM01300Back.GSM01300UserDTO Implements R_BackEnd.R_IServicebase(Of GSM01300Back.GSM01300UserDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300UserCls
        Dim loRtn As New GSM01300UserDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub processMultipleUser(poParam As GSM01300Back.GSM01300UserDTO) Implements IGSM01300UserService.processMultipleUser
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300UserCls

        Try
            loCls.processMultipleUser(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
