Imports System.ServiceModel.Channels
Imports PNI03000Back
Imports PNI03000Common
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNI03000StreamingService" in code, svc and config file together.
Public Class PNI03000StreamingService
    Implements IPNI03000StreamingService

    Public Function getOutstanding() As System.ServiceModel.Channels.Message Implements IPNI03000StreamingService.getOutstanding
        Dim loCls As New PNI03000Cls
        Dim poParam As New PNI03000DTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI03000DTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CSTATUS_TYPE = R_Utility.R_GetStreamingContext("CSTATUS_TYPE")
                .CPERIOD = R_Utility.R_GetStreamingContext("CPERIOD")
            End With

            loRtnTemp = loCls.getOutstanding(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI03000DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOutstanding")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
