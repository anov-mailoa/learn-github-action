Imports R_Common
Imports PYB00600Back
Imports System.ServiceModel.Channels
Imports PYB00600Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00200StreamingService" in code, svc and config file together.
Public Class PYB00600StreamingService
    Implements IPYB00600StreamingService

    Public Function GetListSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYB00600StreamingService.GetListSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYB00600Cls
        Dim loRtnTemp As List(Of PYB00600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB00600DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CPAYMENT_TYPE = R_Utility.R_GetStreamingContext("CPAYMENT_TYPE")
            End With

            loRtnTemp = loCls.GetListSalaryGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetProcess() As System.ServiceModel.Channels.Message Implements IPYB00600StreamingService.GetProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYB00600Cls
        Dim loRtnTemp As List(Of PYB00600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB00600DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CPERIOD_INDEX = R_Utility.R_GetStreamingContext("CPERIOD_INDEX")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
                .EMPLOYEE = R_Utility.R_GetStreamingContext("EMPLOYEE")
            End With

            loRtnTemp = loCls.GetProcess(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PYB00600Back.PYB00600DTO)) Implements IPYB00600StreamingService.Dummy

    End Sub
End Class
