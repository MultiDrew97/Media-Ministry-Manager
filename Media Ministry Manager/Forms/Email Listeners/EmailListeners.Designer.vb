﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmailListeners
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmailListeners))
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.ofd_SelectAudio = New System.Windows.Forms.OpenFileDialog()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.txt_FileLocation = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.bw_Upload = New System.ComponentModel.BackgroundWorker()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_SendEmails = New System.Windows.Forms.Button()
        Me.btn_ViewListeners = New System.Windows.Forms.Button()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.gbx_EmailType = New System.Windows.Forms.GroupBox()
        Me.rdo_GoingLive = New System.Windows.Forms.RadioButton()
        Me.rdo_EmailMinistry = New System.Windows.Forms.RadioButton()
        Me.ss_Feedback.SuspendLayout()
        Me.gbx_EmailType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Upload
        '
        Me.btn_Upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Upload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Upload.Location = New System.Drawing.Point(20, 13)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(238, 36)
        Me.btn_Upload.TabIndex = 0
        Me.btn_Upload.Text = "Upload to Drive"
        Me.btn_Upload.UseVisualStyleBackColor = True
        '
        'ofd_SelectAudio
        '
        Me.ofd_SelectAudio.Multiselect = True
        Me.ofd_SelectAudio.Title = "Email Ministry"
        '
        'cbx_Folders
        '
        Me.cbx_Folders.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(389, 68)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(367, 33)
        Me.cbx_Folders.TabIndex = 1
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(293, 68)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(79, 26)
        Me.lbl_Folder.TabIndex = 2
        Me.lbl_Folder.Text = "Folder"
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(314, 127)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 26)
        Me.lbl_FileLocation.TabIndex = 3
        Me.lbl_FileLocation.Text = "File:"
        '
        'txt_FileLocation
        '
        Me.txt_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FileLocation.Location = New System.Drawing.Point(389, 127)
        Me.txt_FileLocation.Name = "txt_FileLocation"
        Me.txt_FileLocation.ReadOnly = True
        Me.txt_FileLocation.Size = New System.Drawing.Size(367, 32)
        Me.txt_FileLocation.TabIndex = 4
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Browse.Location = New System.Drawing.Point(762, 127)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(44, 31)
        Me.btn_Browse.TabIndex = 5
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'bw_Upload
        '
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddFolder.Location = New System.Drawing.Point(762, 70)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(44, 31)
        Me.btn_AddFolder.TabIndex = 6
        Me.btn_AddFolder.Text = "+"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 727)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Size = New System.Drawing.Size(884, 22)
        Me.ss_Feedback.TabIndex = 7
        Me.ss_Feedback.Text = "ss_Feedback"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(340, 17)
        Me.tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to"
        '
        'btn_SendEmails
        '
        Me.btn_SendEmails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_SendEmails.Location = New System.Drawing.Point(20, 71)
        Me.btn_SendEmails.Name = "btn_SendEmails"
        Me.btn_SendEmails.Size = New System.Drawing.Size(238, 36)
        Me.btn_SendEmails.TabIndex = 8
        Me.btn_SendEmails.Text = "Send Emails"
        Me.btn_SendEmails.UseVisualStyleBackColor = True
        '
        'btn_ViewListeners
        '
        Me.btn_ViewListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ViewListeners.Location = New System.Drawing.Point(20, 129)
        Me.btn_ViewListeners.Name = "btn_ViewListeners"
        Me.btn_ViewListeners.Size = New System.Drawing.Size(238, 36)
        Me.btn_ViewListeners.TabIndex = 10
        Me.btn_ViewListeners.Text = "Current Listeners"
        Me.btn_ViewListeners.UseVisualStyleBackColor = True
        '
        'gbx_EmailType
        '
        Me.gbx_EmailType.Controls.Add(Me.rdo_GoingLive)
        Me.gbx_EmailType.Controls.Add(Me.rdo_EmailMinistry)
        Me.gbx_EmailType.Location = New System.Drawing.Point(389, 13)
        Me.gbx_EmailType.Name = "gbx_EmailType"
        Me.gbx_EmailType.Size = New System.Drawing.Size(352, 49)
        Me.gbx_EmailType.TabIndex = 11
        Me.gbx_EmailType.TabStop = False
        Me.gbx_EmailType.Text = "What Email"
        '
        'rdo_GoingLive
        '
        Me.rdo_GoingLive.AutoSize = True
        Me.rdo_GoingLive.Location = New System.Drawing.Point(196, 19)
        Me.rdo_GoingLive.Name = "rdo_GoingLive"
        Me.rdo_GoingLive.Size = New System.Drawing.Size(95, 17)
        Me.rdo_GoingLive.TabIndex = 1
        Me.rdo_GoingLive.Text = "Live Streaming"
        Me.rdo_GoingLive.UseVisualStyleBackColor = True
        '
        'rdo_EmailMinistry
        '
        Me.rdo_EmailMinistry.AutoSize = True
        Me.rdo_EmailMinistry.Checked = True
        Me.rdo_EmailMinistry.Location = New System.Drawing.Point(65, 19)
        Me.rdo_EmailMinistry.Name = "rdo_EmailMinistry"
        Me.rdo_EmailMinistry.Size = New System.Drawing.Size(88, 17)
        Me.rdo_EmailMinistry.TabIndex = 0
        Me.rdo_EmailMinistry.TabStop = True
        Me.rdo_EmailMinistry.Text = "Email Ministry"
        Me.rdo_EmailMinistry.UseVisualStyleBackColor = True
        '
        'frm_EmailListeners
        '
        Me.AcceptButton = Me.btn_Upload
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 749)
        Me.Controls.Add(Me.gbx_EmailType)
        Me.Controls.Add(Me.btn_ViewListeners)
        Me.Controls.Add(Me.btn_SendEmails)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_FileLocation)
        Me.Controls.Add(Me.lbl_FileLocation)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.cbx_Folders)
        Me.Controls.Add(Me.btn_Upload)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_EmailListeners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.gbx_EmailType.ResumeLayout(False)
        Me.gbx_EmailType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Upload As Button
    Friend WithEvents ofd_SelectAudio As OpenFileDialog
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents txt_FileLocation As TextBox
    Friend WithEvents btn_Browse As Button
    Friend WithEvents bw_Upload As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents btn_SendEmails As Button
    Friend WithEvents btn_ViewListeners As Button
    Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbx_EmailType As GroupBox
    Friend WithEvents rdo_GoingLive As RadioButton
    Friend WithEvents rdo_EmailMinistry As RadioButton
End Class