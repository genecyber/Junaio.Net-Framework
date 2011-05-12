using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// Sets the length of an animation in frames
    /// </summary>
    /// <remarks>
    /// Set length in frames to 0 means looping the animation.
    /// </remarks>
    public class Length : IElement<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Length"/> class.
        /// </summary>
        public Length()
        {
            Value = 0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Length"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        public Length(double length)
        {
            Value = length;
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
