Imports R_BackEnd
Imports R_Common
Imports QAI00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI00100Service" in code, svc and config file together.
Public Class QAI00100Service
    Implements IQAI00100Service




    Public Sub Svc_R_Delete(poEntity As QAI00100Back.QAI00100DTO) Implements R_BackEnd.R_IServicebase(Of QAI00100Back.QAI00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAI00100Back.QAI00100DTO) As QAI00100Back.QAI00100DTO Implements R_BackEnd.R_IServicebase(Of QAI00100Back.QAI00100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAI00100Back.QAI00100DTO, poCRUDMode As R_Common.eCRUDMode) As QAI00100Back.QAI00100DTO Implements R_BackEnd.R_IServicebase(Of QAI00100Back.QAI00100DTO).Svc_R_Save

    End Function
End Class
