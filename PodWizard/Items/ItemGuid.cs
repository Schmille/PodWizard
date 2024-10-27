using System.Xml.Serialization;

namespace PodWizard.Items
{
    public class ItemGuid
    {
        [XmlAttribute(AttributeName = "isPermalink")]
        public bool IsPermalink { get; set; } = true;

        [XmlText]
        public string Guid { get; set; }

        public ItemGuid(string guid)
        {
            Guid = guid;
            IsPermalink = true;
        }

        public ItemGuid() : this("Empty") { }
    }
}
