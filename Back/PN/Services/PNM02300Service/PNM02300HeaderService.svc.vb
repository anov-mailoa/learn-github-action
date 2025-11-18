Imports R_Common
Imports PNM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02300HeaderService" in code, svc and config file together.
Public Class PNM02300HeaderService
    Implements IPNM02300HeaderService

    Public Sub Svc_R_Delete(poEntity As PNM02300Back.PNM02300HeaderDTO) Implements R_BackEnd.R_IServicebase(Of PNM02300Back.PNM02300HeaderDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300HeaderCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02300Back.PNM02300HeaderDTO) As PNM02300Back.PNM02300HeaderDTO Implements R_BackEnd.R_IServicebase(Of PNM02300Back.PNM02300HeaderDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300HeaderCLS
        Dim loRtn As New PNM02300HeaderDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02300Back.PNM02300HeaderDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02300Back.PNM02300HeaderDTO Implements R_BackEnd.R_IServicebase(Of PNM02300Back.PNM02300HeaderDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300HeaderCLS
        Dim loRtn As New PNM02300HeaderDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkDetail(poParam As PNM02300Back.PNM02300HeaderDTO) As Boolean Implements IPNM02300HeaderService.checkDetail
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300HeaderCLS
        Dim loRtn As Boolean
        Try
            loRtn = loCls.checkDetail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
