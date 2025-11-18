Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000CanteenService" in code, svc and config file together.
Public Class PNM20000Service
    Implements IPNM20000Service

    Public Sub Svc_R_Delete(poEntity As PNM20000Back.PNM20000CanteenGridDTO) Implements R_BackEnd.R_IServicebase(Of PNM20000Back.PNM20000CanteenGridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000CanteenCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM20000Back.PNM20000CanteenGridDTO) As PNM20000Back.PNM20000CanteenGridDTO Implements R_BackEnd.R_IServicebase(Of PNM20000Back.PNM20000CanteenGridDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000CanteenCLS
        Dim loRtn As New PNM20000CanteenGridDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM20000Back.PNM20000CanteenGridDTO, poCRUDMode As R_Common.eCRUDMode) As PNM20000Back.PNM20000CanteenGridDTO Implements R_BackEnd.R_IServicebase(Of PNM20000Back.PNM20000CanteenGridDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000CanteenCLS
        Dim loRtn As New PNM20000CanteenGridDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
