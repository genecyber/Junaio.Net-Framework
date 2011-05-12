using System;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace Junaio.Core.Model.Request
{
    public class EventRequest : IRequest
    {
        /// <summary>
        /// Avalilable Parameter
        /// parameter["id"]...ID of the poi be interacted with
        /// parameter["type"]...Type of interaction with the POI (click/text)
        /// parameter["l"]...(optional) Position of the user when interacting with the POI
        /// parameter["uid"]... Unique user identifier
        /// </summary>
       private readonly NameValueCollection _parameters;

       public EventRequest(NameValueCollection parameters)
        {
            _parameters = parameters;
        }
        public XDocument GenerateResults()
        {
            throw new NotImplementedException();
        }
    }
}