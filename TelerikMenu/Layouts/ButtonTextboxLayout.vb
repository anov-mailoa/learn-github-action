Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts

Public Class ButtonTextboxLayout
    Inherits RadTextBox

    Public goButton As New RadButtonElement()
    Public goTxtItem As New RadTextBoxItem

    Public Sub New()
        'AddHandler button.Click, AddressOf button_Click
        goButton.Padding = New Padding(2, 0, 2, -2)
        goButton.Margin = New Padding(0, 0, 0, 0)
        goButton.Text = "OK"
        goButton.TextAlignment = ContentAlignment.MiddleCenter
        goButton.Size = New Size(20, 200)

        Dim stackPanel As New StackLayoutElement()
        stackPanel.Orientation = Orientation.Horizontal
        stackPanel.Margin = New Padding(1, 0, 1, 0)
        stackPanel.Children.Add(goButton)

        goTxtItem = Me.TextBoxElement.TextBoxItem
        goTxtItem.NullText = "New Group Name"
        goTxtItem.AutoSize = True
        Me.TextBoxElement.Children.Remove(goTxtItem)

        Dim dockPanel As New DockLayoutPanel()
        dockPanel.Children.Add(stackPanel)
        dockPanel.Children.Add(goTxtItem)
        DockLayoutPanel.SetDock(goTxtItem, Telerik.WinControls.Layouts.Dock.Left)
        DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right)
        Me.TextBoxElement.Children.Add(dockPanel)
    End Sub

End Class
