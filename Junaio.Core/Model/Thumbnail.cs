namespace Junaio.Core.Model
{
    /// <summary>
    /// Holds a url to an image file which will be displayed with the POI in live view.
    /// </summary>
    /// <remarks>
    /// Shows a thumbail image with a POI in the live view. The thumbnail can be png or jpg format and should not exceed the size of 150x150 pixels. 
    /// </remarks>
    public class Thumbnail : IElement<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail"/> class.
        /// </summary>
        /// <param name="thumbnail">The thumbnail.</param>
        public Thumbnail(string thumbnail)
        {
            Value = thumbnail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail"/> class.
        /// </summary>
        public Thumbnail()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }
    }
}
