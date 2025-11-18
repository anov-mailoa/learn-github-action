Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNT03400Common
Imports PNT03400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03400StreamingService" in code, svc and config file together.
Public Class PNT03400StreamingService
    Implements IPNT03400StreamingService

    Public Function getTransactionList() As System.ServiceModel.Channels.Message Implements IPNT03400StreamingService.getTransactionList
        Dim loRtnTemp As List(Of PNT03400StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03400Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03400DTO

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getTransactionList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransactionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeList() As System.ServiceModel.Channels.Message Implements IPNT03400StreamingService.getEmployeeList
        Dim loRtnTemp As List(Of PNT03400StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNT03400Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNT03400DTO

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getEmployeeList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
