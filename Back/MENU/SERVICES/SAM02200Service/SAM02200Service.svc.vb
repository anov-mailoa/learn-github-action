Imports R_Common
Imports SAM02200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02200Service" in code, svc and config file together.
Public Class SAM02200Service
    Implements ISAM02200Service

    Public Sub Svc_R_Delete(poEntity As SAM02200Back.SAM02200DTO) Implements R_BackEnd.R_IServicebase(Of SAM02200Back.SAM02200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02200Back.SAM02200DTO) As SAM02200Back.SAM02200DTO Implements R_BackEnd.R_IServicebase(Of SAM02200Back.SAM02200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM02200Cls
        Dim loRtn As SAM02200DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM02200Back.SAM02200DTO, poCRUDMode As R_Common.eCRUDMode) As SAM02200Back.SAM02200DTO Implements R_BackEnd.R_IServicebase(Of SAM02200Back.SAM02200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM02200Cls
        Dim loRtn As SAM02200DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub saveData(poParam As SAM02200Back.SaveFileDTO) Implements ISAM02200Service.saveData
        Dim loEx As New R_Exception
        Dim loCls As New SAM02200Cls

        Try
            loCls.saveData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub saveSplitData(poParam As SAM02200Back.SplitDTO) Implements ISAM02200Service.saveSplitData
        Dim loEx As New R_Exception
        Dim loCls As New SAM02200Cls

        Try
            loCls.saveSplitData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
