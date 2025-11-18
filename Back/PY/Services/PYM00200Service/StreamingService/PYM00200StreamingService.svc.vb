Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM00200Back
Imports PYM00200Common

Public Class PYM00200StreamingService
    Implements IPYM00200StreamingService

    Public Function GetPYM00200List() As System.ServiceModel.Channels.Message Implements IPYM00200StreamingService.GetPYM00200List
        Dim loEx As New R_Exception
        Dim loParam As New PYM00200GridDto
        Dim loCls As New PYM00200Cls
        Dim loRtn As New List(Of PYM00200StreamingDto)
        Dim loRtnMsg As Message

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetPYM00200List(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00200StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetPYM00200List")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function GetPYM00210List() As System.ServiceModel.Channels.Message Implements IPYM00200StreamingService.GetPYM00210List
        Dim loEx As New R_Exception
        Dim loParam As New PYM00210GridDto
        Dim loCls As New PYM00200Cls
        Dim loRtn As New List(Of PYM00210StreamingDto)
        Dim loRtnMsg As Message

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCbCode = R_Utility.R_GetStreamingContext("cCbCode")
                .cAccountNo = R_Utility.R_GetStreamingContext("cAccountNo")
            End With

            loRtn = loCls.GetPYM00210List(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00210StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetPYM00210List")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function
End Class
