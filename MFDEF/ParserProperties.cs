using MFDEF.ValueTypes.Experimental;


namespace MFDEF
{

	/// <summary>
	/// Properties to pass to the document parser.
	/// </summary>
	public struct MFParserProperties
	{

		/// <summary>
		/// Whether to allow comments or throw an exception when one is detected.
		/// </summary>
		public bool AllowComments { get; set; }

		/// <summary>
		/// Whether to allow conditional mutations or not. <br/>
		/// If set to false and <see cref="AllowMutations"></see> is true, this will only prevent conditional mutations - generic mutations will still run.<br/>
		/// If <see cref="AllowMutations"></see> is false, this will be ignored and set to false too automatically.
		/// </summary>
		public bool AllowConditions { get; set; }

		/// <summary>
		/// Whether to allow mutations of any type or not.
		/// If you wish to disable conditions instead, please see <see cref="AllowConditions"></see> instead.
		/// </summary>
		public bool AllowMutations { get; set; }

		/// <summary>
		/// Whether to enable MF's Define Experimental Types, such as <see cref="MFInt128"/>, <see cref="MFUInt128"/>, <see cref="MFSignedByte"/> and <see cref="MFStrictNull"/>.
		/// If set to false and these types are used in the document that will be parsed, an error will be thrown.
		/// </summary>
		public bool EnableExperimentalTypes { get; set; }

	}

}
