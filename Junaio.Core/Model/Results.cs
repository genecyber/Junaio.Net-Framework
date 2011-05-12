using System.Collections.Generic;

namespace Junaio.Core.Model
{
    public class Results : IElement<IEnumerable<Poi>>
    {
        private IEnumerable<Poi> _value;
        public Results(){ }

        public Results(Poi poi)
        {
            var list = new List<Poi>();
            list.Add(poi);
            _value = list;
        }

        public Results(IEnumerable<Poi> pois)
        {
            _value = pois;
        }

        public IEnumerable<Poi> Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}