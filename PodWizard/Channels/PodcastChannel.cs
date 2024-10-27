using PodWizard.Items;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PodWizard.Channels
{
    [Serializable]
    [XmlRoot(ElementName = "channel")]
    public class PodcastChannel
    {
        #region Standard Tags
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "image")]
        public string? Image { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "category", Namespace = XmlConstants.ItunesNamespace)]
        public List<PodcastCategory> Categories { get; set; }

        [XmlElement(ElementName = "author", Namespace = XmlConstants.ItunesNamespace)]
        public string Author { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "owner", Namespace = XmlConstants.ItunesNamespace)]
        public PodcastOwner Owner { get; set; }

        [XmlElement(ElementName = "type", Namespace = XmlConstants.ItunesNamespace)]
        public PodcastType Type { get; set; }

        [XmlElement(ElementName = "copyright")]
        public string Copyright { get; set; }

        [XmlElement(ElementName = "summary", Namespace = XmlConstants.ItunesNamespace)]
        public string Summary { get; set; }

        [XmlElement(ElementName = "item")]
        public List<PodcastItem> Items { get; set; }
        #endregion

        #region Recommended Tags
        [XmlElement(ElementName = "lastBuildTime")]
        public DateTime? LastBuildTime { get; set; }
        [XmlElement(ElementName = "generator")]
        public string? Generator { get; set; }
        #endregion

        public PodcastChannel() : this(string.Empty, string.Empty, null, string.Empty, new List<PodcastCategory>(), string.Empty, string.Empty, new PodcastOwner(string.Empty, string.Empty), PodcastType.Episodic, string.Empty, string.Empty, new List<PodcastItem>(), DateTime.Now, "PodWizard Library") { }

        public PodcastChannel(string title, string description, string? image, string language, List<PodcastCategory> categories, string author, string link, PodcastOwner owner, PodcastType type, string copyright, string summary, List<PodcastItem> items, DateTime? lastBuildTime, string? generator)
        {
            Title = title;
            Description = description;
            Image = image;
            Language = language;
            Categories = categories;
            Author = author;
            Link = link;
            Owner = owner;
            Type = type;
            Copyright = copyright;
            Summary = summary;
            Items = items;
            LastBuildTime = lastBuildTime;
            Generator = generator;
        }

        public string ToRssFeed()
        {
            return ToRssFeed(true);
        }

        public string ToRssFeed(bool prettyPrinting)
        {
            using MemoryStream stream = new MemoryStream();
            ToRssFeed(stream, prettyPrinting);
            return Encoding.UTF8.GetString(stream.ToArray());
        }

        public void ToRssFeed(Stream stream, bool prettyPrinting)
        {
            XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
            xmlns.Add(XmlConstants.ItunesPrefix, XmlConstants.ItunesNamespace);
            xmlns.Add(XmlConstants.PodlovePrefix, XmlConstants.PodloveNamepsace);
            xmlns.Add(XmlConstants.ContentPrefix, XmlConstants.ContentNamespace);

            XmlSerializer serializer = new XmlSerializer(typeof(PodcastChannel));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = prettyPrinting;

            using XmlWriter writer = XmlWriter.Create(stream, settings);

            writer.WriteStartElement("rss");
            writer.WriteAttributeString("version", "2.0");
            serializer.Serialize(writer, this, xmlns);
            writer.WriteEndElement();

        }
    }
}
