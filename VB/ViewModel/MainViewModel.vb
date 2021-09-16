Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace Example.ViewModel
	Public Class MainViewModel
		Inherits ViewModelBase

		Private savedText As String

		Public Property Text() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
				RaisePropertyChanged(NameOf(IsSaved))
			End Set
		End Property
		Public ReadOnly Property IsSaved() As Boolean
			Get
				Return Text = savedText AndAlso Not String.IsNullOrEmpty(Text)
			End Get
		End Property

		<Command>
		Public Sub Save()
			savedText = Text
			RaisePropertyChanged(NameOf(IsSaved))
		End Sub

		<Command>
		Public Sub Close()
			savedText = String.Empty
			Text = String.Empty
		End Sub
	End Class
End Namespace
