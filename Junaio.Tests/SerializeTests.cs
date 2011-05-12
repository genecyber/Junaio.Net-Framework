using System.Linq;
using System.Xml.Linq;
using FluentAssertions;
using Junaio.Core.Mock;
using Junaio.Core.Xml;
using NUnit.Framework;

namespace Junaio.Tests
{
    public class SerializeTests
    {
        [Test]
        public void Serialize_SinglePoi_ReturnsXDocument()
        {
            var serializer = new Serializer();
            var doc = serializer.Serialize(new MockData().MakeResultWithOneEmptyPoi());
            doc.Should().BeOfType<XDocument>();
        }

        [Test]
        public void Serialize_TwoPois_ReturnsXDocumentWithTwoPoiNodes()
        {
            var serializer = new Serializer();
            var doc = serializer.Serialize(new MockData().MakeResultWithTwoEmptyPois());
            doc.Root.Descendants().Where(n => n.Name.LocalName == "poi").Should().HaveCount(2);
        }

        [Test]
        public void Serialize_OneLoadedPois_ReturnsXDocumentWithLoadedPoiNode()
        {
            var serializer = new Serializer();
            var mock = new MockData();
            var doc = serializer.Serialize(mock.MakeResult(mock.MakeTestPoi()));
            doc.Root.Descendants().Where(n => n.Name.LocalName == "poi").Should().HaveCount(1);
        }
    }
}