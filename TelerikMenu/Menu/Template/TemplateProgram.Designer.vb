<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateProgram
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RadDockTemplate = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        CType(Me.RadDockTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDockTemplate.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDockTemplate
        '
        Me.RadDockTemplate.Controls.Add(Me.DocumentContainer1)
        Me.RadDockTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDockTemplate.DocumentTabsAlignment = Telerik.WinControls.UI.TabStripAlignment.Left
        Me.RadDockTemplate.IsCleanUpTarget = True
        Me.RadDockTemplate.Location = New System.Drawing.Point(0, 0)
        Me.RadDockTemplate.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDockTemplate.Name = "RadDockTemplate"
        '
        '
        '
        Me.RadDockTemplate.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDockTemplate.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDockTemplate.Size = New System.Drawing.Size(607, 451)
        Me.RadDockTemplate.TabIndex = 0
        Me.RadDockTemplate.TabStop = False
        Me.RadDockTemplate.Text = "RadDock1"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        '
        'TemplateProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 451)
        Me.Controls.Add(Me.RadDockTemplate)
        Me.Name = "TemplateProgram"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "TemplateProgram"
        CType(Me.RadDockTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDockTemplate.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadDockTemplate As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
End Class

