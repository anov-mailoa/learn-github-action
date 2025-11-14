Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI.Docking

Public Class DockButtonLayout
    Inherits RadElement

    Public _oForm As HostWindow

    Public Property oForm() As HostWindow
        Get
            Return _oForm
        End Get
        Set(ByVal value As HostWindow)
            _oForm = value
        End Set
    End Property

    Protected Overrides Sub CreateChildElements()
        Dim headerLayout As New StackLayoutElement()

        With headerLayout
            .Orientation = Orientation.Horizontal
            .NotifyParentOnMouseInput = True
            .ShouldHandleMouseInput = False
            .StretchHorizontally = False

            .Children.Add(getToogleElement)
        End With

        Me.Children.Add(headerLayout)
        MyBase.CreateChildElements()
    End Sub

    Private Function getToogleElement() As RadButtonElement
        Dim toogleBtn As RadButtonElement

        toogleBtn = New RadButtonElement
        With toogleBtn
            .ShowBorder = True
            .Padding = New Padding(2, 0, 2, -2)
            .Margin = New Padding(0, 0, 0, 0)
            '.Text = "..."
            .BackColor = Color.Transparent
            .ImageAlignment = ContentAlignment.MiddleCenter
            '.Image = My.Resources._1440516992_pin.GetThumbnailImage(20, 20, Nothing, New IntPtr())
            .BorderElement.ForeColor = Color.Transparent
            .ButtonFillElement.BackColor = Color.Transparent
            .ButtonFillElement.NumberOfColors = 1
            .ButtonFillElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        End With

        AddHandler toogleBtn.Click, AddressOf toogleBtn_Click
        Return toogleBtn
    End Function

    Public Sub toogleBtn_Click(sender As Object, e As EventArgs)
        If _oForm IsNot Nothing Then
            If _oForm.DockState = DockState.AutoHide Then
                _oForm.DockState = DockState.Docked
            ElseIf _oForm.DockState = DockState.Docked Then
                _oForm.DockState = DockState.AutoHide
            End If
        End If
    End Sub
End Class
