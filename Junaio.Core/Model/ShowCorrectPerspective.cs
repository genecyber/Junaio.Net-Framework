namespace Junaio.Core.Model
{
    /// <summary>
    /// For usability reason we adjust model distances in the world, so they can be seen by users. Set to "true" to avoid view correction.
    /// </summary>
    /// <remarks>
    /// Set the model at the correct location in the world. 
    /// </remarks>
    class ShowCorrectPerspective : IElement<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowCorrectPerspective"/> class.
        /// </summary>
        public ShowCorrectPerspective(){ }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowCorrectPerspective"/> class.
        /// </summary>
        /// <param name="showCorrect">if set to <c>true</c> [show correct].</param>
        public ShowCorrectPerspective(bool showCorrect)
        {
            Value = showCorrect;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ShowCorrectPerspective"/> is value.
        /// </summary>
        /// <value>
        ///   <c>true</c> if value; otherwise, <c>false</c>.
        /// </value>
        public bool Value { get; set; }
    }
}
