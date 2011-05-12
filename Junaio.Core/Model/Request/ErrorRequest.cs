using System;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace Junaio.Core.Model.Request
{
    public class ErrorRequest : IRequest
    {
        private readonly NameValueCollection _parameters;
        private readonly Exception _exception;

        public ErrorRequest(NameValueCollection parameters)
        {
            _parameters = parameters;
        }

        public ErrorRequest(NameValueCollection parameters, Exception exception)
        {
            _parameters = parameters;
            _exception = exception;
        }

        public XDocument GenerateResults()
        {
            throw new NotImplementedException();
        }
    }
}