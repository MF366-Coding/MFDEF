using System;


namespace MFDEF.ValueTypes.Numerics
{

	public class MFBool : IMFValue
	{

		public string? Designation { get; set; }

		/// <summary>
		/// The underlying boolean.
		/// </summary>
		public bool? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define boolean with a value of false.
		/// </summary>
		public MFBool()
		{

			Value = false;
			Designation = "Bool";

		}

		/// <summary>
		/// Creates a MF's Define boolean.
		/// </summary>
		public MFBool(bool value)
		{

			Value = value;
			Designation = "Bool";

		}

		/// <summary>
		/// Creates a MF's Define boolean from another one of the same type.
		/// </summary>
		public MFBool(MFBool value)
		{

			Value = value.Value;
			Designation = "Bool";

		}

		/// <summary>
		/// Creates a MF's Define from a 32-bit integer.
		/// </summary>
		public MFBool(int value)
		{

			Value = Convert.ToBoolean(value);
			Designation = "Bool";

		}

		/// <summary>
		/// Gets the hash code of this object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{

			return base.GetHashCode();

		}

		#region Logical Operators

		/// <summary>
		/// Is the value anything else but null and 0?
		/// </summary>
		public static bool operator true(MFBool a) => a.Value == true;

		/// <summary>
		/// Is the value null or 0?
		/// </summary>
		public static bool operator false(MFBool a) => a.Value == false || a.Value is null;

		/// <summary>
		/// Are 2 MFBools equal?
		/// </summary>
		public static bool operator ==(MFBool a, MFBool b) => a.Value == b.Value;

		/// <summary>
		/// Are 2 MFBools different?
		/// </summary>
		public static bool operator !=(MFBool a, MFBool b) => a.Value != b.Value;

		/// <summary>
		/// Checks if this instance is equals to another one or to a boolean.
		/// </summary>
		public override bool Equals(object? obj)
		{

			if (obj is MFBool value)
			{

				return this == value;

			}

			if (obj is bool integer)
			{

				return Value == integer;

			}

			return false;

		}

		#endregion

	}

}
