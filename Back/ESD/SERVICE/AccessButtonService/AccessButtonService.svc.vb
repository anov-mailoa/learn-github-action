Imports R_Common
Imports AccessButtonBack
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "AccessButtonService" in code, svc and config file together.
Public Class AccessButtonService
    Implements IAccessButtonService

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of AccessButtonBack.ProgramDTO)) Implements IAccessButtonService.Dummy

    End Sub

    Public Function getProgramList() As System.ServiceModel.Channels.Message Implements IAccessButtonService.getProgramList
        Dim loException As New R_Exception
        Dim loCls As New AccessButtonCls
        Dim loRtnTemp As List(Of ProgramDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getProgramList()

            loRtn = R_StreamUtility(Of ProgramDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getProgramList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
