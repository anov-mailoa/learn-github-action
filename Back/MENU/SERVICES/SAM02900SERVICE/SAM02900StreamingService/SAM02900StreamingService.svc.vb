' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02900StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02900StreamingService.svc or SAM02900StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Channels
Imports R_Common
Imports SAM02900Back
Imports SAM02900Common
Imports TelerikMenuService

Public Class SAM02900StreamingService
    Implements ISAM02900StreamingService

    Public Function GetNonMFAUsers() As Message Implements ISAM02900StreamingService.GetNonMFAUsers
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtnTemp As List(Of NonMFAUserDTO)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            Dim lcCompId As String = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            Dim liSecurityMode As Integer = R_Utility.R_GetStreamingContext("ISECURITY_MODE")

            loRtnTemp = loCls.GetNonMFAUsers(lcCompId, liSecurityMode)

            loList = R_Utility.R_GetChunkData(Of NonMFAUserDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetNonMFAUsers")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetUserList() As Message Implements ISAM02900StreamingService.GetUserList
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtnTemp As List(Of UserDTO)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            Dim lcCompId As String = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            Dim liSecurityMode As Integer = R_Utility.R_GetStreamingContext("ISECURITY_MODE")

            loRtnTemp = loCls.GetUserList(lcCompId, liSecurityMode)

            loList = R_Utility.R_GetChunkData(Of UserDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetUserList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
