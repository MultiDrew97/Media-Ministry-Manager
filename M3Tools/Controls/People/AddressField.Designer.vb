﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressField
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.if_Address1 = New SPPBC.M3Tools.GenericInputPair()
        Me.if_City = New SPPBC.M3Tools.GenericInputPair()
        Me.ssf_State = New SPPBC.M3Tools.StateSelectorField()
        Me.if_Address2 = New SPPBC.M3Tools.GenericInputPair()
        Me.if_ZipCode = New SPPBC.M3Tools.GenericInputPair()
        Me.ep_InvalidAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ep_InvalidAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.if_Address1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.if_City, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ssf_State, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.if_Address2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.if_ZipCode, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(650, 125)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'if_Address1
        '
        Me.if_Address1.AutoSize = True
        Me.if_Address1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.if_Address1.LabelText = "Address 1"
        Me.if_Address1.Location = New System.Drawing.Point(6, 6)
        Me.if_Address1.Margin = New System.Windows.Forms.Padding(6)
        Me.if_Address1.Mask = ""
        Me.if_Address1.Name = "if_Address1"
        Me.if_Address1.Placeholder = "Address 1"
        Me.if_Address1.Size = New System.Drawing.Size(248, 49)
        Me.if_Address1.TabIndex = 0
        Me.if_Address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'if_City
        '
        Me.if_City.AutoSize = True
        Me.if_City.Dock = System.Windows.Forms.DockStyle.Fill
        Me.if_City.LabelText = "City"
        Me.if_City.Location = New System.Drawing.Point(6, 67)
        Me.if_City.Margin = New System.Windows.Forms.Padding(6)
        Me.if_City.Mask = ""
        Me.if_City.Name = "if_City"
        Me.if_City.Placeholder = "City"
        Me.if_City.Size = New System.Drawing.Size(248, 52)
        Me.if_City.TabIndex = 2
        Me.if_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ssf_State
        '
        Me.ssf_State.AutoSize = True
        Me.ssf_State.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ssf_State.Location = New System.Drawing.Point(266, 67)
        Me.ssf_State.Margin = New System.Windows.Forms.Padding(6)
        Me.ssf_State.Name = "ssf_State"
        Me.ssf_State.Size = New System.Drawing.Size(118, 52)
        Me.ssf_State.StateCode = ""
        Me.ssf_State.TabIndex = 3
        '
        'if_Address2
        '
        Me.if_Address2.AutoSize = True
        Me.if_Address2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.if_Address2.LabelText = "Address 2"
        Me.if_Address2.Location = New System.Drawing.Point(396, 6)
        Me.if_Address2.Margin = New System.Windows.Forms.Padding(6)
        Me.if_Address2.Mask = ""
        Me.if_Address2.Name = "if_Address2"
        Me.if_Address2.Placeholder = "Address 2"
        Me.if_Address2.Size = New System.Drawing.Size(248, 49)
        Me.if_Address2.TabIndex = 1
        Me.if_Address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'if_ZipCode
        '
        Me.if_ZipCode.AutoSize = True
        Me.if_ZipCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.if_ZipCode.LabelText = "Zip Code"
        Me.if_ZipCode.Location = New System.Drawing.Point(396, 67)
        Me.if_ZipCode.Margin = New System.Windows.Forms.Padding(6)
        Me.if_ZipCode.Mask = "99999"
        Me.if_ZipCode.Name = "if_ZipCode"
        Me.if_ZipCode.Placeholder = "00000"
        Me.if_ZipCode.Size = New System.Drawing.Size(248, 52)
        Me.if_ZipCode.TabIndex = 4
        Me.if_ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ep_InvalidAddress
        '
        Me.ep_InvalidAddress.ContainerControl = Me
        '
        'AddressField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(650, 125)
        Me.Name = "AddressField"
        Me.Size = New System.Drawing.Size(650, 125)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ep_InvalidAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents if_Address1 As GenericInputPair
    Friend WithEvents if_Address2 As GenericInputPair
    Friend WithEvents if_City As GenericInputPair
    Friend WithEvents if_ZipCode As GenericInputPair
    Friend WithEvents ssf_State As StateSelectorField
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents ep_InvalidAddress As Windows.Forms.ErrorProvider
End Class
