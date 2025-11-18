Imports R_Common
Imports System.ServiceModel.Channels
Imports PNM14350Back
Imports PNM14350Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14350StreamingService" in code, svc and config file together.
Public Class PNM14350StreamingService
    Implements IPNM14350StreamingService


    Public Function getAnggotaKK() As System.ServiceModel.Channels.Message Implements IPNM14350StreamingService.getAnggotaKK
        Dim loCls As New PNM14350Cls
        Dim poParam As New PNM14350DTO
        Dim loRtnList As New List(Of PNM14350StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getAnggotaKK(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PNM14350StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAnggotaKK")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
