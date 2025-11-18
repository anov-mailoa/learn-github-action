Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200PersonalBankService" in code, svc and config file together.
Public Class PNM05200PersonalBankService
    Implements IPNM05200PersonalBankService

    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200PersonalBankDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PersonalBankDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalBankCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200PersonalBankDTO) As PNM05200Back.PNM05200PersonalBankDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PersonalBankDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalBankCls
        Dim loRtn As New PNM05200PersonalBankDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200PersonalBankDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200PersonalBankDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PersonalBankDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalBankCls
        Dim loRtn As New PNM05200PersonalBankDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCmbCashBank(poParam As PNM05200Back.PNM05200PersonalBankDTO) As System.Collections.Generic.List(Of PNM05200Back.ComboBoxDTO) Implements IPNM05200PersonalBankService.getCmbCashBank
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalBankCls
        Dim loRtn As New List(Of ComboBoxDTO)

        Try
            loRtn = loCls.getCmbCashBank(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCurrency(poParam As PNM05200Back.PNM05200PersonalBankDTO) As System.Collections.Generic.List(Of PNM05200Back.ComboBoxDTO) Implements IPNM05200PersonalBankService.getCurrency
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalBankCls
        Dim loRtn As New List(Of ComboBoxDTO)

        Try
            loRtn = loCls.getCurrency(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
