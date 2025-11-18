Imports R_Common
Imports PYM00700Back
Imports System.ServiceModel.Channels
Imports PYM00700Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00700StreamingService" in code, svc and config file together.
Public Class PYM00700StreamingService
    Implements IPYM00700StreamingService

    Public Function getTransferCodeHd() As System.ServiceModel.Channels.Message Implements IPYM00700StreamingService.getTransferCodeHd
        Dim loEx As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtnTemp As List(Of PYM00700TransCodeDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00700DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTransferCodeHd(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00700TransCodeDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransferCodeHd")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getProcessCode() As System.ServiceModel.Channels.Message Implements IPYM00700StreamingService.getProcessCode
        Dim loEx As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtnTemp As List(Of PYM00700ProcessCodeDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00700DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransferCode = R_Utility.R_GetStreamingContext("cTransferCode")
            End With

            loRtnTemp = loCls.getProcessCode(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00700ProcessCodeDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcessCode")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getBankAccount() As System.ServiceModel.Channels.Message Implements IPYM00700StreamingService.getBankAccount
        Dim loEx As New R_Exception
        Dim loCls As New PYM00700Cls
        Dim loRtnTemp As List(Of PYM00700BankAccDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00700DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getBankAccount(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00700BankAccDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of PYM00700Back.PYM00700TransCodeDTO)) Implements IPYM00700StreamingService.Dummy

    End Sub

    Public Sub Dummy1(poPar1 As System.Collections.Generic.List(Of PYM00700Back.PYM00700ProcessCodeDTO)) Implements IPYM00700StreamingService.Dummy1

    End Sub
End Class
