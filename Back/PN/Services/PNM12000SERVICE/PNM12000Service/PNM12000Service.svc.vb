Imports R_Common
Imports PNM12000Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM12000Service" in code, svc and config file together.
Public Class PNM12000Service
    Implements IPNM12000Service

    Public Sub Svc_R_Delete1(poEntity As PNM12000Back.PNM12000DTO) Implements R_BackEnd.R_IServicebase(Of PNM12000Back.PNM12000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM12000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord1(poEntity As PNM12000Back.PNM12000DTO) As PNM12000Back.PNM12000DTO Implements R_BackEnd.R_IServicebase(Of PNM12000Back.PNM12000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM12000Cls
        Dim loRtn As PNM12000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As PNM12000Back.PNM12000DTO, poCRUDMode As R_Common.eCRUDMode) As PNM12000Back.PNM12000DTO Implements R_BackEnd.R_IServicebase(Of PNM12000Back.PNM12000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM12000Cls
        Dim loRtn As PNM12000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub checkSyntax(poParam As PNM12000Back.PNM12000DTO) Implements IPNM12000Service.checkSyntax
        Dim loEx As New R_Exception
        Dim loCls As New PNM12000Cls
        Dim loRtn As New PNM12000DTO

        Try
            loCls.checkSyntax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
