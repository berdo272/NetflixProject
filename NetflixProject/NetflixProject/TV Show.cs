using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class TV_Show : Title
    {
        List<Episode> Episodes;

            

        public new int Rating;
        private int ratings;
        Random rnd = new Random();
        
        public TV_Show(string name)
        {
            
            this.Name = name;
            PopulateEpisodeList();
            GetAverageRatingOfEpisodes();
        }


        public void PopulateEpisodeList()
        {
            int RandomRating1;
            int RandomRating2;
            int RandomRating3;
            int RandomRating4;
            RandomRating1 = rnd.Next(0, 5);
            RandomRating2 = rnd.Next(0, 5);
            RandomRating3 = rnd.Next(0, 5);
            RandomRating4 = rnd.Next(0, 5);

            this.Episodes = new List<Episode>() { new Episode(RandomRating1, "Episode 1"), new Episode(RandomRating2, "Episode 2"), new Episode(RandomRating3, "Episode 2"), new Episode(RandomRating4, "Episode 2") };
        }

        public void GetAverageRatingOfEpisodes()
        {
            
            foreach(Episode episode in Episodes)
            {
                ratings += episode.Rating;
            }

            this.Rating = ratings / Episodes.Count;
        }
        public override string ToString()
        {

            return (Name + " Rating : " + Rating.ToString());
        }

    }
}
