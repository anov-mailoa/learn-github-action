Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Public Class R_MenuVScrollBarLayout
    Inherits RadVScrollBar

    Public Sub New()
        Dim loFill As FillPrimitive = TryCast(Me.ScrollBarElement.Children(1), FillPrimitive)
        If loFill IsNot Nothing Then
            loFill.BackColor = Color.FromArgb(20, 20, 20)
            loFill.NumberOfColors = 1
            loFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        End If

        Dim loFill1 As FillPrimitive = TryCast(Me.ScrollBarElement.Children(0), FillPrimitive)
        If loFill1 IsNot Nothing Then
            loFill1.BackColor = Color.FromArgb(20, 20, 20)
            loFill1.NumberOfColors = 1
            loFill1.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        End If

        Me.ScrollBarElement.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

        Me.ScrollBarElement.ThumbElement.ThumbFill.BackColor = Color.FromArgb(51, 51, 51)
        Me.ScrollBarElement.ThumbElement.ThumbFill.NumberOfColors = 1
        Me.ScrollBarElement.ThumbElement.ThumbFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.ScrollBarElement.ThumbElement.ThumbBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.ScrollBarElement.ThumbElement.GripImage = Nothing

        AddHandler Me.ScrollBarElement.ThumbElement.MouseEnter, AddressOf ThumbFill_MouseEnter
        AddHandler Me.ScrollBarElement.ThumbElement.MouseLeave, AddressOf ThumbFill_MouseLeave

        Me.ScrollBarElement.FirstButton.ButtonFill.NumberOfColors = 1
        Me.ScrollBarElement.FirstButton.ButtonFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.ScrollBarElement.FirstButton.ButtonBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.ScrollBarElement.FirstButton.ArrowPrimitive.BackColor = Color.FromArgb(51, 51, 51)

        AddHandler Me.ScrollBarElement.FirstButton.MouseEnter, AddressOf FirstButton_MouseEnter
        AddHandler Me.ScrollBarElement.FirstButton.MouseLeave, AddressOf FirstButton_MouseLeave

        Me.ScrollBarElement.SecondButton.ButtonFill.NumberOfColors = 1
        Me.ScrollBarElement.SecondButton.ButtonFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.ScrollBarElement.SecondButton.ButtonBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.ScrollBarElement.SecondButton.ArrowPrimitive.BackColor = Color.FromArgb(51, 51, 51)

        AddHandler Me.ScrollBarElement.SecondButton.MouseEnter, AddressOf FirstButton_MouseEnter
        AddHandler Me.ScrollBarElement.SecondButton.MouseLeave, AddressOf FirstButton_MouseLeave
    End Sub

    Private Sub ThumbFill_MouseEnter(sender As Object, e As EventArgs)
        sender.ThumbFill.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub ThumbFill_MouseLeave(sender As Object, e As EventArgs)
        sender.ThumbFill.BackColor = Color.FromArgb(51, 51, 51)
    End Sub

    Private Sub FirstButton_MouseEnter(sender As Object, e As EventArgs)
        sender.ButtonFill.BackColor = Color.Transparent
    End Sub

    Private Sub FirstButton_MouseLeave(sender As Object, e As EventArgs)
        sender.ButtonFill.BackColor = Color.Transparent
    End Sub
End Class
