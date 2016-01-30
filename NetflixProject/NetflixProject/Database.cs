using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Database
    {

        //public static List<Title> AllTitles;
        //public static List<Title> ActionTitles;
        //public static List<Title> RomanceTitles;
        //public static List<Title> DramaTitles;
        public List<Genre> Genres;

        public Database()
        {
            this.Genres = new List<Genre>();
        }

        public void PopulateGenreList(Genre All, Genre Action, Genre Romance, Genre Drama)
        {
            Genres.Add (All);
            Genres.Add (Action);
            Genres.Add (Romance);
            Genres.Add (Drama);
        }
        public void PopulateAllTitlesList(Genre All)
        {
            All.ListOfTitles.Add(new Movie("Die Hard", 4, 133));
            All.ListOfTitles.Add(new Movie("Killers", 3, 98));
            All.ListOfTitles.Add(new Movie("Broke Back Mountain", 5, 180));
            All.ListOfTitles.Add(new Movie("Home Alone", 4, 7));
            All.ListOfTitles.Add(new Movie("Sex in the City", 1, 88));
            All.ListOfTitles.Add(new Movie("Deadpool", 5, 130));
            All.ListOfTitles.Add(new TV_Show("The Bachelor"));
            All.ListOfTitles.Add(new TV_Show("Chicago Code"));
            All.ListOfTitles.Add(new TV_Show("Game Of Thrones"));
        }
        public void PopulateActionTitlesList(Genre Action,Genre All)
        {
            Action.ListOfTitles.Add( All.ListOfTitles[0]);
            Action.ListOfTitles.Add(All.ListOfTitles[1]);
            Action.ListOfTitles.Add(All.ListOfTitles[5]);
            Action.ListOfTitles.Add(All.ListOfTitles[7]);
        }
        public void PopulateRomanceTitlesList(Genre Romance, Genre All)
        {
            Romance.ListOfTitles.Add(All.ListOfTitles[2]);
            Romance.ListOfTitles.Add(All.ListOfTitles[6]);
        }
        public void PopulateDramaTitlesList(Genre Drama, Genre All)
        {
            Drama.ListOfTitles.Add(All.ListOfTitles[3]);
            Drama.ListOfTitles.Add(All.ListOfTitles[4]);
            Drama.ListOfTitles.Add(All.ListOfTitles[8]);
        }

    }
}
