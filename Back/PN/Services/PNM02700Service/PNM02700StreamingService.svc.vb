Imports R_BackEnd
Imports R_Common
Imports PNM02700Back
Imports PNM02700Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02700StreamingService" in code, svc and config file together.

Public Class PNM02700StreamingService
    Implements IPNM02700StreamingService

    Public Function getFaultList() As System.ServiceModel.Channels.Message Implements IPNM02700StreamingService.getFaultList
        Dim loException As New R_Exception
        Dim loCls As New PNM02700CLS
        Dim loRtnTemp As List(Of PNM02700StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02700FormDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getFaultList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02700StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFaultList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getData() As System.ServiceModel.Channels.Message Implements IPNM02700StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New PNM02700CLS
        Dim loRtnTemp As List(Of PNM02700StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02700FormDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02700StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As System.Collections.Generic.List(Of PNM02700Back.PNM02700GridDTO), poReport As System.Collections.Generic.List(Of PNM02700Back.PNM02700ReportDTO)) Implements IPNM02700StreamingService.Dummy

    End Sub
End Class
