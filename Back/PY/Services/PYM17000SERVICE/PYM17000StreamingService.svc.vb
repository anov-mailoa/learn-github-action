' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM17000StreamingService" in code, svc and config file together.
Imports R_Common
Imports PYM17000Back
Imports System.ServiceModel.Channels
Imports PYM17000Common
Imports R_BackEnd

Public Class PYM17000StreamingService
    Implements IPYM17000StreamingService

    Public Function getEmpDetail() As System.ServiceModel.Channels.Message Implements IPYM17000StreamingService.getEmpDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYM17000Cls
        Dim loRtnTemp As List(Of PYM17000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM17000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getEmpDetail(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM17000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmpList() As System.ServiceModel.Channels.Message Implements IPYM17000StreamingService.getEmpList
        Dim loEx As New R_Exception
        Dim loCls As New PYM17000Cls
        Dim loRtnTemp As List(Of PYM17000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM17000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
            End With

            loRtnTemp = loCls.getEmpList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM17000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYM17000StreamingService.getSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYM17000Cls
        Dim loRtnTemp As List(Of PYM17000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM17000DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getSalaryGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM17000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub UpdateMaster(poParam As PYM17000Back.PYM17000DTO) Implements IPYM17000StreamingService.UpdateMaster
        Dim loEx As New R_Exception
        Dim loCls As New PYM17000Cls

        Try

            loCls.UpdateMaster(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub
End Class
