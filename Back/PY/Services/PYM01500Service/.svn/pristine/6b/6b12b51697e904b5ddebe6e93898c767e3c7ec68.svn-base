Imports System.ServiceModel
Imports R_Common
Imports PYM01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM01500Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01500StreamingServiceRef" in code, svc and config file together.
Public Class PYM01500StreamingService
    Implements IPYM01500StreamingService

    Public Function getYearList() As System.ServiceModel.Channels.Message Implements IPYM01500StreamingService.getYearList
        Dim loEx As New R_Exception
        Dim loCls As New PYM01500Cls
        Dim loRtn As New List(Of PYM01500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01500DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtn = loCls.getYearList(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getYearList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
