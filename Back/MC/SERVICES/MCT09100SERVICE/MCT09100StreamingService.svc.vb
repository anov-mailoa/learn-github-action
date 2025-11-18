Imports R_Common
Imports System.ServiceModel.Channels
Imports MCT09100Back
Imports R_BackEnd
Imports MCT09100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT09100StreamingService" in code, svc and config file together.
Public Class MCT09100StreamingService
    Implements IMCT09100StreamingService


    Public Function getListGrid() As System.ServiceModel.Channels.Message Implements IMCT09100StreamingService.getListGrid
        Dim loCls As New MCT09100Cls
        Dim poParam As New MCT09101Dto
        Dim loRtnList As New List(Of MCT09100StreamingDto)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEncrypKey = R_Utility.R_GetStreamingContext("cEncrypKey")
                .cDateNow = R_Utility.R_GetStreamingContext("cDateNow")
            End With

            loRtnList = loCls.getListGrid(poParam)

            ' If there is data, convert to Message
            If loRtnList IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of MCT09100StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListGrid")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
