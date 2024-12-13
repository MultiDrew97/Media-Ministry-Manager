﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Data;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ManagementForm<T> : Form
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
			this.components = new System.ComponentModel.Container();
			this.ss_StatusView = new System.Windows.Forms.StatusStrip();
			this.tss_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsp_Progress = new System.Windows.Forms.ToolStripProgressBar();
			this.mms_Main = new SPPBC.M3Tools.MainMenuStrip();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.ts_Tools = new SPPBC.M3Tools.ToolsToolStrip(this.components);
			this.lbl_Empty = new System.Windows.Forms.Label();
			this.ss_StatusView.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ss_StatusView
			// 
			this.ss_StatusView.BackColor = System.Drawing.SystemColors.Control;
			this.ss_StatusView.Dock = System.Windows.Forms.DockStyle.None;
			this.ss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ss_StatusView.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.ss_StatusView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_Status,
            this.tsp_Progress});
			this.ss_StatusView.Location = new System.Drawing.Point(0, 0);
			this.ss_StatusView.Name = "ss_StatusView";
			this.ss_StatusView.Size = new System.Drawing.Size(784, 36);
			this.ss_StatusView.SizingGrip = false;
			this.ss_StatusView.TabIndex = 0;
			// 
			// tss_Status
			// 
			this.tss_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tss_Status.Name = "tss_Status";
			this.tss_Status.Size = new System.Drawing.Size(667, 31);
			this.tss_Status.Spring = true;
			this.tss_Status.Text = "What would you like to do?";
			this.tss_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tsp_Progress
			// 
			this.tsp_Progress.AutoToolTip = true;
			this.tsp_Progress.CausesValidation = false;
			this.tsp_Progress.Name = "tsp_Progress";
			this.tsp_Progress.Size = new System.Drawing.Size(100, 30);
			this.tsp_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// mms_Main
			// 
			this.mms_Main.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.mms_Main.Location = new System.Drawing.Point(0, 0);
			this.mms_Main.Name = "mms_Main";
			this.mms_Main.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
			this.mms_Main.Size = new System.Drawing.Size(784, 24);
			this.mms_Main.TabIndex = 0;
			this.mms_Main.Text = "Menu";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.ss_StatusView);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.lbl_Empty);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 362);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(784, 437);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "ToolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ts_Tools);
			// 
			// ts_Tools
			// 
			this.ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
			this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.ts_Tools.ListType = null;
			this.ts_Tools.Location = new System.Drawing.Point(0, 0);
			this.ts_Tools.Name = "ts_Tools";
			this.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ts_Tools.Size = new System.Drawing.Size(784, 39);
			this.ts_Tools.Stretch = true;
			this.ts_Tools.TabIndex = 0;
			this.ts_Tools.Text = "ToolsToolStrip1";
			// 
			// lbl_Empty
			// 
			this.lbl_Empty.AutoSize = true;
			this.lbl_Empty.Location = new System.Drawing.Point(336, 159);
			this.lbl_Empty.Name = "lbl_Empty";
			this.lbl_Empty.Size = new System.Drawing.Size(103, 13);
			this.lbl_Empty.TabIndex = 2;
			this.lbl_Empty.Text = "No Entries to display";
			this.lbl_Empty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.mms_Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = global::M3App.Properties.Resources.Icon;
			this.MainMenuStrip = this.mms_Main;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(795, 484);
			this.Name = "ManagementForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Media Ministry Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayClosing);
			this.Load += new System.EventHandler(this.Reload);
			this.ss_StatusView.ResumeLayout(false);
			this.ss_StatusView.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        protected internal ToolStripStatusLabel tss_Status;
		protected internal SPPBC.M3Tools.ToolsToolStrip ts_Tools;
		protected internal StatusStrip ss_StatusView;
		protected internal ToolStripContainer toolStripContainer1;
		protected internal SPPBC.M3Tools.MainMenuStrip mms_Main;
		protected internal ToolStripProgressBar tsp_Progress;
		private Label lbl_Empty;
	}
}