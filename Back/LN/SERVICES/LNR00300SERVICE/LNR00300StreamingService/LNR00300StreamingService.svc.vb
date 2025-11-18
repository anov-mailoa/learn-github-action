Imports R_Common
Imports R_BackEnd
Imports LNR00300Back
Imports LNR00300Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00300StreamingService" in code, svc and config file together.
Public Class LNR00300StreamingService
    Implements ILNR00300StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR00300StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR00300Cls
        Dim loRtnTemp As List(Of LNR00300Dto_S)
        Dim loRtn As Message
        Dim loParam As New LNR00300Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromInstallmentDate = R_Utility.R_GetStreamingContext("cFromInstallmentDate")
                .cToInstallmentDate = R_Utility.R_GetStreamingContext("cToInstallmentDate")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.getReport(loParam)
            loList = R_Utility.R_GetChunkData(Of LNR00300Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParReguler As System.Collections.Generic.List(Of LNR00300Back.LNR00300Dto_R), poParReport As System.Collections.Generic.List(Of LNR00300Back.ReportHeaderDTO)) Implements ILNR00300StreamingService.Dummy

    End Sub
End Class
