﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_EmailListeners
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmailListeners))
		Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
		Me.dlc_Listeners = New SPPBC.M3Tools.DisplayListenersCtrl()
		Me.SuspendLayout()
		'
		'mms_Main
		'
		Me.mms_Main.Location = New System.Drawing.Point(0, 0)
		Me.mms_Main.Name = "mms_Main"
		Me.mms_Main.Size = New System.Drawing.Size(733, 24)
		Me.mms_Main.TabIndex = 0
		Me.mms_Main.Text = "MainMenuStrip1"
		'
		'dlc_Listeners
		'
		Me.dlc_Listeners.AllowColumnReordering = True
		Me.dlc_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dlc_Listeners.Filter = Nothing
		Me.dlc_Listeners.Location = New System.Drawing.Point(0, 24)
		Me.dlc_Listeners.Name = "dlc_Listeners"
		Me.dlc_Listeners.Size = New System.Drawing.Size(733, 350)
		Me.dlc_Listeners.TabIndex = 1
		'
		'frm_EmailListeners
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(733, 374)
		Me.Controls.Add(Me.dlc_Listeners)
		Me.Controls.Add(Me.mms_Main)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mms_Main
		Me.Name = "frm_EmailListeners"
		Me.Text = "Media Ministry Manager"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
	Friend WithEvents dlc_Listeners As SPPBC.M3Tools.DisplayListenersCtrl
End Class
