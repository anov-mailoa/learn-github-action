Imports R_Common
Imports TelerikMenu.MenuServiceRef
Imports R_FrontEnd
Imports ClientHelper

Public Class ChangeCompany
    Private Const C_ServiceName As String = "MenuService/MenuService.svc"

    Private Sub rrbChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rrbChange.Click
        'Dim oParentForm As Menu = Me.Owner

        CType(Me.Owner, Menu).gcNewCompanyId = R_RadDropDownList1.SelectedItem.Value.ToString.Trim

        CType(Me.Owner, Menu).glQuit = True
        CType(Me.Owner, Menu).Close()
        Me.Close()
    End Sub

    Private Sub ChangeCompany_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim loException As New R_Exception

        Try
            Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
            bsCompanyList.DataSource = loService.svc_getCompanyList(U_GlobalVar.UserId, U_GlobalVar.CompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            Me.R_DisplayException(loException)
        End If
    End Sub

    Private Sub rrbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rrbCancel.Click
        Me.Close()
    End Sub
End Class
