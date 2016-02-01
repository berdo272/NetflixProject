using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Genre : IEnumerable
    {
        
        public List<Title> ListOfTitles;
        public string Name;

        public Genre(string name)
        {
            this.Name = name;
            this.ListOfTitles = new List<Title>();
        }

        public Genre(Genre genre1,Genre genre2)
        {
         
        }
        public IEnumerator GetEnumerator()
        {
            foreach(Title title in ListOfTitles)
            {
                yield return title;
            }
        }

        //public static Genre operator +(Genre genre1,Genre genre2)
        //{
        //    return new Genre(genre1 + genre2);
        //}
        //public static Genre operator +(Genre genre, Title title)
        //{
        //    return new Genre(genre + title);
        //}
    }
}
