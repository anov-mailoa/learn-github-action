Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09200Back


' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09201Service" in code, svc and config file together.
Public Class PNT09201Service
    Implements IPNT09201Service

    Public Sub Svc_R_Delete(poEntity As PNT09200Back.PNT09201DTO) Implements R_BackEnd.R_IServicebase(Of PNT09200Back.PNT09201DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09200Back.PNT09201DTO) As PNT09200Back.PNT09201DTO Implements R_BackEnd.R_IServicebase(Of PNT09200Back.PNT09201DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT09201Cls
        Dim loRtn As PNT09201DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09200Back.PNT09201DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09200Back.PNT09201DTO Implements R_BackEnd.R_IServicebase(Of PNT09200Back.PNT09201DTO).Svc_R_Save

    End Function


End Class
