Imports ClientHelper
Imports R_Common

Friend Class MainClass

    Private Sub New()

    End Sub

    <STAThread()> _
    Shared Sub main()
        Dim oFormLogin As LoginForm
        Dim oFormMenu As Menu
        Dim llChangeComp As Boolean = False
        Dim llQuit As Boolean = False
        Dim loEx As New R_Exception
        Dim cNewCompId As String = ""

        Try
            Do
                oFormLogin = New LoginForm

                If llChangeComp Then
                    oFormLogin.sChangeCompany(U_GlobalVar.UserId, cNewCompId)
                    llQuit = False
                End If
                If oFormLogin.ShowDialog() = DialogResult.OK Then
                    oFormMenu = New Menu
                    llQuit = oFormMenu.glQuit
                    oFormMenu.lblNotif.Text = oFormLogin.lcMessageToShowInMenu
                    If String.IsNullOrWhiteSpace(oFormLogin.lcMessageToShowInMenu) Then
                        oFormMenu.Visible = False
                    End If
                    oFormMenu.ShowDialog()

                    If oFormMenu.glQuit = False Then
                        llChangeComp = False
                        Exit Do
                    Else
                        cNewCompId = oFormMenu.gcNewCompanyId
                        llChangeComp = True
                        llQuit = oFormMenu.glQuit
                    End If
                End If
            Loop While (llQuit) = True

            Application.Exit()
        Catch ex As Exception
            loEx.Add(ex)
            If loEx.ErrorList(0).ErrNo = "efc003" Then
                MsgBox("DLL not found")
            End If
            MsgBox(loEx.ErrorList(0).ErrDescp)
        End Try
    End Sub
End Class
