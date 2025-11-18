Imports R_Common
Imports PYM01200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01200UserDefineParamService" in code, svc and config file together.
Public Class PYM01200UserDefineParamService
    Implements IPYM01200UserDefineParamService


    Public Sub Svc_R_Delete(poEntity As PYM01200Back.PYM01200UserDefineParamDTO) Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200UserDefineParamDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200UserDefineParamCls
        Dim loRtn As PYM01200UserDefineParamDTO

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01200Back.PYM01200UserDefineParamDTO) As PYM01200Back.PYM01200UserDefineParamDTO Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200UserDefineParamDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200UserDefineParamCls
        Dim loRtn As PYM01200UserDefineParamDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01200Back.PYM01200UserDefineParamDTO, poCRUDMode As R_Common.eCRUDMode) As PYM01200Back.PYM01200UserDefineParamDTO Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200UserDefineParamDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200UserDefineParamCls
        Dim loRtn As PYM01200UserDefineParamDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
