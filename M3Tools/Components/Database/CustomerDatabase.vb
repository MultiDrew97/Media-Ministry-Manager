﻿Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MathNet.Numerics.LinearAlgebra.Factorization
Imports SPPBC.M3Tools.Events
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class CustomerDatabase
		'The username to use for the database connection
		<EditorBrowsable()>
		<SettingsBindable(True)>
		<Description("The username to use for the database connection")>
		Public Property Username As String
			Get
				Return dbConnection.Username
			End Get
			Set(value As String)
				dbConnection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return dbConnection.Password
				'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
			End Get
			Set(value As String)
				'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
				'Console.WriteLine(temp)
				'__connectionString.Password = temp
				dbConnection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<SettingsBindable(True)>
		<Description("The initial catalog to use for the database connection")>
		Public Property BaseUrl As String
			Get
				Return dbConnection.BaseUrl
			End Get
			Set(value As String)
				dbConnection.BaseUrl = value
			End Set
		End Property

		Public Sub AddCustomer(customer As Customer)
			AddCustomer(customer.FirstName, customer.LastName, customer.Address, customer.PhoneNumber, customer.Email)
		End Sub

		Public Sub AddCustomer(
				   fName As String, lName As String,
				   Optional address As Address = Nothing,
				   Optional phone As String = Nothing, Optional email As String = Nothing)

			'used string.format due to enormous query strings and concatination, allowing for easy expansion
			'SELECT CONVERT(VARCHAR(10), getdate(), 101) is a query found online that gets just the date of getdate().
			'source = https://tableplus.io/blog/2018/09/ms-sql-server-how-to-get-date-only-from-datetime-value.html

			'Style	How it’s displayed
			'101    mm/dd/yyyy
			'102    yyyy.mm.dd
			'103    dd/mm/yyyy
			'104    dd.mm.yyyy
			'105    dd-mm-yyyy
			'110    mm-dd-yyyy
			'111    yyyy/mm/dd
			'106    dd mon yyyy
			'107    Mon dd, yyyy

			'date string that holds the command to get the date for when the person joined
			'Dim dateString = "SELECT CONVERT(VARCHAR(10), GETDATE(), 111)"
			AddCustomer(fName, lName, address?.Street, address?.City, address?.State, address?.ZipCode, phone, email)
		End Sub

		Public Sub AddCustomer(
				   fName As String, lName As String,
				   Optional addrStreet As String = Nothing, Optional addrCity As String = Nothing,
				   Optional addrState As String = Nothing, Optional addrZip As String = Nothing,
				   Optional phone As String = Nothing, Optional email As String = Nothing)
			AddCustomer(
				New SqlParameter("FirstName", fName), New SqlParameter("LastName", lName),
				New SqlParameter("Street", addrStreet), New SqlParameter("City", addrCity),
				New SqlParameter("State", addrState), New SqlParameter("Zip", addrZip),
				New SqlParameter("Phone", phone), New SqlParameter("Email", email))
		End Sub

		Private Sub AddCustomer(ParamArray params As SqlParameter())
			Throw New NotImplementedException("AddCustomer")
		End Sub

		Public Function GetCustomers() As CustomerCollection
			Return dbConnection.Consume(Of CustomerCollection)(M3API.Method.Get, $"/customers").Result
		End Function

		Public Function GetCustomer(customerID As Integer) As Customer
			If Not Utils.ValidID(customerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Return dbConnection.Consume(Of Customer)(M3API.Method.Get, $"/customers/{customerID}").Result
		End Function

		Public Sub UpdateCustomer(customerID As Integer, fName As String, lName As String, street As String, city As String, state As String, zipCode As String, phone As String, email As String)
			UpdateCustomer(customerID, fName, lName, Address.Parse(street, city, state, zipCode), phone, email)
		End Sub

		Public Sub UpdateCustomer(customerID As Integer, fName As String, lName As String, addr As Address, phone As String, email As String)
			UpdateCustomer(customerID, $"{fName} {lName}", addr, phone, email)
		End Sub

		Public Sub UpdateCustomer(customerID As Integer, name As String, addr As Address, phone As String, email As String)
			UpdateCustomer(New Customer(customerID, name, addr, phone, email))
		End Sub

		Public Sub UpdateCustomer(customer As Customer)
			UpdateCustomer(
				New SqlParameter("CustomerID", customer.Id),
				New SqlParameter("FirstName", customer.FirstName),
				New SqlParameter("LastName", customer.LastName),
				New SqlParameter("Street", customer.Address?.Street),
				New SqlParameter("City", customer.Address?.City),
				New SqlParameter("State", customer.Address?.State),
				New SqlParameter("ZipCode", customer.Address?.ZipCode),
				New SqlParameter("Phone", customer.PhoneNumber),
				New SqlParameter("Email", customer.Email)
			)
		End Sub

		Public Sub UpdateCustomer(ParamArray params As SqlParameter())
			Throw New NotImplementedException("UpdateCustomer")
		End Sub

		Public Sub RemoveCustomer(customerID As Integer)
			Throw New NotImplementedException("RemoveCustomer")
		End Sub

		Private Structure ColumnNames
			Shared ReadOnly Property ID As String = "CustomerID"
			Shared ReadOnly Property FirstName As String = "FirstName"
			Shared ReadOnly Property LastName As String = "LastName"
			Shared ReadOnly Property Street As String = "Street"
			Shared ReadOnly Property City As String = "City"
			Shared ReadOnly Property State As String = "State"
			Shared ReadOnly Property Zip As String = "ZipCode"
			Shared ReadOnly Property Email As String = "Email"
			Shared ReadOnly Property Phone As String = "PhoneNumber"
			Shared ReadOnly Property Joined As String = "JoinDate"

			Shared ReadOnly Property Message As String = "Message"
		End Structure
	End Class
End Namespace