Imports R_BackEnd
Imports R_Common
Imports ATM00500Back
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00500EService" in code, svc and config file together.
Public Class ATM00500EService
    Implements IATM00500EService

    Public Sub Svc_R_Delete(poEntity As ATM00500Back.ATM00500EDTO) Implements R_BackEnd.R_IServicebase(Of ATM00500Back.ATM00500EDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00500ECls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00500Back.ATM00500EDTO) As ATM00500Back.ATM00500EDTO Implements R_BackEnd.R_IServicebase(Of ATM00500Back.ATM00500EDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00500ECls
        Dim loRtn As ATM00500EDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00500Back.ATM00500EDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00500Back.ATM00500EDTO Implements R_BackEnd.R_IServicebase(Of ATM00500Back.ATM00500EDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00500ECls
        Dim loRtn As ATM00500EDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    'Public Function SaveBatch(pcCompId As String, poNewEntity As System.Collections.Generic.List(Of ATM00500Back.ATM00500EDTO), poCRUDMode As R_Common.eCRUDMode) As System.Collections.Generic.List(Of ATM00500Back.ATM00500EDTO) Implements IATM00500EService.SaveBatch
    '    Dim loException As New R_Exception
    '    Dim loCls As New ATM00500ECls
    '    Dim loRtn As List(Of ATM00500EDTO) = Nothing

    '    Try
    '        loRtn = loCls.SaveBatch(pcCompId, poNewEntity, poCRUDMode)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

End Class

