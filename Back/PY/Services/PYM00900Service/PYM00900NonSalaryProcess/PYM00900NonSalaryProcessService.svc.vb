Imports R_Common
Imports PYM00900Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00900NonSalaryProcessService" in code, svc and config file together.
Public Class PYM00900NonSalaryProcessService
    Implements IPYM00900NonSalaryProcessService

    Public Sub Svc_R_Delete(ByVal poEntity As PYM00900Back.PYM00900NonSalaryProcessDTO) Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900NonSalaryProcessDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As PYM00900Back.PYM00900NonSalaryProcessDTO) As PYM00900Back.PYM00900NonSalaryProcessDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900NonSalaryProcessDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtn As PYM00900NonSalaryProcessDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As PYM00900Back.PYM00900NonSalaryProcessDTO, ByVal poCRUDMode As R_Common.eCRUDMode) As PYM00900Back.PYM00900NonSalaryProcessDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900NonSalaryProcessDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtn As PYM00900NonSalaryProcessDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkExistSequence(ByVal poParam As PYM00900Back.PYM00900NonSalaryProcessDTO) As PYM00900Back.PYM00900NonSalaryProcessDTO Implements IPYM00900NonSalaryProcessService.checkExistSequence
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtn As New PYM00900NonSalaryProcessDTO

        Try
            loRtn = loCls.checkExistSequence(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckExistPeriodsNONSALARY(poParam As PYM00900Back.PYM00900NonSalaryProcessDTO) As Integer Implements IPYM00900NonSalaryProcessService.CheckExistPeriodsNONSALARY
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtn As Integer

        Try
            loRtn = loCls.CheckExistPeriodsNONSALARY(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckProcessStatus(poParam As PYM00900Back.PYM00900NonSalaryProcessDTO) As Integer Implements IPYM00900NonSalaryProcessService.CheckProcessStatus
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtn As Integer

        Try
            loRtn = loCls.CheckProcessStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
