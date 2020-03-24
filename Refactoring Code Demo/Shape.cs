﻿// <copyright file="Shape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171
// Odeysiuss Tuon, 11621966

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Abstract shape class.
    /// </summary>
    internal abstract class Shape
    {
        /// <summary>
        /// Color of the shape.
        /// Can be refactored using Visual Studio.
        /// </summary>
        public ConsoleColor color;

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public abstract bool IsShape { get; set; }

        /// <summary>
        /// Absctract method to display Shape.
        /// </summary>
        public abstract void DisplayShape();
    }
}
