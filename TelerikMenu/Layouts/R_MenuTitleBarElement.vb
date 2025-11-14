Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls

Public Class R_MenuTitleBarElement
    Inherits RadTitleBarElement

    Private _goMenu As Menu
    Private WithEvents _goSearchIcon As R_MenuSearchIconLayout

    Private Sub New()
    End Sub

    Public Sub New(poOwner As Menu)
        With Me
            .FillPrimitive.BackColor = Color.Transparent
            .FillPrimitive.NumberOfColors = 1
            .MaxSize = New Size(0, 30)

            'define close button property
            .CloseButton.Parent.PositionOffset = New SizeF(0, 0)
            SetButtonProperty(.CloseButton, My.Resources.close)

            AddHandler .CloseButton.MouseLeave, AddressOf CloseButton_MouseLeave
            AddHandler .CloseButton.MouseEnter, AddressOf CloseButton_MouseEnter

            'define minimize button property
            SetButtonProperty(.MinimizeButton, My.Resources.minimiza)

            AddHandler .MinimizeButton.MouseLeave, AddressOf MinMaxButton_MouseLeave
            AddHandler .MinimizeButton.MouseEnter, AddressOf MinMaxButton_MouseEnter

            'define maximize button property
            SetButtonProperty(.MaximizeButton, My.Resources.maximize)

            AddHandler .MaximizeButton.MouseLeave, AddressOf MinMaxButton_MouseLeave
            AddHandler .MaximizeButton.MouseEnter, AddressOf MinMaxButton_MouseEnter

            _goSearchIcon = New R_MenuSearchIconLayout
            .SystemButtons.Children.Insert(0, _goSearchIcon)

            .Margin = New Padding(0, -7, 0, 0)
        End With

        'add handler windows state
        AddHandler Me.Close, AddressOf titleBar_Close
        AddHandler Me.Minimize, AddressOf titleBar_Minimize
        AddHandler Me.MaximizeRestore, AddressOf titleBar_MaximizeRestore

        _goMenu = poOwner
    End Sub

#Region "ADD HANDLER WINDOWS STATE"
    Private Sub titleBar_MaximizeRestore(ByVal sender As Object, ByVal args As EventArgs)
        If _goMenu.WindowState <> FormWindowState.Maximized Then
            _goMenu.WindowState = FormWindowState.Maximized
        Else
            _goMenu.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub titleBar_Minimize(ByVal sender As Object, ByVal args As EventArgs)
        _goMenu.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub titleBar_Close(ByVal sender As Object, ByVal args As EventArgs)
        _goMenu.Close()
    End Sub
#End Region

#Region "ADD HANDLER CLOSE BUTTON"
    Private Sub CloseButton_MouseEnter(sender As Object, e As EventArgs)
        sender.BackColor = Color.FromArgb(232, 17, 35)
    End Sub

    Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs)
        sender.BackColor = Color.Transparent
    End Sub
#End Region

#Region "ADD HANDLER MIN MAX BUTTON"
    Private Sub MinMaxButton_MouseEnter(sender As Object, e As EventArgs)
        sender.BackColor = Color.FromArgb(51, 51, 51)
    End Sub

    Private Sub MinMaxButton_MouseLeave(sender As Object, e As EventArgs)
        sender.BackColor = Color.Transparent
    End Sub
#End Region

    'add handler search icon
    Private Sub _goSearchIcon_MenuSearchIconLayoutClick(sender As Object, e As System.EventArgs) Handles _goSearchIcon.MenuSearchIconLayoutClick
        RaiseEvent SearchIconClick(sender, e)
    End Sub

#Region "METHOD"
    Private Sub SetButtonProperty(poRadButtonElement As RadButtonElement, poImage As Bitmap)
        With poRadButtonElement
            .Image = poImage.GetThumbnailImage(13, 13, Nothing, New IntPtr())
            .ShouldPaint = True
            .BackColor = Color.Transparent
            .ShowBorder = False
            .ButtonFillElement.NumberOfColors = 1
            .Margin = New Padding(0, 0, 0, 0)
            .MinSize = New Size(35, 20)
            .LayoutPanel.Margin = New Padding(10, 0, 0, 0)
            .ImagePrimitive.Margin = New Padding(0, 4, 0, 0)

            .SetValue(RadFormElement.IsFormActiveProperty, True)
        End With
    End Sub
#End Region

#Region "EVENT"
    Friend Event SearchIconClick(sender As Object, e As System.EventArgs)
#End Region
     
End Class
