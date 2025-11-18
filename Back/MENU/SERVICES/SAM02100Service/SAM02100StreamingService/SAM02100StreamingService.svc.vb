Imports R_Common
Imports SAM02100Back
Imports System.ServiceModel.Channels
Imports SAM02100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02100StreamingService" in code, svc and config file together.
Public Class SAM02100StreamingService
    Implements ISAM02100StreamingService

    Public Function getTemplateList() As System.ServiceModel.Channels.Message Implements ISAM02100StreamingService.getTemplateList
        Dim loException As New R_Exception
        Dim loCls As New SAM02100Cls
        Dim loRtnTemp As List(Of SAM02100DTOnon)
        Dim loRtn As Message
        Dim lcCompId As String
        Dim loList As New List(Of Byte())

        Try
            lcCompId = R_Utility.R_GetStreamingContext("cCompId")

            loRtnTemp = loCls.getTemplateList(lcCompId)

            loList = R_Utility.R_GetChunkData(Of SAM02100DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getViewTemplate() As System.ServiceModel.Channels.Message Implements ISAM02100StreamingService.getViewTemplate
        Dim loException As New R_Exception
        Dim loCls As New SAM02100Cls
        Dim loRtnTemp As List(Of ViewDTO)
        Dim loRtn As Message
        Dim lcCompId As String
        Dim lcTemplateId As String
        Dim loList As New List(Of Byte())

        Try
            lcCompId = R_Utility.R_GetStreamingContext("cCompId")
            lcTemplateId = R_Utility.R_GetStreamingContext("cTemplateId")

            loRtnTemp = loCls.getViewTemplate(lcCompId, lcTemplateId)

            loList = R_Utility.R_GetChunkData(Of ViewDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getViewTemplate")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
