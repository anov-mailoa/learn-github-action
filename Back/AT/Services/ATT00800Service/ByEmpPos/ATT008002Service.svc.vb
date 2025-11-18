Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ATT00800Back
Imports ATT00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT008002Service" in code, svc and config file together.
Public Class ATT008002Service
    Implements IATT008002Service

    Public Sub prosesSave(ByVal poParam As ATT00800Back.ATT008002DTO) Implements IATT008002Service.prosesSave
        Dim loEx As New R_Exception()
        Dim loCls As New ATT008002Cls
        Try
            loCls.prosesSave(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub prosesSaveAsDraft(ByVal poParam As ATT00800Back.ATT008002DTO) Implements IATT008002Service.prosesSaveAsDraft
        Dim loEx As New R_Exception()
        Dim loCls As New ATT008002Cls
        Try
            loCls.prosesSaveAsDraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    'Public Function getShiftCode(ByVal poParam As ATT00800Back.ATT008002DTO) As System.Collections.Generic.List(Of ATT00800Back.ATT008002DTO) Implements IATT008002Service.getShiftCode
    '    Dim loEx As New R_Exception()
    '    Dim loCls As New ATT008002Cls
    '    Dim loRtn As New List(Of ATT008002DTO)
    '    Try
    '        loRtn = loCls.getShiftCode(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    Return loRtn
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Function

    Public Sub Svc_R_Delete(ByVal poEntity As ATT00800Back.ATT008002DTO) Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT008002DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As ATT00800Back.ATT008002DTO) As ATT00800Back.ATT008002DTO Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT008002DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtn As New ATT008002DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As ATT00800Back.ATT008002DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As ATT00800Back.ATT008002DTO Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT008002DTO).Svc_R_Save

    End Function

    Public Function getLookUpWorkGroupDesc(poParam As ATT00800Back.ATT008002DTO) As ATT00800Back.ATT008002DTO Implements IATT008002Service.getLookUpWorkGroupDesc

        Dim loEx As New R_Exception
        Dim loCls As New ATT00800ByWorkGroupCls
        Dim loRtn As New ATT008002DTO

        Try
            loRtn = loCls.getLookUpWorkGroupDesc(poParam)



        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function getLookUpReasonDesc(poParam As ATT00800Back.ATT008002DTO) As ATT00800Back.ATT008002DTO Implements IATT008002Service.getLookUpReasonDesc
        Dim loEx As New R_Exception
        Dim loCls As New ATT00800ByWorkGroupCls
        Dim loRtn As New ATT008002DTO

        Try
            loRtn = loCls.getLookUpReasonDesc(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
