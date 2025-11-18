Imports R_Common
Imports PYB08000Back
Imports System.ServiceModel.Channels
Imports PYB08000Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB08000StreamingService" in code, svc and config file together.
Public Class PYB08000StreamingService
    Implements IPYB08000StreamingService

    Public Function getList() As System.ServiceModel.Channels.Message Implements IPYB08000StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New PYB08000Cls
        Dim loRtnTemp As List(Of PYB08000StreamingDto)
        Dim loRtn As Message
        Dim loParam As New PYB08000Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cFlag = R_Utility.R_GetStreamingContext("cFlag")
                .cPeriod = R_Utility.R_GetStreamingContext("PERIODE")
            End With

            loRtnTemp = loCls.getList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB08000StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar2 As System.Collections.Generic.List(Of PYB08000Back.PYB08000Dto)) Implements IPYB08000StreamingService.Dummy

    End Sub
End Class
