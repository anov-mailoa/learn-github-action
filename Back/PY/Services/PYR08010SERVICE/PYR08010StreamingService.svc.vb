Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR08010Back
Imports PYR08010Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR08010StreamingService" in code, svc and config file together.
Public Class PYR08010StreamingService
    Implements IPYR08010StreamingService


    Public Function getList() As System.ServiceModel.Channels.Message Implements IPYR08010StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New PYR08010Cls
        Dim loRtnList As New List(Of PYR08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR08010DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cFlag = R_Utility.R_GetStreamingContext("cFlag")
            End With

            loRtnList = loCls.getList(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getInterfaceData() As System.ServiceModel.Channels.Message Implements IPYR08010StreamingService.getInterfaceData
        Dim loEx As New R_Exception
        Dim loCls As New PYR08010Cls
        Dim loRtnList As New List(Of PYR08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim loParam As New PYR08010DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cProcessDate = R_Utility.R_GetStreamingContext("cProcessDate")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getInterfaceData(loParam)
            loList = R_Utility.R_GetChunkData(Of PYR08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getInterfaceData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateDetail(poParam As PYR08010Back.PYR08010DTO) As PYR08010Back.PYR08010DTO Implements IPYR08010StreamingService.getTemplateDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYR08010Cls
        Dim loRtnTemp As New PYR08010DTO

        Try
            loRtnTemp = loCls.getTemplateDetail(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnTemp
    End Function

End Class
