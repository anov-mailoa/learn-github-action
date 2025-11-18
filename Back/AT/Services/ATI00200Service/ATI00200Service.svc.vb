Imports R_Common
Imports ATI00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00200Service" in code, svc and config file together.
Public Class ATI00200Service
    Implements IATI00200Service

    Public Sub Svc_R_Delete(poEntity As ATI00200Back.ATI00200DTO) Implements R_BackEnd.R_IServicebase(Of ATI00200Back.ATI00200DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATI00200Back.ATI00200DTO) As ATI00200Back.ATI00200DTO Implements R_BackEnd.R_IServicebase(Of ATI00200Back.ATI00200DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATI00200Back.ATI00200DTO, poCRUDMode As R_Common.eCRUDMode) As ATI00200Back.ATI00200DTO Implements R_BackEnd.R_IServicebase(Of ATI00200Back.ATI00200DTO).Svc_R_Save

    End Function
End Class
