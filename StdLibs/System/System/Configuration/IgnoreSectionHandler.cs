using System.Xml;

namespace System.Configuration
{
    public class IgnoreSectionHandler : IConfigurationSectionHandler
    {
        public virtual object Create(object parent, object configContext, XmlNode section)
        {
             throw new NotImplementedException();
        }
        
        
        public IgnoreSectionHandler()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
