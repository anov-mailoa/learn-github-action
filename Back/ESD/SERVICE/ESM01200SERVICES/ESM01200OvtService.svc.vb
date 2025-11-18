Imports R_BackEnd
Imports R_Common
Imports ESM01200Back
Imports ESM01200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01200Service" in code, svc and config file together.
Public Class ESM01200OvtService
    Implements IESM01200OvtService

    Public Sub Svc_R_Delete(poEntity As ESM01200Back.ESM01200OvtDTO) Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200OvtDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01200Back.ESM01200OvtDTO) As ESM01200Back.ESM01200OvtDTO Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200OvtDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtn As New ESM01200OvtDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01200Back.ESM01200OvtDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01200Back.ESM01200OvtDTO Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200OvtDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtn As New ESM01200OvtDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDeptEmployee(poParam As ESM01200Back.ESM01200ParamDTO) As ESM01200Back.ESM01200OvtDTO Implements IESM01200OvtService.getDeptEmployee
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtn As New ESM01200OvtDTO

        Try
            loRtn = loCls.getDeptEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMinMaxOvtDate(poParam As ESM01200Back.ESM01200ParamDTO) As ESM01200Back.ESM01200OvtDTO Implements IESM01200OvtService.getMinMaxOvtDate
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtn As New ESM01200OvtDTO

        Try
            loRtn = loCls.getMinMaxOvtDate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMinOvt(poParam As ESM01200Back.ESM01200ParamDTO) As ESM01200Back.ESM01200OvtDTO Implements IESM01200OvtService.getMinOvt
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtn As New ESM01200OvtDTO

        Try
            loRtn = loCls.getMinOvt(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSumOvtTime(poParam As ESM01200Back.ESM01200ParamDTO) As Decimal Implements IESM01200OvtService.getSumOvtTime
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim ldTime As Decimal

        Try
            ldTime = loCls.getSumOvtTime(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return ldTime
    End Function

    Public Function getTotalExcessHours(poParam As ESM01200Back.ESM01200ParamDTO) As ESM01200Back.ESM01200OvtDTO Implements IESM01200OvtService.getTotalExcessHours
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtn As New ESM01200OvtDTO

        Try
            loRtn = loCls.getTotalExcessHours(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
