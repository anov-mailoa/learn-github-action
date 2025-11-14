Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Public Class ButtonLayout
    Inherits RadButtonElement

    Public Sub New()
        With Me
            .MaxSize = New Size(28, 28)
            .Size = New Size(25, 25)
            .ImageAlignment = ContentAlignment.MiddleCenter
            .BorderElement.Width = 0
            .BorderElement.ForeColor = Color.Transparent
            .ButtonFillElement.BackColor = Color.Transparent
            .ButtonFillElement.NumberOfColors = 1
            .ButtonFillElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            AddHandler .MouseEnter, AddressOf oBtn_MouseEnter
            AddHandler .MouseLeave, AddressOf oBtn_MouseLeave
        End With

    End Sub

    Private Sub oBtn_MouseEnter(sender As Object, e As EventArgs)
        'Me.BorderElement.ForeColor = Color.Gray
        Me.ButtonFillElement.BackColor = Color.Gray
    End Sub

    Private Sub oBtn_MouseLeave(sender As Object, e As EventArgs)
        'Me.BorderElement.ForeColor = Color.Transparent
        Me.ButtonFillElement.BackColor = Color.Transparent
    End Sub
End Class
