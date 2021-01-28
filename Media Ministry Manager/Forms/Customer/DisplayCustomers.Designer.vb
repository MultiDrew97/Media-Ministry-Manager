﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DisplayCustomers
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DisplayCustomers))
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoinDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCustomers1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ss_CustomerView = New System.Windows.Forms.StatusStrip()
        Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_AddNewCustomer = New System.Windows.Forms.Button()
        Me.mnstr_Strip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_TableFunctions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsm_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_TableFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Customers
        '
        Me.dgv_Customers.AllowUserToAddRows = False
        Me.dgv_Customers.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        Me.dgv_Customers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Customers.AutoGenerateColumns = False
        Me.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameColumn, Me.LastNameColumn, Me.PhoneNumberColumn, Me.EmailAddressColumn, Me.JoinDateColumn})
        Me.dgv_Customers.DataSource = Me.bsCustomers1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Customers.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_Customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgv_Customers.Location = New System.Drawing.Point(0, 24)
        Me.dgv_Customers.MultiSelect = False
        Me.dgv_Customers.Name = "dgv_Customers"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgv_Customers.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Customers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgv_Customers.Size = New System.Drawing.Size(888, 381)
        Me.dgv_Customers.TabIndex = 0
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.DataPropertyName = "FirstName"
        Me.FirstNameColumn.FillWeight = 163.3136!
        Me.FirstNameColumn.HeaderText = "First Name"
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'LastNameColumn
        '
        Me.LastNameColumn.DataPropertyName = "LastName"
        Me.LastNameColumn.FillWeight = 142.877!
        Me.LastNameColumn.HeaderText = "Last Name"
        Me.LastNameColumn.Name = "LastNameColumn"
        '
        'PhoneNumberColumn
        '
        Me.PhoneNumberColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberColumn.FillWeight = 164.83!
        Me.PhoneNumberColumn.HeaderText = "Phone Number"
        Me.PhoneNumberColumn.Name = "PhoneNumberColumn"
        '
        'EmailAddressColumn
        '
        Me.EmailAddressColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressColumn.FillWeight = 65.87088!
        Me.EmailAddressColumn.HeaderText = "Email"
        Me.EmailAddressColumn.Name = "EmailAddressColumn"
        '
        'JoinDateColumn
        '
        Me.JoinDateColumn.DataPropertyName = "JoinDate"
        Me.JoinDateColumn.FillWeight = 84.47861!
        Me.JoinDateColumn.HeaderText = "Join Date"
        Me.JoinDateColumn.Name = "JoinDateColumn"
        Me.JoinDateColumn.ReadOnly = True
        '
        'ss_CustomerView
        '
        Me.ss_CustomerView.BackColor = System.Drawing.SystemColors.Control
        Me.ss_CustomerView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_CustomerView.Location = New System.Drawing.Point(0, 518)
        Me.ss_CustomerView.Name = "ss_CustomerView"
        Me.ss_CustomerView.Size = New System.Drawing.Size(888, 22)
        Me.ss_CustomerView.TabIndex = 3
        '
        'tss_CustomersView
        '
        Me.tss_CustomersView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tss_CustomersView.Name = "tss_CustomersView"
        Me.tss_CustomersView.Size = New System.Drawing.Size(170, 17)
        Me.tss_CustomersView.Text = "Here are the current customers"
        '
        'btn_AddNewCustomer
        '
        Me.btn_AddNewCustomer.AutoSize = True
        Me.btn_AddNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_AddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNewCustomer.Location = New System.Drawing.Point(333, 440)
        Me.btn_AddNewCustomer.Name = "btn_AddNewCustomer"
        Me.btn_AddNewCustomer.Size = New System.Drawing.Size(222, 35)
        Me.btn_AddNewCustomer.TabIndex = 1
        Me.btn_AddNewCustomer.Text = "Add New Customer"
        Me.btn_AddNewCustomer.UseVisualStyleBackColor = True
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(888, 24)
        Me.mnstr_Strip.TabIndex = 5
        Me.mnstr_Strip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.ProductToolStripMenuItem, Me.ListenerToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewToolStripMenuItem.Text = "&New..."
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NewCustomerToolStripMenuItem.Text = "Customer"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'ListenerToolStripMenuItem
        '
        Me.ListenerToolStripMenuItem.Name = "ListenerToolStripMenuItem"
        Me.ListenerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ListenerToolStripMenuItem.Text = "Listener"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.MediaMinistry.My.Resources.Resources.logout_button
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindCustomerToolStripMenuItem, Me.ProductToolStripMenuItem1, Me.ListenerToolStripMenuItem1})
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CustomizeToolStripMenuItem.Text = "Find..."
        '
        'FindCustomerToolStripMenuItem
        '
        Me.FindCustomerToolStripMenuItem.Name = "FindCustomerToolStripMenuItem"
        Me.FindCustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FindCustomerToolStripMenuItem.Text = "Customer"
        '
        'ProductToolStripMenuItem1
        '
        Me.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1"
        Me.ProductToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ProductToolStripMenuItem1.Text = "Product"
        '
        'ListenerToolStripMenuItem1
        '
        Me.ListenerToolStripMenuItem1.Name = "ListenerToolStripMenuItem1"
        Me.ListenerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ListenerToolStripMenuItem1.Text = "Listener"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OptionsToolStripMenuItem.Text = "Update"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCustomersToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ListenersToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ViewCustomersToolStripMenuItem
        '
        Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
        Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ViewCustomersToolStripMenuItem.Text = "Customers"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'ListenersToolStripMenuItem
        '
        Me.ListenersToolStripMenuItem.Name = "ListenersToolStripMenuItem"
        Me.ListenersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ListenersToolStripMenuItem.Text = "Listeners"
        '
        'cms_TableFunctions
        '
        Me.cms_TableFunctions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Refresh, Me.RemoveToolStripMenuItem})
        Me.cms_TableFunctions.Name = "cms_Refresh"
        Me.cms_TableFunctions.Size = New System.Drawing.Size(118, 48)
        '
        'tsm_Refresh
        '
        Me.tsm_Refresh.Name = "tsm_Refresh"
        Me.tsm_Refresh.Size = New System.Drawing.Size(117, 22)
        Me.tsm_Refresh.Text = "Refresh"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Frm_DisplayCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(888, 540)
        Me.ContextMenuStrip = Me.cms_TableFunctions
        Me.Controls.Add(Me.btn_AddNewCustomer)
        Me.Controls.Add(Me.dgv_Customers)
        Me.Controls.Add(Me.ss_CustomerView)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_DisplayCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_TableFunctions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_Customers As DataGridView
    Friend WithEvents ss_CustomerView As StatusStrip
    Friend WithEvents tss_CustomersView As ToolStripStatusLabel
    Friend WithEvents btn_AddNewCustomer As Button
    Friend WithEvents PREFERREDPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mnstr_Strip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListenerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cms_TableFunctions As ContextMenuStrip
    Friend WithEvents tsm_Refresh As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressColumn As DataGridViewTextBoxColumn
    Friend WithEvents JoinDateColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsCustomers1 As BindingSource
End Class
