using LinkedInLearningDownloader.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace LinkedInLearningDownloader
{
    class Program
    {

        private static readonly string username = "user@email.com";
        private static readonly string password = "password";
        static void Main(string[] args)
        {
            var cookieJar = new CookieContainer();
            var handler = new HttpClientHandler
            {
                CookieContainer = cookieJar,
                UseCookies = true,
            };

            var client = new HttpClient(handler);

            loginAccount(client, cookieJar, username, password);


            // course names to download - you can extract them manually from the web ui from pluralsights. Below are some examples
            var slugs = new string[] {
                "project-management-foundations-4"
                ,"cert-prep-project-management-professional-pmp"
                ,"agile-foundations"
                ,"scrum-the-basics"
                ,"learning-jira-software-3"
                ,"planning-and-releasing-software-with-jira"
                ,"agile-software-development"
                ,"agile-software-development-scrum-for-developers"
                ,"agile-software-development-kanban-for-developers"
                ,"characteristics-of-a-great-scrum-master"
                ,"scrum-advanced"
                ,"devops-foundations"
                ,"agile-testing-2"
                ,"cert-prep-scrum-master"
                ,"jira-software-advanced-administration"
            };
            foreach (var slug in slugs)
            {                
                var getCourseDetailsResponse = client.GetAsync("https://www.linkedin.com/learning-api/detailedCourses?fields=chapters,fullCourseUnlocked,releasedOn,exerciseFileUrls,exerciseFiles&addParagraphsToTranscript=true&courseSlug=" + slug + "&q=slugs").Result;
                var getCourseDetailsResponceContent = getCourseDetailsResponse.Content.ReadAsStringAsync().Result;

                var courses = Newtonsoft.Json.JsonConvert.DeserializeObject<GetCourse>(getCourseDetailsResponceContent);
                foreach (var exerciseFile in courses.elements[0].exerciseFiles)
                {
                    System.IO.Directory.CreateDirectory(slug + "\\" + "Exercise");
                    var response = client.GetAsync(exerciseFile.url).Result;

                    using (var fs = new FileStream(slug + "\\" + "Exercise" + "\\" + exerciseFile.name, FileMode.Create))
                    {
                        response.Content.CopyToAsync(fs).Wait();
                    }
                    // sleep some time do avoid behaiving like a bot
                    Thread.Sleep(new Random().Next(10, 15) * 10);
                }

                foreach (var chapter in courses.elements[0].chapters)
                {
                    System.IO.Directory.CreateDirectory(slug + "\\" + chapter.title.Replace("?","").Replace(":", ""));
                    var cnt = 1;
                    foreach (var video in chapter.videos)
                    {
                        var filename = video.title + ".mp4";
                        {
                            var getVideoDetailsResponse = client.GetAsync("https://www.linkedin.com/learning-api/detailedCourses?addParagraphsToTranscript=false&courseSlug=" + slug + "&q=slugs&resolution=_720&videoSlug=" + video.slug).Result;
                            var getVideoDetailsResponseContent = getVideoDetailsResponse.Content.ReadAsStringAsync().Result;

                            var videoDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<GetVideo>(getVideoDetailsResponseContent);
                            var videoUrl = videoDetails.elements[0].selectedVideo.url.progressiveUrl;
                            var subtitles = videoDetails.elements[0].selectedVideo.transcript;

                            var response = client.GetAsync(videoUrl).Result;

                            using (var fs = new FileStream(slug + "\\" + chapter.title.Replace("?", "").Replace(":", "") + "\\" + cnt + ". " + filename.Replace(":","").Replace("\"", "").Replace("/", "").Replace("?", ""), FileMode.Create))
                            {
                                response.Content.CopyToAsync(fs).Wait();
                            }

                            string subtitle = "";
                            if (subtitles != null)
                            {
                                for (int i = 0; i < subtitles.lines.Length; i++)
                                {
                                    var startAt = TimeSpan.FromMilliseconds(subtitles.lines[i].transcriptStartAt).ToString("hh\\:mm\\:ss\\,fff");
                                    var endAt = TimeSpan.FromMilliseconds(i + 1 < subtitles.lines.Length ? subtitles.lines[i + 1].transcriptStartAt : video.durationInSeconds * 1000).ToString("hh\\:mm\\:ss\\,fff");
                                    subtitle += i + 1 + "\n";
                                    subtitle += startAt + " --> " + endAt + "+\n";
                                    subtitle += subtitles.lines[i].caption + "\n\n";
                                }
                                File.WriteAllText(slug + "\\" + chapter.title.Replace("?", "").Replace(":", "") + "\\" + cnt + ". " + filename.Replace(":", "").Replace("\"", "").Replace("/", "").Replace("?", "") + ".srt", subtitle);
                            }
                            // sleep some time do avoid behaiving like a bot
                            Thread.Sleep(new Random().Next(10, 15) * 1000);
                        }
                        cnt++;
                    }
                }
            }
        }

        private static void loginAccount(HttpClient client, CookieContainer cookieJar, string username, string password)
        {
            var result = client.GetAsync("https://www.linkedin.com/").Result;
            var content = result.Content.ReadAsStringAsync().Result;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(content);
            var node = doc.DocumentNode.SelectSingleNode("//input[@name='loginCsrfParam']").GetAttributeValue("value", null);



            var nvc = new List<KeyValuePair<string, string>>();
            nvc.Add(new KeyValuePair<string, string>("session_key", username));
            nvc.Add(new KeyValuePair<string, string>("session_password", password));
            nvc.Add(new KeyValuePair<string, string>("loginCsrfParam", node));
            nvc.Add(new KeyValuePair<string, string>("isJsEnabled", "False"));


            client.PostAsync("https://www.linkedin.com/uas/login-submit", new FormUrlEncodedContent(nvc)).Wait();

            var cookies = cookieJar.GetCookies(new Uri("https://www.linkedin.com"));

            var csrfId = cookies["JSESSIONID"];
            client.DefaultRequestHeaders.Add("csrf-token", csrfId.Value.Trim('\"'));
        }
    }
}
