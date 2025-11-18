' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00300Service" in code, svc and config file together.
Imports R_Common
Imports ATI00300Back

Public Class ATI00300Service
    Implements IATI00300Service


    Public Sub Svc_R_Delete(poEntity As ATI00300Back.ATI00300DTO) Implements R_BackEnd.R_IServicebase(Of ATI00300Back.ATI00300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATI00300Back.ATI00300DTO) As ATI00300Back.ATI00300DTO Implements R_BackEnd.R_IServicebase(Of ATI00300Back.ATI00300DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATI00300Back.ATI00300DTO, poCRUDMode As R_Common.eCRUDMode) As ATI00300Back.ATI00300DTO Implements R_BackEnd.R_IServicebase(Of ATI00300Back.ATI00300DTO).Svc_R_Save

    End Function

End Class
