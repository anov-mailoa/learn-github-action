' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01200Service" in code, svc and config file together.
Public Class QAR01200Service
    Implements IQAR01200Service

    Public Sub Svc_R_Delete(poEntity As QAR01200Back.QAR01200DTO) Implements R_BackEnd.R_IServicebase(Of QAR01200Back.QAR01200DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAR01200Back.QAR01200DTO) As QAR01200Back.QAR01200DTO Implements R_BackEnd.R_IServicebase(Of QAR01200Back.QAR01200DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAR01200Back.QAR01200DTO, poCRUDMode As R_Common.eCRUDMode) As QAR01200Back.QAR01200DTO Implements R_BackEnd.R_IServicebase(Of QAR01200Back.QAR01200DTO).Svc_R_Save

    End Function
End Class
