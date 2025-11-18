Imports R_Common
Imports R_FrontEnd
Imports System.ServiceModel
Imports CommonHelper
Imports ClientHelper
Imports PYR12100Common
Imports PYR12100FrontResources
Imports PYR12100Front.PYR12100StreamingServiceRef
Imports System.ServiceModel.Channels
Imports CrystalDecisions.CrystalReports.Engine
Imports SIAPP_LookUp.SIAPP_PUB_DTOServiceRef
Imports SIAPP_LookUp
Imports System.Threading
Imports System.Globalization.CultureInfo


Public Class PYR12100

#Region "UTILITIES"
    Public Const C_RegServiceName As String = "PYR12100Service/PYR12100Service.svc"
    Public Const C_StreamingServiceName As String = "PYR12100Service/PYR12100StreamingService.svc"

    Dim gcCompId = U_GlobalVar.CompId.Trim
    Dim gcUserId = U_GlobalVar.UserId.Trim
    Dim gcLangId = U_GlobalVar.CultureUI.TwoLetterISOLanguageName.Trim
    Dim gcEncryptionKey = U_GlobalVar.EncryptKey

    Dim _loTemp As New List(Of PYR12100DTO)

    'PARAMETER LOCAL VARIABLE SP
    Dim gcSalaryGroupList As String = ""
    Dim gcEmployeeIdList As String = ""
    Dim gcProcessList As String = ""
    Dim glSelectEmployee As Boolean = False
    Dim giCountGroup As Integer = 0
    Dim giCountProcessCode As Integer = 0
#End Region

    Public Function getPeriod()
        Dim loStreamingService As PYR12100StreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IPYR12100StreamingService, PYR12100StreamingServiceClient)(e_ServiceClientType.StreamingService, C_StreamingServiceName)
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loTemp As IEnumerable(Of Byte())
        Dim loGrid As New List(Of LookUpCmbDTO)
        Dim loResult As List(Of PYR12100StreamingDTO)

        Try

            Dim loPar As New Dictionary(Of String, Object)

            With loPar
                .Item("cCompanyId") = gcCompId
                .Item("cUserId") = gcUserId
            End With

            R_Utility.R_SetStreamingContext(loPar)

            loRtn = loStreamingService.getPeriod()
            loTemp = R_StreamUtility(Of Byte()).ReadFromMessage(loRtn)
            loResult = R_Utility.R_CombineData(Of PYR12100StreamingDTO)(loTemp)

            For Each loDto As PYR12100StreamingDTO In loResult
                If loDto IsNot Nothing Then
                    loGrid.Add(New LookUpCmbDTO With {.cCode = loDto.cPeriod,
                                                     .cDescription = loDto.cPeriod
                                                     })
                Else
                    Exit For
                End If
            Next

            bsFrom.DataSource = loGrid
            bsTo.DataSource = loGrid
        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loEx.Add(ex)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ThrowExceptionIfErrors()
    End Function

    Private Sub PYR12100_R_Init_From_Master(poParameter As Object) Handles Me.R_Init_From_Master
        getPeriod()

        btnSelect.R_Title = R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "_LookupEmployee")

        rdbSelectAll.IsChecked = True
        rbDetail.IsChecked = True
        gvSalaryGroup.R_RefreshGrid(New Object)
        gvProcess.R_RefreshGrid(New Object)
    End Sub

    Private Sub gvSalaryGroup_R_ServiceGetListRecord1(poEntity As Object, ByRef poListEntityResult As Object) Handles gvSalaryGroup.R_ServiceGetListRecord
        Dim loStreamingService As PYR12100StreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IPYR12100StreamingService, PYR12100StreamingServiceClient)(e_ServiceClientType.StreamingService, C_StreamingServiceName)
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loTemp As IEnumerable(Of Byte())
        Dim loGrid As New List(Of PYR12100DTO)
        Dim loResult As List(Of PYR12100StreamingDTO)
        Try
            Dim loPar As New Dictionary(Of String, Object)

            With loPar
                .Item("cCompanyId") = gcCompId
                .Item("cUserId") = gcUserId
            End With

            R_Utility.R_SetStreamingContext(loPar)
            loRtn = loStreamingService.getGrupGaji()
            loTemp = R_StreamUtility(Of Byte()).ReadFromMessage(loRtn)
            loResult = R_Utility.R_CombineData(Of PYR12100StreamingDTO)(loTemp)

            For Each loDto As PYR12100StreamingDTO In loResult
                If loDto IsNot Nothing Then
                    loGrid.Add(New PYR12100DTO With {._cGroupCode = loDto.cGroupCode,
                                                     ._cGroupDescription = loDto.cGroupDescription
                                                    })
                Else
                    Exit For
                End If
            Next

            poListEntityResult = loGrid
        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loEx.Add(ex)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ThrowExceptionIfErrors()
        End If
    End Sub

    Private Sub gvProcess_R_ServiceGetListRecord(poEntity As Object, ByRef poListEntityResult As Object) Handles gvProcess.R_ServiceGetListRecord
        Dim loStreamingService As PYR12100StreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IPYR12100StreamingService, PYR12100StreamingServiceClient)(e_ServiceClientType.StreamingService, C_StreamingServiceName)
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loTemp As IEnumerable(Of Byte())
        Dim loGrid As New List(Of PYR12100DTO)
        Dim loResult As List(Of PYR12100StreamingDTO)

        Try

            Dim loPar As New Dictionary(Of String, Object)

            With loPar
                .Item("cCompanyId") = gcCompId
                .Item("cUserId") = gcUserId
            End With

            R_Utility.R_SetStreamingContext(loPar)

            loRtn = loStreamingService.getProcess
            loTemp = R_StreamUtility(Of Byte()).ReadFromMessage(loRtn)
            loResult = R_Utility.R_CombineData(Of PYR12100StreamingDTO)(loTemp)

            For Each loDto As PYR12100StreamingDTO In loResult
                If loDto IsNot Nothing Then
                    loGrid.Add(New PYR12100DTO With {._cProcessCode = loDto.cProcessCode,
                                                     ._cProcessDescription = loDto.cProcessDescription
                                                    })
                Else
                    Exit For
                End If
            Next

            poListEntityResult = loGrid
        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loEx.Add(ex)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ThrowExceptionIfErrors()
        End If
    End Sub

#Region "EMPLOYEE OPTION"

#Region "SELECT ALL"

    Private Sub rbResign_CheckStateChanged(sender As Object, e As System.EventArgs) Handles rbResign.CheckStateChanged
        glSelectEmployee = False

        gvEmployeeGrid.Enabled = False
        btnSelect.Enabled = False
        btnRemove.Enabled = False

        bsEmployeeGrid.Clear()
    End Sub

    Private Sub rbActive_CheckStateChanged(sender As Object, e As System.EventArgs) Handles rbActive.CheckStateChanged
        glSelectEmployee = False

        gvEmployeeGrid.Enabled = False
        btnSelect.Enabled = False
        btnRemove.Enabled = False

        bsEmployeeGrid.Clear()
    End Sub

    Private Sub rdbSelectAll_CheckStateChanged(sender As Object, e As System.EventArgs) Handles rdbSelectAll.CheckStateChanged
        glSelectEmployee = False

        gvEmployeeGrid.Enabled = False
        btnSelect.Enabled = False
        btnRemove.Enabled = False

        bsEmployeeGrid.Clear()
    End Sub

#End Region

    Private Sub rdbCertainEmployee_CheckStateChanged(sender As Object, e As System.EventArgs) Handles rdbCertainEmployee.CheckStateChanged
        glSelectEmployee = True

        gvEmployeeGrid.Enabled = True
        btnSelect.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub gvEmployeeGrid_R_ServiceGetRecord1(poEntity As Object, ByRef poEntityResult As Object) Handles gvEmployeeGrid.R_ServiceGetRecord
        Dim loEntity As PYR12100DTO = poEntity
        Dim LoEx As New R_Exception

        Try

            'Untuk getRecord dulu sebelum check/unchecked checkbox
            poEntityResult = loEntity

        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)

            LoEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            LoEx.Add(ex)
        Catch ex As Exception
            LoEx.Add(ex)
        End Try
        If LoEx.Haserror Then
            LoEx.ThrowExceptionIfErrors()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As System.EventArgs) Handles btnRemove.Click
        bsEmployeeGrid.Clear()
    End Sub

#Region "POP UP SELECT EMPLOYEE"

    Private Sub btnSelect_R_Before_Open_Form(ByRef poTargetForm As R_FrontEnd.R_FormBase, ByRef poParameter As Object) Handles btnSelect.R_Before_Open_Form
        Dim loEx As New R_Exception

        'SALARY GROUP LIST
        If bsSalaryGroup.Current IsNot Nothing Then
            Dim SelectedFlag As Integer = 0
            gcSalaryGroupList = ""
            Dim loEmpTemp As New List(Of PYR12100DTO)

            loEmpTemp = bsSalaryGroup.DataSource
            For Each a In loEmpTemp
                If a._lCheck Then
                    SelectedFlag = SelectedFlag + 1
                    gcSalaryGroupList = gcSalaryGroupList + a._cGroupCode.Trim + ","
                End If
            Next
            If Not String.IsNullOrWhiteSpace(gcSalaryGroupList) Then
                gcSalaryGroupList = Microsoft.VisualBasic.Left(gcSalaryGroupList, Len(gcSalaryGroupList) - 1)

                Dim loParameter As New ParameterSPDTO

                With loParameter
                    ._cCompanyId = gcCompId
                    ._cUserId = gcUserId
                    ._cGroupCodeList = gcSalaryGroupList
                    ._cProcessCode = "SALARY"
                    ._cPeriodIndex = cmbTo.SelectedValue.ToString + "-0"
                End With

                poTargetForm = New PYL00800
                poParameter = loParameter
            Else
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS001"))
            End If
        Else
            loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS001"))
        End If

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
            Exit Sub
        End If
    End Sub

    Private Sub btnSelect_R_After_Open_Form(poPopUpResult As System.Windows.Forms.DialogResult, poPopUpEntityResult As Object) Handles btnSelect.R_After_Open_Form
        Dim DTOEMPLOYEE_LIST As New List(Of PYR12100DTO)

        If gvEmployeeGrid.DataSource.Count = 0 Then
            DTOEMPLOYEE_LIST = Nothing
        Else
            DTOEMPLOYEE_LIST = bsEmployeeGrid.DataSource
        End If


        If poPopUpResult = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        ElseIf poPopUpResult = Windows.Forms.DialogResult.OK Then
            If (poPopUpEntityResult IsNot Nothing) Then
                Dim llAdd As Boolean = True
                For Each A In poPopUpEntityResult
                    If DTOEMPLOYEE_LIST IsNot Nothing Then
                        'RESET JIKA SAMA TIDAK BOLEH D ADD
                        llAdd = True
                        For Each B In DTOEMPLOYEE_LIST
                            If A.CEMPLOYEE_ID = B._CEMPLOYEE_ID Then
                                llAdd = False

                            End If
                        Next

                        If llAdd Then

                            _loTemp.Add(New PYR12100DTO With {._CEMPLOYEE_ID = A.CEMPLOYEE_ID,
                                                              ._CEMPLOYEE_NAME = A.CEMPLOYEE_NAME,
                                                              ._POSITION = A.CPOSITION_DESCRIPTION,
                                                              ._DEPT = A.CDEPT_NAME,
                                                              ._LOCATION = A.CLOCATION_DESCRIPTION,
                                                              ._lCheck1 = A.lSelected
                                                             })
                        End If

                    ElseIf DTOEMPLOYEE_LIST Is Nothing Then
                        _loTemp.Add(New PYR12100DTO With {._CEMPLOYEE_ID = A.CEMPLOYEE_ID,
                                                               ._CEMPLOYEE_NAME = A.CEMPLOYEE_NAME,
                                                               ._POSITION = A.CPOSITION_DESCRIPTION,
                                                               ._DEPT = A.CDEPT_NAME,
                                                               ._LOCATION = A.CLOCATION_DESCRIPTION,
                                                               ._lCheck1 = A.lSelected
                                                              })
                    End If
                Next

                'For Each A In poPopUpEntityResult
                '    'TAMPUNG untuk bisa di generate sesuai checkBox yang dipilih
                '    _loTemp.Add(New PYR04000DTO With {._CEMPLOYEE_ID = A.CEMPLOYEE_ID,
                '                                      ._CEMPLOYEE_NAME = A.CEMPLOYEE_NAME,
                '                                      ._lCheck1 = True
                '                                     })
                'Next
            End If

            bsEmployeeGrid.DataSource = _loTemp '
            bsEmployeeGrid.ResetBindings(False)
        End If
    End Sub

#End Region

#End Region

#Region "PRINT"

    Private Sub cryOptBtn_R_GetData(ByRef poData As Object) Handles cryOptBtn.R_GetData
        Dim loStreamingService As PYR12100StreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IPYR12100StreamingService, PYR12100StreamingServiceClient)(e_ServiceClientType.StreamingService, C_StreamingServiceName)
        Dim loTemp As IEnumerable(Of Byte())
        Dim loEx As New R_Exception()
        Dim loRtn As Message
        Dim loFinish As New List(Of PYR12100ReportDTO)
        Dim loResult As List(Of PYR12100ReportDTO)

        Try
            Dim loPar As New Dictionary(Of String, Object)

            With loPar
                .Item("cCompanyId") = gcCompId
                .Item("cFromIndex") = cmbFrom.SelectedValue
                .Item("cToIndex") = cmbTo.SelectedValue
                .Item("cGroupCode") = gcSalaryGroupList
                .Item("cProcessCode") = gcProcessList
                .Item("cEmployeeStatusType") = IIf(rdbSelectAll.IsChecked, "1", IIf(rbActive.IsChecked, "2", IIf(rbResign.IsChecked, "3", "4")))
                .Item("lSelectEmployee") = glSelectEmployee
                .Item("cSalaryValueMode") = IIf(rbDetail.IsChecked, "D", "S")
                .Item("cEmployeeIdList") = gcEmployeeIdList
                .Item("cUserId") = gcUserId
                .Item("cLangId") = gcLangId
                .Item("cEncryptionKey") = gcEncryptionKey
                .Item("lExportToExcel") = False
            End With

            R_Utility.R_SetStreamingContext(loPar)
            loRtn = loStreamingService.getReportData()

            loTemp = R_StreamUtility(Of Byte()).ReadFromMessage(loRtn)
            loResult = R_Utility.R_CombineData(Of PYR12100ReportDTO)(loTemp)

            For Each a As PYR12100ReportDTO In loResult
                If a IsNot Nothing Then
                    loFinish.Add(a)
                Else
                    Exit For
                End If
            Next

            'For I = 1 To 5
            '    loFinish.Add(New PYR12100ReportDTO With {.CEMPLOYEE_ID = "CT-2017-10-0002",
            '                                             .CEMPLOYEE_NAME = "Bambang" + I.ToString,
            '                                             .CGROUP_CODE = "G001",
            '                                             .CGROUP_DESCRIPTION = "SALARY GROUP",
            '                                             .CLOCATION_ID = "LOC_001",
            '                                             .CLOCATION_DESCRIPTION = "Jakarta Head Office",
            '                                             .R01C01LABEL = "Basic Salary",
            '                                              .R01C02LABEL = "Tunjangan Pajak",
            '                                              .R01C03LABEL = "Basic Salary",
            '                                              .R01C04LABEL = "Basic Salary",
            '                                              .R01C05LABEL = "Basic Salary",
            '                                              .R01C06LABEL = "Basic Salary",
            '                                              .R01C07LABEL = "Basic Salary",
            '                                              .R01C08LABEL = "Basic Salary",
            '                                              .R01C09LABEL = "Basic Salary",
            '                                              .R01C10LABEL = "Basic Salary",
            '                                              .R01C11LABEL = "Basic Salary",
            '                                              .R02C01LABEL = "Basic Salary",
            '                                             .R01C01VALUE = "111",
            '                                              .R01C02VALUE = "APA AJA",
            '                                              .R01C03VALUE = "123APA AJA"
            '                                            })
            'Next

            'For I = 1 To 5
            '    loFinish.Add(New PYR12100ReportDTO With {.CEMPLOYEE_ID = "PT-2016-01-000004",
            '                                             .CEMPLOYEE_NAME = "Toni" + I.ToString,
            '                                             .CGROUP_CODE = "G002",
            '                                             .CGROUP_DESCRIPTION = "SALARY GROUP 2",
            '                                             .CLOCATION_ID = "LOC_001",
            '                                             .CLOCATION_DESCRIPTION = "Jakarta Head Office",
            '                                             .R01C01LABEL = "Basic Salary",
            '                                              .R01C02LABEL = "Tunjangan Pajak",
            '                                              .R01C03LABEL = "Basic Salary",
            '                                              .R01C04LABEL = "Basic Salary",
            '                                              .R01C05LABEL = "Basic Salary",
            '                                              .R01C06LABEL = "Basic Salary",
            '                                              .R01C07LABEL = "Basic Salary",
            '                                              .R01C08LABEL = "Basic Salary",
            '                                              .R01C09LABEL = "Basic Salary",
            '                                              .R01C10LABEL = "Basic Salary",
            '                                              .R01C11LABEL = "Basic Salary",
            '                                              .R01C12LABEL = "Basic Salary",
            '                                              .R02C01LABEL = "Basic Salary",
            '                                             .R01C01VALUE = "112"
            '                                            })
            'Next

            'For I = 1 To 5
            '    loFinish.Add(New PYR12100ReportDTO With {.CPERIOD = "2017-02",
            '                                              .CEMPLOYEE_ID = "TEST" + I.ToString,
            '                                              .CEMPLOYEE_NAME = "TESTNAME" + I.ToString,
            '                                              .CGROUP_CODE = "G001",
            '                                              .CGROUP_DESCRIPTION = "SALARY GROUP",
            '                                              .CLOCATION_DESCRIPTION = "Jakarta Head Office",
            '                                              .CPOSITION_DESCRIPTION = "Public Relation Manager",
            '                                              .CPREVIOUS_TAX_OFFICE_ID = "01.106.721.6-902.000",
            '                                              .CPREVIOUS_TAX_OFFICE_DESCRIPTION = "KPP Jakarta Pusat",
            '                                              .CNEW_TAX_OFFICE_ID = "01.106.734.6-907.001",
            '                                              .CNEW_TAX_OFFICE_DESCRIPTION = "KPP Surabaya"
            '                                             })
            'Next

            'For I = 1 To 5
            '    loFinish.Add(New PYR12100ReportDTO With {.CPERIOD = "2017-03",
            '                                             .CEMPLOYEE_ID = "TEST" + I.ToString,
            '                                             .CEMPLOYEE_NAME = "TESTNAME" + I.ToString,
            '                                             .CGROUP_CODE = "G001",
            '                                             .CGROUP_DESCRIPTION = "SALARY GROUP",
            '                                             .CLOCATION_DESCRIPTION = "Jakarta Head Office",
            '                                             .CPOSITION_DESCRIPTION = "Public Relation Manager",
            '                                             .CPREVIOUS_TAX_OFFICE_ID = "01.106.721.6-902.000",
            '                                             .CPREVIOUS_TAX_OFFICE_DESCRIPTION = "KPP Jakarta Pusat",
            '                                             .CNEW_TAX_OFFICE_ID = "01.106.734.6-907.001",
            '                                             .CNEW_TAX_OFFICE_DESCRIPTION = "KPP Surabaya"
            '                                            })
            'Next

            poData = loFinish
            loStreamingService.Close()

        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loEx.Add(ex)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            loEx.ThrowExceptionIfErrors()
        End If

    End Sub

    Private Sub cryOptBtn_R_InstantiateReport(ByRef poTargetReport As CrystalDecisions.CrystalReports.Engine.ReportDocument) Handles cryOptBtn.R_InstantiateReport
        Dim loStreamingService As PYR12100StreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IPYR12100StreamingService, PYR12100StreamingServiceClient)(e_ServiceClientType.StreamingService, C_StreamingServiceName)
        Dim lcReportSize As String

        lcReportSize = loStreamingService.getReportSize(gcCompId)

        Dim LoadReportDoc As New ReportDocument

        Select Case lcReportSize
            Case "7"
                LoadReportDoc.Load(U_GlobalVar.DTO.cReportFilePath + "\PYR12100ReportA4.rpt")
            Case "10"
                LoadReportDoc.Load(U_GlobalVar.DTO.cReportFilePath + "\PYR12100ReportUS.rpt")
            Case "11"
                LoadReportDoc.Load(U_GlobalVar.DTO.cReportFilePath + "\PYR12100ReportA3.rpt")
        End Select
        poTargetReport = LoadReportDoc

        cryOptBtn.R_ReportTitle = R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "_CashAndTransferReport")

    End Sub

    Private Sub cryOptBtn_R_Prepare(ByRef plCancel As Boolean, poErrorList As R_Common.R_Exception) Handles cryOptBtn.R_Prepare
        Dim loEx As New R_Exception

        gcSalaryGroupList = ""
        gcEmployeeIdList = ""
        gcProcessList = ""

        If cmbFrom.SelectedValue > cmbTo.SelectedValue Then
            loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS002"))
        End If

        'GRUP GAJI
        If bsSalaryGroup.Current IsNot Nothing Then
            gcSalaryGroupList = ""
            Dim loEmpTemp As New List(Of PYR12100DTO)

            loEmpTemp = bsSalaryGroup.DataSource
            For Each a In loEmpTemp
                If a._lCheck Then
                    gcSalaryGroupList = gcSalaryGroupList + a._cGroupCode.Trim + ","
                End If
            Next
        End If


        If Not String.IsNullOrWhiteSpace(gcSalaryGroupList) Then
            gcSalaryGroupList = Microsoft.VisualBasic.Left(gcSalaryGroupList, Len(gcSalaryGroupList) - 1)
        Else
            loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS001"))
        End If

        'PROCESS
        If bsProcess.Current IsNot Nothing Then
            gcProcessList = ""
            Dim loEmpTemp As New List(Of PYR12100DTO)

            loEmpTemp = bsProcess.DataSource
            For Each a In loEmpTemp
                If a._lCheck Then
                    gcProcessList = gcProcessList + a._cProcessCode.Trim + ","
                End If
            Next
        End If

        If Not String.IsNullOrWhiteSpace(gcProcessList) Then
            gcProcessList = Microsoft.VisualBasic.Left(gcProcessList, Len(gcProcessList) - 1)
        Else
            loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS004"))
        End If

        If glSelectEmployee Then
            'EMPLOYEE
            If bsEmployeeGrid.Current IsNot Nothing Then
                Dim loEmpTemp As New List(Of PYR12100DTO)

                loEmpTemp = bsEmployeeGrid.DataSource
                'Untuk menentukan Hanya Data yang checked di grid yang akan diPRINT
                For Each a In loEmpTemp
                    gcEmployeeIdList = gcEmployeeIdList + a._CEMPLOYEE_ID.Trim + ","
                Next
                If Not String.IsNullOrWhiteSpace(gcEmployeeIdList) Then
                    gcEmployeeIdList = Microsoft.VisualBasic.Left(gcEmployeeIdList, Len(gcEmployeeIdList) - 1)
                Else
                    loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS003"))
                End If
            Else
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS003"))
            End If
        End If

        If loEx.Haserror Then
            plCancel = True
            Me.R_DisplayException(loEx)
        End If

    End Sub

    Private Sub cryOptBtn_R_SetParameter(ByRef poReport As CrystalDecisions.CrystalReports.Engine.ReportDocument) Handles cryOptBtn.R_SetParameter
        poReport.SetParameterValue("PERIOD", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "PERIOD"))
        poReport.SetParameterValue("GROUPBY", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "GROUPBY"))

        'poReport.SetParameterValue("@GROUPBYPARAM", IIf(rbSalaryGroup.IsChecked, rbSalaryGroup.Text, IIf(rbDept.IsChecked, rbDept.Text, IIf(rbKpp.IsChecked, rbKpp.Text, rbLocation.Text))))
        If rbSalaryGroup.IsChecked Then
            poReport.SetParameterValue("@GROUPBYPARAM", rbSalaryGroup.Text)
        ElseIf rbDept.IsChecked Then
            poReport.SetParameterValue("@GROUPBYPARAM", rbDept.Text)
        ElseIf rbLocation.IsChecked Then
            poReport.SetParameterValue("@GROUPBYPARAM", rbLocation.Text)
        ElseIf rbKpp.IsChecked Then
            poReport.SetParameterValue("@GROUPBYPARAM", rbKpp.Text)
        ElseIf rbCostCenter.IsChecked Then
            poReport.SetParameterValue("@GROUPBYPARAM", rbCostCenter.Text)
        End If

        'poReport.SetParameterValue("GROUP_BY", IIf(rbSalaryGroup.IsChecked, "GROUP", IIf(rbDept.IsChecked, "DEPT", IIf(rbKpp.IsChecked, "KPP", "LOCATION"))))
        If rbSalaryGroup.IsChecked Then
            poReport.SetParameterValue("GROUP_BY", "GROUP")
        ElseIf rbDept.IsChecked Then
            poReport.SetParameterValue("GROUP_BY", "DEPT")
        ElseIf rbLocation.IsChecked Then
            poReport.SetParameterValue("GROUP_BY", "LOCATION")
        ElseIf rbKpp.IsChecked Then
            poReport.SetParameterValue("GROUP_BY", "KPP")
        ElseIf rbCostCenter.IsChecked Then
            poReport.SetParameterValue("GROUP_BY", "COST CENTER")
        End If

        poReport.SetParameterValue("@PERIODPARAM", cmbFrom.SelectedValue + " To " + cmbTo.SelectedValue)

        poReport.SetParameterValue("EmployeeId", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "EmployeeId"))
        poReport.SetParameterValue("EmployeeName", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "EmployeeName"))

        'poReport.SetParameterValue("EMPLOYEE", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "EMPLOYEE"))
        'poReport.SetParameterValue("SALARYGROUP", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "SALARYGROUP"))
        'poReport.SetParameterValue("LOCATION", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "LOCATION"))
        'poReport.SetParameterValue("POSITION", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "POSITION"))
        'poReport.SetParameterValue("PREVTAXOFFICE", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "PREVTAXOFFICE"))
        'poReport.SetParameterValue("NEWTAXOFFICE", R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "NEWTAXOFFICE"))
    End Sub

    Private Sub cryOptBtn_R_SetSubReportParameter(ByRef poMainReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, pcSubReportName As String) Handles cryOptBtn.R_SetSubReportParameter
        poMainReport.SetParameterValue("Pm-@COMPANY", U_GlobalVar.CompanyName)
        poMainReport.SetParameterValue("Pm-@PRINTEDBY", gcUserId)
        poMainReport.SetParameterValue("Pm-@REPORTNAME", "Cash and Transfer Report")
        poMainReport.SetParameterValue("Pm-@LOGO", My.Application.Info.DirectoryPath + "\Image\" + U_GlobalVar.DTO.cCompanyLogoFilePath)

        poMainReport.SetParameterValue("@CURRENTDATE", DateTime.Now, pcSubReportName)
        poMainReport.SetParameterValue("@DATEPARAM", Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern, pcSubReportName)
        poMainReport.SetParameterValue("@CURRENTTIME", DateTime.Now, pcSubReportName)
        poMainReport.SetParameterValue("@TIMEPARAM", Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern, pcSubReportName)
        poMainReport.SetParameterValue("@PROGRAMID", U_GlobalVar.PrgId)
    End Sub

#End Region

    Private Sub cmbFrom_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbFrom.SelectedValueChanged
        Dim loEx As New R_Exception
        If Not String.IsNullOrWhiteSpace(cmbFrom.SelectedValue) And Not String.IsNullOrWhiteSpace(cmbTo.SelectedValue) Then
            If cmbFrom.SelectedValue > cmbTo.SelectedValue Then
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS002"))
            End If
        End If

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub cmbTo_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbTo.SelectedValueChanged
        Dim loEx As New R_Exception
        If Not String.IsNullOrWhiteSpace(cmbFrom.SelectedValue) And Not String.IsNullOrWhiteSpace(cmbTo.SelectedValue) Then
            If cmbFrom.SelectedValue > cmbTo.SelectedValue Then
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS002"))
            End If
        End If
        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        Dim loStreamingService As PYR12100StreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IPYR12100StreamingService, PYR12100StreamingServiceClient)(e_ServiceClientType.StreamingService, C_StreamingServiceName)
        Dim loTemp As IEnumerable(Of Byte())
        Dim loEx As New R_Exception()
        Dim loRtn As Message
        Dim loFinish As New List(Of PYR12100ExcelDTO)
        Dim loResult As List(Of PYR12100ExcelDTO)
        Dim svfd As New Windows.Forms.SaveFileDialog
        Try

            gcSalaryGroupList = ""
            gcEmployeeIdList = ""
            gcProcessList = ""
            giCountGroup = 0
            giCountProcessCode = 0

            If cmbFrom.SelectedValue > cmbTo.SelectedValue Then
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS002"))
            End If

            'GRUP GAJI
            If bsSalaryGroup.Current IsNot Nothing Then
                gcSalaryGroupList = ""
                Dim loEmpTemp As New List(Of PYR12100DTO)

                loEmpTemp = bsSalaryGroup.DataSource
                For Each a In loEmpTemp
                    If a._lCheck Then
                        giCountGroup += 1
                        gcSalaryGroupList = gcSalaryGroupList + a._cGroupCode.Trim + ","
                    End If
                Next
            End If

            If Not String.IsNullOrWhiteSpace(gcSalaryGroupList) Then
                gcSalaryGroupList = Microsoft.VisualBasic.Left(gcSalaryGroupList, Len(gcSalaryGroupList) - 1)
            Else
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS001"))
            End If

            'PROCESS
            If bsProcess.Current IsNot Nothing Then
                gcProcessList = ""
                Dim loEmpTemp As New List(Of PYR12100DTO)

                loEmpTemp = bsProcess.DataSource
                For Each a In loEmpTemp
                    If a._lCheck Then
                        giCountProcessCode += 1
                        gcProcessList = gcProcessList + a._cProcessCode.Trim + ","
                    End If
                Next
            End If

            If Not String.IsNullOrWhiteSpace(gcProcessList) Then
                gcProcessList = Microsoft.VisualBasic.Left(gcProcessList, Len(gcProcessList) - 1)
            Else
                loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS004"))
            End If

            If glSelectEmployee Then
                'EMPLOYEE
                If bsEmployeeGrid.Current IsNot Nothing Then
                    Dim loEmpTemp As New List(Of PYR12100DTO)

                    loEmpTemp = bsEmployeeGrid.DataSource
                    'Untuk menentukan Hanya Data yang checked di grid yang akan diPRINT
                    For Each a In loEmpTemp

                        gcEmployeeIdList = gcEmployeeIdList + a._CEMPLOYEE_ID.Trim + ","
                    Next
                    If Not String.IsNullOrWhiteSpace(gcEmployeeIdList) Then
                        gcEmployeeIdList = Microsoft.VisualBasic.Left(gcEmployeeIdList, Len(gcEmployeeIdList) - 1)
                    Else
                        loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS003"))
                    End If
                Else
                    loEx.Add(R_Utility.R_GetError(GetType(Resources_Dummy_Class), "PS003"))
                End If
            End If

            If loEx.Haserror Then
                Exit Try
            End If

            Dim lcGroupBy As String

            If rbSalaryGroup.IsChecked Then
                lcGroupBy = rbSalaryGroup.Text
            ElseIf rbDept.IsChecked Then
                lcGroupBy = rbDept.Text
            ElseIf rbLocation.IsChecked Then
                lcGroupBy = rbLocation.Text
            ElseIf rbKpp.IsChecked Then
                lcGroupBy = rbKpp.Text
            ElseIf rbCostCenter.IsChecked Then
                lcGroupBy = rbCostCenter.Text
            End If

            svfd.InitialDirectory = My.Application.Info.DirectoryPath
            svfd.FileName = Parent.Text + "_" + lcGroupBy + "_" + IIf(rbDetail.IsChecked, rbDetail.Text, rbSummary.Text) + IIf(giCountGroup = 1, "_" + gcSalaryGroupList, "") + IIf(giCountProcessCode = 1, "_" + gcProcessList, "") + "_" + String.Format("{0:00}", Today.Day) + Today.Month.ToString + Today.Year.ToString
            svfd.Filter = "Excel Worksheets|*.xlsx|Excel 97-2003 Worksheet|*.xls"
            If svfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim loPar As New Dictionary(Of String, Object)

                With loPar
                    .Item("cCompanyId") = gcCompId
                    .Item("cFromIndex") = cmbFrom.SelectedValue
                    .Item("cToIndex") = cmbTo.SelectedValue
                    .Item("cGroupCode") = gcSalaryGroupList
                    .Item("cProcessCode") = gcProcessList
                    .Item("cEmployeeStatusType") = IIf(rdbSelectAll.IsChecked, "1", IIf(rbActive.IsChecked, "2", IIf(rbResign.IsChecked, "3", "4")))
                    .Item("lSelectEmployee") = glSelectEmployee
                    .Item("cSalaryValueMode") = IIf(rbDetail.IsChecked, "D", "S")
                    .Item("cEmployeeIdList") = gcEmployeeIdList
                    .Item("cUserId") = gcUserId
                    .Item("cLangId") = gcLangId
                    .Item("cEncryptionKey") = gcEncryptionKey
                    .Item("lExportToExcel") = True
                End With

                R_Utility.R_SetStreamingContext(loPar)
                loRtn = loStreamingService.getExportExcelData

                loTemp = R_StreamUtility(Of Byte()).ReadFromMessage(loRtn)
                loResult = R_Utility.R_CombineData(Of PYR12100ExcelDTO)(loTemp)

                For Each a As PYR12100ExcelDTO In loResult
                    If a IsNot Nothing Then
                        loFinish.Add(a)
                    Else
                        Exit For
                    End If
                Next

                Dim loTableReturn As DataTable
                Dim loDataSet = New DataSet

                loTableReturn = R_Utility.R_ConvertTo(Of PYR12100ExcelDTO)(loFinish, False)
                loTableReturn.TableName = "Cash and Transfer"

                loDataSet.Tables.Add(loTableReturn)
                R_Excel.R_WriteToExcel(loTableReturn, svfd.FileName, True, False, False, 1, 1)

                loStreamingService.Close()

                R_RadMessageBox.Show(R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "_ProcessSuccess"),
                                   R_Utility.R_GetMessage(GetType(Resources_Dummy_Class), "_Message"),
                                   Windows.Forms.MessageBoxButtons.OK)
            End If



        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loEx.Add(ex)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub svfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)
      
    End Sub
End Class
