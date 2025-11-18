Imports R_Common
Imports GSM01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01000Service" in code, svc and config file together.
Public Class GSM01000Service
    Implements IGSM01000Service

    Public Sub Svc_R_Delete(poEntity As GSM01000Back.GSM01000DTO) Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01000Back.GSM01000DTO) As GSM01000Back.GSM01000DTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01000Cls
        Dim loRtn As GSM01000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01000Back.GSM01000DTO, poCRUDMode As R_Common.eCRUDMode) As GSM01000Back.GSM01000DTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01000Cls
        Dim loRtn As GSM01000DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM01000Back.GSM01000CmbDTO)) Implements IGSM01000Service.Dummy

    End Sub

    Public Function cekApproval(poParam As GSM01000Back.GSM01000DTO) As Boolean Implements IGSM01000Service.cekApproval
        Dim loException As New R_Exception
        Dim loCls As New GSM01000Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekApproval(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekNumbering(poParam As GSM01000Back.GSM01000DTO) As Boolean Implements IGSM01000Service.cekNumbering
        Dim loException As New R_Exception
        Dim loCls As New GSM01000Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekNumbering(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getRestrictFlag(pcCompId As String, pcTransCd As String) As Boolean Implements IGSM01000Service.getRestrictFlag
        Dim loException As New R_Exception
        Dim loCls As New GSM01001Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getRestrictFlag(pcCompId, pcTransCd)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function NumberingHasUsedInTransaction(pcCompId As String) As Boolean Implements IGSM01000Service.NumberingHasUsedInTransaction
        Dim loException As New R_Exception
        Dim loCls As New GSM01000Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.NumberingHasUsedInTransaction(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub generateNumbering(pcCompId As String) Implements IGSM01000Service.generateNumbering
        Dim loException As New R_Exception
        Dim loCls As New GSM01000Cls

        Try
            loCls.generateNumbering(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
