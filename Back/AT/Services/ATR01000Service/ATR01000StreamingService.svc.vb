' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01000StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR01000Back
Imports ATR01000Common
Imports R_BackEnd

Public Class ATR01000StreamingService
    Implements IATR01000StreamingService
     
    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR01000StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR01000CLS
        Dim poParam As New ATR01000DTO
        Dim loRtnList As List(Of ATR01000ReportDTO)
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
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnList = loCls.GetData(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01000ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReason() As System.ServiceModel.Channels.Message Implements IATR01000StreamingService.getReason
        Dim loException As New R_Exception
        Dim loCls As New ATR01000CLS
        Dim poParam As New ATR01000DTO
        Dim loRtnList As List(Of ATR01000ComboDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getReason(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01000ComboDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReason")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDataExcel() As System.ServiceModel.Channels.Message Implements IATR01000StreamingService.GetDataExcel
        Dim loException As New R_Exception
        Dim loCls As New ATR01000CLS
        Dim poParam As New ATR01000DTO
        Dim loRtnList As List(Of ATR01000ExcelDTO)
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
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnList = loCls.GetDataExcel(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01000ExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDataExcel")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
