using System.Xml.Serialization;

namespace PodWizard.Items
{
    public class ItemTranscript
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public TranscriptType Type { get; set; }

        public ItemTranscript(string url, TranscriptType type)
        {
            Url = url;
            Type = type;
        }

        public ItemTranscript() : this("https://www.example.com", TranscriptType.VTT) { }
    }
}
