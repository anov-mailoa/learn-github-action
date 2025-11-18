Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT01000RegularService" in code, svc and config file together.
Public Class PNT01000RegularService

    Implements IPNT01000RegularService

    Public Sub Svc_R_Delete(poEntity As PNT01000Back.PNT01000DTO) Implements R_BackEnd.R_IServicebase(Of PNT01000Back.PNT01000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements R_BackEnd.R_IServicebase(Of PNT01000Back.PNT01000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As PNT01000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT01000Back.PNT01000DTO, poCRUDMode As R_Common.eCRUDMode) As PNT01000Back.PNT01000DTO Implements R_BackEnd.R_IServicebase(Of PNT01000Back.PNT01000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As PNT01000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    'Public Function CekDepartment(poParam As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.CekDepartment
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNT01000Cls
    '    Dim loRtn As PNT01000DTO

    '    Try
    '        loRtn = loCls.CekDepartment(poParam)

    '    Catch ex As Exception
    '        loEx.Add(ex)

    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn
    'End Function

    Public Function CekEmployee(poParam As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.CekEmployee
        'Dim loEx As New R_Exception
        'Dim loCls As New PNT01000Cls
        'Dim loRtn As PNT01000DTO

        'Try
        '    loRtn = loCls.CekEmployee(poParam)

        'Catch ex As Exception
        '    loEx.Add(ex)

        'End Try
        'loEx.ConvertAndThrowToServiceExceptionIfErrors()
        'Return loRtn
    End Function

    Public Function CekPosition(poParam As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.CekPosition
        'Dim loEx As New R_Exception
        'Dim loCls As New PNT01000Cls
        'Dim loRtn As PNT01000DTO

        'Try
        '    loRtn = loCls.CekPosition(poParam)

        'Catch ex As Exception
        '    loEx.Add(ex)

        'End Try
        'loEx.ConvertAndThrowToServiceExceptionIfErrors()
        'Return loRtn
    End Function


    'Public Function DraftUndraft(poCurrent As PNT01000Back.PNT01000DTO) As Boolean Implements IPNT01000RegularService.DraftUndraft
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNT01000Cls
    '    Dim loRtn As Boolean

    '    Try
    '        loRtn = loCls.DraftUndraft(poCurrent)

    '    Catch ex As Exception
    '        loEx.Add(ex)

    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    ''    Return loRtn
    ''End Function

    'Public Function Submit(poCurrent As PNT01000Back.PNT01000DTO) As Boolean Implements IPNT01000RegularService.Submit
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNT01000Cls
    '    Dim loRtn As New PNT01000DTO

    '    Try
    '        loRtn = loCls.Submit(poCurrent)

    '    Catch ex As Exception
    '        loEx.Add(ex)

    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn
    'End Function

    Public Function GetRecordById2(poEntity As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.GetRecordById2
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As PNT01000DTO

        Try
            loRtn = loCls.GetRecordById2(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetRecordById3(poEntity As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.GetRecordById3
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As PNT01000DTO

        Try
            loRtn = loCls.GetRecordById3(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetRecordById4(poEntity As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.GetRecordById4
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As PNT01000DTO

        Try
            loRtn = loCls.GetRecordById4(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poCurrent As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As New PNT01000DTO

        Try
            loRtn = loCls.DraftUndraft(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poCurrent As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.Submit
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As New PNT01000DTO

        Try
            loRtn = loCls.Submit(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT01000Back.PNT01000DTO) As PNT01000Back.PNT01000DTO Implements IPNT01000RegularService.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As New PNT01000DTO

        Try
            loRtn = loCls.Reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckStatus(poEntity As PNT01000Back.PNT01000DTO) As Integer Implements IPNT01000RegularService.CheckStatus
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.CheckStatus(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetProbationNote(poEntity As PNT01000Back.PNT01000DTO) As String Implements IPNT01000RegularService.GetProbationNote
        Dim loEx As New R_Exception
        Dim loCls As New PNT01000Cls
        Dim loRtn As String

        Try
            loRtn = loCls.GetProbationNote(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
