Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls

Public Class R_MenuContext
    Inherits RadContextMenu

    Public Sub New()

    End Sub

    Public Sub New(poHeaderText As String)
        MyBase.New()

        If Not String.IsNullOrWhiteSpace(poHeaderText) Then
            Dim loRadMenuHeaderItem As New RadMenuHeaderItem
            loRadMenuHeaderItem.Text = poHeaderText
            Me.Items.Add(loRadMenuHeaderItem)
        End If
    End Sub

    Private Sub R_MenuContext_DropDownOpening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.DropDownOpening
        Dim oContextFill As FillPrimitive = TryCast(Me.DropDown.PopupElement.Children(0), FillPrimitive)
        If oContextFill IsNot Nothing Then
            oContextFill.BackColor = Color.FromArgb(51, 51, 51)
        End If

        Dim oContextBorder As BorderPrimitive = TryCast(Me.DropDown.PopupElement.Children(1), BorderPrimitive)
        If oContextBorder IsNot Nothing Then
            oContextBorder.Visibility = ElementVisibility.Collapsed
        End If

        Dim oContextSidePanel As RadElement = TryCast(Me.DropDown.PopupElement.Children(2), RadElement)
        If oContextSidePanel IsNot Nothing Then
            Dim oContextSidePanelFill As FillPrimitive = TryCast(oContextSidePanel.Children(0), FillPrimitive)
            If oContextSidePanelFill IsNot Nothing Then
                oContextSidePanelFill.Visibility = ElementVisibility.Collapsed
            End If
        End If

        Dim oRadMenuHeaderItem As RadMenuHeaderItem = Me.Items.Where(Function(x) TypeOf (x) Is RadMenuHeaderItem).FirstOrDefault
        If oRadMenuHeaderItem IsNot Nothing Then
            oRadMenuHeaderItem.Font = New Font("Segoe UI", 9)
            oRadMenuHeaderItem.FillPrimitive.BackColor = Color.FromArgb(51, 51, 51)
            oRadMenuHeaderItem.TextPrimitive.ForeColor = Color.White
        End If 
    End Sub
End Class
