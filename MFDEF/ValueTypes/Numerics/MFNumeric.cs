namespace MFDEF.ValueTypes.Numerics
{

	/// <summary>
	/// Represents a MF's Define numeric value.
	/// </summary>
	public abstract class MFNumeric : IMFValue
	{

		/// <summary>
		/// The underlying value.
		/// </summary>
		public virtual object? Value { get; set; }

		/// <summary>
		/// Each numeric value implements their own designation.
		/// </summary>
		public virtual string? Designation { get; set; }

		/// <summary>
		/// Returns this value's hash code.
		/// 0 if the current value is null.
		/// </summary>
		/// <returns>The underlying value's hash code</returns>
		public override int GetHashCode()
		{

			return Value is null ? 0 : Value.GetHashCode();

		}

		#region Mathematical Operators

#pragma warning disable IDE0060

		/// <summary>
		/// Increments 1 unit.
		/// </summary>
		public static MFNumeric operator ++(MFNumeric a) => a;

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFNumeric operator --(MFNumeric a) => a;

		/// <summary>
		/// Returns the sum of 2 MFNumerics as a MFNumeric.
		/// </summary>
		public static MFNumeric operator +(MFNumeric a, MFNumeric b) => a;

		/// <summary>
		/// Returns the difference of 2 MFNumerics as a MFNumeric.
		/// </summary>
		public static MFNumeric operator -(MFNumeric a, MFNumeric b) => a;

		/// <summary>
		/// Returns the division of 2 MFNumerics as a MFNumeric.
		/// </summary>
		public static MFNumeric operator /(MFNumeric a, MFNumeric b) => a; // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFNumerics as a MFNumeric.
		/// </summary>
		public static MFNumeric operator *(MFNumeric a, MFNumeric b) => a;

		/// <summary>
		/// Returns the remainder of 2 MFNumerics as a MFNumeric.
		/// </summary>
		public static MFNumeric operator %(MFNumeric a, MFNumeric b) => a;

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFNumeric a) => false;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFNumeric a) => false;

		/// <summary>
		/// Are 2 MFNumerics equal?
		/// </summary>
		public static bool operator ==(MFNumeric a, MFNumeric b) => false;

		/// <summary>
		/// Are 2 MFNumerics different?
		/// </summary>
		public static bool operator !=(MFNumeric a, MFNumeric b) => false;

		/// <summary>
		/// Is one MFNumerics greater than the other?
		/// </summary>
		public static bool operator >(MFNumeric a, MFNumeric b) => false;

		/// <summary>
		/// Is one MFNumerics lesser than the other?
		/// </summary>
		public static bool operator <(MFNumeric a, MFNumeric b) => false;

		/// <summary>
		/// Is one MFNumerics greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFNumeric a, MFNumeric b) => false;

		/// <summary>
		/// Is one MFNumerics lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFNumeric a, MFNumeric b) => false;

		/// <summary>
		/// Checks if this instance is equals to another one or to a short int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return false;

		}

#pragma warning restore IDE0060

		#endregion

	}

}
