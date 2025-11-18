Imports R_BackEnd
Imports R_Common
Imports QAM00400Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00400Service" in code, svc and config file together.
Public Class QAM00400Service
    Implements IQAM00400Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAM00400Back.QAM00400DTO) Implements R_BackEnd.R_IServicebase(Of QAM00400Back.QAM00400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAM00400CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAM00400Back.QAM00400DTO) As QAM00400Back.QAM00400DTO Implements R_BackEnd.R_IServicebase(Of QAM00400Back.QAM00400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAM00400CLS
        Dim loRtn As QAM00400DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAM00400Back.QAM00400DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAM00400Back.QAM00400DTO Implements R_BackEnd.R_IServicebase(Of QAM00400Back.QAM00400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAM00400CLS
        Dim loRtn As QAM00400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
