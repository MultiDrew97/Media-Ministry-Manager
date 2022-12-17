﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayListenersCtrl
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ListenerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EditListener = New System.Windows.Forms.DataGridViewImageColumn()
		Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
		Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
		Me.bw_LoadListeners = New System.ComponentModel.BackgroundWorker()
		Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgv_Listeners
		'
		Me.dgv_Listeners.AllowUserToAddRows = False
		Me.dgv_Listeners.AutoGenerateColumns = False
		Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ListenerName, Me.EmailDataGridViewTextBoxColumn, Me.EditListener, Me.Delete})
		Me.dgv_Listeners.DataSource = Me.bsListeners
		Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Listeners.Name = "dgv_Listeners"
		Me.dgv_Listeners.Size = New System.Drawing.Size(517, 395)
		Me.dgv_Listeners.TabIndex = 0
		'
		'IdDataGridViewTextBoxColumn
		'
		Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
		Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
		Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
		Me.IdDataGridViewTextBoxColumn.Visible = False
		'
		'ListenerName
		'
		Me.ListenerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		Me.ListenerName.DataPropertyName = "Name"
		Me.ListenerName.FillWeight = 80.0!
		Me.ListenerName.HeaderText = "Name"
		Me.ListenerName.Name = "ListenerName"
		Me.ListenerName.ToolTipText = "The listener's name"
		Me.ListenerName.Width = 60
		'
		'EmailDataGridViewTextBoxColumn
		'
		Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
		Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
		Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
		'
		'EditListener
		'
		Me.EditListener.Description = "Update a listener's info"
		Me.EditListener.HeaderText = ""
		Me.EditListener.Image = Global.SPPBC.M3Tools.My.Resources.Resources.edit
		Me.EditListener.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.EditListener.MinimumWidth = 25
		Me.EditListener.Name = "EditListener"
		Me.EditListener.ReadOnly = True
		Me.EditListener.Width = 25
		'
		'Delete
		'
		Me.Delete.Description = "Remove the listener from the database and stop sending emails"
		Me.Delete.HeaderText = ""
		Me.Delete.Image = Global.SPPBC.M3Tools.My.Resources.Resources.delete
		Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.Delete.MinimumWidth = 25
		Me.Delete.Name = "Delete"
		Me.Delete.ReadOnly = True
		Me.Delete.Width = 25
		'
		'bsListeners
		'
		Me.bsListeners.DataSource = GetType(SPPBC.M3Tools.Types.Listener)
		'
		'bw_LoadListeners
		'
		'
		'db_Listeners
		'
		Me.db_Listeners.InitialCatalog = "Media Ministry"
		Me.db_Listeners.Password = "M3AppPassword2499"
		Me.db_Listeners.Username = "M3App"
		'
		'DisplayListenersCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.dgv_Listeners)
		Me.Name = "DisplayListenersCtrl"
		Me.Size = New System.Drawing.Size(517, 395)
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents dgv_Listeners As Windows.Forms.DataGridView
    Friend WithEvents bw_LoadListeners As ComponentModel.BackgroundWorker
    Friend WithEvents bsListeners As Windows.Forms.BindingSource
    Friend WithEvents db_Listeners As Database.ListenerDatabase
	Friend WithEvents IdDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ListenerName As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EmailDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EditListener As Windows.Forms.DataGridViewImageColumn
	Friend WithEvents Delete As Windows.Forms.DataGridViewImageColumn
End Class
