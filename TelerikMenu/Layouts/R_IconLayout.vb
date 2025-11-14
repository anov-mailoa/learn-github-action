Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class R_IconLayout
    Inherits RadElement

    Protected Overrides Sub CreateChildElements()
        Dim headerLayout As New StackLayoutElement()

        With headerLayout
            .Orientation = Orientation.Horizontal
            .NotifyParentOnMouseInput = True
            .ShouldHandleMouseInput = False
            .StretchHorizontally = False

            .Children.Add(getVisualElement())
        End With

        Me.Children.Add(headerLayout)
        MyBase.CreateChildElements()
    End Sub

    Private Function getVisualElement() As LightVisualElement
        Dim headerIcon As New LightVisualElement()

        With headerIcon
            .ForeColor = Color.White
            .TextAlignment = ContentAlignment.MiddleLeft
            .MaxSize = New Size(630, 110)
            .NotifyParentOnMouseInput = True
            .ShouldHandleMouseInput = False
            .StretchHorizontally = False
        End With

        Return headerIcon
    End Function

End Class
