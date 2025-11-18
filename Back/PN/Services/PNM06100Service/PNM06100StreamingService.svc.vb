Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports PNM06100Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM06100StreamingService" in code, svc and config file together.
Public Class PNM06100StreamingService
    Implements IPNM06100StreamingService

    Public Function getLetterTemplate() As System.ServiceModel.Channels.Message Implements IPNM06100StreamingService.getLetterTemplate
        Dim loException As New R_Exception
        Dim loCls As New PNM06100LetterTemplateCLS
        Dim loRtnTemp As List(Of PNM06100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM06100DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
            End With

            loRtnTemp = loCls.getLetterTemplate(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM06100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLetterTemplate")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As System.Collections.Generic.List(Of PNM06100Back.PNM06100GridDTO)) Implements IPNM06100StreamingService.Dummy

    End Sub
End Class
