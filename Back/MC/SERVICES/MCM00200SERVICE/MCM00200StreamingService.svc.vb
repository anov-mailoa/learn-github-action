Imports System.ServiceModel.Channels
Imports R_Common
Imports MCM00200Back
Imports MCM00200Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00200StreamingService" in code, svc and config file together.
Public Class MCM00200StreamingService
    Implements IMCM00200StreamingService

    Public Function getMcmMedicalItem() As System.ServiceModel.Channels.Message Implements IMCM00200StreamingService.getMcmMedicalItem
        Dim loCls As New MCM00200Cls
        Dim loRtnList As New List(Of MCM00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCM00200GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getMcmMedicalItem(poParam)

            loList = R_Utility.R_GetChunkData(Of MCM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMcmMedicalItem")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMcmMedicalItemPartner() As System.ServiceModel.Channels.Message Implements IMCM00200StreamingService.getMcmMedicalItemPartner
        Dim loCls As New MCM00200MedicalPartnerCls
        Dim loRtnList As New List(Of MCM00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCM00200GridMedicalPartnerDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cItemId = R_Utility.R_GetStreamingContext("cItemId")
            End With

            loRtnList = loCls.getMcmMedicalItemPartner(poParam)

            loList = R_Utility.R_GetChunkData(Of MCM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMcmMedicalItemPartner")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMcmMedicalSubitem() As System.ServiceModel.Channels.Message Implements IMCM00200StreamingService.getMcmMedicalSubitem
        Dim loCls As New MCM00200SubMedicalItemCls
        Dim loRtnList As New List(Of MCM00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCM00200GridSubMedItemDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cItemId = R_Utility.R_GetStreamingContext("cItemId")
            End With

            loRtnList = loCls.getMcmMedicalSubitem(poParam)

            loList = R_Utility.R_GetChunkData(Of MCM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMcmMedicalSubitem")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of MCM00200Back.MCM00200GridDTO)) Implements IMCM00200StreamingService.Dummy

    End Sub
End Class
