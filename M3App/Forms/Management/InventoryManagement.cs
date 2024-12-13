﻿using System;
using System.Windows.Forms;

using SPPBC.M3Tools.Events.Inventory;

namespace M3App
{
	/// <summary>
	/// Form for managing inventory
	/// </summary>
	public partial class InventoryManagement
	{
		/// <summary>
		/// 
		/// </summary>
		public InventoryManagement() : base()
		{
			InitializeComponent();

			idg_Inventory.Reload += new EventHandler(Reload);
			idg_Inventory.AddProduct += new InventoryEventHandler(Add);
			idg_Inventory.UpdateProduct += new InventoryEventHandler(Update);
			idg_Inventory.RemoveProduct += new InventoryEventHandler(Remove);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override async void Reload(object sender, EventArgs e)
		{
			base.Reload(sender, e);
			_original = await dbInventory.GetProducts();
			idg_Inventory.Inventory = SPPBC.M3Tools.Types.InventoryCollection.Cast(_original.Items);
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, idg_Inventory.Inventory.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
			base.Add(sender, e);
			using AddProductDialog @add = new();

			if (add.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			_ = dbInventory.AddInventory(add.Product);
			_ = MessageBox.Show($"Successfully added {add.Product.Name}", "Successful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Product> e)
		{
			base.Update(sender, e);
			using SPPBC.M3Tools.Dialogs.EditProductDialog @edit = new(e.Value);

			if (edit.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			_ = dbInventory.UpdateProduct(edit.Product);
			_ = MessageBox.Show($"Successfully updated {e.Value.Name}", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Product> e)
		{
			base.Remove(sender, e);
			_ = dbInventory.RemoveProduct(e.Value.Id);
			_ = MessageBox.Show($"Successfully removed {e.Value.Name}", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected override void FilterChanged(object sender, string filter)
		{
			base.FilterChanged(sender, filter);

			idg_Inventory.Inventory = SPPBC.M3Tools.Types.InventoryCollection.Cast(_original.Items);

			AssessLabel();
		}
	}
}