<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R_MenuSearchForm
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
        Me.txtSearch = New R_FrontEnd.R_RadTextBox(Me.components)
        Me.lblSearch = New R_FrontEnd.R_RadLabel(Me.components)
        Me.pnlScrollBar = New R_FrontEnd.R_RadPanel()
        Me.pnlContent = New R_FrontEnd.R_RadPanel()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlScrollBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlScrollBar.SuspendLayout()
        CType(Me.pnlContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 44)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.R_ConductorGridSource = Nothing
        Me.txtSearch.R_ConductorSource = Nothing
        Me.txtSearch.R_UDT = Nothing
        Me.txtSearch.Size = New System.Drawing.Size(268, 27)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = False
        Me.lblSearch.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(13, 4)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Header
        Me.lblSearch.R_ResourceId = Nothing
        Me.lblSearch.Size = New System.Drawing.Size(100, 34)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        '
        'pnlScrollBar
        '
        Me.pnlScrollBar.Controls.Add(Me.pnlContent)
        Me.pnlScrollBar.Location = New System.Drawing.Point(12, 97)
        Me.pnlScrollBar.Name = "pnlScrollBar"
        Me.pnlScrollBar.R_ConductorGridSource = Nothing
        Me.pnlScrollBar.R_ConductorSource = Nothing
        Me.pnlScrollBar.Size = New System.Drawing.Size(268, 300)
        Me.pnlScrollBar.TabIndex = 2
        '
        'pnlContent
        '
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.R_ConductorGridSource = Nothing
        Me.pnlContent.R_ConductorSource = Nothing
        Me.pnlContent.Size = New System.Drawing.Size(268, 300)
        Me.pnlContent.TabIndex = 3
        '
        'R_MenuSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(292, 409)
        Me.Controls.Add(Me.pnlScrollBar)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "R_MenuSearchForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = ""
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlScrollBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlScrollBar.ResumeLayout(False)
        CType(Me.pnlContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As R_FrontEnd.R_RadTextBox
    Friend WithEvents lblSearch As R_FrontEnd.R_RadLabel
    Friend WithEvents pnlScrollBar As R_FrontEnd.R_RadPanel
    Friend WithEvents pnlContent As R_FrontEnd.R_RadPanel

End Class
