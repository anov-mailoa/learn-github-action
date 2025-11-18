Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNM05100Back
Imports PNM05100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05100StreamingService" in code, svc and config file together.
Public Class PNM05100StreamingService
    Implements IPNM05100StreamingService

    Public Function getPermissionCategory() As System.ServiceModel.Channels.Message Implements IPNM05100StreamingService.getPermissionCategory
        Dim loCls As New PNM05100DetailCLS
        Dim poParam As New PNM05100DetailDTO
        Dim loRtnTemp As List(Of PNM05100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getPermissionCategory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPermissionCategory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUserList() As System.ServiceModel.Channels.Message Implements IPNM05100StreamingService.getUserList
        Dim loCls As New PNM05100HeaderCLS
        Dim poParam As New PNM05100HeaderDTO
        Dim loRtnTemp As List(Of PNM05100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getUserList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUserList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getData() As System.ServiceModel.Channels.Message Implements IPNM05100StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New PNM05100DetailCLS
        Dim loRtnTemp As List(Of PNM05100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM05100DetailDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM05100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
