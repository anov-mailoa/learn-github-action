Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR12200Back
Imports PYR12200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR12200StreamingService" in code, svc and config file together.
Public Class PYR12200StreamingService
    Implements IPYR12200StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPYR12200StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR12200Cls
        Dim poParam As New PYR12200DTO
        Dim loRtnList As New List(Of PYR12200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnList = loCls.GetReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12200ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYR12200StreamingService.GetSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYR12200Cls
        Dim poParam As New PYR12200DTO
        Dim loRtnList As New List(Of PYR12200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.GetSalaryGroup(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSalaryGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckSalaryRange(poEntity As PYR12200Back.PYR12200DTO) As PYR12200Back.PYR12200DTO Implements IPYR12200StreamingService.CheckSalaryRange
        Dim loException As New R_Exception
        Dim loCls As New PYR12200Cls
        Dim loRtn As New PYR12200DTO

        Try
            loRtn = loCls.CheckSalaryRange(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYR12200Back.PYR12200GridDTO)) Implements IPYR12200StreamingService.Dummy

    End Sub
End Class
