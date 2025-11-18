Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR12400Back
Imports PYR12400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR12300StreamingService" in code, svc and config file together.
Public Class PYR12400StreamingService
    Implements IPYR12400StreamingService

    Public Function GetSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYR12400StreamingService.GetSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYR12400Cls
        Dim poParam As New PYR12400DTO
        Dim loRtnList As New List(Of PYR12400StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.GetSalaryGroup(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSalaryGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYR12400Back.PYR12400DTO)) Implements IPYR12400StreamingService.Dummy

    End Sub

    Public Function GetComponentReport() As System.ServiceModel.Channels.Message Implements IPYR12400StreamingService.GetComponentReport
        Dim loEx As New R_Exception
        Dim loCls As New PYR12400Cls
        Dim poParam As New PYR12400DTO
        Dim loRtnList As New List(Of PYR12400StreamingDTO)
        Dim loList As New List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE_LIST = R_Utility.R_GetStreamingContext("CGROUP_CODE_LIST")
                .IHISTORY_MODE = R_Utility.R_GetStreamingContext("IHISTORY_MODE")
                .CCUTOFF_DATE = R_Utility.R_GetStreamingContext("CCUTOFF_DATE")
                .IEMPLOYEE_MODE = R_Utility.R_GetStreamingContext("IEMPLOYEE_MODE")
                .IREPORT_TYPE = R_Utility.R_GetStreamingContext("IREPORT_TYPE")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CSELECTED_EMPLOYEE = R_Utility.R_GetStreamingContext("CSELECTED_EMPLOYEE")
                loRtnList = loCls.GetComponentReport(poParam)
                loList = R_Utility.R_GetChunkData(Of PYR12400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            End With


            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetComponentReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
