Imports R_Common
Imports PNM05100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05100HeaderService" in code, svc and config file together.
Public Class PNM05100HeaderService
    Implements IPNM05100HeaderService

    Public Sub Svc_R_Delete(poEntity As PNM05100Back.PNM05100HeaderDTO) Implements R_BackEnd.R_IServicebase(Of PNM05100Back.PNM05100HeaderDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05100Back.PNM05100HeaderDTO) As PNM05100Back.PNM05100HeaderDTO Implements R_BackEnd.R_IServicebase(Of PNM05100Back.PNM05100HeaderDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05100HeaderCLS
        Dim loRtn As New PNM05100HeaderDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05100Back.PNM05100HeaderDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05100Back.PNM05100HeaderDTO Implements R_BackEnd.R_IServicebase(Of PNM05100Back.PNM05100HeaderDTO).Svc_R_Save

    End Function

End Class
