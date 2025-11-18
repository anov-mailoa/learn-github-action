' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02800StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02800StreamingService.svc or SAM02800StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Channels
Imports R_Common
Imports SAM02800Back
Imports SAM02800Common
Imports TelerikMenuService

Public Class SAM02800StreamingService
    Implements ISAM02800StreamingService

    Public Function GetDashboardList() As Message Implements ISAM02800StreamingService.GetDashboardList
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800Cls
        Dim loRtnTemp As List(Of SAM02800DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.GetDashboardList()

            loList = R_Utility.R_GetChunkData(Of SAM02800DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDashboardList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetUserDashboardList() As Message Implements ISAM02800StreamingService.GetUserDashboardList
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800UserDashboardCls
        Dim loRtnTemp As List(Of DashboardUserDTO)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            Dim lcCompId As String = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            Dim lcUserId As String = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtnTemp = loCls.GetUserDashboardList(lcCompId, lcUserId)

            loList = R_Utility.R_GetChunkData(Of DashboardUserDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetUserDashboardList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDashboardAssignment() As Message Implements ISAM02800StreamingService.GetDashboardAssignment
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800UserDashboardCls
        Dim loRtnTemp As List(Of DashboardAssignmentDTO)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            Dim lcCompId As String = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            Dim lcUserId As String = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtnTemp = loCls.GetDashboardAssignment(lcUserId, lcCompId)

            loList = R_Utility.R_GetChunkData(Of DashboardAssignmentDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDashboardAssignment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetUserList() As Message Implements ISAM02800StreamingService.GetUserList
        Dim loEx As New R_Exception
        Dim loCls As New SAM02800UserDashboardCls
        Dim loRtnTemp As List(Of UserDTO)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            Dim lcCompId As String = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnTemp = loCls.GetUserList(lcCompId)

            loList = R_Utility.R_GetChunkData(Of UserDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetUserList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
