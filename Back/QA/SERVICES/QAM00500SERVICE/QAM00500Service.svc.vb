Imports R_BackEnd
Imports R_Common
Imports QAM00500Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00500Service" in code, svc and config file together.
Public Class QAM00500Service
    Implements IQAM00500Service

    Public Sub Svc_R_Delete(poEntity As QAM00500Back.QAM00500Dto) Implements R_BackEnd.R_IServicebase(Of QAM00500Back.QAM00500Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loIsoTypeCls As New QAM00500IsoTypeCls
        Dim loClauseCls As New QAM00500ClauseCls
        Try
            If poEntity.cFormOrigin = "IsoType" Then
                loIsoTypeCls.R_Delete(poEntity)
            ElseIf poEntity.cFormOrigin = "Clause" Then
                loClauseCls.R_Delete(poEntity)
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAM00500Back.QAM00500Dto) As QAM00500Back.QAM00500Dto Implements R_BackEnd.R_IServicebase(Of QAM00500Back.QAM00500Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loIsoTypeCls As New QAM00500IsoTypeCls
        Dim loClauseCls As New QAM00500ClauseCls
        Dim loRtn As New QAM00500Dto

        Try
            If poEntity.cFormOrigin = "IsoType" Then
                loRtn = loIsoTypeCls.R_GetRecord(poEntity)
            ElseIf poEntity.cFormOrigin = "Clause" Then
                loRtn = loClauseCls.R_GetRecord(poEntity)
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAM00500Back.QAM00500Dto, poCRUDMode As R_Common.eCRUDMode) As QAM00500Back.QAM00500Dto Implements R_BackEnd.R_IServicebase(Of QAM00500Back.QAM00500Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loIsoTypeCls As New QAM00500IsoTypeCls
        Dim loClauseCls As New QAM00500ClauseCls
        Dim loRtn As New QAM00500Dto

        Try
            If poEntity.cFormOrigin = "IsoType" Then
                loRtn = loIsoTypeCls.R_Save(poEntity, poCRUDMode)
            ElseIf poEntity.cFormOrigin = "Clause" Then
                loRtn = loClauseCls.R_Save(poEntity, poCRUDMode)
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetParameter(poParam As QAM00500Back.QAM00500Dto) As QAM00500Back.QAM00500Dto Implements IQAM00500Service.GetParameter
        Dim loEx As New R_Exception
        Dim loIsoTypeCls As New QAM00500IsoTypeCls
        Dim loRtn As New QAM00500Dto

        Try
            loRtn = loIsoTypeCls.GetParameter(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetAlreadyUsed(poParam As QAM00500Back.QAM00500Dto) As QAM00500Back.QAM00500Dto Implements IQAM00500Service.GetAlreadyUsed
        Dim loEx As New R_Exception
        Dim loIsoTypeCls As New QAM00500IsoTypeCls
        Dim loRtn As New QAM00500Dto

        Try
            loRtn = loIsoTypeCls.GetAlreadyUsed(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
