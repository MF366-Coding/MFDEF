using System;


namespace MFDEF.ValueTypes.Numerics
{

	public class MFInt16 : IMFValue
	{

		public string? Designation { get; set; }

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public short? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define signed 16-bit Integer with a value of 0.
		/// </summary>
		public MFInt16()
		{

			Value = 0;
			Designation = "Int16";

		}

		/// <summary>
		/// Creates a MF's Define signed 16-bit Integer.
		/// </summary>
		public MFInt16(short value)
		{

			Value = value;
			Designation = "Int16";

		}

		/// <summary>
		/// Creates a MF's Define signed 16-bit Integer from another one of the same type.
		/// </summary>
		public MFInt16(MFInt16 value)
		{

			Value = value.Value;
			Designation = "Int16";

		}

		/// <summary>
		/// Creates a MF's Define signed 16-bit Integer from a 32-bit integer.
		/// </summary>
		public MFInt16(int value)
		{

			Value = Convert.ToInt16(value);
			Designation = "Int16";

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
		public static MFInt16 operator ++(MFInt16 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFInt16 operator --(MFInt16 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFInt16s as a MFInt16.
		/// </summary>
		public static MFInt16 operator +(MFInt16 a, MFInt16 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFInt16s as a MFInt16.
		/// </summary>
		public static MFInt16 operator -(MFInt16 a, MFInt16 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFInt16s as a MFInt16.
		/// </summary>
		public static MFInt16 operator /(MFInt16 a, MFInt16 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFInt16s as a MFInt16.
		/// </summary>
		public static MFInt16 operator *(MFInt16 a, MFInt16 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFInt16s as a MFInt16.
		/// </summary>
		public static MFInt16 operator %(MFInt16 a, MFInt16 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFInt16 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFInt16 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFInt16s equal?
		/// </summary>
		public static bool operator ==(MFInt16 a, MFInt16 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFInt16s different?
		/// </summary>
		public static bool operator !=(MFInt16 a, MFInt16 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFInt16s greater than the other?
		/// </summary>
		public static bool operator >(MFInt16 a, MFInt16 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFInt16s lesser than the other?
		/// </summary>
		public static bool operator <(MFInt16 a, MFInt16 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFInt16s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFInt16 a, MFInt16 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFInt16s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFInt16 a, MFInt16 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a short int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			if (obj is MFInt16 value)
			{

				return this == value;

			}

			if (obj is short integer)
			{

				return Value == integer;

			}

			return false;

		}

		#endregion

	}

}
