Imports R_Common
Imports PNT06100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06100AssignmentHdServices" in code, svc and config file together.
Public Class PNT06100AssignmentHdServices
    Implements IPNT06100AssignmentHdServices

    Public Sub Svc_R_Delete(poEntity As PNT06100Back.PNT06100AssignmentHdDto) Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentHdDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT06100Back.PNT06100AssignmentHdDto) As PNT06100Back.PNT06100AssignmentHdDto Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentHdDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Dim loRtn As New PNT06100AssignmentHdDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT06100Back.PNT06100AssignmentHdDto, poCRUDMode As R_Common.eCRUDMode) As PNT06100Back.PNT06100AssignmentHdDto Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentHdDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Dim loRtn As New PNT06100AssignmentHdDto
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(poParam As PNT06100Back.PNT06100AssignmentHdDto) As PNT06100Back.PNT06100AssignmentHdDto Implements IPNT06100AssignmentHdServices.Draft
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Dim loRtn As New PNT06100AssignmentHdDto
        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As PNT06100Back.PNT06100AssignmentHdDto) As PNT06100Back.PNT06100AssignmentHdDto Implements IPNT06100AssignmentHdServices.Submit
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Dim loRtn As New PNT06100AssignmentHdDto
        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poParam As PNT06100Back.PNT06100AssignmentHdDto) As PNT06100Back.PNT06100AssignmentHdDto Implements IPNT06100AssignmentHdServices.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Dim loRtn As New PNT06100AssignmentHdDto
        Try
            loRtn = loCls.Reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
