﻿Public Class StateSelectorField
    Public Property StateCode As String
        Get
			Return cbx_States.Text
		End Get
        Set(value As String)
			cbx_States.Text = value?.Substring(0, 2)
		End Set
    End Property

    Private Sub cbx_States_TextChanged(sender As Object, e As EventArgs) Handles cbx_States.TextChanged

    End Sub
End Class
