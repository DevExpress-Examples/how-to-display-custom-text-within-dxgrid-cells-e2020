Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace DXGrid_DisplayCustomText_MVVM

    Public Class Invoice

        Public Property ID As Integer

        Public Property ProductName As String

        Public Property Price As Double

        Public Property ShippingDate As Date

        Public Property Discount As Double

        Public Property IsShipped As Boolean
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public ReadOnly Property InvoiceList As ObservableCollection(Of Invoice)

        Public Sub New()
            InvoiceList = New ObservableCollection(Of Invoice)(GetData())
        End Sub

        Private Iterator Function GetData() As IEnumerable(Of Invoice)
            Yield New Invoice() With {.ID = 0, .ProductName = "Tofu", .Price = 235.54, .Discount = 9.4, .ShippingDate = New DateTime(2020, 3, 12), .IsShipped = False}
            Yield New Invoice() With {.ID = 1, .ProductName = "Ravioli Angelo", .Price = 178.45, .Discount = 6.1, .ShippingDate = New DateTime(2020, 2, 9), .IsShipped = True}
            Yield New Invoice() With {.ID = 2, .ProductName = "Geitost", .Price = 89.98, .Discount = 5.4, .ShippingDate = New DateTime(2020, 4, 1), .IsShipped = False}
            Yield New Invoice() With {.ID = 3, .ProductName = "Chang", .Price = 189.33, .Discount = 18.2, .ShippingDate = New DateTime(2020, 5, 23), .IsShipped = True}
            Yield New Invoice() With {.ID = 4, .ProductName = "Inlagd Sill", .Price = 509.10, .Discount = 22.2, .ShippingDate = New DateTime(2020, 6, 30), .IsShipped = False}
            Yield New Invoice() With {.ID = 5, .ProductName = "Alice Mutton", .Price = 791.18, .Discount = 24.4, .ShippingDate = New DateTime(2020, 5, 7), .IsShipped = True}
        End Function

        <Command>
        Public Sub CustomColumnDisplayText(ByVal args As ColumnDisplayTextArgs)
            If Not Equals(args.FieldName, NameOf(Invoice.ProductName)) OrElse args.SourceIndex < 0 Then
                Return
            End If

            If InvoiceList(args.SourceIndex).Discount > 20 Then
                args.DisplayText += " (SALE)"
            End If
        End Sub
    End Class
End Namespace
