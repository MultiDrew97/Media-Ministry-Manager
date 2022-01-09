﻿Imports System.Collections.ObjectModel
Imports System.Windows.Forms

Public Class CreateFolderDialog
	Private __folderName As String
	Private ReadOnly __parents As New Collection(Of String)
	Public Property FolderName As String
		Get
			Return __folderName
		End Get
		Set(value As String)
			__folderName = value
		End Set
	End Property

	Public ReadOnly Property Parents As IList(Of String)
		Get
			Return If(__parents.Count = 0, Nothing, __parents)
		End Get
	End Property

	Sub New(username As String)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		UseWaitCursor = True
		LoadDialog(username)
	End Sub

	Private Sub Create(sender As Object, e As EventArgs) Handles btn_Create.Click
		bw_GatherInfo.RunWorkerAsync(dt_DriveHeirarchy.SelectedNode)
		Try
			gdt_GDrive.CreateFolder(FolderName, Parents)
			DialogResult = DialogResult.OK
			Close()
		Catch ex As Exceptions.FolderException
			MessageBox.Show(Me, ex.Message, "New Folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		DialogResult = DialogResult.Cancel
		Close()
	End Sub

	Private Sub FolderNameTextChanged(sender As Object, e As EventArgs) Handles ip_FolderName.TextChanged
		FolderName = ip_FolderName.Text
	End Sub

	Private Async Sub LoadDialog(username As String)
		Await gdt_GDrive.Authorize(username)

		dt_DriveHeirarchy.RefreshTree()

		UseWaitCursor = False
	End Sub

	Private Sub GatherInfo(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_GatherInfo.DoWork
		__parents.Clear()
		Dim nodeSelected = CType(e.Argument, TreeNode)

		If nodeSelected IsNot Nothing Then
			' A node is selected
			If Not nodeSelected.Name.ToLower.Equals("main") Then
				' Selected node was not the My Drive Folder node
				__parents.Add(nodeSelected.Name)
			End If
		Else
			MessageBox.Show("You must select a folder for the new one to go in.", "New Folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub
End Class