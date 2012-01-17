﻿#region MIT License
/*Copyright (c) 2012 Robert Rouhani, robert.rouhani@gmail.com

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#endregion

using System;
using System.Runtime.InteropServices;

namespace SharpFont
{
	/// <summary>
	/// A structure used to model the metrics of a single glyph. The values are expressed in 26.6 fractional pixel format; if the flag FT_LOAD_NO_SCALE has been used while loading the glyph, values are expressed in font units instead.
	/// </summary>
	/// <remarks>
	/// If not disabled with FT_LOAD_NO_HINTING, the values represent dimensions of the hinted glyph (in case hinting is applicable).
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct GlyphMetrics
	{
		/// <summary>
		/// The glyph's width.
		/// </summary>
		public int Width;

		/// <summary>
		/// The glyph's height.
		/// </summary>
		public int Height;

		/// <summary>
		/// Left side bearing for horizontal layout.
		/// </summary>
		public int HorizontalBearingX;

		/// <summary>
		/// Top side bearing for horizontal layout.
		/// </summary>
		public int HorizontalBearingY;

		/// <summary>
		/// Advance width for horizontal layout.
		/// </summary>
		public int HorizontalAdvance;

		/// <summary>
		/// Left side bearing for vertical layout.
		/// </summary>
		public int VerticalBearingX;

		/// <summary>
		/// Top side bearing for vertical layout. Larger positive values mean further below the vertical glyph origin.
		/// </summary>
		public int VerticalBearingY;

		/// <summary>
		/// Advance height for vertical layout. Positive values mean the glyph has a positive advance downward.
		/// </summary>
		public int VerticalAdvance;
	}
}