Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00595Back
Imports ATR00595Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00595StreamingService" in code, svc and config file together.
Public Class ATR00595StreamingService
    Implements IATR00595StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR00595StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR00595CLS
        Dim poParam As New ATR00595DTO
        Dim loRtnList As List(Of ATR00595ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnList = loCls.GetData(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00595ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReason() As System.ServiceModel.Channels.Message Implements IATR00595StreamingService.getReason
        Dim loException As New R_Exception
        Dim loCls As New ATR00595CLS
        Dim poParam As New ATR00595DTO
        Dim loRtnList As List(Of ATR00595ComboDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getReason(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00595ComboDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReason")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
