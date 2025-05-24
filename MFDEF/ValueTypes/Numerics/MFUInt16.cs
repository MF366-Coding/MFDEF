using System;


namespace MFDEF.ValueTypes.Numerics
{

	/// <summary>
	/// Represents a MF's Define unsigned 16-bit integer.
	/// </summary>
	public class MFUInt16 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new ushort? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define unsigned 16-bit Integer with a value of 0.
		/// </summary>
		public MFUInt16()
		{

			Value = 0;
			Designation = "UInt16";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 16-bit Integer.
		/// </summary>
		public MFUInt16(ushort value)
		{

			Value = value;
			Designation = "UInt16";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 16-bit Integer from another one of the same type.
		/// </summary>
		public MFUInt16(MFUInt16 value)
		{

			Value = value.Value;
			Designation = "UInt16";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 16-bit Integer from a 32-bit integer.
		/// </summary>
		public MFUInt16(int value)
		{

			Value = Convert.ToUInt16(value);
			Designation = "UInt16";

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
		public static MFUInt16 operator ++(MFUInt16 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFUInt16 operator --(MFUInt16 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFUInt16s as a MFUInt16.
		/// </summary>
		public static MFUInt16 operator +(MFUInt16 a, MFUInt16 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFUInt16s as a MFUInt16.
		/// </summary>
		public static MFUInt16 operator -(MFUInt16 a, MFUInt16 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFUInt16s as a MFUInt16.
		/// </summary>
		public static MFUInt16 operator /(MFUInt16 a, MFUInt16 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFUInt16s as a MFUInt16.
		/// </summary>
		public static MFUInt16 operator *(MFUInt16 a, MFUInt16 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFUInt16s as a MFUInt16.
		/// </summary>
		public static MFUInt16 operator %(MFUInt16 a, MFUInt16 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFUInt16 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFUInt16 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFUInt16s equal?
		/// </summary>
		public static bool operator ==(MFUInt16 a, MFUInt16 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFUInt16s different?
		/// </summary>
		public static bool operator !=(MFUInt16 a, MFUInt16 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFUInt16s greater than the other?
		/// </summary>
		public static bool operator >(MFUInt16 a, MFUInt16 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFUInt16s lesser than the other?
		/// </summary>
		public static bool operator <(MFUInt16 a, MFUInt16 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFUInt16s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFUInt16 a, MFUInt16 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFUInt16s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFUInt16 a, MFUInt16 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an unsigned short int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFUInt16 value ? this == value : obj is ushort integer && Value == integer;

		}

		#endregion

	}

}
