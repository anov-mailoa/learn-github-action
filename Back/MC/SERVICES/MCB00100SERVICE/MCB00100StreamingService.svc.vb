Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports MCB00100Back
Imports MCB00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCB00100StreamingService" in code, svc and config file together.
Public Class MCB00100StreamingService
    Implements IMCB00100StreamingService

    Public Function getDimensionList() As System.ServiceModel.Channels.Message Implements IMCB00100StreamingService.getDimensionList
        Dim loException As New R_Exception
        Dim loCls As New MCB00100Cls
        Dim loRtnTemp As New List(Of MCB00100TransferDTO)
        Dim loRtn As Message
        Dim loParam As New MCB00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cLanguangeId = R_Utility.R_GetStreamingContext("cLanguangeId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnTemp = loCls.getDimensionList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB00100TransferDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDimensionList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeList() As System.ServiceModel.Channels.Message Implements IMCB00100StreamingService.getEmployeeList
        Dim loException As New R_Exception
        Dim loCls As New MCB00100Cls
        Dim loRtnTemp As New List(Of MCB00100TransferDTO)
        Dim loRtn As Message
        Dim loParam As New MCB00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguangeId = R_Utility.R_GetStreamingContext("cLanguangeId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnTemp = loCls.getEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of MCB00100TransferDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
