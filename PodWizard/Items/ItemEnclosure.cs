using System.Xml.Serialization;

namespace PodWizard.Items
{
    public class ItemEnclosure
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }

        [XmlAttribute(AttributeName = "length")]
        public long Length { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        public ItemEnclosure(string url, long length, string type)
        {
            Url = url;
            Length = length;
            Type = type;
        }

        public ItemEnclosure() : this("Empty", -1, "Empty") { }
    }
}
