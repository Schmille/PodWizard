using System.Xml.Serialization;

namespace PodWizard.Channels
{
    public enum PodcastType
    {
        [XmlEnum(Name = "episodic")]
        Episodic,
        [XmlEnum(Name = "serial")]
        Serial
    }
}
