﻿using System;
using System.Windows.Forms;

using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Listeners;

namespace M3App
{
	/// <summary>
	/// Form for managing email listeners
	/// </summary>
	public partial class ListenerManagement
	{
		/// <summary>
		/// 
		/// </summary>
		public ListenerManagement() : base()
		{
			InitializeComponent();

			ldg_Listeners.Reload += new EventHandler(Reload);
			ldg_Listeners.AddListener += new ListenerEventHandler(Add);
			ldg_Listeners.UpdateListener += new ListenerEventHandler(Update);
			ldg_Listeners.RemoveListener += new ListenerEventHandler(Remove);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override async void Reload(object sender, EventArgs e)
		{
			base.Reload(sender, e);
			_original = await dbListeners.GetListeners();
			ldg_Listeners.Listeners = SPPBC.M3Tools.Types.ListenerCollection.Cast(_original.Items);
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, ldg_Listeners.Listeners.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
		{
			base.Remove(sender, e);
			_ = dbListeners.RemoveListener(e.Value.Id);
			_ = MessageBox.Show($"Successfully removed {e.Value.Name}", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
			base.Add(sender, e);
			using SPPBC.M3Tools.Dialogs.AddListenerDialog @add = new();

			if (add.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			UseWaitCursor = true;
			AddToDB(sender, add.Listener);
			_ = MessageBox.Show($"Successfully added {add.Listener.Name}", "Successful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		/// <inheritdoc/>
		protected override void Import(object sender, EventArgs e)
		{
			base.Import(sender, e);
			using SPPBC.M3Tools.Dialogs.ImportListenersDialog @import = new();

			if (import.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			foreach (SPPBC.M3Tools.Types.Listener listener in import.Listeners)
			{
				AddToDB(sender, listener);
			}

			UseWaitCursor = false;
		}

		private void AddToDB(object sender, SPPBC.M3Tools.Types.Listener listener)
		{
			try
			{
				_ = dbListeners.AddListener(listener);
				SendWelcome(sender, new ListenerEventArgs(listener, EventType.Added));
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Unable to add listener {listener.Name} to database\nError:\n{ex.Message}");
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
		{
			base.Update(sender, e);
			using SPPBC.M3Tools.Dialogs.EditListenerDialog @edit = new(e.Value);

			if (edit.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			_ = dbListeners.UpdateListener(edit.Listener);
			_ = MessageBox.Show($"Successfully updated {e.Value.Name}", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <inheritdoc/>
		protected override void FilterChanged(object sender, string filter)
		{
			base.FilterChanged(sender, filter);

			ldg_Listeners.Listeners = SPPBC.M3Tools.Types.ListenerCollection.Cast(_original.Items);

			AssessLabel();
		}

		/// <inheritdoc />
		protected override void SendEmails(object sender, EventArgs e)
		{
			base.SendEmails(sender, e);
			using SendEmailsDialog emails = new();
			_ = emails.ShowDialog(this);
			UseWaitCursor = false;
		}

		private void SendWelcome(object sender, ListenerEventArgs e)
		{
			UseWaitCursor = true;

			string subject = "Welcome to the Ministry";
			string body = string.Format(Properties.Resources.NEW_LISTENER_TEMPLATE, e.Value.Name.Trim());
			MimeKit.MimeMessage message = gt_Email.Create(e.Value, subject, body);
#if !DEBUG
			await gt_Email.Send(message);
#endif

			MessageBox.Show($"Listener {e.Value.Name} has been added to the ministry. Their welcome email should be sent shortly.", "Listener Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

			Reload(sender, e);
		}
	}
}