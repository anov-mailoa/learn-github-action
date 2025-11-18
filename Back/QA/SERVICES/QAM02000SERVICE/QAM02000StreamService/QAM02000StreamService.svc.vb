Imports R_Common
Imports QAM02000Back
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports QAM02000Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM02000StreamService" in code, svc and config file together.
Public Class QAM02000StreamService
    Implements IQAM02000StreamService
    Public Function getComboPosition() As System.ServiceModel.Channels.Message Implements IQAM02000StreamService.getComboPosition
        Dim loException As New R_Exception
        Dim loCls As New QAM02000CLS
        Dim loRtnTemp As List(Of ComboBoxDTO)
        Dim loParam As New QAM02000DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

        End With

        Try
            loRtnTemp = loCls.getComboPosition(loParam)

            loChunk = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getComboPosition")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getComboTemplate() As System.ServiceModel.Channels.Message Implements IQAM02000StreamService.getComboTemplate
        Dim loException As New R_Exception
        Dim loCls As New QAM02000CLS
        Dim loRtnTemp As List(Of ComboBoxDTO)
        Dim loParam As New QAM02000DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

        End With

        Try
            loRtnTemp = loCls.getComboTemplate(loParam)

            loChunk = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getComboTemplate")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListGridHeader() As System.ServiceModel.Channels.Message Implements IQAM02000StreamService.getListGridHeader
        Dim loException As New R_Exception
        Dim loCls As New QAM02000CLS
        Dim loRtnTemp As List(Of QAM02000StreamingDTO)
        Dim loParam As New QAM02000DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
        End With

        Try
            loRtnTemp = loCls.getListGridHeader(loParam)
            loChunk = R_Utility.R_GetChunkData(Of QAM02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListGridHeader")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListGridOther() As System.ServiceModel.Channels.Message Implements IQAM02000StreamService.getListGridOther
        Dim loException As New R_Exception
        Dim loCls As New QAM02000CLS
        Dim loRtnTemp As List(Of QAM02000StreamingDTO)
        Dim loParam As New QAM02000DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cConfigId = R_Utility.R_GetStreamingContext("cConfigId")
        End With

        Try
            loRtnTemp = loCls.getListGridOther(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListGridOther")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListGridReceptions_BCC() As System.ServiceModel.Channels.Message Implements IQAM02000StreamService.getListGridReceptions_BCC
        Dim loException As New R_Exception
        Dim loCls As New QAM02000CLS
        Dim loRtnTemp As List(Of QAM02000StreamingDTO)
        Dim loParam As New QAM02000DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cConfigId = R_Utility.R_GetStreamingContext("cConfigId")
        End With

        Try
            loRtnTemp = loCls.getListGridReceptions_BCC(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListGridReceptions_BCC")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListGridReceptions_CC() As System.ServiceModel.Channels.Message Implements IQAM02000StreamService.getListGridReceptions_CC
        Dim loException As New R_Exception
        Dim loCls As New QAM02000CLS
        Dim loRtnTemp As List(Of QAM02000StreamingDTO)
        Dim loParam As New QAM02000DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cConfigId = R_Utility.R_GetStreamingContext("cConfigId")
        End With

        Try
            loRtnTemp = loCls.getListGridReceptions_CC(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListGridReceptions_CC")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Sub Dummy(poGrid2 As QAM02000Back.QAM02000OthersDTO, poGrid3 As QAM02000Back.QAM02000BCCDTO, poGrid4 As QAM02000Back.QAM02000CCDTO) Implements IQAM02000StreamService.Dummy

    End Sub
End Class
