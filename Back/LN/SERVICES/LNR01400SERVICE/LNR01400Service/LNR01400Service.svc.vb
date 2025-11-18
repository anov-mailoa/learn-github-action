Imports R_BackEnd
Imports R_Common
Imports LNR01400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR01400Service" in code, svc and config file together.
Public Class LNR01400Service
    Implements ILNR01400Service

    Public Sub Svc_R_Delete(poEntity As LNR01400Back.LNR01400DTO) Implements R_BackEnd.R_IServicebase(Of LNR01400Back.LNR01400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR01400Back.LNR01400DTO) As LNR01400Back.LNR01400DTO Implements R_BackEnd.R_IServicebase(Of LNR01400Back.LNR01400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR01400Back.LNR01400DTO, poCRUDMode As R_Common.eCRUDMode) As LNR01400Back.LNR01400DTO Implements R_BackEnd.R_IServicebase(Of LNR01400Back.LNR01400DTO).Svc_R_Save

    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of LNR01400Back.LNR01400DTO), poPar2 As System.Collections.Generic.List(Of LNR01400Back.LNR01400GridDTO)) Implements ILNR01400Service.Dummy

    End Sub

End Class
