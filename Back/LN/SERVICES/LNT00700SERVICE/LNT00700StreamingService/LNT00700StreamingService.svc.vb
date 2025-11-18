Imports R_Common
Imports R_BackEnd
Imports LNT00700Back
Imports System.ServiceModel.Channels
Imports LNT00700Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00700StreamingService" in code, svc and config file together.
Public Class LNT00700StreamingService
    Implements ILNT00700StreamingService

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements ILNT00700StreamingService.getTransaction
        Dim loRtn As New List(Of LNT00700Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00700Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00700Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmpID")
            poParam.cKey = R_Utility.R_GetStreamingContext("cKeyID")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loRtn = loCls.getTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00700Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00700Back.LNT00700Dto_R), poSchedule As LNT00700Back.LNT00700ScheduleDto, poScheduleList As System.Collections.Generic.List(Of LNT00700Back.LNT00700ScheduleDto_S), poCmb As System.Collections.Generic.List(Of LNT00700Back.LNT00700PaymentTypeDto)) Implements ILNT00700StreamingService.Dummy

    End Sub
End Class
