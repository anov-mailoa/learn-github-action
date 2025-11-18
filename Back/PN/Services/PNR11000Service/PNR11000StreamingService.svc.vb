Imports System.ServiceModel
Imports R_Common
Imports PNR11000Back
Imports PNR11000Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR11000StreamingService" in code, svc and config file together.
Public Class PNR11000StreamingService
    Implements IPNR11000StreamingService

    Public Function getMailMergeData() As System.ServiceModel.Channels.Message Implements IPNR11000StreamingService.getMailMergeData
        Dim loException As New R_Exception
        Dim loCls As New PNR11000HrdOfficialLetterCLS
        Dim poParam As New PNR11000DTO
        Dim loRtnTemp As List(Of PNR11000MailMergeDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
                .cTemplateId = R_Utility.R_GetStreamingContext("cTemplateId")
                .cCreateBy = R_Utility.R_GetStreamingContext("cCreateBy")
            End With

            loRtnTemp = loCls.getMailMergeData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR11000MailMergeDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMailMergeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSearchList() As System.ServiceModel.Channels.Message Implements IPNR11000StreamingService.getSearchList
        Dim loException As New R_Exception
        Dim loCls As New PNR11000HrdOfficialLetterCLS
        Dim poParam As New PNR11000DTO
        Dim loRtnTemp As List(Of PNR11000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

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
            loList = R_Utility.R_GetChunkData(Of PNR11000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSearchList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
