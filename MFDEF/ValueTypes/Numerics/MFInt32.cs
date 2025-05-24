namespace MFDEF.ValueTypes.Numerics
{

	/// <summary>
	/// Represents a MF's Define 32-bit integer.
	/// </summary>
	public class MFInt32 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new int? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define signed 32-bit Integer with a value of 0.
		/// </summary>
		public MFInt32()
		{

			Value = 0;
			Designation = "Int32";

		}

		/// <summary>
		/// Creates a MF's Define signed 32-bit Integer.
		/// </summary>
		public MFInt32(int value)
		{

			Value = value;
			Designation = "Int32";

		}

		/// <summary>
		/// Creates a MF's Define signed 32-bit Integer from another one of the same type.
		/// </summary>
		public MFInt32(MFInt32 value)
		{

			Value = value.Value;
			Designation = "Int32";

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
		public static MFInt32 operator ++(MFInt32 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFInt32 operator --(MFInt32 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFInt32s as a MFInt32.
		/// </summary>
		public static MFInt32 operator +(MFInt32 a, MFInt32 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFInt32s as a MFInt32.
		/// </summary>
		public static MFInt32 operator -(MFInt32 a, MFInt32 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFInt32s as a MFInt32.
		/// </summary>
		public static MFInt32 operator /(MFInt32 a, MFInt32 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFInt32s as a MFInt32.
		/// </summary>
		public static MFInt32 operator *(MFInt32 a, MFInt32 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFInt32s as a MFInt32.
		/// </summary>
		public static MFInt32 operator %(MFInt32 a, MFInt32 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFInt32 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFInt32 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFInt32s equal?
		/// </summary>
		public static bool operator ==(MFInt32 a, MFInt32 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFInt32s different?
		/// </summary>
		public static bool operator !=(MFInt32 a, MFInt32 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFInt32s greater than the other?
		/// </summary>
		public static bool operator >(MFInt32 a, MFInt32 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFInt32s lesser than the other?
		/// </summary>
		public static bool operator <(MFInt32 a, MFInt32 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFInt32s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFInt32 a, MFInt32 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFInt32s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFInt32 a, MFInt32 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFInt32 value ?
				this == value
				: obj is int integer && Value == integer;

		}

		#endregion

	}

}
