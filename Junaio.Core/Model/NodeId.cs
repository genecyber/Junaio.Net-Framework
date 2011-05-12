using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// Sets the name of the animation that shall be started.
    /// </summary>
    /// <remarks>
    /// This parameter determines the animation that will be started after loading the model.
    /// </remarks>
    public class NodeId : IElement<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeId"/> class.
        /// </summary>
        public NodeId(){}
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeId"/> class.
        /// </summary>
        /// <param name="id">The id.</param>
        public NodeId(string id)
        {
            Value = id;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }
    }
}
