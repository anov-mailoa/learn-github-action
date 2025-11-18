Imports R_BackEnd
Imports R_Common
Imports LNR00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00100Service" in code, svc and config file together.
Public Class LNR00100Service
    Implements ILNR00100Service

    Public Sub Svc_R_Delete(poEntity As LNR00100Back.LNR00100Dto) Implements R_BackEnd.R_IServicebase(Of LNR00100Back.LNR00100Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR00100Back.LNR00100Dto) As LNR00100Back.LNR00100Dto Implements R_BackEnd.R_IServicebase(Of LNR00100Back.LNR00100Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR00100Back.LNR00100Dto, poCRUDMode As R_Common.eCRUDMode) As LNR00100Back.LNR00100Dto Implements R_BackEnd.R_IServicebase(Of LNR00100Back.LNR00100Dto).Svc_R_Save

    End Function
End Class
