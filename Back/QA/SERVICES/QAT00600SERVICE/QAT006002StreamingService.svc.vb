Imports R_BackEnd
Imports R_Common
Imports QAT00600Back
Imports QAT00600Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT006002StreamingService" in code, svc and config file together.
Public Class QAT006002StreamingService
    Implements IQAT006002StreamingService

    Public Function getDocLvl1List() As System.ServiceModel.Channels.Message Implements IQAT006002StreamingService.getDocLvl1List
        Dim loException As New R_Exception
        Dim loCls As New QAT006002Cls
        Dim loRtnTemp As List(Of QAT006002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT006002DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cForeignLanguage = R_Utility.R_GetStreamingContext("cForeignLanguage")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cQaDept = R_Utility.R_GetStreamingContext("cQaDept")
                .cTransactionCOde = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getDocLvl1List(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT006002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocLvl1List")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocLvl2List() As System.ServiceModel.Channels.Message Implements IQAT006002StreamingService.getDocLvl2List
        Dim loException As New R_Exception
        Dim loCls As New QAT006002Cls
        Dim loRtnTemp As List(Of QAT006002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT006002DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cForeignLanguage = R_Utility.R_GetStreamingContext("cForeignLanguage")
                .cParentDocNo = R_Utility.R_GetStreamingContext("cParentDocNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getDocLvl2List(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT006002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocLvl2List")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocumentList() As System.ServiceModel.Channels.Message Implements IQAT006002StreamingService.getDocumentList
        Dim loException As New R_Exception
        Dim loCls As New QAT006002Cls
        Dim loRtnTemp As List(Of QAT006002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT006002DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cForeignLanguage = R_Utility.R_GetStreamingContext("cForeignLanguage")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getDocumentList(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT006002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocumentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
