using PodWizard.Builder.Channel;
using PodWizard.Builder.Item;
using PodWizard.Channels;
using PodWizard.Helpers.Categories;
using PodWizard.Items;

namespace PodWizardExample
{
    public class PodcastSource
    {
        public string GetFeed()
        {
            PodcastItem ep1 = PodcastItemBuilder
                .Create()
                    .WithTitle("Creating weird stuff for the internet")
                    .WithSubtitle("Why you should do it any what you should avoid")
                    .WithAuthor("Dr. Richard Funden")
                    .WithImage("https://www.example.com/pod/episode/1.png")
                    .WithDescription("Join our experts while they explain explaining why stuff matters.")
                .AddAudioInfo()
                    .WithLink("https://www.example.com/pod/episode/1")
                    .WithGuid("https://www.example.com/pod/episode/1")
                    .WithAudioEnclosure("https://www.example.com/pod/episode/1.mp3", 24000, "audio/mp3")
                    .WithPubDate(DateTime.Now)
                    .WithType(ItemType.Full)
                .Build();

            PodcastItem ep2 = PodcastItemBuilder
                .Create()
                    .WithTitle("Exploring the Unusual")
                    .WithSubtitle("Diving Deeper into the World of Weird")
                    .WithAuthor("Rainer Wahnsinn")
                    .WithImage("https://www.example.com/pod/episode/2.png")
                    .WithDescription("Join Rainer as he uncovers more about the fascinating and bizarre aspects of the internet.")
                .AddAudioInfo()
                    .WithLink("https://www.example.com/pod/episode/2")
                    .WithGuid("https://www.example.com/pod/episode/2")
                    .WithAudioEnclosure("https://www.example.com/pod/episode/2.mp3", 24000, "audio/mp3")
                    .WithPubDate(DateTime.Now)
                    .WithType(ItemType.Full)
                .Build();

            PodcastItem ep3 = PodcastItemBuilder
                .Create()
                    .WithTitle("Running ever onwards into the void")
                    .WithSubtitle("Weird Sci-Fi ideas that no one thinks possible")
                    .WithAuthor("Thomas W.")
                    .WithImage("https://www.example.com/pod/episode/3.png")
                    .WithDescription("Advance. Only Advance.")
                .AddAudioInfo()
                    .WithLink("https://www.example.com/pod/episode/3")
                    .WithGuid("https://www.example.com/pod/episode/3")
                    .WithAudioEnclosure("https://www.example.com/pod/episode/3.mp3", 24000, "audio/mp3")
                    .WithPubDate(DateTime.Now)
                    .WithType(ItemType.Full)
                .Build();

            PodcastChannel channel = PodcastChannelBuilder
                .Create()
                    .WithTitle("Weird and wonderfull ideas")
                    .WithLanguage("en-gb")
                    .WithImage("https://www.example.com/pod/title.png")
                    .WithLink("https://www.example.com/pod")
                    .WithItems([ep1, ep2, ep3])
                    .WithDescription("Join me in my balloon to the moon!")
                .AddAuthor()
                    .WithCopyright("Weidness Networks")
                    .WithAuthor("Endlessly typing monkeys")
                    .WithOwner("The endless abyss", "info@example.com")
                .AddDiscoverability()
                    .WithCategories(Categories.Arts.PerformingArts)
                    .WithType(PodcastType.Episodic)
                .AddOptionalInfo()
                    .WithLastBuild(DateTime.Now)
                .Build();


            return channel.ToRssFeed();
        }
    }
}
