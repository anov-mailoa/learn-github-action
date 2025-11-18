' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT01100Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports MCT01100Back

Public Class MCT01100Service
    Implements IMCT01100Service

    Public Sub Svc_R_Delete(poEntity As MCT01100Back.MCT01100DTO) Implements R_BackEnd.R_IServicebase(Of MCT01100Back.MCT01100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT01100CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT01100Back.MCT01100DTO) As MCT01100Back.MCT01100DTO Implements R_BackEnd.R_IServicebase(Of MCT01100Back.MCT01100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCT01100CLS
        Dim loRtn As New MCT01100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT01100Back.MCT01100DTO, poCRUDMode As R_Common.eCRUDMode) As MCT01100Back.MCT01100DTO Implements R_BackEnd.R_IServicebase(Of MCT01100Back.MCT01100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT01100CLS
        Dim loRtn As New MCT01100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As MCT01100Back.MCT01100DTO) As MCT01100Back.MCT01100DTO Implements IMCT01100Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As New MCT01100DTO
        Dim loCls As New MCT01100CLS

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As MCT01100Back.MCT01100DTO) As MCT01100Back.MCT01100DTO Implements IMCT01100Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As New MCT01100DTO
        Dim loCls As New MCT01100CLS

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getYear(poParam As MCT01100Back.MCT01100DTO) As String Implements IMCT01100Service.getYear
        Dim loEx As New R_Exception
        Dim loRtn As String = ""
        Dim loCls As New MCT01100CLS

        Try
            loRtn = loCls.getYear(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
