﻿using System;
using MediaMinistry.Helpers;

namespace MediaMinistry
{

    public partial class Frm_DisplayOrders
    {
        public Frm_DisplayOrders()
        {
            InitializeComponent();
        }
        // TODO: Add eventhandler for when data is updated to show/hide empty message
        private void ViewLoading(object sender, EventArgs e)
        {
            doc_Orders.Reload();
            mms_Strip.ToggleViewItem("Orders");
            // lbl_NoOrders.Visible = doc_Orders.Count
        }

        private void ViewClosed(object sender, EventArgs e)
        {
            mms_Strip.ToggleViewItem("Orders");
            My.MyProject.Forms.MainForm.Show();
        }

        private void Logout()
        {
            Utils.LogOff();
            Close();
        }

        private void ExitApplication()
        {
            Utils.CloseOpenForms();
        }

        private void ViewCustomers(object sender, EventArgs e)
        {
            var customers = new CustomersManagement();
            customers.Show();
            // Utils.SpecialClose(sender)
            Close();
        }

        private void ViewProducts(object sender, EventArgs e)
        {
            var products = new InventoryManagement();
            products.Show();
            // Utils.SpecialClose(sender)
            Close();
        }

        private void ViewListeners(object sender, EventArgs e)
        {
            var listeners = new ListenersManagement();
            listeners.Show();
            // Utils.SpecialClose(sender)
            Close();
        }

        private void ViewSettings()
        {
            var settings = new SettingsForm();
            settings.Show();
        }

        private void DataUpdated()
        {
            // lbl_NoOrders.Visible = doc_Orders.IsEmpty
        }
    }
}