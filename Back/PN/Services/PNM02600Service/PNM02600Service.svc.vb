Imports R_Common
Imports R_BackEnd
Imports PNM02600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02600Service" in code, svc and config file together.
Public Class PNM02600Service
    Implements IPNM02600Service

    Public Sub Svc_R_Delete(poEntity As PNM02600Back.PNM02600DTO) Implements R_BackEnd.R_IServicebase(Of PNM02600Back.PNM02600DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02600Back.PNM02600DTO) As PNM02600Back.PNM02600DTO Implements R_BackEnd.R_IServicebase(Of PNM02600Back.PNM02600DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNM02600Back.PNM02600DTO, poCRUDMode As R_Common.eCRUDMode) As PNM02600Back.PNM02600DTO Implements R_BackEnd.R_IServicebase(Of PNM02600Back.PNM02600DTO).Svc_R_Save

    End Function

End Class
