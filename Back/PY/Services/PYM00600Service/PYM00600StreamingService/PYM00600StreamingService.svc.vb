Imports R_Common
Imports PYM00600Back
Imports System.ServiceModel.Channels
Imports PYM00600Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00600StreamingService" in code, svc and config file together.
Public Class PYM00600StreamingService
    Implements IPYM00600StreamingService


    Public Function getProcess() As System.ServiceModel.Channels.Message Implements IPYM00600StreamingService.getProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYM00600Cls
        Dim loRtnTemp As List(Of PYM00600GridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00600GridDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getProcess(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00600GridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
