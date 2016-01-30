using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Title
    {
        public string Name;
        public int? Rating;
        public Genre Genre;

        public Title()
        {
            this.Name = null;
            this.Rating = null;
            this.Genre = null;
        }
        public Title(string name, int rating, Genre genre)
        {
            this.Name = name;
            this.Rating = rating;
            this.Genre = genre;
        }

    }
}
