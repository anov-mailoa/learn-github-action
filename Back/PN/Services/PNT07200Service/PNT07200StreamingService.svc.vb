Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNT07200Back
Imports PNT07200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07200StreamingService" in code, svc and config file together.
Public Class PNT07200StreamingService
    Implements IPNT07200StreamingService

    Public Function getPnmGradeDt() As System.ServiceModel.Channels.Message Implements IPNT07200StreamingService.getPnmGradeDt
        Dim loCls As New PNT07200CLS
        Dim poParam As New PNT07200DTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNT07200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
            End With

            loRtnTemp = loCls.getPnmGradeDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT07200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmGradeDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
