Imports R_Common
Imports PYT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00300HdService" in code, svc and config file together.
Public Class PYT00300HdService
    Implements IPYT00300HdService

    Public Sub Svc_R_Delete(poEntity As PYT00300Back.PYT00300HdDTO) Implements R_BackEnd.R_IServicebase(Of PYT00300Back.PYT00300HdDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00300Back.PYT00300HdDTO) As PYT00300Back.PYT00300HdDTO Implements R_BackEnd.R_IServicebase(Of PYT00300Back.PYT00300HdDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As PYT00300HdDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00300Back.PYT00300HdDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00300Back.PYT00300HdDTO Implements R_BackEnd.R_IServicebase(Of PYT00300Back.PYT00300HdDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As PYT00300HdDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function GetAdjustment(poParam As PYT00300Back.PYT00300HdDTO) As PYT00300Back.PYT00300HdDTO Implements IPYT00300HdService.GetAdjustment
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00300HdCls
    '    Dim loRtn As PYT00300HdDTO = Nothing

    '    Try
    '        loRtn = loCls.GetAdjustment(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function GetAdjustmentFalse(poParam As PYT00300Back.PYT00300HdDTO) As PYT00300Back.PYT00300PeriodDTO Implements IPYT00300HdService.GetAdjustmentFalse
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As PYT00300PeriodDTO

        Try
            loRtn = loCls.GetAdjustmentFalse(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetAdjustmentTrue(poParam As PYT00300Back.PYT00300HdDTO) As PYT00300Back.PYT00300PeriodDTO Implements IPYT00300HdService.GetAdjustmentTrue
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As PYT00300PeriodDTO

        Try
            loRtn = loCls.GetAdjustmentTrue(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function UpdatePytTransDt(poParam As PYT00300Back.PYT00300HdDTO) As Boolean Implements IPYT00300HdService.UpdatePytTransDt
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.UpdatePytTransDt(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PYT00300Back.PYT00300HdDTO) As PYT00300Back.PYT00300HdDTO Implements IPYT00300HdService.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As New PYT00300HdDTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function OpenProcess(poParam As PYT00300Back.PYT00300HdDTO) As PYT00300Back.PYT00300HdDTO Implements IPYT00300HdService.OpenProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtn As New PYT00300HdDTO
        Try
            loRtn = loCls.OpenProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParamHd2 As System.Collections.Generic.List(Of PYT00300Back.PYT00300GridHdDTO)) Implements IPYT00300HdService.Dummy

    End Sub

    Public Sub Dummy1(poParamDt2 As System.Collections.Generic.List(Of PYT00300Back.PYT00300GridDtDTO)) Implements IPYT00300HdService.Dummy1

    End Sub

    Public Function CheckActiveRapidTrx(poParam As PYT00300HdDTO) As String Implements IPYT00300HdService.CheckActiveRapidTrx
        Dim loException As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim lcRtn As String

        Try
            lcRtn = loCls.CheckActiveRapidTrx(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function
End Class
