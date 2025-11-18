Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09400ScorsingService" in code, svc and config file together.
Public Class PNT09400ScorsingService
    Implements IPNT09400ScorsingService

    Public Sub Svc_R_Delete(poEntity As PNT09000Back.PNT09400DTO) Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09000Back.PNT09400DTO) As PNT09000Back.PNT09400DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09400DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ScorsingCls
        Dim loRtn As New PNT09400DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09000Back.PNT09400DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09000Back.PNT09400DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09400DTO).Svc_R_Save

    End Function

    Public Sub Dummy(poParams As System.Collections.Generic.List(Of PNT09000Back.PNT09400ReportDTO)) Implements IPNT09400ScorsingService.Dummy

    End Sub

End Class
