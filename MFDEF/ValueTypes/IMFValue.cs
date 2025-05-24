namespace MFDEF.ValueTypes
{

	/// <summary>
	/// The most abstract representation of a MF's Define value.
	/// </summary>
	public interface IMFValue
	{

		/// <summary>
		/// The designation of this value type.
		/// </summary>
		public string? Designation { get; set; }

	}

}
