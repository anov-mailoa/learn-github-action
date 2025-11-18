Imports R_BackEnd
Imports R_Common
Imports ATR01150Back
Imports ATR01150Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01150StreamingService" in code, svc and config file together.
Public Class ATR01150StreamingService
    Implements IATR01150StreamingService


    Public Function getSP() As System.ServiceModel.Channels.Message Implements IATR01150StreamingService.getSP
        Dim loException As New R_Exception
        Dim loCls As New ATR01150Cls
        Dim loRtn As New List(Of ATR01150StreamingSPDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR01150GridDTO
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
            End With

            loRtn = loCls.getSP(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01150StreamingSPDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "SPData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


    Public Sub Dummy(poParGridStreaming As System.Collections.Generic.List(Of ATR01150Back.ATR01150GridDTO), popar1 As System.Collections.Generic.List(Of ATR01150Back.ATR01150SPDTO)) Implements IATR01150StreamingService.Dummy

    End Sub
End Class
