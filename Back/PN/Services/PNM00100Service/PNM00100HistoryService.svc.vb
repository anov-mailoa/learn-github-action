Imports R_Common
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM00100HistoryService" in code, svc and config file together.
Public Class PNM00100HistoryService
    Implements IPNM00100HistoryService

    Public Sub DoWork() Implements IPNM00100HistoryService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNM00100Back.PNM00100HistoryDTO) Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100HistoryDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM00100Back.PNM00100HistoryDTO) As PNM00100Back.PNM00100HistoryDTO Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100HistoryDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100HistoryCLS
        Dim loRtn As New PNM00100HistoryDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM00100Back.PNM00100HistoryDTO, poCRUDMode As R_Common.eCRUDMode) As PNM00100Back.PNM00100HistoryDTO Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100HistoryDTO).Svc_R_Save

    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNM00100Back.PNM00100HistoryGridDTO)) Implements IPNM00100HistoryService.Dummy

    End Sub
End Class
