Imports R_Common
Imports PNB09100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNB09100Service" in code, svc and config file together.
Public Class PNB09100Service
    Implements IPNB09100Service

    Public Sub Svc_R_Delete(poEntity As PNB09100Back.PNB09100DTO) Implements R_BackEnd.R_IServicebase(Of PNB09100Back.PNB09100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNB09100Back.PNB09100DTO) As PNB09100Back.PNB09100DTO Implements R_BackEnd.R_IServicebase(Of PNB09100Back.PNB09100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNB09100Cls
        Dim loRtn As New PNB09100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNB09100Back.PNB09100DTO, poCRUDMode As R_Common.eCRUDMode) As PNB09100Back.PNB09100DTO Implements R_BackEnd.R_IServicebase(Of PNB09100Back.PNB09100DTO).Svc_R_Save

    End Function

End Class
