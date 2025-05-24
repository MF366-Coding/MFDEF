using System;

using MFDEF.Sections;
using MFDEF.ValueTypes;


namespace MFDEF.Pointers
{

	/// <summary>
	/// Represents a MF Define's pointer whose type is infered.
	/// </summary>
	public class MFPointer : IMFValue
	{

		/// <summary>
		/// Pointers have no type designation.
		/// </summary>
		public string? Designation { get; set; }

		/// <summary>
		/// The section this pointer points to.
		/// </summary>
		public IMFSection Section { get; set; }

		/// <summary>
		/// The key this pointer points to.
		/// If <see cref="Section"/> is index-based, this string is converted to an integer
		/// and that integer is used instead.
		/// Set this to null if the pointer points to the whole section.
		/// </summary>
		public string? KeyOrIndex { get; set; }

		/// <summary>
		/// Creates a new instance of a MFPointer.
		/// </summary>
		/// <param name="section">The section to point to</param>
		public MFPointer(ref IMFSection section)
		{

			Section = section;

		}

		/// <summary>
		/// Creates a new instance of a MFPointer.
		/// </summary>
		/// <param name="section">The section whose value to point to</param>
		/// <param name="keyOrIndex">The key or index whose value to point to</param>
		public MFPointer(ref IMFSection section, string keyOrIndex)
		{

			Section = section;
			KeyOrIndex = keyOrIndex;

		}

		/// <summary>
		/// Creates a new instance of a MFPointer.
		/// </summary>
		/// <param name="section">The indexed section whose value to point to</param>
		/// <param name="index">The index whose value to point to</param>
		public MFPointer(ref IMFSection section, uint index)
		{

			Section = section;
			KeyOrIndex = Convert.ToString(index);

		}

		/// <summary>
		/// Gets the current state of the section.
		/// </summary>
		/// <returns>The current state of the section</returns>
		public IMFSection? GetCurrentStateOfSection()
		{

			return Section;

		}

		/// <summary>
		/// Gets the current state of the value the pointer points to.
		/// </summary>
		/// <exception cref="FormatException">Trying to get the current state of a section</exception>
		/// <returns>The current state of the value that's being pointed to</returns>
		public IMFValue? GetCurrentStateOfValue()
		{

			if (KeyOrIndex is null)
			{

				throw new FormatException("Please use GetCurrentStateOfSection instead.");

			}

			if (Section is MFIndexedSection indexedSection)
			{

				return indexedSection[Convert.ToUInt32(KeyOrIndex)];

			}

			else if (Section is MFKeyBasedSection keyBasedSection)
			{

				return keyBasedSection[KeyOrIndex];

			}

			return null; // this will only happen if you're using custom section stuff

		}

		/// <summary>
		/// Changes the current state of the value.
		/// </summary>
		/// <param name="newState">The new state of the value, must be of the same datatype</param>
		/// <exception cref="FormatException">Trying to re-assign a section or trying to convert X to Y</exception>
		public void ChangeStateOfValue(IMFValue newState)
		{

			if (KeyOrIndex is null)
			{

				throw new FormatException("Cannot change the state of a section.");

			}

			if (Section is MFIndexedSection)
			{

				string? designation = Section[Convert.ToUInt32(KeyOrIndex)]?.Designation;

				if (newState.Designation != designation)
				{

					throw new FormatException($"Cannot convert {newState.Designation} to {designation}.");

				}

				Section[Convert.ToUInt32(KeyOrIndex)] = newState;

				return;

			}

			else if (Section is MFKeyBasedSection keyBasedSection)
			{

				string? auxVar = keyBasedSection[KeyOrIndex]?.Designation;

				if (newState.Designation != auxVar)
				{

					throw new FormatException($"Cannot convert {newState.Designation} to {auxVar}.");

				}

				keyBasedSection[KeyOrIndex] = newState;

			}

			return;

		}

	}

}
