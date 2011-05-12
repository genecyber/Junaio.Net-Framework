namespace Junaio.Core.Model
{
    public class Mail : IElement<string>
    {
        private string _mail;

        public Mail(string mail)
        {
            _mail = mail;
        }

        public Mail()
        {
            // TODO: Complete member initialization
        }
        public string Value
        {
            get { return _mail; }
            set { _mail = value; }
        }
    }
}
