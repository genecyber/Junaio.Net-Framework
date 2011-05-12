namespace Junaio.Core.Model
{
    public class Phone : IElement<string>
    {
        private string _phone;

        public Phone(string phone)
        {
            _phone = phone;
        }

        public Phone()
        {
            // TODO: Complete member initialization
        }
        public string Value
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
