﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	/// <summary>
	/// The different tool buttons in the tool strip
	/// </summary>
	public enum ToolButtons
	{
		/// <summary>
		/// Add an entry
		/// </summary>
		ADD,
		/// <summary>
		/// Import entries
		/// </summary>
		IMPORT,
		/// <summary>
		/// Send emails
		/// </summary>
		EMAIL,
		/// <summary>
		/// Apply a filter to the data
		/// </summary>
		FILTER,
		/// <summary>
		/// The number of entries
		/// </summary>
		COUNT
	}

	/// <summary>
	/// A tool strip containing similar functionality for all data components
	/// </summary>
    [DefaultEvent("FilterChanged")]
    public partial class ToolsToolStrip : ToolStrip
    {
		/// <summary>
		/// Event fired when importing entries
		/// </summary>
        public event EventHandler ImportEntries;
		/// <summary>
		/// Event fired when adding entries
		/// </summary>
        public event EventHandler AddEntry;
		/// <summary>
		/// Event fire when wanting to send emails
		/// </summary>
        public event EventHandler SendEmails;
		/// <summary>
		/// Event fired when wanting to filter the data
		/// </summary>
        public event EventHandler<string> FilterChanged;

		/// <summary>
		/// The text to display in the data counter
		/// </summary>
        public string Count
        {
            set
            {
                tsl_Count.Text = value;
            }
        }

		/// <summary>
		/// The type of the list
		/// </summary>
        [DefaultValue("")]
        public string ListType { get; set; }

        private string Filter
        {
            get
            {
                return tst_Filter.Text;
            }
            set
            {
                tst_Filter.Text = value;
            }
        }

        private void Import(object sender, EventArgs e)
        {
            ImportEntries?.Invoke(sender, e);
        }

        private void Add(object sender, EventArgs e)
        {
            AddEntry?.Invoke(sender, e);
        }

        private void Emails(object sender, EventArgs e)
        {
            SendEmails?.Invoke(sender, e);
        }

        private void Filtered(object sender, EventArgs e)
        {
            FilterChanged?.Invoke(sender, Filter);
        }

        private void UpdateLabelText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ListType))
            {
                return;
            }

            tsb_New.ToolTipText = string.Format(tsb_New.ToolTipText, ListType);
            tsb_Import.ToolTipText = string.Format(tsb_Import.ToolTipText, ListType);
            tst_Filter.ToolTipText = string.Format(tst_Filter.ToolTipText, ListType);
        }

		/// <summary>
		/// Toggle any of the buttons in the strip to not be visible by name
		/// </summary>
		/// <param name="button">The button to toggle visibility on</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void ToggleButton(ToolButtons button)
		{
			switch (button)
			{
				case ToolButtons.EMAIL:
					tsb_Emails.Available = !tsb_Emails.Available;
					break;
				case ToolButtons.ADD:
					tsb_New.Available = !tsb_New.Available;
					break;
				case ToolButtons.IMPORT:								   
					tsb_Import.Available = !tsb_Import.Available;		   
					break;												   
				case ToolButtons.FILTER:								   
					tst_Filter.Available = !tst_Filter.Available;		   
					// TODO: Also hide last seperator when hiding this one;
					break;
				case ToolButtons.COUNT:
					tsl_Count.Available = !tsl_Count.Available;
					// TODO: Also hide last seperator when hiding this one;
					break;
				default:
					throw new ArgumentException($"Name '${button}' not known");
			}
		}
	}
}
