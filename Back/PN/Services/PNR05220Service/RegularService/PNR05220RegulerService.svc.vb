Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports PNR05220Back

Public Class PNR05220RegulerService
    Implements IPNR05220RegulerService

    Public Sub Svc_R_Delete(poEntity As PNR05220Back.PNR05220BackGridDto) Implements R_BackEnd.R_IServicebase(Of PNR05220Back.PNR05220BackGridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR05220Back.PNR05220BackGridDto) As PNR05220Back.PNR05220BackGridDto Implements R_BackEnd.R_IServicebase(Of PNR05220Back.PNR05220BackGridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR05220Back.PNR05220BackGridDto, poCRUDMode As R_Common.eCRUDMode) As PNR05220Back.PNR05220BackGridDto Implements R_BackEnd.R_IServicebase(Of PNR05220Back.PNR05220BackGridDto).Svc_R_Save

    End Function

End Class
