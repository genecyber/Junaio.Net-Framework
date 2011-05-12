using System;

namespace Junaio.Core.Model
{
    public class Date : IElement<DateTime>
    {
        public Date(DateTime value)
        {
            _value = value;
        }

        public Date()
        {
            // TODO: Complete member initialization
        }
        private DateTime _value;
        public DateTime Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}