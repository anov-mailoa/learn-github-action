Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR12300Back
Imports PYR12300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR12300StreamingService" in code, svc and config file together.
Public Class PYR12300StreamingService
    Implements IPYR12300StreamingService

    Public Function GetSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYR12300StreamingService.GetSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYR12300Cls
        Dim poParam As New PYR12300DTO
        Dim loRtnList As New List(Of PYR12300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.GetSalaryGroup(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSalaryGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYR12300Back.PYR12300DTO)) Implements IPYR12300StreamingService.Dummy

    End Sub

    Public Function getCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYR12300StreamingService.getCmbPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYR12300Cls
        Dim poParam As New PYR12300DTO
        Dim loRtnList As New List(Of PYR12300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
            End With

            loRtnList = loCls.getCmbPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR12300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetReportInterface() As System.ServiceModel.Channels.Message Implements IPYR12300StreamingService.GetReportInterface
        Dim loEx As New R_Exception
        Dim loCls As New PYR12300Cls
        Dim poParam As New PYR12300DTO

        Dim loList As New List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CSTART_PERIOD = R_Utility.R_GetStreamingContext("CSTART_PERIOD")
                .CEND_PERIOD = R_Utility.R_GetStreamingContext("CEND_PERIOD")
                .CINTERFACE_TYPE = R_Utility.R_GetStreamingContext("CINTERFACE_TYPE")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")

                .CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                .CREPORT_OPTION = R_Utility.R_GetStreamingContext("CREPORT_OPTION")
                .CPRINT_TO = R_Utility.R_GetStreamingContext("CPRINT_TO")


                Select Case .CINTERFACE_TYPE
                    Case "1"
                        If .CREPORT_TYPE = "O" Then
                            Dim loRtnList As New List(Of PYR12300ReportAttDTO)
                            loRtnList = loCls.GetReportInterfaceAtt(poParam)
                            loList = R_Utility.R_GetChunkData(Of PYR12300ReportAttDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
                        ElseIf .CREPORT_TYPE = "R" Then
                            Dim loRtnList As New List(Of PYR12300ReportReasonDTO)
                            loRtnList = loCls.GetReportInterfaceReason(poParam)
                            loList = R_Utility.R_GetChunkData(Of PYR12300ReportReasonDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
                        End If
                    Case "2"
                        Dim loRtnList As New List(Of PYR12300ReportLoanDTO)
                        loRtnList = loCls.GetReportInterfaceLoan(poParam)
                        loList = R_Utility.R_GetChunkData(Of PYR12300ReportLoanDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
                    Case "3"
                        Dim loRtnList As New List(Of PYR12300ReportMedicalDTO)
                        loRtnList = loCls.GetReportInterfaceMedical(poParam)
                        loList = R_Utility.R_GetChunkData(Of PYR12300ReportMedicalDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
                End Select
            End With


            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportInterface")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
