Imports R_BackEnd
Imports R_Common
Imports QAR01500Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01500Service" in code, svc and config file together.
Public Class QAR01500Service
    Implements IQAR01500Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAR01500Back.QAR01500DTO) Implements R_BackEnd.R_IServicebase(Of QAR01500Back.QAR01500DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAR01500Back.QAR01500DTO) As QAR01500Back.QAR01500DTO Implements R_BackEnd.R_IServicebase(Of QAR01500Back.QAR01500DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAR01500Back.QAR01500DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAR01500Back.QAR01500DTO Implements R_BackEnd.R_IServicebase(Of QAR01500Back.QAR01500DTO).Svc_R_Save

    End Function
End Class
