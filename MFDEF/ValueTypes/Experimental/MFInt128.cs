using System;

using MFDEF.ValueTypes.Numerics;


namespace MFDEF.ValueTypes.Experimental
{

	/// <summary>
	/// Represents a MF's Define 128-bit integer.
	/// </summary>
	public class MFInt128 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new Int128? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define signed 128-bit Integer with a value of 0.
		/// </summary>
		public MFInt128()
		{

			Value = 0;
			Designation = "Int128";

		}

		/// <summary>
		/// Creates a MF's Define signed 128-bit Integer.
		/// </summary>
		public MFInt128(Int128 value)
		{

			Value = value;
			Designation = "Int128";

		}

		/// <summary>
		/// Creates a MF's Define signed 128-bit Integer from another one of the same type.
		/// </summary>
		public MFInt128(MFInt128 value)
		{

			Value = value.Value;
			Designation = "Int128";

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
		public static MFInt128 operator ++(MFInt128 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFInt128 operator --(MFInt128 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFInt128s as a MFInt128.
		/// </summary>
		public static MFInt128 operator +(MFInt128 a, MFInt128 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFInt128s as a MFInt128.
		/// </summary>
		public static MFInt128 operator -(MFInt128 a, MFInt128 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFInt128s as a MFInt128.
		/// </summary>
		public static MFInt128 operator /(MFInt128 a, MFInt128 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFInt128s as a MFInt128.
		/// </summary>
		public static MFInt128 operator *(MFInt128 a, MFInt128 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFInt128s as a MFInt128.
		/// </summary>
		public static MFInt128 operator %(MFInt128 a, MFInt128 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFInt128 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFInt128 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFInt128s equal?
		/// </summary>
		public static bool operator ==(MFInt128 a, MFInt128 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFInt128s different?
		/// </summary>
		public static bool operator !=(MFInt128 a, MFInt128 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFInt128s greater than the other?
		/// </summary>
		public static bool operator >(MFInt128 a, MFInt128 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFInt128s lesser than the other?
		/// </summary>
		public static bool operator <(MFInt128 a, MFInt128 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFInt128s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFInt128 a, MFInt128 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFInt128s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFInt128 a, MFInt128 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an Int128.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFInt128 value ? this == value : obj is Int128 integer && Value == integer;

		}

		#endregion

	}

}
