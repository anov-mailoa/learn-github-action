' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01050StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR01050Back
Imports ATR01050Common
Imports R_BackEnd

Public Class ATR01050StreamingService
    Implements IATR01050StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR01050StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR01050CLS
        Dim poParam As New ATR01050DTO
        Dim loRtnList As List(Of ATR01050ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .lIsAllReason = R_Utility.R_GetStreamingContext("lIsAllReason")
                .cReasonList = R_Utility.R_GetStreamingContext("cReasonList")
                .lActualGroup = R_Utility.R_GetStreamingContext("lActualGroup")
                .CMASK = R_Utility.R_GetStreamingContext("CMASK")
                .CTEMP = R_Utility.R_GetStreamingContext("CTEMP")
            End With

            loRtnList = loCls.GetData(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01050ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReason() As System.ServiceModel.Channels.Message Implements IATR01050StreamingService.getReason
        Dim loException As New R_Exception
        Dim loCls As New ATR01050CLS
        Dim poParam As New ATR01050DTO
        Dim loRtnList As List(Of ATR01050ComboDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getReason(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01050ComboDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReason")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
