<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits R_FrontEnd.R_FormBase

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.TileGroupElement3 = New Telerik.WinControls.UI.TileGroupElement()
        Me.RadTileElement4 = New Telerik.WinControls.UI.RadTileElement()
        Me.RadTileElement5 = New Telerik.WinControls.UI.RadTileElement()
        Me.rcmPanoramaMouseDown = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.rcmTileGroupElementMouseDown = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.rcmTileFolderMouseDown = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.rcmTileMouseDown = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.rcmButtonFavouriteMouseDown = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
        Me.rbeDesertTheme = New Telerik.WinControls.UI.RadButtonElement()
        Me.panelTitle = New Telerik.WinControls.UI.RadPanel()
        Me.panelContent = New Telerik.WinControls.UI.RadPanel()
        Me.lblNotif = New R_FrontEnd.R_RadLabel(Me.components)
        CType(Me.panelTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContent.SuspendLayout()
        CType(Me.lblNotif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonTab1
        '
        Me.RibbonTab1.AccessibleDescription = "Favourites"
        Me.RibbonTab1.AccessibleName = "Favourites"
        Me.RibbonTab1.IsSelected = True
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Favourites"
        '
        'RadRibbonBarGroup1
        '
        Me.RadRibbonBarGroup1.AccessibleDescription = "Favourite"
        Me.RadRibbonBarGroup1.AccessibleName = "Favourite"
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        Me.RadRibbonBarGroup1.Text = "Favourite"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Rad Panorama"
        Me.RadLabelElement1.AccessibleName = "Rad Panorama"
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadLabelElement1.Text = "Rad Panorama"
        Me.RadLabelElement1.TextWrap = True
        '
        'TileGroupElement3
        '
        Me.TileGroupElement3.AccessibleDescription = "Reservation"
        Me.TileGroupElement3.AccessibleName = "Reservation"
        Me.TileGroupElement3.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.TileGroupElement3.AutoSize = True
        Me.TileGroupElement3.AutoToolTip = True
        Me.TileGroupElement3.CellSize = New System.Drawing.Size(300, 150)
        Me.TileGroupElement3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TileGroupElement3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadTileElement4, Me.RadTileElement5})
        Me.TileGroupElement3.Margin = New System.Windows.Forms.Padding(0)
        Me.TileGroupElement3.Name = "TileGroupElement3"
        Me.TileGroupElement3.RowsCount = 2
        Me.TileGroupElement3.Shape = Nothing
        Me.TileGroupElement3.Text = "Reservation"
        Me.TileGroupElement3.ToolTipText = "Tool Tip Reservation"
        Me.TileGroupElement3.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadTileElement4
        '
        Me.RadTileElement4.AccessibleDescription = "Check In"
        Me.RadTileElement4.AccessibleName = "Check In"
        Me.RadTileElement4.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.RadTileElement4.ImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RadTileElement4.Name = "RadTileElement4"
        Me.RadTileElement4.Text = "Check In"
        Me.RadTileElement4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadTileElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'RadTileElement5
        '
        Me.RadTileElement5.AccessibleDescription = "Check Reservation"
        Me.RadTileElement5.AccessibleName = "Check Reservation"
        Me.RadTileElement5.BackgroundImage = CType(resources.GetObject("RadTileElement5.BackgroundImage"), System.Drawing.Image)
        Me.RadTileElement5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadTileElement5.Column = 1
        Me.RadTileElement5.Image = Nothing
        Me.RadTileElement5.Name = "RadTileElement5"
        Me.RadTileElement5.RowSpan = 2
        Me.RadTileElement5.Text = "Check Reservation"
        '
        'RadButtonElement4
        '
        Me.RadButtonElement4.AccessibleDescription = "RadButtonElement4"
        Me.RadButtonElement4.AccessibleName = "RadButtonElement4"
        Me.RadButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement4.Name = "RadButtonElement4"
        Me.RadButtonElement4.StretchHorizontally = False
        Me.RadButtonElement4.Text = "AquaTheme"
        Me.RadButtonElement4.ToolTipText = "Aqua Theme"
        Me.RadButtonElement4.ZIndex = 3
        '
        'RadButtonElement5
        '
        Me.RadButtonElement5.AccessibleDescription = "RadButtonElement5"
        Me.RadButtonElement5.AccessibleName = "RadButtonElement5"
        Me.RadButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement5.Name = "RadButtonElement5"
        Me.RadButtonElement5.StretchHorizontally = False
        Me.RadButtonElement5.Text = "BreezeTheme"
        Me.RadButtonElement5.ToolTipText = "Band Aid Write"
        Me.RadButtonElement5.ZIndex = 2
        '
        'rbeDesertTheme
        '
        Me.rbeDesertTheme.AccessibleDescription = "DesertTheme"
        Me.rbeDesertTheme.AccessibleName = "rbeDesertTheme"
        Me.rbeDesertTheme.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.rbeDesertTheme.Name = "rbeDesertTheme"
        Me.rbeDesertTheme.StretchHorizontally = False
        Me.rbeDesertTheme.Text = "Desert Theme"
        Me.rbeDesertTheme.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.rbeDesertTheme.ToolTipText = "Desert Theme"
        Me.rbeDesertTheme.ZIndex = 1
        '
        'panelTitle
        '
        Me.panelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitle.Location = New System.Drawing.Point(0, 8)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(1126, 54)
        Me.panelTitle.TabIndex = 3
        '
        'panelContent
        '
        Me.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelContent.Controls.Add(Me.lblNotif)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(0, 62)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(1126, 479)
        Me.panelContent.TabIndex = 4
        '
        'lblNotif
        '
        Me.lblNotif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotif.AutoSize = False
        Me.lblNotif.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblNotif.ForeColor = System.Drawing.Color.White
        Me.lblNotif.Location = New System.Drawing.Point(1023, 379)
        Me.lblNotif.Name = "lblNotif"
        Me.lblNotif.R_FontType = R_FrontEnd.R_FontTypeEnumeration.eFontType.Reguler
        Me.lblNotif.R_ResourceId = Nothing
        Me.lblNotif.Size = New System.Drawing.Size(100, 97)
        Me.lblNotif.TabIndex = 0
        Me.lblNotif.Text = "R_RadLabel1"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1126, 541)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelTitle)
        Me.Name = "Menu"
        Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Realta Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.panelTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContent.ResumeLayout(False)
        CType(Me.lblNotif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonTab1 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents TileGroupElement3 As Telerik.WinControls.UI.TileGroupElement
    Friend WithEvents RadTileElement4 As Telerik.WinControls.UI.RadTileElement
    Friend WithEvents RadTileElement5 As Telerik.WinControls.UI.RadTileElement
    Friend WithEvents RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadButtonElement4 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement5 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents rbeDesertTheme As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents rcmPanoramaMouseDown As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents rcmTileGroupElementMouseDown As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents rcmTileFolderMouseDown As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents rcmTileMouseDown As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents rcmButtonFavouriteMouseDown As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents panelTitle As Telerik.WinControls.UI.RadPanel
    Friend WithEvents panelContent As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblNotif As R_FrontEnd.R_RadLabel

End Class
