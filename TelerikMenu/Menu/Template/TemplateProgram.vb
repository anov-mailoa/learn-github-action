Imports R_FrontEnd
Imports Telerik.WinControls.UI.Docking

Public Class TemplateProgram

    Private _cFormParent As String
    Private _cDockCollection As New List(Of R_DocumentWindow)

#Region "PROPERTY"
#Region " PROPERTY R_FormParent "
    Public Property R_FormParent() As String
        Get
            Return _cFormParent
        End Get
        Set(ByVal value As String)
            _cFormParent = value
        End Set
    End Property

    Public Property R_DockCollection As Object
        Get
            Return _cDockCollection
        End Get
        Set(value As Object)
            For Each oDock As R_DocumentWindow In value
                _cDockCollection.Add(oDock)
            Next
        End Set
    End Property
#End Region
#End Region

#Region " EVENT's IMPLEMENTATION "
#Region " RadDock_ActiveWindowChanged "
    Private Sub RadDock_ActiveWindowChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Docking.DockWindowEventArgs) Handles RadDockTemplate.ActiveWindowChanged
        If e.DockWindow IsNot Nothing Then
            With CType(e.DockWindow, R_DocumentWindow)
                If .R_PredefinedDockComponent IsNot Nothing Then
                    If .R_IsPredefined Then
                        Dim loParameter As Object = Nothing
                        Dim lcAccess As String = "V"

                        If .R_PredefinedDockComponent.R_CopyAccess Then
                            lcAccess = .R_PredefinedDockComponent.R_FormParent.R_Access
                        Else
                            lcAccess = CType(.R_PredefinedDockComponent.R_FormParent, R_IFormAccess).R_AccessDetail
                        End If

                        .R_PredefinedDockComponent.R_GetParameterAndAccess(loParameter, lcAccess)
                        CType(.R_Form, R_IFormAccess)._SetAccess(lcAccess)
                        CType(.R_Form, R_IFormBase)._InitFromMaster(loParameter, R_eFormModel.Predefine, Nothing)
                    End If
                End If
            End With
        End If
    End Sub
#End Region
#Region " RadDock_ActiveWindowChanging "
    Private Sub RadDock_ActiveWindowChanging(sender As Object, e As Telerik.WinControls.UI.Docking.DockWindowCancelEventArgs) Handles RadDockTemplate.ActiveWindowChanging
        If e.OldWindow IsNot Nothing Then
            With CType(e.OldWindow, R_DocumentWindow)
                If .R_IsPredefined AndAlso .R_IsActive Then
                    e.Cancel = True
                    Exit Sub
                End If
            End With
        End If

        With CType(e.NewWindow, R_DocumentWindow)
            If .R_EnableDock = False Then
                e.Cancel = True
                Exit Sub
            End If
            If .R_IsPredefined Then
                If .R_PredefinedDockComponent IsNot Nothing Then
                    If .R_PredefinedDockComponent.R_EnableHASDATA AndAlso Not .R_PredefinedDockComponent.R_HasData Then
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        End With
    End Sub
#End Region
#Region " RadDock_DockWindowClosing "
    Private Sub RadDock_DockWindowClosing(sender As Object, e As Telerik.WinControls.UI.Docking.DockWindowCancelEventArgs) Handles RadDockTemplate.DockWindowClosing
        If e.NewWindow.Controls(0) IsNot Nothing Then
            If TypeOf (e.NewWindow.Controls(0)) Is R_FormBase Then
                CType(e.NewWindow.Controls(0), R_FormBase).R_Closing(e)
            End If
        End If
    End Sub
#End Region
#Region " RadDock_DockWindowClosed "
    Private Sub RadDockTemplate_DockWindowClosed(sender As Object, e As Telerik.WinControls.UI.Docking.DockWindowEventArgs) Handles RadDockTemplate.DockWindowClosed
        If _cFormParent IsNot Nothing Then
            CType(sender, RadDock).ActivateWindow(CType(sender, RadDock).DockWindows(_cFormParent))
        End If
    End Sub
#End Region
#Region " Load "

    Private Sub TemplateProgram_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        RadDockTemplate.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.ToBack
        RadDockTemplate.DocumentTabsAlignment = Telerik.WinControls.UI.TabStripAlignment.Top
        'Me.R_DockCollection = CType(Me.Parent.Parent, DocumentTabStrip).DockManager.DockWindows
        'set transparent document container
        CType(RadDockTemplate.Controls(0), DocumentContainer).SplitContainer.SplitPanelElement.Fill.ShouldPaint = False
        CType(RadDockTemplate.Controls(0), DocumentContainer).SplitPanelElement.Fill.ShouldPaint = False
    End Sub
#End Region
#End Region
End Class
