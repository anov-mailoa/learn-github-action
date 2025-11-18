Imports R_BackEnd
Imports R_Common
Imports ESM01200Back
Imports ESM01200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01200Service" in code, svc and config file together.
Public Class ESM01200LeaveService
    Implements IESM01200LeaveService

    Public Sub Svc_R_Delete(poEntity As ESM01200Back.ESM01200LeaveDTO) Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200LeaveDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01200Back.ESM01200LeaveDTO) As ESM01200Back.ESM01200LeaveDTO Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200LeaveDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtn As New ESM01200LeaveDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01200Back.ESM01200LeaveDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01200Back.ESM01200LeaveDTO Implements R_BackEnd.R_IServicebase(Of ESM01200Back.ESM01200LeaveDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtn As New ESM01200LeaveDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSumLeaveBalance(poParam As ESM01200Back.ESM01200LeaveDTO) As ESM01200Back.ESM01200LeaveDTO Implements IESM01200LeaveService.getSumLeaveBalance
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtn As New ESM01200LeaveDTO

        Try
            loRtn = loCls.getSumLeaveBalance(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
