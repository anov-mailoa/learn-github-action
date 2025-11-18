Imports R_BackEnd
Imports R_Common
Imports PNM14300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14300Service" in code, svc and config file together.
Public Class PNM14300Service
    Implements IPNM14300Service


    Public Sub Svc_R_Delete(poEntity As PNM14300Back.PNM14300DetailDTO) Implements R_BackEnd.R_IServicebase(Of PNM14300Back.PNM14300DetailDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM14300Back.PNM14300DetailDTO) As PNM14300Back.PNM14300DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM14300Back.PNM14300DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14300Cls
        Dim loRtn As New PNM14300DetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNM14300Back.PNM14300DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PNM14300Back.PNM14300DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM14300Back.PNM14300DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM14300Cls
        Dim loRtn As New PNM14300DetailDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Activate(poParam As PNM14300Back.PNM14300DetailDTO) As PNM14300Back.PNM14300DetailDTO Implements IPNM14300Service.Activate
        Dim loEx As New R_Exception
        Dim loCls As New PNM14300Cls
        Dim loRtn As New PNM14300DetailDTO
        Try
            loRtn = loCls.Activate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Deactivate(poParam As PNM14300Back.PNM14300DetailDTO) As PNM14300Back.PNM14300DetailDTO Implements IPNM14300Service.Deactivate
        Dim loEx As New R_Exception
        Dim loCls As New PNM14300Cls
        Dim loRtn As New PNM14300DetailDTO
        Try
            loRtn = loCls.Deactivate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
