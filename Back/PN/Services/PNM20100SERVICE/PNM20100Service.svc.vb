Imports R_Common
Imports PNM20100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000CanteenService" in code, svc and config file together.
Public Class PNM20100Service
    Implements IPNM20100Service

    Public Sub RSP_PNM20100_COPY_DINING_SCHEDULE(poParam As PNM20100DTO) Implements IPNM20100Service.RSP_PNM20100_COPY_DINING_SCHEDULE
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS

        Try
            loCls.RSP_PNM20100_COPY_DINING_SCHEDULE(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNM20100Back.PNM20100DTO) Implements R_BackEnd.R_IServicebase(Of PNM20100Back.PNM20100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function RFN_FIND_MIN_DATE_DINING_SCHEDULE(poParam As PNM20100DTO) As String Implements IPNM20100Service.RFN_FIND_MIN_DATE_DINING_SCHEDULE
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS
        Dim lcRtn As String

        Try
            lcRtn = loCls.RFN_FIND_MIN_DATE_DINING_SCHEDULE(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function

    Public Function Svc_R_GetRecord(poEntity As PNM20100Back.PNM20100DTO) As PNM20100Back.PNM20100DTO Implements R_BackEnd.R_IServicebase(Of PNM20100Back.PNM20100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS
        Dim loRtn As New PNM20100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM20100Back.PNM20100DTO, poCRUDMode As R_Common.eCRUDMode) As PNM20100Back.PNM20100DTO Implements R_BackEnd.R_IServicebase(Of PNM20100Back.PNM20100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS
        Dim loRtn As New PNM20100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
