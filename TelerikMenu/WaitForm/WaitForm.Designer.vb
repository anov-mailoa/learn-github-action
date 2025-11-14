<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WaitForm
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
        Me.lblMessage = New R_FrontEnd.R_RadLabel(Me.components)
        Me.WaitBar = New Telerik.WinControls.UI.RadWaitingBar()
        Me.pnlWaitForm = New R_FrontEnd.R_RadPanel()
        CType(Me.lblMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlWaitForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWaitForm.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = False
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblMessage.Location = New System.Drawing.Point(12, 12)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.lblMessage.R_ResourceId = Nothing
        Me.lblMessage.Size = New System.Drawing.Size(170, 65)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "R_RadLabel1"
        Me.lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WaitBar
        '
        Me.WaitBar.Location = New System.Drawing.Point(12, 100)
        Me.WaitBar.Name = "WaitBar"
        Me.WaitBar.Size = New System.Drawing.Size(170, 24)
        Me.WaitBar.TabIndex = 1
        Me.WaitBar.Text = "RadWaitingBar1"
        '
        'pnlWaitForm
        '
        Me.pnlWaitForm.Controls.Add(Me.WaitBar)
        Me.pnlWaitForm.Controls.Add(Me.lblMessage)
        Me.pnlWaitForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWaitForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlWaitForm.Name = "pnlWaitForm"
        Me.pnlWaitForm.R_BorderStyle = R_FrontEnd.R_eBorderStyle.Solid
        Me.pnlWaitForm.R_ConductorGridSource = Nothing
        Me.pnlWaitForm.R_ConductorSource = Nothing
        Me.pnlWaitForm.Size = New System.Drawing.Size(199, 148)
        Me.pnlWaitForm.TabIndex = 0
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 2.0!
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).PaintUsingParentShape = False
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.pnlWaitForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'WaitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(199, 148)
        Me.Controls.Add(Me.pnlWaitForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WaitForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = ""
        CType(Me.lblMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlWaitForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWaitForm.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As R_FrontEnd.R_RadLabel
    Friend WithEvents WaitBar As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents pnlWaitForm As R_FrontEnd.R_RadPanel

End Class
