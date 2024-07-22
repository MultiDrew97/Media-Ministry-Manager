﻿namespace SPPBC.M3Tools
{
	/// <summary>
	/// A control that displays a list of customers in a combo box
	/// </summary>
	public partial class CustomersComboBox
	{
		/// <summary>
		/// 
		/// </summary>
		public Types.CustomerCollection Customers
		{
			set
			{
				foreach (Types.Customer item in value)
				{
					_ = bsCustomers.Add(item);
				}
			}
		}

		/// <summary>
		/// The currently selected customer
		/// </summary>
		public Types.Customer SelectedItem => (Types.Customer)cbx_Items.SelectedItem;

		/// <summary>
		/// The index in the list for the currently selected customer
		/// </summary>
		public int SelectedIndex => cbx_Items.SelectedIndex;

		/// <summary>
		/// 
		/// </summary>
		public object SelectedValue
		{
			get => cbx_Items.SelectedValue;
			set
			{
				if (value is null)
				{
					return;
				}

				cbx_Items.SelectedValue = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public CustomersComboBox()
		{
			InitializeComponent();
		}
	}
}
