Imports R_Common
Imports PYM01600Back
Imports System.ServiceModel.Channels
Imports PYM01600Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01600StreamingService" in code, svc and config file together.
Public Class PYM01600StreamingService
    Implements IPYM01600StreamingService

    Public Function getCurrencyList() As System.ServiceModel.Channels.Message Implements IPYM01600StreamingService.getCurrencyList
        Dim loEx As New R_Exception
        Dim loCls As New PYM01600Cls
        Dim loRtnTemp As List(Of PYM01600StreamingDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getCurrencyList()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCurrencyList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDenominationList() As System.ServiceModel.Channels.Message Implements IPYM01600StreamingService.getDenominationList
        Dim loEx As New R_Exception
        Dim loCls As New PYM01600Cls
        Dim loRtnTemp As List(Of PYM01600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM01600DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
            End With

            loRtnTemp = loCls.getDenominationList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDenominationList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


End Class
