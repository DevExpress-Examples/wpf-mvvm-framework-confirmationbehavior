Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace Example.ViewModel
    <POCOViewModel> _
    Public Class MainViewModel
        Private SavedText As String
        Public Overridable Property Text() As String
        Public ReadOnly Property IsSaved() As Boolean
            Get
                Return Text = SavedText
            End Get
        End Property
        Public Sub Save()
            SavedText = Text
            Me.RaisePropertyChanged(Function(x) x.IsSaved)
        End Sub
        Public Sub Close()
            SavedText = ""
            Text = ""
        End Sub
        Protected Sub OnTextChanged()
            Me.RaisePropertyChanged(Function(x) x.IsSaved)
        End Sub
    End Class
End Namespace
