Imports R_Common
Imports PYT00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00800Service" in code, svc and config file together.
Public Class PYT00800DetailService
    Implements IPYT00800DetailService

    Public Sub Svc_R_Delete(poEntity As PYT00800Back.PYT00800DetailDTO) Implements R_BackEnd.R_IServicebase(Of PYT00800Back.PYT00800DetailDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00800Back.PYT00800DetailDTO) As PYT00800Back.PYT00800DetailDTO Implements R_BackEnd.R_IServicebase(Of PYT00800Back.PYT00800DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800DetailCls
        Dim loRtn As PYT00800DetailDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00800Back.PYT00800DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00800Back.PYT00800DetailDTO Implements R_BackEnd.R_IServicebase(Of PYT00800Back.PYT00800DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800DetailCls
        Dim loRtn As PYT00800DetailDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
