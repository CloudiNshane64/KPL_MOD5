using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul5_1302204082
{
    class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo tube = new SayaTubeVideo();
            tube.PrintVideoDetails();
            tube.IncreaseplayCount(1);
            tube.PrintVideoDetails();
        }

    }
    public class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo()
        {
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;
        }
        public void IncreaseplayCount(int angka)
        {
            playCount = playCount + angka;
        }
        public int GetPlaycount()
        {
            return playCount;
        }
        public string GetTitle()
        {
            return title;
        }
        public void printVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }

        internal void PrintVideoDetails()
        {
            throw new NotImplementedException();
        }
    }
    public class SayaTubeUser
    {
        int id;
        private List<SayaTubeVideo> uploadedVideo;
        string Username;

        public SayaTubeUser(string profile)
        {
            this.Username = profile;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            uploadedVideo = new List<SayaTubeVideo>();
        }
        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideo.Add(video);
        }

        public void printAllvideoplayCount()
        {
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine("username:" + Username);
                Console.WriteLine("video:" + (i + 1) + ":" + uploadedVideo[i]);
            }
        }
    }
}
