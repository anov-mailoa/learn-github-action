Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09100EmpPunishmListService" in code, svc and config file together.
Public Class PNT09100EmpPunishmListService
    Implements IPNT09100EmpPunishmListService

    Public Sub Svc_R_Delete(poEntity As PNT09000Back.PNT09100DTO) Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New EmpPunishListCls
        Dim loRtn As New PNT09100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09000Back.PNT09100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09000Back.PNT09100DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09100DTO).Svc_R_Save

    End Function

    Public Function removeDocument(poParameter As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements IPNT09100EmpPunishmListService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New EmpPunishListCls
        Dim loRtn As PNT09100DTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements IPNT09100EmpPunishmListService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New EmpPunishListCls
        Dim loRtn As PNT09100DTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParams As System.Collections.Generic.List(Of PNT09000Back.PNT09100ReportDTO)) Implements IPNT09100EmpPunishmListService.Dummy

    End Sub
End Class
