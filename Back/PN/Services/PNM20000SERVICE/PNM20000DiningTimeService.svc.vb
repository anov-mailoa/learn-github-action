Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000DiningTimeService" in code, svc and config file together.
Public Class PNM20000DiningTimeService
    Implements IPNM20000DiningTimeService

    Public Sub Svc_R_Delete(poEntity As PNM20000Back.PNM20000DiningTimeDTO) Implements R_BackEnd.R_IServicebase(Of PNM20000Back.PNM20000DiningTimeDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000DiningTimeCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM20000Back.PNM20000DiningTimeDTO) As PNM20000Back.PNM20000DiningTimeDTO Implements R_BackEnd.R_IServicebase(Of PNM20000Back.PNM20000DiningTimeDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000DiningTimeCLS
        Dim loRtn As New PNM20000DiningTimeDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM20000Back.PNM20000DiningTimeDTO, poCRUDMode As R_Common.eCRUDMode) As PNM20000Back.PNM20000DiningTimeDTO Implements R_BackEnd.R_IServicebase(Of PNM20000Back.PNM20000DiningTimeDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000DiningTimeCLS
        Dim loRtn As New PNM20000DiningTimeDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
