Imports R_BackEnd
Imports R_Common
Imports QAR00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR00100Service" in code, svc and config file together.
Public Class QAR00100Service
    Implements IQAR00100Service




    Public Sub Svc_R_Delete(poEntity As QAR00100Back.QAR00100DTO) Implements R_BackEnd.R_IServicebase(Of QAR00100Back.QAR00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAR00100Back.QAR00100DTO) As QAR00100Back.QAR00100DTO Implements R_BackEnd.R_IServicebase(Of QAR00100Back.QAR00100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAR00100Back.QAR00100DTO, poCRUDMode As R_Common.eCRUDMode) As QAR00100Back.QAR00100DTO Implements R_BackEnd.R_IServicebase(Of QAR00100Back.QAR00100DTO).Svc_R_Save

    End Function
End Class
