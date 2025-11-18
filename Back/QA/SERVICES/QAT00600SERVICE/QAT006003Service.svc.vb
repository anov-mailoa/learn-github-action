Imports R_BackEnd
Imports R_Common
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT006003Service" in code, svc and config file together.
Public Class QAT006003Service
    Implements IQAT006003Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAT00600Back.QAT006003DTO) Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT006003DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAT00600Back.QAT006003DTO) As QAT00600Back.QAT006003DTO Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT006003DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAT00600Back.QAT006003DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAT00600Back.QAT006003DTO Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT006003DTO).Svc_R_Save

    End Function

    Public Sub deleteAttProc(ByVal poParam As QAT00600Back.QAT006003DTO) Implements IQAT006003Service.deleteAttProc
        Dim loEx As New R_Exception
        Dim loCls As New QAT006003Cls

        Try
            loCls.deleteAttProc(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
