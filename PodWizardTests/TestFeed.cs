using CodeHollow.FeedReader;
using PodWizard.Builder.Channel;
using PodWizard.Builder.Item;
using PodWizard.Channels;
using PodWizard.Helpers.Categories;
using PodWizard.Items;

namespace PodWizardTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestFeedCreation()
        {


            PodcastItem item = PodcastItemBuilder
                .Create()
                    .WithTitle("The problem of serialization")
                    .WithSubtitle("Why .NET Xml Serialization feels weird, but is proabably fine.")
                    .WithDescription("Many interesting things")
                    .WithSummary("In this episode, we will find out, why serialization is important and how podcasts are distributed")
                    .WithAuthor("Schmille")
               .AddAudioInfo()
                    .WithLink("https://www.example.com/episodes/1")
                    .WithGuid("https://www.example.com/episodes/1")
                    .WithAudioEnclosure("https://www.example.com/episodes/1/audio.mp4", 3600, "audio/mp4")
                    .WithPubDate(DateTime.Parse("2024-05-01"))
                    .AddOptionalMetadata()
                    .WithChapters(
                    [
                        new ItemChapter("0", "Intro"),
                        new ItemChapter("30", "Welcome to serialization!"),
                        new ItemChapter("20:52", "The .NET conjecture"),
                        new ItemChapter("45:52", "The XML conspiracy"),
                        new ItemChapter("55:00", "Summary"),
                        new ItemChapter("59:30", "Outro")
                    ]
                )
                .Build();

            PodcastChannel channel = PodcastChannelBuilder
                .Create()
                    .WithTitle("CreatingPodWizard")
                    .WithLanguage("en-gb")
                    .WithLink("https://www.example.com/podcast")
                    .WithImage("https://www.example.com/podcast/image")
                    .WithDescription("Follow me on my (short) journey to create and test PodWizard. This is not an actual Podcast.")
                    .WithItems([item])
                .AddAuthor()
                    .WithAuthor("Schmille")
                    .WithCopyright("Schmille, 2024")
                    .WithOwner("Schmille", "schmille@example.com")
                .AddDiscoverability()
                    .WithCategories(Categories.Technology, Categories.Arts.Design, Categories.HealthAndFitness.Nutrition)
                    .WithType(PodcastType.Episodic)
                    .WithSummary("What is a podcast? How do you create a feed in .NET? What even is XML? This and much more!")
                .Build();

            string rss = channel.ToRssFeed();
            Feed feed = FeedReader.ReadFromString(rss);

            Assert.That(feed, Is.Not.Null);
            Assert.That(feed.Title, Is.EqualTo("CreatingPodWizard"));
            Assert.That(feed.Description, Is.EqualTo("Follow me on my (short) journey to create and test PodWizard. This is not an actual Podcast."));
            Assert.That(feed.Items.Count, Is.EqualTo(1));
        }
    }
}