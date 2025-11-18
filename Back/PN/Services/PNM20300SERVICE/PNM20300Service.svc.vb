Imports R_Common
Imports PNM20300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000CanteenService" in code, svc and config file together.
Public Class PNM20300Service
    Implements IPNM20300Service

    Public Sub Svc_R_Delete(poEntity As PNM20300Back.PNM20300DTO) Implements R_BackEnd.R_IServicebase(Of PNM20300Back.PNM20300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM20300Back.PNM20300DTO) As PNM20300Back.PNM20300DTO Implements R_BackEnd.R_IServicebase(Of PNM20300Back.PNM20300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM20300CLS
        Dim loRtn As New PNM20300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM20300Back.PNM20300DTO, poCRUDMode As R_Common.eCRUDMode) As PNM20300Back.PNM20300DTO Implements R_BackEnd.R_IServicebase(Of PNM20300Back.PNM20300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM20300CLS
        Dim loRtn As New PNM20300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
