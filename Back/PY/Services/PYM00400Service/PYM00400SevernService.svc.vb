Imports R_Common
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00400PPH21Service" in code, svc and config file together.
Public Class PYM00400SevernService
    Implements IPYM00400SevernService

    Public Sub Svc_R_Delete1(poEntity As PYM00400Back.PYM00400SevernDTO) Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400SevernDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400SevernCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord1(poEntity As PYM00400Back.PYM00400SevernDTO) As PYM00400Back.PYM00400SevernDTO Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400SevernDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400SevernCLS
        Dim loRtn As New PYM00400SevernDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As PYM00400Back.PYM00400SevernDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00400Back.PYM00400SevernDTO Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400SevernDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400SevernCLS
        Dim loRtn As New PYM00400SevernDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
