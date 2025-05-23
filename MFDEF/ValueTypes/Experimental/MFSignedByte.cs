using System;


namespace MFDEF.ValueTypes.Experimental
{

	public class MFSignedByte : IMFValue
	{

		public string? Designation { get; set; }

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public sbyte? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer with a value of 0.
		/// </summary>
		public MFSignedByte()
		{

			Value = 0;
			Designation = "SignedByte";

		}

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer.
		/// </summary>
		public MFSignedByte(sbyte value)
		{

			Value = value;
			Designation = "SignedByte";

		}

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer from another one of the same type.
		/// </summary>
		public MFSignedByte(MFSignedByte value)
		{

			Value = value.Value;
			Designation = "SignedByte";

		}

		/// <summary>
		/// Creates a MF's Define signed 8-bit Integer from a 32-bit integer.
		/// </summary>
		public MFSignedByte(int value)
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
		public static MFSignedByte operator ++(MFSignedByte a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFSignedByte operator --(MFSignedByte a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFSignedBytes as a MFSignedByte.
		/// </summary>
		public static MFSignedByte operator +(MFSignedByte a, MFSignedByte b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFSignedBytes as a MFSignedByte.
		/// </summary>
		public static MFSignedByte operator -(MFSignedByte a, MFSignedByte b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFSignedBytes as a MFSignedByte.
		/// </summary>
		public static MFSignedByte operator /(MFSignedByte a, MFSignedByte b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFSignedBytes as a MFSignedByte.
		/// </summary>
		public static MFSignedByte operator *(MFSignedByte a, MFSignedByte b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFSignedBytes as a MFSignedByte.
		/// </summary>
		public static MFSignedByte operator %(MFSignedByte a, MFSignedByte b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFSignedByte a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFSignedByte a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFSignedBytes equal?
		/// </summary>
		public static bool operator ==(MFSignedByte a, MFSignedByte b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFSignedBytes different?
		/// </summary>
		public static bool operator !=(MFSignedByte a, MFSignedByte b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFSignedBytes greater than the other?
		/// </summary>
		public static bool operator >(MFSignedByte a, MFSignedByte b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFSignedBytes lesser than the other?
		/// </summary>
		public static bool operator <(MFSignedByte a, MFSignedByte b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFSignedBytes greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFSignedByte a, MFSignedByte b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFSignedBytes lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFSignedByte a, MFSignedByte b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a signed byte.
		/// </summary>
		public override bool Equals(object? obj)
		{

			if (obj is MFSignedByte value)
			{

				return this == value;

			}

			if (obj is sbyte integer)
			{

				return Value == integer;

			}

			return false;

		}

		#endregion

	}

}
