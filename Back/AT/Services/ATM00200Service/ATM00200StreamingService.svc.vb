Imports System.ServiceModel.Channels
Imports ATM00200Back
Imports ATM00200Common
Imports R_Common
Imports R_Common.R_Utility
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00200StreamingService" in code, svc and config file together.
Public Class ATM00200StreamingService
    Implements IATM00200StreamingService

    Public Function getATM00200List() As System.ServiceModel.Channels.Message Implements IATM00200StreamingService.getATM00200List
        Dim loEx As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATM00200StreamingDTO)
        Dim poParam As New ATM00200DTO
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cClassRecId = R_Utility.R_GetStreamingContext("cClassRecId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getATM00200List(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getATM00200List")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function



    Public Function GetReasonList() As System.ServiceModel.Channels.Message Implements IATM00200StreamingService.GetReasonList
        Dim loEx As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATM00200StreamingDTO)
        Dim poParam As New ATM00200DTO
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReasonType = R_Utility.R_GetStreamingContext("cReasonType")
            End With

            loRtnList = loCls.GetReasonList(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReasonList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of ATM00200Back.ATM0020002DTO)) Implements IATM00200StreamingService.Dummy

    End Sub
End Class
