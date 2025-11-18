Imports System.ServiceModel.Channels
Imports R_Common
Imports ESSMenuBack

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESSMenuStreamingService" in code, svc and config file together.
Public Class ESSMenuStreamingService
    Implements IESSMenuStreamingService

    Public Function GetMenu() As System.ServiceModel.Channels.Message Implements IESSMenuStreamingService.GetMenu
        Dim loException As New R_Exception
        Dim loCls As New ESSMenuCls
        Dim loRtnTemp As List(Of ESSMenuDTO)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())
        Dim loParam As New ESSLoginDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetMenu(loParam)

            loRtn = R_StreamUtility(Of ESSMenuDTO).WriteToMessage(loRtnTemp.AsEnumerable, "GetMenu")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of ESSMenuBack.ESSMenuDTO)) Implements IESSMenuStreamingService.Dummy

    End Sub
End Class
