Imports R_Common
Imports PNM04100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM04100Service" in code, svc and config file together.
Public Class PNM04100Service
    Implements IPNM04100Service


    Public Sub Svc_R_Delete(poEntity As PNM04100Back.PNM04100PnmFacilitiesDto) Implements R_BackEnd.R_IServicebase(Of PNM04100Back.PNM04100PnmFacilitiesDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM04100PnmFacilitiesCls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM04100Back.PNM04100PnmFacilitiesDto) As PNM04100Back.PNM04100PnmFacilitiesDto Implements R_BackEnd.R_IServicebase(Of PNM04100Back.PNM04100PnmFacilitiesDto).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New PNM04100PnmFacilitiesCls
        Dim loRtn As New PNM04100PnmFacilitiesDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Function Svc_R_Save(poEntity As PNM04100Back.PNM04100PnmFacilitiesDto, poCRUDMode As R_Common.eCRUDMode) As PNM04100Back.PNM04100PnmFacilitiesDto Implements R_BackEnd.R_IServicebase(Of PNM04100Back.PNM04100PnmFacilitiesDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM04100PnmFacilitiesCls
        Dim loRtn As New PNM04100PnmFacilitiesDto
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Activate1(poParam As PNM04100Back.PNM04100PnmFacilitiesDto) As PNM04100Back.PNM04100PnmFacilitiesDto Implements IPNM04100Service.Activate
        Dim loEx As New R_Exception
        Dim loCls As New PNM04100PnmFacilitiesCls
        Dim loRtn As New PNM04100PnmFacilitiesDto
        Try
            loRtn = loCls.Activate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
