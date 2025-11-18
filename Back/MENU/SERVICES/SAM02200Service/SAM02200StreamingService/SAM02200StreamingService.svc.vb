Imports R_Common
Imports SAM02200Back
Imports System.ServiceModel.Channels
Imports SAM02200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02200StreamingService" in code, svc and config file together.
Public Class SAM02200StreamingService
    Implements ISAM02200StreamingService

    Public Function getProgramList() As System.ServiceModel.Channels.Message Implements ISAM02200StreamingService.getProgramList
        Dim loException As New R_Exception
        Dim loCls As New SAM02200Cls
        Dim loRtnTemp As List(Of ProgramDTO)
        Dim loRtn As Message
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.getProgramList()

            loList = R_Utility.R_GetChunkData(Of ProgramDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProgramList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRecordDocument() As System.ServiceModel.Channels.Message Implements ISAM02200StreamingService.getRecordDocument
        Dim loException As New R_Exception
        Dim loCls As New SAM02200Cls
        Dim loRtnTemp As SAM02200DTOnon
        Dim loRtnTempList As New List(Of SAM02200DTOnon)
        Dim loRtn As Message
        Dim loParam As New SAM02200DTO
        Dim loList As New List(Of Byte())

        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loParam.CPROGRAM_ID = R_Utility.R_GetStreamingContext("CPROGRAM_ID")
            loParam.CTEMPLATE_ID = R_Utility.R_GetStreamingContext("CTEMPLATE_ID")

            loRtnTemp = loCls.getRecordDocument(loParam)

            loRtnTempList.Add(loRtnTemp)

            loList = R_Utility.R_GetChunkData(Of SAM02200DTOnon)(loRtnTempList, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRecordDocument")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateList() As System.ServiceModel.Channels.Message Implements ISAM02200StreamingService.getTemplateList
        Dim loException As New R_Exception
        Dim loCls As New SAM02200Cls
        Dim loRtnTemp As List(Of SAM02200DTOnon)
        Dim loRtn As Message
        Dim lcCompID As String
        Dim loList As New List(Of Byte())

        Try
            lcCompID = R_Utility.R_GetStreamingContext("CCOMPID")

            loRtnTemp = loCls.getTemplateList(lcCompID)

            loList = R_Utility.R_GetChunkData(Of SAM02200DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
