Imports R_Common
Imports PNM05100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05100DetailService" in code, svc and config file together.
Public Class PNM05100DetailService
    Implements IPNM05100DetailService

    Public Sub Svc_R_Delete(poEntity As PNM05100Back.PNM05100DetailDTO) Implements R_BackEnd.R_IServicebase(Of PNM05100Back.PNM05100DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM05100DetailCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05100Back.PNM05100DetailDTO) As PNM05100Back.PNM05100DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM05100Back.PNM05100DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05100DetailCLS
        Dim loRtn As New PNM05100DetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05100Back.PNM05100DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05100Back.PNM05100DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM05100Back.PNM05100DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05100DetailCLS
        Dim loRtn As New PNM05100DetailDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNM05100Back.PNM05100DetailGridDTO)) Implements IPNM05100DetailService.Dummy

    End Sub

    Public Function removeAll(poParam As PNM05100Back.PNM05100DetailDTO) As Object Implements IPNM05100DetailService.removeAll
        Dim loEx As New R_Exception
        Dim loCls As New PNM05100DetailCLS
        Try
            loCls.removeAll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    'Public Sub RSP_GET_POSITION_RIGHTS(poParam As PNM05100Back.PNM05100DetailDTO) Implements IPNM05100DetailService.RSP_GET_POSITION_RIGHTS
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNM05100DetailCLS
    '    Try
    '        loCls.RSP_GET_POSITION_RIGHTS(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub
End Class
