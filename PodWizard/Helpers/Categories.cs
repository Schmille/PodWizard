using PodWizard.Channels;

namespace PodWizard.Helpers.Categories
{
    /// <summary>
    /// Static factory for Apple iTunes podcast categories.
    /// </summary>
    public static class Categories
    {
        public static Arts Arts { get; } = new Arts();
        public static Business Business { get; } = new Business();
        public static Comedy Comedy { get; } = new Comedy();
        public static Education Education { get; } = new Education();
        public static Fiction Fiction { get; } = new Fiction();
        public static PodcastCategory Government { get => new PodcastCategory("Government", null); }
        public static PodcastCategory History { get => new PodcastCategory("History", null); }
        public static HealthAndFitness HealthAndFitness { get; } = new HealthAndFitness();
        public static KidsAndFamily KidsAndFamily { get; } = new KidsAndFamily();
        public static Leisure Leisure { get; } = new Leisure();
        public static Music Music { get; } = new Music();
        public static News News { get; } = new News();
        public static ReligionAndSpirituality ReligionAndSpirituality { get; } = new ReligionAndSpirituality();
        public static Science Science { get; } = new Science();
        public static SocietyAndCulture SocietyAndCulture { get; } = new SocietyAndCulture();
        public static Sports Sports { get; } = new Sports();
        public static PodcastCategory Technology { get => new PodcastCategory("Technology", null); }
        public static PodcastCategory TrueCrime { get => new PodcastCategory("True Crime", null); }
        public static TvAndFilm TvAndFilm { get; } = new TvAndFilm();
    }

    public class Arts
    {
        public PodcastCategory Default { get => new PodcastCategory("Arts", null); }
        public PodcastCategory Books { get => new PodcastCategory("Arts", "Books"); }
        public PodcastCategory Design { get => new PodcastCategory("Arts", "Design"); }
        public PodcastCategory FashionAndBeauty { get => new PodcastCategory("Arts", "Fashion & Beauty"); }
        public PodcastCategory Food { get => new PodcastCategory("Arts", "Food"); }
        public PodcastCategory PerformingArts { get => new PodcastCategory("Arts", "Performing Arts"); }
        public PodcastCategory VisualArts { get => new PodcastCategory("Arts", "Visual Arts"); }
    }

    public class Business
    {
        public PodcastCategory Default { get => new PodcastCategory("Business", null); }
        public PodcastCategory Careers { get => new PodcastCategory("Business", "Careers"); }
        public PodcastCategory Entrepreneurship { get => new PodcastCategory("Business", "Entrepreneurship"); }
        public PodcastCategory Investing { get => new PodcastCategory("Business", "Investing"); }
        public PodcastCategory Management { get => new PodcastCategory("Business", "Management"); }
        public PodcastCategory Marketing { get => new PodcastCategory("Business", "Marketing"); }
        public PodcastCategory NonProfit { get => new PodcastCategory("Business", "Non-Profit"); }
    }

    public class Comedy
    {
        public PodcastCategory Default { get => new PodcastCategory("Comedy", null); }
        public PodcastCategory ComedyInterviews { get => new PodcastCategory("Comedy", "Comedy Interviews"); }
        public PodcastCategory Improv { get => new PodcastCategory("Comedy", "Improv"); }
        public PodcastCategory StandUp { get => new PodcastCategory("Comedy", "Stand-Up"); }
    }

    public class Education
    {
        public PodcastCategory Default { get => new PodcastCategory("Education", null); }
        public PodcastCategory Courses { get => new PodcastCategory("Education", "Courses"); }
        public PodcastCategory HowTo { get => new PodcastCategory("Education", "How To"); }
        public PodcastCategory LanguageLearning { get => new PodcastCategory("Education", "Language Learning"); }
        public PodcastCategory SelfImprovement { get => new PodcastCategory("Education", "Self-Improvement"); }
    }

    public class Fiction
    {
        public PodcastCategory Default { get => new PodcastCategory("Fiction", null); }
        public PodcastCategory ComedyFiction { get => new PodcastCategory("Fiction", "Comedy Fiction"); }
        public PodcastCategory Drama { get => new PodcastCategory("Fiction", "Drama"); }
        public PodcastCategory ScienceFiction { get => new PodcastCategory("Fiction", "Science Fiction"); }
    }

    public class HealthAndFitness
    {
        public PodcastCategory Default { get => new PodcastCategory("Health & Fitness", null); }
        public PodcastCategory AlternativeHealth { get => new PodcastCategory("Health & Fitness", "Alternative Health"); }
        public PodcastCategory Fitness { get => new PodcastCategory("Health & Fitness", "Fitness"); }
        public PodcastCategory Medicine { get => new PodcastCategory("Health & Fitness", "Medicine"); }
        public PodcastCategory MentalHealth { get => new PodcastCategory("Health & Fitness", "Mental Health"); }
        public PodcastCategory Nutrition { get => new PodcastCategory("Health & Fitness", "Nutrition"); }
        public PodcastCategory Sexuality { get => new PodcastCategory("Health & Fitness", "Sexuality"); }
    }

    public class KidsAndFamily
    {
        public PodcastCategory Default { get => new PodcastCategory("Kids & Family", null); }
        public PodcastCategory EducationForKids { get => new PodcastCategory("Kids & Family", "Education for Kids"); }
        public PodcastCategory Parenting { get => new PodcastCategory("Kids & Family", "Parenting"); }
        public PodcastCategory PetsAndAnimals { get => new PodcastCategory("Kids & Family", "Pets & Animals"); }
        public PodcastCategory StoriesForKids { get => new PodcastCategory("Kids & Family", "Stories for Kids"); }
    }

    public class Leisure
    {
        public PodcastCategory Default { get => new PodcastCategory("Leisure", null); }
        public PodcastCategory AnimationAndManga { get => new PodcastCategory("Leisure", "Animation & Manga"); }
        public PodcastCategory Automotive { get => new PodcastCategory("Leisure", "Automotive"); }
        public PodcastCategory Aviation { get => new PodcastCategory("Leisure", "Aviation"); }
        public PodcastCategory Crafts { get => new PodcastCategory("Leisure", "Crafts"); }
        public PodcastCategory Games { get => new PodcastCategory("Leisure", "Games"); }
        public PodcastCategory Hobbies { get => new PodcastCategory("Leisure", "Hobbies"); }
        public PodcastCategory HomeAndGarden { get => new PodcastCategory("Leisure", "Home & Garden"); }
        public PodcastCategory VideoGames { get => new PodcastCategory("Leisure", "Video Games"); }
    }

    public class Music
    {
        public PodcastCategory Default { get => new PodcastCategory("Music", null); }
        public PodcastCategory MusicCommentary { get => new PodcastCategory("Music", "Music Commentary"); }
        public PodcastCategory MusicHistory { get => new PodcastCategory("Music", "Music History"); }
        public PodcastCategory MusicInterviews { get => new PodcastCategory("Music", "Music Interviews"); }
    }

    public class News
    {
        public PodcastCategory Default { get => new PodcastCategory("News", null); }
        public PodcastCategory BusinessNews { get => new PodcastCategory("News", "Business News"); }
        public PodcastCategory DailyNews { get => new PodcastCategory("News", "Daily News"); }
        public PodcastCategory EntertainmentNews { get => new PodcastCategory("News", "Entertainment News"); }
        public PodcastCategory NewsCommentary { get => new PodcastCategory("News", "News Commentary"); }
        public PodcastCategory PoliticsNews { get => new PodcastCategory("News", "Politics News"); }
        public PodcastCategory SportsNews { get => new PodcastCategory("News", "Sports News"); }
        public PodcastCategory TechNews { get => new PodcastCategory("News", "Tech News"); }
    }

    public class ReligionAndSpirituality
    {
        public PodcastCategory Default { get => new PodcastCategory("Religion & Spirituality", null); }
        public PodcastCategory Buddhism { get => new PodcastCategory("Religion & Spirituality", "Buddhism"); }
        public PodcastCategory Christianity { get => new PodcastCategory("Religion & Spirituality", "Christianity"); }
        public PodcastCategory Hinduism { get => new PodcastCategory("Religion & Spirituality", "Hinduism"); }
        public PodcastCategory Islam { get => new PodcastCategory("Religion & Spirituality", "Islam"); }
        public PodcastCategory Judaism { get => new PodcastCategory("Religion & Spirituality", "Judaism"); }
        public PodcastCategory Religion { get => new PodcastCategory("Religion & Spirituality", "Religion"); }
        public PodcastCategory Spirituality { get => new PodcastCategory("Religion & Spirituality", "Spirituality"); }
    }

    public class Science
    {
        public PodcastCategory Default { get => new PodcastCategory("Science", null); }
        public PodcastCategory Astronomy { get => new PodcastCategory("Science", "Astronomy"); }
        public PodcastCategory Chemistry { get => new PodcastCategory("Science", "Chemistry"); }
        public PodcastCategory EarthSciences { get => new PodcastCategory("Science", "Earth Sciences"); }
        public PodcastCategory LifeSciences { get => new PodcastCategory("Science", "Life Sciences"); }
        public PodcastCategory Mathematics { get => new PodcastCategory("Science", "Mathematics"); }
        public PodcastCategory NaturalSciences { get => new PodcastCategory("Science", "Natural Sciences"); }
        public PodcastCategory Nature { get => new PodcastCategory("Science", "Nature"); }
        public PodcastCategory Physics { get => new PodcastCategory("Science", "Physics"); }
        public PodcastCategory SocialSciences { get => new PodcastCategory("Science", "Social Sciences"); }
    }

    public class SocietyAndCulture
    {
        public PodcastCategory Default { get => new PodcastCategory("Society & Culture", null); }
        public PodcastCategory Documentary { get => new PodcastCategory("Society & Culture", "Documentary"); }
        public PodcastCategory PersonalJournals { get => new PodcastCategory("Society & Culture", "Personal Journals"); }
        public PodcastCategory Philosophy { get => new PodcastCategory("Society & Culture", "Philosophy"); }
        public PodcastCategory PlacesAndTravel { get => new PodcastCategory("Society & Culture", "Places & Travel"); }
        public PodcastCategory Relationships { get => new PodcastCategory("Society & Culture", "Relationships"); }

    }

    public class Sports
    {
        public PodcastCategory Default { get => new PodcastCategory("Sports", null); }
        public PodcastCategory Baseball { get => new PodcastCategory("Sports", "Baseball"); }
        public PodcastCategory Basketball { get => new PodcastCategory("Sports", "Basketball"); }
        public PodcastCategory Cricket { get => new PodcastCategory("Sports", "Cricket"); }
        public PodcastCategory FantasySports { get => new PodcastCategory("Sports", "Fantasy Sports"); }
        public PodcastCategory Football { get => new PodcastCategory("Sports", "Football"); }
        public PodcastCategory Golf { get => new PodcastCategory("Sports", "Golf"); }
        public PodcastCategory Hockey { get => new PodcastCategory("Sports", "Hockey"); }
        public PodcastCategory Rugby { get => new PodcastCategory("Sports", "Rugby"); }
        public PodcastCategory Running { get => new PodcastCategory("Sports", "Running"); }
        public PodcastCategory Soccer { get => new PodcastCategory("Sports", "Soccer"); }
        public PodcastCategory Swimming { get => new PodcastCategory("Sports", "Swimming"); }
        public PodcastCategory Tennis { get => new PodcastCategory("Sports", "Tennis"); }
        public PodcastCategory Volleyball { get => new PodcastCategory("Sports", "Volleyball"); }
        public PodcastCategory Wilderness { get => new PodcastCategory("Sports", "Wilderness Sports"); }
        public PodcastCategory Wrestling { get => new PodcastCategory("Sports", "Wrestling"); }
    }

    public class TvAndFilm
    {
        public PodcastCategory Default { get => new PodcastCategory("TV & Film", null); }
        public PodcastCategory AfterShows { get => new PodcastCategory("TV & Film", "After Shows"); }
        public PodcastCategory FilmHistory { get => new PodcastCategory("TV & Film", "Film History"); }
        public PodcastCategory FilmInterviews { get => new PodcastCategory("TV & Film", "Film Interviews"); }
        public PodcastCategory FilmReviews { get => new PodcastCategory("TV & Film", "Film Reviews"); }
        public PodcastCategory TvReviews { get => new PodcastCategory("TV & Film", "TV Reviews"); }
    }
}
