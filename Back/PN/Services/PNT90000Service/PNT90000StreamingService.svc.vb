Imports PNT90000Back
Imports PNT90000Common
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT90000StreamingService" in code, svc and config file together.
Public Class PNT90000StreamingService
    Implements IPNT90000StreamingService

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements IPNT90000StreamingService.getTransaction
        Dim loRtnTemp As List(Of PNT90000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT90000Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNT90000DTO


        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
            poParam.CSTART_FROM = R_Utility.R_GetStreamingContext("CSTART_FROM")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            poParam.CTO_DATE = R_Utility.R_GetStreamingContext("DTO_DATE")

            loRtnTemp = loCls.getTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT90000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransaction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
