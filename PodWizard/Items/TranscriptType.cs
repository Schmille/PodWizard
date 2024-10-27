using System.Xml.Serialization;

namespace PodWizard.Items
{
    public enum TranscriptType
    {
        [XmlEnum(Name = "text/vtt")]
        VTT,
        [XmlEnum(Name = "text/srt")]
        SRT
    }
}
