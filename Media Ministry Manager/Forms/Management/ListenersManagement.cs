﻿using System;
using System.ComponentModel;
using SPPBC.M3Tools.Events.Listeners;

namespace MediaMinistry
{

    public partial class ListenersManagement
    {

        private event ListenerEventHandler ListenerAdded;
        private event ListenerEventHandler ListenerDBModified;
        private bool Tooled = false;

        public ListenersManagement()
        {
            InitializeComponent();
            mms_Main.ToggleViewItem("Listeners");
            gt_Email.Authorize(My.MySettingsProperty.Settings.Username);
            gd_Drive.Authorize(My.MySettingsProperty.Settings.Username);
        }

        private void ClosingForm(object sender, CancelEventArgs e)
        {
            // TODO: Find easier way
            if (Tooled)
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }

        private void Logout()
        {
            Helpers.Utils.LogOff();
            Tooled = true;
            Close();
        }

        private void ExitApplication()
        {
            Helpers.Utils.CloseOpenForms();
        }

        private void ManageCustomers(object sender, EventArgs e)
        {
            var customers = new CustomersManagement();
            customers.Show();
            Tooled = true;
            Close();
        }

        private void ManageOrders(object sender, EventArgs e)
        {
            var orders = new OrderManagement();
            orders.Show();
            Tooled = true;
            Close();
        }

        private void ManageProducts(object sender, EventArgs e)
        {
            var products = new InventoryManagement();
            products.Show();
            Tooled = true;
            Close();
        }

        private void ViewSettings()
        {
            var settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void SendEmails()
        {
			using var emails = new SendEmailsDialog();
			UseWaitCursor = true;
			emails.ShowDialog();
			UseWaitCursor = false;
		}

        private void RemoveListener(object sender, ListenerEventArgs e)
        {
            UseWaitCursor = true;
            dbListeners.RemoveListener(e.Listener.Id);
            ListenerDBModified.Invoke(this, e);
        }

        private void AddListener(object sender, ListenerEventArgs e)
        {
            UseWaitCursor = true;
            dbListeners.AddListener(e.Listener.Name, e.Listener.Email);
            ListenerAdded.Invoke(this, e);
        }

        private void SendWelcom(object sender, ListenerEventArgs e)
        {
            UseWaitCursor = true;
#if !DEBUG
            string subject = "Welcome to the Ministry";
            string body = string.Format(My.Resources.Resources.newListener, e.Listener.Name.Trim());
			var message = gt_Email.Create(e.Listener, subject, body);
			gt_Email.Send(message);
#endif
			ListenerDBModified.Invoke(this, e);
        }

        private void UpdateListener(object sender, ListenerEventArgs e)
        {
            UseWaitCursor = true;
            dbListeners.UpdateListener(e.Listener);
			ListenerDBModified.Invoke(this, e);
        }

        private void Reload(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            bsListeners.Clear();
            foreach (var listener in dbListeners.GetListeners())
                bsListeners.Add(listener);
            dlc_Listeners.Reload();
            UseWaitCursor = false;
        }
    }
}