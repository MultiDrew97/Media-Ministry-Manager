﻿Option Strict On
Namespace Types
    Public Class Person
        Public Property FirstName() As String
        Public Property LastName() As String

        Public ReadOnly Property Name() As String
            Get
                Return Me.FirstName & " " & Me.LastName
            End Get
        End Property

        Public Sub New(firstName As String, lastName As String)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub
    End Class
End Namespace
