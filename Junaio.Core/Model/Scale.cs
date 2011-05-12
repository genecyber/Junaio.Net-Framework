using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// Sets the scale of a model.
    /// </summary>
    /// <remarks>
    /// For 3D models only!
    /// </remarks>
    public class Scale : IElement<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scale"/> class.
        /// </summary>
        public Scale()
        {
            Value = -1;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scale"/> class.
        /// </summary>
        /// <param name="scale">The scale.</param>
        public Scale(double scale)
        {
            Value = scale;
        }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public double Value { get; set; }
    }
}
