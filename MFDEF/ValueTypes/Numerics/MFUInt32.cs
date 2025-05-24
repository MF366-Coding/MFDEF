namespace MFDEF.ValueTypes.Numerics
{

	/// <summary>
	/// Represents a MF's Define unsigned 32-bit integer.
	/// </summary>
	public class MFUInt32 : MFNumeric
	{

		/// <summary>
		/// The underlying integer.
		/// </summary>
		public new uint? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define Unsigned 32-bit Integer with a value of 0.
		/// </summary>
		public MFUInt32()
		{

			Value = 0;
			Designation = "UInt32";

		}

		/// <summary>
		/// Creates a MF's Define Unsigned 32-bit Integer.
		/// </summary>
		public MFUInt32(uint value)
		{

			Value = value;
			Designation = "UInt32";

		}

		/// <summary>
		/// Creates a MF's Define Unsigned 32-bit Integer from another one of the same type.
		/// </summary>
		public MFUInt32(MFUInt32 value)
		{

			Value = value.Value;
			Designation = "UInt32";

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
		public static MFUInt32 operator ++(MFUInt32 a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFUInt32 operator --(MFUInt32 a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFUInt32s as a MFUInt32.
		/// </summary>
		public static MFUInt32 operator +(MFUInt32 a, MFUInt32 b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFUInt32s as a MFUInt32.
		/// </summary>
		public static MFUInt32 operator -(MFUInt32 a, MFUInt32 b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFUInt32s as a MFUInt32.
		/// </summary>
		public static MFUInt32 operator /(MFUInt32 a, MFUInt32 b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFUInt32s as a MFUInt32.
		/// </summary>
		public static MFUInt32 operator *(MFUInt32 a, MFUInt32 b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFUInt32s as a MFUInt32.
		/// </summary>
		public static MFUInt32 operator %(MFUInt32 a, MFUInt32 b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFUInt32 a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFUInt32 a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFUInt32s equal?
		/// </summary>
		public static bool operator ==(MFUInt32 a, MFUInt32 b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFUInt32s different?
		/// </summary>
		public static bool operator !=(MFUInt32 a, MFUInt32 b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFUInt32s greater than the other?
		/// </summary>
		public static bool operator >(MFUInt32 a, MFUInt32 b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFUInt32s lesser than the other?
		/// </summary>
		public static bool operator <(MFUInt32 a, MFUInt32 b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFUInt32s greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFUInt32 a, MFUInt32 b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFUInt32s lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFUInt32 a, MFUInt32 b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an uint.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFUInt32 value ?
				this == value
				: obj is uint integer && Value == integer;

		}

		#endregion

	}

}
