using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedInLearningDownloader.Models
{

    public class GetVideo
    {
        public Element[] elements { get; set; }
        public Paging paging { get; set; }

        public class Paging
        {
            public int count { get; set; }
            public int start { get; set; }
            public object[] links { get; set; }
        }

        public class Element
        {
            public int durationInSeconds { get; set; }
            public bool eligibleForCompletionCertificate { get; set; }
            public Chapter[] chapters { get; set; }
            public string difficultyLevel { get; set; }
            public string welcomeVideo { get; set; }
            public bool fullCourseUnlocked { get; set; }
            public string description { get; set; }
            public bool coursePurchased { get; set; }
            public string source { get; set; }
            public string title { get; set; }
            public Locale locale { get; set; }
            public string lifecycle { get; set; }
            public bool canAddToProfile { get; set; }
            public bool inactive { get; set; }
            public string webThumbnail { get; set; }
            public Credentialingprogramdata credentialingProgramData { get; set; }
            public bool courseContextuallyUnlocked { get; set; }
            public bool studyGroupAccessible { get; set; }
            public Category[] categories { get; set; }
            public bool containsSummativeExam { get; set; }
            public string slug { get; set; }
            public object[] assessments { get; set; }
            public Companyviewercount[] companyViewerCounts { get; set; }
            public Like like { get; set; }
            public Viewingstatus viewingStatus { get; set; }
            public int viewerCount { get; set; }
            public Titleviewercount[] titleViewerCounts { get; set; }
            public int bookmarkCounts { get; set; }
            public string shortDescription { get; set; }
            public string courseVisibilityStatus { get; set; }
            public string hashedCourseId { get; set; }
            public Selectedvideo selectedVideo { get; set; }
            public long releasedOn { get; set; }
            public string urn { get; set; }
            public Bookmark2 bookmark { get; set; }
            public Associatedskill[] associatedSkills { get; set; }
            public object[] learningPaths { get; set; }
            public Exercisefile[] exerciseFiles { get; set; }
            public bool showQuestionsTab { get; set; }
            public string[] exerciseFileUrls { get; set; }
            public string mobileThumbnail { get; set; }
            public string cachingKey { get; set; }
            public bool containsPracticeExam { get; set; }
            public Author1[] authors { get; set; }
        }

        public class Locale
        {
            public string country { get; set; }
            public string language { get; set; }
        }

        public class Credentialingprogramdata
        {
            public Userprogramselection userProgramSelection { get; set; }
            public object[] credentialingPrograms { get; set; }
        }

        public class Userprogramselection
        {
            public string cachingKey { get; set; }
        }

        public class Like
        {
            public string cachingKey { get; set; }
            public Details details { get; set; }
        }

        public class Details
        {
            public Liker[] likers { get; set; }
            public bool liked { get; set; }
            public int totalLikes { get; set; }
        }

        public class Liker
        {
            public string urn { get; set; }
            public string memberDistance { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string vanityName { get; set; }
            public string pictureId { get; set; }
            public string publicUrl { get; set; }
            public Profileimage profileImage { get; set; }
            public string headline { get; set; }
        }

        public class Profileimage
        {
            public Source source { get; set; }
        }

        public class Source
        {
            public ComLinkedinLearningApiCommonSizedimage comlinkedinlearningapicommonSizedImage { get; set; }
        }

        public class ComLinkedinLearningApiCommonSizedimage
        {
            public Slice[] slices { get; set; }
        }

        public class Slice
        {
            public Dimension dimension { get; set; }
            public string url { get; set; }
        }

        public class Dimension
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Viewingstatus
        {
            public string cachingKey { get; set; }
            public Details1 details { get; set; }
        }

        public class Details1
        {
            public bool complCertificateAddedToProfile { get; set; }
            public int totalCompletedVideoDurationInSeconds { get; set; }
            public string statusType { get; set; }
            public bool canDownloadCertificate { get; set; }
            public int durationInSecondsViewed { get; set; }
            public Lastviewedcontent lastViewedContent { get; set; }
            public long lastViewedAt { get; set; }
            public bool markedAsDone { get; set; }
        }

        public class Lastviewedcontent
        {
            public ComLinkedinLearningApiBasicvideo comlinkedinlearningapiBasicVideo { get; set; }
        }

        public class ComLinkedinLearningApiBasicvideo
        {
            public string urn { get; set; }
            public Bookmark bookmark { get; set; }
            public bool accessible { get; set; }
            public int durationInSeconds { get; set; }
            public bool _public { get; set; }
            public string lyndaUrl { get; set; }
            public bool androidPublic { get; set; }
            public Viewingstatus1 viewingStatus { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
        }

        public class Bookmark
        {
            public string cachingKey { get; set; }
        }

        public class Viewingstatus1
        {
            public string cachingKey { get; set; }
            public Details2 details { get; set; }
        }

        public class Details2
        {
            public int offsetInSeconds { get; set; }
            public string statusType { get; set; }
            public int durationInSecondsViewed { get; set; }
            public long lastViewedAt { get; set; }
        }

        public class Selectedvideo
        {
            public bool accessible { get; set; }
            public Format[] formats { get; set; }
            public Notes notes { get; set; }
            public int durationInSeconds { get; set; }
            public string lyndaUrl { get; set; }
            public bool androidPublic { get; set; }
            public Viewingstatus2 viewingStatus { get; set; }
            public string defaultThumbnail { get; set; }
            public long publishedOn { get; set; }
            public string description { get; set; }
            public string title { get; set; }
            public Url url { get; set; }
            public string urn { get; set; }
            public Bookmark1 bookmark { get; set; }
            public Transcript transcript { get; set; }
            public bool _public { get; set; }
            public Course course { get; set; }
            public Audio audio { get; set; }
            public string slug { get; set; }
            public Author[] authors { get; set; }
        }

        public class Notes
        {
            public string cachingKey { get; set; }
            public object[] details { get; set; }
            public object[] notes { get; set; }
        }

        public class Viewingstatus2
        {
            public string cachingKey { get; set; }
            public Details3 details { get; set; }
        }

        public class Details3
        {
            public int offsetInSeconds { get; set; }
            public string statusType { get; set; }
            public int durationInSecondsViewed { get; set; }
            public long lastViewedAt { get; set; }
        }

        public class Url
        {
            public string progressiveUrl { get; set; }
            public long expiresAt { get; set; }
            public string streamingUrl { get; set; }
        }

        public class Bookmark1
        {
            public string cachingKey { get; set; }
        }

        public class Transcript
        {
            public Line[] lines { get; set; }
        }

        public class Line
        {
            public int transcriptStartAt { get; set; }
            public string caption { get; set; }
        }

        public class Course
        {
            public int durationInSeconds { get; set; }
            public string difficultyLevel { get; set; }
            public string description { get; set; }
            public string shortDescription { get; set; }
            public string title { get; set; }
            public Locale1 locale { get; set; }
            public long releasedOn { get; set; }
            public string urn { get; set; }
            public string lifecycle { get; set; }
            public string webThumbnail { get; set; }
            public string mobileThumbnail { get; set; }
            public string slug { get; set; }
            public object[] authors { get; set; }
        }

        public class Locale1
        {
            public string country { get; set; }
            public string language { get; set; }
        }

        public class Audio
        {
            public string progressiveUrl { get; set; }
            public long expiresAt { get; set; }
        }

        public class Format
        {
            public int width { get; set; }
            public string extension { get; set; }
            public int height { get; set; }
        }

        public class Author
        {
            public string lastName { get; set; }
            public string lyndaUrl { get; set; }
            public string biography { get; set; }
            public Follow follow { get; set; }
            public string urn { get; set; }
            public string firstName { get; set; }
            public bool influencer { get; set; }
            public string webThumbnail { get; set; }
            public string publicUrl { get; set; }
            public bool canFollow { get; set; }
            public string mobileThumbnail { get; set; }
            public string headline { get; set; }
            public string slug { get; set; }
        }

        public class Follow
        {
            public string cachingKey { get; set; }
        }

        public class Bookmark2
        {
            public string cachingKey { get; set; }
        }

        public class Chapter
        {
            public string urn { get; set; }
            public Video[] videos { get; set; }
            public string title { get; set; }
            public int durationInSeconds { get; set; }
        }

        public class Video
        {
            public string urn { get; set; }
            public Bookmark3 bookmark { get; set; }
            public bool accessible { get; set; }
            public int durationInSeconds { get; set; }
            public bool _public { get; set; }
            public string lyndaUrl { get; set; }
            public bool androidPublic { get; set; }
            public Viewingstatus3 viewingStatus { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
        }

        public class Bookmark3
        {
            public string cachingKey { get; set; }
        }

        public class Viewingstatus3
        {
            public string cachingKey { get; set; }
            public Details4 details { get; set; }
        }

        public class Details4
        {
            public int offsetInSeconds { get; set; }
            public string statusType { get; set; }
            public int durationInSecondsViewed { get; set; }
            public long lastViewedAt { get; set; }
        }

        public class Category
        {
            public string urn { get; set; }
            public string name { get; set; }
            public Locale2 locale { get; set; }
            public string type { get; set; }
            public string slug { get; set; }
            public string trackingId { get; set; }
            public string lyndaUrl { get; set; }
        }

        public class Locale2
        {
            public string country { get; set; }
            public string language { get; set; }
        }

        public class Companyviewercount
        {
            public string company { get; set; }
            public int viewerCount { get; set; }
            public Basiccompany basicCompany { get; set; }
            public string companyName { get; set; }
        }

        public class Basiccompany
        {
            public string urn { get; set; }
            public string name { get; set; }
            public string logo { get; set; }
            public Logoimage logoImage { get; set; }
        }

        public class Logoimage
        {
            public Source1 source { get; set; }
        }

        public class Source1
        {
            public ComLinkedinLearningApiCommonSizedimage1 comlinkedinlearningapicommonSizedImage { get; set; }
        }

        public class ComLinkedinLearningApiCommonSizedimage1
        {
            public Slice1[] slices { get; set; }
        }

        public class Slice1
        {
            public Dimension1 dimension { get; set; }
            public string url { get; set; }
        }

        public class Dimension1
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Titleviewercount
        {
            public string titleUrn { get; set; }
            public string title { get; set; }
            public int viewerCount { get; set; }
        }

        public class Associatedskill
        {
            public string name { get; set; }
            public string urn { get; set; }
            public Mappedcategory mappedCategory { get; set; }
        }

        public class Mappedcategory
        {
            public string urn { get; set; }
            public string lyndaUrl { get; set; }
            public string name { get; set; }
            public Locale3 locale { get; set; }
            public string type { get; set; }
            public string slug { get; set; }
            public string trackingId { get; set; }
        }

        public class Locale3
        {
            public string country { get; set; }
            public string language { get; set; }
        }

        public class Exercisefile
        {
            public string name { get; set; }
            public string url { get; set; }
            public long sizeInBytes { get; set; }
        }

        public class Author1
        {
            public string lastName { get; set; }
            public string lyndaUrl { get; set; }
            public string biography { get; set; }
            public Follow1 follow { get; set; }
            public string urn { get; set; }
            public string firstName { get; set; }
            public bool influencer { get; set; }
            public string webThumbnail { get; set; }
            public string publicUrl { get; set; }
            public bool canFollow { get; set; }
            public string mobileThumbnail { get; set; }
            public string headline { get; set; }
            public string slug { get; set; }
        }

        public class Follow1
        {
            public string cachingKey { get; set; }
        }
    }



}
