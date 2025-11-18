Imports R_BackEnd
Imports R_Common
Imports ATR01400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01400Service" in code, svc and config file together.
Public Class ATR01400Service
    Implements IATR01400Service

    Public Sub Svc_R_Delete(poEntity As ATR01400Back.ATR01400DTO) Implements R_BackEnd.R_IServicebase(Of ATR01400Back.ATR01400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR01400Back.ATR01400DTO) As ATR01400Back.ATR01400DTO Implements R_BackEnd.R_IServicebase(Of ATR01400Back.ATR01400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR01400Back.ATR01400DTO, poCRUDMode As R_Common.eCRUDMode) As ATR01400Back.ATR01400DTO Implements R_BackEnd.R_IServicebase(Of ATR01400Back.ATR01400DTO).Svc_R_Save

    End Function

End Class
