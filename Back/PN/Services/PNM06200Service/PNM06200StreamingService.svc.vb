Imports System.ServiceModel
Imports R_Common
Imports PNM06200Back
Imports PNM06200Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM06200StreamingService" in code, svc and config file together.
Public Class PNM06200StreamingService
    Implements IPNM06200StreamingService

    Public Function getSearchList() As System.ServiceModel.Channels.Message Implements IPNM06200StreamingService.getSearchList
        Dim loException As New R_Exception
        Dim loCls As New PNM06200HrdOfficialLetterCLS
        Dim loRtnTemp As List(Of PNM06200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM06200DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .lBasedOnTransaction = R_Utility.R_GetStreamingContext("lBasedOnTransaction")
            End With

            loRtnTemp = loCls.getSearchList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM06200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSearchList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMailMergeData() As System.ServiceModel.Channels.Message Implements IPNM06200StreamingService.getMailMergeData
        Dim loException As New R_Exception
        Dim loCls As New PNM06200HrdOfficialLetterCLS
        Dim loRtnTemp As List(Of PNM06200MailMergeDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM06200DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
                .cTemplateId = R_Utility.R_GetStreamingContext("cTemplateId")
                .cCreateBy = R_Utility.R_GetStreamingContext("cCreateBy")
            End With

            loRtnTemp = loCls.getMailMergeData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM06200MailMergeDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMailMergeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
