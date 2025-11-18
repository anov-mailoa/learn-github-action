Imports R_BackEnd
Imports R_Common
Imports QAR01400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01400Service" in code, svc and config file together.
Public Class QAR01400Service
    Implements IQAR01400Service


    Public Sub Svc_R_Delete(ByVal poEntity As QAR01400Back.QAR01400DTO) Implements R_BackEnd.R_IServicebase(Of QAR01400Back.QAR01400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAR01400Back.QAR01400DTO) As QAR01400Back.QAR01400DTO Implements R_BackEnd.R_IServicebase(Of QAR01400Back.QAR01400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAR01400Back.QAR01400DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAR01400Back.QAR01400DTO Implements R_BackEnd.R_IServicebase(Of QAR01400Back.QAR01400DTO).Svc_R_Save

    End Function
End Class
