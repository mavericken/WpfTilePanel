﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TilePanelTest
{
	/// <summary>Boolena to Visibility converter</summary>
	public class StringToValueConverter : IValueConverter
	{

		/// <summary>Converts a boolena value to a visibility value.</summary>
		/// <param name="value">The value produced by the binding source.</param>
		/// <param name="targetType">The type of the binding target property.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>A converted value. If the method returns null, the valid null value is used.</returns>
		public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
		{
			if (targetType == typeof(double))
			{
				try
				{
				return System.Convert.ToDouble(value);
				}
				catch (Exception)
				{
					return 0.0;
				}
			}
			throw new InvalidOperationException("Converter can only convert to value value types.");
		}

		/// <summary>Converts a value.</summary>
		/// <param name="value">The value that is produced by the binding target.</param>
		/// <param name="targetType">The type to convert to.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
		{
			return value.ToString();
		}
	}
}
