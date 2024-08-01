﻿using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom data grid to use for displaying order information
	/// </summary>
	public partial class OrderDataGrid
	{
		#region Columns
		// Columns for the data grid
		private readonly DataGridViewTextBoxColumn dgc_CustomerName = new();
		private readonly DataGridViewTextBoxColumn dgc_ItemName = new();
		private readonly DataGridViewTextBoxColumn dgc_OrderTotal = new();
		private readonly DataGridViewTextBoxColumn dgc_Quantity = new();
		private readonly DataGridViewTextBoxColumn dgc_OrderDate = new();
		private readonly DataGridViewTextBoxColumn dgc_CompletedDate = new();
		#endregion

		#region Events
		/// <summary>
		/// Event that occurs when a order is being added to the database
		/// </summary>
		public event Events.Orders.OrderEventHandler AddOrder;

		/// <summary>
		/// Event that occurs when a order is being removed from the database
		/// </summary>
		public event Events.Orders.OrderEventHandler RemoveOrder;

		/// <summary>
		/// Event that occurs when a order is being updated in the database
		/// </summary>
		public event Events.Orders.OrderEventHandler UpdateOrder;
		#endregion

		/// <summary>
		/// The list of orders currently in the data grid
		/// </summary>
		[Browsable(false)]
		public Types.OrderCollection Orders
		{
			get => Types.OrderCollection.Cast(bsOrders.List);
			set
			{
				if (DesignMode)
				{
					return;
				}

				bsOrders.DataSource = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public Types.OrderCollection SelectedOrders => Types.OrderCollection.Cast(base.SelectedRows);

		/// <summary>
		/// 
		/// </summary>
		public OrderDataGrid() : base()
		{
			InitializeComponent();

			LoadColumns();

			AddEntry += (sender, e) => AddOrder?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateOrder?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveOrder?.Invoke(sender, new(e.Value, e.EventType));
		}

		/// <inheritdoc/>
		protected override void LoadColumns()
		{
			base.LoadColumns();

			dgc_ID.HeaderText = "OrderID";

			// Customer Column
			dgc_CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dgc_CustomerName.DataPropertyName = "Customer.Name";
			dgc_CustomerName.FillWeight = 25F;
			dgc_CustomerName.HeaderText = "Customer";
			dgc_CustomerName.MinimumWidth = 10;
			dgc_CustomerName.Name = "dgc_CustomerName";

			// Item Column
			dgc_ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgc_ItemName.DataPropertyName = "Item.Name";
			dgc_ItemName.FillWeight = 25F;
			dgc_ItemName.HeaderText = "Item";
			dgc_ItemName.MinimumWidth = 10;
			dgc_ItemName.Name = "dgc_ItemName";

			// Quantity Column
			dgc_Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgc_Quantity.DataPropertyName = "Quantity";
			dgc_Quantity.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, NullValue = "0" };
			dgc_Quantity.FillWeight = 25F;
			dgc_Quantity.HeaderText = "Quantity";
			dgc_Quantity.MinimumWidth = 10;
			dgc_Quantity.Name = "dgc_Quantity";

			// Order Total Column
			dgc_OrderTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgc_OrderTotal.DataPropertyName = "Total";
			dgc_OrderTotal.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "C2", NullValue = "$0.00" };
			dgc_OrderTotal.FillWeight = 25F;
			dgc_OrderTotal.HeaderText = "Total";
			dgc_OrderTotal.MinimumWidth = 50;
			dgc_OrderTotal.Name = "dgc_OrderTotal";

			// Order Placed Date Column
			dgc_OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgc_OrderDate.DataPropertyName = "OrderDate";
			dgc_OrderDate.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A" };
			dgc_OrderDate.FillWeight = 25F;
			dgc_OrderDate.HeaderText = "Ordered";
			dgc_OrderDate.MinimumWidth = 10;
			dgc_OrderDate.Name = "dgc_OrderDate";

			// Order Completed Date Column
			dgc_CompletedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgc_CompletedDate.DataPropertyName = "CompletedDate";
			dgc_CompletedDate.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A" };
			dgc_CompletedDate.FillWeight = 25F;
			dgc_CompletedDate.HeaderText = "Completed";
			dgc_CompletedDate.MinimumWidth = 10;
			dgc_CompletedDate.Name = "dgc_CompletedDate";

			Columns.AddRange([
				dgc_Selection,
				dgc_ID,
				dgc_CustomerName,
				dgc_ItemName,
				dgc_Quantity,
				dgc_OrderTotal,
				dgc_OrderDate,
				dgc_CompletedDate,
				dgc_Edit,
				dgc_Remove
			]);
		}
	}
}
