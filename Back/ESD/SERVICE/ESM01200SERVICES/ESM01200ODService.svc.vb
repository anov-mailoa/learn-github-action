Imports R_Common
Imports ESM01200Back
Imports ESM01200Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01200ODService" in code, svc and config file together.
Public Class ESM01200ODService
    Implements IESM01200ODService

    Public Sub Svc_R_Delete(poEntity As ESM01200Back.ESM01200ODParamDTO) Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200ODParamDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ESM01200ODCLS
        Dim loParam As New ESM01200ODParamDTO

        Try

            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01200Back.ESM01200ODParamDTO) As ESM01200Back.ESM01200ODParamDTO Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200ODParamDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200ODCLS
        Dim loRtn As New ESM01200ODParamDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01200Back.ESM01200ODParamDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01200Back.ESM01200ODParamDTO Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200ODParamDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200ODCLS
        Dim loRtn As New ESM01200ODParamDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekExistTrx(poParam As ESM01200Back.ESM01200ODParamDTO) As String Implements IESM01200ODService.cekExistTrx
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200ODCLS
        Dim lcRtn As String
        Try
            lcRtn = loCls.cekExistTrx(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function
End Class
