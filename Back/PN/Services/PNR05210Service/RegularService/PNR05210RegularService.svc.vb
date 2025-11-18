Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR05210Back

Public Class PNR05210RegularService
    Implements IPNR05210RegularService

    Public Sub Svc_R_Delete(poEntity As PNR05210Back.PNR05210GridDto) Implements R_BackEnd.R_IServicebase(Of PNR05210Back.PNR05210GridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR05210Back.PNR05210GridDto) As PNR05210Back.PNR05210GridDto Implements R_BackEnd.R_IServicebase(Of PNR05210Back.PNR05210GridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR05210Back.PNR05210GridDto, poCRUDMode As R_Common.eCRUDMode) As PNR05210Back.PNR05210GridDto Implements R_BackEnd.R_IServicebase(Of PNR05210Back.PNR05210GridDto).Svc_R_Save

    End Function

End Class
