' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT00100LanguagesService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel
Imports SIAPP_PUB_DTO

Public Class PNT00100LanguagesService
    Implements IPNT00100LanguagesService

    Public Sub Svc_R_Delete(poEntity As PNT00100Back.PNT00100LanguageGridDTO) Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100LanguageGridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100LanguageCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT00100Back.PNT00100LanguageGridDTO) As PNT00100Back.PNT00100LanguageGridDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100LanguageGridDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100LanguageCLS
        Dim loRtn As PNT00100LanguageGridDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT00100Back.PNT00100LanguageGridDTO, poCRUDMode As R_Common.eCRUDMode) As PNT00100Back.PNT00100LanguageGridDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100LanguageGridDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100LanguageCLS
        Dim loRtn As PNT00100LanguageGridDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT00100Back.PNT00100LanguageGridDTO) As PNT00100Back.PNT00100LanguageGridDTO Implements IPNT00100LanguagesService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100LanguageCLS
        Dim loRtn As PNT00100LanguageGridDTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function removeDocument(poParameter As PNT00100Back.PNT00100LanguageGridDTO) As PNT00100Back.PNT00100LanguageGridDTO Implements IPNT00100LanguagesService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100LanguageCLS
        Dim loRtn As PNT00100LanguageGridDTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
