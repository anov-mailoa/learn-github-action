Imports R_BackEnd
Imports R_Common
Imports QAM00300Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00300Service" in code, svc and config file together.
Public Class QAM00300Service
    Implements IQAM00300Service




    Public Sub Svc_R_Delete(poEntity As QAM00300Back.QAM00300DTO) Implements R_BackEnd.R_IServicebase(Of QAM00300Back.QAM00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAM00300CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAM00300Back.QAM00300DTO) As QAM00300Back.QAM00300DTO Implements R_BackEnd.R_IServicebase(Of QAM00300Back.QAM00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAM00300CLS
        Dim loRtn As QAM00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAM00300Back.QAM00300DTO, poCRUDMode As R_Common.eCRUDMode) As QAM00300Back.QAM00300DTO Implements R_BackEnd.R_IServicebase(Of QAM00300Back.QAM00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAM00300CLS
        Dim loRtn As QAM00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
