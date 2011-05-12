using System.Collections.Specialized;

namespace Junaio.Core.Model.Request
{
    public static class RequestFactory
    {
        public static IRequest GenerateRequest(string requestType, NameValueCollection parameters)
        {
            switch (requestType)
            {
                case "search":
                    return new SearchRequest(parameters);
                case "event":
                    return new EventRequest(parameters);
                case "subscribe":
                    return new SubscribeRequest(parameters);
                default:
                    return new ErrorRequest(parameters);
            }
        }
    }
}