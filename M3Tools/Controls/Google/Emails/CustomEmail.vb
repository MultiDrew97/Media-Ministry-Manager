﻿Imports System.Windows.Forms

Public Class CustomEmail
	ReadOnly placeholders As String() = {"Subject...", "Email Body..."}
	Private Structure Shortcuts
		Shared Bold As String = "Bold"
		Shared Underline As String = "Underline"
		Shared Italics As String = "Italics"
	End Structure

	Public Property Subject As String
		Get
			Return txt_Subject.Text
		End Get
		Set(value As String)
			txt_Subject.Text = value
		End Set
	End Property

	Public Property Body As String
		Get
			Return txt_Body.Text
		End Get
		Set(value As String)
			txt_Body.Text = value
		End Set
	End Property

	Public ReadOnly Property RichTextBody As String
		Get
			Return rtb_Body.Rtf
		End Get
	End Property

	Private Sub ChangeFont(sender As Object, e As EventArgs) Handles btn_ChangeFont.Click
		If fd_Font.ShowDialog = DialogResult.OK Then
			rtb_Body.Font = fd_Font.Font
			btn_Bold.Checked = fd_Font.Font.Bold
			btn_Italics.Checked = fd_Font.Font.Italic
			btn_Underline.Checked = fd_Font.Font.Underline
		End If
	End Sub

	Private Sub BoldText(sender As Object, e As EventArgs) Handles btn_Bold.Click, Bold.Click
		MessageBox.Show("Under Construction", "Text formatting is still under construction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Return
		Dim fontStyle = GetCurrentFontStyle()

		If Not rtb_Body.SelectionFont.Bold Then
			fontStyle += Drawing.FontStyle.Bold
		Else
			fontStyle -= Drawing.FontStyle.Bold
		End If

		rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, CType(fontStyle, Drawing.FontStyle))
	End Sub

	Private Sub BoldShortcut(sender As Object, e As EventArgs) Handles Bold.Click, Underline.Click, Italics.Click
		Dim name = CType(sender, ToolStripMenuItem).Name

		Select Case name
			Case Shortcuts.Bold
				btn_Bold.Checked = Not btn_Bold.Checked
			Case Shortcuts.Underline
				btn_Underline.Checked = Not btn_Underline.Checked
			Case Shortcuts.Italics
				btn_Italics.Checked = Not btn_Italics.Checked
		End Select
	End Sub

	Private Sub UnderlineText(sender As Object, e As EventArgs) Handles btn_Underline.Click, Underline.Click
		MessageBox.Show("Under Construction", "Text formatting is still under construction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Return
		Dim fontStyle = GetCurrentFontStyle()

		If Not rtb_Body.SelectionFont.Underline Then
			fontStyle += Drawing.FontStyle.Underline
		Else
			fontStyle -= Drawing.FontStyle.Underline
		End If

		rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, CType(fontStyle, Drawing.FontStyle))

	End Sub

	Private Sub ItalicizeText(sender As Object, e As EventArgs) Handles btn_Italics.Click, Italics.Click
		MessageBox.Show("Under Construction", "Text formatting is still under construction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Return
		Dim fontStyle = GetCurrentFontStyle()

		If Not rtb_Body.SelectionFont.Italic Then
			fontStyle += Drawing.FontStyle.Italic
		Else
			fontStyle -= Drawing.FontStyle.Italic
		End If

		rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, CType(fontStyle, Drawing.FontStyle))
	End Sub

	Private Function GetCurrentFontStyle() As Integer
		'Dim fontStyle As Integer

		Return If(rtb_Body.SelectionFont.Bold, Drawing.FontStyle.Bold, 0) +
				If(rtb_Body.SelectionFont.Underline, Drawing.FontStyle.Underline, 0) +
				If(rtb_Body.SelectionFont.Italic, Drawing.FontStyle.Italic, 0)

		'If rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Italic And rtb_Body.SelectionFont.Bold Then
		'	fontStyle = Drawing.FontStyle.Italic + Drawing.FontStyle.Underline + Drawing.FontStyle.Bold
		'ElseIf rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Italic Then
		'	fontStyle = Drawing.FontStyle.Underline + Drawing.FontStyle.Italic
		'ElseIf rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Bold Then
		'	fontStyle = Drawing.FontStyle.Underline + Drawing.FontStyle.Bold
		'ElseIf rtb_Body.SelectionFont.Italic And rtb_Body.SelectionFont.Bold Then
		'	fontStyle = Drawing.FontStyle.Italic + Drawing.FontStyle.Bold
		'ElseIf rtb_Body.SelectionFont.Underline Then
		'	fontStyle = Drawing.FontStyle.Underline
		'ElseIf rtb_Body.SelectionFont.Italic Then
		'	fontStyle = Drawing.FontStyle.Italic
		'ElseIf rtb_Body.SelectionFont.Bold Then
		'	fontStyle = Drawing.FontStyle.Bold
		'Else
		'	fontStyle = 0
		'End If

		'Return fontStyle
	End Function

	'Private Sub BodyChanged(sender As Object, e As EventArgs) Handles txt_Body.TextChanged
	'	If txt_Body.Text <> "" Or txt_Body.Text = placeholder Then
	'		Return
	'	End If

	'	'rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, Drawing.FontStyle.Regular)

	'	ResetFontButtons()
	'	txt_Body.Text = placeholder
	'End Sub

	'Private Sub ResetFontButtons()
	'	btn_Bold.Checked = False
	'	btn_Italics.Checked = False
	'	btn_Underline.Checked = False
	'End Sub

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		rtb_Body.SelectionFont = fd_Font.Font
		btn_Bold.Checked = fd_Font.Font.Bold
		btn_Italics.Checked = fd_Font.Font.Italic
		btn_Underline.Checked = fd_Font.Font.Underline
		txt_Subject.Text = placeholders(0)
		txt_Body.Text = placeholders(1)
	End Sub

	Private Sub TextGotFocus(sender As Object, e As EventArgs) Handles txt_Body.GotFocus, txt_Subject.GotFocus
		Dim txtBox = CType(sender, TextBox)
		Dim value As String = If(txtBox.Name = "txt_Subject", placeholders(0), placeholders(1))

		If txtBox.Text <> value Then
			Return
		End If

		txtBox.Text = ""
		txtBox.ForeColor = Drawing.SystemColors.WindowText
	End Sub

	Private Sub TextLostFocus(sender As Object, e As EventArgs) Handles txt_Body.LostFocus, txt_Subject.LostFocus
		Dim txtBox = CType(sender, TextBox)
		Dim value As String = If(txtBox.Name = "txt_Subject", placeholders(0), placeholders(1))

		If txtBox.Text <> "" Then
			Return
		End If

		txtBox.Text = value
		txtBox.ForeColor = Drawing.SystemColors.ControlDark
	End Sub
End Class
