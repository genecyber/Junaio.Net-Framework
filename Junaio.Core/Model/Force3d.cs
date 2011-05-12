using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// Force the display of the 3D model. Only valid in combination with mime-type model/md2 or model/obj.
    /// </summary>
    /// <remarks>
    /// Displays the 3D model, without showing the <see cref="Thumbnail"/> first.
    /// </remarks>
    public class Force3D : IElement<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Force3D"/> class.
        /// </summary>
        public Force3D()
        {
            Value = false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Force3D"/> class.
        /// </summary>
        /// <param name="force">if set to <c>true</c> [force].</param>
        public Force3D(bool force)
        {
            Value = force;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Force3D"/> is value.
        /// </summary>
        /// <value>
        ///   <c>true</c> if value; otherwise, <c>false</c>.
        /// </value>
        public bool Value { get; set; }
    }
}
