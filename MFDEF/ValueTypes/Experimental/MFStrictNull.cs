namespace MFDEF.ValueTypes.Experimental
{

	public class MFStrictNull : IMFValue
	{

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
