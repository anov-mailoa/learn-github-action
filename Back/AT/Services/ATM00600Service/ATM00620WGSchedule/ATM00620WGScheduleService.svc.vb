Imports System.ServiceModel
Imports ATM00600Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00620WGScheduleService" in code, svc and config file together.
Public Class ATM00620WGScheduleService
    Implements IATM00620WGScheduleService

    Public Function setStartDate(ByVal poParam As ATM00600Back.ATM00620WGScheduleDTO) As ATM00600Back.ATM00620WGScheduleDTO Implements IATM00620WGScheduleService.setStartDate
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WGScheduleCls

            Return loClass.setStartDate(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getPatternDayStart(ByVal poParam As ATM00600Back.ATM00620WGScheduleDTO) As ATM00600Back.ATM00620WGScheduleDTO Implements IATM00620WGScheduleService.getPatternDayStart
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WGScheduleCls

            Return loClass.getPatternDayStart(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getPatternSeqStart(ByVal poParam As ATM00600Back.ATM00620WGScheduleDTO) As ATM00600Back.ATM00620WGScheduleDTO Implements IATM00620WGScheduleService.getPatternSeqStart
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WGScheduleCls

            Return loClass.getPatternSeqStart(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getLastAttDate(ByRef poParam As ATM00600Back.ATM00620WGScheduleDTO) As String Implements IATM00620WGScheduleService.getLastAttDate
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WGScheduleCls

            Return loClass.getLastAttDate(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub Svc_R_Delete(poEntity As ATM00600Back.ATM00620WGScheduleDTO) Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WGScheduleDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00600Back.ATM00620WGScheduleDTO) As ATM00600Back.ATM00620WGScheduleDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WGScheduleDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATM00600Back.ATM00620WGScheduleDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00600Back.ATM00620WGScheduleDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WGScheduleDTO).Svc_R_Save

    End Function

    Public Function getDataProcessSingle(ByRef poParam As ATM00600Back.ATM00620WGScheduleDTO) As ATM00620WGScheduleDTO Implements IATM00620WGScheduleService.getDataProcessSingle
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WGScheduleCls

            Return loClass.getDataProcessSchedule(poParam)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
     
End Class
