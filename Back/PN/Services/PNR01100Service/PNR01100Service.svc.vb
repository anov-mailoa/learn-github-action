' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR01100Service" in code, svc and config file together.
Public Class PNR01100Service
    Implements IPNR01100Service

    Public Sub Svc_R_Delete(poEntity As PNR01100Back.PNR01100BackDTO) Implements R_BackEnd.R_IServicebase(Of PNR01100Back.PNR01100BackDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR01100Back.PNR01100BackDTO) As PNR01100Back.PNR01100BackDTO Implements R_BackEnd.R_IServicebase(Of PNR01100Back.PNR01100BackDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR01100Back.PNR01100BackDTO, poCRUDMode As R_Common.eCRUDMode) As PNR01100Back.PNR01100BackDTO Implements R_BackEnd.R_IServicebase(Of PNR01100Back.PNR01100BackDTO).Svc_R_Save

    End Function
End Class
