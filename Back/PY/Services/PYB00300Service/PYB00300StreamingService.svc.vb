Imports R_Common
Imports R_BackEnd
Imports PYB00300Back
Imports System.ServiceModel.Channels
Imports PYB00300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00300StreamingService" in code, svc and config file together.
Public Class PYB00300StreamingService
    Implements IPYB00300StreamingService

    Public Function GetGvSalaryGroupList() As System.ServiceModel.Channels.Message Implements IPYB00300StreamingService.GetGvSalaryGroupList
        Dim loEx As New R_Exception
        Dim loCls As New PYB00300CLS
        Dim loRtnTemp As List(Of PYB00300StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB00300DTO

        Try
            With loParam
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .IEND_PERIOD_METHOD = R_Utility.R_GetStreamingContext("IEND_PERIOD_METHOD")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetGvSalaryGroupList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvSalaryGroupList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
