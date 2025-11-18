Imports R_Common
Imports PYM12000Back
Imports System.ServiceModel.Channels
Imports PYM12000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM12000StreamingService" in code, svc and config file together.
Public Class PYM12000StreamingService
    Implements IPYM12000StreamingService

    Public Function getMaintainableReportList() As System.ServiceModel.Channels.Message Implements IPYM12000StreamingService.getMaintainableReportList
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000Cls
        Dim loRtnTemp As List(Of PYM12000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM12000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getMaintainableReportList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM12000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMaintainableReportList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDetailCellList() As System.ServiceModel.Channels.Message Implements IPYM12000StreamingService.getDetailCellList
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000DetailCls
        Dim loRtnTemp As List(Of PYM12000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM12000DetailDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportId = R_Utility.R_GetStreamingContext("cReportId")
            End With

            loRtnTemp = loCls.getDetailCellList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM12000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDetailCellList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IPYM12000StreamingService.getEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000FooterCls
        Dim loRtnTemp As List(Of PYM12000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As String

        Try
            loParam = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loRtnTemp = loCls.getEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM12000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
