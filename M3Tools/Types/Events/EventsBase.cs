﻿using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Events
{
	//public delegate void RemoveEventHandler(object sender, BulkActionEventArgs e);
	//public delegate void AddEventHandler(object sender, BulkActionEventArgs e);
	//public delegate void EditEventHandler(object sender, BulkActionEventArgs e);

	/// <summary>
	/// The base event handler for data events
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void DataEventHandler<T>(object sender, DataEventArgs<T> e);

	/// <summary>
	/// When a remove rows event occurs
	/// </summary>
	public delegate void RemoveRowsEventHandler();

	/// <summary>
	/// When a send email event occurs
	/// </summary>
	public delegate void SendEmailsEventHandler();

	/// <summary>
	/// When a edit selected rows event occurs
	/// </summary>
	public delegate void EditSelectedEventHandler();

	/// <summary>
	/// When a manage button is clicked
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void ManageEventHandler(object sender, ManageEventArgs e);

	/// <summary>
	/// The argument values for the event that occured
	/// </summary>
	/// <typeparam name="T">The type of the data being modified</typeparam>
	public class DataEventArgs<T> : BaseDataEventArgs
	{
		/*/// <summary>
		/// The row of the data being modified
		/// </summary>
		protected DataGridViewRow Row { get; }*/

		/// <summary>
		/// The value of the data being modified
		/// </summary>
		public virtual T Value { get; protected set; }

		/// <summary>
		/// Create a new event arguments value
		/// </summary>
		/// <param name="value">The value being modified</param>
		/// <param name="type">The type of event occuring</param>
		public DataEventArgs(T value, EventType type = EventType.None) : base()
		{
			Value = value;
			EventType = type;
		}

		/// <summary>
		/// Creates a DataEventArgs object using the provided values
		/// </summary>
		/// <param name="value">The value being modified</param>
		/// <param name="type">The type of modificaiton occuring</param>
		/// <returns></returns>
		public static DataEventArgs<T> Parse(T value, EventType type)
		{
			Console.WriteLine(value.GetType());
			
			return new(value, type);
		}
	}

	public class ManageEventArgs : EventArgs
	{
		/// <summary>
		/// What management window to open
		/// </summary>
		public ManageType Manage { get; protected set;}

		public ManageEventArgs(ManageType manage) : base()
		{
			Manage = manage;
		}
	}

	/// <summary>
	/// Base class for all event args
	/// </summary>
	public abstract class BaseDataEventArgs : EventArgs
    {
		/// <summary>
		/// The type of even that occured
		/// </summary>
		public EventType EventType { get; protected set; }
	}

    //public class BulkActionEventArgs : BaseArgs
    //{

    //    public IList List { get; set; }

    //    public BulkActionEventArgs(IList list, EventType eventType = EventType.None)
    //    {
    //        List = list;
    //        EventType = eventType;
    //    }
    //}

	/// <summary>
	/// The types of events that can occur for data entries
	/// </summary>
    public enum EventType
    {
		/// <summary>
		/// No specific event has occured
		/// </summary>
        None,
		/// <summary>
		/// When an entry is added
		/// </summary>
        Added,
		/// <summary>
		/// When an entry is removed
		/// </summary>
        Removed,
		/// <summary>
		/// When an entry is updated
		/// </summary>
        Updated
    }

	/// <summary>
	/// What type of management window is desired to be opened
	/// </summary>
	public enum ManageType
	{
		/// <summary>
		/// No window needs to open
		/// </summary>
		None,
		/// <summary>
		/// Manage customers
		/// </summary>
		Customers,
		/// <summary>
		/// Manage listeners
		/// </summary>
		Listeners,
		/// <summary>
		/// Manage orders
		/// </summary>
		Orders,
		/// <summary>
		/// Manage inventory
		/// </summary>
		Inventory
	}
}