Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM01000Service" in code, svc and config file together.
Public Class MCM01000Service
    Implements IMCM01000Service

    Public Sub Svc_R_Delete(poEntity As MCM01000Back.MCM01000DTO) Implements R_BackEnd.R_IServicebase(Of MCM01000Back.MCM01000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM01000Back.MCM01000DTO) As MCM01000Back.MCM01000DTO Implements R_BackEnd.R_IServicebase(Of MCM01000Back.MCM01000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As New MCM01000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM01000Back.MCM01000DTO, poCRUDMode As R_Common.eCRUDMode) As MCM01000Back.MCM01000DTO Implements R_BackEnd.R_IServicebase(Of MCM01000Back.MCM01000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As New MCM01000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckUserAuthority(poParam As MCM01000Back.MCM01000DTO) As Integer Implements IMCM01000Service.CheckUserAuthority
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.CheckUserAuthority(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub CopyPrevious(poParam As MCM01000Back.MCM01000DTO) Implements IMCM01000Service.CopyPrevious
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As New MCM01000DTO
        Try
            loCls.CopyPrevious(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetDlogRecord(poParam As MCM01000Back.MCM01000DTO) As MCM01000Back.MCM01000DTO Implements IMCM01000Service.GetDlogRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01000CLS
        Dim loRtn As New MCM01000DTO

        Try
            loRtn = loCls.GetDlogRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
