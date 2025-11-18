Imports System.ServiceModel
Imports R_Common
Imports PYM02500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM02500Service" in code, svc and config file together.
Public Class PYM02500Service
    Implements IPYM02500Service

    Public Sub Svc_R_Delete(poEntity As PYM02500Back.PYM02500DTO) Implements R_BackEnd.R_IServicebase(Of PYM02500Back.PYM02500DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM02500Back.PYM02500DTO) As PYM02500Back.PYM02500DTO Implements R_BackEnd.R_IServicebase(Of PYM02500Back.PYM02500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM02500CLS
        Dim loRtn As New PYM02500DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM02500Back.PYM02500DTO, poCRUDMode As R_Common.eCRUDMode) As PYM02500Back.PYM02500DTO Implements R_BackEnd.R_IServicebase(Of PYM02500Back.PYM02500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM02500CLS
        Dim loRtn As New PYM02500DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLocalCurr(pcCompId As String) As String Implements IPYM02500Service.getLocalCurr
        Dim loEx As New R_Exception
        Dim loCls As New PYM02500CLS
        Dim lcRtn As String
        Try
            lcRtn = loCls.getLocalCurr(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

End Class

