Imports R_BackEnd
Imports R_Common
Imports LNR00200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00200Service" in code, svc and config file together.
Public Class LNR00200Service
    Implements ILNR00200Service

    Public Sub Svc_R_Delete(poEntity As LNR00200Back.LNR00200Dto) Implements R_BackEnd.R_IServicebase(Of LNR00200Back.LNR00200Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR00200Back.LNR00200Dto) As LNR00200Back.LNR00200Dto Implements R_BackEnd.R_IServicebase(Of LNR00200Back.LNR00200Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR00200Back.LNR00200Dto, poCRUDMode As R_Common.eCRUDMode) As LNR00200Back.LNR00200Dto Implements R_BackEnd.R_IServicebase(Of LNR00200Back.LNR00200Dto).Svc_R_Save

    End Function
End Class
