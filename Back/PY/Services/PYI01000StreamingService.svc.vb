Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYI01000Back
Imports PYI01000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYI01000StreamingService" in code, svc and config file together.
Public Class PYI01000StreamingService
    Implements IPYI01000StreamingService

    Public Function GetCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYI01000StreamingService.GetCmbPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYI01000CLS
        Dim poParam As New PYI01000DTO
        Dim loRtnTemp As List(Of PYI01000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.GetCmbPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI01000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbPeriod")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPYI01000StreamingService.GetEmployeeList
        Dim loException As New R_Exception
        Dim loCls As New PYI01000CLS
        Dim poParam As New PYI01000DTO
        Dim loRtnTemp As List(Of PYI01000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CSTART_PERIOD = R_Utility.R_GetStreamingContext("CSTART_PERIOD")
                .CEND_PERIOD = R_Utility.R_GetStreamingContext("CEND_PERIOD")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.GetEmployeeList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI01000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYI01000StreamingService.GetCmbSalaryGroup
        Dim loException As New R_Exception
        Dim loCls As New PYI01000CLS
        Dim poParam As New PYI01000DTO
        Dim loRtnTemp As List(Of PYI01000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.GetCmbSalaryGroup(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI01000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbSalaryGroup")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PYI01000Back.PYI01000DTO)) Implements IPYI01000StreamingService.Dummy

    End Sub

End Class
