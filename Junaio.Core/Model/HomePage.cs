using System;

namespace Junaio.Core.Model
{
    public class HomePage : IElement<Uri>
    {
        private Uri _uri;

        public HomePage(Uri uri)
        {
            _uri = uri;
        }

        public HomePage()
        {
            // TODO: Complete member initialization
        }
        public Uri Value
        {
            get { return _uri; }
            set { _uri = value; }
        }
    }
}
