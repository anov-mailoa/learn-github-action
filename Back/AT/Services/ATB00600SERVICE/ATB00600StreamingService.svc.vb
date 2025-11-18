' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00600StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports ATB00600Back
Imports R_BackEnd
Imports R_Common
Imports ATB00600Common

Public Class ATB00600StreamingService
    Implements IATB00600StreamingService
     
    Public Function getEmployeeValidation() As System.ServiceModel.Channels.Message Implements IATB00600StreamingService.getEmployeeValidation
        Dim loException As New R_Exception
        Dim loCls As New ATB00600CLS
        Dim loRtn As New List(Of ATB00600StreamingDTO)
        Dim loRtnMessage As Message
        Dim loParam As New ATB00600DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cStartDateSchedule = R_Utility.R_GetStreamingContext("cStartDateSchedule")
            loParam.cLastDtGenerateSchedule = R_Utility.R_GetStreamingContext("cLastDtGenerateSchedule")

            loRtn = loCls.getEmployeeValidation(loParam)
            loList = R_Utility.R_GetChunkData(Of ATB00600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeValidation")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
