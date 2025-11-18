Imports R_BackEnd
Imports R_Common
Imports QAM00600Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00600Service" in code, svc and config file together.
Public Class QAM00600Service
    Implements IQAM00600Service



    Public Sub Svc_R_Delete(ByVal poEntity As QAM00600Back.QAM00600DTO) Implements R_BackEnd.R_IServicebase(Of QAM00600Back.QAM00600DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAM00600CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAM00600Back.QAM00600DTO) As QAM00600Back.QAM00600DTO Implements R_BackEnd.R_IServicebase(Of QAM00600Back.QAM00600DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAM00600CLS
        Dim loRtn As QAM00600DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAM00600Back.QAM00600DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAM00600Back.QAM00600DTO Implements R_BackEnd.R_IServicebase(Of QAM00600Back.QAM00600DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAM00600CLS
        Dim loRtn As QAM00600DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Function getValidationForDelete(ByVal poPar As QAM00600Back.QAM00600DTO) As Boolean Implements IQAM00600Service.getValidationForDelete
        Dim loEx As New R_Exception
        Dim loCls As New QAM00600CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getValidationForDelete(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
