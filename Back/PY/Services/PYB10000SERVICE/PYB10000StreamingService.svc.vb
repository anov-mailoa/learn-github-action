Imports R_Common
Imports R_BackEnd
Imports PYB10000Back
Imports System.ServiceModel.Channels
Imports PYB10000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB10000StreamingService" in code, svc and config file together.
Public Class PYB10000StreamingService
    Implements IPYB10000StreamingService

    Public Function getEmployees() As System.ServiceModel.Channels.Message Implements IPYB10000StreamingService.getEmployees
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS
        Dim loRtnTemp As List(Of PYB10000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB10000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CPROCESS_PERIOD = R_Utility.R_GetStreamingContext("CPROCESS_PERIOD")
                .LREGISTERED_EMP = R_Utility.R_GetStreamingContext("LREGISTERED_EMP")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.getEmployees(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployees")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYB10000StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS
        Dim loRtnTemp As List(Of PYB10000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB10000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.getGrupGaji(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getProcessCode() As System.ServiceModel.Channels.Message Implements IPYB10000StreamingService.getProcessCode
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS
        Dim loRtnTemp As List(Of PYB10000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB10000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
            End With

            loRtnTemp = loCls.getProcessCode(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcessCode")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYB10000StreamingService.getCmbPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS
        Dim loRtnTemp As List(Of PYB10000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB10000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
            End With

            loRtnTemp = loCls.getCmbPeriod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmailProcessList() As System.ServiceModel.Channels.Message Implements IPYB10000StreamingService.getEmailProcessList
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS
        Dim loRtnTemp As List(Of PYB10000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB10000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CPROCESS_PERIOD = R_Utility.R_GetStreamingContext("CPROCESS_PERIOD")
                .ITOTAL_EMPLOYEE = R_Utility.R_GetStreamingContext("ITOTAL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LINSERT = R_Utility.R_GetStreamingContext("LINSERT")
                .CFLAG = R_Utility.R_GetStreamingContext("CFLAG")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
            End With

            loRtnTemp = loCls.getEmailProcessList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmailProcessList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub sendEmail(pcEmailId As String) Implements IPYB10000StreamingService.sendEmail
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS

        Try
            loCls.sendEmail(pcEmailId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getCmbYear() As System.ServiceModel.Channels.Message Implements IPYB10000StreamingService.getCmbYear
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS
        Dim loRtnTemp As List(Of PYB10000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB10000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
            End With

            loRtnTemp = loCls.getCmbYear(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbYear")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub insertEmailProcess(poParam As PYB10000Back.PYB10000DTO) Implements IPYB10000StreamingService.insertEmailProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS

        Try
            loCls.insertEmailProcess(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub savePublishESS(poParam As System.Collections.Generic.List(Of PYB10000Back.PYB10000PublishDTO)) Implements IPYB10000StreamingService.savePublishESS
        Dim loEx As New R_Exception
        Dim loCls As New PYB10000CLS

        Try
            loCls.savePublishESS(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
