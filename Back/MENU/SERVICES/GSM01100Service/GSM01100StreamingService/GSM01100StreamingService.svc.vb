Imports R_Common
Imports R_BackEnd
Imports GSM01100Back
Imports GSM01100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01100StreamingService" in code, svc and config file together.
Public Class GSM01100StreamingService
    Implements IGSM01100StreamingService

    Public Function getMasterBank() As System.ServiceModel.Channels.Message Implements IGSM01100StreamingService.getMasterBank
        Dim loException As New R_Exception
        Dim loCls As New GSM01100Cls
        Dim loRtnTemp As List(Of GSM01100BankGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01100MasterBankDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getMasterBank(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01100BankGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMasterBank")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompanyBank() As System.ServiceModel.Channels.Message Implements IGSM01100StreamingService.getCompanyBank
        Dim loException As New R_Exception
        Dim loCls As New GSM01100CompanyBankCls
        Dim loRtnTemp As List(Of GSM01100CompBankGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01100MasterBankDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCompanyBank(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01100CompBankGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompanyBank")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM01100Back.GSM01100BankGridDTO)) Implements IGSM01100StreamingService.Dummy

    End Sub
End Class
