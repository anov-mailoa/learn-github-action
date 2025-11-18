Imports System.ServiceModel
Imports ATB00400Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00400Service" in code, svc and config file together.
Public Class ATB00400Service
    Implements IATB00400Service

    Public Sub Svc_R_Delete(poEntity As ATB00400Back.ATB00400DTO) Implements R_BackEnd.R_IServicebase(Of ATB00400Back.ATB00400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATB00400Back.ATB00400DTO) As ATB00400Back.ATB00400DTO Implements R_BackEnd.R_IServicebase(Of ATB00400Back.ATB00400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATB00400Back.ATB00400DTO, poCRUDMode As R_Common.eCRUDMode) As ATB00400Back.ATB00400DTO Implements R_BackEnd.R_IServicebase(Of ATB00400Back.ATB00400DTO).Svc_R_Save

    End Function

    Public Function getLastAttDate(ByRef poParam As ATB00400Back.ATB00400DTO) As String Implements IATB00400Service.getLastAttDate
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATB00400Cls

            Return loClass.getLastAttDate(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getPatternDayStart(poParam As ATB00400Back.ATB00400DTO) As ATB00400Back.ATB00400DTO Implements IATB00400Service.getPatternDayStart
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATB00400Cls

            Return loClass.getPatternDayStart(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getPatternSeqStart(poParam As ATB00400Back.ATB00400DTO) As ATB00400Back.ATB00400DTO Implements IATB00400Service.getPatternSeqStart
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATB00400Cls

            Return loClass.getPatternSeqStart(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function previewGrid(poBatchProcessPar As R_Common.R_BatchProcessPar) As System.Collections.Generic.List(Of ATB00400Back.ATB00400DTO) Implements IATB00400Service.previewGrid
        'Dim loException As New R_Exception

        'Try
        '    Dim loClass As New ATM00620WGScheduleCls

        '    loClass.previewGrid(poBatchProcessPar)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try
        'loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function processGrid(poBatchProcessPar As R_Common.R_BatchProcessPar) As System.Collections.Generic.List(Of ATB00400Back.ATB00400DTO) Implements IATB00400Service.processGrid
        'Dim loException As New R_Exception

        'Try
        '    Dim loClass As New ATM00620WGScheduleCls

        '    loClass.processGrid(poBatchProcessPar)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try
        'loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function setStartDate(poParam As ATB00400Back.ATB00400DTO) As ATB00400Back.ATB00400DTO Implements IATB00400Service.setStartDate
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATB00400Cls

            Return loClass.setStartDate(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
