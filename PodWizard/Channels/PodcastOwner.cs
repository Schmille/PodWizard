using System.Xml.Serialization;

namespace PodWizard.Channels
{
    public class PodcastOwner
    {
        [XmlElement(ElementName = "name", Namespace = XmlConstants.ItunesNamespace)]
        public string Name { get; set; }
        [XmlElement(ElementName = "email", Namespace = XmlConstants.ItunesNamespace)]
        public string EMail { get; set; }

        public PodcastOwner(string name, string email)
        {
            Name = name;
            EMail = email;
        }

        public PodcastOwner() : this("Empty", "Empty") { }
    }
}
