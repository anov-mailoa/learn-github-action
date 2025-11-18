' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01500Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports ATR01500Back

Public Class ATR01500Service
    Implements IATR01500Service

    Public Sub Svc_R_Delete(poEntity As ATR01500Back.ATR01500DTO) Implements R_BackEnd.R_IServicebase(Of ATR01500Back.ATR01500DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR01500Back.ATR01500DTO) As ATR01500Back.ATR01500DTO Implements R_BackEnd.R_IServicebase(Of ATR01500Back.ATR01500DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR01500Back.ATR01500DTO, poCRUDMode As R_Common.eCRUDMode) As ATR01500Back.ATR01500DTO Implements R_BackEnd.R_IServicebase(Of ATR01500Back.ATR01500DTO).Svc_R_Save

    End Function
End Class
