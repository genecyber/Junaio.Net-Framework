namespace Junaio.Core.Model
{
    public class Minaccuracy : IElement<int>
    {
        private int _accuracy;

        public Minaccuracy(int accuracy)
        {
            _accuracy = accuracy;
        }

        public Minaccuracy()
        {
            // TODO: Complete member initialization
        }

        public int Value
        {
            get { return _accuracy; }
            set { _accuracy = value; }
        }
    }
}
