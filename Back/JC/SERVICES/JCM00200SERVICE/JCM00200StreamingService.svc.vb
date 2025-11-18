Imports R_Common
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports JCM00200BACK
Imports JCM00200COMMON

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCM00200StreamingService" in code, svc and config file together.
Public Class JCM00200StreamingService
    Implements IJCM00200StreamingService

    Public Function GetComboPosition() As System.ServiceModel.Channels.Message Implements IJCM00200StreamingService.GetComboPosition
        Dim loException As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtnTemp As List(Of JCM00200CmbDTO)
        Dim loParam As New JCM00200DTO
        Dim loRtn As Message = Nothing
        Dim loChunk As New List(Of Byte())

        With loParam
            .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
        End With

        Try

            loRtnTemp = loCls.GetComboPosition(loParam)
            loChunk = R_Utility.R_GetChunkData(Of JCM00200CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetComboPosition")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetComboTemplate() As System.ServiceModel.Channels.Message Implements IJCM00200StreamingService.GetComboTemplate
        Dim loException As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtnTemp As List(Of JCM00200CmbDTO)
        Dim loParam As New JCM00200DTO
        Dim loRtn As Message = Nothing
        Dim loChunk As New List(Of Byte())

        With loParam
            .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
        End With

        Try

            loRtnTemp = loCls.GetComboTemplate(loParam)
            loChunk = R_Utility.R_GetChunkData(Of JCM00200CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetComboTemplate")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetListGridHeader() As System.ServiceModel.Channels.Message Implements IJCM00200StreamingService.GetListGridHeader
        Dim loException As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtnTemp As List(Of JCM00200StreamingDTO)
        Dim loParam As New JCM00200DTO
        Dim loRtn As Message = Nothing
        Dim loChunk As New List(Of Byte())

        With loParam
            .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
        End With

        Try

            loRtnTemp = loCls.GetListGridHeader(loParam)
            loChunk = R_Utility.R_GetChunkData(Of JCM00200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetListGridHeader")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetComboTransaction() As System.ServiceModel.Channels.Message Implements IJCM00200StreamingService.GetComboTransaction
        Dim loException As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtnTemp As List(Of JCM00200CmbDTO)
        Dim loParam As New JCM00200DTO
        Dim loRtn As Message = Nothing
        Dim loChunk As New List(Of Byte())

        With loParam
            .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
        End With

        Try

            loRtnTemp = loCls.GetComboTransaction(loParam)
            loChunk = R_Utility.R_GetChunkData(Of JCM00200CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetComboTransaction")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
