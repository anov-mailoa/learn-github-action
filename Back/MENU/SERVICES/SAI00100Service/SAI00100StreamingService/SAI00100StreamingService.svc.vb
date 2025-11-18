Imports R_Common
Imports SAI00100Back
Imports System.ServiceModel.Channels
Imports SAI00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01700StreamingService" in code, svc and config file together.
Public Class SAI00100StreamingService
    Implements ISAI00100StreamingService

    Public Function GetHistory() As System.ServiceModel.Channels.Message Implements ISAI00100StreamingService.GetHistory
        Dim loException As New R_Exception
        Dim loCls As New SAI00100Cls
        Dim loRtnTemp As List(Of SAI00100DTO)
        Dim loRtn As Message
        Dim loList As New List(Of Byte())

        Try
            Dim lcCompId As String = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            Dim lcProgId As String = R_Utility.R_GetStreamingContext("CPROGRAM_ID")
            Dim lcUserId As String = R_Utility.R_GetStreamingContext("CUSER_ID")
            Dim lcAction As String = R_Utility.R_GetStreamingContext("CACTION")

            loRtnTemp = loCls.GetHistory(lcCompId, lcProgId, lcUserId, lcAction)

            loList = R_Utility.R_GetChunkData(Of SAI00100DTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetHistory")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbProgram() As System.ServiceModel.Channels.Message Implements ISAI00100StreamingService.GetCmbProgram
        Dim loException As New R_Exception
        Dim loCls As New SAI00100Cls
        Dim loRtnTemp As List(Of CmbDTO)
        Dim loRtn As Message


        Try
            loRtnTemp = loCls.GetCmbProgram()

            loRtn = R_StreamUtility(Of CmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "GetCmbProgram")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbUser() As System.ServiceModel.Channels.Message Implements ISAI00100StreamingService.GetCmbUser
        Dim loException As New R_Exception
        Dim loCls As New SAI00100Cls
        Dim loRtnTemp As List(Of CmbDTO)
        Dim loRtn As Message


        Try
            loRtnTemp = loCls.GetCmbUser()

            loRtn = R_StreamUtility(Of CmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "GetCmbUser")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of SAI00100Back.CmbDTO)) Implements ISAI00100StreamingService.Dummy

    End Sub
End Class
