Imports R_Common
Imports PYT00100Back
Imports System.ServiceModel.Channels
Imports PYT00100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00100StreamingService" in code, svc and config file together.
Public Class PYT00100StreamingService
    Implements IPYT00100StreamingService

    Public Function getPytTransactionHd() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getPytTransactionHd
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtnTemp As List(Of PYT00100GridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getPytTransactionHd(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100GridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPytTransactionHd")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDownloadTemplate() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getDownloadTemplate
        Dim loEx As New R_Exception
        'Dim loCls As New PYT00100EmployeeCls
        Dim loRtnTemp As List(Of PYT00100TemplateDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100EmployeeDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
            End With

            ' loRtnTemp = loCls.getDownloadTemplate(loParam)

            loRtn = R_StreamUtility(Of PYT00100TemplateDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getDownloadTemplate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function getListDraftComponent() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getListDraftComponent
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100ComponentCls
        Dim loRtnTemp As List(Of ComponentListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100ComponentDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                '.cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
                '.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                '.cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionPeriod = R_Utility.R_GetStreamingContext("cTransactionPeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getListDraftComponent(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComponentListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDraftComponent")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListNonDraftComponent() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getListNonDraftComponent
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100ComponentCls
        Dim loRtnTemp As List(Of ComponentListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100ComponentDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
            End With

            loRtnTemp = loCls.getListNonDraftComponent(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComponentListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListNonDraftComponent")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDraftCurrency() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getListDraftCurrency
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100ComponentCls
        Dim loRtnTemp As List(Of ComponentListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100ComponentDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getListDraftCurrency(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComponentListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDraftCurrency")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListNonDraftCurrency() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getListNonDraftCurrency
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100ComponentCls
        Dim loRtnTemp As List(Of ComponentListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100ComponentDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getListNonDraftCurrency(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComponentListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListNonDraftCurrency")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "HISTORY"

    Public Function getComponent() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getComponent
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100HistoryCls
        Dim loRtnTemp As List(Of PYT00100HistoryDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100HistoryDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cRefNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnTemp = loCls.getComponent(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100HistoryDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComponent")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100HistoryCls
        Dim loRtnTemp As List(Of PYT00100HistoryDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100HistoryDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cRefNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnTemp = loCls.getEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100HistoryDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getTransaction
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100HistoryCls
        Dim loRtnTemp As List(Of PYT00100HistoryDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100HistoryDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionPeriod = R_Utility.R_GetStreamingContext("cTransactionPeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getTransaction(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100HistoryDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransaction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriodList() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getPeriodList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100HistoryCls
        Dim loRtnTemp As List(Of PYT00100HistoryDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100HistoryDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPeriodList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100HistoryDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriodList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

    Public Function getDownloadTemplateComponent() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getDownloadTemplateComponent
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100ComponentCls
        Dim loRtnTemp As List(Of PYT00100TemplateDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100EmployeeDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cRefNo")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getDownloadTemplateComponent(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100TemplateDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDownloadTemplateComponent")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDownloadTemplateEmployee() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getDownloadTemplateEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100EmployeeCls
        Dim loRtnTemp As List(Of PYT00100TemplateDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100EmployeeDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cRefNo")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getDownloadTemplateEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00100TemplateDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDownloadTemplateEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_RESTRICT_SUBGRADE_VALIDATION() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.RSP_RESTRICT_SUBGRADE_VALIDATION
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtnTemp As List(Of EmployeeListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100DTO

        Dim lcEmployees As String
        Dim loEmployees As New List(Of PYT00100CommonDTO)
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")

             
                lcEmployees = R_Utility.R_GetStreamingContext("oEmployees")
                loEmployees = R_Utility.XMLToObject(Of List(Of PYT00100CommonDTO))(lcEmployees)

            End With

            loRtnTemp = loCls.RSP_RESTRICT_SUBGRADE_VALIDATION(loParam, loEmployees)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of EmployeeListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_RESTRICT_SUBGRADE_VALIDATION")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "DUMMY"
    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYT00100Back.PYT00100GridDTO)) Implements IPYT00100StreamingService.Dummy

    End Sub

    Public Sub Dummy1(poPar As System.Collections.Generic.List(Of PYT00100Back.ComponentListGridDTO)) Implements IPYT00100StreamingService.Dummy1

    End Sub

    Public Sub Dummy2(poPar As System.Collections.Generic.List(Of PYT00100Back.EmployeeListGridDTO)) Implements IPYT00100StreamingService.Dummy2

    End Sub

    Public Sub Dummy3(poPar As System.Collections.Generic.List(Of PYT00100Back.PYT00100ComponentDTO)) Implements IPYT00100StreamingService.Dummy3

    End Sub

#End Region

#Region "EMPLOYEE"

    Public Function getListNonDraft() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getListNonDraft
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100EmployeeCls
        Dim loRtnTemp As List(Of EmployeeListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100EmployeeDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
            End With

            loRtnTemp = loCls.getListNonDraft(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of EmployeeListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListNonDraft")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDraft() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getListDraft
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100EmployeeCls
        Dim loRtnTemp As List(Of EmployeeListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100EmployeeDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cTransactionPeriod = R_Utility.R_GetStreamingContext("cTransactionPeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnTemp = loCls.getListDraft(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of EmployeeListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDraft")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmpCompList() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getEmpCompList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100EmployeeCls
        Dim loRtnTemp As List(Of EmployeeListGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00100EmployeeDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")

                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
            End With

            loRtnTemp = loCls.getEmpCompList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of EmployeeListGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpCompList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IPYT00100StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtnTemp As List(Of TEST_DTO)
        Dim loRtn As Message
        Dim loParam As New PYT00100DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnTemp = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of TEST_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
