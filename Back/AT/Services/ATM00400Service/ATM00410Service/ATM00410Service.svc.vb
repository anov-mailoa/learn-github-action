Imports R_Common
Imports R_BackEnd
Imports ATM00400Back
Imports ATM00400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00410Service" in code, svc and config file together.
Public Class ATM00410Service
    Implements IATM00410Service

    Public Sub Svc_R_Delete(poEntity As ATM00400Back.ATM00400DTO) Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00410Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00400Back.ATM00400DTO) As ATM00400Back.ATM00400DTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00410Cls
        Dim loRtn As ATM00400DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00400Back.ATM00400DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00400Back.ATM00400DTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400DTO).Svc_R_Save

    End Function

    'Public Function SaveBatch(pcCompId As String, poNewEntity As System.Collections.Generic.List(Of ATM00400Back.ATM00400DTO), poCRUDMode As R_Common.eCRUDMode) As System.Collections.Generic.List(Of ATM00400Back.ATM00400DTO) Implements IATM00410Service.SaveBatch
    '    Dim loException As New R_Exception
    '    Dim loCls As New ATM00410Cls
    '    Dim loRtn As List(Of ATM00400DTO) = Nothing

    '    Try
    '        loRtn = loCls.SaveBatch(pcCompId, poNewEntity, poCRUDMode)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function



    'Public Function getAtmOffice(poParam As ATM00400Back.ATM00400DTO) As System.Collections.Generic.List(Of ATM00400Back.ATM00400DTO) Implements IATM00410Service.getAtmOffice
    '    Dim loException As New R_Exception
    '    Dim loCls As New ATM00410Cls
    '    Dim loRtn As List(Of ATM00400DTO) = Nothing

    '    Try
    '        loRtn = loCls.GetAtmOffice(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function cekAtmCard(poParam As ATM00400Back.ATM00400DTO) As System.Collections.Generic.List(Of ATM00400Common.ATM00400StreamingDTO) Implements IATM00410Service.cekAtmCard
        Dim loException As New R_Exception
        Dim loCls As New ATM00410Cls
        Dim loRtn As List(Of ATM00400StreamingDTO) = Nothing

        Try
            loRtn = loCls.cekAtmCard(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
