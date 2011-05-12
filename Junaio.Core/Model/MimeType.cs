namespace Junaio.Core.Model
{
    /// <summary>
    /// It defines the type of media given for the client.
    /// </summary>
    /// <remarks>
    /// Depending on the mime type, different representations will be chosen for the information. 
    /// </remarks>
    public class MimeType : IElement<Mimetype>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MimeType"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public MimeType(Mimetype type)
        {
            Value = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MimeType"/> class.
        /// </summary>
        public MimeType()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public Mimetype Value { get; set; }
    }
    public enum Mimetype
    {
        image_png = 0,
        image_jpeg,
        video_quicktime,
        video_mp4,
        audio_mp3,
        text_plain,
        model_md2,
        model_obj
    }
}
