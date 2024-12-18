﻿Namespace Types
	Public Class Auth
		<Text.Json.Serialization.JsonPropertyName("username")>
		Public Property Username As String

		'<Text.Json.Serialization.JsonIgnore>
		<Text.Json.Serialization.JsonPropertyName("password")>
		Public Property Password As String

		<Text.Json.Serialization.JsonPropertyName("salt")>
		Public Property Salt As Guid

		<Text.Json.Serialization.JsonPropertyName("role")>
		Public Property Role As AccountRole

		Public Sub New()
			Me.New("JohnDoe123", "WelcomeJohnDoe123!")
		End Sub

		Public Sub New(Optional username As String = "JohnDoe123", Optional password As String = Nothing, Optional salt As Guid = Nothing, Optional role As AccountRole = AccountRole.User)
			Me.Username = username
			Me.Password = If(password IsNot Nothing, password.ToBase64String(), Nothing)
			Me.Salt = If(Not IsNothing(salt), salt, Guid.Empty)
			Me.Role = role
			'Me.New(username, Text.Encoding.UTF8.GetBytes(If(password, $"Welcome{username}!")), If(salt = Nothing, Guid.Empty, salt), role)
		End Sub

		'Public Sub New(username As String, password As Byte(), Optional salt As Guid = Nothing, Optional role As AccountRole = AccountRole.User)
		'	Me.Username = username
		'	Me.Password = password
		'	Me.Salt = salt
		'	Me.Role = role
		'End Sub
	End Class
End Namespace
