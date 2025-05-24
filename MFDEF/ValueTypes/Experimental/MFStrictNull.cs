namespace MFDEF.ValueTypes.Experimental
{

	/// <summary>
	/// Represents a value in MF's Define that's always null no matter what. Cannot be modified whatsoever.
	/// </summary>
	public class MFStrictNull : IMFValue
	{

		/// <summary>
		/// StrictNull.
		/// </summary>
		public string? Designation { get; set; }

		/// <summary>
		/// Null.
		/// </summary>
		public object? Value { get; set; }

		/// <summary>
		/// Creates a MF's Define null value.
		/// </summary>
		public MFStrictNull()
		{

			Value = null;
			Designation = "StrictNull";

		}

	}

}
