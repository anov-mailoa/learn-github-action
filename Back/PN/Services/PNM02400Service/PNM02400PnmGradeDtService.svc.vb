Imports R_Common
Imports R_BackEnd
Imports PNM02400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02400PnmGradeDtService" in code, svc and config file together.
Public Class PNM02400PnmGradeDtService
    Implements IPNM02400PnmGradeDtService

    Public Sub Svc_R_Delete(poEntity As PNM02400Back.PNM02400PnmGradeDtDTO) Implements R_BackEnd.R_IServicebase(Of PNM02400Back.PNM02400PnmGradeDtDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02400PnmGradeDtCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02400Back.PNM02400PnmGradeDtDTO) As PNM02400Back.PNM02400PnmGradeDtDTO Implements R_BackEnd.R_IServicebase(Of PNM02400Back.PNM02400PnmGradeDtDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeDtCls
        Dim loRtn As PNM02400PnmGradeDtDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02400Back.PNM02400PnmGradeDtDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02400Back.PNM02400PnmGradeDtDTO Implements R_BackEnd.R_IServicebase(Of PNM02400Back.PNM02400PnmGradeDtDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeDtCls
        Dim loRtn As PNM02400PnmGradeDtDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
