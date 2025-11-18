Imports R_BackEnd
Imports R_Common
Imports PND00100Back
Imports PND00100Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02000StreamingService" in code, svc and config file together.
Public Class PND00100StreamingService
    Implements IPND00100StreamingService


    Public Sub Dummy(poDummy As System.Collections.Generic.List(Of PND00100Back.PND00100ParamDTO)) Implements IPND00100StreamingService.Dummy

    End Sub

    Public Function getRSP_PN_DASHBOARD_INFO() As System.ServiceModel.Channels.Message Implements IPND00100StreamingService.getRSP_PN_DASHBOARD_INFO
        Dim loException As New R_Exception
        Dim loCls As New PND00100Cls
        Dim poParam As New PND00100ParamDTO
        Dim loRtnList As New List(Of PND00100MultiResultDTO)
        Dim loRtnTemp As List(Of PND00100MultiResultDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getRSP_PN_DASHBOARD_INFO(poParam)

            loList = R_Utility.R_GetChunkData(Of PND00100MultiResultDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRSP_PN_DASHBOARD_INFO")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class
