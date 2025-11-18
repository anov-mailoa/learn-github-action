Imports R_BackEnd
Imports R_Common
Imports QAR01100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01100Service" in code, svc and config file together.
Public Class QAR01100Service
    Implements IQAR01100Service




    Public Sub Svc_R_Delete(poEntity As QAR01100Back.QAR01100DTO) Implements R_BackEnd.R_IServicebase(Of QAR01100Back.QAR01100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAR01100Back.QAR01100DTO) As QAR01100Back.QAR01100DTO Implements R_BackEnd.R_IServicebase(Of QAR01100Back.QAR01100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAR01100Back.QAR01100DTO, poCRUDMode As R_Common.eCRUDMode) As QAR01100Back.QAR01100DTO Implements R_BackEnd.R_IServicebase(Of QAR01100Back.QAR01100DTO).Svc_R_Save

    End Function
End Class
