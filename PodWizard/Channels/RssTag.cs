using System.Xml.Serialization;

namespace PodWizard.Channels
{
    public class RssTag
    {
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        public RssTag()
        {
            Version = "2.0";
        }
    }
}
