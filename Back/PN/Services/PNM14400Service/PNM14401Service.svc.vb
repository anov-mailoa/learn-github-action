Imports R_BackEnd
Imports R_Common
Imports PNM14400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14401Service" in code, svc and config file together.
Public Class PNM14401Service
    Implements IPNM14401Service


    Public Sub Svc_R_Delete(poEntity As PNM14400Back.PNM14400KartuKeluargaDTO) Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400KartuKeluargaDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM14400Back.PNM14400KartuKeluargaDTO) As PNM14400Back.PNM14400KartuKeluargaDTO Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400KartuKeluargaDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400KartuKeluargaBPJSCls
        Dim loRtn As New PNM14400KartuKeluargaDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM14400Back.PNM14400KartuKeluargaDTO, poCRUDMode As R_Common.eCRUDMode) As PNM14400Back.PNM14400KartuKeluargaDTO Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400KartuKeluargaDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400KartuKeluargaBPJSCls
        Dim loRtn As New PNM14400KartuKeluargaDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


End Class
