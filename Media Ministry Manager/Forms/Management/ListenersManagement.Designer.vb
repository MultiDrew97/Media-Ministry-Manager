﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListenersManagement
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListenersManagement))
        Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
        Me.dlc_Listeners = New SPPBC.M3Tools.DisplayListenersCtrl()
        Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
        Me.gt_Email = New SPPBC.M3Tools.GTools.GmailTool(Me.components)
        Me.dbListeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mms_Main
        '
        Me.mms_Main.Location = New System.Drawing.Point(0, 0)
        Me.mms_Main.Name = "mms_Main"
        Me.mms_Main.Size = New System.Drawing.Size(784, 24)
        Me.mms_Main.TabIndex = 0
        Me.mms_Main.Text = "MainMenuStrip1"
        '
        'dlc_Listeners
        '
        Me.dlc_Listeners.CountTemplate = "Count: {0}"
        Me.dlc_Listeners.DataSource = Me.bsListeners
        Me.dlc_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlc_Listeners.Location = New System.Drawing.Point(0, 24)
        Me.dlc_Listeners.Name = "dlc_Listeners"
        Me.dlc_Listeners.Size = New System.Drawing.Size(784, 437)
        Me.dlc_Listeners.TabIndex = 1
        '
        'bsListeners
        '
        Me.bsListeners.DataSource = GetType(SPPBC.M3Tools.Types.ListenerCollection)
        Me.bsListeners.Filter = ""
		'
		'gt_Email
		'
		Me.gt_Email.Username = Global.MediaMinistry.My.MySettings.Default.Username
		'
		'dbListeners
		'
		Me.dbListeners.InitialCatalog = "Media Ministry"
        Me.dbListeners.Password = "M3AppPassword2499"
        Me.dbListeners.Username = "M3App"
        '
        'ListenersManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.dlc_Listeners)
        Me.Controls.Add(Me.mms_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mms_Main
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "ListenersManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
	Friend WithEvents dlc_Listeners As SPPBC.M3Tools.DisplayListenersCtrl
	Friend WithEvents gt_Email As SPPBC.M3Tools.GTools.GmailTool
	Friend WithEvents bsListeners As BindingSource
	Friend WithEvents dbListeners As SPPBC.M3Tools.Database.ListenerDatabase
End Class
