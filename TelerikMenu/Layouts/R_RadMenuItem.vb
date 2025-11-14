Imports Telerik.WinControls.UI

Public Class R_RadMenuItem
    Inherits RadMenuItem

    Public Sub New()
        
    End Sub

    Public Sub New(poText As String)
        MyBase.New()

        If Not String.IsNullOrWhiteSpace(poText) Then
            Me.Text = poText
        End If
    End Sub

    Private Sub R_RadMenuItem_DropDownCreating(sender As Object, e As System.EventArgs) Handles Me.DropDownCreating
        With Me
            .ImageAlignment = ContentAlignment.MiddleCenter
            .Margin = New Padding(3, 3, 0, 3)
            .BorderPrimitive.ShouldPaint = False
            .ForeColor = Color.White
            .MinSize = New Size(0, 30)
        End With
    End Sub

    Private Sub R_RadMenuItem_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        sender.FillPrimitive.BackColor = Color.FromArgb(23, 23, 23)
    End Sub

    Private Sub R_RadMenuItem_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        sender.FillPrimitive.BackColor = Color.FromArgb(51, 51, 51)
    End Sub
End Class
