Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DXExample.DemoData

Namespace DXGrid_DisplayCustomText
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = Invoice.GetData()
		End Sub
		Private Sub gridControl1_CustomColumnDisplayText( _
				ByVal sender As Object, _
				ByVal e As CustomColumnDisplayTextEventArgs)
			If Not e.Column Is columnProductName Then
				Return
			End If
			If CDbl(gridControl1.GetCellValue(e.RowHandle, "Discount")) > 20 Then
				e.DisplayText = (CStr(e.Value)) & " (SALE)"
			End If
		End Sub
	End Class
End Namespace
