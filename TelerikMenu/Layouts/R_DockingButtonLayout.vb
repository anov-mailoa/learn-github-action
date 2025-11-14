Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI.Docking

Public Class R_DockingButtonLayout
    Inherits RadButtonElement

    Private _oForm As HostWindow

    Public Property oForm() As HostWindow
        Get
            Return _oForm
        End Get
        Set(ByVal value As HostWindow)
            _oForm = value
        End Set
    End Property

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
            AddHandler .Click, AddressOf oBtn_Click
        End With

    End Sub

    Private Sub oBtn_MouseEnter(sender As Object, e As EventArgs)
        'Me.BorderElement.ForeColor = Color.Gray
        Me.ButtonFillElement.BackColor = Color.LightGray
    End Sub

    Private Sub oBtn_MouseLeave(sender As Object, e As EventArgs)
        'Me.BorderElement.ForeColor = Color.Transparent
        Me.ButtonFillElement.BackColor = Color.Transparent
    End Sub

    Private Sub oBtn_Click(sender As Object, e As EventArgs)
        If _oForm IsNot Nothing Then
            If _oForm.DockState = DockState.AutoHide Then
                _oForm.DockState = DockState.Docked
            ElseIf _oForm.DockState = DockState.Docked Then
                _oForm.DockState = DockState.AutoHide
            End If
        End If
    End Sub
End Class
