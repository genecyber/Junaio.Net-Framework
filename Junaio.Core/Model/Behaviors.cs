using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// A List of <see cref="Behavior"/>
    /// </summary>
    public class Behaviors : IElement<IEnumerable<Behavior>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Behaviors"/> class.
        /// </summary>
        public Behaviors()
        {
            Value = new List<Behavior>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Behaviors"/> class.
        /// </summary>
        /// <param name="behavior">A single behavior.</param>
        public Behaviors(Behavior behavior)
        {
            Value = new List<Behavior>() {behavior};
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Behaviors"/> class.
        /// </summary>
        /// <param name="behaviors">Multiple behaviors.</param>
        public Behaviors(IEnumerable<Behavior> behaviors)
        {
            Value = behaviors;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public IEnumerable<Behavior> Value { get; set; }
    }
}
