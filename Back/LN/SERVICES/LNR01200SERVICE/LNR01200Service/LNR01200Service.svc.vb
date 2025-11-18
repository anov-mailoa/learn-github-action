Imports R_BackEnd
Imports R_Common
Imports LNR01200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR01200Service" in code, svc and config file together.
Public Class LNR01200Service
    Implements ILNR01200Service

    Public Sub Svc_R_Delete(poEntity As LNR01200Back.LNR01200DTO) Implements R_BackEnd.R_IServicebase(Of LNR01200Back.LNR01200DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR01200Back.LNR01200DTO) As LNR01200Back.LNR01200DTO Implements R_BackEnd.R_IServicebase(Of LNR01200Back.LNR01200DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR01200Back.LNR01200DTO, poCRUDMode As R_Common.eCRUDMode) As LNR01200Back.LNR01200DTO Implements R_BackEnd.R_IServicebase(Of LNR01200Back.LNR01200DTO).Svc_R_Save

    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of LNR01200Back.LNR01200DTO), poPar2 As System.Collections.Generic.List(Of LNR01200Back.LNR01200GridDTO)) Implements ILNR01200Service.Dummy

    End Sub

End Class
