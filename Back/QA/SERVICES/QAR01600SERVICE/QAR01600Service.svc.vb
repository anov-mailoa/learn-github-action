Imports R_BackEnd
Imports R_Common
Imports QAR01600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01600Service" in code, svc and config file together.
Public Class QAR01600Service
    Implements IQAR01600Service



    Public Sub Svc_R_Delete(ByVal poEntity As QAR01600Back.QAR01600DTO) Implements R_BackEnd.R_IServicebase(Of QAR01600Back.QAR01600DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAR01600Back.QAR01600DTO) As QAR01600Back.QAR01600DTO Implements R_BackEnd.R_IServicebase(Of QAR01600Back.QAR01600DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAR01600Back.QAR01600DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAR01600Back.QAR01600DTO Implements R_BackEnd.R_IServicebase(Of QAR01600Back.QAR01600DTO).Svc_R_Save

    End Function
End Class
