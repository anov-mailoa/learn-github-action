Imports R_FrontEnd
Imports System.IO

Public Class R_SearchButtonLayout
    Inherits R_RadButton

    Public Sub New()

    End Sub

    Public Sub New(piY As Integer, pcName As String, pcText As String, pcImgFileName As String)
        MyBase.New()

        'Me.Location = New Point(13, 91 + piY)
        Me.Location = New Point(0, piY)
        Me.Text = pcText
        Me.ButtonElement.ToolTipText = pcText
        Me.Name = pcName
        Me.TextAlignment = ContentAlignment.MiddleLeft

        Try
            Me.Image = Image.FromFile(Application.StartupPath + "\Image\" + pcImgFileName + ".png").GetThumbnailImage(50, 50, Nothing, New IntPtr())
        Catch ex As FileNotFoundException
            Me.Image = My.Resources.ICON_ERROR_3.GetThumbnailImage(50, 50, Nothing, New IntPtr())
        Catch ex As Exception
        End Try

        With Me
            '.Size = New Size(267, 50)
            .Size = New Size(240, 50)
            '.Anchor = AnchorStyles.Right And AnchorStyles.Left
            .TextImageRelation = TextImageRelation.ImageBeforeText

            'set fill color
            .ButtonElement.ButtonFillElement.BackColor = Color.FromArgb(24, 24, 24)
            .ButtonElement.ButtonFillElement.NumberOfColors = 1
            .ButtonElement.ButtonFillElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid

            'set border color
            .ButtonElement.ShowBorder = False

            'set font color
            .ButtonElement.TextElement.ForeColor = Color.White
        End With
    End Sub

    Private Sub R_SearchButtonLayout_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        sender.ButtonElement.ButtonFillElement.BackColor = Color.FromArgb(51, 51, 51)
    End Sub

    Private Sub R_SearchButtonLayout_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        sender.ButtonElement.ButtonFillElement.BackColor = Color.FromArgb(24, 24, 24)
    End Sub
End Class
