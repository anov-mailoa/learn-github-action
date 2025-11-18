Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports PNM06100Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM06111StreamingService" in code, svc and config file together.
Public Class PNM06111StreamingService
    Implements IPNM06111StreamingService

    Public Function GetLetterNumber() As System.ServiceModel.Channels.Message Implements IPNM06111StreamingService.GetLetterNumber
        Dim loCls As New PNM06110NumberProcessCLS
        Dim poParam As New PNM06110NumberDTO
        Dim loRtnTemp As List(Of PNM06110NumberStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
                .cTemplateId = R_Utility.R_GetStreamingContext("cTemplateId")

                .cNumberingMethod = R_Utility.R_GetStreamingContext("cNumberingMethod")
                .cCreateBy = R_Utility.R_GetStreamingContext("cCreateBy")
                .dCreateDate = R_Utility.R_GetStreamingContext("dCreateDate")
                .cUpdateBy = R_Utility.R_GetStreamingContext("cUpdateBy")
                .dUpdateDate = R_Utility.R_GetStreamingContext("dUpdateDate")
            End With

            loRtnTemp = loCls.GetLetterNumber(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM06110NumberStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLetterNumber")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As System.Collections.Generic.List(Of PNM06100Back.PNM06110NumberGridDTO)) Implements IPNM06111StreamingService.Dummy

    End Sub

End Class
