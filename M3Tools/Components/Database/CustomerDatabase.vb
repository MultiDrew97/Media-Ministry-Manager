﻿Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class CustomerDatabase
		Private ReadOnly tableName As String = "Customers"
		'The username to use for the database connection
		<EditorBrowsable()>
		<SettingsBindable(True)>
		<Description("The username to use for the database connection")>
		Public Property Username As String
			Get
				Return db_Connection.Username
			End Get
			Set(value As String)
				db_Connection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return db_Connection.Password
				'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
			End Get
			Set(value As String)
				'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
				'Console.WriteLine(temp)
				'__connectionString.Password = temp
				db_Connection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<SettingsBindable(True)>
		<Description("The initial catalog to use for the database connection")>
		Public Property InitialCatalog As String
			Get
				Return db_Connection.InitialCatalog
			End Get
			Set(value As String)
				db_Connection.InitialCatalog = value
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
			AddCustomer(
				New SqlParameter("FirstName", fName), New SqlParameter("LastName", lName),
				New SqlParameter("Street", addrStreet), New SqlParameter("City", addrCity),
				New SqlParameter("State", addrState), New SqlParameter("Zip", addrZip),
				New SqlParameter("Phone", phone), New SqlParameter("Email", email))
		End Sub

		Private Sub AddCustomer(ParamArray params As SqlParameter())
			Using _conn = db_Connection.Connect()
				_conn.CommandType = CommandType.StoredProcedure
				_conn.CommandText = $"[{My.Settings.Schema}].[sp_AddCustomer]"

				_conn.Parameters.AddRange(params)

				_conn.ExecuteNonQuery()
			End Using
		End Sub

		Public Function GetCustomers() As CustomerCollection
			Dim customers As New CustomerCollection()

			Using _conn = db_Connection.Connect
				_conn.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}]"

				Using reader = _conn.ExecuteReader

					Do While reader.Read()
						customers.Add(New Customer(
									CInt(reader("CustomerID")),
									CStr(reader("FirstName")),
									CStr(reader("LastName")),
									Address.Parse(reader("Street"), reader("City"), reader("State"), reader("ZipCode")),
									TryCast(reader("PhoneNumber"), String),
									TryCast(reader("Email"), String),
									CDate(reader("JoinDate"))
								  ))
					Loop


				End Using
			End Using

			Return customers
		End Function

		Public Function GetCustomer(customerID As Integer) As Customer
			If Not Utils.ValidID(customerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Using _conn = db_Connection.Connect()
				_conn.Parameters.AddWithValue("CustomerID", customerID)

				_conn.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] WHERE CustomerID = @CustomerID"

				Using reader = _conn.ExecuteReader()
					If Not reader.Read() Then
						Throw New Exceptions.CustomerNotFoundException()
					End If

					Return New Customer(
							customerID, CStr(reader("FirstName")), CStr(reader("LastName")),
							New Address(
								TryCast(reader("Street"), String), TryCast(reader("City"), String), TryCast(reader("State"), String), TryCast(reader("ZipCode"), String)
								),
							TryCast(reader("PhoneNumber"), String), TryCast(reader("Email"), String), CDate(reader("JoinDate"))
						)

				End Using
			End Using
		End Function

		Public Sub UpdateCustomer(customerID As Integer, fName As String, lName As String, street As String, city As String, state As String, zipCode As String, phone As String, email As String)
			'If Not Utils.ValidID(customerID) Then
			'	Throw New ArgumentException($"ID Values must be greater than or equal to {My.Settings.MinID}")
			'End If

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
			Using cmd = db_Connection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_UpdateCustomer]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub RemoveCustomer(customerID As Integer)
			If Not Utils.ValidID(customerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Using _conn = db_Connection.Connect()
				_conn.Parameters.AddWithValue("CustomerID", customerID)

				_conn.CommandText = "DELETE FROM CUSTOMERS WHERE CustomerID = @CustomerID"

				_conn.ExecuteNonQuery()
			End Using
		End Sub
	End Class
End Namespace