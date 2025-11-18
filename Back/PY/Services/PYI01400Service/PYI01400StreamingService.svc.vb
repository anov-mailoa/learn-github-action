Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYI01400Back
Imports PYI01400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYI01400StreamingService" in code, svc and config file together.
Public Class PYI01400StreamingService
    Implements IPYI01400StreamingService

    Public Function GetCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYI01400StreamingService.GetCmbPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYI01400CLS
        Dim poParam As New PYI01400DTO
        Dim loRtnTemp As List(Of PYI01400StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.GetCmbPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI01400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbPeriod")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionInquiry() As System.ServiceModel.Channels.Message Implements IPYI01400StreamingService.GetTransactionInquiry
        Dim loException As New R_Exception
        Dim loCls As New PYI01400CLS
        Dim poParam As New PYI01400DTO
        Dim loRtnTemp As List(Of PYI01400StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .iInquiryType = R_Utility.R_GetStreamingContext("iInquiryType")
                .cStatus = R_Utility.R_GetStreamingContext("cStatus")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.GetTransactionInquiry(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI01400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionInquiry")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYI01400Back.PYI01400DTO)) Implements IPYI01400StreamingService.Dummy

    End Sub
End Class
