' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00101ClauseService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back

Public Class QAT00101ClauseService
    Implements IQAT00101ClauseService
     
    Public Sub Svc_R_Delete(poEntity As QAT00101Back.QAT00101ClauseGridDTO) Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101ClauseGridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101ClauseCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00101Back.QAT00101ClauseGridDTO) As QAT00101Back.QAT00101ClauseGridDTO Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101ClauseGridDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New QAT00101ClauseCLS
        Dim loRtn As New QAT00101ClauseGridDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00101Back.QAT00101ClauseGridDTO, poCRUDMode As R_Common.eCRUDMode) As QAT00101Back.QAT00101ClauseGridDTO Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101ClauseGridDTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New QAT00101ClauseCLS
        Dim loRtn As New QAT00101ClauseGridDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function
End Class
