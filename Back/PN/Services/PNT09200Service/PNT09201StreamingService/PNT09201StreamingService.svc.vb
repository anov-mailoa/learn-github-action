Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNT09200Back
Imports PNT09200Common

Public Class PNT09201StreamingService
    Implements IPNT09201StreamingService

    Public Function getAppreciationList() As System.ServiceModel.Channels.Message Implements IPNT09201StreamingService.getAppreciationList
        Dim loCls As New PNT09201Cls
        Dim loRtnTemp As List(Of PNT09201StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT09201DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLoginId = R_Utility.R_GetStreamingContext("cLoginId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .dDate = R_Utility.R_GetStreamingContext("dDate")
            End With

            loRtnTemp = loCls.getAppreciationList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT09201StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAppreciationList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
