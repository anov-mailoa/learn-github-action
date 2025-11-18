Imports R_Common
Imports GSM01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01030Service" in code, svc and config file together.
Public Class GSM01030Service
    Implements IGSM01030Service

    Public Sub dummy1(poPar As System.Collections.Generic.List(Of GSM01000Back.GSM01030CmbDTO)) Implements IGSM01030Service.dummy1

    End Sub

    Public Sub Svc_R_Delete(poEntity As GSM01000Back.GSM01030ParamDTO) Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01030ParamDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01030Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01000Back.GSM01030ParamDTO) As GSM01000Back.GSM01030ParamDTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01030ParamDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01030Cls
        Dim loRtn As GSM01030ParamDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01000Back.GSM01030ParamDTO, poCRUDMode As R_Common.eCRUDMode) As GSM01000Back.GSM01030ParamDTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01030ParamDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01030Cls
        Dim loRtn As GSM01030ParamDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
