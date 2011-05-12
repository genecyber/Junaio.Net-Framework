using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// Determines, whether a user should be able to be navigated to that POI.
    /// </summary>
    /// <remarks>
    /// If this parameter is set, an "Directions" button will be displayed.
    /// </remarks>
    public class Route : IElement<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route"/> class.
        /// </summary>
        public Route(){}
        /// <summary>
        /// Initializes a new instance of the <see cref="Route"/> class.
        /// </summary>
        /// <param name="shouldRoute">if set to <c>true</c> [should route].</param>
        public Route(bool shouldRoute)
        {
            Value = shouldRoute;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Route"/> is value.
        /// </summary>
        /// <value>
        ///   <c>true</c> if value; otherwise, <c>false</c>.
        /// </value>
        public bool Value { get; set; }
    }
}
