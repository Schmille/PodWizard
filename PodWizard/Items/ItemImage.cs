using System.Xml.Serialization;

namespace PodWizard.Items
{
    public class ItemImage
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }

        public ItemImage(string href)
        {
            Href = href;
        }

        public ItemImage() : this("https://www.example.com") { }
    }
}
