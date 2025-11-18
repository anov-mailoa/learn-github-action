Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports ATT00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800ListStreamingService" in code, svc and config file together.
Public Class ATT00800ListStreamingService

    Implements IATT00800ListStreamingService
     
    Public Function getAttCorrectionList() As System.ServiceModel.Channels.Message Implements IATT00800ListStreamingService.getAttCorrectionList
        Dim loException As New R_Exception
        Dim loCls As New ATT00800Cls
        Dim loRtnTemp As New List(Of ATT00800StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00800DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getAttCorrectionList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttCorrectionList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAttCorrectionDetail() As System.ServiceModel.Channels.Message Implements IATT00800ListStreamingService.getAttCorrectionDetail
        Dim loException As New R_Exception
        Dim loCls As New ATT00800Cls
        Dim loRtnTemp As New List(Of ATT00800StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00800DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getAttCorrectionDetail(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttCorrectionDetail")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy() Implements IATT00800ListStreamingService.Dummy

    End Sub
End Class
