namespace Junaio.Core.Model
{
    public class Name : IElement<string>
    {
        public Name(string name)
        {
            Value = name;
        }

        public Name()
        {
            // TODO: Complete member initialization
        }

        public string Value { get; set; }
    }
}