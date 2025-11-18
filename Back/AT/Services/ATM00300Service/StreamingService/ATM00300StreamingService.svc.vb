Imports R_BackEnd
Imports R_Common
Imports ATM00300Back
Imports ATM00300Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00300StreamingService" in code, svc and config file together.
Public Class ATM00300StreamingService
    Implements IATM00300StreamingService

    Public Function getAtmHolidayParam() As System.ServiceModel.Channels.Message Implements IATM00300StreamingService.getAtmHolidayParam
        Dim loException As New R_Exception
        Dim loCls As New ATM00300Cls
        Dim loRtn As New List(Of ATM00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATM00300DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")

            loRtn = loCls.getAtmHolidayParam(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "HolidayData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATM00300StreamingService.getEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATM00300BCls
        Dim loRtn As New List(Of ATM00300BStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATM00300BDTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cHolidayDate = R_Utility.R_GetStreamingContext("cHolidayDate")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00300BStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "EmployeeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

   
End Class
