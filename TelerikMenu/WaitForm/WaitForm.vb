Partial Friend Class WaitForm

    Public Sub New(parent As WaitFormCls)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._parent = parent
        Me.BackColor = Color.FromArgb(23, 23, 23)
        Me.lblMessage.ForeColor = Color.White
        Me.lblMessage.Font = New Font("Segoe UI", 10)
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Private _parent As WaitFormCls
    Private Delegate Function functioninvoker(Of T)() As T
    Friend _Result As Object
    Friend _Error As Exception
    Private threadResult As IAsyncResult

    Protected Overrides Sub OnShown(e As System.EventArgs)
        MyBase.OnShown(e)

        Dim threadController As New functioninvoker(Of Object)(AddressOf Me.DoWork)

        Me.threadResult = threadController.BeginInvoke(AddressOf Me.WorkComplete, threadController)
        WaitBar.StartWaiting()
    End Sub

    Friend Function DoWork() As Object
        Dim e As New WaitFormEventArgs(Me._parent, Me._parent._Args)
        If (Me._parent._WorkerMethod IsNot Nothing) Then
            Me._parent._WorkerMethod(Me, e)
        End If
        Return e.Result
    End Function

    Private Sub WorkComplete(result As IAsyncResult)
        If Not Me.IsDisposed Then
            If Me.InvokeRequired Then
                Me.Invoke(New WaitFormCls.methodinvoker(Of IAsyncResult)(AddressOf Me.WorkComplete), result)
            Else
                Try
                    Me._Result = DirectCast(result.AsyncState, functioninvoker(Of Object)).EndInvoke(result)
                Catch ex As Exception
                    Me._Error = ex
                End Try
                Me.Close()
            End If
        End If
    End Sub

    Friend Sub SetMessage(message As String)
        Me.lblMessage.Text = message
    End Sub

    Friend Sub Cancel()
        Me.Invoke(New MethodInvoker(AddressOf Me.Close), Nothing)
    End Sub

    'Private Sub WaitForm_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    'End Sub
End Class
