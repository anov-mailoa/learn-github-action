Imports R_BackEnd
Imports R_Common
Imports PNR04100Back
Imports System.ServiceModel

Public Class PNR04100RegulerService
    Implements IPNR04100RegulerService


    Public Sub Svc_R_Delete(poEntity As PNR04100Back.PNR04100GridDto) Implements R_BackEnd.R_IServicebase(Of PNR04100Back.PNR04100GridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR04100Back.PNR04100GridDto) As PNR04100Back.PNR04100GridDto Implements R_BackEnd.R_IServicebase(Of PNR04100Back.PNR04100GridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR04100Back.PNR04100GridDto, poCRUDMode As R_Common.eCRUDMode) As PNR04100Back.PNR04100GridDto Implements R_BackEnd.R_IServicebase(Of PNR04100Back.PNR04100GridDto).Svc_R_Save

    End Function
End Class
