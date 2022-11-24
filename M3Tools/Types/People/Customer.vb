﻿Option Strict On

Namespace Types
    Public Class Customer
        Inherits Person
		'Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
		Private __joined As Date

		Public Property PhoneNumber As String
		Public Property Address As Address
		Public Property Joined As Object
			Get
				If __joined.Year < 1950 OrElse IsNothing(__joined) Then
					Return Nothing
				End If

				Return __joined
			End Get
			Set(value As Object)
				Try
					__joined = CDate(value)
				Catch ex As Exception
					__joined = Nothing
				End Try
			End Set
		End Property

		Public Sub New()
			Me.New(-1, "John", "Doe", "123 Main St", "City", "ST", "12345", "123-456-7890", "johndoe@domain.ext")
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional join As Date = Nothing)
			Me.New(id, $"{fName} {lName}", Address.Parse(street, city, state, zip), phone, email, join)
		End Sub

		Public Sub New(id As Integer, name As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional join As Date = Nothing)
			Me.New(id, name, Address.parse(street, city, state, zip), phone, email, join)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, address As Address, phone As String, email As String, Optional join As Date = Nothing)
			Me.New(id, $"{fName} {lName}", address, phone, email, join)
		End Sub

		Public Sub New(id As Integer, name As String, address As Address, phone As String, email As String, join As Date)
			MyBase.New(id, name, email)
			PhoneNumber = phone
			Me.Address = address
			Joined = join
		End Sub



		Shared Function Parse(ParamArray arr As Object()) As Customer
			' TODO: Make this way better
			If Not arr.Any() Then
				Return Nothing
			End If

			Return New Customer(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)), CStr(arr(3)), CStr(arr(4)), CStr(arr(5)), CStr(arr(6)), CStr(arr(7)), CStr(arr(8)), CDate(arr(9)))
		End Function

		Public Overrides Function ToString() As String
			'ID) Name (Email)
			'Street
			'City, ST ZipCode
			'Phone Number
			Return $"{Id}) {Name} ({Email}){vbCrLf}
					{vbTab}{Address}{vbCrLf}
					{vbTab}{PhoneNumber}"
		End Function
	End Class
End Namespace
