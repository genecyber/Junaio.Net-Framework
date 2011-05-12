using System;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace Junaio.Core.Model.Request
{
    public class SubscribeRequest : IRequest
    {
        /// <summary>
        /// Avalilable Parameter
        /// parameter["action"] ... subscribe or unsubscribe
        /// parameter["uid"] ... unique user identification
        /// </summary>
        private readonly NameValueCollection _parameters;

        public SubscribeRequest(NameValueCollection parameters)
        {
            _parameters = parameters;
        }

        public XDocument GenerateResults()
        {
            throw new NotImplementedException();
        }
    }
}