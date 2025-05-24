using System;


namespace MFDEF.ValueTypes.Numerics
{

	/// <summary>
	/// Represents a MF's Define byte - unsigned 8-bit integer.
	/// </summary>
	public class MFUInt8 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new byte? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define unsigned 8-bit Integer with a value of 0.
		/// </summary>
		public MFUInt8()
		{

			Value = 0;
			Designation = "Int8";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 8-bit Integer.
		/// </summary>
		public MFUInt8(byte value)
		{

			Value = value;
			Designation = "Int8";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 8-bit Integer from another one of the same type.
		/// </summary>
		public MFUInt8(MFUInt8 value)
		{

			Value = value.Value;
			Designation = "Int8";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 8-bit Integer from a 32-bit integer.
		/// </summary>
		public MFUInt8(int value)
		{

			Value = Convert.ToByte(value);
			Designation = "Int8";

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
		public static MFUInt8 operator ++(MFUInt8 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFUInt8 operator --(MFUInt8 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFUInt8s as a MFUInt8.
		/// </summary>
		public static MFUInt8 operator +(MFUInt8 a, MFUInt8 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFUInt8s as a MFUInt8.
		/// </summary>
		public static MFUInt8 operator -(MFUInt8 a, MFUInt8 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFUInt8s as a MFUInt8.
		/// </summary>
		public static MFUInt8 operator /(MFUInt8 a, MFUInt8 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFUInt8s as a MFUInt8.
		/// </summary>
		public static MFUInt8 operator *(MFUInt8 a, MFUInt8 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFUInt8s as a MFUInt8.
		/// </summary>
		public static MFUInt8 operator %(MFUInt8 a, MFUInt8 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFUInt8 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFUInt8 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFUInt8s equal?
		/// </summary>
		public static bool operator ==(MFUInt8 a, MFUInt8 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFUInt8s different?
		/// </summary>
		public static bool operator !=(MFUInt8 a, MFUInt8 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFUInt8s greater than the other?
		/// </summary>
		public static bool operator >(MFUInt8 a, MFUInt8 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFUInt8s lesser than the other?
		/// </summary>
		public static bool operator <(MFUInt8 a, MFUInt8 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFUInt8s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFUInt8 a, MFUInt8 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFUInt8s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFUInt8 a, MFUInt8 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a byte.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return
				obj is MFUInt8 value ? // is the object another MFUInt8
					this == value // if true, is this class equals to the other
					: obj is byte integer && Value == integer; // if false, then this must be a byte and the values must match
			// otherwise, false

		}

		#endregion

	}

}
