Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class R_LabelLayout
    Inherits RadLabelElement

    Public Sub New()
        With Me
            .ForeColor = Color.White
            '.TextAlignment = ContentAlignment.MiddleRight
            .Font = New Font("Verdana", 10, FontStyle.Regular)
            .NotifyParentOnMouseInput = True
            .ShouldHandleMouseInput = True
            .StretchHorizontally = False
            .AutoSize = True
            .RightToLeft = True
            .Size = New Size(100, 30)

            AddHandler .MouseEnter, AddressOf RadLabelElement_MouseEnter
            AddHandler .MouseLeave, AddressOf RadLabelElement_MouseLeave
        End With
    End Sub

    Private Sub RadLabelElement_MouseEnter(sender As Object, e As EventArgs)
        With Me
            .Font = New Font("Verdana", 10, FontStyle.Underline)
            .ElementTree.Control.Cursor = Cursors.Hand
        End With
    End Sub

    Private Sub RadLabelElement_MouseLeave(sender As Object, e As EventArgs)
        With Me
            .Font = New Font("Verdana", 10, FontStyle.Regular)
            .ElementTree.Control.Cursor = Cursors.Default
        End With
    End Sub

End Class
