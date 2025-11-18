Imports System.ServiceModel
Imports R_Common
Imports PYT00300Back
Imports System.ServiceModel.Channels
Imports PYT00300Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00300StreamingService" in code, svc and config file together.
Public Class PYT00300StreamingService
    Implements IPYT00300StreamingService

    Public Function GetListRapidTransactionDt() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.GetListRapidTransactionDt
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300DtCls
        Dim poParam As New PYT00300DtDTO
        Dim loRtnList As New List(Of PYT00300GridDtDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lView = R_Utility.R_GetStreamingContext("lView")
            End With

            loRtnList = loCls.GetListRapidTransactionDt(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridDtDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RapidTransactionDt")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetListRapidTransactionHd() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.GetListRapidTransactionHd
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim poParam As New PYT00300HdDTO
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.GetListRapidTransactionHd(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RapidTransactionHd")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTemplate() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.GetTemplate
        Dim loEx As New R_Exception
        'Dim loCls As New PYT00300DtCls
        Dim poParam As New PYT00300DtDTO
        Dim loRtnList As New List(Of PYT00300TemplateDTO)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
            End With

            'loRtnList = loCls.GetTemplate(poParam)

            loRtn = R_StreamUtility(Of PYT00300TemplateDTO).WriteToMessage(loRtnList.AsEnumerable, "GetTemplate")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DownloadExcel() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.DownloadExcel
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300DtCls
        Dim poParam As New PYT00300DtDTO
        Dim loRtnList As New List(Of PYT00300ExcelStreamingDTO)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
            End With

            loRtnList = loCls.DownloadExcel(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300ExcelStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "DownloadExcel")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim poParam As New PYT00300HdDTO
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cActivePeriod = R_Utility.R_GetStreamingContext("cActivePeriod")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getHistory(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriods() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getPeriods
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim poParam As New PYT00300HdDTO
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getPeriods(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriods")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroups() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getSalaryGroups
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim poParam As New PYT00300HdDTO
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getSalaryGroups(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroups")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmpHistory() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getEmpHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim poParam As New PYT00300HdDTO
        Dim loRtnList As New List(Of PYT00300GridDtDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getEmpHistory(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridDtDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbUploadRapidTo() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getCmbUploadRapidTo
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            loRtnList = loCls.getCmbUploadRapidTo(R_Utility.R_GetStreamingContext("cCompanyId"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbUploadRapidTo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompList() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getCompList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            loRtnList = loCls.getCompList(R_Utility.R_GetStreamingContext("cCompanyId"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroupList() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getSalaryGroupList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message

        Try
            loRtnList = loCls.getSalaryGroupList(R_Utility.R_GetStreamingContext("cCompanyId"),
                                                 R_Utility.R_GetStreamingContext("cUserId"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroupList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDownloadData() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getDownloadData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00300HdDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
                .cNewCurrency = R_Utility.R_GetStreamingContext("cCurrencyCode")
            End With

            loRtnList = loCls.getDownloadData(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDownloadData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00300HdDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnList = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCurrency() As System.ServiceModel.Channels.Message Implements IPYT00300StreamingService.getCmbCurrency
        Dim loEx As New R_Exception
        Dim loCls As New PYT00300HdCls
        Dim loRtnList As New List(Of PYT00300GridHdDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00300HdDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbCurrency(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00300GridHdDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCurrency")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
