' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01300Service" in code, svc and config file together.
Public Class QAR01300Service
    Implements IQAR01300Service

    Public Sub Svc_R_Delete(poEntity As QAR01300Back.QAR01300DTO) Implements R_BackEnd.R_IServicebase(Of QAR01300Back.QAR01300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAR01300Back.QAR01300DTO) As QAR01300Back.QAR01300DTO Implements R_BackEnd.R_IServicebase(Of QAR01300Back.QAR01300DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAR01300Back.QAR01300DTO, poCRUDMode As R_Common.eCRUDMode) As QAR01300Back.QAR01300DTO Implements R_BackEnd.R_IServicebase(Of QAR01300Back.QAR01300DTO).Svc_R_Save

    End Function
End Class
