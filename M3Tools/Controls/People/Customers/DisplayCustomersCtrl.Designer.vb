﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayCustomersCtrl
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayCustomersCtrl))
        Me.cms_Tools = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.cdg_Customers = New SPPBC.M3Tools.CustomersDataGrid()
        Me.ts_CustomerTools = New System.Windows.Forms.ToolStrip()
        Me.tbtn_AddCustomer = New System.Windows.Forms.ToolStripButton()
        Me.tbtn_Refresh = New System.Windows.Forms.ToolStripButton()
        Me.cms_Tools.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ts_CustomerTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_Tools
        '
        Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cms_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Refresh, Me.ts_Remove})
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(181, 70)
        Me.cms_Tools.Text = "Tools"
        '
        'ts_Refresh
        '
        Me.ts_Refresh.Name = "ts_Refresh"
        Me.ts_Refresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ts_Refresh.Size = New System.Drawing.Size(154, 22)
        Me.ts_Refresh.Text = "Refresh"
        '
        'ts_Remove
        '
        Me.ts_Remove.Name = "ts_Remove"
        Me.ts_Remove.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.ts_Remove.Size = New System.Drawing.Size(154, 22)
        Me.ts_Remove.Text = "Remove"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.cdg_Customers)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(748, 525)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(748, 550)
        Me.ToolStripContainer1.TabIndex = 9
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_CustomerTools)
        '
        'cdg_Customers
        '
        Me.cdg_Customers.AllowColumnReordering = True
        Me.cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cdg_Customers.Filter = Nothing
        Me.cdg_Customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdg_Customers.Location = New System.Drawing.Point(0, 0)
        Me.cdg_Customers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cdg_Customers.Name = "cdg_Customers"
        Me.cdg_Customers.Size = New System.Drawing.Size(748, 525)
        Me.cdg_Customers.TabIndex = 1
        '
        'ts_CustomerTools
        '
        Me.ts_CustomerTools.AllowItemReorder = True
        Me.ts_CustomerTools.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_CustomerTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_CustomerTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_AddCustomer})
        Me.ts_CustomerTools.Location = New System.Drawing.Point(6, 0)
        Me.ts_CustomerTools.Name = "ts_CustomerTools"
        Me.ts_CustomerTools.Size = New System.Drawing.Size(26, 25)
        Me.ts_CustomerTools.TabIndex = 8
        '
        'tbtn_AddCustomer
        '
        Me.tbtn_AddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_AddCustomer.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
        Me.tbtn_AddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_AddCustomer.Name = "tbtn_AddCustomer"
        Me.tbtn_AddCustomer.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_AddCustomer.Text = "New Customer"
        '
        'tbtn_Refresh
        '
        Me.tbtn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_Refresh.Enabled = False
        Me.tbtn_Refresh.Image = CType(resources.GetObject("tbtn_Refresh.Image"), System.Drawing.Image)
        Me.tbtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_Refresh.Name = "tbtn_Refresh"
        Me.tbtn_Refresh.Size = New System.Drawing.Size(36, 36)
        Me.tbtn_Refresh.Text = "Refresh"
        '
        'DisplayCustomersCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ContextMenuStrip = Me.cms_Tools
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DisplayCustomersCtrl"
        Me.Size = New System.Drawing.Size(748, 550)
        Me.cms_Tools.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ts_CustomerTools.ResumeLayout(False)
        Me.ts_CustomerTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cms_Tools As Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_Refresh As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Remove As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents tbtn_Refresh As Windows.Forms.ToolStripButton
    Friend WithEvents ts_CustomerTools As Windows.Forms.ToolStrip
	Friend WithEvents tbtn_AddCustomer As Windows.Forms.ToolStripButton
    Friend WithEvents cdg_Customers As CustomersDataGrid
End Class
