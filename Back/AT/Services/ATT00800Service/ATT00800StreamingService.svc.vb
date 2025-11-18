Imports R_Common
Imports R_Common.R_Utility
Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports ATT00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800StreamingService" in code, svc and config file together.
Public Class ATT00800StreamingService
    Implements IATT00800StreamingService

      
    Public Function getData() As System.ServiceModel.Channels.Message Implements IATT00800StreamingService.getData
        Dim loEx As New R_Exception
        Dim loStream As New List(Of ATT00800StreamDTO)
        Dim loRtn As Message = Nothing
       
        Try
            Dim cCompanyId As String = R_GetStreamingContext("cCompanyId")
            Dim cUserId As String = R_GetStreamingContext("cUserId")
            Dim cToday As String = R_GetStreamingContext("cToday")
            Dim cFrom As String = R_GetStreamingContext("cFrom")
            Dim cTo As String = R_GetStreamingContext("cTo")
            Dim cEmployeeId As String = R_GetStreamingContext("cEmployeeId")
            Dim lMultipleEmployee As Boolean = R_GetStreamingContext("lMultipleEmployee")
            Dim cPositionCode As String = R_GetStreamingContext("cPositionCode")
            Dim loCls As New ATT00800Cls
            'loStream = loCls.getData(cCompanyId, cUserId, cToday, cFrom, cTo, cEmployeeId, lMultipleEmployee, cPositionCode)

            If loStream IsNot Nothing Then
                loRtn = R_StreamUtility(Of ATT00800StreamDTO).WriteToMessage(loStream.AsEnumerable(), "ATT00800")
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy() Implements IATT00800StreamingService.Dummy

    End Sub
End Class
