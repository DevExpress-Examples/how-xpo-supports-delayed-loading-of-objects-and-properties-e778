Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Namespace DelayedProperties
	Friend Class MyTraceListner
		Inherits System.Diagnostics.TraceListener
		Private outputWindow As TextBox
		Public Sub New(ByVal outputWindow As TextBox)
			Me.outputWindow = outputWindow
		End Sub
		Public Overrides Overloads Sub Write(ByVal message As String)
			outputWindow.AppendText(message)
		End Sub
		Public Overrides Overloads Sub WriteLine(ByVal message As String)
			outputWindow.AppendText(message & Constants.vbCrLf)
		End Sub
	End Class
End Namespace
