Imports R_BackEnd
Imports R_Common
Imports ATR02600Back
Imports ATR02600Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR02600StreamingService" in code, svc and config file together.
Public Class ATR02600StreamingService
    Implements IATR02600StreamingService


    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IATR02600StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATR02600Cls
        Dim loRtn As New List(Of ATR02600GridDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR02600GridDTO
        Dim loList As List(Of Byte())
        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompId")
            poParam.CLOGINID = R_Utility.R_GetStreamingContext("cUserId")
            poParam.DDATE = R_Utility.R_GetStreamingContext("dDate")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getAllEmployee(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR02600GridDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "AllEmployeeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getSP() As System.ServiceModel.Channels.Message Implements IATR02600StreamingService.getSP
        Dim loException As New R_Exception
        Dim loCls As New ATR02600Cls
        Dim loRtn As New List(Of ATR02600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR02600GridDTO
        Dim loList As List(Of Byte())
        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompId")
            poParam.CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("cEmployeeList")
            poParam.CPERIOD = R_Utility.R_GetStreamingContext("cPeriod")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")

            loRtn = loCls.getSP(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR02600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "SPData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParGrid As System.Collections.Generic.List(Of ATR02600Back.ATR02600GridDTO), poParSP As System.Collections.Generic.List(Of ATR02600Back.ATR02600SPDTO)) Implements IATR02600StreamingService.Dummy

    End Sub
End Class
