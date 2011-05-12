using System.Xml.Linq;
using Junaio.Core.Model;

namespace Junaio.Core.Xml
{
    public class Serializer
    {
        public XDocument Serialize(Results results)
        {
            var resultsNode = new XElement("results");
            foreach (var result in results.Value)
            {
                var poiNode = new XElement("poi");
                HandleAttributes(result.AttributeCollection, poiNode);
                HandleElements(result,poiNode);
                resultsNode.Add(poiNode);
            }
            return new XDocument(resultsNode);
        }

        private void HandleElements(Poi result, XElement poiNode)
        {
            poiNode.Add(MakeElement("name", result.Name.Value, true));
            poiNode.Add(MakeElement("description", result.Description.Value,true));
            poiNode.Add(MakeElement("date", result.Date.Value));
            poiNode.Add(MakeElement("l", result.l.Value));
            poiNode.Add(MakeElement("o", result.o.Value));
            poiNode.Add(MakeElement("minaccuracy", result.Minaccuracy.Value));
            poiNode.Add(MakeElement("maxdistance", result.Maxdistance.Value));
            poiNode.Add(MakeElement("mime-type", result.Mimetype.Value.ToString().Replace('_','/')));
            poiNode.Add(MakeElement("mainresource", result.Mainresource.Value));
            poiNode.Add(MakeElement("thumbnail", result.Thumbnail.Value));
            poiNode.Add(MakeElement("icon", result.Icon.Value));
            poiNode.Add(MakeElement("phone", result.Phone.Value));
            poiNode.Add(MakeElement("mail", result.Mail.Value));
            poiNode.Add(MakeElement("homepage", result.Homepage.Value));
        }

        private XElement MakeElement(string localname, object content, bool useCdata = false)
        {
            string value = "";
            XElement element;
            if (content != null)
                value = content.ToString();
            if (useCdata)
                element = new XElement(localname, new XCData(value));
            else 
                element = new XElement(localname,value);
            return element;
        }

        private void HandleAttributes(PoIAttributes attributes, XElement poi)
        {
            var id = new XAttribute("id", attributes.IdAttr);
            var feedback = new XAttribute("interactionfeedback", attributes.InteractionFeedbackAttr);
            poi.Add(id,feedback);
        }

        
    }
}