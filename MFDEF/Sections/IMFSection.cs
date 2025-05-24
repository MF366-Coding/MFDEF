using MFDEF.ValueTypes;


namespace MFDEF.Sections
{

	/// <summary>
	/// The most abstract representation of a MF's Define section.
	/// </summary>
	public interface IMFSection
	{

		/// <summary>
		/// Get or set values inside this section.
		/// </summary>
		/// <param name="keyOrIndex">The key or index to modify</param>
		/// <returns><strong>(Get)</strong> The MFValue</returns>
		abstract IMFValue? this[object keyOrIndex] { get; set; }

	}

}
