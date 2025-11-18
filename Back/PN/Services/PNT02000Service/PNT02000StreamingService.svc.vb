Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNT02000Common
Imports PNT02000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT02000StreamingService" in code, svc and config file together.
Public Class PNT02000StreamingService
    Implements IPNT02000StreamingService

    Public Function getCmbSubGrade() As System.ServiceModel.Channels.Message Implements IPNT02000StreamingService.getCmbSubGrade
        Dim loCls As New PNT02000Cls
        Dim loRtnTemp As List(Of PNT02000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT02000DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
            End With

            loRtnTemp = loCls.getCmbSubGrade(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmGradeDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
