Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM02000Back
Imports PYM02000Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM02000StreamingService" in code, svc and config file together.
Public Class PYM02000StreamingService
    Implements IPYM02000StreamingService

    Public Function getUserList() As System.ServiceModel.Channels.Message Implements IPYM02000StreamingService.getUserList
        Dim loCls As New PYM02000CLS
        Dim loRtnList As New List(Of PYM02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New PYM02000DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getUserList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUserList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroupList() As System.ServiceModel.Channels.Message Implements IPYM02000StreamingService.getSalaryGroupList
        Dim loCls As New PYM02000CLS
        Dim loRtnList As New List(Of PYM02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New PYM02000DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getSalaryGroupList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroupList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYM02000Back.PYM02000GridDTO)) Implements IPYM02000StreamingService.Dummy

    End Sub

End Class
