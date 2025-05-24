using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using MFDEF.Pointers;
using MFDEF.ValueTypes;


namespace MFDEF.Sections
{

	/// <summary>
	/// Represents a MF's Define section that has a Key-Value Pair structure.
	/// </summary>
	public class MFKeyBasedSection : IMFSection
	{

		/// <summary>
		/// The values contained in this section.
		/// </summary>
		private readonly Dictionary<string, IMFValue> values = [];

		/// <summary>
		/// Creates a new empty section.
		/// </summary>
		public MFKeyBasedSection() { }

		/// <summary>
		/// Creates a section from a readonly list of compatible values.
		/// </summary>
		/// <param name="values">The readonly collection</param>
		public MFKeyBasedSection(ReadOnlyDictionary<string, IMFValue> values)
		{

			this.values = values.ToDictionary();

		}

		/// <summary>
		/// <strong>This accessor is obsolete.</strong>
		/// Gets or sets one of this section's values.
		/// </summary>
		/// <param name="keyOrIndex">The key or index to modify/access</param>
		/// <exception cref="NotSupportedException"></exception>
		[Obsolete("Use MFIndexedSection.this[uint index] instead")]
		public IMFValue? this[object keyOrIndex]
		{

			get => throw new NotSupportedException("Use MFIndexedSection.this[uint index] instead");
			set => throw new NotSupportedException("Use MFIndexedSection.this[uint index] instead");

		}

		/// <summary>
		/// Get or set values inside this section.
		/// </summary>
		/// <param name="key">The key to access/modify</param>
		/// <returns><strong>(Get)</strong> The MFValue</returns>
		public IMFValue? this[string key]
		{

			get
			{

				var temp = values.GetValueOrDefault(key);

				return temp is MFPointer pointer ?
					pointer.GetCurrentStateOfValue()
					: temp;

			}

			set
			{

				if (value is null)
				{

					throw new NullReferenceException("You may only assign valid MFValues.");

				}
				if (value is MFPointer pointer)
				{

					values[key] = pointer.GetCurrentStateOfValue() ?? throw new FormatException("Pointer is pointing to an unrecognized section format");

				}

				values[key] = value;

			}

		}

		/// <summary>
		/// Returns the section as a readonly collection of values.
		/// </summary>
		public ReadOnlyDictionary<string, IMFValue> Values
		{

			get => values.AsReadOnly();

		}

	}

}
