Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09300VerbalWarningService" in code, svc and config file together.
Public Class PNT09300VerbalWarningService
    Implements IPNT09300VerbalWarningService

    Public Sub Svc_R_Delete(poEntity As PNT09000Back.PNT09300DTO) Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09000Back.PNT09300DTO) As PNT09000Back.PNT09300DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09300DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New EmpWarningListCls
        Dim loRtn As New PNT09300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09000Back.PNT09300DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09000Back.PNT09300DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09300DTO).Svc_R_Save

    End Function

End Class
