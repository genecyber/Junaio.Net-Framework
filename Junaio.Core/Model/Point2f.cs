using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// X and Y representation.
    /// </summary>
    public class Point2F : IElement<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point2F"/> class.
        /// </summary>
        public Point2F()
        {
            _values = new double[] { 0, 0, 0 };
        }
        private double[] _values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2F"/> class.
        /// </summary>
        /// <param name="values">The values.</param>
        public Point2F(double[] values)
        {
            _values = values;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value
        {
            get { return _values[0] + "," + _values[1]; }
            set { }
        }
    }
}



