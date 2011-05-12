namespace Junaio.Core.Model
{
    public class Point3f : IElement<string>
    {
        public Point3f()
        {
            _values = new double[] {0, 0, 0};
        }
        private double[] _values;

        public Point3f(double[] values)
        {
            _values = values;
        }

        public string Value
        {
            get { return _values[0] + "," + _values[1] + "," + _values[2]; }
            set { }
        }
    }
}
