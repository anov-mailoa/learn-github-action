Imports R_BackEnd
Imports R_Common
Imports PNT03200Back
Imports System.ServiceModel
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200PictureDataService" in code, svc and config file together.
Public Class PNT03200PictureDataService
    Implements IPNT03200PictureDataService


    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200PictureDataDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200PictureDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200PictureDataDTO) As PNT03200Back.PNT03200PictureDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200PictureDataDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200PictureDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200PictureDataDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200PictureDataDTO).Svc_R_Save

    End Function

    Public Function getPictureData(poParameter As PNT03200Back.PNT03200PictureDataDTO) As PNT03200Back.PNT03200PictureDataDTO Implements IPNT03200PictureDataService.getPictureData
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PictureDataCls
        Dim loRtn As PNT03200PictureDataDTO

        Try
            loRtn = loCls.getPictureData(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub removePicture(poParameter As PNT03200Back.PNT03200PictureDataDTO) Implements IPNT03200PictureDataService.removePicture
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PictureDataCls
        Dim loRtn As PNT03200PictureDataDTO

        Try
            loCls.removePicture(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub removeSignature(poParameter As PNT03200Back.PNT03200PictureDataDTO) Implements IPNT03200PictureDataService.removeSignature
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PictureDataCls
        Dim loRtn As PNT03200PictureDataDTO

        Try
            loCls.removeSignature(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub savePicture(poParameter As PNT03200Back.PNT03200PictureDataDTO) Implements IPNT03200PictureDataService.savePicture
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PictureDataCls
        Dim loRtn As PNT03200PictureDataDTO

        Try
            loCls.savePicture(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub saveSignature(poParameter As PNT03200Back.PNT03200PictureDataDTO) Implements IPNT03200PictureDataService.saveSignature
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200PictureDataCls
        Dim loRtn As PNT03200PictureDataDTO

        Try
            loCls.saveSignature(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
