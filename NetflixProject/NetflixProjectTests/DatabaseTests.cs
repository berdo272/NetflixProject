using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject.Tests
{
    [TestClass()]
    public class DatabaseTests
    {
        [TestMethod()]
        public void PopulateAllTitlesListTest()
        {
            Genre All = new Genre("All");
            Movie test = new Movie("Die Hard", 4, 133);

            All.ListOfTitles.Add(new Movie("Die Hard", 4, 133));
            
            Assert.AreEqual(test.Name,All.ListOfTitles[0].Name);
            Assert.AreEqual(test.Rating, All.ListOfTitles[0].Rating);
            
        }
    }
}