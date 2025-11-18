Imports R_BackEnd
Imports R_Common
Imports QAR00600Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR00600Service" in code, svc and config file together.
Public Class QAR00600Service
    Implements IQAR00600Service





    Public Sub Svc_R_Delete(ByVal poEntity As QAR00600Back.QAR00600DTO) Implements R_BackEnd.R_IServicebase(Of QAR00600Back.QAR00600DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAR00600Back.QAR00600DTO) As QAR00600Back.QAR00600DTO Implements R_BackEnd.R_IServicebase(Of QAR00600Back.QAR00600DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAR00600Back.QAR00600DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAR00600Back.QAR00600DTO Implements R_BackEnd.R_IServicebase(Of QAR00600Back.QAR00600DTO).Svc_R_Save

    End Function

   
End Class
