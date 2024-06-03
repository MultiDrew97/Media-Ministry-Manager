﻿using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ListenerSelectionDialog : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.ldg_Listeners = new SPPBC.M3Tools.Data.ListenersDataGrid();
            this.bsListeners = new SPPBC.M3Tools.Data.ListenerBindingSource();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Select, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(366, 368);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Select.Location = new System.Drawing.Point(76, 3);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(67, 23);
            this.btn_Select.TabIndex = 0;
            this.btn_Select.Text = "Select";
            this.btn_Select.Click += new System.EventHandler(this.ConfirmSelection);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // ldg_Listeners
            // 
            this.ldg_Listeners.AllowUserToAddRows = false;
            this.ldg_Listeners.AllowUserToOrderColumns = true;
            this.ldg_Listeners.AutoGenerateColumns = false;
            this.ldg_Listeners.CanDelete = false;
            this.ldg_Listeners.CanEdit = false;
            this.ldg_Listeners.CanReorder = true;
            this.ldg_Listeners.ColumnHeadersHeight = 46;
            this.ldg_Listeners.DataSource = this.bsListeners;
            this.ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Top;
            this.ldg_Listeners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ldg_Listeners.Location = new System.Drawing.Point(0, 0);
            this.ldg_Listeners.MinimumSize = new System.Drawing.Size(400, 200);
            this.ldg_Listeners.Name = "ldg_Listeners";
            this.ldg_Listeners.RowHeadersWidth = 82;
            this.ldg_Listeners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ldg_Listeners.Size = new System.Drawing.Size(524, 362);
            this.ldg_Listeners.TabIndex = 1;
            // 
            // bsListeners
            // 
            this.bsListeners.Filter = "";
            // 
            // ListenerSelectionDialog
            // 
            this.AcceptButton = this.btn_Select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(524, 409);
            this.Controls.Add(this.ldg_Listeners);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListenerSelectionDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Which Listener(s)?";
            this.TopMost = true;
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Select;
        internal System.Windows.Forms.Button btn_Cancel;
        internal Data.ListenersDataGrid ldg_Listeners;
		private Data.ListenerBindingSource bsListeners;
	}
}
