Imports R_BackEnd
Imports R_Common
Imports PYT00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00400HdService" in code, svc and config file together.
Public Class PYT00400HdService
    Implements IPYT00400HdService

    Public Sub Svc_R_Delete(poEntity As PYT00400Back.PYT00400HdDTO) Implements R_BackEnd.R_IServicebase(Of PYT00400Back.PYT00400HdDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New PYT00400HdCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00400Back.PYT00400HdDTO) As PYT00400Back.PYT00400HdDTO Implements R_BackEnd.R_IServicebase(Of PYT00400Back.PYT00400HdDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As PYT00400HdDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00400Back.PYT00400HdDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00400Back.PYT00400HdDTO Implements R_BackEnd.R_IServicebase(Of PYT00400Back.PYT00400HdDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As PYT00400HdDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionPeriod(poParam As PYT00400Back.PYT00400HdDTO) As String Implements IPYT00400HdService.GetTransactionPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As String

        Try
            loRtn = loCls.GetTransactionPeriod(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function UpdatePytTransDt(poParam As PYT00400Back.PYT00400HdDTO) As Boolean Implements IPYT00400HdService.UpdatePytTransDt
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00400HdCls
    '    Dim loRtn As Boolean

    '    Try
    '        loRtn = loCls.UpdatePytTransDt(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function GetActivePeriod(poParam As PYT00400Back.PYT00400HdDTO) As PYT00400Back.PYT00400HdDTO Implements IPYT00400HdService.GetActivePeriod
        Dim loException As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As PYT00400HdDTO

        Try
            loRtn = loCls.GetActivePeriod(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function GetDataUpdateMaster(poParam As PYT00400Back.PYT00400HdDTO) As Boolean Implements IPYT00400HdService.GetDataUpdateMaster
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00400HdCls
    '    Dim loRtn As Boolean

    '    Try
    '        loRtn = loCls.GetDataUpdateMaster(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function DraftFunction(poParam As PYT00400Back.PYT00400HdDTO) As PYT00400Back.PYT00400HdDTO Implements IPYT00400HdService.DraftFunction
        Dim loException As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As New PYT00400HdDTO

        Try
            loRtn = loCls.DraftFunction(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function OpenFunction(poParam As PYT00400Back.PYT00400HdDTO) As PYT00400Back.PYT00400HdDTO Implements IPYT00400HdService.OpenFunction
        Dim loException As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As New PYT00400HdDTO


        Try
            loRtn = loCls.OpenFunction(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckFinalizeKpp(poParam As PYT00400Back.PYT00400HdDTO) As Boolean Implements IPYT00400HdService.CheckFinalizeKpp
        Dim loException As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckFinalizeKpp(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
