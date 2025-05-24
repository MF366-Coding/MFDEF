using System;

using MFDEF.ValueTypes.Numerics;


namespace MFDEF.ValueTypes.Experimental
{

	/// <summary>
	/// Represents a MF's Define 8-bit integer.
	/// </summary>
	public class MFInt8 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new sbyte? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer with a value of 0.
		/// </summary>
		public MFInt8()
		{

			Value = 0;
			Designation = "SignedByte";

		}

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer.
		/// </summary>
		public MFInt8(sbyte value)
		{

			Value = value;
			Designation = "SignedByte";

		}

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer from another one of the same type.
		/// </summary>
		public MFInt8(MFInt8 value)
		{

			Value = value.Value;
			Designation = "SignedByte";

		}

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer from a 32-bit integer.
		/// </summary>
		public MFInt8(int value)
		{

			Value = Convert.ToSByte(value);
			Designation = "SignedByte";

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
		public static MFInt8 operator ++(MFInt8 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFInt8 operator --(MFInt8 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFInt8s as a MFInt8.
		/// </summary>
		public static MFInt8 operator +(MFInt8 a, MFInt8 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFInt8s as a MFInt8.
		/// </summary>
		public static MFInt8 operator -(MFInt8 a, MFInt8 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFInt8s as a MFInt8.
		/// </summary>
		public static MFInt8 operator /(MFInt8 a, MFInt8 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFInt8s as a MFInt8.
		/// </summary>
		public static MFInt8 operator *(MFInt8 a, MFInt8 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFInt8s as a MFInt8.
		/// </summary>
		public static MFInt8 operator %(MFInt8 a, MFInt8 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFInt8 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFInt8 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFInt8s equal?
		/// </summary>
		public static bool operator ==(MFInt8 a, MFInt8 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFInt8s different?
		/// </summary>
		public static bool operator !=(MFInt8 a, MFInt8 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFInt8s greater than the other?
		/// </summary>
		public static bool operator >(MFInt8 a, MFInt8 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFInt8s lesser than the other?
		/// </summary>
		public static bool operator <(MFInt8 a, MFInt8 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFInt8s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFInt8 a, MFInt8 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFInt8s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFInt8 a, MFInt8 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a signed byte.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFInt8 value ? this == value : obj is sbyte integer && Value == integer;

		}

		#endregion

	}

}
