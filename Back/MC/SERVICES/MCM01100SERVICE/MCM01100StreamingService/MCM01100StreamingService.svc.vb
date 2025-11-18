Imports R_Common
Imports R_BackEnd
Imports MCM01100Back
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports MCM01100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM01100StreamingService" in code, svc and config file together.
Public Class MCM01100StreamingService
    Implements IMCM01100StreamingService

    Public Function MedicalRole() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.MedicalRole
        Dim loRtn As New List(Of MCM01100RoleListStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01100Dto
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            loRtn = loCls.MedicalRole(poParam.cCompanyId, poParam.cYear)
            loList = R_Utility.R_GetChunkData(Of MCM01100RoleListStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function MedicalItemList() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.MedicalItemList
        Dim loRtn As New List(Of MCM01101GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01101Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01101Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")

            loRtn = loCls.MedicalItemList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01101GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "MedicalItemList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function MedicaSublItemList() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.MedicaSublItemList
        Dim loRtn As New List(Of MCM01102GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01102Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01102Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            poParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")

            loRtn = loCls.MedicaSublItemList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01102GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "MedicaSublItemList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function ComboSubMedicalItem() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.ComboSubMedicalItem

        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01102Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01102Dto

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")

            loRtn = loCls.ComboSubMedicalItem(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "ComboSubMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage

    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of MCM01100Back.MCM01100RoleListDto), poPar2 As System.Collections.Generic.List(Of MCM01100Back.MCM01101GvDto), poPar4 As System.Collections.Generic.List(Of MCM01100Back.MCM01102GvDto)) Implements IMCM01100StreamingService.Dummy

    End Sub

    Public Function GetLogMedicalItemList() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.GetLogMedicalItemList
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Dim poParam As New MCM01101Dto
        Dim loRtn As New List(Of MCM01101GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01101Cls

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            poParam.dLogDatetime = R_Utility.R_GetStreamingContext("dLogDatetime")

            loRtn = loCls.GetLogMedicalItemList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01101GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLogMedicalItemList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetLogMedicalRuleList() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.GetLogMedicalRuleList
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Dim poParam As New MCM01100Dto
        Dim loRtn As New List(Of MCM01100RoleListStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01100Cls

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.dLogDatetime = R_Utility.R_GetStreamingContext("dLogDatetime")

            loRtn = loCls.GetLogMedicalRuleList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01100RoleListStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLogMedicalRuleList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetLogMedicalSubItemList() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.GetLogMedicalSubItemList
        Dim loRtn As New List(Of MCM01102GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01102Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01102Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            poParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")
            poParam.dLogDatetime = R_Utility.R_GetStreamingContext("dLogDatetime")

            loRtn = loCls.GetLogMedicalSubItemList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01102GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLogMedicalSubItemList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetDlogMedicalRule() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.GetDlogMedicalRule
        Dim loRtn As New List(Of MCM01101GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01100Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetDlogMedicalRule(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01101GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDlogMedicalRule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetDlogMedicalItem() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.GetDlogMedicalItem
        Dim loRtn As New List(Of MCM01101GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01100Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")

            loRtn = loCls.GetDlogMedicalItem(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01101GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDlogMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetDlogMedicalSubItem() As System.ServiceModel.Channels.Message Implements IMCM01100StreamingService.GetDlogMedicalSubItem
        Dim loRtn As New List(Of MCM01101GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCM01100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCM01100Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            poParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")

            loRtn = loCls.GetDlogMedicalSubItem(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM01101GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDlogMedicalSubItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class
