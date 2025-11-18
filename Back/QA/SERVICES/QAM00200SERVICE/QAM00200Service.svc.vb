' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00200Service" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports QAM00200Back

Public Class QAM00200Service
    Implements IQAM00200Service
     
    Public Sub Svc_R_Delete(poEntity As QAM00200Back.QAM00200DTO) Implements R_BackEnd.R_IServicebase(Of QAM00200Back.QAM00200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAM00200CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAM00200Back.QAM00200DTO) As QAM00200Back.QAM00200DTO Implements R_BackEnd.R_IServicebase(Of QAM00200Back.QAM00200DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New QAM00200CLS
        Dim loRtn As New QAM00200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAM00200Back.QAM00200DTO, poCRUDMode As R_Common.eCRUDMode) As QAM00200Back.QAM00200DTO Implements R_BackEnd.R_IServicebase(Of QAM00200Back.QAM00200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAM00200CLS
        Dim loRtn As New QAM00200DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub updateStatus(poParam As QAM00200Back.QAM00200DTO) Implements IQAM00200Service.updateStatus
        Dim loEx As New R_Exception
        Dim loCls As New QAM00200CLS

        Try
            loCls.updateStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function RSP_DOCTYPE_ALREADYUSED(poParam As QAM00200Back.QAM00200DTO) As Integer Implements IQAM00200Service.RSP_DOCTYPE_ALREADYUSED
        Dim loEx As New R_Exception
        Dim loCls As New QAM00200CLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.RSP_DOCTYPE_ALREADYUSED(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function
End Class
