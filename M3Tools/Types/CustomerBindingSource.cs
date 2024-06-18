﻿using System.Collections.Generic;
using System.ComponentModel;
using NPOI.SS.Formula.Functions;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class CustomerBindingSource : BindingSource<Types.Customer>
    {
		private readonly string CustomerFilter = "Name LIKE '%{0}%'";

		/// <summary>
		/// 
		/// </summary>
		public CustomerBindingSource() : base()
		{
			DataSource = new();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public new Types.CustomerCollection DataSource
		{
			get => (Types.CustomerCollection)base.DataSource;
			set => base.DataSource = value;
		}

		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = string.Format(CustomerFilter, value);
		}
	}
}
