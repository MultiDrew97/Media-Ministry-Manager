﻿using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception that occurs when there is an error creating an entry for the database
	/// </summary>
    [Serializable]
    public class CreationException : DatabaseException
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public CreationException() : base()
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
        public CreationException(string message) : base(message)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public CreationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
