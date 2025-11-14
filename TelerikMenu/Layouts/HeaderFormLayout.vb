Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Public Class HeaderFormLayout
    Inherits RadElement

    Protected Overrides Sub CreateChildElements()
        Dim headerLayout As New StackLayoutElement()

        With headerLayout
            .Orientation = Orientation.Horizontal
            .NotifyParentOnMouseInput = True
            .ShouldHandleMouseInput = True
            .StretchHorizontally = False

            AddHandler .MouseEnter, AddressOf RadLabelElement_MouseEnter
            AddHandler .MouseLeave, AddressOf RadLabelElement_MouseLeave
            
            .Children.Add(getVisualElement())
        End With

        Me.Children.Add(headerLayout)
        MyBase.CreateChildElements()
    End Sub

    Private Function getVisualElement() As LightVisualElement
        Dim headerLabel As New LightVisualElement()

        With headerLabel
            .Font = New Font("Arial", 10)
            .TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            .ForeColor = Color.White
            .TextAlignment = ContentAlignment.MiddleLeft
            .MaxSize = New Size(630, 110)
            .NotifyParentOnMouseInput = True
            .ShouldHandleMouseInput = False
            .StretchHorizontally = False
        End With

        Return headerLabel
    End Function

    Public Sub setText(pcText As String)
        CType(Me.Children(0).Children(0), LightVisualElement).Text = pcText
    End Sub

    Private Sub RadLabelElement_MouseEnter(sender As Object, e As EventArgs)
        With CType(Me.Children(0).Children(0), LightVisualElement)
            .Font = New Font("Arial", 10, FontStyle.Underline)
            .ElementTree.Control.Cursor = Cursors.Hand
        End With
    End Sub

    Private Sub RadLabelElement_MouseLeave(sender As Object, e As EventArgs)
        With CType(Me.Children(0).Children(0), LightVisualElement)
            .Font = New Font("Arial", 10, FontStyle.Regular)
            .ElementTree.Control.Cursor = Cursors.Default
        End With
    End Sub

End Class
