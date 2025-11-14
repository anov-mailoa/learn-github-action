Public Class WaitFormEventArgs
    Inherits EventArgs

    Public Sub New(oForm As WaitFormCls, args As List(Of Object))
        MyBase.New()
        'Me._
    End Sub

    Private _Form As WaitFormCls
    Private _Arguments As List(Of Object)
    Private _Result As Object

    Public ReadOnly Property Form As WaitFormCls
        Get
            Return _Form
        End Get
    End Property

    Public ReadOnly Property Arguments As List(Of Object)
        Get
            Return _Arguments
        End Get
    End Property

    Public Property Result As Object
        Get
            Return _Result
        End Get
        Set(value As Object)
            _Result = value
        End Set
    End Property
End Class
