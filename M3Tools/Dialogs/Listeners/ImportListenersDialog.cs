﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace SPPBC.M3Tools.Dialogs
{
    public partial class ImportListenersDialog
    {
		/// <summary>
		/// The list of listeners being imported
		/// </summary>
        public Types.DbEntryCollection<Types.Listener> Listeners
        {
            get
            {
                return (Types.DbEntryCollection<Types.Listener>)ldg_Listeners.Listeners;
            }
        }

		/// <summary>
		/// A dialog to be used to import listeners into the database
		/// </summary>
        public ImportListenersDialog()
        {
            InitializeComponent();
        }

        private void BeginImport(object sender, EventArgs e)
        {
            if (Listeners.Count == 0)
            {
                MessageBox.Show("No listeners have been selected", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RetrieveFile(object sender, EventArgs e)
        {
            ofd_ImportFile.ShowDialog();
        }

        private void FilesSelected(object sender, CancelEventArgs e)
        {
            gi_FileName.Text = string.Join(",", ofd_ImportFile.SafeFileNames);

            bw_ParseFiles.RunWorkerAsync(ofd_ImportFile.FileNames);
        }

        private Dictionary<string, int> ParseHeaders(params string[] headers)
        {
            var dict = new Dictionary<string, int>();
            string[] validHeaderValues = new[] { "Name", "Email" };

            foreach (var validHeader in validHeaderValues)
            {
                int index = Array.IndexOf(headers, validHeader.ToLower());

                if (index < 0)
                {
                    throw new ArgumentException($"Unable to find column '{validHeader}'. Please update file and try again.");
                }

                dict.Add(validHeader, index);
            }

            return dict;
        }

        private void ClearList(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to clear the list of imports?", "Clear Import List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes))
            {
                return;
            }

            // TODO: Verify that this works still
            bsListeners.Clear();
        }

        private void ParseFiles(object sender, DoWorkEventArgs e)
        {
            var colDict = new Dictionary<string, int>() { { "Name", 0 }, { "Email", 1 } };
            TextFieldParser csvReader;
			Types.ListenerCollection list = new();

            foreach (var @file in ofd_ImportFile.FileNames)
            {
                csvReader = new TextFieldParser(@file)
                {
                    Delimiters = new[] { "," },
                    TextFieldType = FieldType.Delimited
                };

                if (chk_Headers.Checked)
                {
                    try
                    {
                        colDict = ParseHeaders(string.Join(";", csvReader.ReadFields()).ToLower().Split(';'));
                    }
                    catch (ArgumentException)
                    {
                        throw new MalformedLineException("Headers missing in file");
                    }
                }

                while (!csvReader.EndOfData)
                {
                    string[] fields = csvReader.ReadFields();
                    var listener = new Types.Listener(-1, fields[colDict["Name"]], fields[colDict["Email"]]);

                    if (bsListeners.Contains(listener))
                    {
                        continue;
                    }

                    list.Add(listener);
                }
            }

			e.Result = list;
        }

        private void FilesParsed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error is not null)
            {
				MessageBox.Show(e.Error.Message, "Failed to Import", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				return;
            }

            if (e.Cancelled)
            {
                return;
            }

            var list = (Types.ListenerCollection)e.Result;

			foreach (var listener in list)
				bsListeners.Add(listener);
        }
    }
}