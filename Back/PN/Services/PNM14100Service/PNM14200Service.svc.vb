Imports R_BackEnd
Imports R_Common
Imports PNM14100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14200Service" in code, svc and config file together.
Public Class PNM14200Service
    Implements IPNM14200Service

    Public Sub Svc_R_Delete(poEntity As PNM14100Back.PNM14200Dto) Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14200Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM14200Cls
        Dim loRtn As PNM14200Dto

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM14100Back.PNM14200Dto) As PNM14100Back.PNM14200Dto Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14200Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14200Cls
        Dim loRtn As PNM14200Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM14100Back.PNM14200Dto, poCRUDMode As R_Common.eCRUDMode) As PNM14100Back.PNM14200Dto Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14200Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM14200Cls
        Dim loRtn As PNM14200Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParStreaming As System.Collections.Generic.List(Of PNM14100Back.DropDownListDto)) Implements IPNM14200Service.Dummy

    End Sub

    Public Function cekUsedBPJS(poParam As PNM14100Back.PNM14200Dto) As Boolean Implements IPNM14200Service.cekUsedBPJS
        Dim loEx As New R_Exception
        Dim loCls As New PNM14200Cls
        Dim llRtn As New Boolean

        Try
            llRtn = loCls.cekUsedBPJS(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llRtn
    End Function

    Public Function setActivateDeactivate(poParam As PNM14100Back.PNM14200Dto) As PNM14100Back.PNM14200Dto Implements IPNM14200Service.setActivateDeactivate
        Dim loEx As New R_Exception
        Dim loCls As New PNM14200Cls
        Dim loRtn As New PNM14200Dto

        Try
            loRtn = loCls.setActivateDeactivate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
