Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR07000Back
Imports MCR07000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR07000StreamingService" in code, svc and config file together.
Public Class MCR07000StreamingService
    Implements IMCR07000StreamingService


    Public Function getDataReport() As System.ServiceModel.Channels.Message Implements IMCR07000StreamingService.getDataReport
        Dim loException As New R_Exception
        Dim loCls As New mcr07000CLS
        Dim poParam As New mcr07000DTO
        Dim loRtnList As New List(Of mcr07000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cSortBy = R_Utility.R_GetStreamingContext("cSortBy")
                .cPartnerList = R_Utility.R_GetStreamingContext("cPartnerList")
                .lAllPartner = R_Utility.R_GetStreamingContext("lAllPartner")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getDataReport(poParam)
            loList = R_Utility.R_GetChunkData(Of mcr07000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class
