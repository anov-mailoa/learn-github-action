Imports R_BackEnd
Imports R_Common
Imports QAI01100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI01100Service" in code, svc and config file together.
Public Class QAI01100Service
    Implements IQAI01100Service

    Public Sub Svc_R_Delete(poEntity As QAI01100Back.QAI01100Dto) Implements R_BackEnd.R_IServicebase(Of QAI01100Back.QAI01100Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAI01100Back.QAI01100Dto) As QAI01100Back.QAI01100Dto Implements R_BackEnd.R_IServicebase(Of QAI01100Back.QAI01100Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAI01100Back.QAI01100Dto, poCRUDMode As R_Common.eCRUDMode) As QAI01100Back.QAI01100Dto Implements R_BackEnd.R_IServicebase(Of QAI01100Back.QAI01100Dto).Svc_R_Save

    End Function

    Public Function GetSOCINFO(poParam As QAI01100Back.QAI01100Dto) As QAI01100Back.QAI01100Dto Implements IQAI01100Service.GetSOCINFO
        Dim loEx As New R_Exception
        Dim loCls As New QAI01100Cls
        Dim loRtn As New QAI01100Dto

        Try
            loRtn = loCls.GetSOCINFO(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
