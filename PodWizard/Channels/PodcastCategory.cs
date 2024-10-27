using System.Xml.Serialization;

namespace PodWizard.Channels
{
    public class PodcastCategory
    {
        [XmlAttribute(AttributeName = "text")]
        public string Text { get; set; }

        [XmlElement(ElementName = "category", Namespace = XmlConstants.ItunesNamespace)]
        public string? Subcategory { get; set; }

        public PodcastCategory(string text, string? subcategory)
        {
            Text = text;
            Subcategory = subcategory;
        }

        public PodcastCategory() : this("Empty", "Empty") { }
    }
}
