Imports R_BackEnd
Imports R_Common
Imports MCR03000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR03000Service" in code, svc and config file together.
Public Class MCR03000Service
    Implements IMCR03000Service

    Public Sub Svc_R_Delete(poEntity As MCR03000Back.MCR03000Dto) Implements R_BackEnd.R_IServicebase(Of MCR03000Back.MCR03000Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCR03000Back.MCR03000Dto) As MCR03000Back.MCR03000Dto Implements R_BackEnd.R_IServicebase(Of MCR03000Back.MCR03000Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCR03000Back.MCR03000Dto, poCRUDMode As R_Common.eCRUDMode) As MCR03000Back.MCR03000Dto Implements R_BackEnd.R_IServicebase(Of MCR03000Back.MCR03000Dto).Svc_R_Save

    End Function

End Class
