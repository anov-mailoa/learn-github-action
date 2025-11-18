Imports R_BackEnd
Imports R_Common
Imports LNR00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00400Service" in code, svc and config file together.
Public Class LNR00400Service
    Implements ILNR00400Service

    Public Sub Svc_R_Delete(poEntity As LNR00400Back.LNR00400Dto) Implements R_BackEnd.R_IServicebase(Of LNR00400Back.LNR00400Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR00400Back.LNR00400Dto) As LNR00400Back.LNR00400Dto Implements R_BackEnd.R_IServicebase(Of LNR00400Back.LNR00400Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR00400Back.LNR00400Dto, poCRUDMode As R_Common.eCRUDMode) As LNR00400Back.LNR00400Dto Implements R_BackEnd.R_IServicebase(Of LNR00400Back.LNR00400Dto).Svc_R_Save

    End Function
End Class
