Imports R_BackEnd
Imports R_Common
Imports LNR01300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR01300Service" in code, svc and config file together.
Public Class LNR01300Service
    Implements ILNR01300Service

    Public Sub Svc_R_Delete(poEntity As LNR01300Back.LNR01300DTO) Implements R_BackEnd.R_IServicebase(Of LNR01300Back.LNR01300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNR01300Back.LNR01300DTO) As LNR01300Back.LNR01300DTO Implements R_BackEnd.R_IServicebase(Of LNR01300Back.LNR01300DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As LNR01300Back.LNR01300DTO, poCRUDMode As R_Common.eCRUDMode) As LNR01300Back.LNR01300DTO Implements R_BackEnd.R_IServicebase(Of LNR01300Back.LNR01300DTO).Svc_R_Save

    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of LNR01300Back.LNR01300DTO), poPar2 As System.Collections.Generic.List(Of LNR01300Back.LNR01300GridDTO)) Implements ILNR01300Service.Dummy

    End Sub

End Class
