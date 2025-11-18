Imports R_BackEnd
Imports R_Common
Imports PNM14400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14402Service" in code, svc and config file together.
Public Class PNM14402Service
    Implements IPNM14402Service

    Public Function Svc_R_GetRecord(poEntity As PNM14400Back.PNM14400AnggotaBpjsDetailDTO) As PNM14400Back.PNM14400AnggotaBpjsDetailDTO Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400AnggotaBpjsDetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400AnggotaBpjsCls
        Dim loRtn As New PNM14400AnggotaBpjsDetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNM14400Back.PNM14400AnggotaBpjsDetailDTO, poCRUDMode As R_Common.eCRUDMode) As PNM14400Back.PNM14400AnggotaBpjsDetailDTO Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400AnggotaBpjsDetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400AnggotaBpjsCls
        Dim loRtn As New PNM14400AnggotaBpjsDetailDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub Svc_R_Delete(poEntity As PNM14400Back.PNM14400AnggotaBpjsDetailDTO) Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400AnggotaBpjsDetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400AnggotaBpjsCls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function ActivateDeactivate(poParam As PNM14400Back.PNM14400AnggotaBpjsDetailDTO) As PNM14400Back.PNM14400AnggotaBpjsDetailDTO Implements IPNM14402Service.ActivateDeactivate
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400AnggotaBpjsCls
        Dim loRtn As New PNM14400AnggotaBpjsDetailDTO
        Try
            loRtn = loCls.ActivateDeactivate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
