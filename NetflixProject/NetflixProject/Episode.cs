using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Episode
    {
       public int Rating;
        public string Name;

        public Episode(int rating, string name)
        {
            this.Rating = rating;
            this.Name = name;
        }

    }
}
