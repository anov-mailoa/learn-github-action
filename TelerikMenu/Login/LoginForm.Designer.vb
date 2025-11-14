<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits R_FrontEnd.R_FormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rrbOK = New R_FrontEnd.R_RadButton(Me.components)
        Me.rrtbCompanyId = New R_FrontEnd.R_RadTextBox(Me.components)
        Me.rrtbUserId = New R_FrontEnd.R_RadTextBox(Me.components)
        Me.cbCulture = New R_FrontEnd.R_RadDropDownList(Me.components)
        Me.panelTitle = New Telerik.WinControls.UI.RadPanel()
        Me.lblCompID = New R_FrontEnd.R_RadLabel(Me.components)
        Me.lblUserID = New R_FrontEnd.R_RadLabel(Me.components)
        Me.lblPass = New R_FrontEnd.R_RadLabel(Me.components)
        Me.lblLink = New Telerik.WinControls.UI.RadLabel()
        Me.rrtbPassword = New R_FrontEnd.R_RadPasswordBox()
        Me.errProvider = New R_FrontEnd.R_ErrorProvider(Me.components)
        Me.waitBar = New Telerik.WinControls.UI.RadWaitingBar()
        CType(Me.rrbOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rrtbCompanyId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rrtbUserId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCulture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCompID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rrtbPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.waitBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rrbOK
        '
        Me.rrbOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rrbOK.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rrbOK.ForeColor = System.Drawing.Color.Silver
        Me.rrbOK.Location = New System.Drawing.Point(385, 267)
        Me.rrbOK.Margin = New System.Windows.Forms.Padding(0)
        Me.rrbOK.Name = "rrbOK"
        Me.rrbOK.R_ConductorGridSource = Nothing
        Me.rrbOK.R_ConductorSource = Nothing
        Me.rrbOK.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Caption
        Me.rrbOK.R_ResourceId = Nothing
        Me.rrbOK.Size = New System.Drawing.Size(250, 35)
        Me.rrbOK.TabIndex = 0
        Me.rrbOK.Text = "Login"
        CType(Me.rrbOK.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Login"
        CType(Me.rrbOK.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ButtonFace
        CType(Me.rrbOK.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ButtonFace
        CType(Me.rrbOK.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ButtonFace
        CType(Me.rrbOK.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.SystemColors.ActiveBorder
        CType(Me.rrbOK.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.ButtonFace
        '
        'rrtbCompanyId
        '
        Me.rrtbCompanyId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rrtbCompanyId.Location = New System.Drawing.Point(385, 148)
        Me.rrtbCompanyId.Name = "rrtbCompanyId"
        Me.rrtbCompanyId.R_ConductorGridSource = Nothing
        Me.rrtbCompanyId.R_ConductorSource = Nothing
        Me.rrtbCompanyId.R_UDT = Nothing
        Me.rrtbCompanyId.Size = New System.Drawing.Size(250, 27)
        Me.rrtbCompanyId.TabIndex = 1
        '
        'rrtbUserId
        '
        Me.rrtbUserId.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.rrtbUserId.Location = New System.Drawing.Point(385, 181)
        Me.rrtbUserId.Name = "rrtbUserId"
        Me.rrtbUserId.R_ConductorGridSource = Nothing
        Me.rrtbUserId.R_ConductorSource = Nothing
        Me.rrtbUserId.R_UDT = Nothing
        Me.rrtbUserId.Size = New System.Drawing.Size(250, 27)
        Me.rrtbUserId.TabIndex = 2
        '
        'cbCulture
        '
        Me.cbCulture.AutoCompleteDisplayMember = Nothing
        Me.cbCulture.AutoCompleteValueMember = Nothing
        Me.cbCulture.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.cbCulture.Location = New System.Drawing.Point(385, 122)
        Me.cbCulture.Name = "cbCulture"
        Me.cbCulture.R_ConductorGridSource = Nothing
        Me.cbCulture.R_ConductorSource = Nothing
        Me.cbCulture.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.cbCulture.Size = New System.Drawing.Size(250, 20)
        Me.cbCulture.TabIndex = 4
        Me.cbCulture.Visible = False
        '
        'panelTitle
        '
        Me.panelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitle.Location = New System.Drawing.Point(0, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(698, 91)
        Me.panelTitle.TabIndex = 5
        '
        'lblCompID
        '
        Me.lblCompID.AutoSize = False
        Me.lblCompID.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblCompID.Location = New System.Drawing.Point(267, 148)
        Me.lblCompID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCompID.Name = "lblCompID"
        Me.lblCompID.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.lblCompID.R_ResourceId = Nothing
        Me.lblCompID.Size = New System.Drawing.Size(112, 27)
        Me.lblCompID.TabIndex = 6
        Me.lblCompID.Text = "Company ID :"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = False
        Me.lblUserID.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblUserID.Location = New System.Drawing.Point(267, 181)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.lblUserID.R_ResourceId = Nothing
        Me.lblUserID.Size = New System.Drawing.Size(100, 27)
        Me.lblUserID.TabIndex = 7
        Me.lblUserID.Text = "User ID :"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = False
        Me.lblPass.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblPass.Location = New System.Drawing.Point(267, 214)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.lblPass.R_ResourceId = Nothing
        Me.lblPass.Size = New System.Drawing.Size(100, 27)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Password :"
        '
        'lblLink
        '
        Me.lblLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLink.Location = New System.Drawing.Point(469, 400)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(87, 18)
        Me.lblLink.TabIndex = 9
        Me.lblLink.Text = "www.realta.co.id"
        '
        'rrtbPassword
        '
        Me.rrtbPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.rrtbPassword.Location = New System.Drawing.Point(385, 212)
        Me.rrtbPassword.Name = "rrtbPassword"
        Me.rrtbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.rrtbPassword.R_ConductorGridSource = Nothing
        Me.rrtbPassword.R_ConductorSource = Nothing
        Me.rrtbPassword.R_UDT = Nothing
        Me.rrtbPassword.Size = New System.Drawing.Size(250, 27)
        Me.rrtbPassword.TabIndex = 10
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'waitBar
        '
        Me.waitBar.Location = New System.Drawing.Point(12, 414)
        Me.waitBar.Name = "waitBar"
        Me.waitBar.Size = New System.Drawing.Size(219, 10)
        Me.waitBar.TabIndex = 11
        Me.waitBar.Text = "RadWaitingBar1"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.rrbOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(698, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.waitBar)
        Me.Controls.Add(Me.rrtbPassword)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblCompID)
        Me.Controls.Add(Me.panelTitle)
        Me.Controls.Add(Me.cbCulture)
        Me.Controls.Add(Me.rrtbUserId)
        Me.Controls.Add(Me.rrtbCompanyId)
        Me.Controls.Add(Me.rrbOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(706, 460)
        Me.MinimumSize = New System.Drawing.Size(706, 460)
        Me.Name = "LoginForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(706, 460)
        Me.Text = "Login"
        CType(Me.rrbOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rrtbCompanyId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rrtbUserId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCulture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCompID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rrtbPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.waitBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rrbOK As R_FrontEnd.R_RadButton
    Friend WithEvents rrtbCompanyId As R_FrontEnd.R_RadTextBox
    Friend WithEvents rrtbUserId As R_FrontEnd.R_RadTextBox
    Friend WithEvents cbCulture As R_FrontEnd.R_RadDropDownList
    Friend WithEvents panelTitle As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblCompID As R_FrontEnd.R_RadLabel
    Friend WithEvents lblUserID As R_FrontEnd.R_RadLabel
    Friend WithEvents lblPass As R_FrontEnd.R_RadLabel
    Friend WithEvents lblLink As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rrtbPassword As R_FrontEnd.R_RadPasswordBox
    Friend WithEvents errProvider As R_FrontEnd.R_ErrorProvider
    Friend WithEvents waitBar As Telerik.WinControls.UI.RadWaitingBar

End Class
