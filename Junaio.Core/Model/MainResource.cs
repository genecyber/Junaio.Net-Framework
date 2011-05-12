namespace Junaio.Core.Model
{
    public class MainResource : IElement<string>
    {
        private string _resource;

        public MainResource(string resource)
        {
            _resource = resource;
        }

        public MainResource()
        {
            // TODO: Complete member initialization
        }
        public string Value
        {
            get { return _resource; }
            set { _resource = value; }
        }
    }
}
