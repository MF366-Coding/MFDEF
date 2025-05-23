using System;


namespace MFDEF.ValueTypes.Numerics
{

	public class MFInt64 : IMFValue
	{

		public string? Designation { get; set; }

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public long? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define signed 64-bit Integer with a value of 0.
		/// </summary>
		public MFInt64()
		{

			Value = 0;
			Designation = "Int64";

		}

		/// <summary>
		/// Creates a MF's Define signed 64-bit Integer.
		/// </summary>
		public MFInt64(long value)
		{

			Value = value;
			Designation = "Int64";

		}

		/// <summary>
		/// Creates a MF's Define signed 64-bit Integer from another one of the same type.
		/// </summary>
		public MFInt64(MFInt64 value)
		{

			Value = value.Value;
			Designation = "Int64";

		}

		/// <summary>
		/// Creates a MF's Define signed 64-bit Integer from a 32-bit integer.
		/// </summary>
		public MFInt64(int value)
		{

			Value = Convert.ToInt64(value);
			Designation = "Int64";

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
		public static MFInt64 operator ++(MFInt64 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFInt64 operator --(MFInt64 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFInt64s as a MFInt64.
		/// </summary>
		public static MFInt64 operator +(MFInt64 a, MFInt64 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFInt64s as a MFInt64.
		/// </summary>
		public static MFInt64 operator -(MFInt64 a, MFInt64 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFInt64s as a MFInt64.
		/// </summary>
		public static MFInt64 operator /(MFInt64 a, MFInt64 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFInt64s as a MFInt64.
		/// </summary>
		public static MFInt64 operator *(MFInt64 a, MFInt64 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFInt64s as a MFInt64.
		/// </summary>
		public static MFInt64 operator %(MFInt64 a, MFInt64 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFInt64 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFInt64 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFInt64s equal?
		/// </summary>
		public static bool operator ==(MFInt64 a, MFInt64 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFInt64s different?
		/// </summary>
		public static bool operator !=(MFInt64 a, MFInt64 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFInt64s greater than the other?
		/// </summary>
		public static bool operator >(MFInt64 a, MFInt64 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFInt64s lesser than the other?
		/// </summary>
		public static bool operator <(MFInt64 a, MFInt64 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFInt64s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFInt64 a, MFInt64 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFInt64s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFInt64 a, MFInt64 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a long int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			if (obj is MFInt64 value)
			{

				return this == value;

			}

			if (obj is long integer)
			{

				return Value == integer;

			}

			return false;

		}

		#endregion

	}

}
