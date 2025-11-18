Imports System.ServiceModel
Imports R_Common
Imports ATF00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports ATF00200Common
Imports ATT90400Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATF00200StreamingService" in code, svc and config file together.
Public Class ATF00200StreamingService
    Implements IATF00200StreamingService

    Public Function getLeaveBalance() As System.ServiceModel.Channels.Message Implements IATF00200StreamingService.getLeaveBalance
        Dim loRtn As Message
        Dim loCls As New ATF00200Cls
        Dim loEx As New R_Exception
        Dim lcCompId, lcLeaveType, lcLeaveCode, lcEmployeeId, lcYear, lcMonth, lcEntitlementDt As String
        Dim loRtnTemp As New List(Of ATF00200Common.ATF00200CommonStreamingDTO)
        Dim loChunk As New List(Of Byte())
        Try

            lcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            lcLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
            lcLeaveCode = R_Utility.R_GetStreamingContext("cLeaveCode")
            lcEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            lcYear = R_Utility.R_GetStreamingContext("cYear")
            lcMonth = R_Utility.R_GetStreamingContext("cMonth")
            lcEntitlementDt = R_Utility.R_GetStreamingContext("cEntitlementDate")

            loRtnTemp = loCls.getLeaveBalance(lcCompId, lcLeaveType, lcLeaveCode, lcEmployeeId, lcYear, lcMonth, lcEntitlementDt)

            loChunk = R_Utility.R_GetChunkData(Of ATF00200CommonStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLeaveBalance")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
