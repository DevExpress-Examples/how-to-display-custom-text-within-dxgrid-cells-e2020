Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace DXExample.DemoData
	Public Class Invoice
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateProductName As String
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property
		Private privatePrice As Double
		Public Property Price() As Double
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Double)
				privatePrice = value
			End Set
		End Property
		Private privateShippingDate As DateTime
		Public Property ShippingDate() As DateTime
			Get
				Return privateShippingDate
			End Get
			Set(ByVal value As DateTime)
				privateShippingDate = value
			End Set
		End Property
		Private privateDiscount As Double
		Public Property Discount() As Double
			Get
				Return privateDiscount
			End Get
			Set(ByVal value As Double)
				privateDiscount = value
			End Set
		End Property
		Private privateIsShipped As Boolean
		Public Property IsShipped() As Boolean
			Get
				Return privateIsShipped
			End Get
			Set(ByVal value As Boolean)
				privateIsShipped = value
			End Set
		End Property
		Public Shared Function GetData() As List(Of Invoice)
			Dim data As New List(Of Invoice)()

			data.Add(New Invoice() With {.ID = 0, .ProductName = "Tofu", .Price = 235.54, .Discount = 9.4, .ShippingDate = New DateTime(2010, 3, 12), .IsShipped = False})
			data.Add(New Invoice() With {.ID = 1, .ProductName = "Ravioli Angelo", .Price = 178.45, .Discount = 6.1, .ShippingDate = New DateTime(2010, 2, 9), .IsShipped = True})
			data.Add(New Invoice() With {.ID = 2, .ProductName = "Geitost", .Price = 89.98, .Discount = 5.4, .ShippingDate = New DateTime(2010, 4, 1), .IsShipped = False})
			data.Add(New Invoice() With {.ID = 3, .ProductName = "Chang", .Price = 189.33, .Discount = 18.2, .ShippingDate = New DateTime(2010, 5, 23), .IsShipped = True})
			data.Add(New Invoice() With {.ID = 4, .ProductName = "Inlagd Sill", .Price = 509.10, .Discount = 22.2, .ShippingDate = New DateTime(2010, 6, 30), .IsShipped = False})
			data.Add(New Invoice() With {.ID = 5, .ProductName = "Alice Mutton", .Price = 791.18, .Discount = 24.4, .ShippingDate = New DateTime(2010, 5, 7), .IsShipped = True})

			Return data
		End Function
	End Class
End Namespace
