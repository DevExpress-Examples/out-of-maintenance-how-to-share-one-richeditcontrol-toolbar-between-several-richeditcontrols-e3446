Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.RichEdit
Imports System.Windows.Threading
Imports System

Namespace RichEditTwoControlsOneToolbarSL
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			System.Windows.Browser.HtmlPage.Plugin.Focus()
			richEditControl1.ApplyTemplate()
			Dispatcher.BeginInvoke(Function() AnonymousMethod1())
		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			richEditControl1.KeyCodeConverter.Focus()
			Return True
		End Function

		Private Sub richEditControl_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim richEditControl As RichEditControl = CType(sender, RichEditControl)

			richEditControl1.BarManager = Nothing
			richEditControl2.BarManager = Nothing
			richEditControl.BarManager = barManager1
			richEditControlProvider1.RichEditControl = richEditControl
		End Sub
	End Class
End Namespace
