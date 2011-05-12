using System.Xml.Linq;

namespace Junaio.Core.Model.Request
{
    public interface IRequest
    {
        XDocument GenerateResults();
    }
}