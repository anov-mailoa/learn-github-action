Imports R_BackEnd
Imports R_Common
Imports QAT00300Back
Imports QAT00300Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00300StreamService" in code, svc and config file together.
Public Class QAT00300StreamService
    Implements IQAT00300StreamService

    Public Function getListGrid() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getListGrid
        Dim loException As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New List(Of QAT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT00300DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.getListGrid(poParam)

            loList = R_Utility.R_GetChunkData(Of QAT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGrid")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListGridClause() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getListGridClause
        Dim loException As New R_Exception
        Dim loCls As New QAT003002CLS
        Dim loRtn As New List(Of QAT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003002DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.getListGridClause(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridClause")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function Clause_Type() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.Clause_Type
        Dim loException As New R_Exception
        Dim loCls As New QAT003002CLS
        Dim loRtn As New List(Of ComboBoxDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003002DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cIsoType = R_Utility.R_GetStreamingContext("cIsoType")
            poParam.cIsoVersion = R_Utility.R_GetStreamingContext("cIsoVersion")

            loRtn = loCls.Clause_Type(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Clause_Type")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function ISO_Type() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.ISO_Type
        Dim loException As New R_Exception
        Dim loCls As New QAT003002CLS
        Dim loRtn As New List(Of ComboBoxDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003002DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")


            loRtn = loCls.ISO_Type(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "ISO_Type")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function ComboPositionCode() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.ComboPositionCode
        Dim loException As New R_Exception
        Dim loCls As New QAT003003CLS
        Dim loRtn As New List(Of ComboBoxDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003003DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.ComboPositionCode(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "ComboPositionCode")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListGridRetainer() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getListGridRetainer
        Dim loException As New R_Exception
        Dim loCls As New QAT003003CLS
        Dim loRtn As New List(Of QAT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003003DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.getListGridRetainer(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridRetainer")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getGridRetain() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getGridRetain
        Dim loException As New R_Exception
        Dim loCls As New QAT00300RetainersCLS
        Dim loRtn As New List(Of QAT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003006DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.getGridRetain(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridRetain")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListGridDocumentInfo() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getListGridDocumentInfo
        Dim loException As New R_Exception
        Dim loCls As New QAT00300RetainDocumentCLS
        Dim loRtn As New List(Of QAT00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT003005DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.getListGridDocumentInfo(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridDocumentInfo")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDepartmentList() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getDepartmentList
        Dim loException As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New List(Of String)
        Dim loRtnMessage As Message
        Dim poParam As New QAT00300DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getDepartmentList(poParam)
            loList = R_Utility.R_GetChunkData(Of String)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDepartmentList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbDocType() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getCmbDocType
        Dim loCls As New QAT00300RetainDocumentCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT003005DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getCmbDocType(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbDocType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPositionCodeRetainer() As System.ServiceModel.Channels.Message Implements IQAT00300StreamService.getCmbPositionCodeRetainer
        Dim loCls As New QAT00300RetainersCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT003006DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
            End With

            loRtnList = loCls.getCmbPositionCodeRetainer(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbPositionCodeRetainer")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
