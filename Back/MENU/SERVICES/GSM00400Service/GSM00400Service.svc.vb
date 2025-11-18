Imports R_Common
Imports GSM00400BACK
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00400Service" in code, svc and config file together.
Public Class GSM00400Service
    Implements IGSM00400Service

    Public Function getCmbTransCode() As System.Collections.Generic.List(Of GSM00400Back.GSM00400CmbDTO) Implements IGSM00400Service.getCmbTransCode
        Dim loEx As New R_Exception
        Dim loCls As New GSM00400Cls
        Dim loRtn As List(Of GSM00400CmbDTO)

        Try
            loRtn = loCls.getCmbTransCode()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As GSM00400Back.GSM00400CenterGridDTO) Implements R_BackEnd.R_IServicebase(Of GSM00400Back.GSM00400CenterGridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM00400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM00400Back.GSM00400CenterGridDTO) As GSM00400Back.GSM00400CenterGridDTO Implements R_BackEnd.R_IServicebase(Of GSM00400Back.GSM00400CenterGridDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM00400Cls
        Dim loRtn As GSM00400CenterGridDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM00400Back.GSM00400CenterGridDTO, poCRUDMode As R_Common.eCRUDMode) As GSM00400Back.GSM00400CenterGridDTO Implements R_BackEnd.R_IServicebase(Of GSM00400Back.GSM00400CenterGridDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM00400Cls
        Dim loRtn As GSM00400CenterGridDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
