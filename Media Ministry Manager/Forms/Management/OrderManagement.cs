﻿
using System;
using System.Windows.Forms;

using SPPBC.M3Tools.Events.Orders;

namespace M3App
{
	/// <summary>
	/// Form for managing orders
	/// </summary>
	public partial class OrderManagement
	{
		/// <summary>
		/// 
		/// </summary>
		public OrderManagement() : base()
		{
			InitializeComponent();

			odg_Orders.Reload += new EventHandler(Reload);
			odg_Orders.AddOrder += new OrderEventHandler(Add);
			odg_Orders.UpdateOrder += new OrderEventHandler(Update);
			odg_Orders.RemoveOrder += new OrderEventHandler(Remove);

			odg_Orders.Reload += (sender, e) => _original = dbOrders.GetOrders();

			_original = dbOrders.GetOrders();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			odg_Orders.Orders = SPPBC.M3Tools.Types.OrderCollection.Cast(_original.Items);
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, odg_Orders.Orders.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// Add a new Order to the database from the tool strip
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
#if !DEBUG
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#else
			using SPPBC.M3Tools.Dialogs.PlaceOrderDialog @add = new(dbCustomers.GetCustomers(), dbInventory.GetProducts());

			if (add.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}

			foreach (SPPBC.M3Tools.Types.CartItem item in add.Cart)
			{
				dbOrders.AddOrder(new(-1, add.Customer, item.Item, item.Quantity, default, default));
			}

			MessageBox.Show($"Order has been placed for {add.Customer.Name}", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
#endif
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Order> e)
		{
#if !DEBUG
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#else
			using SPPBC.M3Tools.Dialogs.EditOrderDialog @edit = new(e.Value, dbCustomers.GetCustomers(), dbInventory.GetProducts());

			if (edit.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}

			dbOrders.UpdateOrder(edit.UpdatedOrder);
			MessageBox.Show($"Successfully updated order", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
#endif
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Order> e)
		{
#if !DEBUG
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#else
			string text;
			string caption;
			try
			{
				UseWaitCursor = true;
				switch (MessageBox.Show("Is this order being canceled?", "Cancel Order", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Yes:
						dbOrders.CancelOrder(e.Value.Id);
						text = $"Order for {e.Value.Customer.Name} has been cancelled";
						caption = "Order Cancelled";
						break;
					case DialogResult.No:
						dbOrders.CompleteOrder(e.Value.Id);
						text = $"Order for {e.Value.Customer.Name} has been completed";
						caption = "Order Completed";
						break;
					case DialogResult.Cancel:
					default:
						text = $"Removal of order for {e.Value.Customer.Name} has been canceled";
						caption = "Removal Canceled";
						return;
				}

				_ = MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				Reload(sender, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Removal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				UseWaitCursor = false;
			}
#endif
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected override void FilterChanged(object sender, string filter)
		{
			_original.Filter = filter;
			odg_Orders.Orders = SPPBC.M3Tools.Types.OrderCollection.Cast(_original.Items);
		}
	}
}
