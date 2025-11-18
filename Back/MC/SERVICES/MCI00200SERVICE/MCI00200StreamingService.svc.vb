Imports System.ServiceModel.Channels
Imports MCI00200Back
Imports R_Common
Imports MCI00200Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCI00200StreamingService" in code, svc and config file together.
Public Class MCI00200StreamingService
    Implements IMCI00200StreamingService
    Public Function GetOutstandingEmployees() As System.ServiceModel.Channels.Message Implements IMCI00200StreamingService.GetOutstandingEmployees
        Dim loCls As New MCI00200Cls
        Dim loRtnList As New List(Of MCI00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCI00200StreamingDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.GetOutstandingEmployees(poParam)

            loList = R_Utility.R_GetChunkData(Of MCI00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetOutstandingEmployees")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetOutstandingTransaction() As System.ServiceModel.Channels.Message Implements IMCI00200StreamingService.GetOutstandingTransaction
        Dim loCls As New MCI00200Cls
        Dim loRtnList As New List(Of MCI00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCI00200StreamingDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.GetOutstandingTransaction(poParam)

            loList = R_Utility.R_GetChunkData(Of MCI00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetOutstandingTransaction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionType() As System.ServiceModel.Channels.Message Implements IMCI00200StreamingService.GetTransactionType
        Dim loCls As New MCI00200Cls
        Dim loRtnList As New List(Of MCI00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCI00200StreamingDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.GetTransactionType(poParam)

            loList = R_Utility.R_GetChunkData(Of MCI00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetTransactionType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
