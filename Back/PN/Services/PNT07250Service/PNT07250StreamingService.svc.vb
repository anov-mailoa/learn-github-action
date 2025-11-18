Imports System.ServiceModel.Channels
Imports PNT07250Back
Imports PNT07250Common
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07250StreamingService" in code, svc and config file together.
Public Class PNT07250StreamingService
    Implements IPNT07250StreamingService

    Public Function getPnmGradeDt() As System.ServiceModel.Channels.Message Implements IPNT07250StreamingService.getPnmGradeDt
        Dim loCls As New PNT07250CLS
        Dim loRtnTemp As List(Of PNT07250StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT07250DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
            End With

            loRtnTemp = loCls.getPnmGradeDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT07250StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmGradeDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
