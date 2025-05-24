using System;


namespace MFDEF.Parser
{

	/// <summary>
	/// Represents a MFDEF Parser Exception.
	/// </summary>
	public class ParserError : Exception
	{

		/// <summary>
		/// Creates a new instance of a parser error.
		/// </summary>
		public ParserError() : base() { }

		/// <summary>
		/// Creates a new instance of a parser error with a custom message.
		/// </summary>
		/// <param name="message">Custom message</param>
		public ParserError(string message) : base(message) { }

		/// <summary>
		/// Creates a new instance of a parser error with a custom error
		/// message and the exception that caused this error.
		/// </summary>
		/// <param name="message">Custom error message</param>
		/// <param name="innerException">The exception that caused this error</param>
		public ParserError(string? message, Exception? innerException) : base(message, innerException) { }

	}

}
