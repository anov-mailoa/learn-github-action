Imports R_Common
Imports MCM12000Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM12000Service" in code, svc and config file together.
Public Class MCM12000Service
    Implements IMCM12000Service

    Public Sub Svc_R_Delete1(poEntity As MCM12000Back.MCM12000DTO) Implements R_BackEnd.R_IServicebase(Of MCM12000Back.MCM12000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM12000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord1(poEntity As MCM12000Back.MCM12000DTO) As MCM12000Back.MCM12000DTO Implements R_BackEnd.R_IServicebase(Of MCM12000Back.MCM12000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM12000Cls
        Dim loRtn As MCM12000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As MCM12000Back.MCM12000DTO, poCRUDMode As R_Common.eCRUDMode) As MCM12000Back.MCM12000DTO Implements R_BackEnd.R_IServicebase(Of MCM12000Back.MCM12000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM12000Cls
        Dim loRtn As MCM12000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub checkSyntax(poParam As MCM12000Back.MCM12000DTO) Implements IMCM12000Service.checkSyntax
        Dim loEx As New R_Exception
        Dim loCls As New MCM12000Cls
        Dim loRtn As New MCM12000DTO

        Try
            loCls.checkSyntax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
