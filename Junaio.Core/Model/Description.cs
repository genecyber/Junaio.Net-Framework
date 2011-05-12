namespace Junaio.Core.Model
{
    public class Description : IElement<string>
    {
        private string _description;

        public Description(string description)
        {
            _description = description;
        }

        public Description()
        {
            // TODO: Complete member initialization
        }

        public string Value 
        { 
            get { return _description; }
            set { _description = value; }
        }
    }
}