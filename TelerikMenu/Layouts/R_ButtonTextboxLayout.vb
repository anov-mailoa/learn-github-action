Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts

Public Class R_ButtonTextboxLayout
    Inherits RadTextBox

    Public goButton As RadButtonElement
    Public goTxtItem As RadTextBoxItem

    Public Sub New()
        goButton = New RadButtonElement
        goButton.Text = "OK"
        goButton.TextAlignment = ContentAlignment.MiddleCenter
        goButton.MinSize = New Size(30, 0)
        goButton.ButtonFillElement.BackColor = Color.FromArgb(51, 51, 51)
        goButton.ButtonFillElement.NumberOfColors = 1
        goButton.TextElement.ForeColor = Color.White
        goButton.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

        AddHandler goButton.MouseEnter, AddressOf goButton_MouseEnter
        AddHandler goButton.MouseLeave, AddressOf goButton_MouseLeave

        Dim stackPanel As New StackLayoutElement()
        stackPanel.Orientation = Orientation.Horizontal
        stackPanel.Margin = New Padding(1, 0, 1, 0)
        stackPanel.Children.Add(goButton)

        goTxtItem = Me.TextBoxElement.TextBoxItem
        goTxtItem.NullText = R_Common.R_Utility.R_GetMessage(Me.GetType, "_NewGroup")
        Me.TextBoxElement.Children.Remove(goTxtItem)

        Dim dockPanel As New DockLayoutPanel()
        dockPanel.Children.Add(stackPanel)
        dockPanel.Children.Add(goTxtItem)
        DockLayoutPanel.SetDock(goTxtItem, Telerik.WinControls.Layouts.Dock.Left)
        DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right)
        Me.TextBoxElement.Children.Add(dockPanel)
    End Sub

    Private Sub goButton_MouseEnter(sender As Object, e As EventArgs)
        sender.ButtonFillElement.BackColor = Color.FromArgb(68, 68, 68)
    End Sub

    Private Sub goButton_MouseLeave(sender As Object, e As EventArgs)
        sender.ButtonFillElement.BackColor = Color.FromArgb(23, 23, 23)
    End Sub
End Class
