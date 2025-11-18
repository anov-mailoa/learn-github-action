Imports R_Common
Imports SAM00200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM00200Service" in code, svc and config file together.
Public Class SAM00200Service
    Implements ISAM00200Service

    Public Sub Svc_R_Delete(poEntity As SAM00200Back.SAM00200DTO) Implements R_BackEnd.R_IServicebase(Of SAM00200Back.SAM00200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM00200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM00200Back.SAM00200DTO) As SAM00200Back.SAM00200DTO Implements R_BackEnd.R_IServicebase(Of SAM00200Back.SAM00200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM00200Cls
        Dim loRtn As SAM00200DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM00200Back.SAM00200DTO, poCRUDMode As R_Common.eCRUDMode) As SAM00200Back.SAM00200DTO Implements R_BackEnd.R_IServicebase(Of SAM00200Back.SAM00200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM00200Cls
        Dim loRtn As SAM00200DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkLOB(pcLOBCode As String) As Boolean Implements ISAM00200Service.checkLOB
        Dim loEx As New R_Exception
        Dim loCls As New SAM00200Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkLOB(pcLOBCode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
