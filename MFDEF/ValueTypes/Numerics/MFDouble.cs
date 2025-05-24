namespace MFDEF.ValueTypes.Numerics
{

	/// <summary>
	/// Represents a MF's Define double-precision floating point.
	/// </summary>
	public class MFDouble : MFNumeric
	{

		/// <summary>
		/// The underlying double.
		/// </summary>
		public new double? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define double.
		/// </summary>
		public MFDouble()
		{

			Value = 0;
			Designation = "Double";

		}

		/// <summary>
		/// Creates a MF's Define double.
		/// </summary>
		public MFDouble(double value)
		{

			Value = value;
			Designation = "Double";

		}

		/// <summary>
		/// Creates a MF's Define double.
		/// </summary>
		public MFDouble(MFDouble value)
		{

			Value = value.Value;
			Designation = "Double";

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
		public static MFDouble operator ++(MFDouble a) => new((a.Value ?? 0) + 1);

		/// <summary>
		/// Decrements 1 unit.
		/// </summary>
		public static MFDouble operator --(MFDouble a) => new((a.Value ?? 0) - 1);

		/// <summary>
		/// Returns the sum of 2 MFDoubles as a MFDouble.
		/// </summary>
		public static MFDouble operator +(MFDouble a, MFDouble b) => new((a.Value ?? 0) + (b.Value ?? 0));

		/// <summary>
		/// Returns the difference of 2 MFDoubles as a MFDouble.
		/// </summary>
		public static MFDouble operator -(MFDouble a, MFDouble b) => new((a.Value ?? 0) - (b.Value ?? 0));

		/// <summary>
		/// Returns the division of 2 MFDoubles as a MFDouble.
		/// </summary>
		public static MFDouble operator /(MFDouble a, MFDouble b) => new((a.Value ?? 0) / (b.Value ?? 1)); // use 1 for the second number just to be safe

		/// <summary>
		/// Returns the product of 2 MFDoubles as a MFDouble.
		/// </summary>
		public static MFDouble operator *(MFDouble a, MFDouble b) => new((a.Value ?? 0) * (b.Value ?? 0));

		/// <summary>
		/// Returns the remainder of 2 MFDoubles as a MFDouble.
		/// </summary>
		public static MFDouble operator %(MFDouble a, MFDouble b) => new((a.Value ?? 0) % (b.Value ?? 0));

		#endregion

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFDouble a) => a.Value != 0 && a.Value is not null;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFDouble a) => a.Value == 0 || a.Value is null;

		/// <summary>
		/// Are 2 MFDoubles equal?
		/// </summary>
		public static bool operator ==(MFDouble a, MFDouble b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFDoubles different?
		/// </summary>
		public static bool operator !=(MFDouble a, MFDouble b) => a.Value != b.Value;

		/// <summary>
		/// Is one MFDoubles greater than the other?
		/// </summary>
		public static bool operator >(MFDouble a, MFDouble b) => a.Value > b.Value;

		/// <summary>
		/// Is one MFDoubles lesser than the other?
		/// </summary>
		public static bool operator <(MFDouble a, MFDouble b) => a.Value < b.Value;

		/// <summary>
		/// Is one MFDoubles greater or equal in relation to another one?
		/// </summary>
		public static bool operator >=(MFDouble a, MFDouble b) => a.Value >= b.Value;

		/// <summary>
		/// Is one MFDoubles lesser or equal in relation to another one?
		/// </summary>
		public static bool operator <=(MFDouble a, MFDouble b) => a.Value <= b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to an int.
		/// </summary>
		public override bool Equals(object? obj)
		{

			return obj is MFDouble value ? this == value : obj is double integer && Value == integer;

		}

		#endregion

	}

}
