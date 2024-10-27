using System.Xml.Serialization;

namespace PodWizard.Items
{
    public enum ItemType
    {
        [XmlEnum(Name = "full")]
        Full,
        [XmlEnum(Name = "trailer")]
        Trailer,
        [XmlEnum(Name = "bonus")]
        Bonus
    }
}
