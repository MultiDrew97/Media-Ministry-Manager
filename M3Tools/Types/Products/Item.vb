﻿Option Strict On
Namespace Types
	Public Class Item
		Inherits DBEntry

		Public Property Name As String
		Public Property Stock As Integer
		Public Property Price As Double
		Public Property Available As Boolean

		Public Sub New()
			Me.New(1, "New Product", 0, 0, True)
		End Sub

		Public Sub New(id As Integer, name As String)
			Me.New(id, name, 0, 0, True)
		End Sub

		Public Sub New(id As Integer, name As String, stock As Integer, price As Double, available As Boolean)
			Me.Id = id
			Me.Name = name
			Me.Stock = stock
			Me.Price = price
			Me.Available = available
		End Sub

		Public Function Display() As String
			Return $"{Id}) {Name} ({Price}) {If(Available, "Available", "Not Available")}"
		End Function

		Public Overrides Function ToString() As String
			Return String.Join(My.Settings.ObjectDelimiter, Id, Name, Stock, Price, If(Available, "Available", "Not Available"))
		End Function
	End Class
End Namespace