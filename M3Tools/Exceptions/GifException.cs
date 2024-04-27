﻿using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to GIF operations
	/// </summary>
    [Serializable]
    public class GifException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
        public GifException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public GifException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public GifException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
