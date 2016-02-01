using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            View view = new View();
            Genre All = new Genre("All");
            Genre Action = new Genre("Action");
            Genre Romance = new Genre("Romance");
            Genre Drama = new Genre("Drama");

            database.PopulateAllTitlesList(All);
            database.PopulateActionTitlesList(Action,All);
            database.PopulateRomanceTitlesList(Romance,All);
            database.PopulateDramaTitlesList(Drama,All);
            database.PopulateGenreList(All,Action,Romance,Drama);
            view.DisplayGenresAndTitles(database.Genres);

            Console.ReadKey();
            
            
        }

    }
}
