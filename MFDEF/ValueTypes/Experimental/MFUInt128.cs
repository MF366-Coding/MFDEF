using System;

using MFDEF.ValueTypes.Numerics;


namespace MFDEF.ValueTypes.Experimental
{

	/// <summary>
	/// Represents an experimental MF's Define unsigned 128-bit integer.
	/// </summary>
	public class MFUInt128 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new UInt128? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define unsigned 128-bit Integer with a value of 0.
		/// </summary>
		public MFUInt128()
		{

			Value = 0;
			Designation = "UInt128";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 128-bit Integer.
		/// </summary>
		public MFUInt128(UInt128 value)
		{

			Value = value;
			Designation = "UInt128";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 128-bit Integer from another one of the same type.
		/// </summary>
		public MFUInt128(MFUInt128 value)
		{

			Value = value.Value;
			Designation = "UInt128";

		}

		/// <summary>
		/// Gets the hash code of this object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{

			return base.GetHashCode();

		}

		#region Mathematical Operators

		/// <summary>
		/// Increments 1 unit.
		/// </summary>
		public static MFUInt128 operator ++(MFUInt128 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFUInt128 operator --(MFUInt128 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFUInt128s as a MFUInt128.
		/// </summary>
		public static MFUInt128 operator +(MFUInt128 a, MFUInt128 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFUInt128s as a MFUInt128.
		/// </summary>
		public static MFUInt128 operator -(MFUInt128 a, MFUInt128 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFUInt128s as a MFUInt128.
		/// </summary>
		public static MFUInt128 operator /(MFUInt128 a, MFUInt128 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFUInt128s as a MFUInt128.
		/// </summary>
		public static MFUInt128 operator *(MFUInt128 a, MFUInt128 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFUInt128s as a MFUInt128.
		/// </summary>
		public static MFUInt128 operator %(MFUInt128 a, MFUInt128 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFUInt128 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFUInt128 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFUInt128s equal?
		/// </summary>
		public static bool operator ==(MFUInt128 a, MFUInt128 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFUInt128s different?
		/// </summary>
		public static bool operator !=(MFUInt128 a, MFUInt128 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFUInt128s greater than the other?
		/// </summary>
		public static bool operator >(MFUInt128 a, MFUInt128 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFUInt128s lesser than the other?
		/// </summary>
		public static bool operator <(MFUInt128 a, MFUInt128 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFUInt128s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFUInt128 a, MFUInt128 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFUInt128s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFUInt128 a, MFUInt128 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an UInt128.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFUInt128 value ? this == value : obj is UInt128 integer && Value == integer;

		}

		#endregion

	}

}
