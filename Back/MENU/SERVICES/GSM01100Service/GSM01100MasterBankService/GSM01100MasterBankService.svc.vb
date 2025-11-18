Imports R_Common
Imports GSM01100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01100MasterBankService" in code, svc and config file together.
Public Class GSM01100MasterBankService
    Implements IGSM01100MasterBankService

    Public Sub Svc_R_Delete(poEntity As GSM01100Back.GSM01100MasterBankDTO) Implements R_BackEnd.R_IServicebase(Of GSM01100Back.GSM01100MasterBankDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01100Back.GSM01100MasterBankDTO) As GSM01100Back.GSM01100MasterBankDTO Implements R_BackEnd.R_IServicebase(Of GSM01100Back.GSM01100MasterBankDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01100Cls
        Dim loRtn As GSM01100MasterBankDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01100Back.GSM01100MasterBankDTO, poCRUDMode As R_Common.eCRUDMode) As GSM01100Back.GSM01100MasterBankDTO Implements R_BackEnd.R_IServicebase(Of GSM01100Back.GSM01100MasterBankDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01100Cls
        Dim loRtn As GSM01100MasterBankDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
