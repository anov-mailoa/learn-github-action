Imports R_Common
Imports PNT06200Back


' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06200ReturnHdServices" in code, svc and config file together.
Public Class PNT06200ReturnHdServices
    Implements IPNT06200ReturnHdServices

    Public Sub Svc_R_Delete(ByVal poEntity As PNT06200Back.PNT06200ReturnHdDto) Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnHdDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnHdCls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As PNT06200Back.PNT06200ReturnHdDto) As PNT06200Back.PNT06200ReturnHdDto Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnHdDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnHdCls
        Dim loRtn As New PNT06200ReturnHdDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As PNT06200Back.PNT06200ReturnHdDto, ByVal poCRUDMode As R_Common.eCRUDMode) As PNT06200Back.PNT06200ReturnHdDto Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnHdDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnHdCls
        Dim loRtn As New PNT06200ReturnHdDto
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(ByVal poParam As PNT06200Back.PNT06200ReturnHdDto) As PNT06200Back.PNT06200ReturnHdDto Implements IPNT06200ReturnHdServices.Draft
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnHdCls
        Dim loRtn As New PNT06200ReturnHdDto
        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(ByVal poParam As PNT06200Back.PNT06200ReturnHdDto) As PNT06200Back.PNT06200ReturnHdDto Implements IPNT06200ReturnHdServices.Submit
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200ReturnHdCls
        Dim loRtn As New PNT06200ReturnHdDto
        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub runRejectProcess(ByVal poParam As PNT06200Back.PNT06200ReturnHdDto) Implements IPNT06200ReturnHdServices.runRejectProcess
        Dim loEx As New R_Exception
        Dim loCls As PNT06200ReturnHdCls
        Dim loRtn As New PNT06200ReturnHdDto
        Try
            loCls.runRejectProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
