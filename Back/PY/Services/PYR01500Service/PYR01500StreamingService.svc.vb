Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR01500Common
Imports PYR01500Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR01500StreamingService" in code, svc and config file together.
Public Class PYR01500StreamingService
    Implements IPYR01500StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR01500StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYR01500CLS
        Dim poParam As New PYR01500DTO
        Dim loRtnList As New List(Of PYR01500StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR01500StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR01500CLS
        Dim poParam As New PYR01500DTO
        Dim loRtnList As New List(Of PYR01500ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromIndex = R_Utility.R_GetStreamingContext("cFromIndex")
                .cToIndex = R_Utility.R_GetStreamingContext("cToIndex")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .lShowResignEmp = R_Utility.R_GetStreamingContext("lShowResignEmp")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01500ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IPYR01500StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYR01500CLS
        Dim poParam As New PYR01500DTO
        Dim loRtnList As New List(Of PYR01500StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYR01500Back.PYR01500DTO)) Implements IPYR01500StreamingService.Dummy

    End Sub
End Class
