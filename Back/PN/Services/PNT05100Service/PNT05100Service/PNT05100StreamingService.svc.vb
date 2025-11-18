Imports System.ServiceModel
Imports R_Common
Imports PNT05100Back
Imports PNT05100Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT05100StreamingService" in code, svc and config file together.
Public Class PNT05100StreamingService
    Implements IPNT05100StreamingService

    Public Function getCmbPosition() As System.ServiceModel.Channels.Message Implements IPNT05100StreamingService.getCmbPosition
        Dim loException As New R_Exception
        Dim loCls As New PNT05100Cls
        Dim loRtnTemp As List(Of PNT05100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNT05100DTO

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getCmbPosition(loParam)
            loList = R_Utility.R_GetChunkData(Of PNT05100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPosition")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
