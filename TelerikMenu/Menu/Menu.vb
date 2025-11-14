Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking
Imports System.IO
Imports R_FrontEnd
Imports ClientHelper
Imports TelerikMenu.MenuServiceRef
Imports TelerikMenu.MenuStreamingServiceRef
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.Layouts
Imports R_Common
Imports System.ServiceModel.Channels
Imports System.Configuration
Imports System.ServiceModel
Imports System.ComponentModel
Imports System.Reflection

Public Class Menu

#Region " VARIABLE(s) "
    Private Const C_ServiceName As String = "MenuService/MenuService.svc"
    Private Const C_ServiceNameMenuStream As String = "MenuService/MenuStreamingService/MenuStreamingService.svc"
    Private Const C_ServiceNameLogin As String = "LoginService/LoginService.svc"
    Dim gcCompanyId As String = U_GlobalVar.CompId
    Dim gcUserId As String = U_GlobalVar.UserId.ToLower
    Dim _oRadPanorama As Telerik.WinControls.UI.RadPanorama
    Dim _nLevel As Integer
    Dim goImageList As New List(Of String)
    Dim glGroup As Boolean
    Dim glProgram As Boolean
    Dim grtbPanoramaGroupName As RadTextBox
    Dim grtbTileGroupElementFolderName As RadTextBox
    Dim grtbTileGroupElementFolderRename As RadTextBox
    Dim goTileGroupElement As TileGroupElement
    Dim grtbTileFolderRename As RadTextBox
    Dim goRadTileElement As RadTileElement
    Dim goRadButtonElement As RadButtonElement
    Dim goRadMenuComboItem As RadMenuComboItem
    Dim gnOldColumn As Integer
    Dim gnOldRow As Integer
    Dim gcOldGroupTile As String
    Dim goLocation As System.Drawing.Point
    Friend goRadDock As RadDock = New RadDock()
    Dim loHostFAV As HostWindow
    Dim goMenuProgramAccessDTOList As List(Of MenuProgramAccessDTO) = U_GlobalVar.ProgramAccessDTOList
    Public Const WM_SIZE As Integer = 5
    Private WithEvents goTitleBar As R_MenuTitleBarElement
    Dim labelUser As New R_LabelLayout()
    Dim loMenuDTOList As New List(Of MenuDTO)
    Dim loPanoramaFAV As Telerik.WinControls.UI.RadPanorama
    Public glQuit As Boolean = False
    Public gcNewCompanyId As String = ""
    Private _lValid As Boolean = True
    Private _lWithHistory As Boolean = True
    'Dim oRadDropDownListElement As RadDropDownListElement
    'Dim loHostSearch As HostWindow
    'Dim loPanoramaSearch As RadPanorama
    Private goMenuDTOList As List(Of MenuDTO)
    Private goHostWindowList As List(Of HostWindow)
#End Region

#Region " ENUMERATION "
    Enum geImageTextAlignment
        BottomCenter = 512
        BottomLeft = 256
        BottomRight = 1024
        MiddleCenter = 32
        MiddleLeft = 16
        MiddleRight = 64
        TopCenter = 2
        TopLeft = 1
        TopRight = 4
    End Enum

    Enum geTextImageRelation
        ImageAboveText = 1
        ImageBeforeText = 4
        Overlay = 0
        TextAboveImage = 2
        TextBeforeImage = 8
    End Enum
#End Region

#Region " EVENT "
#Region " RealtaMenu_Load "
    Public Sub New()
        Dim loEx As New R_Exception()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            goRadDock.BeginInit()
            goRadDock.Dock = DockStyle.Fill
            goRadDock.DragDropMode = DragDropMode.Preview
            goRadDock.ShowDocumentCloseButton = True
            goRadDock.Focusable = True
            goRadDock.TabStop = True
            goRadDock.DocumentManager.DocumentInsertOrder = DockWindowInsertOrder.ToBack
            goRadDock.DocumentManager.BoldActiveDocument = True

            '' Add Handler raddock
            AddHandler goRadDock.DockWindowClosing, AddressOf goRadDock_DockClosing
            AddHandler goRadDock.DockWindowClosed, AddressOf goRadDock_DockWindowClosed
            AddHandler goRadDock.ActiveWindowChanged, AddressOf goRadDock_ActiveWindowChanged
            goRadDock.EndInit()

            'set transparent document container
            If goRadDock.Controls.Count > 0 Then
                CType(goRadDock.Controls(0), DocumentContainer).SplitContainer.SplitPanelElement.Fill.ShouldPaint = False
                CType(goRadDock.Controls(0), DocumentContainer).SplitPanelElement.Fill.ShouldPaint = False
            End If

            'set side panel bar to Transparent
            Dim loDockAutoHideTabStrip As AutoHideTabStripElement = CType(goRadDock.SplitPanelElement.Children(2).Children(2), AutoHideTabStripElement)
            With loDockAutoHideTabStrip
                .BackColor = Color.Transparent
                .NumberOfColors = 1
                .DrawBorder = False
            End With

            '' METHOD | Get Menu Tree And Create Panorama
            _getTree("", "", 1)

            _CreateSearchDock(goMenuDTOList)

            'check program on favourite tab and hide if nothing
            Dim iCountTileFav As Integer = CType(loPanoramaFAV.Groups(0), TileGroupElement).Items.Count

            'set color to side tab
            Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
            For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                With dockTabStripItem
                    If .Text = "Favourites" Then
                        If iCountTileFav = 0 Then
                            .Visibility = ElementVisibility.Collapsed
                        End If
                    End If
                    .ForeColor = Color.White
                    '.BackColor = Color.IndianRed
                    .BackColor = Color.FromArgb(93, 46, 145)
                    .GradientStyle = GradientStyles.Solid
                    .DrawBorder = False
                    .NumberOfColors = 1
                    .Font = New Font("Verdana", 12.0F, FontStyle.Regular)
                    .FlipText = True
                    .Margin = New Padding(0, 0, 0, 2)
                End With

                AddHandler dockTabStripItem.MouseEnter, AddressOf dockTabStripItem_MouseEnter
                AddHandler dockTabStripItem.MouseLeave, AddressOf dockTabStripItem_MouseLeave
            Next

            Dim autoHideTab = Me.goRadDock.GetAutoHideTabStrip(AutoHidePosition.Left)
            autoHideTab.StripButtons = StripViewButtons.LeftScroll Or StripViewButtons.RightScroll Or StripViewButtons.ItemList
            CType(autoHideTab.Children(0).Children(1).Children(0), RadPageViewStripButtonElement).Image = My.Resources.up.GetThumbnailImage(12, 12, Nothing, New IntPtr)
            CType(autoHideTab.Children(0).Children(1).Children(0), RadPageViewStripButtonElement).ImageLayout = ImageLayout.Stretch
            CType(autoHideTab.Children(0).Children(1).Children(0), RadPageViewStripButtonElement).ToolTipText = "Scroll Up"

            CType(autoHideTab.Children(0).Children(1).Children(1), RadPageViewStripButtonElement).Image = My.Resources.down.GetThumbnailImage(12, 12, Nothing, New IntPtr)
            CType(autoHideTab.Children(0).Children(1).Children(1), RadPageViewStripButtonElement).ImageLayout = ImageLayout.Stretch
            CType(autoHideTab.Children(0).Children(1).Children(1), RadPageViewStripButtonElement).ToolTipText = "Scroll Down"

            CType(autoHideTab.Children(0).Children(1).Children(2), RadPageViewStripButtonElement).Image = My.Resources.garis.GetThumbnailImage(12, 12, Nothing, New IntPtr)
            CType(autoHideTab.Children(0).Children(1).Children(2), RadPageViewStripButtonElement).ImageLayout = ImageLayout.Stretch
            CType(autoHideTab.Children(0).Children(1).Children(2), RadPageViewStripButtonElement).ToolTipText = "Available Menu"

            autoHideTab.ItemContainer.ButtonsPanel.Visibility = ElementVisibility.Visible
            Dim autoHideParent As RadPageViewStripElement = TryCast(autoHideTab.ItemContainer.Parent, RadPageViewStripElement)
            Dim fi As FieldInfo = GetType(RadPageViewElement).GetField("itemListMenu", BindingFlags.Instance Or BindingFlags.NonPublic)
            Dim contextMenu As RadContextMenu = fi.GetValue(autoHideParent)
            AddHandler contextMenu.DropDownOpened, AddressOf DropDownOpened

            AddHandler goRadDock.DockStateChanging, AddressOf goRadDock_DockStateChanging
            AddHandler goRadDock.DockStateChanged, AddressOf goRadDock_DockStateChanged
            AddHandler goRadDock.AutoHideWindowDisplaying, AddressOf goRadDock_AutoHideWindowDisplaying
            AddHandler goRadDock.AutoHideWindowHiding, AddressOf goRadDock_AutoHideWindowHiding
            AddHandler goRadDock.AutoHideWindowHidden, AddressOf goRadDock_AutoHideWindowHidden

            Dim service As DragDropService = goRadDock.GetService(Of DragDropService)()
            service.AllowedDockManagerEdges = AllowedDockPosition.Fill
            AddHandler service.Stopped, AddressOf service_Stopping

            Me.R_HelpFile = "First_Topic" 'set name help_file
        Catch ex As FileNotFoundException
            '' If Layout.DockTemplate Not Found - Do Nothing
        Catch ex As FaultException(Of R_Common.R_ServiceExceptions)
            loEx.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loEx.Add(ex)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub DropDownOpened(sender As Object, e As EventArgs)
        Dim contextMenu As RadContextMenu = TryCast(sender, RadContextMenu)
        For Each item As RadMenuItem In contextMenu.Items
            AddHandler item.MouseDown, AddressOf ItemClick
        Next
    End Sub

    Private Sub ItemClick(sender As Object, e As EventArgs)
        Dim loEx As New R_Exception

        Try
            Dim menuItem As RadMenuItem = TryCast(sender, RadMenuItem)
            Dim tabStrip As TabStripItem = TryCast(menuItem.Tag, TabStripItem)

            Dim loHost As HostWindow = goHostWindowList.Where(Function(x) x.Name = tabStrip.Text).FirstOrDefault

            If loHost IsNot Nothing Then
                Me.goRadDock.ShowAutoHidePopup(loHost)
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub Menu_Initialized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Initialized
        Dim lcIcon As String = ConfigurationManager.AppSettings("ImgIcon").ToString()
        Dim lcIconPath As String = Application.StartupPath + "\Image\" + lcIcon

        'set application icon
        If IO.File.Exists(lcIconPath) Then
            Me.Icon = New Icon(lcIconPath)
        Else
            Me.Icon = My.Resources.icon
        End If

        '' Add Dock to Panel
        Me.panelContent.Controls.Add(goRadDock)

        'hide title bar
        Me.FormElement.TitleBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

        'set panel background to transparent
        Me.panelTitle.BackColor = Color.Black

        'set form background
        Me.BackColor = Color.Black
        Me.SetStyle(Windows.Forms.ControlStyles.SupportsTransparentBackColor, True)

        Dim lcBackground As String = ConfigurationManager.AppSettings("ImgBG_Menu").ToString()
        Dim lcBGPath As String = Application.StartupPath + "\Image\" + lcBackground
        If IO.File.Exists(lcBGPath) Then
            Me.panelContent.BackgroundImage = Image.FromFile(lcBGPath)
        Else
            Me.panelContent.BackgroundImage = My.Resources.bg_apps
        End If

        'set panel border to transparent
        Dim loPanelTitleElement As BorderPrimitive = CType(Me.panelTitle.PanelElement.Children.Where(Function(x) x.GetType.Name = "BorderPrimitive").FirstOrDefault, BorderPrimitive)
        Dim loPanelContentElement As BorderPrimitive = CType(Me.panelContent.PanelElement.Children.Where(Function(x) x.GetType.Name = "BorderPrimitive").FirstOrDefault, BorderPrimitive)
        loPanelTitleElement.ForeColor = Color.Transparent
        loPanelContentElement.ForeColor = Color.Transparent

        PrepareTitleBar()
        PrepareHeader()

        'add icon on top left form
        Dim oIcon As New R_IconLayout()
        With oIcon
            .Name = "icon"
            .Margin = New Padding(10, 1, 0, 0)
            With CType(.Children(0).Children(0), LightVisualElement)
                lcBackground = ConfigurationManager.AppSettings("ImgIcon").ToString()
                lcBGPath = Application.StartupPath + "\Image\" + lcBackground
                If IO.File.Exists(lcBGPath) Then
                    .Image = Image.FromFile(lcBGPath).GetThumbnailImage(25, 22, Nothing, New IntPtr())
                Else
                    .Image = My.Resources.icon.ToBitmap
                End If
            End With
        End With
        Me.panelTitle.PanelElement.Children.Add(oIcon)

        'add label on top right form
        With labelUser
            .Name = "MyProfile"
            .Margin = New Padding(Me.Width - 200, 30, 30, 5)
            .Text = U_GlobalVar.UserName.ToUpper
            AddHandler .Click, AddressOf oBtnMyProfile_Click
        End With
        Me.panelTitle.PanelElement.Children.Add(labelUser)

        'set form model
        CType(Me, R_IFormBase)._SetFormModel(R_eFormModel.Menu)
    End Sub

    Private Sub RealtaMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim loEx As New R_Exception

        Try
            '' SYSYSYSYSY - This need to save to DB - Set Default Theme
            ThemeResolutionService.LoadPackageFile(My.Application.Info.DirectoryPath + "\ControlDefaultEDIT.tssp")
            ThemeResolutionService.ApplicationThemeName = "ControlDefaultEDIT"

            Me.ActiveControl = goRadDock

            'check program on favourite tab and hide if nothing
            Dim iCountTileFav As Integer = CType(loPanoramaFAV.Groups(0), TileGroupElement).Items.Count

            If iCountTileFav > 0 Then
                goRadDock.ShowAutoHidePopup(goRadDock.GetHostWindow(loPanoramaFAV))
            Else
                If goHostWindowList.Count > 0 Then
                    Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
                    If loDockTabStripItem.Children.Count > 0 Then
                        Dim dockTabStripItem As TabStripItem = loDockTabStripItem.Children.Where(Function(x) CType(x, TabStripItem).Text = "Favourites").FirstOrDefault
                        If dockTabStripItem IsNot Nothing Then
                            If dockTabStripItem.Visibility = ElementVisibility.Collapsed Then
                                goRadDock.ShowAutoHidePopup(goRadDock.GetHostWindow(goHostWindowList(1).Controls(0)))
                            Else
                                goRadDock.ShowAutoHidePopup(goRadDock.GetHostWindow(goHostWindowList(0).Controls(0)))
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region

#Region " RealtaMenu_FormClosing "
    Private Sub RealtaMenu_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim loEx As New R_Exception()
        Dim lHasCRUDForm As Boolean
        Dim lcMsgText As String

        Try
            Dim oAllWindows = goRadDock.DockWindows.Where(Function(x) x.GetType.Name = "R_DocumentWindow")

            If oAllWindows IsNot Nothing Then
                For Each oWinParent As R_DocumentWindow In oAllWindows
                    Dim oAllWindowsChild = CType(oWinParent.Controls(0).Controls(0), RadDock).DockWindows
                    For Each oWinChild As R_DocumentWindow In oAllWindowsChild
                        If oWinChild.R_Form IsNot Nothing Then
                            If CType(oWinChild.R_Form, R_FormBase).R_IsCRUDActive Then
                                CType(oWinChild.R_Form, R_FormBase).R_IsCloseFromMenu = True
                                lHasCRUDForm = True
                            End If
                        End If
                    Next
                Next
            End If

            If lHasCRUDForm Then
                lcMsgText = R_Utility.R_GetMessage(Me.GetType, "_CRUDConfirmation")
            Else
                lcMsgText = R_Utility.R_GetMessage(Me.GetType, "_CloseConfirmation")
            End If

            Select Case R_RadMessageBox.Show(lcMsgText, _
                                             R_Utility.R_GetMessage(Me.GetType, "_Confirmation"), MessageBoxButtons.OKCancel)
                Case Windows.Forms.DialogResult.OK

                    '' Close All Documents
                    goRadDock.CloseAllWindows()

                    Dim loService As LoginServiceRef.LoginServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of LoginServiceRef.ILoginService, LoginServiceRef.LoginServiceClient)(e_ServiceClientType.RegularService, C_ServiceNameLogin)
                    If Me.glQuit Then 'TRUE = CHANGE COMPANY
                        loService.Svc_R_UserLockingCompany(U_GlobalVar.CompId, gcNewCompanyId, U_GlobalVar.UserId)
                    Else
                        loService.Svc_R_UserLockingFlush(U_GlobalVar.CompId, U_GlobalVar.UserId)
                    End If

                    loService.Close()
                    'Dim loInitiator As IInitiator = New U_GlobalVar
                    'loInitiator.Set_CompId(Me.gcNewCompanyId)
                Case Else
                    glQuit = False
                    e.Cancel = True
            End Select

        Catch ex As Exception
            loEx.Add(ex)
            e.Cancel = True
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#End Region

#Region " HANDLER "
#Region " CONTEXT MENU CLICK "
#Region " rmiMoveGroupUp_Click "
    Private Sub rmiMoveGroupUp_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            '' Close Context Menu
            rcmTileGroupElementMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)

            '' Prepare Parameter
            Dim loParam As New MenuDTO
            With loParam
                .CCOMPANY_ID = gcCompanyId
                .CUSER_ID = gcUserId
                .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                .CSUB_MENU_TYPE = "G"
                .CSUB_MENU_ID = goTileGroupElement.Name.Trim
                .IGROUP_INDEX = _oRadPanorama.Groups.IndexOf(goTileGroupElement)
                .ILEVEL = _nLevel
            End With
            '' Update Group Name To DB
            loService.updateGroupIndexToDB(loParam, "UP")

            '' Change Index
            Dim lnIndexMoved As Integer
            Dim lnIndexMovedTo As Integer
            Dim loGroupMoved As TileGroupElement

            lnIndexMoved = _oRadPanorama.Groups.IndexOf(goTileGroupElement)
            lnIndexMovedTo = lnIndexMoved - 1
            loGroupMoved = _oRadPanorama.Groups.Item(lnIndexMoved)

            _oRadPanorama.Groups.Remove(loGroupMoved)
            _oRadPanorama.Groups.Insert(lnIndexMovedTo, loGroupMoved)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#Region " rmiMoveGroupDown_Click "
    Private Sub rmiMoveGroupDown_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            '' Close Context Menu
            rcmTileGroupElementMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)

            '' Prepare Parameter
            Dim loParam As New MenuDTO
            With loParam
                .CCOMPANY_ID = gcCompanyId
                .CUSER_ID = gcUserId
                .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                .CSUB_MENU_TYPE = "G"
                .CSUB_MENU_ID = goTileGroupElement.Name.Trim
                .IGROUP_INDEX = _oRadPanorama.Groups.IndexOf(goTileGroupElement)
                .ILEVEL = _nLevel
            End With
            '' Update Group Name To DB
            loService.updateGroupIndexToDB(loParam, "DOWN")

            '' Change Index
            Dim lnIndexMoved As Integer
            Dim lnIndexMovedTo As Integer
            Dim loGroupMoved As TileGroupElement

            lnIndexMoved = _oRadPanorama.Groups.IndexOf(goTileGroupElement)
            lnIndexMovedTo = lnIndexMoved + 1
            loGroupMoved = _oRadPanorama.Groups.Item(lnIndexMoved)

            _oRadPanorama.Groups.Remove(loGroupMoved)
            _oRadPanorama.Groups.Insert(lnIndexMovedTo, loGroupMoved)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#Region " rmiRenameGroup_Click "
    Private Sub rmiRenameGroup_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            If grtbTileGroupElementFolderRename.Text.Trim = "" Then
                R_RadMessageBox.Show(R_Utility.R_GetError(Me.GetType, "Err003").ErrDescp)
            Else
                '' Close Context Menu
                rcmTileGroupElementMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)

                '' Prepare Parameter
                Dim loParam As New MenuDTO
                With loParam
                    .CCOMPANY_ID = gcCompanyId
                    .CUSER_ID = gcUserId
                    .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                    .CSUB_MENU_TYPE = "G"
                    .CSUB_MENU_ID = goTileGroupElement.Name.Trim
                    .CSUB_MENU_NAME = grtbTileGroupElementFolderRename.Text.Trim
                    .CSUB_MENU_TOOL_TIP = grtbTileGroupElementFolderRename.Text.Trim
                End With
                '' Update Group Name To DB
                loService.updateMenuNameToDB(loParam)

                '' Update Group Name & ToolTip
                goTileGroupElement.Text = grtbTileGroupElementFolderRename.Text.Trim
                goTileGroupElement.ToolTipText = grtbTileGroupElementFolderRename.Text.Trim

                '' Set Tile Group Element Folder Rename text to ""
                grtbTileGroupElementFolderRename.Text = ""
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#Region " rmiDeleteGroup_Click "
    Private Sub rmiDeleteGroup_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            '' Close Context Menu
            rcmTileGroupElementMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)

            '' Prepare Parameter
            Dim loParam As New MenuDTO
            With loParam
                .CCOMPANY_ID = gcCompanyId
                .CUSER_ID = gcUserId
                .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                .CSUB_MENU_TYPE = "G"
                .CSUB_MENU_ID = goTileGroupElement.Name.Trim
            End With
            '' Delete Group From DB
            loService.deleteMenuFromDB(loParam)

            '' Delete Group
            goTileGroupElement.Dispose()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#Region " rmiMarkAsFavourite_Click "
    Private Sub rmiMarkAsFavourite_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            '' Close Context Menu
            rcmTileMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)

            'set dto
            Dim loParam As New MenuDTO
            With loParam
                .CCOMPANY_ID = gcCompanyId
                .CUSER_ID = gcUserId
                .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                .CSUB_MENU_TYPE = goRadTileElement.Tag.ToString.Trim
                .CSUB_MENU_ID = goRadTileElement.Name.Trim
                .LFAVORITE = True
            End With

            If loService.checkMenuFavourite(loParam) = False Then
                loService.saveMenuFavourite(loParam)

                'get lohost favourite
                Dim groupElement As TileGroupElement = CType(CType(loHostFAV.Controls(0), RadPanorama).Groups(0), TileGroupElement)
                _createTile(groupElement, New MenuDTO With {.CSUB_MENU_ID = goRadTileElement.Name.Trim,
                                                               .CSUB_MENU_NAME = goRadTileElement.Text.Trim,
                                                               .CSUB_MENU_TOOL_TIP = goRadTileElement.ToolTipText.Trim,
                                                               .CSUB_MENU_IMAGE = loService._getProgramImage(loParam),
                                                            .CSUB_MENU_TYPE = goRadTileElement.Tag.ToString.Trim})

                Dim iCountTileFav As Integer = CType(loPanoramaFAV.Groups(0), TileGroupElement).Items.Count
                'set color to side tab
                Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
                For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                    With dockTabStripItem
                        If .Text = "Favourites" Then
                            If iCountTileFav = 0 Then
                                .Visibility = ElementVisibility.Collapsed
                            Else
                                .Visibility = ElementVisibility.Visible
                            End If
                        End If
                        .ForeColor = Color.White
                        '.BackColor = Color.IndianRed
                        .BackColor = Color.FromArgb(93, 46, 145)
                        .GradientStyle = GradientStyles.Solid
                        .DrawBorder = False
                        .NumberOfColors = 1
                        .Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)

                    End With

                    AddHandler dockTabStripItem.MouseEnter, AddressOf dockTabStripItem_MouseEnter
                    'AddHandler dockTabStripItem.MouseLeave, AddressOf dockTabStripItem_MouseLeave
                Next
            Else
                R_RadMessageBox.Show(R_Utility.R_GetError(Me.GetType, "Err004").ErrDescp)
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#Region " rmiUnMarkFavourite_Click "
    Private Sub rmiUnMarkFavourite_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            '' Close Context Menu
            rcmButtonFavouriteMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)
            '' Update Button as Not favourite
            '' Prepare Parameter
            Dim loParam As New MenuDTO
            With loParam
                .CCOMPANY_ID = gcCompanyId
                .CUSER_ID = gcUserId
                .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                .CSUB_MENU_TYPE = "P"
                .CSUB_MENU_ID = goRadTileElement.Name.Trim
                .LFAVORITE = False
            End With
            '' Cek program exist in folder
            loService.deleteMenuFavourite(loParam)

            'get lohost favourite
            Dim groupElement As TileGroupElement = CType(CType(loHostFAV.Controls(0), RadPanorama).Groups(0), TileGroupElement)

            groupElement.Items.Remove(groupElement.Items(goRadTileElement.Name))

            'check program on favourite tab and hide if nothing
            Dim iCountTileFav As Integer = CType(loPanoramaFAV.Groups(0), TileGroupElement).Items.Count
            'set color to side tab
            Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
            For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                With dockTabStripItem
                    If .Text = "Favourites" Then
                        If iCountTileFav = 0 Then
                            .Visibility = ElementVisibility.Collapsed
                            Dim hw As HostWindow = TryCast(loPanoramaFAV.Parent, HostWindow)
                            Dim popup As AutoHidePopup = TryCast(hw.ParentForm, AutoHidePopup)
                            popup.Hide()
                            groupElement.Text = "Favourites"
                        Else
                            .Visibility = ElementVisibility.Visible
                        End If
                    End If
                    .ForeColor = Color.White
                    '.BackColor = Color.IndianRed
                    .BackColor = Color.FromArgb(93, 46, 145)
                    .GradientStyle = GradientStyles.Solid
                    .DrawBorder = False
                    .NumberOfColors = 1
                    .Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)
                End With

                AddHandler dockTabStripItem.MouseEnter, AddressOf dockTabStripItem_MouseEnter
                'AddHandler dockTabStripItem.MouseLeave, AddressOf dockTabStripItem_MouseLeave
            Next
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#End Region

#Region "ADD HANDLER METHOD"
#Region "HANDLER DOCKING"
    Private Sub goRadDock_AutoHideWindowHidden(sender As Object, e As DockWindowEventArgs)
        Try
            Dim loDockDocContainer As DocumentContainer

            'get document container
            For Each ctrl In goRadDock.Controls
                If TypeOf ctrl Is DocumentContainer Then
                    loDockDocContainer = ctrl
                End If
            Next

            If loDockDocContainer IsNot Nothing Then
                If loDockDocContainer.Controls.Count > 0 Then
                    CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Opacity = 1
                    CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.BackColor = Color.Transparent
                    CType(CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Children(0), FillPrimitive).Opacity = 1
                    CType(CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Children(2), RadPageViewTabStripElement).Opacity = 1
                    CType(CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Children(2).Children(1), RadPageViewContentAreaElement).Opacity = 1
                    CType(CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Children(2).Children(1), RadPageViewContentAreaElement).BackColor = SystemColors.ControlLightLight

                    'unhide documenttab strip
                    CType(loDockDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Visibility = ElementVisibility.Visible
                    If CType(loDockDocContainer.Controls(0), DocumentTabStrip).Controls.Count > 0 Then
                        CType(CType(loDockDocContainer.Controls(0).Controls(0), DocumentWindow).Controls(0), RadForm).Parent.Parent.Visible = True
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub goRadDock_AutoHideWindowHiding(sender As Object, e As DockWindowCancelEventArgs)
        'set color on active tab
        Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
        For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
            With dockTabStripItem
                If .Text = e.NewWindow.Text Then
                    '.BackColor = Color.IndianRed
                    .BackColor = Color.FromArgb(93, 46, 145)
                End If
            End With
        Next
    End Sub

    Private Sub goRadDock_AutoHideWindowDisplaying(sender As Object, e As AutoHideWindowDisplayingEventArgs) 'after window move to dock then set dockstate to auto hide
        Dim hw As HostWindow = TryCast(e.NewWindow, HostWindow)
        Dim popup As AutoHidePopup = TryCast(hw.ParentForm, AutoHidePopup)
        popup.AllowTransparency = True
        Dim loDockDocContainer As DocumentContainer
        Dim loEx As New R_Exception

        Try
            'get document container
            For Each ctrl In goRadDock.Controls
                If TypeOf ctrl Is DocumentContainer Then
                    loDockDocContainer = ctrl
                End If
            Next

            If loDockDocContainer.Controls.Count = 0 Then
                popup.BackColor = Color.Black
                popup.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                popup.FormElement.Border.BackColor = Color.White
            Else
                popup.BackColor = Color.Black
                popup.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                popup.FormElement.Border.BackColor = Color.White

                'hide documentab strip
                Dim oDockStrip As DocumentTabStrip

                oDockStrip = TryCast(loDockDocContainer.Controls(0), DocumentTabStrip)
                If oDockStrip IsNot Nothing Then
                    oDockStrip.SplitPanelElement.Visibility = ElementVisibility.Hidden

                    If oDockStrip.Controls.Count > 0 Then
                        CType(CType(oDockStrip.Controls(0), DocumentWindow).Controls(0), RadForm).Parent.Parent.Visible = False
                    End If
                End If
            End If

            'set transparent host window border
            CType(popup.ToolStrip.SplitPanelElement.Children(1), BorderPrimitive).ForeColor = Color.Transparent

            'set color on active tab
            Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
            For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                With dockTabStripItem
                    If .Text = e.NewWindow.Text Then
                        '.BackColor = Color.Black
                        .BackColor = Color.FromArgb(145, 100, 195)
                    Else
                        '.BackColor = Color.IndianRed
                        .BackColor = Color.FromArgb(93, 46, 145)
                    End If
                End With
            Next
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub goRadDock_DockStateChanging(sender As Object, e As DockStateChangingEventArgs) 'after window move to dock then set dockstate to auto hide
        Try
            If e.NewDockState = DockState.Floating Then
                e.Cancel = True
                Exit Try
            End If
            If CType(sender, RadDock).DockWindows.DocumentWindows.Count = 1 And e.NewDockState <> DockState.Hidden Then
                e.Cancel = True
                Exit Try
            End If
            If e.NewDockState = DockState.Docked And e.NewWindow.DockState = DockState.Floating Then
                e.NewWindow.DockState = DockState.AutoHide
            ElseIf e.NewDockState = DockState.AutoHide Then
                'set back DockingButtonLayout on autohide state
                Dim dockBtn As R_DockingButtonLayout = CType(CType(e.NewWindow.Controls(0), RadPanorama).PanoramaElement.Children. _
                       Where(Function(x) x.GetType.Name = "DockingButtonLayout").FirstOrDefault, R_DockingButtonLayout)
                dockBtn.Margin = New Padding(Me.Width - 100, 15, 0, 0)

                'set back header panorama font to light gray
                Dim oHeaderPanorama As LightVisualElement = CType(CType(e.NewWindow.Controls(0), RadPanorama).PanoramaElement.Children(3).Children. _
                    Where(Function(x) x.GetType.Name = "LightVisualElement").FirstOrDefault, LightVisualElement)
                oHeaderPanorama.ForeColor = Color.LightGray

                'set back header group to white
                For Each group As TileGroupElement In CType(e.NewWindow.Controls(0), RadPanorama).Groups
                    group.ForeColor = Color.White
                Next
            End If
            If e.NewDockState = DockState.Docked Then
                If e.NewWindow.DockState = DockState.AutoHide Then
                    e.NewWindow.AutoHideSize = New Size(Me.Width, e.NewWindow.Height)

                    'set DockingButtonLayout on docked state 
                    Dim dockBtn As R_DockingButtonLayout = CType(CType(e.NewWindow.Controls(0), RadPanorama).PanoramaElement.Children. _
                        Where(Function(x) x.GetType.Name = "DockingButtonLayout").FirstOrDefault, R_DockingButtonLayout)
                    dockBtn.Margin = New Padding(e.NewWindow.Width - 50, 0, 0, 0)

                    'set header panorama font to black
                    Dim oHeaderPanorama As LightVisualElement = CType(CType(e.NewWindow.Controls(0), RadPanorama).PanoramaElement.Children(3).Children. _
                        Where(Function(x) x.GetType.Name = "LightVisualElement").FirstOrDefault, LightVisualElement)
                    oHeaderPanorama.ForeColor = Color.Black

                    'set header group to gray
                    For Each group As TileGroupElement In CType(e.NewWindow.Controls(0), RadPanorama).Groups
                        group.ForeColor = Color.Gray
                    Next

                    AddHandler e.NewWindow.Resize, AddressOf Hostwindow_Resize
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub goRadDock_DockStateChanged(sender As Object, e As DockWindowEventArgs)
        If e.DockWindow.DockTabStrip IsNot Nothing Then
            'hide titlebar on hostwindow
            Dim loHostDockLayout As DockLayoutPanel = CType(e.DockWindow.DockTabStrip.SplitPanelElement.Children.Where(Function(x) x.GetType.Name = "DockLayoutPanel").FirstOrDefault, DockLayoutPanel)
            loHostDockLayout.Visibility = ElementVisibility.Collapsed
        End If

        'set gray to side tab
        Dim loDockTabStripItem As StripViewItemLayout = CType(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
        For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
            With dockTabStripItem
                .ForeColor = Color.White
                '.BackColor = Color.IndianRed
                .BackColor = Color.FromArgb(93, 46, 145)
                .GradientStyle = GradientStyles.Solid
                .DrawBorder = False
                .NumberOfColors = 1
            End With

            AddHandler dockTabStripItem.MouseEnter, AddressOf dockTabStripItem_MouseEnter
            'AddHandler dockTabStripItem.MouseLeave, AddressOf dockTabStripItem_MouseLeave
        Next
    End Sub

    Private Sub goRadDock_DockClosing(sender As Object, e As Telerik.WinControls.UI.Docking.DockWindowCancelEventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception

        Try
            Dim loDockCollection = CType(e.NewWindow.Controls(0).Controls(0), RadDock).DockWindows 'cek dari kanan

            Dim loDockList As New List(Of R_DocumentWindow)

            For Each oDoc As R_DocumentWindow In loDockCollection
                loDockList.Add(oDoc)
            Next

            For Each loDocumentWindow As R_DocumentWindow In loDockList
                loDocumentWindow.R_Form.R_IsCloseFromMenu = False
                'loDocumentWindow.R_Form.R_Closing(e)
                If loDocumentWindow.R_Form.R_FormModel = R_eFormModel.Detail Then
                    loDocumentWindow.Close()
                Else
                    loDocumentWindow.R_Form.R_Closing(e)
                End If

                If Not e.Cancel Then
                    If loDocumentWindow.R_Form IsNot Nothing AndAlso loDocumentWindow.R_PredefinedDockComponent Is Nothing Then
                        'insert history
                        If _lWithHistory And loDocumentWindow.R_Form.Name <> "MyProfile" And loDocumentWindow.R_Form.Owner Is Nothing Then
                            loService.SaveHistory(U_GlobalVar.CompId, U_GlobalVar.UserId, loDocumentWindow.R_Form.Name, "CLOSE")
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            loEx.Add(ex)
        Finally
            loService.Close()
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub goRadDock_DockWindowClosed(sender As Object, e As Telerik.WinControls.UI.Docking.DockWindowEventArgs)
        Dim loDockDocContainer As DocumentContainer
        Dim loEx As New R_Exception

        Try
            'get document container
            For Each ctrl In goRadDock.Controls
                If TypeOf ctrl Is DocumentContainer Then
                    loDockDocContainer = ctrl
                End If
            Next

            If loDockDocContainer.Controls.Count > 0 Then
                Dim oDockTabStrip As DocumentTabStrip
                oDockTabStrip = TryCast(loDockDocContainer.Controls(0), DocumentTabStrip)
                If oDockTabStrip IsNot Nothing Then
                    If oDockTabStrip.Controls.Count = 0 Then
                        lblNotif.BringToFront()
                    End If
                End If
            End If

            If goRadDock.DockWindows.DocumentWindows.Count <= 5 Then
                For Each oDock As R_DocumentWindow In goRadDock.DockWindows.DocumentWindows
                    oDock.DocumentButtons = DocumentStripButtons.None
                Next
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub goRadDock_ActiveWindowChanged(sender As Object, e As Telerik.WinControls.UI.Docking.DockWindowEventArgs)
        If e.DockWindow IsNot Nothing And TypeOf (e.DockWindow) Is R_DocumentWindow Then
            Dim loInitiator As IInitiator = New U_GlobalVar

            Dim lcProgId As String = CType(e.DockWindow, R_DocumentWindow).R_ProgramId
            If Not String.IsNullOrEmpty(lcProgId) Then
                loInitiator.Set_PrgId(lcProgId)
            End If
        End If
    End Sub
#End Region

#Region "HANDLER GROUP TILE"
    Private Sub TileGroupElement_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        glGroup = False
        goTileGroupElement = sender
        glGroup = True
    End Sub
#End Region

#Region "HANDLER TILE"
    Private Sub TileElement_MouseEnter(ByVal sender As Object, ByVal args As EventArgs)
        CType(sender, RadTileElement).BorderColor = Color.DarkSlateGray
    End Sub

    Private Sub TileElement_MouseLeave(ByVal sender As Object, ByVal args As EventArgs)
        CType(sender, RadTileElement).BorderColor = Color.Transparent
    End Sub

    Private Sub RadTileElement_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim loEx As New R_Exception()

        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                If Cursor.Position = goLocation Then
                    With CType(sender, RadTileElement)
                        If .Tag = "F" Then
                            '' Set Global Level
                            _nLevel = _nLevel + 1
                            '' Get Menu Tree And Create Panorama
                            _getTree(_oRadPanorama.Name.ToString.Trim, goRadTileElement.Name.Trim, _nLevel)
                        Else
                            Me.Cursor = Cursors.WaitCursor
                            _createDockDocumentWindow(sender)
                            Me.Cursor = Nothing
                            If _lValid Then
                                hideDocContainer()
                            End If
                            _lValid = True
                        End If
                    End With

                    goLocation = Nothing
                    Console.WriteLine("MouseLeave")
                End If
            End If
            Console.WriteLine("Up - Done")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub

    Private Sub RadTileElement_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        goRadTileElement = sender
        '' Cek Left Mouse Click
        If e.Button = Windows.Forms.MouseButtons.Left Then
            goLocation = Cursor.Position
            With CType(sender, RadTileElement)
                gnOldColumn = .Column
                gnOldRow = .Row
                gcOldGroupTile = .Parent.Parent.Name
                Console.WriteLine("MouseDown - Column = " + .Column.ToString + ",Row = " + .Row.ToString + ",GroupTile = " + .Parent.Parent.Name)
            End With
        End If
        glProgram = True
    End Sub
#End Region

#Region "HANDLER DOCK TAB STRIP"
    Private Sub dockTabStripItem_MouseEnter(sender As Object, e As EventArgs)
        With CType(sender, TabStripItem)
            '.BackColor = Color.PaleVioletRed
            .BackColor = Color.FromArgb(145, 100, 195)
        End With
    End Sub

    Private Sub dockTabStripItem_MouseLeave(sender As Object, e As EventArgs)
        With CType(sender, TabStripItem)
            '.BackColor = Color.IndianRed
            .BackColor = Color.FromArgb(93, 46, 145)
        End With
    End Sub
#End Region

#Region "HANDLER BUTTON"
    Public Sub oBtnChangeCompany_Click(ByVal sender As Object, ByVal args As EventArgs)
        Dim oForm As New ChangeCompany
        oForm.Show(Me)
    End Sub

    Private Sub oBtnMyProfile_Click(ByVal sender As Object, ByVal args As EventArgs)
        _createDockDocumentWindow(sender)

        hideDocContainer()
    End Sub

    Private Sub backButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loDockDocContainer As DocumentContainer

        'close auto hide popup
        goRadDock.AutoHidePopup.Hide()

        'get document container
        For Each ctrl In goRadDock.Controls
            If TypeOf ctrl Is DocumentContainer Then
                loDockDocContainer = ctrl
            End If
        Next

        If loDockDocContainer.Controls.Count > 0 Then
            Dim oDocTabStrip As DocumentTabStrip

            oDocTabStrip = TryCast(loDockDocContainer.Controls(0), DocumentTabStrip)
            If oDocTabStrip IsNot Nothing Then
                oDocTabStrip.SplitPanelElement.Visibility = ElementVisibility.Visible
                If oDocTabStrip.Controls.Count > 0 Then
                    CType(CType(oDocTabStrip.Controls(0), DocumentWindow).Controls(0), RadForm).Parent.Parent.Visible = True
                End If
            End If
        End If

        'set color on active tab
        Dim loDockTabStripItem As StripViewItemLayout

        loDockTabStripItem = TryCast(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
        If loDockTabStripItem IsNot Nothing Then
            For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                With dockTabStripItem
                    If .Text = goRadDock.AutoHidePopup.ActiveWindow.Text Then
                        '.BackColor = Color.IndianRed
                        .BackColor = Color.FromArgb(93, 46, 145)
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub backButton_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, RadButtonElement).Image = My.Resources.MB_0006_back.GetThumbnailImage(30, 30, Nothing, New IntPtr())
    End Sub

    Private Sub backButton_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, RadButtonElement).Image = My.Resources.icon_panah.GetThumbnailImage(30, 30, Nothing, New IntPtr())
    End Sub
#End Region

#Region "HANDLER RESIZE"
    Private Sub Menu_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        With labelUser
            .Margin = New Padding(Me.Width - 200, 30, 0, 0)
        End With

        Me.panelContent.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Hostwindow_Resize(sender As Object, e As EventArgs) Handles Me.MouseDown
        If sender IsNot Nothing Then
            If TypeOf sender Is HostWindow Then
                With CType(sender, HostWindow)
                    'set DockingButtonLayout on resize 
                    Dim dockBtn As R_DockingButtonLayout = CType(CType(.Controls(0), RadPanorama).PanoramaElement.Children. _
                        Where(Function(x) x.GetType.Name = "DockingButtonLayout").FirstOrDefault, R_DockingButtonLayout)
                    dockBtn.Margin = New Padding(.Width - 50, 0, 0, 0)
                End With
                With CType(sender, HostWindow)
                    'set DockingButtonLayout on resize 
                    Dim dockBtn As R_DockingButtonLayout = CType(CType(.Controls(0), RadPanorama).PanoramaElement.Children. _
                        Where(Function(x) x.GetType.Name = "DockingButtonLayout").FirstOrDefault, R_DockingButtonLayout)
                    dockBtn.Margin = New Padding(.Width - 50, 0, 0, 0)
                End With
            End If
        End If
    End Sub
#End Region

#Region "HANDLER TITLEBAR"
    Private Sub titleBar_MaximizeRestore(ByVal sender As Object, ByVal args As EventArgs)
        If Me.WindowState <> FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub titleBar_Minimize(ByVal sender As Object, ByVal args As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub titleBar_Close(ByVal sender As Object, ByVal args As EventArgs)
        Me.Close()
    End Sub
#End Region

#Region "HANDLER PANORAMA"
    Private Sub RadPanorama_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '' Make Sure Mouse Down Don't Come From Group Or Tile, because group or tile mouse down trigger this event
        '' Set Global Level
        _oRadPanorama = sender
        _nLevel = sender.Tag

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If _oRadPanorama.Name = "FAV" Then
                If glGroup Then
                    '' Get Cursor Position
                    Dim mspt = New Point(Cursor.Position)
                    _prepareTileGroupElementContextMenu(goTileGroupElement)
                    '' Show Tile Group Element Context Menu
                    rcmTileGroupElementMouseDown.Show(mspt.X, mspt.Y)
                Else
                    If glProgram Then
                        Dim mspt = New Point(Cursor.Position)

                        With goRadTileElement
                            If .Tag = "F" Then
                                '' Prepare Context Menu For Folder type tile
                                '_prepareFolderTileContextMenu()
                                '' Open Tile Folder Mouse Down Context Menu
                                rcmTileFolderMouseDown.Show(mspt.X, mspt.Y)
                            Else
                                '' Prepare Context Menu For tile
                                _prepareButtonFavouriteContextMenu()
                                '' Open Tile Mouse Down Context Menu
                                rcmButtonFavouriteMouseDown.Show(mspt.X, mspt.Y)
                            End If
                        End With
                    Else
                        '' Cek Mouse Down is a Right Click
                        '' Prepare Panorama Context Menu
                        _preparePanoramaContextMenu()
                        '' Get Cursor Position
                        Dim mspt = New Point(Cursor.Position)
                        '' Display Context Menu Panorama Mouse Down
                        rcmPanoramaMouseDown.Show(mspt.X, mspt.Y)
                    End If
                End If
            Else
                If glGroup Then
                    '' Get Cursor Position
                    Dim mspt = New Point(Cursor.Position)
                    _prepareTileGroupElementContextMenu(goTileGroupElement)
                    '' Show Tile Group Element Context Menu
                    rcmTileGroupElementMouseDown.Show(mspt.X, mspt.Y)
                Else
                    If glProgram Then
                        Dim mspt = New Point(Cursor.Position)

                        With goRadTileElement
                            If .Tag = "F" Then
                                '' Prepare Context Menu For Folder type tile
                                '_prepareFolderTileContextMenu()
                                '' Open Tile Folder Mouse Down Context Menu
                                rcmTileFolderMouseDown.Show(mspt.X, mspt.Y)
                            Else
                                '' Prepare Context Menu For tile
                                _prepareTileContextMenu()
                                '' Open Tile Mouse Down Context Menu
                                rcmTileMouseDown.Show(mspt.X, mspt.Y)
                            End If
                        End With
                    Else
                        '' Cek Mouse Down is a Right Click
                        '' Prepare Panorama Context Menu
                        _preparePanoramaContextMenu()
                        '' Get Cursor Position
                        Dim mspt = New Point(Cursor.Position)
                        '' Display Context Menu Panorama Mouse Down
                        rcmPanoramaMouseDown.Show(mspt.X, mspt.Y)
                    End If
                End If
            End If
        End If
        '' Reset Group or Tile Boolean
        glGroup = False
        glProgram = False
    End Sub

    Private Sub RadPanoramaDragDropService_Stopped(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim loEx As New R_Exception

        Try
            Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)

            With goRadTileElement
                Console.WriteLine("DragDropServiceStopping - Column = " + .Column.ToString + ",Row = " + .Row.ToString + ",GroupTile = " + .Parent.Parent.Name)
                If gnOldColumn = .Column AndAlso gnOldRow = .Row AndAlso gcOldGroupTile = .Parent.Parent.Name Then
                    Console.WriteLine("MouseLeaveSame")
                Else
                    Console.WriteLine("MouseLeaveDiff")
                    '' Update Database
                    '' Prepare Parameter
                    Dim loParam As New MenuDTO
                    With loParam
                        .CCOMPANY_ID = gcCompanyId
                        .CUSER_ID = gcUserId
                        .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                        .CSUB_MENU_TYPE = goRadTileElement.Tag.ToString.Trim
                        .CSUB_MENU_ID = goRadTileElement.Name.Trim
                        .ICOLUMN_INDEX = goRadTileElement.Column
                        .IROW_INDEX = goRadTileElement.Row
                        .CPARENT_SUB_MENU_ID = goRadTileElement.Parent.Parent.Name
                    End With
                    '' Update Menu Position To DB
                    loService.updateMenuPositionToDB(loParam)
                End If
            End With
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#End Region

    Private Sub service_Stopping(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim oDockManager As RadDock = TryCast(sender.DockManager, RadDock)
            If oDockManager IsNot Nothing Then
                For Each oDockWind As R_DocumentWindow In oDockManager.DockWindows.DocumentWindows
                    Dim oRadPageViewTabStripElement As RadPageViewTabStripElement = TryCast(oDockWind.DockTabStrip.SplitPanelElement.Children(2), RadPageViewTabStripElement)
                    If oRadPageViewTabStripElement IsNot Nothing Then
                        oRadPageViewTabStripElement.BackColor = Color.Transparent
                        oRadPageViewTabStripElement.GradientStyle = GradientStyles.Solid
                    End If

                    Dim oRadPageViewContentAreaElement As RadPageViewContentAreaElement = TryCast(oDockWind.DockTabStrip.SplitPanelElement.Children(2).Children(1), RadPageViewContentAreaElement)
                    If oRadPageViewContentAreaElement IsNot Nothing Then
                        oRadPageViewContentAreaElement.BackColor = Color.White
                        oRadPageViewContentAreaElement.GradientStyle = GradientStyles.Solid
                    End If
                Next
            End If

        Catch ex As Exception
            'do nothing
        End Try
    End Sub
#End Region

#Region " METHOD "
#Region " INTERNAL METHOD "
#Region " SUB "
#Region " _getTree "
    Private Sub _getTree(ByVal pcMENU_ID As String, ByVal pcSUB_MENU_ID As String, ByVal pnLEVEL As Integer)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loServiceStream As MenuStreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuStreamingService, MenuStreamingServiceClient)(e_ServiceClientType.StreamingService, C_ServiceNameMenuStream)
        Dim loRtn As Message
        Dim loStreaming As IEnumerable(Of MenuDTOnon)

        ' Get Method to show from app.config 'R_Md'
        Dim lcModul As String
        lcModul = System.Configuration.ConfigurationManager.AppSettings("R_Md").ToString()

        '' GET MENU 
        R_Utility.R_SetStreamingContext("cCompId", gcCompanyId.Trim)
        R_Utility.R_SetStreamingContext("cUserId", gcUserId.Trim)
        R_Utility.R_SetStreamingContext("cMenuId", pcMENU_ID)
        R_Utility.R_SetStreamingContext("cSubMenuId", pcSUB_MENU_ID)
        R_Utility.R_SetStreamingContext("nLevel", pnLEVEL)
        R_Utility.R_SetStreamingContext("cModul", lcModul)
        R_Utility.R_SetStreamingContext("cLangId", U_GlobalVar.CultureUI.TwoLetterISOLanguageName)

        loRtn = loServiceStream.getMenu()
        loStreaming = R_StreamUtility(Of MenuDTOnon).ReadFromMessage(loRtn)

        For Each loDto As MenuDTOnon In loStreaming
            If loDto IsNot Nothing Then
                loMenuDTOList.Add(New MenuDTO With {.CCOMPANY_ID = loDto.CCOMPANY_ID,
                                                    .CUSER_ID = loDto.CUSER_ID,
                                                    .CMENU_ID = loDto.CMENU_ID,
                                                    .CMENU_NAME = loDto.CMENU_NAME,
                                                    .CSUB_MENU_TYPE = loDto.CSUB_MENU_TYPE,
                                                    .CSUB_MENU_ID = loDto.CSUB_MENU_ID,
                                                    .CSUB_MENU_NAME = loDto.CSUB_MENU_NAME,
                                                    .CSUB_MENU_TOOL_TIP = loDto.CSUB_MENU_TOOL_TIP,
                                                    .CSUB_MENU_IMAGE = loDto.CSUB_MENU_IMAGE,
                                                    .CPARENT_SUB_MENU_ID = loDto.CPARENT_SUB_MENU_ID,
                                                    .IGROUP_INDEX = loDto.IGROUP_INDEX,
                                                    .IROW_INDEX = loDto.IROW_INDEX,
                                                    .ICOLUMN_INDEX = loDto.ICOLUMN_INDEX,
                                                    .LFAVORITE = loDto.LFAVORITE,
                                                    .IFAVORITE_INDEX = loDto.IFAVORITE_INDEX,
                                                    .ILEVEL = loDto.ILEVEL})
            Else
                Exit For
            End If
        Next

        If loMenuDTOList.Count = 0 Then
            Throw New Exception(R_Utility.R_GetError(Me.GetType, "Err005").ErrDescp)
        End If

        goMenuDTOList = loMenuDTOList.Where(Function(x) x.CSUB_MENU_TYPE.ToLower = "p").ToList
        'load data for search combobox
        'PopulateData(oRadDropDownListElement)

        If pcMENU_ID = "" Then '' INITIALIZE
            '' GET AND SET ACCESS
            Dim loInitiator As IInitiator = New U_GlobalVar
            loInitiator.Set_MenuProgramAccessDTOList(_GetMenuAccess)

            goMenuProgramAccessDTOList = U_GlobalVar.ProgramAccessDTOList


            goHostWindowList = New List(Of HostWindow)

            'create host window for favourite
            If loMenuDTOList.Count <> 0 Then
                _createPanoramaFAV(loMenuDTOList, pnLEVEL)
            End If

            ''LINQ All MENU_ID
            Dim q = From p In loMenuDTOList Where p.CMENU_ID <> "FAV" Select p.CMENU_ID Distinct
            For Each loMenuDTOMENU_ID In q
                Dim loPanorama As Telerik.WinControls.UI.RadPanorama
                Dim loHost As HostWindow

                'LINQ to get menu name
                Dim r = From p In loMenuDTOList Where p.CMENU_ID = loMenuDTOMENU_ID And p.CCOMPANY_ID = gcCompanyId And p.CUSER_ID.ToLower = gcUserId Select p.CMENU_NAME Distinct
                'Dim cMenuID As String = From p In loMenuDTOList Where p.CMENU_ID = loMenuDTOMENU_ID And p.CCOMPANY_ID = gcCompanyId And p.CUSER_ID.ToLower = gcUserId Select p.CMENU_ID Distinct

                '' METHOD | _createPanorama
                loPanorama = _createPanorama(loMenuDTOMENU_ID.ToString.Trim, pnLEVEL, loMenuDTOList, r.FirstOrDefault)

                ' Add Panorama To Dock
                loHost = goRadDock.DockControl(loPanorama, Telerik.WinControls.UI.Docking.DockPosition.Left, DockType.ToolWindow)

                With loHost
                    .Text = r.FirstOrDefault
                    .Name = r.FirstOrDefault
                    .AllowedDockState = Not AllowedDockState.Hidden 'And Not AllowedDockState.TabbedDocument
                    .TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Fill
                    .AutoHideSize = New System.Drawing.Size(Me.Width, loHost.Height) ' - 250, loHost.Height)
                    .DockState = DockState.AutoHide
                    '.Margin = New Padding(0, 0, 0, 2)
                    .TabStrip.Margin = New Padding(0, 0, 0, 2)
                End With

                goHostWindowList.Add(loHost)
            Next
        Else
            Dim loPanorama As Telerik.WinControls.UI.RadPanorama
            Dim loHost As HostWindow = goRadDock.ActiveWindow

            '' METHOD | _createPanorama
            loPanorama = _createPanorama(pcMENU_ID.ToString.Trim, pnLEVEL, loMenuDTOList, "")

            loHost.Controls().RemoveAt(0)
            loHost.Controls.Add(loPanorama)
        End If
    End Sub
#End Region
    Private Function _GetMenuAccess() As List(Of MenuProgramAccessDTO)
        Dim loServiceStream As MenuStreamingServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuStreamingService, MenuStreamingServiceClient)(e_ServiceClientType.StreamingService, C_ServiceNameMenuStream)
        Dim loException As New R_Exception
        Dim loRtn As Message
        Dim loStreaming As IEnumerable(Of MenuProgramAccessDTO)
        Dim loListEntity As New List(Of MenuProgramAccessDTO)

        Try
            R_Utility.R_SetStreamingContext("cCompId", gcCompanyId.Trim)
            R_Utility.R_SetStreamingContext("cUserId", gcUserId.Trim)
            R_Utility.R_SetStreamingContext("cLang", U_GlobalVar.CultureUI.TwoLetterISOLanguageName)

            loRtn = loServiceStream.getMenuAccess()
            loStreaming = R_StreamUtility(Of MenuProgramAccessDTO).ReadFromMessage(loRtn)

            For Each loDto As MenuProgramAccessDTO In loStreaming
                If loDto IsNot Nothing Then
                    loListEntity.Add(loDto)
                Else
                    Exit For
                End If
            Next
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()

        Return loListEntity
    End Function
#Region " _createHeader "
    Private Sub _CreateHeader(ByRef poPanorama As Telerik.WinControls.UI.RadPanorama)
        '' Create Header Layout
        Dim loHeaderLayout As New StackLayoutElement()

        '' Set Header Layout Properties
        loHeaderLayout.Orientation = Orientation.Horizontal
        loHeaderLayout.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        loHeaderLayout.NotifyParentOnMouseInput = True
        loHeaderLayout.ShouldHandleMouseInput = False
        loHeaderLayout.StretchHorizontally = False
        loHeaderLayout.Name = "HeaderLayout" + poPanorama.Name

        'Back Button
        Dim loBackButton As New RadButtonElement
        '' Set Back Button Properties
        With loBackButton
            .StretchHorizontally = False
            '.Text = "<"
            .Margin = New Padding(15, 0, 15, 0)
            .Visibility = ElementVisibility.Visible
            .MinSize = New Size(30, 30)
            .TextImageRelation = TextImageRelation.ImageAboveText
            .ImageAlignment = ContentAlignment.MiddleCenter
            .ButtonFillElement.BackColor = Color.Transparent
            .ButtonFillElement.ForeColor = Color.White
            .ButtonFillElement.NumberOfColors = 1
            .ButtonFillElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            .BorderElement.Width = 0
            .BorderElement.ForeColor = Color.Transparent
            .ToolTipText = "Back"
            .Image = My.Resources.icon_panah.GetThumbnailImage(30, 30, Nothing, New IntPtr())

            '' Add Handler for Back Button
            AddHandler .Click, AddressOf backButton_Click
            AddHandler .MouseEnter, AddressOf backButton_MouseEnter
            AddHandler .MouseLeave, AddressOf backButton_MouseLeave
        End With

        '' Add Back Button to Header Layout
        loHeaderLayout.Children.Add(loBackButton)

        '' Create Header Label
        Dim loHeaderLabel As New LightVisualElement()

        '' Set Header Label Properties
        loHeaderLabel.Text = poPanorama.Text
        loHeaderLabel.Font = New Font("Arial", 15, FontStyle.Italic, GraphicsUnit.Point)
        loHeaderLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        loHeaderLabel.ForeColor = Color.White
        loHeaderLabel.TextAlignment = ContentAlignment.MiddleLeft
        loHeaderLabel.MaxSize = New Size(1368, 30)
        loHeaderLabel.NotifyParentOnMouseInput = True
        loHeaderLabel.ShouldHandleMouseInput = False
        loHeaderLabel.StretchHorizontally = False

        '' Add Header Label to Header Layout
        loHeaderLayout.Children.Add(loHeaderLabel)

        '' Add Header Layout to Panorama
        poPanorama.PanoramaElement.Children.Add(loHeaderLayout)
    End Sub
#End Region
#Region " _createDockDocumentWindow "
    Friend Sub _createDockDocumentWindow(ByVal pcProgram As Object)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception
        Dim loTemplateProgram As TemplateProgram
        Dim loPredefinedDTOList As List(Of R_PredefinedDTO) = Nothing

        With pcProgram
            Dim loDockWindowParent As R_DocumentWindow
            Dim loDockDocContainer As DocumentContainer
            Dim lNotFound As Boolean = False

            Try
                Try
                    loDockWindowParent = goRadDock.DockWindows("DockWindowParent" + .Name.Trim + .Text.Trim)

                    goRadDock.AutoHidePopup.Hide()

                    'get document container
                    For Each ctrl In goRadDock.Controls
                        If TypeOf ctrl Is DocumentContainer Then
                            loDockDocContainer = ctrl
                        End If
                    Next

                    Dim oDocTabStrip As DocumentTabStrip

                    oDocTabStrip = TryCast(loDockDocContainer.Controls(0), DocumentTabStrip)
                    If oDocTabStrip IsNot Nothing Then
                        oDocTabStrip.SplitPanelElement.Visibility = ElementVisibility.Visible
                        If oDocTabStrip.Controls.Count > 0 Then
                            CType(CType(oDocTabStrip.Controls(0), DocumentWindow).Controls(0), RadForm).Parent.Parent.Visible = True
                        End If
                    End If

                    'set color on active tab
                    Dim loDockTabStripItem As StripViewItemLayout

                    loDockTabStripItem = TryCast(goRadDock.SplitPanelElement.Children(2).Children(2).Children(0).Children.Where(Function(x) x.GetType.Name = "StripViewItemLayout").FirstOrDefault, StripViewItemLayout)
                    If loDockTabStripItem IsNot Nothing Then
                        For Each dockTabStripItem As TabStripItem In loDockTabStripItem.Children
                            With dockTabStripItem
                                If .Text = goRadDock.AutoHidePopup.ActiveWindow.Text Then
                                    .BackColor = Color.FromArgb(93, 46, 145)
                                End If
                            End With
                        Next
                    End If

                Catch ex As KeyNotFoundException
                    lNotFound = True
                Catch ex As Exception
                    loEx.Add(ex)
                End Try

                If Not lNotFound Then
                    Exit Try
                End If

                loDockWindowParent = New R_DocumentWindow
                loDockWindowParent.Name = "DockWindowParent" + .Name.Trim + .Text.Trim
                goRadDock.BringToFront()

                If TypeOf pcProgram Is R_LabelLayout Then
                    loDockWindowParent.Text = "My Profile"
                Else
                    loDockWindowParent.Text = .Text
                End If

                loDockWindowParent.R_ProgramId = .Name.Trim
                loDockWindowParent.ToolTipText = .Name.Trim & " - " & .Text

                If goRadDock.DockWindows.DocumentWindows.Count >= 5 Then
                    For Each oDock As R_DocumentWindow In goRadDock.DockWindows.DocumentWindows
                        oDock.DocumentButtons = DocumentStripButtons.All
                    Next
                    loDockWindowParent.DocumentButtons = DocumentStripButtons.All
                End If

                'Dim loTemplateProgram As New TemplateProgram()
                loTemplateProgram = New TemplateProgram
                loTemplateProgram.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                loTemplateProgram.TopLevel = False
                loTemplateProgram.Dock = DockStyle.Fill
                loDockWindowParent.Controls.Add(loTemplateProgram)
                loTemplateProgram.Show()

                Dim loDockWindowChild As R_DocumentWindow
                loDockWindowChild = New R_DocumentWindow
                loDockWindowChild.Name = "DockWindow" + .Text.Trim
                If TypeOf pcProgram Is R_LabelLayout Then
                    loDockWindowChild.Text = "My Profile"
                Else
                    loDockWindowChild.Text = .Text
                End If
                'loDockWindowChild.DocumentButtons = DocumentStripButtons.None
                'loDockWindowChild.CloseAction = DockWindowCloseAction.CloseAndDispose

                WaitFormCls.Show(AddressOf WorkerMethod, "Downloading New Update...")
                '' SYSYSY - For Testing predefined - UNCOMMENT THIS PART after test
                Dim loForm As R_FrontEnd.R_FormBase = R_DeployUtility.R_DynamicLoadObject(.name + "Front", .Name + "Front", .Name)

                WaitFormCls.Show(AddressOf WorkerMethod, "Load Form Layout...")
                CType(loForm, R_IFormBase)._ValidationOpenForm(_lValid, loEx)

                If _lValid = False Then
                    loTemplateProgram.Close()
                    loDockWindowParent.Controls.Remove(loTemplateProgram)
                    Exit Try
                End If

                ' Buat dapetin access dari program2 yang ada di menu, misalkan lebih dari 1 program di 2 menu id yang berbeda, akses-nya disatukan
                Dim pcAccess As String = ""
                Dim llContainA As Boolean = False
                Dim llContainU As Boolean = False
                Dim llContainD As Boolean = False
                Dim llContainP As Boolean = False
                Dim llContainV As Boolean = False

                Dim q = From p In goMenuProgramAccessDTOList Where p.CPROGRAM_ID = .name Select p.CPROGRAM_ID, p.CACCESS_ID
                For Each loMenuProgramAccessDTO In q
                    If loMenuProgramAccessDTO.CACCESS_ID Is Nothing Then
                        llContainV = True
                        Exit For
                    End If
                    If loMenuProgramAccessDTO.CACCESS_ID.Contains("A") Then
                        llContainA = True
                    End If
                    If loMenuProgramAccessDTO.CACCESS_ID.Contains("U") Then
                        llContainU = True
                    End If
                    If loMenuProgramAccessDTO.CACCESS_ID.Contains("D") Then
                        llContainD = True
                    End If
                    If loMenuProgramAccessDTO.CACCESS_ID.Contains("P") Then
                        llContainP = True
                    End If
                    If loMenuProgramAccessDTO.CACCESS_ID.Contains("V") Then
                        llContainV = True
                    End If
                Next

                If llContainA Then
                    If pcAccess = "" Then
                        pcAccess = "A"
                    Else
                        pcAccess = pcAccess + ",A"
                    End If
                End If
                If llContainU Then
                    If pcAccess = "" Then
                        pcAccess = "U"
                    Else
                        pcAccess = pcAccess + ",U"
                    End If
                End If
                If llContainD Then
                    If pcAccess = "" Then
                        pcAccess = "D"
                    Else
                        pcAccess = pcAccess + ",D"
                    End If
                End If
                If llContainP Then
                    If pcAccess = "" Then
                        pcAccess = "P"
                    Else
                        pcAccess = pcAccess + ",P"
                    End If
                End If
                If llContainV Then
                    If pcAccess = "" Then
                        pcAccess = "V"
                    Else
                        pcAccess = pcAccess + ",V"
                    End If
                End If

                If pcAccess = "" Then
                    pcAccess = "V"
                End If

                If TypeOf pcProgram Is R_LabelLayout Then
                    CType(loForm, R_IFormAccess)._SetAccess("U")
                Else
                    CType(loForm, R_IFormAccess)._SetAccess(pcAccess)
                End If

                If Not TypeOf pcProgram Is R_LabelLayout Then
                    Dim lcAccess As List(Of MenuProgramAccessDTO)
                    Dim oMenu As String()

                    oMenu = goMenuProgramAccessDTOList.Select(Function(x) x.CMENU_ID).Distinct.ToArray
                    lcAccess = loService.getAccessButton(U_GlobalVar.CompId, pcProgram.Name)

                    lcAccess = (From A In lcAccess
                               From B In oMenu
                               Where A.CMENU_ID = B
                               Select A).ToList

                    If lcAccess.Count > 0 Then
                        For Each oCtrl As Control In loForm.Controls
                            If (TypeOf oCtrl Is R_RadButton) Then
                                If CType(oCtrl, R_RadButton).R_IsAccess Then
                                    Dim cAccess As String = lcAccess.Where(Function(x) x.CACCESS_ID = CType(oCtrl, R_RadButton).Name).Select(Function(x) x.CACCESS_ID).FirstOrDefault
                                    If Not String.IsNullOrEmpty(cAccess) Then
                                        CType(oCtrl, R_RadButton).Enabled = True
                                    Else
                                        CType(oCtrl, R_RadButton).Enabled = False
                                    End If
                                    If loForm.R_ConductorHeader IsNot Nothing Then
                                        loForm.R_ConductorHeader.R_SetAccessButton(cAccess)
                                    End If
                                End If
                            ElseIf (TypeOf oCtrl Is R_RadGroupBox) Then
                                For Each oCtrlGroup As Control In oCtrl.Controls
                                    If (TypeOf oCtrlGroup Is R_RadButton) Then
                                        If CType(oCtrlGroup, R_RadButton).R_IsAccess Then
                                            Dim cAccess As String = lcAccess.Where(Function(x) x.CACCESS_ID = CType(oCtrlGroup, R_RadButton).Name).Select(Function(x) x.CACCESS_ID).FirstOrDefault
                                            If Not String.IsNullOrEmpty(cAccess) Then
                                                CType(oCtrlGroup, R_RadButton).Enabled = True
                                            Else
                                                CType(oCtrlGroup, R_RadButton).Enabled = False
                                            End If
                                            If loForm.R_ConductorHeader IsNot Nothing Then
                                                loForm.R_ConductorHeader.R_SetAccessButton(cAccess)
                                            End If
                                        End If
                                    End If
                                Next
                            End If
                        Next
                    End If
                End If

                loForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                loForm.TopLevel = False
                loForm.Dock = DockStyle.None

                loDockWindowChild.Controls.Add(loForm)
                loDockWindowChild.R_Form = loForm
                loDockWindowChild.AutoScroll = True

                CType(loForm, R_IFormBase)._InitFromMaster(Nothing, R_eFormModel.MainForm, Nothing)

                'taro runform disini, looping di r_components nya cek ada r_runform apa tidak.
                'kalo ada bikin objectnya, jalanin event before_open_form, simpen parameternya untuk dipakai lagi untuk initFromMaster yang kedua.
                Dim oRunFormParam As Object = Nothing
                If loForm.R_Components IsNot Nothing Then
                    If TypeOf (loForm.R_Components) Is System.ComponentModel.Container Then
                        For Each loObject As Object In CType(loForm.R_Components, System.ComponentModel.Container).Components
                            If TypeOf (loObject) Is R_RunForm Then
                                loDockWindowChild.Controls.Remove(loForm)
                                loDockWindowChild.R_Form = Nothing

                                loForm = Nothing

                                CType(loObject, R_RunForm)._BeforeOpenForm(loForm, oRunFormParam)
                                'Dim loRunForm As R_FrontEnd.R_FormBase = R_DeployUtility.R_DynamicLoadObject(.R_TargetForm + "Front", .R_TargetForm + "Front", .R_TargetForm)
                                If TypeOf pcProgram Is R_LabelLayout Then
                                    CType(loForm, R_IFormAccess)._SetAccess("U")
                                Else
                                    CType(loForm, R_IFormAccess)._SetAccess(pcAccess)
                                End If

                                If Not TypeOf pcProgram Is R_LabelLayout Then
                                    Dim lcAccess As List(Of MenuProgramAccessDTO)
                                    Dim oMenu As String()

                                    oMenu = goMenuProgramAccessDTOList.Select(Function(x) x.CMENU_ID).Distinct.ToArray
                                    lcAccess = loService.getAccessButton(U_GlobalVar.CompId, pcProgram.Name)

                                    lcAccess = (From A In lcAccess
                                               From B In oMenu
                                               Where A.CMENU_ID = B
                                               Select A).ToList

                                    If lcAccess.Count > 0 Then
                                        For Each oCtrl As Control In loForm.Controls
                                            If (TypeOf oCtrl Is R_RadButton) Then
                                                If CType(oCtrl, R_RadButton).R_IsAccess Then
                                                    Dim cAccess As String = lcAccess.Where(Function(x) x.CACCESS_ID = CType(oCtrl, R_RadButton).Name).Select(Function(x) x.CACCESS_ID).FirstOrDefault
                                                    If Not String.IsNullOrEmpty(cAccess) Then
                                                        CType(oCtrl, R_RadButton).Enabled = True
                                                    Else
                                                        CType(oCtrl, R_RadButton).Enabled = False
                                                    End If
                                                    If loForm.R_ConductorHeader IsNot Nothing Then
                                                        loForm.R_ConductorHeader.R_SetAccessButton(cAccess)
                                                    End If
                                                End If
                                            ElseIf (TypeOf oCtrl Is R_RadGroupBox) Then
                                                For Each oCtrlGroup As Control In oCtrl.Controls
                                                    If (TypeOf oCtrlGroup Is R_RadButton) Then
                                                        If CType(oCtrlGroup, R_RadButton).R_IsAccess Then
                                                            Dim cAccess As String = lcAccess.Where(Function(x) x.CACCESS_ID = CType(oCtrlGroup, R_RadButton).Name).Select(Function(x) x.CACCESS_ID).FirstOrDefault
                                                            If Not String.IsNullOrEmpty(cAccess) Then
                                                                CType(oCtrlGroup, R_RadButton).Enabled = True
                                                            Else
                                                                CType(oCtrlGroup, R_RadButton).Enabled = False
                                                            End If
                                                            If loForm.R_ConductorHeader IsNot Nothing Then
                                                                loForm.R_ConductorHeader.R_SetAccessButton(cAccess)
                                                            End If
                                                        End If
                                                    End If
                                                Next
                                            End If
                                        Next
                                    End If
                                End If

                                loForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                                loForm.TopLevel = False
                                loForm.Dock = DockStyle.Fill

                                loDockWindowChild.Controls.Add(loForm)
                                loDockWindowChild.R_Form = loForm
                                loDockWindowChild.AutoScroll = True

                                CType(loForm, R_IFormBase)._InitFromMaster(oRunFormParam, R_eFormModel.MainForm, Nothing)
                                'loForm._InitFromMaster(oRunFormParam, R_eFormModel.MainForm, Nothing)
                            End If
                        Next
                    End If
                End If

                'insert history
                If TypeOf pcProgram Is R_LabelLayout = False And _lWithHistory Then
                    loService.SaveHistory(U_GlobalVar.CompId, U_GlobalVar.UserId, .name, "OPEN")
                    loService.Close()
                End If

                loForm.Show()
                loTemplateProgram.RadDockTemplate.AddDocument(loDockWindowChild)

                If loForm.R_Components IsNot Nothing Then
                    If Not String.IsNullOrWhiteSpace(loForm.R_HeaderTitle) Then
                        loDockWindowChild.Text = loForm.R_HeaderTitle
                    End If

                    ' create dto list from any R_PredefineDock so it can be sort
                    'Dim loPredefinedDTOList As New List(Of R_PredefinedDTO)
                    loPredefinedDTOList = New List(Of R_PredefinedDTO)

                    If TypeOf (loForm.R_Components) Is System.ComponentModel.Container Then
                        For Each loObject As Object In CType(loForm.R_Components, System.ComponentModel.Container).Components
                            If TypeOf (loObject) Is R_PredefinedDock Then
                                CType(loObject, R_PredefinedDock).R_SetFormParent(loForm)

                                Dim loPredefinedDTO As New R_PredefinedDTO
                                loPredefinedDTO.loPredefineDock = loObject
                                loPredefinedDTO.lnIndex = CType(loObject, R_PredefinedDock).R_DockIndex

                                loPredefinedDTOList.Add(loPredefinedDTO)
                            End If
                        Next
                    Else
                        For Each loObject As Object In loForm.R_Components
                            If TypeOf (loObject) Is R_PredefinedDock Then
                                CType(loObject, R_PredefinedDock).R_SetFormParent(loForm)

                                Dim loPredefinedDTO As New R_PredefinedDTO
                                loPredefinedDTO.loPredefineDock = loObject
                                loPredefinedDTO.lnIndex = CType(loObject, R_PredefinedDock).R_DockIndex

                                loPredefinedDTOList.Add(loPredefinedDTO)
                            End If
                        Next
                    End If

                    ' Cek if there is any R_PredefineDTO
                    If loPredefinedDTOList.Count > 0 Then
                        loDockWindowChild.R_IsPredefined = True
                        ' Sort base on index
                        Dim r = From p In loPredefinedDTOList Order By p.lnIndex Ascending Select p.loPredefineDock
                        For Each loPredefineDockItem In r
                            Dim loTargetForm As R_FormBase

                            loPredefineDockItem.R_GetInstance(loTargetForm)

                            If loTargetForm IsNot Nothing Then
                                Dim loDockWindow As New R_DocumentWindow
                                loDockWindow.Name = "DockWindow" + loPredefineDockItem.R_HeaderTitle.ToString.Trim
                                loDockWindow.Text = loPredefineDockItem.R_HeaderTitle.ToString.Trim
                                loDockWindow.R_IsPredefined = True
                                loDockWindow.R_Form = loTargetForm
                                loDockWindow.R_PredefinedDockComponent = loPredefineDockItem
                                'loDockWindow.CloseAction = DockWindowCloseAction.CloseAndDispose
                                loDockWindow.AllowedDockState = AllowedDockState.TabbedDocument
                                loDockWindow.R_DocumentIndex = loPredefineDockItem.R_DockIndex

                                'loTargetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                                'loTargetForm.TopLevel = False
                                'loTargetForm.Dock = DockStyle.None
                                'loTargetForm.ThemeName = "ControlDefaultEDIT"

                                'loDockWindow.Controls.Add(loTargetForm)
                                'loDockWindow.AutoScroll = True
                                'loTargetForm.Show()

                                loTemplateProgram.RadDockTemplate.AddDocument(loDockWindow)
                            End If
                        Next
                    End If
                End If
                'Add Parent Dock into parent RadDock
                goRadDock.AddDocument(loDockWindowParent)

                CType(loForm, R_IFormBase)._InitPredefine()
            Catch ex As Exception
                loEx.Add(ex)
            Finally
                If loPredefinedDTOList IsNot Nothing Then
                    Dim loDocumentWindowList As IEnumerable(Of R_DocumentWindow) = loTemplateProgram.RadDockTemplate.DockWindows.DocumentWindows.Cast(Of R_DocumentWindow)()
                    loDocumentWindowList = loDocumentWindowList.Where(Function(x) x.R_Form.R_FormModel = R_eFormModel.MainForm)
                    loTemplateProgram.RadDockTemplate.ActiveWindow = loDocumentWindowList.FirstOrDefault
                End If
                goRadDock.ActiveWindow = loDockWindowParent
            End Try
        End With

        If loEx.Haserror Then
            Me.R_DisplayException(loEx)
        End If
    End Sub
#End Region
#Region " _createPanoramaFAV "
    Private Sub _createPanoramaFAV(loMenuDTOList As List(Of MenuDTO), pnLEVEL As Integer)
        Dim fav = (From p In loMenuDTOList Where p.CMENU_ID = "FAV" Select p.CMENU_ID Distinct).FirstOrDefault.ToString

        'get menu name
        Dim nameFAV = From p In loMenuDTOList Where p.CMENU_ID = fav.ToString And p.CCOMPANY_ID = gcCompanyId And p.CUSER_ID.ToLower = gcUserId Select p.CMENU_NAME Distinct

        loPanoramaFAV = _createPanorama(fav.ToString.Trim, pnLEVEL, loMenuDTOList, nameFAV.FirstOrDefault)

        loHostFAV = New HostWindow
        loHostFAV = goRadDock.DockControl(loPanoramaFAV, Telerik.WinControls.UI.Docking.DockPosition.Left, DockType.ToolWindow)

        With loHostFAV
            .Name = nameFAV.FirstOrDefault
            .Text = nameFAV.FirstOrDefault
            .AllowedDockState = Not AllowedDockState.Hidden
            .TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Fill
            .AutoHideSize = New System.Drawing.Size(Me.Width, loHostFAV.Height)
            .DockState = DockState.AutoHide
            .BackColor = Color.Transparent
            .ForeColor = Color.Transparent

            'backcolor host window
            .DockTabStrip.SplitPanelElement.BackColor = Color.Transparent 'gray
            .DockTabStrip.RootElement.BackColor = Color.Transparent 'gray

            'set color container host window to transparent
            Dim loHostPanelFill As FillPrimitive = CType(.DockTabStrip.SplitPanelElement.Children.Where(Function(x) x.GetType.Name = "FillPrimitive").FirstOrDefault, FillPrimitive)
            With loHostPanelFill
                .BackColor = Color.Transparent
                .GradientStyle = GradientStyles.Solid
                .NumberOfColors = 1
            End With

            'set color border
            Dim loHostPanelBorder As BorderPrimitive = CType(.DockTabStrip.SplitPanelElement.Children.Where(Function(x) x.GetType.Name = "BorderPrimitive").FirstOrDefault, BorderPrimitive)
            With loHostPanelBorder
                .BackColor = Color.Transparent
                .GradientStyle = GradientStyles.Solid
            End With

            'hide titlebar on hostwindow
            Dim loHostDockLayout As DockLayoutPanel = CType(.DockTabStrip.SplitPanelElement.Children.Where(Function(x) x.GetType.Name = "DockLayoutPanel").FirstOrDefault, DockLayoutPanel)
            loHostDockLayout.Visibility = ElementVisibility.Collapsed
        End With

        goHostWindowList.Add(loHostFAV)
    End Sub
#End Region
    Private Sub PrepareTitleBar()
        goTitleBar = New R_MenuTitleBarElement(Me)

        Me.panelTitle.PanelElement.Children.Add(goTitleBar)
    End Sub
    'Private Sub buttonElement_MouseEnter(sender As Object, e As EventArgs)
    '    sender.ButtonFillElement.BackColor = Color.FromArgb(51, 51, 51)
    'End Sub

    'Private Sub buttonElement_MouseLeave(sender As Object, e As EventArgs)
    '    sender.ButtonFillElement.BackColor = Color.Transparent
    'End Sub

    'Private Sub buttonElement_Click(sender As Object, e As EventArgs)
    '    goRadDock.ShowAutoHidePopup(goRadDock.GetHostWindow(oSearchForm))
    '    oSearchForm.txtSearch.Focus()
    'End Sub

    'Private Sub CloseButton_MouseEnter(sender As Object, e As EventArgs)
    '    sender.BackColor = Color.FromArgb(232, 17, 35)
    'End Sub

    'Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs)
    '    sender.BackColor = Color.Transparent
    'End Sub

    'Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
    '    sender.BackColor = Color.FromArgb(51, 51, 51)
    'End Sub

    'Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
    '    sender.BackColor = Color.Transparent
    'End Sub
    Private Sub PrepareHeader()
        Dim header As New R_HeaderFormLayout()
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)
        Dim loEx As New R_Exception()

        Try
            With header
                .Name = "headerForm"
                '.Margin = New Padding(10, 40, 0, 0)
                .Margin = New Padding(10, 30, 0, 0)
                .setText(U_GlobalVar.CompanyName.ToUpper)
            End With

            AddHandler CType(header.Children(0), StackLayoutElement).Click, AddressOf oBtnChangeCompany_Click

            If U_GlobalVar.SecurityParameter.cSecurityAndAccountPolicy = "byuser" Then
                header.Enabled = False
            Else
                Dim oCheckCompany As List(Of SAM_USER_COMPANYDTO) = loService.svc_getCompanyList(U_GlobalVar.UserId, U_GlobalVar.CompId)

                If oCheckCompany.Count > 0 Then
                    header.Enabled = True
                Else
                    header.Enabled = False
                End If
            End If

            loService.Close()
            Me.panelTitle.PanelElement.Children.Add(header)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ThrowExceptionIfErrors()
    End Sub
    Friend Sub hideDocContainer()
        Dim oDocContainer As DocumentContainer

        For Each ctrl In goRadDock.Controls
            If TypeOf ctrl Is DocumentContainer Then
                oDocContainer = ctrl
            End If
        Next

        If oDocContainer.Controls.Count > 0 Then
            Dim oDocTabStrip As DocumentTabStrip
            oDocTabStrip = TryCast(oDocContainer.Controls(0), DocumentTabStrip)

            If oDocTabStrip IsNot Nothing Then
                CType(oDocTabStrip.SplitPanelElement.Children(2), RadPageViewTabStripElement).BackColor = Color.Transparent
                'add button close on document container
                'CType(CType(oDocContainer.Controls(0), DocumentTabStrip).SplitPanelElement.Children(3).Children(0), RadButtonElement).Visibility = ElementVisibility.Visible
                'clear document border
                CType(oDocTabStrip.SplitPanelElement.Children(2), RadPageViewTabStripElement).ShouldPaint = False
            End If
        End If
    End Sub

    Dim oSearchForm As R_MenuSearchForm
    Private Sub _CreateSearchDock(poProgList As Object)
        Dim loHost As HostWindow

        oSearchForm = New R_MenuSearchForm
        oSearchForm.SetListProg(poProgList)
        oSearchForm.oForm = Me

        loHost = goRadDock.DockControl(oSearchForm, Telerik.WinControls.UI.Docking.DockPosition.Right, DockType.ToolWindow)

        With loHost
            .AllowedDockState = Not AllowedDockState.Hidden
            .TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Auto
            .AutoHideSize = New System.Drawing.Size(300, Me.Height)
            .DockState = DockState.AutoHide
            .Text = ""
        End With

        Dim autoHideTab = Me.goRadDock.GetAutoHideTabStrip(AutoHidePosition.Right)
        autoHideTab.BackColor = Color.Transparent
        autoHideTab.NumberOfColors = 1
        autoHideTab.DrawBorder = False

        'get tab strip
        Dim oTabStrip As TabStripItem = TryCast(autoHideTab.Children(0).Children(0).Children(0), TabStripItem)
        If oTabStrip IsNot Nothing Then
            oTabStrip.BackColor = Color.Transparent
            oTabStrip.NumberOfColors = 1
            oTabStrip.DrawBorder = False
            oTabStrip.GradientStyle = GradientStyles.Solid
        End If
    End Sub
#End Region
#Region " FUNCTION "
#Region " _createPanorama "
    Private Function _createPanorama(ByVal pcMENU_ID As String, ByVal pnLEVEL As Integer, ByVal poMenuDTOList As List(Of MenuDTO), pcMenuName As String) As Telerik.WinControls.UI.RadPanorama
        Dim loTileGroupElement As TileGroupElement

        '' Create Panorama
        Dim loPanorama As Telerik.WinControls.UI.RadPanorama
        loPanorama = New Telerik.WinControls.UI.RadPanorama

        '' Set Panorama Properties
        loPanorama.BackColor = System.Drawing.Color.Transparent
        loPanorama.Dock = System.Windows.Forms.DockStyle.Fill
        loPanorama.Location = New System.Drawing.Point(0, 0)
        loPanorama.Margin = New System.Windows.Forms.Padding(0)
        loPanorama.Name = pcMENU_ID
        loPanorama.ScrollBarThickness = 7
        loPanorama.ScrollingBackground = True
        loPanorama.ShowGroups = True
        loPanorama.Size = New System.Drawing.Size(787, 315)
        'loPanorama.PanelImageSize = New System.Drawing.Size(1024, 768)
        loPanorama.PanelImage = Nothing
        loPanorama.PanoramaElement.BackColor = Color.Transparent
        loPanorama.PanoramaElement.NumberOfColors = 1
        loPanorama.PanoramaElement.DrawBorder = False
        loPanorama.Tag = pnLEVEL
        loPanorama.Text = pcMenuName
        loPanorama.MouseWheelBehavior = PanoramaMouseWheelBehavior.Scroll
        'loPanorama.EnableZooming = True
        Dim loFill As FillPrimitive = TryCast(loPanorama.PanoramaElement.ScrollBar.Children(1), FillPrimitive)
        If loFill IsNot Nothing Then
            loFill.BackColor = Color.FromArgb(20, 20, 20)
            loFill.NumberOfColors = 1
            loFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        End If

        Dim loFill1 As FillPrimitive = TryCast(loPanorama.PanoramaElement.ScrollBar.Children(0), FillPrimitive)
        If loFill1 IsNot Nothing Then
            loFill1.BackColor = Color.FromArgb(20, 20, 20)
            loFill1.NumberOfColors = 1
            loFill1.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        End If

        loPanorama.PanoramaElement.ScrollBar.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

        loPanorama.PanoramaElement.ScrollBar.ThumbElement.ThumbFill.BackColor = Color.FromArgb(51, 51, 51)
        loPanorama.PanoramaElement.ScrollBar.ThumbElement.ThumbFill.NumberOfColors = 1
        loPanorama.PanoramaElement.ScrollBar.ThumbElement.ThumbFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        loPanorama.PanoramaElement.ScrollBar.ThumbElement.ThumbBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        loPanorama.PanoramaElement.ScrollBar.ThumbElement.GripImage = Nothing

        '' Add Panorama Handler
        AddHandler loPanorama.MouseDown, AddressOf RadPanorama_MouseDown
        AddHandler loPanorama.PanoramaElement.DragDropService.Stopped, AddressOf RadPanoramaDragDropService_Stopped

        '' METHOD | Create Header
        _CreateHeader(loPanorama)

        'LINQ All Group
        Dim q = From p In poMenuDTOList Where p.CSUB_MENU_TYPE = "G" And p.CMENU_ID = pcMENU_ID.Trim Order By p.IGROUP_INDEX Ascending
        For Each loMenuDTOGroup In q
            With loMenuDTOGroup
                '' METHOD | Create Group
                loTileGroupElement = _createGroup(loPanorama, loMenuDTOGroup)

                'LINQ All Program & Folder with ParentMenuId = poGroupTile.Name
                Dim s = From r In poMenuDTOList Where r.CPARENT_SUB_MENU_ID = .CSUB_MENU_ID And r.CMENU_ID = pcMENU_ID.Trim Order By r.IFAVORITE_INDEX Ascending
                For Each loMenuDTOProgram In s
                    With loMenuDTOProgram
                        '' METHOD | Create Tile
                        _createTile(loTileGroupElement, loMenuDTOProgram)
                    End With
                Next
            End With
        Next

        'add button on top left form
        Dim oBtnPin As New R_DockingButtonLayout()
        With oBtnPin
            .Name = "btn" & pcMENU_ID.ToString
            .MaxSize = New Size(28, 28)
            .Size = New Size(25, 25)
            .Margin = New Padding(Me.Width - 100, 15, 0, 0)
            '.Image = My.Resources._1440516992_pin.GetThumbnailImage(25, 25, Nothing, New IntPtr())
            .ToolTipText = "Pin"
            'AddHandler .Click, AddressOf dockBtn_Click
        End With
        Return loPanorama
    End Function
#End Region
#Region " _createGroup "
    Private Function _createGroup(ByRef poPanorama As Telerik.WinControls.UI.RadPanorama, ByVal poMenuDTOGroup As MenuDTO) As TileGroupElement
        '' Create Group Tile
        Dim loTileGroupElement As New TileGroupElement
        Dim loEx As New R_Exception

        Try
            With poMenuDTOGroup
                '' Group Tile Properties
                loTileGroupElement.Alignment = System.Drawing.ContentAlignment.TopLeft
                loTileGroupElement.AutoSize = True
                loTileGroupElement.CellSize = New System.Drawing.Size(120, 120)
                loTileGroupElement.Margin = New System.Windows.Forms.Padding(15, 50, 15, 0)
                loTileGroupElement.Name = .CSUB_MENU_ID
                loTileGroupElement.RowsCount = 4
                loTileGroupElement.Text = .CSUB_MENU_NAME
                loTileGroupElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
                loTileGroupElement.DrawBorder = True
                loTileGroupElement.BorderDashStyle = Drawing2D.DashStyle.Dash
                loTileGroupElement.Font = New System.Drawing.Font("Arial", 11)
                loTileGroupElement.ForeColor = Color.White
                loTileGroupElement.BorderColor = Color.FromArgb(35.3, 35.3, 35.3)
                loTileGroupElement.BorderGradientStyle = GradientStyles.Solid

                '' Add Handler for Group Tile
                AddHandler loTileGroupElement.MouseDown, AddressOf TileGroupElement_MouseDown

                If .IGROUP_INDEX.HasValue Then
                    '' Insert to Panorama
                    poPanorama.Groups.Insert(.IGROUP_INDEX, loTileGroupElement)
                Else
                    '' Add to Panorama
                    poPanorama.Groups.Insert(poPanorama.Groups.Count, loTileGroupElement)
                End If
            End With
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loTileGroupElement
    End Function
#End Region
#Region " _createTile "
    Private Function _createTile(ByRef poGroupTile As TileGroupElement, ByVal poMenuDTO As MenuDTO) As RadTileElement
        '' Create Tile
        Dim loRadTileElement As New RadTileElement

        With poMenuDTO
            '' Set Tile Properties
            loRadTileElement.ImageAlignment = geImageTextAlignment.TopCenter
            loRadTileElement.TextAlignment = geImageTextAlignment.BottomCenter
            loRadTileElement.TextImageRelation = geTextImageRelation.Overlay
            loRadTileElement.RowSpan = 1
            loRadTileElement.ColSpan = 1
            loRadTileElement.ToolTipText = .CSUB_MENU_TOOL_TIP
            loRadTileElement.Name = .CSUB_MENU_ID
            loRadTileElement.Text = .CSUB_MENU_NAME
            loRadTileElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
            loRadTileElement.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            loRadTileElement.AutoToolTip = True
            loRadTileElement.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
            loRadTileElement.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold)
            loRadTileElement.ForeColor = Color.White
            loRadTileElement.Tag = .CSUB_MENU_TYPE
            loRadTileElement.AllowDrag = True
            loRadTileElement.AllowDrop = True
            loRadTileElement.TextWrap = True
            loRadTileElement.BorderWidth = 3
            loRadTileElement.BorderColor = Color.Transparent
            loRadTileElement.BackColor = Color.Transparent
            loRadTileElement.GradientStyle = GradientStyles.Solid
            loRadTileElement.CellPadding = New Padding(-1)

            If .CSUB_MENU_TYPE = "F" Then
                'loRadTileElement.Image = My.Resources.Folder_123.GetThumbnailImage(120, 120, Nothing, New IntPtr())
            Else '.MenuType = "P"
                Try
                    loRadTileElement.Image = Image.FromFile(Application.StartupPath + "\Image\" + .CSUB_MENU_IMAGE.ToString.Trim + ".png").GetThumbnailImage(120, 120, Nothing, New IntPtr())
                Catch ex As FileNotFoundException
                    loRadTileElement.Image = My.Resources.ICON_ERROR_3.GetThumbnailImage(120, 120, Nothing, New IntPtr())
                Catch ex As Exception
                End Try
            End If

            If .ICOLUMN_INDEX.HasValue Then
                loRadTileElement.Column = .ICOLUMN_INDEX.Value
            End If

            If .IROW_INDEX.HasValue Then
                loRadTileElement.Row = .IROW_INDEX.Value
            End If

            loRadTileElement.ToolTipText = .CSUB_MENU_TOOL_TIP

            If .ICOLUMN_INDEX.HasValue Then
                loRadTileElement.Column = .ICOLUMN_INDEX
            End If

            If .IROW_INDEX.HasValue Then
                loRadTileElement.Row = .IROW_INDEX
            End If

            '' Add Handler For Tile Element
            AddHandler loRadTileElement.MouseDown, AddressOf RadTileElement_MouseDown
            AddHandler loRadTileElement.MouseUp, AddressOf RadTileElement_MouseUp
            AddHandler loRadTileElement.MouseEnter, AddressOf TileElement_MouseEnter
            AddHandler loRadTileElement.MouseLeave, AddressOf TileElement_MouseLeave
        End With

        '' Insert to Group
        poGroupTile.Items.Add(loRadTileElement)

        Return loRadTileElement
    End Function
#End Region
#Region " FAVOURITE "
#Region " _createPanoramaFAV "
    Private Function _createPanoramaFAV(ByVal pcMENU_ID As String, ByVal pnLEVEL As Integer, ByVal poMenuDTOList As List(Of MenuDTO)) As Telerik.WinControls.UI.RadPanorama
        Dim loTileGroupElement As TileGroupElement

        '' Create Panorama
        Dim loPanorama As Telerik.WinControls.UI.RadPanorama
        loPanorama = New Telerik.WinControls.UI.RadPanorama

        '' Set Panorama Properties
        loPanorama.BackColor = System.Drawing.Color.Transparent
        loPanorama.Dock = System.Windows.Forms.DockStyle.Fill
        loPanorama.Location = New System.Drawing.Point(0, 0)
        loPanorama.Margin = New System.Windows.Forms.Padding(0)
        loPanorama.Name = pcMENU_ID
        loPanorama.ScrollBarThickness = 1
        loPanorama.ScrollingBackground = True
        loPanorama.ShowGroups = True
        loPanorama.Size = New System.Drawing.Size(787, 315)
        loPanorama.PanelImageSize = New System.Drawing.Size(1024, 768)
        loPanorama.Tag = pnLEVEL

        '' Add Panorama Handler
        AddHandler loPanorama.MouseDown, AddressOf RadPanorama_MouseDown
        AddHandler loPanorama.PanoramaElement.DragDropService.Stopped, AddressOf RadPanoramaDragDropService_Stopped

        '' METHOD | Create Header
        _CreateHeader(loPanorama)

        'LINQ All Group
        Dim q = From p In poMenuDTOList Where p.CSUB_MENU_TYPE = "G" And p.CMENU_ID = pcMENU_ID.Trim Order By p.IGROUP_INDEX Ascending
        For Each loMenuDTOGroup In q
            With loMenuDTOGroup
                '' METHOD | Create Group
                loTileGroupElement = _createGroup(loPanorama, loMenuDTOGroup)

                'LINQ All Program & Folder with ParentMenuId = poGroupTile.Name
                Dim s = From r In poMenuDTOList Where r.LFAVORITE = True Order By r.IFAVORITE_INDEX Ascending
                For Each loMenuDTOProgram In s
                    With loMenuDTOProgram
                        '' METHOD | Create Tile
                        _createTile(loTileGroupElement, loMenuDTOProgram)
                    End With
                Next
            End With
        Next

        Return loPanorama
    End Function
#End Region
#End Region

#End Region
#Region " CONTEXT MENU "
#Region " _preparePanoramaContextMenu "
    Private Sub _preparePanoramaContextMenu()
        '' Clear Context Menu Panorama
        rcmPanoramaMouseDown.Items.Clear()

        rcmPanoramaMouseDown = New R_MenuContext(R_Utility.R_GetMessage(Me.GetType, "_CreateGroup"))

        Dim loHostedTextBox As RadMenuHostItem
        Dim oTxtLayout As New R_ButtonTextboxLayout
        loHostedTextBox = New RadMenuHostItem(oTxtLayout)
        loHostedTextBox.MinSize = New Size(150, 0)
        rcmPanoramaMouseDown.Items.Add(loHostedTextBox)
        grtbPanoramaGroupName = oTxtLayout

        AddHandler oTxtLayout.goButton.Click, AddressOf rmiCreateGroup_Click
        AddHandler oTxtLayout.KeyUp, AddressOf rmiCreateGroup_KeyUp
    End Sub
    Private Sub rmiCreateGroup_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If TypeOf (sender) Is RadTextBox Then
            If e.KeyCode = Keys.Enter Then
                Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)

                Dim lnNextId As Integer

                If grtbPanoramaGroupName.Text.Trim = "" Then
                    R_RadMessageBox.Show(R_Utility.R_GetError(Me.GetType, "Err002").ErrDescp)
                Else
                    '' Close Context Menu
                    rcmPanoramaMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)
                    '' Get Last Group Id
                    Dim loMenuDTOGroup As MenuDTO
                    '' SYSY Change Company Id And User Id From Login
                    loMenuDTOGroup = loService.getLastId(gcCompanyId.Trim, gcUserId.Trim, _oRadPanorama.Name.ToString.Trim, "G")
                    '' + 1 Menu Id
                    If loMenuDTOGroup IsNot Nothing Then
                        lnNextId = CInt(loMenuDTOGroup.CSUB_MENU_ID.Substring(1)) + 1
                    Else
                        lnNextId = 1
                    End If
                    '' Prepare Parameter
                    Dim loParam As New MenuDTO
                    With loParam
                        .CCOMPANY_ID = gcCompanyId
                        .CUSER_ID = gcUserId
                        .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                        .CSUB_MENU_TYPE = "G"
                        .CSUB_MENU_ID = "G" + lnNextId.ToString.Trim.PadLeft(3, "0") '"Group" + rtbPanoramaGroup.Text.ToString.Trim.Replace(" ", "")
                        .CSUB_MENU_NAME = grtbPanoramaGroupName.Text.ToString.Trim
                        .CSUB_MENU_TOOL_TIP = grtbPanoramaGroupName.Text.ToString.Trim
                        .IGROUP_INDEX = _oRadPanorama.Groups.Count
                        .IROW_INDEX = Nothing
                        .ICOLUMN_INDEX = Nothing
                        .IFAVORITE_INDEX = Nothing
                        .CPARENT_SUB_MENU_ID = _oRadPanorama.Name.Trim
                        .ILEVEL = _oRadPanorama.Tag
                    End With
                    '' Create Group
                    _createGroup(_oRadPanorama, loParam)

                    '' Save Group to DB
                    loService.insertMenuToDB(loParam)

                    '' Set Context Menu Panorama Group text to ""
                    grtbPanoramaGroupName.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub rmiCreateGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)

        Dim lnNextId As Integer

        If grtbPanoramaGroupName.Text.Trim = "" Then
            R_RadMessageBox.Show(R_Utility.R_GetError(Me.GetType, "Err002").ErrDescp)
        Else
            '' Close Context Menu
            rcmPanoramaMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)
            '' Get Last Group Id
            Dim loMenuDTOGroup As MenuDTO
            '' SYSY Change Company Id And User Id From Login
            loMenuDTOGroup = loService.getLastId(gcCompanyId.Trim, gcUserId.Trim, _oRadPanorama.Name.ToString.Trim, "G")
            '' + 1 Menu Id
            If loMenuDTOGroup IsNot Nothing Then
                lnNextId = CInt(loMenuDTOGroup.CSUB_MENU_ID.Substring(1)) + 1
            Else
                lnNextId = 1
            End If
            '' Prepare Parameter
            Dim loParam As New MenuDTO
            With loParam
                .CCOMPANY_ID = gcCompanyId
                .CUSER_ID = gcUserId
                .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                .CSUB_MENU_TYPE = "G"
                .CSUB_MENU_ID = "G" + lnNextId.ToString.Trim.PadLeft(3, "0") '"Group" + rtbPanoramaGroup.Text.ToString.Trim.Replace(" ", "")
                .CSUB_MENU_NAME = grtbPanoramaGroupName.Text.ToString.Trim
                .CSUB_MENU_TOOL_TIP = grtbPanoramaGroupName.Text.ToString.Trim
                .IGROUP_INDEX = _oRadPanorama.Groups.Count
                .IROW_INDEX = Nothing
                .ICOLUMN_INDEX = Nothing
                .IFAVORITE_INDEX = Nothing
                .CPARENT_SUB_MENU_ID = _oRadPanorama.Name.Trim
                .ILEVEL = _oRadPanorama.Tag
            End With
            '' Create Group
            _createGroup(_oRadPanorama, loParam)

            '' Save Group to DB
            loService.insertMenuToDB(loParam)

            '' Set Context Menu Panorama Group text to ""
            grtbPanoramaGroupName.Text = ""
        End If
    End Sub
#End Region
#Region " _prepareTileGroupElementContextMenu "
    Private Sub _prepareTileGroupElementContextMenu(ByVal poTileGroupElement As TileGroupElement)
        '' Clear Context Menut Tile Group Element
        rcmTileGroupElementMouseDown.Items.Clear()

        rcmTileGroupElementMouseDown = New R_MenuContext

        '' Delete Group if no tile exists in group
        If poTileGroupElement.Items.Count <= 0 And _oRadPanorama.Groups.Count > 1 Then
            Dim menuItemDelGroup As New R_RadMenuItem(R_Utility.R_GetMessage(Me.GetType, "_DeleteGroup"))

            With menuItemDelGroup
                '.Text = R_Utility.R_GetMessage(Me.GetType, "_DeleteGroup")
                .Image = My.Resources.close.GetThumbnailImage(15, 15, Nothing, New IntPtr())
                '.ImageAlignment = ContentAlignment.MiddleCenter
                '.Margin = New Padding(5, 5, 0, 0)
                '.AutoSize = True
                '.BorderPrimitive.ShouldPaint = False
                '.ForeColor = Color.White
            End With
            rcmTileGroupElementMouseDown.Items.Add(menuItemDelGroup)

            AddHandler menuItemDelGroup.Click, AddressOf rmiDeleteGroup_Click
            'AddHandler menuItemDelGroup.MouseEnter, AddressOf allContext_MouseEnter
            'AddHandler menuItemDelGroup.MouseLeave, AddressOf allContext_MouseLeave
        End If

        '' Move Group Up
        If _oRadPanorama.Groups.IndexOf(poTileGroupElement) > 0 Then
            Dim menuItemMoveLeft As New R_RadMenuItem(R_Utility.R_GetMessage(Me.GetType, "_MoveGroupLeft"))

            With menuItemMoveLeft
                '.Text = R_Utility.R_GetMessage(Me.GetType, "_MoveGroupLeft")
                '.Margin = New System.Windows.Forms.Padding(17, 0, 0, 0)
                '.AutoSize = True
                '.BorderPrimitive.ShouldPaint = False
            End With
            rcmTileGroupElementMouseDown.Items.Add(menuItemMoveLeft)

            AddHandler menuItemMoveLeft.Click, AddressOf rmiMoveGroupUp_Click
            'AddHandler menuItemMoveLeft.MouseEnter, AddressOf allContext_MouseEnter
            'AddHandler menuItemMoveLeft.MouseLeave, AddressOf allContext_MouseLeave
        End If
        '' Move Group Down
        If _oRadPanorama.Groups.IndexOf(poTileGroupElement) < (_oRadPanorama.Groups.Count - 1) Then
            Dim menuItemMoveRight As New R_RadMenuItem(R_Utility.R_GetMessage(Me.GetType, "_MoveGroupRight"))

            With menuItemMoveRight
                '.Text = R_Utility.R_GetMessage(Me.GetType, "_MoveGroupRight")
                '.Margin = New System.Windows.Forms.Padding(17, 0, 0, 0)
                '.AutoSize = True
                '.BorderPrimitive.ShouldPaint = False
            End With
            rcmTileGroupElementMouseDown.Items.Add(menuItemMoveRight)

            AddHandler menuItemMoveRight.Click, AddressOf rmiMoveGroupDown_Click
            'AddHandler menuItemMoveRight.MouseEnter, AddressOf allContext_MouseEnter
            'AddHandler menuItemMoveRight.MouseLeave, AddressOf allContext_MouseLeave
        End If

        'add separator
        rcmTileGroupElementMouseDown.Items.Add(New RadMenuSeparatorItem)

        '' Rename Group
        Dim loRadMenuHeaderItem1 As New RadMenuHeaderItem
        loRadMenuHeaderItem1.Text = R_Utility.R_GetMessage(Me.GetType, "_RenameGroup")
        rcmTileGroupElementMouseDown.Items.Add(loRadMenuHeaderItem1)

        Dim loHostedTextBox As RadMenuHostItem
        Dim oTxtLayout As New R_ButtonTextboxLayout
        loHostedTextBox = New RadMenuHostItem(oTxtLayout)
        'loHostedTextBox.Margin = New System.Windows.Forms.Padding(35, 0, 0, 0)
        rcmTileGroupElementMouseDown.Items.Add(loHostedTextBox)
        grtbTileGroupElementFolderRename = oTxtLayout

        AddHandler oTxtLayout.goButton.Click, AddressOf rmiRenameGroup_Click
        AddHandler oTxtLayout.KeyUp, AddressOf oTxtLayout_KeyUp
    End Sub
    Private Sub oTxtLayout_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim loService As MenuServiceClient = R_ServiceClientWrapper.R_GetServiceClient(Of IMenuService, MenuServiceClient)(e_ServiceClientType.RegularService, C_ServiceName)

        If TypeOf (sender) Is R_ButtonTextboxLayout Then
            If e.KeyCode = Keys.Enter Then
                If grtbTileGroupElementFolderRename.Text.Trim = "" Then
                    R_RadMessageBox.Show(R_Utility.R_GetError(Me.GetType, "Err003").ErrDescp)
                Else
                    '' Close Context Menu
                    rcmTileGroupElementMouseDown.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)

                    '' Prepare Parameter
                    Dim loParam As New MenuDTO
                    With loParam
                        .CCOMPANY_ID = gcCompanyId
                        .CUSER_ID = gcUserId
                        .CMENU_ID = _oRadPanorama.Name.ToString.Trim
                        .CSUB_MENU_TYPE = "G"
                        .CSUB_MENU_ID = goTileGroupElement.Name.Trim
                        .CSUB_MENU_NAME = grtbTileGroupElementFolderRename.Text.Trim
                        .CSUB_MENU_TOOL_TIP = grtbTileGroupElementFolderRename.Text.Trim
                    End With
                    '' Update Group Name To DB
                    loService.updateMenuNameToDB(loParam)

                    '' Update Group Name & ToolTip
                    goTileGroupElement.Text = grtbTileGroupElementFolderRename.Text.Trim
                    goTileGroupElement.ToolTipText = grtbTileGroupElementFolderRename.Text.Trim

                    '' Set Tile Group Element Folder Rename text to ""
                    grtbTileGroupElementFolderRename.Text = ""
                End If
            End If
        End If


    End Sub
#End Region
#Region " _prepareTileContextMenu "
    Private Sub _prepareTileContextMenu()
        '' Clear Context Menu Tile Element
        rcmTileMouseDown.Items.Clear()

        rcmTileMouseDown = New R_MenuContext

        Dim menuItem As New R_RadMenuItem(R_Utility.R_GetMessage(Me.GetType, "_MarkFav"))

        With menuItem
            '.Text = R_Utility.R_GetMessage(Me.GetType, "_MarkFav")
            .Image = My.Resources.star.GetThumbnailImage(15, 15, Nothing, New IntPtr())
            '.ImageAlignment = ContentAlignment.MiddleCenter
            '.AutoSize = True
            '.BorderPrimitive.ShouldPaint = False
        End With
        rcmTileMouseDown.Items.Add(menuItem)

        AddHandler menuItem.Click, AddressOf rmiMarkAsFavourite_Click
        'AddHandler menuItem.MouseEnter, AddressOf allContext_MouseEnter
        'AddHandler menuItem.MouseLeave, AddressOf allContext_MouseLeave
    End Sub
#End Region
#Region " _prepareButtonFavouriteContextMenu "
    Private Sub _prepareButtonFavouriteContextMenu()
        '' Clear Context Menu Tile Element
        rcmButtonFavouriteMouseDown.Items.Clear()

        rcmButtonFavouriteMouseDown = New R_MenuContext

        Dim menuItem As New R_RadMenuItem(R_Utility.R_GetMessage(Me.GetType, "_UnMarkFav"))

        With menuItem
            '.Text = R_Utility.R_GetMessage(Me.GetType, "_UnMarkFav")
            .Image = My.Resources.close.GetThumbnailImage(15, 15, Nothing, New IntPtr())
            '.ImageAlignment = ContentAlignment.MiddleCenter
            '.AutoSize = True
            '.BorderPrimitive.ShouldPaint = False
        End With
        rcmButtonFavouriteMouseDown.Items.Add(menuItem)

        AddHandler menuItem.Click, AddressOf rmiUnMarkFavourite_Click
        'AddHandler menuItem.MouseEnter, AddressOf allContext_MouseEnter
        'AddHandler menuItem.MouseLeave, AddressOf allContext_MouseLeave
    End Sub
#End Region
    'Private Sub allContext_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
    '    If TypeOf (sender) Is RadMenuItem Then
    '        CType(sender, RadMenuItem).FillPrimitive.BackColor = Color.LightGray
    '    End If
    'End Sub
    'Private Sub allContext_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
    '    If TypeOf (sender) Is RadMenuItem Then
    '        CType(sender, RadMenuItem).FillPrimitive.ResetValue(FillPrimitive.BackColorProperty, ValueResetFlags.Local)
    '    End If
    'End Sub
#End Region
#End Region
#End Region

    Private Sub WorkerMethod(sender As Object, e As WaitFormEventArgs)
        'System.Threading.Thread.Sleep(1000)
        If e.Arguments IsNot Nothing Then
            If e.Arguments.Count > 0 Then
                e.Result = e.Arguments(0).ToString()
            Else
                e.Result = ""
            End If
        End If
    End Sub

    Private Sub Menu_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode.ToString = "F" Then
            goRadDock.ShowAutoHidePopup(goRadDock.GetHostWindow(oSearchForm))
            oSearchForm.txtSearch.Focus()
        End If
    End Sub

    'Private Sub PopulateData(pDropDownListElement As RadDropDownListElement)
    '    pDropDownListElement.BeginUpdate()
    '    pDropDownListElement.DataSource = loMenuDTOList
    '    pDropDownListElement.ValueMember = "CSUB_MENU_ID"
    '    pDropDownListElement.DisplayMember = "CSUB_MENU_TOOL_TIP"
    '    pDropDownListElement.EndUpdate()
    '    pDropDownListElement.SelectedIndex = -1
    'End Sub

    Private Sub goTitleBar_SearchIconClick(sender As Object, e As System.EventArgs) Handles goTitleBar.SearchIconClick
        goRadDock.ShowAutoHidePopup(goRadDock.GetHostWindow(oSearchForm))
        oSearchForm.txtSearch.Focus()
    End Sub

    Private Sub rcmPanoramaMouseDown_DropDownOpening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rcmPanoramaMouseDown.DropDownOpening
        'Dim oContextFill As FillPrimitive = TryCast(rcmPanoramaMouseDown.DropDown.PopupElement.Children(0), FillPrimitive)
        'If oContextFill IsNot Nothing Then
        '    oContextFill.BackColor = Color.FromArgb(51, 51, 51)
        'End If

        'Dim oContextBorder As BorderPrimitive = TryCast(rcmPanoramaMouseDown.DropDown.PopupElement.Children(1), BorderPrimitive)
        'If oContextBorder IsNot Nothing Then
        '    oContextBorder.Visibility = ElementVisibility.Collapsed
        'End If

        'Dim oContextSidePanel As RadElement = TryCast(rcmPanoramaMouseDown.DropDown.PopupElement.Children(2), RadElement)
        'If oContextSidePanel IsNot Nothing Then
        '    Dim oContextSidePanelFill As FillPrimitive = TryCast(oContextSidePanel.Children(0), FillPrimitive)
        '    If oContextSidePanelFill IsNot Nothing Then
        '        oContextSidePanelFill.Visibility = ElementVisibility.Collapsed
        '    End If
        'End If

        'Dim oRadMenuHeaderItem As RadMenuHeaderItem = rcmPanoramaMouseDown.Items.Where(Function(x) TypeOf (x) Is RadMenuHeaderItem).FirstOrDefault
        'oRadMenuHeaderItem.Font = New Font("Segoe UI", 9)
        'oRadMenuHeaderItem.FillPrimitive.BackColor = Color.FromArgb(51, 51, 51)
        'oRadMenuHeaderItem.TextPrimitive.ForeColor = Color.White
    End Sub
End Class

Public Class R_PredefinedDTO
    Dim _loPredefineDock As R_PredefinedDock
    Dim _lnIndex As Integer

    Public Property lnIndex() As Integer
        Get
            Return Me._lnIndex
        End Get
        Set(value As Integer)
            Me._lnIndex = value
        End Set
    End Property

    Public Property loPredefineDock() As R_PredefinedDock
        Get
            Return Me._loPredefineDock
        End Get
        Set(value As R_PredefinedDock)
            Me._loPredefineDock = value
        End Set
    End Property
End Class



