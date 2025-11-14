Imports R_FrontEnd
Imports System.Data.Linq.SqlClient
Imports System.IO
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls

Public Class R_MenuSearchForm

    Private count As Integer
    Private oColBtn As New List(Of R_RadButton)
    Private loProgramAccessDTOList As New List(Of _MenuProgramAccessDTO)
    Private _oForm As Menu
    Private buttonElement As RadButtonElement
    Private loVscroll As R_MenuVScrollBarLayout

#Region "PROPERTY"
    Friend Property oForm() As Menu
        Get
            Return _oForm
        End Get
        Set(ByVal value As Menu)
            _oForm = value
        End Set
    End Property
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.BackColor = Color.FromArgb(20, 20, 20)

        buttonElement = New RadButtonElement
        With buttonElement
            .MinSize = New Size(40, 20)
            .ButtonFillElement.BackColor = Color.Transparent
            .ButtonFillElement.NumberOfColors = 1
            .ShowBorder = False
            .Margin = New Padding(0, 3, 3, 3)
            .ImageAlignment = ContentAlignment.MiddleCenter
            AddHandler .Click, AddressOf buttonCloseElement_Click
        End With

        Dim textBoxItem As RadTextBoxItem = txtSearch.TextBoxElement.TextBoxItem
        textBoxItem.Alignment = ContentAlignment.MiddleLeft

        txtSearch.TextBoxElement.Children.Remove(textBoxItem)

        Dim dockLayoutPanel As New DockLayoutPanel()
        dockLayoutPanel.Children.Add(buttonElement)
        dockLayoutPanel.Children.Add(textBoxItem)
        dockLayoutPanel.SetDock(textBoxItem, Telerik.WinControls.Layouts.Dock.Left)
        dockLayoutPanel.SetDock(buttonElement, Telerik.WinControls.Layouts.Dock.Right)

        txtSearch.TextBoxElement.Children.Add(dockLayoutPanel)

        AddHandler textBoxItem.KeyUp, AddressOf textBoxItem_KeyUp

        If Not String.IsNullOrWhiteSpace(textBoxItem.Text) Then
            buttonElement.Image = My.Resources.close_gray.GetThumbnailImage(15, 15, Nothing, New IntPtr())
        End If

        loVscroll = New R_MenuVScrollBarLayout
        loVscroll.Dock = DockStyle.Right
        loVscroll.Visible = False
        AddHandler loVscroll.Scroll, AddressOf Vscroll_Scroll
        Me.pnlScrollBar.Controls.Add(loVscroll)
        
        pnlScrollBar.Size = New Size(268, 552)
    End Sub

    Private Sub Vscroll_Scroll(sender As Object, e As ScrollEventArgs)
        Me.pnlContent.Top = -e.NewValue
    End Sub

#Region "EVENT HANDLER"
    Private Sub buttonCloseElement_Click(sender As Object, e As MouseEventArgs)
        txtSearch.Text = ""
        buttonElement.Image = Nothing
        txtSearch.Focus()
        ClearTile()
    End Sub

    Private Sub textBoxItem_KeyUp(sender As Object, e As KeyEventArgs)
        If CType(sender, RadTextBoxItem).Text.Count > 0 Then
            buttonElement.Image = My.Resources.close_gray.GetThumbnailImage(15, 15, Nothing, New IntPtr())
        Else
            buttonElement.Image = Nothing
        End If
    End Sub

    Private Sub buttonElement_Click(sender As Object, e As EventArgs)
        If _oForm IsNot Nothing Then
            _oForm._createDockDocumentWindow(sender)
            _oForm.hideDocContainer()
        End If
    End Sub
#End Region

#Region "METHOD"
    Private Sub SearchTile(cText As String)
        Dim loListProgAccess As New List(Of _MenuProgramAccessDTO)

        loListProgAccess = loProgramAccessDTOList.Where(Function(x) x.CPROGRAM_ID.ToLower.Contains(cText.ToLower) _
                                                            Or x.CPROGRAM_NAME.ToLower.Contains(cText.ToLower)).ToList

        If loListProgAccess.Count > 0 Then
            CreateTile(loListProgAccess)
        End If

        pnlContent.Size = New Size(268 - loVscroll.Width, loListProgAccess.Count * 55)

        If loListProgAccess.Count > 10 Then
            loVscroll.Visible = True
            loVscroll.Maximum = Me.pnlContent.Size.Height - Me.pnlScrollBar.Size.Height
        Else
            loVscroll.Visible = False
        End If

    End Sub

    Private Sub CreateTile(poObj As Object)
        Dim y As Integer = 0
        Dim aab As List(Of _MenuProgramAccessDTO) = poObj

        For i As Integer = 0 To aab.Count - 1
            Dim loBtn As New R_SearchButtonLayout(y, aab.Item(i).CPROGRAM_ID, aab.Item(i).CTOOL_TIP, aab.Item(i).CIMAGE_FILENAME)

            AddHandler loBtn.Click, AddressOf buttonElement_Click

            y += 56
            Me.pnlContent.Controls.Add(loBtn)
            oColBtn.Add(loBtn)
        Next
    End Sub

    Friend Sub ClearTile()
        Me.pnlContent.Controls.Clear()
        oColBtn.Clear()
    End Sub

    Friend Sub SetListProg(oProgList As Object)
        For Each oAcc In oProgList
            loProgramAccessDTOList.Add(New _MenuProgramAccessDTO With {.CMENU_ID = oAcc.CPARENT_SUB_MENU_ID,
                                                                       .CPROGRAM_ID = oAcc.CSUB_MENU_ID,
                                                                       .CIMAGE_FILENAME = oAcc.CSUB_MENU_IMAGE,
                                                                       .CPROGRAM_NAME = oAcc.CSUB_MENU_NAME,
                                                                       .CTOOL_TIP = oAcc.CSUB_MENU_TOOL_TIP})
        Next
    End Sub
#End Region

    Private Sub txtSearch_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        ClearTile()
        oColBtn.Clear()

        If e.KeyCode = Keys.Escape Then
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                txtSearch.Text = ""
                txtSearch.Focus()
            Else
                Dim loDockDocContainer As DocumentContainer
                _oForm.goRadDock.AutoHidePopup.Hide()

                'get document container
                For Each ctrl In _oForm.goRadDock.Controls
                    If TypeOf ctrl Is DocumentContainer Then
                        loDockDocContainer = ctrl
                    End If
                Next

                If loDockDocContainer.Controls.Count > 0 Then
                    Dim oDocTabStrip As DocumentTabStrip

                    oDocTabStrip = TryCast(loDockDocContainer.Controls(0), DocumentTabStrip)
                    If oDocTabStrip IsNot Nothing Then
                        oDocTabStrip.SplitPanelElement.Visibility = ElementVisibility.Visible
                        If oDocTabStrip.Controls.Count > 0 Then
                            CType(CType(oDocTabStrip.Controls(0), DocumentWindow).Controls(0), RadForm).Parent.Parent.Visible = True
                        End If
                    End If
                End If

                'set color on active tab
                Dim loDockTabStripItem As StripViewItemLayout

                loDockTabStripItem = TryCast(_oForm.goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
                If loDockTabStripItem IsNot Nothing Then
                    For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                        With dockTabStripItem
                            If .Text = _oForm.goRadDock.AutoHidePopup.ActiveWindow.Text Then
                                .BackColor = Color.IndianRed
                            End If
                        End With
                    Next
                End If
            End If

            Exit Sub
        End If

        Delaying(1000)
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            loVscroll.PerformFirst()
            ClearTile()
            SearchTile(txtSearch.Text)
        End If
    End Sub

    Private Sub Delaying(piInterval As Integer)
        Dim sw As New Stopwatch

        sw.Start()
        Do While sw.ElapsedMilliseconds < piInterval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub R_MenuSearchForm_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If loVscroll.Visible = False Then
            Exit Sub
        End If

        If e.Delta > 0 Then
            loVscroll.PerformSmallDecrement(10)
        Else
            loVscroll.PerformSmallIncrement(10)
        End If
    End Sub
End Class

Friend Class _MenuProgramAccessDTO
    Private _CMENU_ID As String
    Private _CPROGRAM_ID As String
    Private _CPROGRAM_NAME As String
    Private _CTOOL_TIP As String
    Private _CIMAGE_FILENAME As String

    Public Property CMENU_ID As String
        Get
            Return _CMENU_ID
        End Get
        Set(ByVal value As String)
            _CMENU_ID = value
        End Set
    End Property
    Public Property CPROGRAM_ID As String
        Get
            Return _CPROGRAM_ID
        End Get
        Set(ByVal value As String)
            _CPROGRAM_ID = value
        End Set
    End Property
    Public Property CPROGRAM_NAME As String
        Get
            Return _CPROGRAM_NAME
        End Get
        Set(ByVal value As String)
            _CPROGRAM_NAME = value
        End Set
    End Property
    Public Property CTOOL_TIP As String
        Get
            Return _CTOOL_TIP
        End Get
        Set(ByVal value As String)
            _CTOOL_TIP = value
        End Set
    End Property
    Public Property CIMAGE_FILENAME As String
        Get
            Return _CIMAGE_FILENAME
        End Get
        Set(ByVal value As String)
            _CIMAGE_FILENAME = value
        End Set
    End Property
End Class
