using PodWizard.Channels;
using PodWizard.Items;

namespace PodWizard.Builder.Channel
{
    public interface IGeneralInformation
    {
        public IAuthorInformation AddAuthor();
        public IGeneralInformation WithTitle(string title);
        public IGeneralInformation WithDescription(string description);
        public IGeneralInformation WithImage(string imageUrl);
        public IGeneralInformation WithLanguage(string language);
        public IGeneralInformation WithLink(string link);
        public IGeneralInformation WithItems(IEnumerable<PodcastItem> items);
        public IGeneralInformation WithItemFactory(Func<IEnumerable<PodcastItem>> itemFactory);
    }

    public interface IAuthorInformation
    {
        public IDiscoverabilityInformation AddDiscoverability();
        public IAuthorInformation WithCopyright(string copyright);
        public IAuthorInformation WithAuthor(string author);
        public IAuthorInformation WithOwner(string ownerName, string ownerEmail);
    }

    public interface IDiscoverabilityInformation
    {
        public IOptionalInformation AddOptionalInfo();
        public IDiscoverabilityInformation WithSummary(string summary);
        public IDiscoverabilityInformation WithCategories(params PodcastCategory[] category);
        public IDiscoverabilityInformation WithType(PodcastType type);
        public PodcastChannel Build();
    }

    public interface IOptionalInformation
    {
        public IOptionalInformation WithItems(params PodcastItem[] items);
        public IOptionalInformation WithLastBuild(DateTime time);
        public IOptionalInformation WithGenerator(string generatorName);
        public PodcastChannel Build();
    }

    public class PodcastChannelBuilder : IGeneralInformation, IAuthorInformation, IDiscoverabilityInformation, IOptionalInformation
    {

        private PodcastChannel _channel;

        private PodcastChannelBuilder()
        {
            this._channel = new PodcastChannel();
        }

        public IAuthorInformation AddAuthor()
        {
            return this;
        }

        public IDiscoverabilityInformation AddDiscoverability()
        {
            return this;
        }

        public IOptionalInformation AddOptionalInfo()
        {
            return this;
        }

        public PodcastChannel Build()
        {
            return _channel;
        }

        public IAuthorInformation WithAuthor(string author)
        {
            _channel.Author = author;
            return this;
        }

        public IDiscoverabilityInformation WithCategories(params PodcastCategory[] category)
        {
            _channel.Categories.AddRange(category);
            return this;
        }

        public IAuthorInformation WithCopyright(string copyright)
        {
            _channel.Copyright = copyright;
            return this;
        }

        public IGeneralInformation WithDescription(string description)
        {
            _channel.Description = description;
            return this;
        }

        public IOptionalInformation WithGenerator(string generatorName)
        {
            _channel.Generator = generatorName;
            return this;
        }

        public IGeneralInformation WithImage(string imageUrl)
        {
            _channel.Image = imageUrl;
            return this;
        }

        public IOptionalInformation WithItems(params PodcastItem[] items)
        {
            _channel.Items.AddRange(items);
            return this;
        }

        public IGeneralInformation WithLanguage(string language)
        {
            _channel.Language = language;
            return this;
        }

        public IOptionalInformation WithLastBuild(DateTime time)
        {
            _channel.LastBuildTime = time;
            return this;
        }

        public IGeneralInformation WithLink(string link)
        {
            _channel.Link = link;
            return this;
        }

        public IAuthorInformation WithOwner(string ownerName, string ownerEmail)
        {
            _channel.Owner = new PodcastOwner(ownerName, ownerEmail);
            return this;
        }

        public IDiscoverabilityInformation WithSummary(string summary)
        {
            _channel.Summary = summary;
            return this;
        }

        public IGeneralInformation WithTitle(string title)
        {
            _channel.Title = title;
            return this;
        }

        public IDiscoverabilityInformation WithType(PodcastType type)
        {
            _channel.Type = type;
            return this;
        }

        public static IGeneralInformation Create()
        {
            return new PodcastChannelBuilder();
        }

        public IGeneralInformation WithItems(IEnumerable<PodcastItem> items)
        {
            _channel.Items.AddRange(items);
            return this;
        }

        public IGeneralInformation WithItemFactory(Func<IEnumerable<PodcastItem>> itemFactory)
        {
            _channel.Items.AddRange(itemFactory());
            return this;
        }
    }
}
