Imports R_BackEnd
Imports R_Common
Imports PNM14100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14100Service" in code, svc and config file together.
Public Class PNM14100Service
    Implements IPNM14100Service

    Public Sub Svc_R_Delete(poEntity As PNM14100Back.PNM14100Dto) Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14100Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM14100Back.PNM14100Dto) As PNM14100Back.PNM14100Dto Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14100Cls
        Dim loRtn As PNM14100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM14100Back.PNM14100Dto, poCRUDMode As R_Common.eCRUDMode) As PNM14100Back.PNM14100Dto Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14100Dto).Svc_R_Save

    End Function
End Class
