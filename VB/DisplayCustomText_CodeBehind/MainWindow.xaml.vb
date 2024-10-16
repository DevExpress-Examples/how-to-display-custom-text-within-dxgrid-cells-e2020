Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace DisplayCustomText_CodeBehind

    Public Class Invoice

        Public Property ID As Integer

        Public Property ProductName As String

        Public Property Price As Double

        Public Property ShippingDate As Date

        Public Property Discount As Double

        Public Property IsShipped As Boolean
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl1.ItemsSource = New List(Of Invoice)(GetData())
        End Sub

        Private Sub gridControl1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As CustomColumnDisplayTextEventArgs)
            If Not e.Column.Equals(Me.columnProductName) OrElse e.ListSourceIndex < 0 Then Return
            If CDbl(Me.gridControl1.GetCellValue(e.RowHandle, "Discount")) > 20 Then e.DisplayText =(CStr(e.Value)) & " (SALE)"
        End Sub

        Private Iterator Function GetData() As IEnumerable(Of Invoice)
            Yield New Invoice() With {.ID = 0, .ProductName = "Tofu", .Price = 235.54, .Discount = 9.4, .ShippingDate = New DateTime(2020, 3, 12), .IsShipped = False}
            Yield New Invoice() With {.ID = 1, .ProductName = "Ravioli Angelo", .Price = 178.45, .Discount = 6.1, .ShippingDate = New DateTime(2020, 2, 9), .IsShipped = True}
            Yield New Invoice() With {.ID = 2, .ProductName = "Geitost", .Price = 89.98, .Discount = 5.4, .ShippingDate = New DateTime(2020, 4, 1), .IsShipped = False}
            Yield New Invoice() With {.ID = 3, .ProductName = "Chang", .Price = 189.33, .Discount = 18.2, .ShippingDate = New DateTime(2020, 5, 23), .IsShipped = True}
            Yield New Invoice() With {.ID = 4, .ProductName = "Inlagd Sill", .Price = 509.10, .Discount = 22.2, .ShippingDate = New DateTime(2020, 6, 30), .IsShipped = False}
            Yield New Invoice() With {.ID = 5, .ProductName = "Alice Mutton", .Price = 791.18, .Discount = 24.4, .ShippingDate = New DateTime(2020, 5, 7), .IsShipped = True}
        End Function
    End Class
End Namespace
