using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
   public class View
    {
        
        public void DisplayGenresAndTitles(List<Genre> Genres)
        {
            foreach (Genre genre in Genres)
            {
                Console.WriteLine(genre.Name);
                foreach (Title title in genre)
                {
                    Console.WriteLine(title.ToString());
                }
            }
        }

    }
}
