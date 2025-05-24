using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using MFDEF.Pointers;
using MFDEF.ValueTypes;


namespace MFDEF.Sections
{

	/// <summary>
	/// Represents a MF's Define indexed section, which is different from a MF's Define array.
	/// </summary>
	public class MFIndexedSection : IMFSection
	{

		/// <summary>
		/// The values contained in this section.
		/// </summary>
		private readonly List<IMFValue> values = [];

		/// <summary>
		/// Creates a new empty section.
		/// </summary>
		public MFIndexedSection() { }

		/// <summary>
		/// Creates a section from an array of compatible values.
		/// </summary>
		/// <param name="values">The array</param>
		public MFIndexedSection(IMFValue[] values)
		{

			this.values = values.ToList();

		}

		/// <summary>
		/// Creates a section from a mutable list of compatible values.
		/// </summary>
		/// <param name="values">The list</param>
		public MFIndexedSection(List<IMFValue> values)
		{

			this.values = values;

		}

		/// <summary>
		/// Creates a section from a readonly list of compatible values.
		/// </summary>
		/// <param name="values">The readonly collection</param>
		public MFIndexedSection(ReadOnlyCollection<IMFValue> values)
		{

			this.values = values.ToList();

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
		/// <param name="index">The index to access/modify</param>
		/// <returns><strong>(Get)</strong> The MFValue</returns>
		public IMFValue? this[uint index]
		{

			get
			{

				var temp = values.ElementAtOrDefault((int)index);

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

					values[(int)index] = pointer.GetCurrentStateOfValue() ?? throw new FormatException("Pointer is pointing to an unrecognized section format");

				}

				values[(int)index] = value;

			}

		}

		/// <summary>
		/// Returns the section as a readonly collection of values.
		/// </summary>
		public ReadOnlyCollection<IMFValue> Values
		{

			get => values.AsReadOnly();

		}

	}

}
