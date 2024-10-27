using PodWizard.Channels;
using System.Xml.Serialization;

namespace PodWizard.Helpers
{
    [XmlRoot(IsNullable = false, ElementName = "root")]
    [Serializable]
    public class XmlRootElement
    {
        [XmlElement(ElementName = "rss")]
        public RssTag Rss { get; init; }
        public PodcastChannel Channel { get; init; }

        public XmlRootElement() : this(new PodcastChannel()) { }

        public XmlRootElement(PodcastChannel channel)
        {
            Rss = new RssTag();
            Channel = channel;
        }
    }
}
