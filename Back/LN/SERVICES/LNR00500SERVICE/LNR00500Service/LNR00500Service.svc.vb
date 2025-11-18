Imports R_BackEnd
Imports R_Common
Imports LNR00500Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00500Service" in code, svc and config file together.
Public Class LNR00500Service
    Implements ILNR00500Service

    Public Sub Svc_R_Delete(poEntity As LNR00500Back.LNR00500Dto) Implements R_BackEnd.R_IServicebase(Of LNR00500Back.LNR00500Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR00500Back.LNR00500Dto) As LNR00500Back.LNR00500Dto Implements R_BackEnd.R_IServicebase(Of LNR00500Back.LNR00500Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR00500Back.LNR00500Dto, poCRUDMode As R_Common.eCRUDMode) As LNR00500Back.LNR00500Dto Implements R_BackEnd.R_IServicebase(Of LNR00500Back.LNR00500Dto).Svc_R_Save

    End Function
End Class
