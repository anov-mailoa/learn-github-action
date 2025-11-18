' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT00100PictureDataService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel
Imports SIAPP_PUB_DTO

Public Class PNT00100PictureDataService
    Implements IPNT00100PictureDataService

    Public Sub Svc_R_Delete(poEntity As PNT00100Back.PNT00100PictureDataDTO) Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100PictureDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT00100Back.PNT00100PictureDataDTO) As PNT00100Back.PNT00100PictureDataDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100PictureDataDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNT00100Back.PNT00100PictureDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNT00100Back.PNT00100PictureDataDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100PictureDataDTO).Svc_R_Save

    End Function

    Public Function getPictureData(poParameter As PNT00100Back.PNT00100PictureDataDTO) As PNT00100Back.PNT00100PictureDataDTO Implements IPNT00100PictureDataService.getPictureData
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100PictureDataCLS
        Dim loRtn As PNT00100PictureDataDTO

        Try
            loRtn = loCls.getPictureData(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub savePicture(poParameter As PNT00100Back.PNT00100PictureDataDTO) Implements IPNT00100PictureDataService.savePicture

        Dim loEx As New R_Exception
        Dim loCls As New PNT00100PictureDataCLS
        Dim loRtn As PNT00100PictureDataDTO

        Try
            loCls.savePicture(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub removePicture(poParameter As PNT00100Back.PNT00100PictureDataDTO) Implements IPNT00100PictureDataService.removePicture


        Dim loEx As New R_Exception
        Dim loCls As New PNT00100PictureDataCLS
        Dim loRtn As PNT00100PictureDataDTO

        Try
            loCls.removePicture(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()


    End Sub

    Public Sub removeSignature(poParameter As PNT00100Back.PNT00100PictureDataDTO) Implements IPNT00100PictureDataService.removeSignature


        Dim loEx As New R_Exception
        Dim loCls As New PNT00100PictureDataCLS
        Dim loRtn As PNT00100PictureDataDTO

        Try
            loCls.removeSignature(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()


    End Sub

    Public Sub saveSignature(poParameter As PNT00100Back.PNT00100PictureDataDTO) Implements IPNT00100PictureDataService.saveSignature


        Dim loEx As New R_Exception
        Dim loCls As New PNT00100PictureDataCLS
        Dim loRtn As PNT00100PictureDataDTO

        Try
            loCls.saveSignature(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()


    End Sub

End Class
