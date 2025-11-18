Imports R_BackEnd
Imports R_Common
Imports PNT03200Back
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200WorkExperienceService" in code, svc and config file together.
Public Class PNT03200WorkExperienceService
    Implements IPNT03200WorkExperienceService


    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200WorkExperienceDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200WorkExperienceDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200WorkExperienceCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200WorkExperienceDTO) As PNT03200Back.PNT03200WorkExperienceDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200WorkExperienceDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200WorkExperienceCls
        Dim loRtn As PNT03200WorkExperienceDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200WorkExperienceDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200WorkExperienceDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200WorkExperienceDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200WorkExperienceCls
        Dim loRtn As PNT03200WorkExperienceDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
