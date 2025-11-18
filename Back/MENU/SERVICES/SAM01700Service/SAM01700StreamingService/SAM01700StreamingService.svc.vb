Imports R_Common
Imports SAM01700Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01700StreamingService" in code, svc and config file together.
Public Class SAM01700StreamingService
    Implements ISAM01700StreamingService

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of SAM01700Back.SAM01700DTO)) Implements ISAM01700StreamingService.Dummy

    End Sub

    Public Function GetHistory() As System.ServiceModel.Channels.Message Implements ISAM01700StreamingService.GetHistory
        Dim loException As New R_Exception
        Dim loCls As New SAM01700Cls
        Dim loRtnTemp As List(Of SAM01700DTO)
        Dim loRtn As Message
        Dim lcCompId As String

        Try
            lcCompId = R_Utility.R_GetStreamingContext("CompId")

            loRtnTemp = loCls.GetHistory(lcCompId)

            loRtn = R_StreamUtility(Of SAM01700DTO).WriteToMessage(loRtnTemp.AsEnumerable, "GetHistory")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
