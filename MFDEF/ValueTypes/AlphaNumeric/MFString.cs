using System;
using System.ComponentModel.DataAnnotations;
using MFDEF.ValueTypes.Numerics;


namespace MFDEF.ValueTypes.AlphaNumeric
{

	/// <summary>
	/// Represents a MF's Define UTF-16 encoded string.
	/// </summary>
	public class MFString : IMFValue
	{

		/// <summary>
		/// String.
		/// </summary>
		public string? Designation { get; set; }

		/// <summary>
		/// The underlying string.
		/// </summary>
		public string? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define empty string.
		/// </summary>
		public MFString()
		{

			Value = "";
			Designation = "String";

		}

		/// <summary>
		/// Creates a MF's Define string.
		/// </summary>
		public MFString(string? value)
		{

			Value = value;
			Designation = "String";

		}

		/// <summary>
		/// Creates a MF's Define string from another one of the same type.
		/// </summary>
		public MFString(MFString value)
		{

			Value = value.Value;
			Designation = "String";

		}

		/// <summary>
		/// Gets the hash code of this object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{

			return base.GetHashCode();

		}

		/// <summary>
		/// Returns the length of the string.
		/// 0 if the string is null or empty.
		/// </summary>
		public int Length
		{

			get => (Value?.Length ?? 0);

		}

		#region Mathematical Operators

		/// <summary>
		/// Returns the sum of 2 MFStrings as a MFInt128.
		/// </summary>
		public static MFString operator +(MFString a, MFString b) => new((a.Value ?? "") + (b.Value ?? ""));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and empty string?
		/// </summary>
		public static bool operator true(MFString a) => a.Value != "" && a.Value is not null;

		/// <summary>
		/// Is the value null or empty string?
		/// </summary>
		public static bool operator false(MFString a) => a.Value == "" || a.Value is null;

		/// <summary>
		/// Are 2 MFStrings equal?
		/// </summary>
		public static bool operator ==(MFString a, MFString b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFStrings different?
		/// </summary>
		public static bool operator !=(MFString a, MFString b) => a.Value != b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a string.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFString value ?
				this == value
				: obj is string integer && Value == integer;

		}

		#endregion

	}

}
