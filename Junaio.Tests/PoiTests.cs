using FluentAssertions;
using Junaio.Core.Model;
using NUnit.Framework;

namespace Junaio.Tests
{
    [TestFixture]
    public class PoiTests
    {
        [Test]
        public void Poi_CreatesValueOfItself()
        {
            var poi = new Poi();
            poi.Value.Should().Be(poi);
        }
        [Test]
        public void Poi_WithNoAttributesDefined_ResultsInDefaults()
        {
            var poi = new Poi();
            poi.AttributeCollection.IdAttr.Should().NotBeNullOrEmpty();
            poi.AttributeCollection.InteractionFeedbackAttr.Should().Be(InteractionFeedbackType.None);
        }

        [Test]
        public void Poi_WithAttributesInConstructor_ResultsInAttributesDefinedInPoiResult()
        {
            var poi = new Poi(new PoIAttributes("someID", InteractionFeedbackType.Click));
            poi.AttributeCollection.IdAttr.Should().Be("someID");
            poi.AttributeCollection.InteractionFeedbackAttr.Should().Be(InteractionFeedbackType.Click);
        }
    }
}