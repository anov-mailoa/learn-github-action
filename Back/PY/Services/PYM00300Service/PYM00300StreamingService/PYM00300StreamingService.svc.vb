Imports R_Common
Imports PYM00300Back
Imports System.ServiceModel.Channels
Imports PYM00300Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00300StreamingService" in code, svc and config file together.
Public Class PYM00300StreamingService
    Implements IPYM00300StreamingService

    Public Function getActiveComplist() As System.ServiceModel.Channels.Message Implements IPYM00300StreamingService.getActiveComplist
        Dim loEx As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim loRtnTemp As List(Of PYM00300CompListDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00300DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getActiveComplist(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00300CompListDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getActiveComplist")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAllComplist() As System.ServiceModel.Channels.Message Implements IPYM00300StreamingService.getAllComplist
        Dim loEx As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim loRtnTemp As List(Of PYM00300CompListDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00300DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getAllComplist(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00300CompListDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAllComplist")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of PYM00300Back.PYM00300CompListDTO)) Implements IPYM00300StreamingService.Dummy

    End Sub

    Public Function getCmbBank() As System.ServiceModel.Channels.Message Implements IPYM00300StreamingService.getCmbBank
        Dim loException As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim pcCompId As String
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM00300CompListDTOnon)
        Dim loRtn As Message = Nothing

        Try

            pcCompId = R_Utility.R_GetStreamingContext("pcCompId")

            loRtnList = loCls.getCmbBank(pcCompId)
            loList = R_Utility.R_GetChunkData(Of PYM00300CompListDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbBank")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCurrency() As System.ServiceModel.Channels.Message Implements IPYM00300StreamingService.getCmbCurrency
        Dim loException As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim pcCompId As String
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM00300CompListDTOnon)
        Dim loRtn As Message = Nothing

        Try

            loRtnList = loCls.getCmbCurrency()
            loList = R_Utility.R_GetChunkData(Of PYM00300CompListDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCurrency")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPYM00300StreamingService.GetReportData
        Dim loException As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim poParam As New PYM00300DTO
        Dim loRtnList As New List(Of PYM00300ReportDTO)
        Dim loRtnTemp As List(Of PYM00300ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.GetReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM00300ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCompanyBank() As System.ServiceModel.Channels.Message Implements IPYM00300StreamingService.getCmbCompanyBank
        Dim loException As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim pcCompId As String
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM00300CompListDTOnon)
        Dim loRtn As Message = Nothing

        Try

            pcCompId = R_Utility.R_GetStreamingContext("pcCompId")

            loRtnList = loCls.getCmbCompanyBank(pcCompId)
            loList = R_Utility.R_GetChunkData(Of PYM00300CompListDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCompanyBank")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
