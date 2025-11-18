Imports R_BackEnd
Imports R_Common
Imports ATM00500Back
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00500BService" in code, svc and config file together.
Public Class ATM00500BService
    Implements IATM00500BService

    Public Sub Svc_R_Delete(poEntity As ATM00500Back.ATM00500BDTO) Implements R_BackEnd.R_IServicebase(Of ATM00500Back.ATM00500BDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00500BCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00500Back.ATM00500BDTO) As ATM00500Back.ATM00500BDTO Implements R_BackEnd.R_IServicebase(Of ATM00500Back.ATM00500BDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00500BCls
        Dim loRtn As ATM00500BDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As ATM00500Back.ATM00500BDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00500Back.ATM00500BDTO Implements R_BackEnd.R_IServicebase(Of ATM00500Back.ATM00500BDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00500BCls
        Dim loRtn As ATM00500BDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
