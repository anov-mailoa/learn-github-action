Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200FormalEducationService" in code, svc and config file together.
Public Class PNM05200FormalEducationService
    Implements IPNM05200FormalEducationService

    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200FormalEducationDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200FormalEducationDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200FormalEducationCls


        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200FormalEducationDTO) As PNM05200Back.PNM05200FormalEducationDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200FormalEducationDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200FormalEducationCls
        Dim loRtn As New PNM05200FormalEducationDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200FormalEducationDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200FormalEducationDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200FormalEducationDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200FormalEducationCls
        Dim loRtn As New PNM05200FormalEducationDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCmbCountry(poParam As PNM05200Back.PNM05200FormalEducationDTO) As System.Collections.Generic.List(Of PNM05200Back.PNM05200FormalEducationDTO) Implements IPNM05200FormalEducationService.getCmbCountry
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200FormalEducationCls
        Dim loRtn As New List(Of PNM05200FormalEducationDTO)

        Try
            loRtn = loCls.getCmbCountry(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function removeDocument(poParameter As PNM05200Back.PNM05200FormalEducationDTO) As PNM05200Back.PNM05200FormalEducationDTO Implements IPNM05200FormalEducationService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200FormalEducationCls
        Dim loRtn As PNM05200FormalEducationDTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNM05200Back.PNM05200FormalEducationDTO) As PNM05200Back.PNM05200FormalEducationDTO Implements IPNM05200FormalEducationService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200FormalEducationCls
        Dim loRtn As PNM05200FormalEducationDTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
