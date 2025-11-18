Imports R_Common
Imports GSM21000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM21000Service" in code, svc and config file together.
Public Class GSM21000Service
    Implements IGSM21000Service

    Public Sub Svc_R_Delete(poEntity As GSM21000Back.GSM21000DTO) Implements R_BackEnd.R_IServicebase(Of GSM21000Back.GSM21000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM21000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM21000Back.GSM21000DTO) As GSM21000Back.GSM21000DTO Implements R_BackEnd.R_IServicebase(Of GSM21000Back.GSM21000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtn As GSM21000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM21000Back.GSM21000DTO, poCRUDMode As R_Common.eCRUDMode) As GSM21000Back.GSM21000DTO Implements R_BackEnd.R_IServicebase(Of GSM21000Back.GSM21000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtn As GSM21000DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM21000Back.ParamDTO)) Implements IGSM21000Service.Dummy

    End Sub
End Class
