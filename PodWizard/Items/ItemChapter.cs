using System.Xml.Serialization;

namespace PodWizard.Items
{
    /// <summary>
    /// Podlove Simple Chapter
    /// </summary>
    public class ItemChapter
    {
        [XmlAttribute(AttributeName = "start", Namespace = XmlConstants.PodloveNamepsace)]
        public string Start { get; set; }

        [XmlAttribute(AttributeName = "title", Namespace = XmlConstants.PodloveNamepsace)]
        public string Title { get; set; }

        public ItemChapter(string start, string title)
        {
            Start = start;
            Title = title;
        }

        public ItemChapter() : this("0", "start") { }
    }
}
