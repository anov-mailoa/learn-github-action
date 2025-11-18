Imports R_Common
Imports PNT06200Back


' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06200ReturnDtServices" in code, svc and config file together.
Public Class PNT06200ReturnDtServices
    Implements IPNT06200ReturnDtServices


    Public Sub Svc_R_Delete(poEntity As PNT06200Back.PNT06200ReturnDtDto) Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnDtDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnDtCls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT06200Back.PNT06200ReturnDtDto) As PNT06200Back.PNT06200ReturnDtDto Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnDtDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnDtCls
        Dim loRtn As New PNT06200ReturnDtDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT06200Back.PNT06200ReturnDtDto, poCRUDMode As R_Common.eCRUDMode) As PNT06200Back.PNT06200ReturnDtDto Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnDtDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnDtCls
        Dim loRtn As New PNT06200ReturnDtDto
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As PNT06200Back.PNT06200ReturnDtDto) Implements IPNT06200ReturnDtServices.Dummy

    End Sub
End Class
