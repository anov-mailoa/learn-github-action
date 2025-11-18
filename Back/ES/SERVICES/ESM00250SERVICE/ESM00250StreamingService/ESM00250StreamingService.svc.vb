Imports R_Common
Imports ESM00250Back
Imports System.ServiceModel.Channels
Imports ESM00250Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00250StreamingService" in code, svc and config file together.
Public Class ESM00250StreamingService
    Implements IESM00250StreamingService

    Public Function getMenuList() As System.ServiceModel.Channels.Message Implements IESM00250StreamingService.getMenuList
        Dim loException As New R_Exception
        Dim loCls As New ESM00250Cls
        Dim loRtnTemp As List(Of ESM00250GridDTO)
        Dim loRtn As Message
        Dim lcCompId As String
        Dim loList As New List(Of Byte())

        Try
            lcCompId = R_Utility.R_GetStreamingContext("cCompId")

            loRtnTemp = loCls.getMenuList(lcCompId)

            loList = R_Utility.R_GetChunkData(Of ESM00250GridDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMenuList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMenuProgramList() As System.ServiceModel.Channels.Message Implements IESM00250StreamingService.getMenuProgramList
        Dim loException As New R_Exception
        Dim loCls As New ESM00250Cls
        Dim loRtnTemp As List(Of ESM00250MenuProgramDTOnon)
        Dim loRtn As Message
        Dim lcCompId As String
        Dim lcMenuId As String
        Dim loList As New List(Of Byte())

        Try
            lcCompId = R_Utility.R_GetStreamingContext("cCompId")
            lcMenuId = R_Utility.R_GetStreamingContext("cMenuId")

            loRtnTemp = loCls.getMenuProgramList(lcCompId, lcMenuId)

            loList = R_Utility.R_GetChunkData(Of ESM00250MenuProgramDTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMenuProgramList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getProgramList() As System.ServiceModel.Channels.Message Implements IESM00250StreamingService.getProgramList
        Dim loException As New R_Exception
        Dim loCls As New ESM00250Cls
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

    'Public Function getProgramButton() As System.ServiceModel.Channels.Message Implements IESM00250StreamingService.getProgramButton
    '    Dim loException As New R_Exception
    '    Dim loCls As New ESM00250Cls
    '    Dim loRtnTemp As List(Of ButtonDTO)
    '    Dim loRtn As Message
    '    Dim lcProgId As String
    '    Dim lcCompId As String
    '    Dim lcMenuId As String
    '    Dim loList As New List(Of Byte())

    '    Try
    '        lcProgId = R_Utility.R_GetStreamingContext("ProgID")
    '        lcCompId = R_Utility.R_GetStreamingContext("CompID")
    '        lcMenuId = R_Utility.R_GetStreamingContext("MenuID")

    '        loRtnTemp = loCls.getProgramButton(lcProgId, lcCompId, lcMenuId)

    '        loList = R_Utility.R_GetChunkData(Of ButtonDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

    '        loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProgramButton")
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function
End Class
