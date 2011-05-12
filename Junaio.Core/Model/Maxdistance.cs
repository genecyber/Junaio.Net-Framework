namespace Junaio.Core.Model
{
    public class Maxdistance : IElement<int>
    {
        private int _maxDistance;

        public Maxdistance(int maxDistance)
        {
            _maxDistance = maxDistance;
        }

        public Maxdistance()
        {
            // TODO: Complete member initialization
        }
        public int Value
        {
            get { return _maxDistance; }
            set { _maxDistance = value; }
        }
    }
}
