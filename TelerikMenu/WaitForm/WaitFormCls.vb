Public NotInheritable Class WaitFormCls
    Public Shared Function Show(workerMethod As EventHandler(Of WaitFormEventArgs)) As Object
        Return WaitFormCls.Show(workerMethod, Nothing)
    End Function

    Public Shared Function Show(workerMethod As EventHandler(Of WaitFormEventArgs), message As String) As Object
        Dim instance As New WaitFormCls()
        Return instance.Show(workerMethod, message, New List(Of Object)())
    End Function

    Public Shared Function Show(workerMethod As EventHandler(Of WaitFormEventArgs), message As String, ParamArray args As Object()) As Object
        Dim arguments As New List(Of Object)()
        arguments.AddRange(args)

        Dim instance As New WaitFormCls
        Return instance.Show(workerMethod, message, arguments)
    End Function

    Public Sub New()
    End Sub

    Private _Form As WaitForm
    Friend Delegate Sub methodinvoker(Of T)(param1 As T)
    Friend _WorkerMethod As EventHandler(Of WaitFormEventArgs)
    Friend _Args As List(Of Object)

    Public WriteOnly Property Message As String
        Set(value As String)
            Me._Form.Invoke(New methodinvoker(Of String)(AddressOf Me._Form.SetMessage), value)
        End Set
    End Property

    Public Sub Cancel()
        Me._Form.Invoke(New methodinvoker(AddressOf Me._Form.Cancel), Nothing)
    End Sub

    Private Function Show(workerMethod As EventHandler(Of WaitFormEventArgs), message As String, args As List(Of Object)) As Object
        If workerMethod Is Nothing Then
            Throw New ArgumentException("No worker method has been specified.", "workerMethod")
        Else
            Me._WorkerMethod = workerMethod
        End If

        Me._Args = args

        If String.IsNullOrEmpty(message) Then
            message = "Please wait..."
        End If

        Me._Form = New WaitForm(Me)
        Me._Form.lblMessage.Text = message

        Me._Form.ShowDialog()

        Dim result As Object = Me._Form._Result

        Dim _Error As Exception = Me._Form._Error
        Me._Form.Dispose()

        If _Error IsNot Nothing Then
            Throw _Error
        Else
            Return result
        End If
    End Function
End Class
