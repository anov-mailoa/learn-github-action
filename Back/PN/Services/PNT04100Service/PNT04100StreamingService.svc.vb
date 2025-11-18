Imports System.ServiceModel.Channels
Imports PNT04100Back
Imports PNT04100Common
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT04100StreamingService" in code, svc and config file together.
Public Class PNT04100StreamingService
    Implements IPNT04100StreamingService

    Public Function getPnmGradeDt() As System.ServiceModel.Channels.Message Implements IPNT04100StreamingService.getPnmGradeDt
        Dim loCls As New PNT04100Cls
        Dim loRtnTemp As List(Of PNT04100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT04100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
            End With

            loRtnTemp = loCls.getPnmGradeDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT04100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmGradeDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
