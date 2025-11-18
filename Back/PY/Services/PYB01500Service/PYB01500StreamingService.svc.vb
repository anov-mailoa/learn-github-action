Imports System.ServiceModel
Imports R_Common
Imports PYB01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYB01500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB01500StreamingService" in code, svc and config file together.
Public Class PYB01500StreamingService
    Implements IPYB01500StreamingService

    Public Function getKPPList() As System.ServiceModel.Channels.Message Implements IPYB01500StreamingService.getKPPList
        Dim loEx As New R_Exception
        Dim loCls As New PYB01500Cls
        Dim loRtn As New List(Of PYB01500StreamingDto)
        Dim loRtnMessage As Message
        Dim poParam As New PYB01500Dto

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtn = loCls.getKPPList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01500StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getKPPList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getAllGroupCode(pcCompanyId As String) As String Implements IPYB01500StreamingService.getAllGroupCode
        Dim loEx As New R_Exception
        Dim loCls As New PYB01500Cls
        Dim lcRtn As String

        Try
            lcRtn = loCls.getAllGroupCode(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function

    Public Sub Dummy(poDetail As System.Collections.Generic.List(Of PYB01500Back.PYB01500Dto), poDetail1 As System.Collections.Generic.List(Of PYB01500Back.PYB01500GridDto)) Implements IPYB01500StreamingService.Dummy

    End Sub

    Public Function CheckFinalizeKpp(loParam As PYB01500Back.PYB01500Dto) As Boolean Implements IPYB01500StreamingService.CheckFinalizeKpp
        Dim loEx As New R_Exception
        Dim loCls As New PYB01500Cls
        Dim llRtn As Boolean
        Try
            llRtn = loCls.CheckFinalizeKpp(loParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llRtn
    End Function
End Class
