Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT09000Back
Imports MCT09000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT09000StreamingService" in code, svc and config file together.
Public Class MCT09000StreamingService
    Implements IMCT09000StreamingService

    Public Function GetGvSubItem() As System.ServiceModel.Channels.Message Implements IMCT09000StreamingService.GetGvSubItem
        Dim loEx As New R_Exception
        Dim loCls As New MCT09000Cls
        Dim loRtnList As List(Of MCT09000SubItemGvNonDto)
        Dim loParam As New MCT09000Dto
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEncryptKey = R_Utility.R_GetStreamingContext("cEncryptKey")
            End With

            loRtnList = loCls.GetGvSubItem(loParam)
            loList = R_Utility.R_GetChunkData(Of MCT09000SubItemGvNonDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvSubItem")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of MCT09000Back.MCT09000SubItemGvDto)) Implements IMCT09000StreamingService.Dummy

    End Sub
End Class
