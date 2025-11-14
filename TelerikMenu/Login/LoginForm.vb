Imports TelerikMenu.LoginServiceRef
Imports R_Common
Imports ClientHelper
Imports R_FrontEnd
Imports System.ServiceModel
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports System.IO
Imports Microsoft.Win32
Imports System.Globalization

Public Class LoginForm

#Region "VARIABLE"
    Private Const C_ServiceName As String = "LoginService/LoginService.svc"
    Public Const WM_SIZE As Integer = 5
    Private titleBar As RadTitleBarElement
    Private _oParameter As R_SecurityPolicyParameterDTO
    Public lcMessageToShowInMenu As String = ""
    Private _cDefaultLang As String = ""
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'hide title bar
        Me.FormElement.TitleBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

        'set application icon
        Dim lcIcon As String = ConfigurationManager.AppSettings("ImgIcon").ToString()
        Dim lcIconPath As String = Application.StartupPath + "\Image\" + lcIcon
        If IO.File.Exists(lcIconPath) Then
            Me.Icon = New Icon(lcIconPath)
        Else
            Me.Icon = My.Resources.icon
        End If

        'set panel background to transparent
        Me.panelTitle.BackColor = Color.Transparent

        'add custom titlebar
        PrepareTitleBar()

        'set panel border to transparent
        CType(Me.panelTitle.PanelElement.Children(1), BorderPrimitive).ForeColor = Color.Transparent

        'set backColor form to transparent
        Me.BackColor = Color.White

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.R_HelpFile = "First_Topic" 'set help page
    End Sub

    Private Sub rrbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rrbOK.Click
        Dim loService As LoginServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of ILoginService, LoginServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loException As New R_Exception()
        Dim loInitiator As IInitiator = New U_GlobalVar
        Dim loLoginDTO As New LoginDTO
        Dim loRtn As New LoginDTO
        Dim lCheck As Boolean = True
        Dim lcAppId As String

        Try
            'Set Computer ID, supaya dikenal di internal context server
            loInitiator.Set_ComputerId()

            'get Default language untuk pengaturan bahasa di login
            Dim oCulture As eCulture = eCulture.English
            _cDefaultLang = ConfigurationManager.AppSettings("R_DefaultLanguage")
            If Not String.IsNullOrWhiteSpace(_cDefaultLang) Then
                oCulture = R_Culture.R_GetCultureEnum(_cDefaultLang.ToLower)
            End If
            loInitiator.Set_CultureMenu(oCulture)

            'set Application ID
            lcAppId = ConfigurationManager.AppSettings("R_ApplicationID")
            If String.IsNullOrWhiteSpace(lcAppId) Then
                Throw New Exception(R_Utility.R_GetError(Me.GetType, "Err011", New CultureInfo(_cDefaultLang)).ErrDescp)
            End If
            loInitiator.Set_ApplicationID(lcAppId)

            loLoginDTO = New LoginDTO With {.CUSER_ID = rrtbUserId.Text.Trim.ToLower,
                                            .CUSER_PASSWORD = rrtbPassword.Text.Trim,
                                            .CCOMPANY_ID = IIf(rrtbCompanyId.Visible, rrtbCompanyId.Text.Trim, "")}

            'VALIDATE FIELD
            ValidateField(loLoginDTO)

            'CHECK IF DEVELOPING
            'lCheck = cekReg()

            'security policy
            R_FrontEnd.R_SecurityPolicyClient.R_SecurityPolicyLogin(_oParameter, IIf(rrtbCompanyId.Visible, rrtbCompanyId.Text.Trim, ""), rrtbUserId.Text.Trim.ToLower, rrtbPassword.Text.Trim, lcAppId)

            If Not lCheck Then
                'CHECK LICENSE & ACTIVATION
                Dim loReturnCheckLicense As R_LicenseActivationResult

                loReturnCheckLicense = R_FrontEnd.R_LicenseActivationClient.R_CheckLicense(lcAppId, IIf(rrtbCompanyId.Visible, rrtbCompanyId.Text.Trim, ""))
                If loReturnCheckLicense.IsSuccess = False Then
                    loException.Add("", loReturnCheckLicense.Exception)
                    Exit Try
                Else ' Success
                    If String.IsNullOrEmpty(loReturnCheckLicense.Exception) = False Then
                        loException.Add("", loReturnCheckLicense.Exception)
                    End If
                End If

                Dim loReturnCheckActivation As R_LicenseActivationResult
                loReturnCheckActivation = R_FrontEnd.R_LicenseActivationClient.R_CheckActivation(lcAppId, IIf(rrtbCompanyId.Visible, rrtbCompanyId.Text.Trim, ""))
                If loReturnCheckActivation.IsSuccess = False Then
                    loException.Add("", loReturnCheckActivation.Exception)
                    Exit Try
                Else ' Success
                    If loReturnCheckActivation.Exception IsNot Nothing Then
                        If loReturnCheckActivation.Exception.Contains("05") Then
                            lcMessageToShowInMenu = loReturnCheckActivation.Exception.Substring(3)
                        Else
                            loException.Add("", loReturnCheckActivation.Exception)
                        End If
                    End If
                End If
            End If

            loRtn = loService.Logon(loLoginDTO)

            'loService.Svc_R_UserLocking(loLoginDTO)

            'Set token
            If R_Context._GetServerContext(R_InternalContextVarEnumerator.ACCESS_TOKEN) IsNot Nothing Then
                R_Context._AccessToken = R_Context._GetServerContext(R_InternalContextVarEnumerator.ACCESS_TOKEN).ToString
            Else
                Throw New Exception(R_Utility.R_GetError(Me.GetType, "Err011").ErrDescp)
            End If

            'set global variable
            loInitiator.Set_CompId(loRtn.CCOMPANY_ID)
            loInitiator.Set_UserId(loRtn.CUSER_ID)
            loInitiator.Set_CompanyName(loRtn.CCOMPANY_NAME)
            loInitiator.Set_UserName(loRtn.CUSER_NAME)
            loInitiator.Set_DTO(getGlobalVar())

            'set culture
            If loRtn.CCULTURE_ID IsNot Nothing Then
                Dim leLoginCulture As eCulture

                leLoginCulture = R_Culture.R_GetCultureEnum(loRtn.CCULTURE_ID)

                loInitiator.Set_CultureUI(leLoginCulture)
                loInitiator.Set_ReportLanguage(leLoginCulture)
            Else
                loInitiator.Set_CultureUI(eCulture.English)
            End If

            'set number info
            Dim oNumberInfo As NumberFormatInfo = Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat
            If loRtn.CNUMBER_FORMAT IsNot Nothing Then
                With oNumberInfo
                    .NumberDecimalSeparator = loRtn.CNUMBER_FORMAT
                    .NumberGroupSeparator = IIf(loRtn.CNUMBER_FORMAT = ",", ".", ",")
                End With
            Else
                oNumberInfo = New NumberFormatInfo With {.NumberDecimalSeparator = ",",
                                                         .NumberGroupSeparator = "."}
            End If
            oNumberInfo.NumberDecimalDigits = loRtn.IDECIMAL_PLACES

            'set rounding
            Dim oRounding As R_eRoundingMethod
            If loRtn.CROUNDING_METHOD = "Up" Then
                oRounding = R_eRoundingMethod.Up
            ElseIf loRtn.CROUNDING_METHOD = "Down" Then
                oRounding = R_eRoundingMethod.Down
            Else
                oRounding = R_eRoundingMethod.UpDown
            End If
            loInitiator.Set_Rounding(loRtn.IROUNDING_PLACES, oRounding)

            'set date info
            Dim oDateInfo As DateTimeFormatInfo = Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat
            With oDateInfo
                If loRtn.CDATE_LONG_FORMAT IsNot Nothing Then .LongDatePattern = loRtn.CDATE_LONG_FORMAT Else .LongDatePattern = "MMMM d, yyyy"
                If loRtn.CDATE_SHORT_FORMAT IsNot Nothing Then .ShortDatePattern = loRtn.CDATE_SHORT_FORMAT Else .ShortDatePattern = "M/d/yy"
                If loRtn.CTIME_LONG_FORMAT IsNot Nothing Then .LongTimePattern = loRtn.CTIME_LONG_FORMAT Else .LongTimePattern = "hh:mm:ss tt"
                If loRtn.CTIME_SHORT_FORMAT IsNot Nothing Then .ShortTimePattern = loRtn.CTIME_SHORT_FORMAT Else .ShortTimePattern = "hh:mm tt"
            End With
            loInitiator.Set_CultureFormat(oNumberInfo, oDateInfo)

            'set Flag save confirmation
            loInitiator.Set_FlagSaveConfirm(loRtn.LENABLE_SAVE_CONFIRMATION)

            'set temporary path
            Dim lcTempPath As String
            lcTempPath = My.Application.Info.DirectoryPath + "\Temporary"
            If Directory.Exists(lcTempPath) = False Then
                Directory.CreateDirectory(lcTempPath)
            End If
            loInitiator.Set_TemporaryPath(lcTempPath)

            'For Pivot
            Dim loParameter As New SAM_USER_COMPANYDTO
            loParameter.CCOMPANY_ID = rrtbCompanyId.Text.ToString.Trim
            loParameter.CUSER_ID = rrtbUserId.Text.ToString.Trim
            loParameter.LCAN_BROADCAST = False
            loInitiator.Set_Broadcast(CType(loService.svc_getUserCompanyBroadcast(loParameter), SAM_USER_COMPANYDTO).LCAN_BROADCAST)

            'set encryption key
            If R_Context._GetServerContext(R_Context._GetKey(R_Context.eContextKey.EncryptKey)) IsNot Nothing Then
                loInitiator.Set_EncryptKey(R_Context._GetServerContext(R_Context._GetKey(R_Context.eContextKey.EncryptKey)).ToString)
            Else
                Throw New Exception(R_Utility.R_GetError(Me.GetType, "Err007").ErrDescp)
            End If
            loService.SetKey(R_GlobalVar.EncryptKey)

            'set license mode and license number
            loInitiator.Set_License(loRtn.CLICENSE_MODE, loRtn.NLICENSEE)

            'delete temporary folder for crystal class and email engine template
            DelTempFolder(loRtn.CUSER_ID.ToLower)

            'flush data on user id and company id
            'loService.doFlushData(loRtn.CUSER_ID.ToLower, loRtn.CCOMPANY_ID)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        Finally
            If loService IsNot Nothing Then
                If Not (loService.State = CommunicationState.Closed) Then
                    loService.Close()
                End If
                loService = Nothing
            End If
        End Try

        If loException.Haserror Then
            R_RadMessageBox.Show(loException.ErrorList(0).ErrDescp)
        End If
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim loEx As New R_Exception

        Try
            If waitBar.Visible = False Then
                waitBar.Visible = True
            End If
            waitBar.StartWaiting()

            Dim loArgs As ObjectModel.ReadOnlyCollection(Of String)
            loArgs = My.Application.CommandLineArgs()
            If loArgs.Count > 0 Then
                R_DeployUtility.R_InitFromLauncher(loArgs(0), loArgs(1))
            End If

            'set position adn size each control
            setPosControl()
            setSizeControl()

            ' Get Method to show from app.config 'R_Md'
            'Dim lcModul As String = Replace(Split(System.Configuration.ConfigurationManager.AppSettings("R_Md").ToString, ",")(0), "'", " ").Trim

            'set application icon
            Dim lcIcon As String = ConfigurationManager.AppSettings("ImgIcon").ToString()
            Dim lcIconPath As String = Application.StartupPath + "\Image\" + lcIcon
            If IO.File.Exists(lcIconPath) Then
                Me.Icon = New Icon(lcIconPath)
            Else
                Me.Icon = My.Resources.icon
            End If

            Dim lcBackground As String = ConfigurationManager.AppSettings("ImgBG_Login").ToString()
            Dim lcBGPath As String = Application.StartupPath + "\Image\" + lcBackground
            If IO.File.Exists(lcBGPath) Then
                Me.BackgroundImage = Image.FromFile(lcBGPath)
            Else
                Me.BackgroundImage = My.Resources.login '.GetThumbnailImage(120, 120, Nothing, New IntPtr())
            End If
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center

            'Jangan lupa delete
            'rrtbCompanyId.Text = "001"
            'rrtbUserId.Text = "cp"
            'rrtbPassword.Text = "cp"

            'set border textbox
            Dim oArrayConf As Array
            oArrayConf = ConfigurationManager.AppSettings("ColorBorderTxt").ToString.Split(",")
            setColorBorderTxt(Color.FromArgb(CInt(oArrayConf(0)), CInt(oArrayConf(1)), CInt(oArrayConf(2))))

            'set color button login
            lcBackground = ConfigurationManager.AppSettings("ImgBG_LoginBtn").ToString()
            lcBGPath = Application.StartupPath + "\Image\" + lcBackground
            If IO.File.Exists(lcBGPath) Then
                rrbOK.Image = Image.FromFile(lcBGPath)
            Else
                rrbOK.Image = My.Resources.btn_login
            End If
            rrbOK.TextImageRelation = TextImageRelation.ImageAboveText

            'set font type button
            CType(rrbOK.ButtonElement.Children(1).Children(1), TextPrimitive).Font = New Font("Myriad Pro", 11)

            'set font type
            oArrayConf = ConfigurationManager.AppSettings("SizeTypeFont").ToString.Split(",")
            setFontStyle(New Font(CStr(oArrayConf(0)), CInt(oArrayConf(1))))
            lblLink.Size = New Size(100, 18)

            'set font color
            oArrayConf = ConfigurationManager.AppSettings("ColorFont").ToString.Split(",")
            setColor(Color.FromArgb(CInt(oArrayConf(0)), CInt(oArrayConf(1)), CInt(oArrayConf(2))))

            'SY | SECURITY POLICY AND SHOW COMPANY AT LOGIN PARAMETER
            _oParameter = R_FrontEnd.R_SecurityPolicyClient.R_GetSecurityPolicyParameter()

            Dim loInitiator As IInitiator = New U_GlobalVar
            loInitiator.Set_SecurityParameter(_oParameter)

            If Not _oParameter.lChooseCompanyAtLoginPage Then
                lblCompID.Visible = False
                rrtbCompanyId.Text = ""
                rrtbCompanyId.Visible = False
            End If
            waitBar.StopWaiting()
            waitBar.Visible = False
        Catch ex As Exception
            loEx.Add(ex)
        Finally
            waitBar.StopWaiting()
        End Try

        If loEx.Haserror Then
            R_RadMessageBox.Show(loEx.ErrorList(0).ErrDescp)
        End If
    End Sub

#Region " INTERNAL METHOD "
#Region " SUB "
#Region " _loadCultures "
    Private Sub _loadCultures()
        Dim laNameValues As R_NameValue()

        laNameValues = R_Culture.R_GetAvailableCultures

        cbCulture.DisplayMember = "Name"
        cbCulture.ValueMember = "Value"
        cbCulture.DataSource = laNameValues
    End Sub
#End Region

#Region " cbCulture_SelectedIndexChanged "
    Private Sub cbCulture_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cbCulture.SelectedIndexChanged
        Dim loInitiator As IInitiator = New U_GlobalVar

        'loInitiator.Set_CultureFormat([Enum].Parse(GetType(eCulture), cbCulture.Text))
        loInitiator.Set_CultureUI([Enum].Parse(GetType(eCulture), cbCulture.Text))
    End Sub
#End Region

    Private Function getGlobalVar() As GlobalVarDTO
        Dim loEx As New R_Exception
        Dim loRtn As New GlobalVarDTO

        Try
            loRtn.cReportFilePath = My.Application.Info.DirectoryPath + "\Report"
            loRtn.cCompanyLogoFilePath = ConfigurationManager.AppSettings("U_CompanyLogoFilePath").ToString()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ThrowExceptionIfErrors()
        Return loRtn
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_SIZE Then
            titleBar.CloseButton.SetValue(RadFormElement.FormWindowStateProperty, Me.WindowState)
            titleBar.MinimizeButton.SetValue(RadFormElement.FormWindowStateProperty, Me.WindowState)
            titleBar.MaximizeButton.SetValue(RadFormElement.FormWindowStateProperty, Me.WindowState)
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub PrepareTitleBar()
        titleBar = New RadTitleBarElement()

        titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden
        titleBar.MaxSize = New Size(0, 30)
        titleBar.Children(1).Visibility = ElementVisibility.Hidden

        titleBar.CloseButton.Parent.PositionOffset = New SizeF(5, 2)
        titleBar.CloseButton.MinSize = New Size(30, 30)
        titleBar.CloseButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed

        titleBar.MinimizeButton.MinSize = New Size(30, 30)
        titleBar.MinimizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed
        titleBar.MinimizeButton.Visibility = ElementVisibility.Collapsed

        titleBar.MaximizeButton.MinSize = New Size(30, 30)
        titleBar.MaximizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed
        titleBar.MaximizeButton.Visibility = ElementVisibility.Collapsed

        titleBar.CloseButton.SetValue(RadFormElement.IsFormActiveProperty, True)
        titleBar.MinimizeButton.SetValue(RadFormElement.IsFormActiveProperty, True)
        titleBar.MaximizeButton.SetValue(RadFormElement.IsFormActiveProperty, True)

        AddHandler titleBar.Close, AddressOf titleBar_Close
        Me.panelTitle.PanelElement.Children.Add(titleBar)
    End Sub

    Private Sub ValidateField(poParam As LoginDTO)
        Dim loEx As New R_Exception()

        Try
            With poParam
                If String.IsNullOrEmpty(.CCOMPANY_ID) And lblCompID.Visible Then
                    loEx.Add(R_Utility.R_GetError(Me.GetType, "Err008", New CultureInfo(_cDefaultLang)))
                ElseIf String.IsNullOrEmpty(.CUSER_ID) Then
                    loEx.Add(R_Utility.R_GetError(Me.GetType, "Err009", New CultureInfo(_cDefaultLang)))
                ElseIf String.IsNullOrEmpty(.CUSER_PASSWORD) Then
                    loEx.Add(R_Utility.R_GetError(Me.GetType, "Err010", New CultureInfo(_cDefaultLang)))
                End If
            End With
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ThrowExceptionIfErrors()
    End Sub

    Public Sub sChangeCompany(ByVal pcUserId As String, ByVal pcCompanyId As String)
        rrtbCompanyId.Text = pcCompanyId
        rrtbUserId.Text = pcUserId
        rrtbPassword.Select()
    End Sub

    Private Sub DelTempFolder(pcUserName As String)
        Dim lcTempPath As String = U_GlobalVar.TemporaryPath
        Dim lcTempPathUser As String = lcTempPath + "\" + pcUserName + "_"

        If Directory.Exists(lcTempPath) Then
            Dim dirDel As New DirectoryInfo(lcTempPath)
            For Each b As FileInfo In dirDel.GetFiles()
                If b.Name.ToLower.Contains(pcUserName + "_") Then
                    b.Delete()
                End If
            Next
        End If
    End Sub

    Private Function cekReg() As Boolean
        Dim lRtn As Boolean = False
        Dim lcOldLicenseCode As String = ""

        'Get license code from registry
        Dim loLMSRegistryKey As RegistryKey
        loLMSRegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Realta\R_FrontEnd", False)
        If loLMSRegistryKey IsNot Nothing Then
            lcOldLicenseCode = loLMSRegistryKey.GetValue("R_SerialNo", "")
        End If

        lRtn = Not String.IsNullOrEmpty(lcOldLicenseCode)
        Return lRtn
    End Function

#Region "LOAD LAYOUT FROM APP CONFIG"
#Region "CUSTOM POSITION"
    Private Sub setPosControl()
        Dim oArrayConf As Array

        Try
            'set location for textbox
            oArrayConf = ConfigurationManager.AppSettings("PosUserTxtBox").ToString.Split(",")
            rrtbUserId.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            oArrayConf = ConfigurationManager.AppSettings("PosPassTxtBox").ToString.Split(",")
            rrtbPassword.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            oArrayConf = ConfigurationManager.AppSettings("PosCompTxtBox").ToString.Split(",")
            rrtbCompanyId.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            'set location for button
            oArrayConf = ConfigurationManager.AppSettings("PosOKBtn").ToString.Split(",")
            rrbOK.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            'set location for label
            oArrayConf = ConfigurationManager.AppSettings("PosUserlbl").ToString.Split(",")
            lblUserID.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            oArrayConf = ConfigurationManager.AppSettings("PosPasslbl").ToString.Split(",")
            lblPass.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            oArrayConf = ConfigurationManager.AppSettings("PosComplbl").ToString.Split(",")
            lblCompID.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            oArrayConf = ConfigurationManager.AppSettings("PosLinklbl").ToString.Split(",")
            lblLink.Location = New Point(CInt(oArrayConf(0)), CInt(oArrayConf(1)))
        Catch ex As Exception

        End Try

    End Sub
#End Region
#Region "CUSTOM SIZE"
    Private Sub setSizeControl()
        Dim oArrayConf As Array

        Try
            oArrayConf = ConfigurationManager.AppSettings("SizeOKBtn").ToString.Split(",")
            rrbOK.Size = New Size(CInt(oArrayConf(0)), CInt(oArrayConf(1)))

            oArrayConf = ConfigurationManager.AppSettings("SizeLoginForm").ToString.Split(",")
            Me.MinimumSize = New Size(CInt(oArrayConf(0)), CInt(oArrayConf(1)))
            Me.MaximumSize = New Size(CInt(oArrayConf(0)), CInt(oArrayConf(1)))
            Me.Size = New Size(CInt(oArrayConf(0)), CInt(oArrayConf(1)))
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "CUSTOM COLOR, FONT STYLE, AND BORDER TEXT"
    Private Sub setColor(poColor As Color)
        lblPass.ForeColor = poColor
        lblLink.ForeColor = poColor
        lblUserID.ForeColor = poColor
        lblCompID.ForeColor = poColor

        'set transparent all label
        lblPass.BackColor = Color.Transparent
        lblLink.BackColor = Color.Transparent
        lblUserID.BackColor = Color.Transparent
        lblCompID.BackColor = Color.Transparent
    End Sub

    Private Sub setFontStyle(poFont As Font)
        lblCompID.Font = poFont
        lblUserID.Font = poFont
        lblPass.Font = poFont
        lblLink.Font = poFont
    End Sub

    Private Sub setColorBorderTxt(poColor As Color)
        CType(rrtbCompanyId.TextBoxElement.Children(2), BorderPrimitive).ForeColor = poColor
        CType(rrtbUserId.TextBoxElement.Children(2), BorderPrimitive).ForeColor = poColor
        CType(rrtbPassword.TextBoxElement.Children(1), BorderPrimitive).ForeColor = poColor
    End Sub
#End Region
#End Region
#End Region
#End Region

#Region "EVENT HANDLER"
    Private Sub titleBar_Close(ByVal sender As Object, ByVal args As EventArgs)
        Application.Exit()
    End Sub

#Region "BUTTON OK"
    Private Sub rrbOK_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles rrbOK.MouseDown
        Dim lcBackground As String = ConfigurationManager.AppSettings("ImgBG_LoginBtnHover").ToString()
        Dim lcBGPath As String = Application.StartupPath + "\Image\" + lcBackground
        If IO.File.Exists(lcBGPath) Then
            rrbOK.Image = Image.FromFile(lcBGPath)
        Else
            rrbOK.Image = My.Resources.btn_login_press
        End If
    End Sub

    Private Sub rrbOK_MouseEnter(sender As Object, e As System.EventArgs) Handles rrbOK.MouseEnter
        Dim lcBackground As String = ConfigurationManager.AppSettings("ImgBG_LoginBtnPress").ToString()
        Dim lcBGPath As String = Application.StartupPath + "\Image\" + lcBackground
        If IO.File.Exists(lcBGPath) Then
            rrbOK.Image = Image.FromFile(lcBGPath)
        Else
            rrbOK.Image = My.Resources.btn_login_hover
        End If
    End Sub

    Private Sub rrbOK_MouseLeave(sender As Object, e As System.EventArgs) Handles rrbOK.MouseLeave
        Dim lcBackground As String = ConfigurationManager.AppSettings("ImgBG_LoginBtn").ToString()
        Dim lcBGPath As String = Application.StartupPath + "\Image\" + lcBackground
        If IO.File.Exists(lcBGPath) Then
            rrbOK.Image = Image.FromFile(lcBGPath)
        Else
            rrbOK.Image = My.Resources.btn_login
        End If
    End Sub

    Private Sub rrbOK_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles rrbOK.MouseUp
        Dim lcBackground As String = ConfigurationManager.AppSettings("ImgBG_LoginBtn").ToString()
        Dim lcBGPath As String = Application.StartupPath + "\Image\" + lcBackground
        If IO.File.Exists(lcBGPath) Then
            rrbOK.Image = Image.FromFile(lcBGPath)
        Else
            rrbOK.Image = My.Resources.btn_login
        End If
    End Sub
#End Region

#Region "LABEL LINK"
    Private Sub lblLink_Click(sender As System.Object, e As System.EventArgs) Handles lblLink.Click
        System.Diagnostics.Process.Start(lblLink.Text)
    End Sub

    Private Sub lblLink_MouseEnter(sender As Object, e As System.EventArgs) Handles lblLink.MouseEnter
        lblLink.ForeColor = Color.FromArgb(15, 46, 126)
    End Sub

    Private Sub lblLink_MouseLeave(sender As Object, e As System.EventArgs) Handles lblLink.MouseLeave
        lblLink.ForeColor = Color.FromArgb(133, 133, 133)
    End Sub
#End Region
#End Region

    '<Serializable()> _
    'Public Class oNewLoginDTO
    '    Inherits LoginDTO
    '    Public Property UserId As String
    '    Public Property CompId As String

    '    Public Sub New()

    '    End Sub
    'End Class
End Class