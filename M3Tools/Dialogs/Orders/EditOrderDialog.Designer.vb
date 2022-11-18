﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditOrderDialog
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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.OK_Button = New System.Windows.Forms.Button()
		Me.Cancel_Button = New System.Windows.Forms.Button()
		Me.bw_LoadOrder = New System.ComponentModel.BackgroundWorker()
		Me.db_Orders = New SPPBC.M3Tools.Database.OrdersDatabase(Me.components)
		Me.pcb_Items = New SPPBC.M3Tools.ProductsComboBox()
		Me.qnc_Quantity = New SPPBC.M3Tools.QuantityNudCtrl()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.OK_Button.Location = New System.Drawing.Point(3, 3)
		Me.OK_Button.Name = "OK_Button"
		Me.OK_Button.Size = New System.Drawing.Size(67, 23)
		Me.OK_Button.TabIndex = 0
		Me.OK_Button.Text = "OK"
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
		Me.Cancel_Button.Name = "Cancel_Button"
		Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
		Me.Cancel_Button.TabIndex = 1
		Me.Cancel_Button.Text = "Cancel"
		'
		'bw_LoadOrder
		'
		'
		'db_Orders
		'
		Me.db_Orders.InitialCatalog = "Media Ministry"
		Me.db_Orders.Password = "M3AppPassword2499"
		Me.db_Orders.Username = "M3App"
		'
		'pcb_Items
		'
		Me.pcb_Items.AutoSize = True
		Me.pcb_Items.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pcb_Items.Location = New System.Drawing.Point(114, 84)
		Me.pcb_Items.MaximumSize = New System.Drawing.Size(0, 42)
		Me.pcb_Items.MinimumSize = New System.Drawing.Size(200, 42)
		Me.pcb_Items.Name = "pcb_Items"
		Me.pcb_Items.SelectedIndex = -1
		Me.pcb_Items.SelectedItem = Nothing
		Me.pcb_Items.SelectedValue = Nothing
		Me.pcb_Items.Size = New System.Drawing.Size(200, 42)
		Me.pcb_Items.TabIndex = 3
		'
		'qnc_Quantity
		'
		Me.qnc_Quantity.Location = New System.Drawing.Point(196, 150)
		Me.qnc_Quantity.MaximumSize = New System.Drawing.Size(0, 42)
		Me.qnc_Quantity.MinimumSize = New System.Drawing.Size(100, 42)
		Me.qnc_Quantity.Name = "qnc_Quantity"
		Me.qnc_Quantity.Quantity = 0
		Me.qnc_Quantity.Size = New System.Drawing.Size(100, 42)
		Me.qnc_Quantity.TabIndex = 4
		'
		'EditOrderDialog
		'
		Me.AcceptButton = Me.OK_Button
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.Cancel_Button
		Me.ClientSize = New System.Drawing.Size(435, 315)
		Me.Controls.Add(Me.qnc_Quantity)
		Me.Controls.Add(Me.pcb_Items)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "EditOrderDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Edit Order"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents OK_Button As System.Windows.Forms.Button
	Friend WithEvents Cancel_Button As System.Windows.Forms.Button
	Friend WithEvents bw_LoadOrder As ComponentModel.BackgroundWorker
	Friend WithEvents db_Orders As Database.OrdersDatabase
	Friend WithEvents pcb_Items As ProductsComboBox
	Friend WithEvents qnc_Quantity As QuantityNudCtrl
End Class