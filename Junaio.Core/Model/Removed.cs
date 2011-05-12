using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Junaio.Core.Model
{
    /// <summary>
    /// Attribute to be returned upon pois/event to remove a loaded POI.
    /// </summary>
    /// <remarks>
    /// Set to "true" to remove a POI, which is displayed.
    /// </remarks>
    public class Removed : IElement<bool>
    {
        private bool _check;

        public Removed(){ }

        public Removed(bool check)
        {
            _check = check;
        }
        public bool Value
        {
            get { return _check; }
            set { _check = value; }
        }
    }
}
