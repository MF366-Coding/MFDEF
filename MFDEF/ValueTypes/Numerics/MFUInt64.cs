using System;


namespace MFDEF.ValueTypes.Numerics
{

	public class MFUInt64 : IMFValue
	{

		public string? Designation { get; set; }

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public ulong? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define unsigned 64-bit Integer with a value of 0.
		/// </summary>
		public MFUInt64()
		{

			Value = 0;
			Designation = "UInt64";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 64-bit Integer.
		/// </summary>
		public MFUInt64(ulong value)
		{

			Value = value;
			Designation = "UInt64";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 64-bit Integer from another one of the same type.
		/// </summary>
		public MFUInt64(MFUInt64 value)
		{

			Value = value.Value;
			Designation = "UInt64";

		}

		/// <summary>
		/// Creates a MF's Define unsigned 64-bit Integer from a 32-bit integer.
		/// </summary>
		public MFUInt64(int value)
		{

			Value = Convert.ToUInt64(value);
			Designation = "UInt64";

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
		public static MFUInt64 operator ++(MFUInt64 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFUInt64 operator --(MFUInt64 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFUInt64s as a MFUInt64.
		/// </summary>
		public static MFUInt64 operator +(MFUInt64 a, MFUInt64 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFUInt64s as a MFUInt64.
		/// </summary>
		public static MFUInt64 operator -(MFUInt64 a, MFUInt64 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFUInt64s as a MFUInt64.
		/// </summary>
		public static MFUInt64 operator /(MFUInt64 a, MFUInt64 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFUInt64s as a MFUInt64.
		/// </summary>
		public static MFUInt64 operator *(MFUInt64 a, MFUInt64 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFUInt64s as a MFUInt64.
		/// </summary>
		public static MFUInt64 operator %(MFUInt64 a, MFUInt64 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFUInt64 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFUInt64 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFUInt64s equal?
		/// </summary>
		public static bool operator ==(MFUInt64 a, MFUInt64 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFUInt64s different?
		/// </summary>
		public static bool operator !=(MFUInt64 a, MFUInt64 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFUInt64s greater than the other?
		/// </summary>
		public static bool operator >(MFUInt64 a, MFUInt64 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFUInt64s lesser than the other?
		/// </summary>
		public static bool operator <(MFUInt64 a, MFUInt64 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFUInt64s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFUInt64 a, MFUInt64 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFUInt64s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFUInt64 a, MFUInt64 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an unsigned long int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			if (obj is MFUInt64 value)
			{

				return this == value;

			}

			if (obj is ulong integer)
			{

				return Value == integer;

			}

			return false;

		}

		#endregion

	}

}
