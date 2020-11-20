using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedInLearningDownloader.Models
{
    public class GetCourse
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
            public bool fullCourseUnlocked { get; set; }
            public string[] exerciseFileUrls { get; set; }
            public Chapter[] chapters { get; set; }
            public Exercisefile[] exerciseFiles { get; set; }
            public long releasedOn { get; set; }
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
            public Bookmark bookmark { get; set; }
            public bool accessible { get; set; }
            public int durationInSeconds { get; set; }
            public bool _public { get; set; }
            public string lyndaUrl { get; set; }
            public bool androidPublic { get; set; }
            public Viewingstatus viewingStatus { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
        }

        public class Bookmark
        {
            public string cachingKey { get; set; }
        }

        public class Viewingstatus
        {
            public string cachingKey { get; set; }
            public Details details { get; set; }
        }

        public class Details
        {
            public int offsetInSeconds { get; set; }
            public string statusType { get; set; }
            public int durationInSecondsViewed { get; set; }
            public long lastViewedAt { get; set; }
        }

        public class Exercisefile
        {
            public string name { get; set; }
            public string url { get; set; }
            public long sizeInBytes { get; set; }
        }
    }

    
}
