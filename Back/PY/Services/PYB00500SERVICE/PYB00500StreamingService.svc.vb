Imports System.ServiceModel
Imports R_Common
Imports PYB00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYB00500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00500StreamingService" in code, svc and config file together.
Public Class PYB00500StreamingService
    Implements IPYB00500StreamingService

    Public Function getCmbYear() As System.ServiceModel.Channels.Message Implements IPYB00500StreamingService.getCmbYear
        Dim loEx As New R_Exception
        Dim loCls As New PYB00500Cls
        Dim loRtn As New List(Of PYB00500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYB00500DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtn = loCls.getCmbYear(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbYear")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getEmpList() As System.ServiceModel.Channels.Message Implements IPYB00500StreamingService.getEmpList
        Dim loEx As New R_Exception
        Dim loCls As New PYB00500Cls
        Dim loRtn As New List(Of PYB00500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYB00500DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtn = loCls.getEmpList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


End Class
