﻿using System;
using System.Drawing;
using System.Windows.Forms;
using M3App.Helpers;

namespace M3App
{

    public partial class MainForm
    {
		/// <summary>
		/// 
		/// </summary>
        public MainForm()
        {
            InitializeComponent();

			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);
        }
        private void Reload()
        {
            tss_Feedback.Text = "What would you like to do?";
            tss_Feedback.ForeColor = SystemColors.WindowText;
            Focus();
        }

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			switch (e.Manage)
			{
				case SPPBC.M3Tools.Events.ManageType.Customers:
					ManageCustomers(sender, e);
					break;
				case SPPBC.M3Tools.Events.ManageType.Listeners:
					ManageListeners(sender, e);
					break;
				case SPPBC.M3Tools.Events.ManageType.Orders:
					ManageOrders(sender, e);
					break;
				case SPPBC.M3Tools.Events.ManageType.Inventory:
					MangeInventory(sender, e);
					break;
					
			}
		}

        private void MangeInventory(object sender, EventArgs e)
        {
            var products = new InventoryManagement();
            products.Show();
            Close();
        }

        private void ManageOrders(object sender, EventArgs e)
        {
            var orders = new OrderManagement();
            orders.Show();
            Close();
        }

        private void ManageCustomers(object sender, EventArgs e)
        {
            var customers = new CustomerManagement();
            customers.Show();
            Close();
        }

        private void ManageListeners(object sender, EventArgs e)
        {
            var listeners = new ListenersManagement();
            listeners.Show();
            Close();
        }

        private void Logout(object sender, EventArgs e)
        {
            Utils.LogOff();
            Close();
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Utils.CloseOpenForms();
        }

		private void AddCustomer(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Customer> e)
		{
			AddCustomer(sender, e as SPPBC.M3Tools.Events.Customers.CustomerEventArgs);
		}

        private void AddCustomer(object sender, SPPBC.M3Tools.Events.Customers.CustomerEventArgs e)
        {
            dbCustomer.AddCustomer(e.Value);
            MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		private void AddListener(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
		{
			AddListener(sender, e as SPPBC.M3Tools.Events.Listeners.ListenerEventArgs);
		}

		private void AddListener(object sender, SPPBC.M3Tools.Events.Listeners.ListenerEventArgs e)
        {
            dbListener.AddListener(e.Value);
            MessageBox.Show($"Successfully created listener", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		private void AddProduct(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Product> e)
		{
			AddProduct(sender, e as SPPBC.M3Tools.Events.Inventory.InventoryEventArgs);
		}

		private void AddProduct(object sender, SPPBC.M3Tools.Events.Inventory.InventoryEventArgs e)
        {
            dbInventory.AddProduct(e.Value);
            MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		// Private Sub AddOrder(sender As Object, e As SPPBC.M3Tools.Events.Orders.OrderEventArgs) Handles mms_Main.AddOrder
		// dbOrder.AddOrder(e.Order)
		// MessageBox.Show($"Successfully created order", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
		// End Sub

		private void ViewSettings(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.Show();
        }

        private void Reload(object sender, EventArgs e) => Reload();
    }
}