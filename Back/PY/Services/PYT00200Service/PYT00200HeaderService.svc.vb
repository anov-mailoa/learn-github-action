Imports R_Common
Imports PYT00200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00200HeaderService" in code, svc and config file together.
Public Class PYT00200HeaderService
    Implements IPYT00200HeaderService


    Public Sub Svc_R_Delete(poEntity As PYT00200Back.PYT00200HeaderDetailDTO) Implements R_BackEnd.R_IServicebase(Of PYT00200Back.PYT00200HeaderDetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00200Back.PYT00200HeaderDetailDTO) As PYT00200Back.PYT00200HeaderDetailDTO Implements R_BackEnd.R_IServicebase(Of PYT00200Back.PYT00200HeaderDetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim loRtn As PYT00200HeaderDetailDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00200Back.PYT00200HeaderDetailDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00200Back.PYT00200HeaderDetailDTO Implements R_BackEnd.R_IServicebase(Of PYT00200Back.PYT00200HeaderDetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim loRtn As PYT00200HeaderDetailDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkActivePeriod(poParam As PYT00200Back.PYT00200HeaderDetailDTO) As Boolean Implements IPYT00200HeaderService.checkActivePeriod
        Dim loRtn As Boolean
        Dim loCls As New PYT00200HeaderCls
        Dim loException As New R_Exception

        Try
            loRtn = loCls.checkActivePeriod(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroupDetail(poParam As PYT00200Back.PYT00200HeaderDetailDTO) As PYT00200Back.PYT00200HeaderDetailDTO Implements IPYT00200HeaderService.getSalaryGroupDetail
        Dim loRtn As New PYT00200HeaderDetailDTO
        Dim loCls As New PYT00200HeaderCls
        Dim loException As New R_Exception

        Try
            loRtn = loCls.getSalaryGroupDetail(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PYT00200Back.PYT00200HeaderDetailDTO) As PYT00200Back.PYT00200HeaderDetailDTO Implements IPYT00200HeaderService.DraftProcess
        Dim loCls As New PYT00200HeaderCls
        Dim loException As New R_Exception
        Dim loRtn As New PYT00200HeaderDetailDTO

        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function OpenProcess(poParam As PYT00200Back.PYT00200HeaderDetailDTO) As PYT00200Back.PYT00200HeaderDetailDTO Implements IPYT00200HeaderService.OpenProcess
        Dim loCls As New PYT00200HeaderCls
        Dim loException As New R_Exception
        Dim loRtn As New PYT00200HeaderDetailDTO

        Try
            loRtn = loCls.OpenProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function cekSalaryEffectiveDate(poParam As PYT00200Back.PYT00200HeaderDetailDTO) As String Implements IPYT00200HeaderService.cekSalaryEffectiveDate
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim lcRtn As String = ""
        Try
            lcRtn = loCls.cekSalaryEffectiveDate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

End Class
