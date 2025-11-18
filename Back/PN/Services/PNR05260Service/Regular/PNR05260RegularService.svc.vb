Imports R_BackEnd
Imports R_Common
Imports PNR05260Back
Imports System.ServiceModel

Public Class PNR05260RegularService
    Implements IPNR05260RegularService

    Public Sub Svc_R_Delete(poEntity As PNR05260Back.PNR05260GridDto) Implements R_BackEnd.R_IServicebase(Of PNR05260Back.PNR05260GridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR05260Back.PNR05260GridDto) As PNR05260Back.PNR05260GridDto Implements R_BackEnd.R_IServicebase(Of PNR05260Back.PNR05260GridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR05260Back.PNR05260GridDto, poCRUDMode As R_Common.eCRUDMode) As PNR05260Back.PNR05260GridDto Implements R_BackEnd.R_IServicebase(Of PNR05260Back.PNR05260GridDto).Svc_R_Save

    End Function

End Class
