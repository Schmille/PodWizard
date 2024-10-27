using System.Xml.Serialization;

namespace PodWizard.Items
{
    public class PodcastItem
    {
        #region Standard Tags
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "enclosure")]
        public ItemEnclosure Enclosure { get; set; }

        [XmlElement(ElementName = "guid")]
        public ItemGuid? Guid { get; set; }

        [XmlElement(ElementName = "pubDate")]
        public DateTime PublicationDate { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "duration")]
        public long Duration { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "image", Namespace = XmlConstants.ItunesNamespace)]
        public ItemImage? Image { get; set; }

        [XmlElement(ElementName = "episodeType", Namespace = XmlConstants.ItunesNamespace)]
        public ItemType Type { get; set; }

        [XmlElement(ElementName = "summary", Namespace = XmlConstants.ItunesNamespace)]
        public string Summary { get; set; }
        #endregion

        #region Recommended Tags

        [XmlElement(ElementName = "encoded", Namespace = XmlConstants.ContentNamespace)]
        public string? EncodedContent { get; set; }
        [XmlIgnore]
        private bool EncodedContentSpecified { get => EncodedContent != null; }

        [XmlElement(ElementName = "season", Namespace = XmlConstants.ItunesNamespace)]
        public UInt32? Season { get; set; }
        [XmlIgnore]
        private bool SeasonSpecified { get => Season != null; }

        [XmlElement(ElementName = "episode", Namespace = XmlConstants.ItunesNamespace)]
        public UInt32? Episode { get; set; }
        [XmlIgnore]
        private bool EpisodeSpecified { get => Episode != null; }

        [XmlElement(ElementName = "subtitle", Namespace = XmlConstants.ItunesNamespace)]
        public string? Subtitle { get; set; }
        [XmlIgnore]
        private bool SubtitleSpecified { get => Subtitle != null; }

        [XmlElement(ElementName = "author", Namespace = XmlConstants.ItunesNamespace)]
        public string? Author { get; set; }
        [XmlIgnore]
        private bool AuthorSpecified { get => Author != null; }

        [XmlElement(ElementName = "podcast:transcript")]
        public ItemTranscript? Transcript { get; set; }
        [XmlIgnore]
        private bool TranscriptSpecified { get => Transcript != null; }

        [XmlArray(ElementName = "chapters", Namespace = XmlConstants.PodloveNamepsace)]
        [XmlArrayItem(ElementName = "chapter", Namespace = XmlConstants.PodloveNamepsace)]
        public List<ItemChapter>? Chapters { get; set; }
        [XmlIgnore]
        private bool ChaptersSpecified { get => Chapters != null; }
        #endregion

        public PodcastItem(string title, string link)
        {
            Title = title;
            Link = link;
            Guid = new ItemGuid(link);
            PublicationDate = DateTime.Now;
            Enclosure = new ItemEnclosure(string.Empty, 0, string.Empty);
            Description = string.Empty;
            Image = null;
            Summary = string.Empty;
            EncodedContent = string.Empty;
        }

        public PodcastItem() : this("Empty", "Empty") { }
    }
}
