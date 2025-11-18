Imports R_BackEnd
Imports R_Common
Imports LNR00300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00300Service" in code, svc and config file together.
Public Class LNR00300Service
    Implements ILNR00300Service

    Public Sub Svc_R_Delete(poEntity As LNR00300Back.LNR00300Dto) Implements R_BackEnd.R_IServicebase(Of LNR00300Back.LNR00300Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR00300Back.LNR00300Dto) As LNR00300Back.LNR00300Dto Implements R_BackEnd.R_IServicebase(Of LNR00300Back.LNR00300Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR00300Back.LNR00300Dto, poCRUDMode As R_Common.eCRUDMode) As LNR00300Back.LNR00300Dto Implements R_BackEnd.R_IServicebase(Of LNR00300Back.LNR00300Dto).Svc_R_Save

    End Function
End Class
