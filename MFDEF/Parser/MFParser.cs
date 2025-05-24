using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml;
using MFDEF.Sections;
using MFDEF.ValueTypes.Numerics;


namespace MFDEF.Parser
{

	/// <summary>
	/// Parser for MF's Define.
	/// </summary>
	public class MFParser
	{

		private bool inSection;
		private bool curSectionIsIndexed;
		private MFParserProperties parserProperties;

		/// <summary>
		/// Creates a new instance of a MFDEF parser with some given properties.
		/// </summary>
		/// <param name="properties"></param>
		public MFParser(MFParserProperties properties)
		{

			parserProperties = properties;
			NormalizeProperties();

		}

		private void NormalizeProperties()
		{

			if (!(parserProperties.AllowMutations))
			{

				parserProperties.AllowConditions = false;

			}

			parserProperties.FallbackForInt ??= typeof(MFInt32);

		}

		public ReadOnlyDictionary<string, IMFSection> ParseDocument(string document)
		{

			Dictionary<string, IMFSection> parsedResult = new();

			using (StringReader stringReader = new(document))
			{

				while (stringReader.Peek() != -1)
				{

					string? line = stringReader.ReadLine();

					if (line is null) break;

					if (line.StartsWith("//")) continue;

					if (line.StartsWith("#endall"))
					{

						inSection = false;
						curSectionIsIndexed = false;
						continue;

					}
					
					if (line.StartsWith("#end"))
					{

						if (!inSection) throw new ParserError("Can't end a non-existing section.");
						inSection = false;
						curSectionIsIndexed = false;
						continue;

					}

					if (line.StartsWith("#indexed"))
					{

						if (inSection) throw new ParserError("Cannot create a section inside another section - did you mean to use a pointer?");
						inSection = true;
						curSectionIsIndexed = true;

						parsedResult.Add(line[8..^1].Replace(" ", ""), // get rid of spaces
							new MFIndexedSection()); // empty indexed section
						continue;

					}

					if (line.StartsWith("#kvpairs"))
					{

						if (inSection) throw new ParserError("Cannot create a section inside another section - did you mean to use a pointer?");
						inSection = true;
						curSectionIsIndexed = false;

						parsedResult.Add(line[8..^1].Replace(" ", ""), // get rid of spaces
							new MFIndexedSection()); // empty indexed section
						continue;

					}

					if (inSection)
					{

						if (!(line.StartsWith("Double") || line.StartsWith("UInt") || line.StartsWith("Int") || line.StartsWith("String")
							|| line.StartsWith("Bool") || line.StartsWith("StrictNull")))
							throw new ParserError("Invalid datatype in MF's Define.");

						// todo: handle members

					}

				}

			};

			return parsedResult.AsReadOnly();

		}

	}

}
