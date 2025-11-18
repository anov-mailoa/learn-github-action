' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200PictureDataService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel

Public Class PNM05200PictureDataService
    Implements IPNM05200PictureDataService

    Public Sub DoWork() Implements IPNM05200PictureDataService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200PictureDataDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PictureDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200PictureDataDTO) As PNM05200Back.PNM05200PictureDataDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PictureDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PictureDataCLS
        Dim loRtn As New PNM05200PictureDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200PictureDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200PictureDataDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PictureDataDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PictureDataCLS
        Dim loRtn As New PNM05200PictureDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
