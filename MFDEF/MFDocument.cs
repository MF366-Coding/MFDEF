using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using MFDEF.Parser;
using MFDEF.Sections;
using MFDEF.ValueTypes.Numerics;


namespace MFDEF
{

	/// <summary>
	/// Represents a MF's Define file.
	/// </summary>
	public class MFDocument
	{

		/// <summary>
		/// The sections present in this MFDEF document.
		/// </summary>
		private Dictionary<string, IMFSection> sections = new();

		/// <summary>
		/// The parser properties.
		/// </summary>
		private MFParserProperties parserProperties;

		/// <summary>
		/// Creates an empty document.
		/// </summary>
		public MFDocument()
		{

			parserProperties = new()
			{

				AllowComments = true,
				AllowMutations = true,
				FallbackForInt = typeof(MFInt32),
				EnableExperimentalTypes = false

			};

		}

		/// <summary>
		/// Creates a document from a dictionary of sections.
		/// </summary>
		/// <param name="sections">The sections this document must have</param>
		public MFDocument(ReadOnlyDictionary<string, IMFSection> sections)
		{

			this.sections = sections.ToDictionary();
			parserProperties = new()
			{

				AllowComments = true,
				AllowMutations = true,
				FallbackForInt = typeof(MFInt32),
				EnableExperimentalTypes = false

			};

		}

	}

}
