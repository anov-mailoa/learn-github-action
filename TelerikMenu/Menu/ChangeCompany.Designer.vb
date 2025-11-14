<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeCompany
    Inherits R_FrontEnd.R_FormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rrbChange = New R_FrontEnd.R_RadButton(Me.components)
        Me.rrbCancel = New R_FrontEnd.R_RadButton(Me.components)
        Me.R_RadDropDownList1 = New R_FrontEnd.R_RadDropDownList(Me.components)
        Me.bsCompanyList = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_RadLabel1 = New R_FrontEnd.R_RadLabel(Me.components)
        CType(Me.rrbChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rrbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCompanyList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rrbChange
        '
        Me.rrbChange.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.rrbChange.Location = New System.Drawing.Point(226, 38)
        Me.rrbChange.Name = "rrbChange"
        Me.rrbChange.R_ConductorGridSource = Nothing
        Me.rrbChange.R_ConductorSource = Nothing
        Me.rrbChange.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.rrbChange.R_ResourceId = Nothing
        Me.rrbChange.Size = New System.Drawing.Size(154, 24)
        Me.rrbChange.TabIndex = 0
        Me.rrbChange.Text = "Change company"
        '
        'rrbCancel
        '
        Me.rrbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.rrbCancel.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.rrbCancel.Location = New System.Drawing.Point(386, 38)
        Me.rrbCancel.Name = "rrbCancel"
        Me.rrbCancel.R_ConductorGridSource = Nothing
        Me.rrbCancel.R_ConductorSource = Nothing
        Me.rrbCancel.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.rrbCancel.R_ResourceId = Nothing
        Me.rrbCancel.Size = New System.Drawing.Size(110, 24)
        Me.rrbCancel.TabIndex = 1
        Me.rrbCancel.Text = "Cancel"
        '
        'R_RadDropDownList1
        '
        Me.R_RadDropDownList1.DataSource = Me.bsCompanyList
        Me.R_RadDropDownList1.DisplayMember = "CCOMPANY_ID"
        Me.R_RadDropDownList1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.R_RadDropDownList1.Location = New System.Drawing.Point(142, 12)
        Me.R_RadDropDownList1.Name = "R_RadDropDownList1"
        Me.R_RadDropDownList1.R_ConductorGridSource = Nothing
        Me.R_RadDropDownList1.R_ConductorSource = Nothing
        Me.R_RadDropDownList1.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.R_RadDropDownList1.Size = New System.Drawing.Size(354, 20)
        Me.R_RadDropDownList1.TabIndex = 2
        Me.R_RadDropDownList1.ValueMember = "CCOMPANY_ID"
        '
        'bsCompanyList
        '
        Me.bsCompanyList.DataSource = GetType(TelerikMenu.MenuServiceRef.SAM_USER_COMPANYDTO)
        '
        'R_RadLabel1
        '
        Me.R_RadLabel1.AutoSize = False
        Me.R_RadLabel1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.R_RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.R_RadLabel1.Name = "R_RadLabel1"
        Me.R_RadLabel1.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.R_RadLabel1.R_ResourceId = Nothing
        Me.R_RadLabel1.Size = New System.Drawing.Size(100, 18)
        Me.R_RadLabel1.TabIndex = 3
        Me.R_RadLabel1.Text = "Choose company"
        '
        'ChangeCompany
        '
        Me.AcceptButton = Me.rrbChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.rrbCancel
        Me.ClientSize = New System.Drawing.Size(508, 69)
        Me.Controls.Add(Me.R_RadLabel1)
        Me.Controls.Add(Me.R_RadDropDownList1)
        Me.Controls.Add(Me.rrbCancel)
        Me.Controls.Add(Me.rrbChange)
        Me.Name = "ChangeCompany"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Change Company"
        CType(Me.rrbChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rrbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCompanyList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rrbChange As R_FrontEnd.R_RadButton
    Friend WithEvents rrbCancel As R_FrontEnd.R_RadButton
    Friend WithEvents R_RadDropDownList1 As R_FrontEnd.R_RadDropDownList
    Friend WithEvents R_RadLabel1 As R_FrontEnd.R_RadLabel
    Friend WithEvents bsCompanyList As System.Windows.Forms.BindingSource

End Class
