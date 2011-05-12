namespace Junaio.Core.Model
{
    public class Icon : IElement<string>
    {
        private string _icon;

        public Icon(string icon)
        {
            _icon = icon;
        }

        public Icon()
        {
            // TODO: Complete member initialization
        }
        public string Value
        {
            get { return _icon; }
            set { _icon = value; }
        }
    }
}
