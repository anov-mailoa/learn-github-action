Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYR01000Common
Imports PYR01000Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR01000StreamingService" in code, svc and config file together.
Public Class PYR01000StreamingService
    Implements IPYR01000StreamingService

    Public Function getCustomReportList() As System.ServiceModel.Channels.Message Implements IPYR01000StreamingService.getCustomReportList
        Dim loEx As New R_Exception
        Dim loCls As New PYR01000Cls
        Dim poParam As New PYR01000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getCustomReportList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCustomReportList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCustomReportCellList() As System.ServiceModel.Channels.Message Implements IPYR01000StreamingService.getCustomReportCellList
        Dim loEx As New R_Exception
        Dim loCls As New PYR01000Cls
        Dim poParam As New PYR01000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportId = R_Utility.R_GetStreamingContext("cReportId")
            End With

            loRtnList = loCls.getCustomReportCellList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCustomReportCellList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
