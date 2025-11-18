Imports R_Common
Imports PYT00500Back
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports PYT00500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00500StreamingService" in code, svc and config file together.
Public Class PYT00500StreamingService
    Implements IPYT00500StreamingService

    Public Function getRapelTransaction() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelTransaction
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500GridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getRapelTransaction(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500GridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelTransaction")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRapelComponent() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelComponent
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500RapelComponentGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getRapelComponent(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelComponentGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelComponent")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRapelEmployee() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500RapelEmployeeGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lView = R_Utility.R_GetStreamingContext("lView")
            End With

            loRtnTemp = loCls.getRapelEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelEmployeeGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRapelResult() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelResult
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500RapelEmployeeGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lView = R_Utility.R_GetStreamingContext("lView")
            End With

            loRtnTemp = loCls.getRapelResult(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelEmployeeGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelResult")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRapelResultDetails() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelResultDetails
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500RapelResultDetailDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.getRapelResultDetails(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelResultDetailDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelResultDetails")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExcelData() As Message Implements IPYT00500StreamingService.getExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loParam As New PYT00500DTO
        Dim loRtnTemp As New List(Of DataTable)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.getExcelData(loParam)
            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRapelResultPrint() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelResultPrint
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500ReportDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.getRapelResultPrint(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelResultPrint")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRapelResultComp() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getRapelResultComp
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500RapelResultDetailDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .lFromHistory = R_Utility.R_GetStreamingContext("lFromHistory")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
            End With

            loRtnTemp = loCls.getRapelResultComp(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelResultDetailDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapelResultComp")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSalaryGroups() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getSalaryGroups
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim poParam As New PYT00500DTO
        Dim loRtnList As New List(Of PYT00500DTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getSalaryGroups(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500DTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroups")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getYears() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getYears
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim poParam As New PYT00500DTO
        Dim loRtnList As New List(Of PYT00500DTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getYears(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500DTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getYears")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim poParam As New PYT00500DTO
        Dim loRtnList As New List(Of PYT00500DTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartYear = R_Utility.R_GetStreamingContext("cStartYear")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getHistory(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500DTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompHistory() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getCompHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim poParam As New PYT00500DTO
        Dim loRtnList As New List(Of PYT00500RapelComponentGridDTOnon)
        Dim loRtn As Message

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getCompHistory(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelComponentGridDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmpHistory() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getEmpHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim poParam As New PYT00500DTO
        Dim loRtnList As New List(Of PYT00500RapelEmployeeGridDTOnon)
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
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelEmployeeGridDTOnon)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy1(poPar1 As System.Collections.Generic.List(Of PYT00500Back.PYT00500RapelComponentGridDTO), poPar2 As System.Collections.Generic.List(Of PYT00500Back.PYT00500RapelEmployeeGridDTO), poPar5 As System.Collections.Generic.List(Of PYT00500Back.PYT00500RapelResultDetailDTO), poPar6 As System.Collections.Generic.List(Of PYT00500Back.PYT00500GridDTO)) Implements IPYT00500StreamingService.Dummy1

    End Sub

    Public Function getList() As System.ServiceModel.Channels.Message Implements IPYT00500StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtnTemp As List(Of PYT00500RapelEmployeeGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00500DTO

        Try
            With loParam
                .cDataType = R_Utility.R_GetStreamingContext("cDataType")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cDeptList = R_Utility.R_GetStreamingContext("cDeptList")
                .cPosList = R_Utility.R_GetStreamingContext("cPosList")
                .cLocList = R_Utility.R_GetStreamingContext("cLocList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00500RapelEmployeeGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
