Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports LNB00100Back
Imports LNB00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNB00100StreamingService" in code, svc and config file together.
Public Class LNB00100StreamingService
    Implements ILNB00100StreamingService

    Public Function getDataDetail() As System.ServiceModel.Channels.Message Implements ILNB00100StreamingService.getDataDetail
        Dim loEx As New R_Exception
        Dim loCls As New LNB00100Cls
        Dim poParam As New LNB00100Dto
        Dim loRtnList As New List(Of GridDetailDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEncryptKey = R_Utility.R_GetStreamingContext("cEncryptKey")
            End With

            loRtnList = loCls.getDataDetail(poParam)
            loList = R_Utility.R_GetChunkData(Of GridDetailDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of LNB00100Back.LNB00100Dto)) Implements ILNB00100StreamingService.Dummy

    End Sub

    Public Function checkFestivalInterfaceStatus(poParam As LNB00100Back.LNB00100Dto) As String Implements ILNB00100StreamingService.checkFestivalInterfaceStatus
        Dim loEx As New R_Exception
        Dim loCls As New LNB00100Cls
        Dim lcRtn As String

        Try
            lcRtn = loCls.checkFestivalInterfaceStatus(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function
End Class
