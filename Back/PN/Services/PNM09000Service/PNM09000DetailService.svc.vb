Imports System.ServiceModel
Imports R_Common
Imports PNM09000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM09000DetailService" in code, svc and config file together.
Public Class PNM09000DetailService
    Implements IPNM09000DetailService



    Public Sub Svc_R_Delete(poEntity As PNM09000Back.PNM09000DetailDTO) Implements R_BackEnd.R_IServicebase(Of PNM09000Back.PNM09000DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000DetailCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM09000Back.PNM09000DetailDTO) As PNM09000Back.PNM09000DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM09000Back.PNM09000DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000DetailCls
        Dim loRtn As PNM09000DetailDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM09000Back.PNM09000DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PNM09000Back.PNM09000DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM09000Back.PNM09000DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000DetailCls
        Dim loRtn As PNM09000DetailDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
