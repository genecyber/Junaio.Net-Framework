using System;

namespace Junaio.Core.Model
{
    public class Poi : IElement<Poi>
    {
        public Poi()
        {
            AttributeCollection = new PoIAttributes();
            Init();
        }
        public Poi(PoIAttributes attributes)
        {
            AttributeCollection = attributes;
            Init();
        }

        private void Init()
        {
            Date = new Date();
            Name = new Name();
            Description = new Description();
            Homepage = new HomePage();
            Icon = new Icon();
            l = new Point3f();
            o = new Point3f();
            Mail = new Mail();
            Mainresource = new MainResource();
            Minaccuracy = new Minaccuracy();
            Maxdistance = new Maxdistance();
            Mimetype = new MimeType();
            Thumbnail = new Thumbnail();
            Phone = new Phone();
        }

        public PoIAttributes AttributeCollection { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Date Date { get; set; }
        public Point3f l { get; set; }
        public Point3f o { get; set; }
        public Minaccuracy Minaccuracy { get; set; }
        public Maxdistance Maxdistance { get; set; }
        public MimeType Mimetype { get; set; }
        public MainResource Mainresource { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public Icon Icon { get; set; }
        public Phone Phone { get; set; }
        public Mail Mail { get; set; }
        public HomePage Homepage { get; set; }
        
        public Poi Value
        {
            get { return this; }
            set { }
        }
    }

    public class PoIAttributes : IAttributeCollection
    {
        public PoIAttributes()
        {
            IdAttr = Guid.NewGuid().ToString();
            InteractionFeedbackAttr = InteractionFeedbackType.None;
        }
        public PoIAttributes(string id, InteractionFeedbackType type )
        {
            IdAttr = id;
            InteractionFeedbackAttr = type;
        }
        public string IdAttr { get; set; }
        public InteractionFeedbackType InteractionFeedbackAttr { get; set; }
    }
    public enum InteractionFeedbackType
    {
        None = 0,
        Click,
        Text
    }
}