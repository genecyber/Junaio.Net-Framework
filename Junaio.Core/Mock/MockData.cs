using System;
using System.Collections.Generic;
using Junaio.Core.Model;

namespace Junaio.Core.Mock
{
    public class MockData
    {
        public Poi MakeEmptyPoi()
        {
            return new Poi();
        }

        public Poi MakeTestPoi()
        {
            var poi = new Poi(new PoIAttributes());
            poi.l = new Point3f(new[] { 35.915426, -78.743379, 0 });
            poi.Name.Value = "Shannon";
            poi.Description.Value = "This is a test point";
            poi.Minaccuracy.Value = 100;
            poi.Maxdistance.Value = 500;
            poi.Mimetype.Value = Mimetype.image_png;
            poi.Mainresource.Value =
                "http://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/PNG_transparency_demonstration_2.png/280px-PNG_transparency_demonstration_2.png";
            poi.Thumbnail.Value =
                "http://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/PNG_transparency_demonstration_2.png/280px-PNG_transparency_demonstration_2.png";
            poi.Homepage.Value = new Uri("http://www.prototypic.net");
            return poi;
        }

        public Results MakeResultWithOneEmptyPoi()
        {
            var pois = new List<Poi> { MakeEmptyPoi() };
            var result = new Results(pois);
            return result;
        }

        public Results MakeResult(Poi poi)
        {
            var result = new Results(poi);
            return result;
        }
        
        public Results MakeResultWithTwoEmptyPois()
        {
            var pois = new List<Poi> { MakeEmptyPoi(), MakeEmptyPoi() };
            var result = new Results(pois);
            return result;
        }
    }
}