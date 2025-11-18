Imports System.ServiceModel
Imports R_Common
Imports PNM14000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14000Service" in code, svc and config file together.
Public Class PNM14000Service
    Implements IPNM14000Service

    Public Sub Svc_R_Delete(poEntity As PNM14000Back.PNM14000DTO) Implements R_BackEnd.R_IServicebase(Of PNM14000Back.PNM14000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM14000Back.PNM14000DTO) As PNM14000Back.PNM14000DTO Implements R_BackEnd.R_IServicebase(Of PNM14000Back.PNM14000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14000Cls
        Dim loRtn As PNM14000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM14000Back.PNM14000DTO, poCRUDMode As R_Common.eCRUDMode) As PNM14000Back.PNM14000DTO Implements R_BackEnd.R_IServicebase(Of PNM14000Back.PNM14000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM14000Cls
        Dim loRtn As PNM14000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekExistKode(poParam As String) As Boolean Implements IPNM14000Service.cekExistKode
        Dim loEx As New R_Exception
        Dim loCls As New PNM14000Cls
        Dim loRtn As New Boolean

        Try
            loRtn = loCls.cekExistKode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckFlagUpload() As Boolean Implements IPNM14000Service.CheckFlagUpload
        Dim loEx As New R_Exception
        Dim loCls As New PNM14000Cls
        Dim loRtn As New Boolean

        Try
            loRtn = loCls.CheckFlagUpload()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
