Imports R_BackEnd
Imports R_Common
Imports MCT09100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT09100Service" in code, svc and config file together.
Public Class MCT09100Service
    Implements IMCT09100Service

    Public Sub Svc_R_Delete(poEntity As MCT09100Back.MCT09100Dto) Implements R_BackEnd.R_IServicebase(Of MCT09100Back.MCT09100Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT09100Back.MCT09100Dto) As MCT09100Back.MCT09100Dto Implements R_BackEnd.R_IServicebase(Of MCT09100Back.MCT09100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCT09100Cls
        Dim loRtn As MCT09100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT09100Back.MCT09100Dto, poCRUDMode As R_Common.eCRUDMode) As MCT09100Back.MCT09100Dto Implements R_BackEnd.R_IServicebase(Of MCT09100Back.MCT09100Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT09100Cls
        Dim loRtn As MCT09100Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataYear(pcCompanyId As String) As MCT09100Back.MCT09100Dto Implements IMCT09100Service.getDataYear
        Dim loRtn As New MCT09100Dto
        Dim loCls As New MCT09100Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getDataYear(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataForm(pcCompanyId As String, pcCyear As String, pcCdeptCode As String, pcCreferenceNo As String, pcUserId As String) As MCT09100Back.MCT09100Dto Implements IMCT09100Service.getDataForm
        Dim loRtn As New MCT09100Dto
        Dim loCls As New MCT09100Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getDataForm(pcCompanyId, pcCyear, pcCdeptCode, pcCreferenceNo, pcUserId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckAllowPremi(pcCompanyId As String) As Integer Implements IMCT09100Service.CheckAllowPremi
        Dim iRtn As Integer
        Dim loCls As New MCT09100Cls
        Dim loEx As New R_Exception

        Try
            iRtn = loCls.CheckAllowPremi(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return iRtn
    End Function
End Class
