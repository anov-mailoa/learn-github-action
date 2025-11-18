Imports R_Common
Imports GSM01500Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01500Service" in code, svc and config file together.
Public Class GSM01500Service
    Implements IGSM01500Service

    Public Sub Svc_R_Delete(poEntity As GSM01500Back.GSM01500DTO) Implements R_BackEnd.R_IServicebase(Of GSM01500Back.GSM01500DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01500Back.GSM01500DTO) As GSM01500Back.GSM01500DTO Implements R_BackEnd.R_IServicebase(Of GSM01500Back.GSM01500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01500Cls
        Dim loRtn As GSM01500DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01500Back.GSM01500DTO, poCRUDMode As R_Common.eCRUDMode) As GSM01500Back.GSM01500DTO Implements R_BackEnd.R_IServicebase(Of GSM01500Back.GSM01500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01500Cls
        Dim loRtn As GSM01500DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
