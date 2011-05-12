using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Linq;
using Junaio.Core.Mock;
using Junaio.Core.Xml;

namespace Junaio.Core.Model.Request
{
    public class SearchRequest : IRequest
    {
        /// <summary>
        /// Avalilable Parameter
        ///parameter["l"]...(optional) Position of the user when interacting with the POI
        ///parameter["p"]...(optional) perimeter of the data requested in meters.
        ///parameter["uid"]... Unique user identifier
        ///parameter["m"]... (optional) limit of to be returned values
        ///parameter["page"]...page number of result. e.g. m = 10: page 1: 1-10; page 2: 11-20, e.g.
        /// </summary>
        private readonly NameValueCollection _parameters;

        public SearchRequest(NameValueCollection parameters)
        {
            _parameters = parameters;
        }
        public XDocument GenerateResults()
        {
            var poi = new MockData().MakeTestPoi();
            var serializer = new Serializer();
            serializer.Serialize(new Results(new List<Poi> {poi}));
            return serializer.Serialize(new Results(new List<Poi> { poi })); 
        }
    }
}