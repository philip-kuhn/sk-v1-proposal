
using System.Xml;

namespace Microsoft.SemanticKernel.Handlebars;
public class FunctionContentFactory : IMessageContentFactory<FunctionContent>
{
    public FunctionContent ParseMessageContent(XmlNode node)
    {
        FunctionContent messageContent;
        if (node.NodeType == XmlNodeType.Element && node.Name == "function")
        {
            XmlElement element = (XmlElement)node;
            string pluginName = element.GetAttribute("PluginName");
            string name = element.GetAttribute("name");
            messageContent = new FunctionContent(pluginName, name);
        } else
        {
            throw new NotImplementedException();
        }

        return messageContent;
    }

    
}