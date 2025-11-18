Imports R_Common
Imports PYM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM001000202Service" in code, svc and config file together.
Public Class PYM0010002Service
    Implements IPYM0010002Service

    Public Sub Svc_R_Delete(poEntity As PYM00100Back.PYM0010002DTO) Implements R_BackEnd.R_IServicebase(Of PYM00100Back.PYM0010002DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00100Back.PYM0010002DTO) As PYM00100Back.PYM0010002DTO Implements R_BackEnd.R_IServicebase(Of PYM00100Back.PYM0010002DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM0010002CLS
        Dim loRtn As PYM0010002DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00100Back.PYM0010002DTO, poCRUDMode As R_Common.eCRUDMode) As PYM00100Back.PYM0010002DTO Implements R_BackEnd.R_IServicebase(Of PYM00100Back.PYM0010002DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM0010002CLS
        Dim loRtn As PYM0010002DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckSystemParam(poParam As String) As Boolean Implements IPYM0010002Service.CheckSystemParam
        Dim loEx As New R_Exception
        Dim loCls As New PYM0010002CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckSystemParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
