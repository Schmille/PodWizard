using PodWizard.Items;

namespace PodWizard.Builder.Item
{

    public interface ITitleInfo
    {
        ITitleInfo WithTitle(string title);
        ITitleInfo WithSubtitle(string subtitle);
        ITitleInfo WithDescription(string description);
        ITitleInfo WithSummary(string summary);
        ITitleInfo WithAuthor(string author);
        ITitleInfo WithImage(string url);
        ITitleInfo WithEncodedContent(string content);
        IAudioInfo AddAudioInfo();
    }

    public interface IAudioInfo
    {
        IAudioInfo WithAudioEnclosure(string url, int seconds, string type);
        IAudioInfo WithGuid(string guid);
        IAudioInfo WithPubDate(DateTime pubDate);
        IAudioInfo WithLink(string link);

        IAudioInfo WithType(ItemType itemType);
        IOptionalMetadata AddOptionalMetadata();
        PodcastItem Build();
    }

    public interface IOptionalMetadata
    {
        IOptionalMetadata WithChapter(string start, string title);
        IOptionalMetadata WithChapter(ItemChapter chapter);
        IOptionalMetadata WithChapters(IEnumerable<ItemChapter> chapters);
        IOptionalMetadata WithSeason(uint season);
        IOptionalMetadata WithEpisodeNumber(uint episodeNumber);
        IOptionalMetadata WithTranscript(string url, TranscriptType transcriptType);
        IOptionalMetadata WithTranscript(ItemTranscript transcript);
        PodcastItem Build();
    }

    public class PodcastItemBuilder : ITitleInfo, IAudioInfo, IOptionalMetadata
    {
        private PodcastItem _Item;
        private PodcastItemBuilder()
        {
            this._Item = new PodcastItem();
        }

        public static ITitleInfo Create()
        {
            return new PodcastItemBuilder();
        }

        public PodcastItem Build()
        {
            return this._Item;
        }

        public IOptionalMetadata WithAuthor(string author)
        {
            _Item.Author = author;
            return this;
        }

        public IOptionalMetadata WithChapter(string start, string title)
        {
            return WithChapter(new ItemChapter(start, title));
        }

        public IOptionalMetadata WithChapter(ItemChapter chapter)
        {
            if (_Item.Chapters == null)
                _Item.Chapters = new List<ItemChapter>();

            _Item.Chapters.Add(chapter);
            return this;
        }

        public IOptionalMetadata WithEpisodeNumber(uint episodeNumber)
        {
            _Item.Episode = episodeNumber;
            return this;
        }

        public IOptionalMetadata WithSeason(uint season)
        {
            _Item.Season = season;
            return this;
        }

        public IOptionalMetadata WithTranscript(string url, TranscriptType transcriptType)
        {
            return WithTranscript(new ItemTranscript(url, transcriptType));
        }

        public IOptionalMetadata WithTranscript(ItemTranscript transcript)
        {
            _Item.Transcript = transcript;
            return this;
        }

        public IOptionalMetadata AddOptionalInfo()
        {
            return this;
        }

        public ITitleInfo WithTitle(string title)
        {
            _Item.Title = title;
            return this;
        }

        public ITitleInfo WithDescription(string description)
        {
            _Item.Description = description;
            return this;
        }

        public ITitleInfo WithSummary(string summary)
        {
            _Item.Summary = summary;
            return this;
        }

        ITitleInfo ITitleInfo.WithAuthor(string author)
        {
            _Item.Author = author;
            return this;
        }

        public ITitleInfo WithImage(string url)
        {
            _Item.Image = new ItemImage(url);
            return this;
        }

        public ITitleInfo WithEncodedContent(string content)
        {
            _Item.EncodedContent = content;
            return this;
        }

        public IAudioInfo AddAudioInfo()
        {
            return this;
        }

        public IAudioInfo WithAudioEnclosure(string url, int seconds, string type)
        {
            _Item.Enclosure = new ItemEnclosure(url, seconds, type);
            return this;
        }

        public IAudioInfo WithGuid(string guid)
        {
            _Item.Guid = new ItemGuid(guid);
            return this;
        }

        public IAudioInfo WithPubDate(DateTime pubDate)
        {
            _Item.PublicationDate = pubDate;
            return this;
        }

        public IAudioInfo WithLink(string link)
        {
            _Item.Link = link;
            return this;
        }

        public IAudioInfo WithType(ItemType itemType)
        {
            _Item.Type = itemType;
            return this;
        }

        public IOptionalMetadata AddOptionalMetadata()
        {
            return this;
        }

        public ITitleInfo WithSubtitle(string subtitle)
        {
            _Item.Subtitle = subtitle;
            return this;
        }

        public IOptionalMetadata WithChapters(IEnumerable<ItemChapter> chapters)
        {
            foreach (ItemChapter chapter in chapters)
                WithChapter(chapter);
            return this;
        }
    }
}
