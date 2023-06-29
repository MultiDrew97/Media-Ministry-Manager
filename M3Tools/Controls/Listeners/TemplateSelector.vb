﻿Imports System.ComponentModel
Imports System.Windows.Forms

Public Class TemplateSelector
	' TODO: Allow to add more templates later

	'<RefreshProperties(RefreshProperties.Repaint)>
	'<Category("Data")>
	'<DesignOnly(True)>
	'<AttributeProvider(GetType(IListSource))>
	'<EditorBrowsable(EditorBrowsableState.Always)>
	'<Browsable(True)>
	'Public Property DataSource As BindingSource
	'	Get
	'		Return bsTemplates
	'	End Get
	'	Set(value As BindingSource)
	'		bsTemplates = value
	'	End Set
	'End Property

	'<Category("Data")>
	'<DesignOnly(True)>
	'<RefreshProperties(RefreshProperties.Repaint)>
	'<EditorBrowsable(EditorBrowsableState.Always)>
	'<Browsable(True)>
	'<AttributeProvider(GetType(Types.Template))>
	'Public Property DisplayMember As String
	'	Get
	'		Return cbx_TemplateSelection.DisplayMember
	'	End Get
	'	Set(value As String)
	'		cbx_TemplateSelection.DisplayMember = value
	'	End Set
	'End Property

	'<Category("Data")>
	'<DesignOnly(True)>
	'<RefreshProperties(RefreshProperties.Repaint)>
	'<EditorBrowsable(EditorBrowsableState.Always)>
	'<Browsable(True)>
	'<AttributeProvider(GetType(Types.Template))>
	'Public Property ValueMember As String
	'	Get
	'		Return cbx_TemplateSelection.ValueMember
	'	End Get
	'	Set(value As String)
	'		cbx_TemplateSelection.ValueMember = value
	'	End Set
	'End Property

	Private ReadOnly Property SelectedTemplate As Types.Template
		Get
			Return CType(cbx_TemplateSelection.SelectedItem, Types.Template)
		End Get
	End Property

	<[ReadOnly](True)>
	Public ReadOnly Property TemplateName As String
		Get
			Return cbx_TemplateSelection.SelectedText
		End Get
	End Property

	<[ReadOnly](True)>
	Public ReadOnly Property TemplateValue As String
		Get
			Return CStr(cbx_TemplateSelection.SelectedValue)
		End Get
	End Property

	Public ReadOnly Property TemplateSubject As String
		Get
			Return If(SelectedTemplate?.Subject, "")
		End Get
	End Property

	Sub Reload()
		cbx_TemplateSelection.SelectedIndex = -1
	End Sub

	Private Sub TemplateSelectionChanged(sender As Object, e As EventArgs) Handles cbx_TemplateSelection.SelectedIndexChanged
		If cbx_TemplateSelection.SelectedIndex < 0 Then
			cbx_TemplateSelection.Text = "Select Template..."
			Return
		End If

		wb_TemplateDisplay.DocumentText = CStr(cbx_TemplateSelection.SelectedValue)
	End Sub

	Private Sub TemplateListUpdated(sender As Object, e As ListChangedEventArgs) Handles bsTemplates.ListChanged
		If Not e.ListChangedType = ListChangedType.ItemAdded Then
			Return
		End If

		'bsTemplates.ResetBindings(False)
	End Sub

	' TODO: Add this to other controls and dialogs to move data handling to main app instead of tools themselves
	Public Sub AddTemplate(template As Types.Template)
		bsTemplates.Add(template)
	End Sub

	Public Sub AddRange(templates As Types.TemplateList)
		AddRange(templates.ToArray())
	End Sub

	Public Sub AddRange(templates As Types.Template())
		For Each template In templates
			AddTemplate(template)
		Next
	End Sub

	Public Sub Clear()
		bsTemplates.Clear()
	End Sub

	Public Sub RemoveTemplate(template As Types.Template)
		bsTemplates.Remove(template)
	End Sub

	Public Sub RemoveTemplate(index As Integer)
		bsTemplates.RemoveAt(index)
	End Sub
End Class
