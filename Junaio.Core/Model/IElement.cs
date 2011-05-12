namespace Junaio.Core.Model
{
    public interface IElement<T>
    {
        T Value { get; set; }
    }
}