Imports System.ServiceModel
Imports R_Common
Imports ATM00600Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00600Service" in code, svc and config file together.
Public Class ATM00600Service
    Implements IATM00600Service

    Public Sub Svc_R_Delete(poEntity As ATM00600Back.ATM00600DTO) Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00600DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00600CLS
        Dim loRtn As ATM00600DTO
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00600Back.ATM00600DTO) As ATM00600Back.ATM00600DTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00600DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00600CLS
        Dim loRtn As ATM00600DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As ATM00600Back.ATM00600DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00600Back.ATM00600DTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00600DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00600CLS
        Dim loRtn As ATM00600DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
