using System.Collections.Generic;
using FluentAssertions;
using Junaio.Core.Mock;
using Junaio.Core.Model;
using NUnit.Framework;

namespace Junaio.Tests
{
    [TestFixture]
    public class ResultTests
    {
        [Test]
        public void NewResult_NoPoiObject_ContainsNullResultValue()
        {
            var result = new Results();
            result.Value.Should().BeNull();
        }

        [Test]
        public void NewResult_WithEmptyPoiList_ContainsZeroPoisInResult()
        {
            var pois = new List<Poi>();
            var result = new Results(pois);
            result.Value.Should().NotBeNull();
            result.Value.Should().HaveCount(0);
        }

        [Test]
        public void NewResult_WithOnePoiInList_ContainsOnePoiInResult()
        {
            var result = new MockData().MakeResultWithOneEmptyPoi();
            result.Value.Should().HaveCount(1);
        }

        [Test]
        public void NewResult_WithTwoPoiInList_ContainsTwoPoiInResult()
        {
            var result = new MockData().MakeResultWithTwoEmptyPois();
            result.Value.Should().HaveCount(2);
        }

    }
}