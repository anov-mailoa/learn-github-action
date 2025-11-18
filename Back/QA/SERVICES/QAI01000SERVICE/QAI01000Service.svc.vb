Imports R_BackEnd
Imports R_Common
Imports QAI01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI01000Service" in code, svc and config file together.
Public Class QAI01000Service
    Implements IQAI01000Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAI01000Back.QAI01000DTO) Implements R_BackEnd.R_IServicebase(Of QAI01000Back.QAI01000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAI01000Back.QAI01000DTO) As QAI01000Back.QAI01000DTO Implements R_BackEnd.R_IServicebase(Of QAI01000Back.QAI01000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAI01000Back.QAI01000DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAI01000Back.QAI01000DTO Implements R_BackEnd.R_IServicebase(Of QAI01000Back.QAI01000DTO).Svc_R_Save

    End Function
End Class
