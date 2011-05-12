namespace Junaio.Core.Model
{
    /// <summary>
    /// Behaviours determine possible animations of a 3D model. 
    /// </summary>
    public class Behavior : IElement<Behavior>
    {
        /// <summary>
        /// Gets or sets the attribute collection.
        /// </summary>
        /// <value>
        /// The attribute collection.
        /// </value>
        public BehaviorAttributes AttributeCollection { get; set; }
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public Length Length { get; set; }
        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        /// <value>
        /// The node id.
        /// </value>
        public NodeId NodeId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Behavior"/> class.
        /// </summary>
        public Behavior()
        {
            AttributeCollection = new BehaviorAttributes {TypeAttr = BehaviorType.Idle};
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Behavior"/> class.
        /// </summary>
        /// <param name="behavior">The behavior.</param>
        public Behavior(Behavior behavior)
        {
            Value = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Behavior"/> class.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="length">The length.</param>
        /// <param name="nodeId">The node id.</param>
        public Behavior(BehaviorAttributes attributes, Length length, NodeId nodeId)
        {
            AttributeCollection = attributes;
            Length = length;
            NodeId = nodeId;
        }

        public Behavior Value { get; set; }
    }

    public class BehaviorAttributes : IAttributeCollection
    {
        public BehaviorAttributes()
        {
            TypeAttr = BehaviorType.Idle;
        }
        public BehaviorType TypeAttr { get; set; }
    }
    /// <summary>
    /// Behaviours determine possible animations of a 3D model. It sets the type of the animation.
    /// </summary>
    /// <remarks>
    /// It sets the type of the animation.
    /// </remarks>
    public enum BehaviorType
    {
        /// <summary>
        /// The stated animation of the model will start when clicked.
        /// </summary>
        Click = 0,
        /// <summary>
        /// The stated animation of the model will be started.
        /// </summary>
        Idle
    }
}
