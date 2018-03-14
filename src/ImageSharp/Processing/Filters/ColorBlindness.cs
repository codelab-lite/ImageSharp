﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Processing.Filters
{
    /// <summary>
    /// Enumerates the various types of defined color blindness filters.
    /// </summary>
    public enum ColorBlindness
    {
        /// <summary>
        /// Partial color desensitivity.
        /// </summary>
        Achromatomaly,

        /// <summary>
        /// Complete color desensitivity (Monochrome)
        /// </summary>
        Achromatopsia,

        /// <summary>
        /// Green weak
        /// </summary>
        Deuteranomaly,

        /// <summary>
        /// Green blind
        /// </summary>
        Deuteranopia,

        /// <summary>
        /// Red weak
        /// </summary>
        Protanomaly,

        /// <summary>
        /// Red blind
        /// </summary>
        Protanopia,

        /// <summary>
        /// Blue weak
        /// </summary>
        Tritanomaly,

        /// <summary>
        /// Blue blind
        /// </summary>
        Tritanopia
    }
}