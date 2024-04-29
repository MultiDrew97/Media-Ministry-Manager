﻿using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// The customer based database API calls
	/// </summary>
    public partial class CustomerDatabase
    {
        private const string path = "customers";

		/// <summary>
		/// Add a customer to the database
		/// </summary>
		/// <param name="customer"></param>
		public void AddCustomer(Types.Customer customer)
        {
            Execute(Method.Post, $"{path}", JSON.ConvertToJSON(customer));
        }

		/// <summary>
		/// Retrieves all customers from the database
		/// </summary>
		/// <returns></returns>
        public Types.CustomerCollection GetCustomers()
        {
            return ExecuteWithResult<Types.CustomerCollection>(Method.Get, $"{path}").Result;
        }

		/// <summary>
		/// Retrieves the specified customer from the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
        public Types.Customer GetCustomer(int customerID)
        {
            if (!Utils.ValidID(customerID))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            return ExecuteWithResult<Types.Customer>(Method.Get, $"{path}/{customerID}").Result;
        }

		/// <summary>
		/// Updates the info for a customer in the database
		/// </summary>
		/// <param name="customer"></param>
		public void UpdateCustomer(Types.Customer customer)
        {
            if (!Utils.ValidID(customer.Id))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            Execute(Method.Put, $"{path}/{customer.Id}", JSON.ConvertToJSON(customer));
        }

		/// <summary>
		/// Removes a customer from the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <exception cref="ArgumentException"></exception>
        public void RemoveCustomer(int customerID)
        {
            if (!Utils.ValidID(customerID))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            Execute(Method.Delete, $"{path}/{customerID}");
        }
    }
}
