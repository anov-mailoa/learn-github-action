Imports Telerik.WinControls.UI

Public Class R_MenuSearchIconLayout
    Inherits StackLayoutElement

    Private _goButton As RadButtonElement

    Public Sub New()
        With Me
            .Orientation = Orientation.Horizontal
            .Margin = New Padding(10, 0, 0, 0)
            .DrawBorder = False

            _goButton = New RadButtonElement

            With _goButton
                .ForeColor = Color.White
                .MinSize = New Size(35, 20)
                .Image = My.Resources.search.GetThumbnailImage(13, 13, Nothing, New IntPtr())
                .ImageAlignment = ContentAlignment.MiddleCenter
                .ButtonFillElement.BackColor = Color.Transparent
                .ButtonFillElement.NumberOfColors = 1
                .ShowBorder = False

                AddHandler .MouseLeave, AddressOf buttonElement_MouseLeave
                AddHandler .MouseEnter, AddressOf buttonElement_MouseEnter
                AddHandler .Click, AddressOf buttonElement_Click
            End With

            .Children.Add(_goButton)
        End With
    End Sub

#Region "EVENT HANDLER"
    Private Sub buttonElement_MouseEnter(sender As Object, e As EventArgs)
        sender.ButtonFillElement.BackColor = Color.FromArgb(51, 51, 51)
    End Sub

    Private Sub buttonElement_MouseLeave(sender As Object, e As EventArgs)
        sender.ButtonFillElement.BackColor = Color.Transparent
    End Sub

    Private Sub buttonElement_Click(sender As Object, e As EventArgs)
        RaiseEvent MenuSearchIconLayoutClick(sender, e)
    End Sub
#End Region

#Region "EVENT"
    Friend Event MenuSearchIconLayoutClick(sender As Object, e As EventArgs)
#End Region

End Class
