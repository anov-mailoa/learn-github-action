Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR04110Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR04110RegulerService" in code, svc and config file together.
Public Class PNR04110RegulerService
    Implements IPNR04110RegulerService

    Public Sub Svc_R_Delete(poEntity As PNR04110Back.PNR04110BackGridDto) Implements R_BackEnd.R_IServicebase(Of PNR04110Back.PNR04110BackGridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR04110Back.PNR04110BackGridDto) As PNR04110Back.PNR04110BackGridDto Implements R_BackEnd.R_IServicebase(Of PNR04110Back.PNR04110BackGridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNR04110Back.PNR04110BackGridDto, poCRUDMode As R_Common.eCRUDMode) As PNR04110Back.PNR04110BackGridDto Implements R_BackEnd.R_IServicebase(Of PNR04110Back.PNR04110BackGridDto).Svc_R_Save

    End Function

End Class
