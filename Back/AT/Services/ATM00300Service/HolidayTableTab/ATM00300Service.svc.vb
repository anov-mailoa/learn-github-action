Imports R_BackEnd
Imports R_Common
Imports ATM00300Back
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM0300Service" in code, svc and config file together.
Public Class ATM00300Service
    Implements IATM00300Service

    Public Sub Svc_R_Delete(poEntity As ATM00300Back.ATM00300DTO) Implements R_BackEnd.R_IServicebase(Of ATM00300Back.ATM00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00300Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00300Back.ATM00300DTO) As ATM00300Back.ATM00300DTO Implements R_BackEnd.R_IServicebase(Of ATM00300Back.ATM00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00300Cls
        Dim loRtn As ATM00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00300Back.ATM00300DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00300Back.ATM00300DTO Implements R_BackEnd.R_IServicebase(Of ATM00300Back.ATM00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00300Cls
        Dim loRtn As ATM00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getData() As System.Collections.Generic.List(Of ATM00300Back.ATM00300DTO) Implements IATM00300Service.getData
        Dim loRtn As List(Of ATM00300DTO)
        Dim loCls As New ATM00300Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getData()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSystemParam(poParam As ATM00300Back.ATM00300DTO) As ATM00300Back.ATM00300DTO Implements IATM00300Service.getSystemParam
        Dim loRtn As New ATM00300DTO
        Dim loCls As New ATM00300Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getSystemParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
