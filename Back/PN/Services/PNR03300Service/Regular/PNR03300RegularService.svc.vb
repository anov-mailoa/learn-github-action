Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR03300Back

Public Class PNR03300RegularService
    Implements IPNR03300RegularService

    Public Sub Svc_R_Delete(poEntity As PNR03300Back.PNR03300GridDto) Implements R_BackEnd.R_IServicebase(Of PNR03300Back.PNR03300GridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR03300Back.PNR03300GridDto) As PNR03300Back.PNR03300GridDto Implements R_BackEnd.R_IServicebase(Of PNR03300Back.PNR03300GridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR03300Back.PNR03300GridDto, poCRUDMode As R_Common.eCRUDMode) As PNR03300Back.PNR03300GridDto Implements R_BackEnd.R_IServicebase(Of PNR03300Back.PNR03300GridDto).Svc_R_Save

    End Function
End Class
