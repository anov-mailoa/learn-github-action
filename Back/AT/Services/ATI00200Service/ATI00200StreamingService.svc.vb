Imports System.ServiceModel.Channels
Imports ATI00200Back
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00200StreamingService" in code, svc and config file together.
Public Class ATI00200StreamingService
    Implements IATI00200StreamingService

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of ATI00200Back.ATI00200StreamingDTO), poParam2 As System.Collections.Generic.List(Of ATI00200Back.ATI00200ComboDTO)) Implements IATI00200StreamingService.Dummy

    End Sub

    Public Function getGridForm200() As System.ServiceModel.Channels.Message Implements IATI00200StreamingService.getGridForm200
        Dim loEx As New R_Exception
        Dim loCls As New ATI00200CLS
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATI00200StreamingDTO)
        Dim poParam As New ATI00200DTO

        Try
            With poParam
                .cCompId = R_Utility.R_GetStreamingContext("cCompId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cYr = R_Utility.R_GetStreamingContext("cYr")
                .cMon = R_Utility.R_GetStreamingContext("cMon")
            End With

            loRtnList = loCls.getGridForm200(poParam)

            loRtn = R_StreamUtility(Of ATI00200StreamingDTO).WriteToMessage(loRtnList.AsEnumerable, "getGridForm200")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Function getGridForm210() As System.ServiceModel.Channels.Message Implements IATI00200StreamingService.getGridForm210
        Dim loEx As New R_Exception
        Dim loCls As New ATI00200CLS
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATI00200StreamingDTO)
        Dim poParam As New ATI00200DTO

        Try
            With poParam
                .cCompId = R_Utility.R_GetStreamingContext("cCompId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cWorkGrp = R_Utility.R_GetStreamingContext("cWorkGrp")
                .cYr = R_Utility.R_GetStreamingContext("cYr")
                .cMon = R_Utility.R_GetStreamingContext("cMon")
            End With

            loRtnList = loCls.getGridForm210(poParam)

            loRtn = R_StreamUtility(Of ATI00200StreamingDTO).WriteToMessage(loRtnList.AsEnumerable, "getGridForm210")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Function getGridForm220() As System.ServiceModel.Channels.Message Implements IATI00200StreamingService.getGridForm220
        Dim loEx As New R_Exception
        Dim loCls As New ATI00200CLS
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATI00200StreamingDTO)
        Dim poParam As New ATI00200DTO

        Try
            With poParam
                .cCompId = R_Utility.R_GetStreamingContext("cCompId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cWorkGrp = R_Utility.R_GetStreamingContext("cWorkGrp")
                .cYr = R_Utility.R_GetStreamingContext("cYr")
                .cMon = R_Utility.R_GetStreamingContext("cMon")
            End With

            loRtnList = loCls.getGridForm220(poParam)

            loRtn = R_StreamUtility(Of ATI00200StreamingDTO).WriteToMessage(loRtnList.AsEnumerable, "getGridForm220")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Function getGridForm230() As System.ServiceModel.Channels.Message Implements IATI00200StreamingService.getGridForm230
        Dim loEx As New R_Exception
        Dim loCls As New ATI00200CLS
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATI00200StreamingDTO)
        Dim poParam As New ATI00200DTO

        Try
            With poParam
                .cCompId = R_Utility.R_GetStreamingContext("cCompId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cWorkGrp = R_Utility.R_GetStreamingContext("cWorkGrp")
                .cEmpId = R_Utility.R_GetStreamingContext("cEmpId")
                .cToDt = R_Utility.R_GetStreamingContext("cToDt")
                .cYr = R_Utility.R_GetStreamingContext("cYr")
                .cMon = R_Utility.R_GetStreamingContext("cMon")
            End With

            loRtnList = loCls.getGridForm230(poParam)

            loRtn = R_StreamUtility(Of ATI00200StreamingDTO).WriteToMessage(loRtnList.AsEnumerable, "getGridForm230")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IATI00200StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New ATI00200Cls
        Dim loRtn As Message
        Dim loRtnList As New List(Of ATI00200ComboDTO)
        Dim poParam As New ATI00200DTO

        Try
            With poParam
                .cCompId = R_Utility.R_GetStreamingContext("cCompId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getPeriod(poParam)

            loRtn = R_StreamUtility(Of ATI00200ComboDTO).WriteToMessage(loRtnList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function
End Class
