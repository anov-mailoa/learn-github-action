Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM06110Service" in code, svc and config file together.
Public Class PNM06110Service
    Implements IPNM06110Service

    Public Sub Svc_R_Delete(poEntity As PNM06100Back.PNM06110DTO) Implements R_BackEnd.R_IServicebase(Of PNM06100Back.PNM06110DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM06100Back.PNM06110DTO) As PNM06100Back.PNM06110DTO Implements R_BackEnd.R_IServicebase(Of PNM06100Back.PNM06110DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM06110CLS
        Dim loRtn As New PNM06110DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM06100Back.PNM06110DTO, poCRUDMode As R_Common.eCRUDMode) As PNM06100Back.PNM06110DTO Implements R_BackEnd.R_IServicebase(Of PNM06100Back.PNM06110DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM06110CLS
        Dim loRtn As PNM06110DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetSettingDate(poParam As PNM06100Back.PNM06110DTO) As PNM06100Back.PNM06110DTO Implements IPNM06110Service.GetSettingDate
        Dim loEx As New R_Exception
        Dim loCls As New PNM06110CLS
        Dim loRtn As New PNM06110DTO

        Try
            loRtn = loCls.GetSettingDate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRecord(poParam As PNM06100Back.PNM06110DTO) As PNM06100Back.PNM06110DTO Implements IPNM06110Service.getRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM06110CLS
        Dim loRtn As New PNM06110DTO

        Try
            loRtn = loCls.getRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
